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
    public partial class frmFilmDetalji : Form
    {
        private readonly ApiService _filmService = new ApiService("Film");
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _glumacService = new ApiService("Osoba");
        private readonly ApiService _zanrService = new ApiService("Zanr");
        private readonly ApiService _tipService = new ApiService("Tip");
        private readonly ApiService _filmglumciService = new ApiService("FilmGlumci");
        private readonly ApiService _filmscenaristiService = new ApiService("FilmScenaristi");
        private readonly ApiService _filmprkuceService = new ApiService("FilmProdukcijskeKuce");
        private readonly ApiService _filmprojekcijaService = new ApiService("FilmProjekcija");
        private readonly ApiService _prkucaService = new ApiService("ProdukcijskaKuca");
        private readonly ApiService _projekcijaService = new ApiService("Projekcija");
        private readonly ApiService _ocijenaService = new ApiService("Ocijena");
        private readonly ApiService _gradService = new ApiService("Grad");
        private readonly ApiService _ulogaService = new ApiService("Uloga");
        private readonly ApiService _dvoranaService = new ApiService("Dvorana");
        private readonly ApiService _komentarService = new ApiService("Komentar");
        private readonly ApiService _komentarReakcijaService = new ApiService("KomentarReakcija");
        private int _filmId;
        public frmFilmDetalji(int FilmId)
        {
            _filmId = FilmId;
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void frmFilmDetalji_Load(object sender, EventArgs e)
        {
            var film = _filmService.GetById<Film>(_filmId);

            //tblDodavanjeGlumca.Visible = false;

            var k = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email });
            if (k.Count == 1 && k[0].UlogaId == _ulogaService.GetByName<Uloga>("Admin").Id)
            {
                bttnDodajGlumca.Visible = true;
                bttnDodajPrKucu.Visible = true;
                bttnDodajProjekciju.Visible = true;
                bttnDodajScenaristu.Visible = true;
            }
            else
            {
                bttnDodajGlumca.Visible = false;
                bttnDodajPrKucu.Visible = false;
                bttnDodajProjekciju.Visible = false;
                bttnDodajScenaristu.Visible = false;
            }

            pbxSlika.Image = ImageConvertor.ConvertByteArrayToImage(film.Slika);
            lblZanr.Text = _zanrService.GetById<Zanr>(film.ZanrId).NazivZanra;
            lblTip.Text = _tipService.GetById<Tip>(film.TipId).NazivTipa;
            lblOpis.Text = film.Opis;
            lblDatum.Text = film.DatumIzlaska.ToString("dd/MM/yyyy");
            lblNaziv.Text = film.Naziv;
            lblProjekcija.Text = _projekcijaService.Get<List<Projekcija>>().Where(w => w.FilmId == film.Id).Select(s => s.Opis).FirstOrDefault();

            var osobe = _glumacService.Get<List<Osoba>>(new OsobaSearchRequest { Uloga = "Glumac" });

            var filmglumci = _filmglumciService.Get<List<FilmGlumci>>(new FilmGlumciSearchRequest { FilmId = _filmId });
            foreach (var f in filmglumci)
            {
                var glumac = osobe.Where(w => w.Id == f.GlumacId).FirstOrDefault();
                var l = new LinkLabel { Text = glumac.Ime + " " + glumac.Prezime };
                pnlGlumci.Controls.Add(l);
                l.Anchor = AnchorStyles.Left;
                l.TextAlign = ContentAlignment.MiddleCenter;
            }

            osobe = _glumacService.Get<List<Osoba>>(new OsobaSearchRequest { Uloga = "Scenarista" });

            var filmscenaristi = _filmscenaristiService.Get<List<FilmScenaristi>>(new FilmScenaristiSearchRequest { FilmId = _filmId });
            foreach (var f in filmscenaristi)
            {
                var scenarist = osobe.Where(w => w.Id == f.ScenaristId).FirstOrDefault();
                var l = new LinkLabel { Text = scenarist.Ime + " " + scenarist.Prezime };
                pnlScenaristi.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                pnlScenaristi.Controls.Add(l);
                //l.Dock = DockStyle.Fill;
                l.Anchor = AnchorStyles.Left;
                l.TextAlign = ContentAlignment.MiddleCenter;
            }

            var filmprkuce = _filmprkuceService.Get<List<FilmProdukcijskeKuce>>(new FilmProdukcijskeKuceSearchRequest { FilmId = _filmId });
            foreach (var f in filmprkuce)
            {
                var prkuca = _prkucaService.GetById<ProdukcijskaKuca>(f.ProdukcijskaKucaId);
                var l = new LinkLabel { Text = prkuca.Naziv };
                pnlPrKuce.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                pnlPrKuce.Controls.Add(l);
                //l.Dock = DockStyle.Fill;
                l.Anchor = AnchorStyles.Left;
                l.TextAlign = ContentAlignment.MiddleCenter;
            }

            var ocijene = _ocijenaService.Get<List<Ocijena>>(new OcijenaSearchRequest { FilmId = film.Id });
            var prosijek = ocijene.Average(a => (int?)a.DataOcijena) ?? 0;
            for (int i = 0; i < tblOcijena.ColumnCount; i++)
            {
                tblOcijena.Controls.Clear();
            }
            for (int i = 1; i <= 5; i++)
            {
                tblOcijena.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / 5));
                var l = new Label();
                tblOcijena.Controls.Add(l);
                l.Dock = DockStyle.Fill;
                if (prosijek >= i)
                {
                    l.Text = "★";
                }
                else
                {
                    l.Text = "☆";
                }
                l.Font = new Font("Microsoft Sans Serif", 24);
            }

            //komentari
            var komentari = _komentarService.Get<List<Komentar>>(new KomentarSearchRequest { FilmId = _filmId });
            var counter = 0;
            foreach (var komentar in komentari)
            {
                var komentator = _korisnikService.GetById<Korisnik>(komentar.KomentatorId);
                var reakcije = _komentarReakcijaService.Get<List<KomentarReakcija>>(new KomentarReakcijaSearchRequest { KomentarId = komentar.Id });
                var likes = reakcije.Where(w => w.Reakcija == Model.ReakcijaTip.Like).Count();
                var dislikes = reakcije.Where(w => w.Reakcija == Model.ReakcijaTip.Dislike).Count();
                DodajKomentar(komentar.Id, komentator.Ime + " " + komentator.Prezime, komentar.SadrzajKomentara, likes, dislikes);
                counter++;
                if (counter >= 10)
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttnDodajGlumca_Click(object sender, EventArgs e)
        {
            lblNoviNaslov.Text = "Novi glumac";
            OcistiTextBoxove();
            tblDodavanjeGlumca.Visible = true;
        }

        private void OcistiTextBoxove()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtBiografija.Text = "";
            dtpDatum.Value = DateTime.Now;
            txtKucaNaziv.Text = "";
            txtCijenaProjekcije.Text = "";
            txtOpisProjekcije.Text = "";
            tblDodavanjeGlumca.Visible = false;
            tblDodajPrKucu.Visible = false;
            tblDodajProjekciju.Visible = false;
            tblZaOcjenjivanjeFilma.Visible = false;
            tblZaDodavanjeKomentara.Visible = false;
            tblLikeAndDislike.Visible = false;
        }

        private void bttnDodajGlumcaOdustani_Click(object sender, EventArgs e)
        {
            OcistiTextBoxove();
        }

        private void bttnDodajGlumcaDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (cbxListGlumaca.SelectedIndex != 0)
                {
                    if (_filmglumciService.Get<List<FilmGlumci>>(new FilmGlumciSearchRequest { FilmId = _filmId, GlumacId = cbxListGlumaca.SelectedIndex }).Select(s => s.GlumacId).ToList().Count != 0)
                    {
                        OcistiTextBoxove();
                        return;
                    };
                    var g = _glumacService.GetById<Osoba>((int)cbxListGlumaca.SelectedValue);
                    _filmglumciService.Add(new FilmGlumciInsertRequest { FilmId = _filmId, GlumacId = g.Id });
                    var l = new LinkLabel { Text = g.Ime + " " + g.Prezime };
                    pnlGlumci.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    pnlGlumci.Controls.Add(l);
                    l.Anchor = AnchorStyles.Left;
                    l.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    var g = new OsobaInsertRequest
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Biografija = txtBiografija.Text,
                        DatumRodjenja = dtpDatum.Value,
                        GradId = (int)cbxGrad.SelectedValue,
                        UlogaId = _ulogaService.GetByName<Uloga>("Glumac").Id
                    };
                    var gl = _glumacService.Add<OsobaInsertRequest>(g);

                    var gId = _glumacService.Get<List<Osoba>>(new OsobaSearchRequest { Ime = g.Ime, Prezime = g.Prezime }).Select(s => s.Id).FirstOrDefault();
                    _filmglumciService.Add(new FilmGlumciInsertRequest { FilmId = _filmId, GlumacId = gId });

                    var l = new LinkLabel { Text = g.Ime + " " + g.Prezime };
                    pnlGlumci.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    pnlGlumci.Controls.Add(l);
                    l.Anchor = AnchorStyles.Left;
                    l.TextAlign = ContentAlignment.MiddleCenter;
                }
                OcistiTextBoxove();
            }
        }

        private void bttnDodajScenaristuDodaj_Click(object sender, EventArgs e)
        {
            if (cbxListGlumaca.SelectedIndex != 0)
            {
                if (_filmscenaristiService.Get<List<FilmScenaristi>>(new FilmScenaristiSearchRequest { FilmId = _filmId, ScenaristId = (int)cbxListGlumaca.SelectedValue }).Select(s => s.ScenaristId).ToList().Count != 0)
                {
                    OcistiTextBoxove();
                    return;
                }
                var g = _glumacService.GetById<Osoba>((int)cbxListGlumaca.SelectedValue);
                _filmscenaristiService.Add(new FilmScenaristiInsertRequest { FilmId = _filmId, ScenaristId = g.Id });
                var l = new LinkLabel { Text = g.Ime + " " + g.Prezime };
                pnlScenaristi.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                pnlScenaristi.Controls.Add(l);
                //l.Dock = DockStyle.Fill;
                l.Anchor = AnchorStyles.Left;
                l.TextAlign = ContentAlignment.MiddleCenter;
            }
            else
            {
                var g = new OsobaInsertRequest
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Biografija = txtBiografija.Text,
                    DatumRodjenja = dtpDatum.Value,
                    GradId = (int)cbxGrad.SelectedValue,
                    UlogaId = _ulogaService.GetByName<Uloga>("Scenarista").Id
                };
                var gl = _glumacService.Add<OsobaInsertRequest>(g);

                var gId = _glumacService.Get<List<Osoba>>(new OsobaSearchRequest { Ime = g.Ime, Prezime = g.Prezime }).Select(s => s.Id).FirstOrDefault();
                _filmscenaristiService.Add(new FilmScenaristiInsertRequest { FilmId = _filmId, ScenaristId = gId });

                var l = new LinkLabel { Text = g.Ime + " " + g.Prezime };
                pnlScenaristi.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                pnlScenaristi.Controls.Add(l);
                //l.Dock = DockStyle.Fill;
                l.Anchor = AnchorStyles.Left;
                l.TextAlign = ContentAlignment.MiddleCenter;
            }
            OcistiTextBoxove();
        }

        private void tblDodavanjeGlumca_VisibleChanged(object sender, EventArgs e)
        {
            if (tblDodavanjeGlumca.Visible == true)
            {
                if (lblNoviNaslov.Text.Contains("glumac"))
                {
                    var glumci = _glumacService.Get<List<Osoba>>(new OsobaSearchRequest { Uloga = "Glumac" });
                    glumci.Insert(0, new Osoba { Ime = "Odaberi glumca" });
                    cbxListGlumaca.DataSource = glumci;
                    cbxListGlumaca.DisplayMember = "ImePrezime";
                    cbxListGlumaca.ValueMember = "Id";
                    bttnDodajGlumcaDodaj.Click -= bttnDodajScenaristuDodaj_Click;
                    bttnDodajGlumcaDodaj.Click += bttnDodajGlumcaDodaj_Click;
                }
                else if (lblNoviNaslov.Text.Contains("scenarista"))
                {
                    var scenaristi = _glumacService.Get<List<Osoba>>(new OsobaSearchRequest { Uloga = "Scenarista" });
                    scenaristi.Insert(0, new Osoba { Ime = "Odaberi scenaristu" });
                    cbxListGlumaca.DataSource = scenaristi;
                    cbxListGlumaca.DisplayMember = "ImePrezime";
                    cbxListGlumaca.ValueMember = "Id";
                    bttnDodajGlumcaDodaj.Click -= bttnDodajGlumcaDodaj_Click;
                    bttnDodajGlumcaDodaj.Click += bttnDodajScenaristuDodaj_Click;
                }

                var gradovi = _gradService.Get<List<Grad>>();
                gradovi.Insert(0, new Grad { Naziv = "Odaberi grad" });
                cbxGrad.DataSource = gradovi;
                cbxGrad.DisplayMember = "Naziv";
                cbxGrad.ValueMember = "Id";
            }
        }

        private void bttnDodajScenaristu_Click(object sender, EventArgs e)
        {
            lblNoviNaslov.Text = "Novi scenarista";
            OcistiTextBoxove();
            tblDodavanjeGlumca.Visible = true;
        }

        private void bttnDodajPrKucuDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (cbxListKuca.SelectedIndex != 0)
                {
                    var g = _filmprkuceService.Get<List<FilmProdukcijskeKuce>>(new FilmProdukcijskeKuceSearchRequest { FilmId = _filmId, ProdukcijskaKucaId = cbxListKuca.SelectedIndex });
                    if (g.Count != 0)
                    {
                        OcistiTextBoxove();
                        return;
                    };
                    var p = _prkucaService.GetById<ProdukcijskaKuca>((int)cbxListKuca.SelectedValue);
                    _filmprkuceService.Add(new FilmProdukcijskeKuceInsertRequest { FilmId = _filmId, ProdukcijskaKucaId = p.Id });
                    var l = new LinkLabel { Text = p.Naziv };
                    pnlPrKuce.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    pnlPrKuce.Controls.Add(l);
                    //l.Dock = DockStyle.Fill;
                    l.Anchor = AnchorStyles.Left;
                    l.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                {
                    var g = new ProdukcijskaKucaInsertRequest
                    {
                        Naziv = txtKucaNaziv.Text,
                        GradId = (int)cbxKucaGrad.SelectedValue
                    };
                    var gl = _prkucaService.Add<ProdukcijskaKucaInsertRequest>(g);

                    var gId = _prkucaService.Get<List<ProdukcijskaKuca>>(new ProdukcijskaKucaSearchRequest { Naziv = g.Naziv }).Select(s => s.Id).FirstOrDefault();
                    _filmprkuceService.Add(new FilmProdukcijskeKuceInsertRequest { FilmId = _filmId, ProdukcijskaKucaId = gId });

                    var l = new LinkLabel { Text = g.Naziv };
                    pnlPrKuce.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    pnlPrKuce.Controls.Add(l);
                    //l.Dock = DockStyle.Fill;
                    l.Anchor = AnchorStyles.Left;
                    l.TextAlign = ContentAlignment.MiddleCenter;
                }
                OcistiTextBoxove();
            }
        }

        private void bttnDodajPrKucuOdustani_Click(object sender, EventArgs e)
        {
            OcistiTextBoxove();
        }

        private void tblDodajPrKucu_VisibleChanged(object sender, EventArgs e)
        {
            if (tblDodajPrKucu.Visible == true)
            {
                var prkuce = _prkucaService.Get<List<ProdukcijskaKuca>>();
                prkuce.Insert(0, new ProdukcijskaKuca { Naziv = "Odaberi pr. kucu" });
                cbxListKuca.DataSource = prkuce;
                cbxListKuca.DisplayMember = "Naziv";
                cbxListKuca.ValueMember = "Id";

                var gradovi = _gradService.Get<List<Grad>>();
                gradovi.Insert(0, new Grad { Naziv = "Odaberi grad" });
                cbxKucaGrad.DataSource = gradovi;
                cbxKucaGrad.DisplayMember = "Naziv";
                cbxKucaGrad.ValueMember = "Id";
            }
        }

        private void bttnDodajPrKucu_Click(object sender, EventArgs e)
        {
            OcistiTextBoxove();
            tblDodajPrKucu.Visible = true;
        }

        private void tblDodajProjekciju_VisibleChanged(object sender, EventArgs e)
        {
            if (tblDodajProjekciju.Visible == true)
            {
                var dvorane = _dvoranaService.Get<List<Dvorana>>();
                dvorane.Insert(0, new Dvorana { Info = "Odaberi dvoranu" });
                cbxDvoranaProjekcije.DataSource = dvorane;
                cbxDvoranaProjekcije.DisplayMember = "Info";
                cbxDvoranaProjekcije.ValueMember = "Id";
            }
        }

        private void bttnDodajProjekciju_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblProjekcija.Text)) // ako je vec dodana projekcija
                return;

            OcistiTextBoxove();
            tblDodajProjekciju.Visible = true;
        }

        private void bttnDodajProjekcijuOdustani_Click(object sender, EventArgs e)
        {
            OcistiTextBoxove();
        }

        private void bttnDodajProjekcijuDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var g = new ProjekcijaInsertRequest
                {
                    CijenaUlaznice = Int32.Parse(txtCijenaProjekcije.Text),
                    DatumProjekcije = dtpDatumProjekcije.Value,
                    DvoranaId = (int)cbxDvoranaProjekcije.SelectedValue,
                    FilmId = _filmId,
                    Opis = txtOpisProjekcije.Text
                };
                _projekcijaService.Add<ProjekcijaInsertRequest>(g);

                lblProjekcija.Text = g.DatumProjekcije.ToString("dd/MM/yyyy") + " - " + g.CijenaUlaznice.ToString() + "KM - " + g.Opis;
                OcistiTextBoxove();
            }
        }

        private void bttnDodajKomentar_Click(object sender, EventArgs e)
        {
            OcistiTextBoxove();
            tblZaDodavanjeKomentara.Visible = true;
        }

        private void bttnOcijeniFilm_Click(object sender, EventArgs e)
        {
            OcistiTextBoxove();
            tblZaOcjenjivanjeFilma.Visible = true;
        }

        private void tblZaOcjenjivanjeFilma_VisibleChanged(object sender, EventArgs e)
        {
            if (tblZaOcjenjivanjeFilma.Visible == true)
            {
                var ocijene = new[] {
                    new{ Id = 1, Ocijena = "★☆☆☆☆ (1)" },
                    new{ Id = 2, Ocijena = "★★☆☆☆ (2)" },
                    new{ Id = 3, Ocijena = "★★★☆☆ (3)" },
                    new{ Id = 4, Ocijena = "★★★★☆ (4)" },
                    new{ Id = 5, Ocijena = "★★★★★ (5)" }
                };
                cbxListOcijena.DataSource = ocijene;
                cbxListOcijena.DisplayMember = "Ocijena";
                cbxListOcijena.ValueMember = "Id";
            }
        }

        private void bttnPotvrdiOcijenu_Click(object sender, EventArgs e)
        {
            var ocijena = (int)cbxListOcijena.SelectedValue;
            var komentator = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            if (_ocijenaService.Get<List<Ocijena>>(new OcijenaSearchRequest { FilmId = _filmId, KorisnikId = komentator.Id }).Count() > 0)
                return;
            _ocijenaService.Add(new OcijenaInsertRequest
            {
                DataOcijena = ocijena,
                FilmId = _filmId,
                KomentatorId = komentator.Id,
            });
            OcistiTextBoxove();
        }

        private void bttnOdustaniOdOcijenjivanja_Click(object sender, EventArgs e)
        {
            OcistiTextBoxove();
        }

        private void bttnPotvrdiKomentar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var komentar = txtKomentar.Text;
                var komentator = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
                _komentarService.Add(new KomentarInsertRequest
                {
                    FilmId = _filmId,
                    KomentatorId = komentator.Id,
                    SadrzajKomentara = komentar
                });
                OcistiTextBoxove();
            }
        }

        private void bttnOdustaniOdKomentara_Click(object sender, EventArgs e)
        {
            OcistiTextBoxove();
        }

        private void ZatvoriTblLikeAndDislike(object sender, EventArgs e)
        {
            tblLikeAndDislike.Visible = false;
        }

        private void KomentarClick_Click(object sender, EventArgs e)
        {
            tblLikeAndDislike.Visible = true;
            tblLikeAndDislike.Name = ((Label)sender).Name;
            var timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += ZatvoriTblLikeAndDislike;
        }

        private void OcijeniKomentar(int komentarId, Model.Requests.ReakcijaTip reakcija)
        {
            var komentator = _korisnikService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
            if (_komentarReakcijaService.Get<List<KomentarReakcija>>(new KomentarReakcijaSearchRequest { KorisnikId = komentator.Id, KomentarId = komentarId }).Count() > 0)
                return;

            _komentarReakcijaService.Add(new KomentarReakcijaInsertRequest
            {
                KomentarId = komentarId,
                KorisnikId = komentator.Id,
                Reakcija = reakcija
            });
            OcistiTextBoxove();
        }

        private void bttnLike_Click(object sender, EventArgs e)
        {
            var komentarId = Int32.Parse(tblLikeAndDislike.Name);
            OcijeniKomentar(komentarId, Model.Requests.ReakcijaTip.Like);
            OcistiTextBoxove();
        }

        private void bttnDislike_Click(object sender, EventArgs e)
        {
            var komentarId = Int32.Parse(tblLikeAndDislike.Name);
            OcijeniKomentar(komentarId, Model.Requests.ReakcijaTip.Dislike);
            OcistiTextBoxove();
        }

        private void bttnPotvrdiKomentar_Validating(object sender, CancelEventArgs e)
        {
            if (txtKomentar.TextLength < 3 || txtKomentar.TextLength > 200)
            {
                e.Cancel = true;
                errorProvider.SetError(txtKomentar, Messages.Text_Length_3_200);
            }
        }

        private void txtBiografija_Validating(object sender, CancelEventArgs e)
        {
            if (txtBiografija.TextLength < 3 || txtBiografija.TextLength > 200)
            {
                e.Cancel = true;
                errorProvider.SetError(txtBiografija, Messages.Text_Length_3_200);
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtIme, Messages.Text_Ime);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPrezime, Messages.Text_Prezime);
            }
        }

        private void txtKucaNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKucaNaziv.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtKucaNaziv, Messages.Text_PrKuca);
            }
        }

        private void txtCijenaProjekcije_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtCijenaProjekcije.Text, out var i))
            {
                e.Cancel = true;
                errorProvider.SetError(txtCijenaProjekcije, Messages.Int_CijenaProjekcije);
            }
        }

        private void txtOpisProjekcije_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtOpisProjekcije.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtOpisProjekcije, Messages.Text_Opis);
            }
        }
    }
}

