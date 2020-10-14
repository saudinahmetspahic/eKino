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
    public partial class frmRezervacijaPregled : Form
    {
        private readonly ApiService _rezervacijeService = new ApiService("Rezervacija");
        private readonly ApiService _projekcijeService = new ApiService("Projekcija");
        private readonly ApiService _kupciService = new ApiService("Korisnik");
        private readonly ApiService _filmoviService = new ApiService("Film");
        private readonly ApiService _dvoraneService = new ApiService("Dvorana");

        private Korisnik k;
        private List<Rezervacija> rezervacije;
        private List<Projekcija> projekcije;
        private List<Film> filmovi;
        private List<Dvorana> dvorane;

        private int DeleteRowId = -1;

        public frmRezervacijaPregled()
        {
            InitializeComponent();

        }

        private void PopuniTabelu()
        {
            var source = new List<object>();
            var i = 1;
            foreach (var r in rezervacije)
            {
                var p = projekcije.Where(w => w.Id == r.ProjekcijaId).FirstOrDefault();

                if (!cbxNeaktivne.Checked)
                {
                    if (p.DatumProjekcije.CompareTo(DateTime.Now) < 0)
                        continue;
                }
                if (!cbxAktivne.Checked)
                {
                    if (p.DatumProjekcije.CompareTo(DateTime.Now) > 0)
                        continue;
                }

                source.Add(new
                {
                    Id = r.Id,
                    RedniBroj = i,
                    DatumRezervacije = r.DatumKreirnja,
                    Film = filmovi.Where(w => w.Id == p.FilmId).Select(s => s.Naziv).FirstOrDefault(),
                    Dvorana = dvorane.Where(w => w.Id == p.DvoranaId).Select(s => s.Naziv).FirstOrDefault(),
                    Cijena = p.CijenaUlaznice,
                    DatumProjekcije = p.DatumProjekcije,
                    Sjediste = (Convert.ToChar(r.SjedisteRed + 65)).ToString() + "/" + (r.SjedisteKolona + 1)
                });
                i++;
            }
            source.OrderBy(o => 4);
            dgvListaRezervacija.DataSource = source;
            if (dgvListaRezervacija.ColumnCount > 0) // pravi bug kad je lista prazna (nema kolona u tabeli)
                dgvListaRezervacija.Columns[0].Visible = false;
        }

        private void frmRezervacijaPregled_Load(object sender, EventArgs e)
        {
            k = _kupciService.Get<List<Korisnik>>(new KorisnikLoginRequest { Email = ApiService.Email, Password = ApiService.Sifra }).FirstOrDefault();
            rezervacije = _rezervacijeService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = k.Id });
            projekcije = _projekcijeService.Get<List<Projekcija>>();
            filmovi = _filmoviService.Get<List<Film>>();
            dvorane = _dvoraneService.Get<List<Dvorana>>();

            var l = _projekcijeService.Get<List<Projekcija>>();
            l.Insert(0, new Projekcija { Opis = "Odaberi projekciju" });
            cbxListaProjZaDodavanjePrez.DataSource = l;
            cbxListaProjZaDodavanjePrez.ValueMember = "Id";
            cbxListaProjZaDodavanjePrez.DisplayMember = "Opis";

            PopuniTabelu();
        }

        private void cbxAktivne_Click(object sender, EventArgs e)
        {
            PopuniTabelu();
        }

        private void cbxNeaktivne_Click(object sender, EventArgs e)
        {
            PopuniTabelu();
        }

        private void bttnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            var p = _projekcijeService.GetById<Projekcija>((int)cbxListaProjZaDodavanjePrez.SelectedValue);
            if (p != null)
            {
                var frm = new frmRezervacijaDodavanje(p);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Close();
            }

            //var k = _kupciService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            //var p = _projekcijeService.GetById<Projekcija>((int)cbxListaProjZaDodavanjePrez.SelectedValue);
            //foreach (var rez in rezervacije) // vec dodana rezervacija
            //{
            //    if (rez.ProjekcijaId == p.Id)
            //        return;
            //}
            //var r = new RezervacijaInsertRequest
            //{
            //    DatumKreirnja = DateTime.Now,
            //    ProjekcijaId = p.Id,
            //    KupacId = k.Id                
            //};
            //_rezervacijeService.Add(r);
            //rezervacije = _rezervacijeService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = k.Id });
            //PopuniTabelu();
        }

        private void dgvListaRezervacija_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tblPotvrda.Visible = true;
            DeleteRowId = (int)dgvListaRezervacija.SelectedRows[0].Cells[0].Value;
        }

        private void bttnNe_Click(object sender, EventArgs e)
        {
            tblPotvrda.Visible = false;
        }

        private void bttnDa_Click(object sender, EventArgs e)
        {
            if (DeleteRowId <= 0)
                return;
            _rezervacijeService.Remove(DeleteRowId);
            tblPotvrda.Visible = false;
            rezervacije = _rezervacijeService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = k.Id }).Where(w => w.Id != DeleteRowId).ToList();
            PopuniTabelu();
        }
    }
}
