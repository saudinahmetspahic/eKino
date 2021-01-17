using eKino.Model.Helper;
using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.Desktop
{
    public partial class frmFilmDodaj : Form
    {
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _filmService = new ApiService("Film");
        private readonly ApiService _projekcijaService = new ApiService("Projekcija");
        private readonly ApiService _zanrService = new ApiService("Zanr");
        private readonly ApiService _tipService = new ApiService("Tip");
        private readonly ApiService _dvoranaService = new ApiService("Dvorana");
        private readonly ApiService _ocijenaService = new ApiService("Ocijena");

        public frmFilmDodaj()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void bttnDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                byte[] slika = null;
                if (!string.IsNullOrEmpty(txtSlikaNaziv.Text))
                    slika = ImageConvertor.ConvertImageToByteArray(Image.FromFile(txtSlikaNaziv.Text), ".jpg");
                else
                    slika = ImageHelper.GetImage("imgInitial.jpg");

                var film = new FilmInsertRequest
                {
                    DatumIzlaska = dtpDatumIzlaska.Value,
                    Naziv = txtNazivFilma.Text,
                    Opis = txtOpis.Text,
                    TipId = cbxVrsta.SelectedIndex,
                    ZanrId = cbxZanr.SelectedIndex,
                    Link = txtLink.Text,
                    Slika = slika
                };
                _filmService.Add(film);
                Task.Delay(1000);
                var dodanifilm = _filmService.Get<List<Film>>(new FilmSearchRequest { Naziv = film.Naziv }).FirstOrDefault();
                if (dodanifilm == null)
                    return;
                
                if (!string.IsNullOrEmpty(txtProjekcijaCijenaUlaznice.Text) && !string.IsNullOrEmpty(txtProjekcijaBrojKarata.Text) && cbxDvorana.SelectedIndex != 0)
                {
                    var projekcija = new ProjekcijaInsertRequest
                    {
                        DatumProjekcije = dtpDatumProjekcije.Value,
                        CijenaUlaznice = double.Parse(txtProjekcijaCijenaUlaznice.Text),
                        FilmId = dodanifilm.Id,
                        Opis = "Film: " + dodanifilm.Naziv + " Opis: " + dodanifilm.Opis,
                        DvoranaId = cbxDvorana.SelectedIndex
                    };
                    _projekcijaService.Add(projekcija);
                }

                _ocijenaService.Add(new OcijenaInsertRequest
                {
                    DataOcijena = Int32.Parse(txtOcijena.Text), 
                    FilmId = dodanifilm.Id,
                    KomentatorId = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault().Id
                });

                var form = new frmPocetna();
                form.Show();
                this.MdiParent.Close();
                this.Close();
            }
        }

        private void frmFilmDodaj_Load(object sender, EventArgs e)
        {
            var zanrovi = _zanrService.Get<List<Zanr>>();
            zanrovi.Insert(0, new Zanr { Id = 0, NazivZanra = "Odaberi zanr" });
            cbxZanr.DataSource = zanrovi;
            cbxZanr.DisplayMember = "NazivZanra";
            cbxZanr.ValueMember = "Id";

            var tipovi = _tipService.Get<List<Tip>>();
            tipovi.Insert(0, new Tip { Id = 0, NazivTipa = "Odaberi tip" });
            cbxVrsta.DataSource = tipovi;
            cbxVrsta.DisplayMember = "NazivTipa";
            cbxVrsta.ValueMember = "Id";

            var dvorane = _dvoranaService.Get<List<Dvorana>>();
            dvorane.Insert(0, new Dvorana { Id = 0, Naziv = "Odaberi dvoranu" });
            cbxDvorana.DataSource = dvorane;
            cbxDvorana.DisplayMember = "Naziv";
            cbxDvorana.ValueMember = "Id";
        }

        private void bttnSlikaDodaj_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtSlikaNaziv.Text = d.FileName;
                    //var sr = new StreamReader(d.FileName);
                    //_slika = ImageConvertor.ConvertImageToByteArray(Image.FromFile(sr.ReadToEnd()), "jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eror: Slika nije u ispravnom formatu.");
                }
            }
        }

        private void txtNazivFilma_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazivFilma.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNazivFilma, Messages.Text_Naziv);
            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpis.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtOpis, Messages.Text_Opis);
            }
        }

        private void txtLink_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLink.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtLink, Messages.Text_Link);
            }
        }

        private void txtProjekcijaCijenaUlaznice_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProjekcijaCijenaUlaznice.Text) ||
                !string.IsNullOrEmpty(txtProjekcijaBrojKarata.Text) ||
                cbxDvorana.SelectedIndex != 0)
            {
                if (!int.TryParse(txtProjekcijaCijenaUlaznice.Text, out var i))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtProjekcijaCijenaUlaznice, Messages.Int_CijenaProjekcije);
                }
            }
        }

        private void txtProjekcijaBrojKarata_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProjekcijaCijenaUlaznice.Text) ||
                !string.IsNullOrEmpty(txtProjekcijaBrojKarata.Text) ||
                cbxDvorana.SelectedIndex != 0)
            {
                if (!int.TryParse(txtProjekcijaBrojKarata.Text, out var i) || i < 10)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtProjekcijaBrojKarata, Messages.Int_BrojKarata);
                }
            }
        }

        private void cbxZanr_Validating(object sender, CancelEventArgs e)
        {
            if (cbxZanr.SelectedIndex == 0)
            {   
                e.Cancel = true;
                errorProvider.SetError(cbxZanr, Messages.CBX_Zanr);
            }
        }

        private void cbxVrsta_Validating(object sender, CancelEventArgs e)
        {
            if (cbxVrsta.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbxVrsta, Messages.CBX_Vrsta);
            }
        }

        private void cbxDvorana_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProjekcijaCijenaUlaznice.Text) ||
                !string.IsNullOrEmpty(txtProjekcijaBrojKarata.Text) ||
                cbxDvorana.SelectedIndex != 0)
            {
                if (cbxDvorana.SelectedIndex == 0)
                {
                    e.Cancel = true;
                    errorProvider.SetError(cbxDvorana, Messages.CBX_Zanr);
                }
            }
        }
    }
}
