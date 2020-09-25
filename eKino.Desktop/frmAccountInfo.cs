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
using System.Windows;
using System.Windows.Forms;

namespace eKino.Desktop
{
    public partial class frmAccountInfo : Form
    {
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _paketService = new ApiService("Paket");
        private readonly ApiService _ocijenaService = new ApiService("Ocijena");
        private readonly ApiService _rezervacijaService = new ApiService("Rezervacija");
        private readonly ApiService _ulogaService = new ApiService("Uloga");
        private readonly ApiService _komentarService = new ApiService("Komentar");
        private readonly ApiService _komentarReakcijaService = new ApiService("KomentarReakcija");
        public frmAccountInfo()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            ApiService.Email = "";
            ApiService.Sifra = "";
            frmLogin frm = new frmLogin();
            frm.Show();
            this.MdiParent.Close();
            //this.Close();
        }

        private void bttnUredi_Click(object sender, EventArgs e)
        {
            frmUrediAccount frm = new frmUrediAccount();
            frm.MdiParent = this.MdiParent;
            frm.Show();
            this.Close();
        }

        private void frmAccountInfo_Load(object sender, EventArgs e)
        {
            var req = new KorisnikSearchRequest { Email = ApiService.Email };
            var k = _korisnikService.Get<List<Korisnik>>(req).FirstOrDefault();


            if(k != null)
            {
                lblImePrezime.Text = k.Ime + " " + k.Prezime;
                lblDatumRegistracije.Text = k.DatumRegistracije.ToString("dd-MM-yyyy");
                var search = new KorisnikPaketSearchRequest { KorisnikId = k.Id };
                lblPaket.Text = _paketService.Get<List<Paket>>(search).FirstOrDefault()?.Opis ?? "-";
                lblBrojOcijena.Text = _ocijenaService.Get<List<Ocijena>>(new OcijenaSearchRequest { KorisnikId = k.Id })?.Count.ToString();
                lblBrojRezervacija.Text = _rezervacijaService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = k.Id })?.Count.ToString();
                var komentari = _komentarService.Get<List<Komentar>>(new KomentarSerchRequest { KomentatorId = k.Id });
                var maxReakcija = 0;
                string kom = "";
                foreach (var komentar in komentari)
                {
                    var reakcije = _komentarReakcijaService.Get<List<KomentarReakcija>>(new KomentarReakcijaSearch { KomentarId = komentar.Id, Reakcija = Model.Requests.ReakcijaTip.Like });
                    int brojReakcija = reakcije.Count;
                    if(brojReakcija >= maxReakcija)
                    {
                        maxReakcija = brojReakcija;
                        kom = komentar.SadrzajKomentara;
                    }
                }
                lblNajpopularnijiKomentar.Text = "[Likes: " + maxReakcija.ToString() + "] Komentar: " + kom;
                lblUloga.Text = _ulogaService.GetById<Uloga>(k.UlogaId).NazivUloge;
            }
        }
    }
}
