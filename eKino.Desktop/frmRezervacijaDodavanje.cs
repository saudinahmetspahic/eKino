using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.Desktop
{
    public partial class frmRezervacijaDodavanje : Form
    {
        private Projekcija _projekcija;
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _dvoranaService = new ApiService("Dvorana");
        private readonly ApiService _rezervacijaService = new ApiService("Rezervacija");
        private readonly ApiService _paketService = new ApiService("Paket");
        private readonly ApiService _korisnikPaketService = new ApiService("KorisnikPaket");

        private Korisnik _korisnik;
        private KorisnikPaket _korisnikPaket;
        private List<Sjediste> _zauzetaSjedista = new List<Sjediste>();
        private List<Sjediste> _rezervisanaSjedista = new List<Sjediste>();
        public frmRezervacijaDodavanje(Projekcija projekcija)
        {
            _korisnik = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            _korisnikPaket = _korisnikPaketService.Get<List<KorisnikPaket>>(new KorisnikPaketSearchRequest { KorisnikId = _korisnik.Id }).FirstOrDefault();
            _projekcija = projekcija;
            InitializeComponent();
        }

        public class Sjediste
        {
            public int KorisnikId;
            public int Red;
            public int Kolona;

            public override bool Equals(object obj)
            {
                return Red == ((Sjediste)obj).Red && Kolona == ((Sjediste)obj).Kolona;
            }

            public override int GetHashCode()
            {
                return ((Red * Kolona) + 1).GetHashCode();
            }
        }

        private void InicirajTabele()
        {
            var dvorana = _dvoranaService.GetById<Dvorana>(_projekcija.DvoranaId);
            var sjedista = _rezervacijaService.Get<List<Rezervacija>>(new RezervacijaSearchRequest
            {
                ProjekcijaId = _projekcija.Id
            });
            //var zauzetaSjedista = new List<Sjediste>();
            foreach (var sjediste in sjedista)
            {
                _zauzetaSjedista.Add(new Sjediste { KorisnikId = (int)sjediste.KupacId, Red = sjediste.SjedisteRed, Kolona = sjediste.SjedisteKolona });
            }
            GenerisiPolja(tblSjedista.Width, tblSjedista.Height, dvorana.BrojRedova, dvorana.BrojKolona, _zauzetaSjedista);
            UpdateTextBoxove();
        }

        private void frmRezervacijaDodavanje_Load(object sender, EventArgs e)
        {
            InicirajTabele();
        }

        private void UpdateTextBoxove(bool _inicirajTabele = false)
        {
            var zauzetaMjesta = _zauzetaSjedista.Where(w => w.KorisnikId == _korisnik.Id).Count();
            txtBrojRezervacija.Text = (_rezervisanaSjedista.Count() + zauzetaMjesta).ToString();
            var cijena = _projekcija.CijenaUlaznice;
            var ukupnaCijena = ((_rezervisanaSjedista.Count() + zauzetaMjesta)  * cijena);
            if(_korisnikPaket != null)
            {
                var paket = _paketService.GetById<Paket>(_korisnikPaket.PaketId);
                ukupnaCijena -= (double)(paket.Cijena * 0.1);
                if (ukupnaCijena < 0)
                    ukupnaCijena = 0;
            }
            txtUkupnaCijena.Text = ukupnaCijena + "KM";
            if (_inicirajTabele)
                InicirajTabele();
        }

        private void PointClick_Click(object sender, EventArgs e)
        {
            var n = ((Label)sender).Name.Split('/');
            var red = Int32.Parse(n[0]);
            var kolona = Int32.Parse(n[1]);
            var s = new Sjediste { Red = red, Kolona = kolona };
            if (_zauzetaSjedista.Contains(s) == true)
            {
                return;
            }
            if (_rezervisanaSjedista.Contains(s) == true)
            {
                _rezervisanaSjedista.Remove(s);
                ((Label)sender).ForeColor = Color.FromArgb(113, 217, 154);
            }
            else
            {
                _rezervisanaSjedista.Add(s);
                ((Label)sender).ForeColor = Color.FromArgb(230, 92, 92);
            }
            UpdateTextBoxove();
        }

        private void bttnPonistiRezervacije_Click(object sender, EventArgs e)
        {
            _rezervisanaSjedista.Clear();
            UpdateTextBoxove(true);
        }

        private void VratiSeNaIspis()
        {
            var frm = new frmRezervacijaPregled();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }

        private void bttnOdustaniOdRezervacije_Click(object sender, EventArgs e)
        {
            VratiSeNaIspis();
        }

        private void bttnPotvrdiRezervacije_Click(object sender, EventArgs e)
        {
            //var _korisnikId = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            foreach (var r in _rezervisanaSjedista)
            {
                _rezervacijaService.Add(new RezervacijaInsertRequest
                {
                    DatumKreirnja = DateTime.Now,
                    ProjekcijaId = _projekcija.Id,
                    SjedisteRed = r.Red,
                    SjedisteKolona = r.Kolona,
                    KupacId = _korisnik.Id
                });                    
            }
            VratiSeNaIspis();
        }
    }
}
