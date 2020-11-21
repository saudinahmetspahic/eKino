using eKino.Model;
using eKino.Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Forms.Xaml;
using eKino.Model.Requests;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace eKino.Desktop
{
    public partial class frmPocetna : Form
    {
        //private ApiService _korisnikApiService = new ApiService("Korisnik");
        //private ApiService _rezervacijeApiService = new ApiService("Rezervacija");
        //private ApiService _projekcijaApiService = new ApiService("Projekcija");
        private bool DropDownListeSakrivene;
        public frmPocetna()
        {
            InitializeComponent();
            DropDownListeSakrivene = true;
        }


        private void HideButtons()
        {
            bttnPaketDodaj.Hide();
            bttnPaketAktuelno.Hide();
            pnlPaketiDropDownLista.Hide();

            bttnFilmAktuelno.Hide();
            bttnFilmDodaj.Hide();
            pnlFilmoviDropDownLista.Hide();
        }

        private void ShowPaketButtons()
        {
            bttnPaketDodaj.Size = bttnPaketi.Size;
            bttnPaketDodaj.Show();
            bttnPaketAktuelno.Size = bttnPaketi.Size;
            bttnPaketAktuelno.Show();
            var visina = bttnPaketDodaj.Size.Height + bttnPaketAktuelno.Size.Height + 1;
            pnlPaketiDropDownLista.Size = new Size(bttnPaketi.Size.Width, visina);
            pnlPaketiDropDownLista.Show();
        }

        private void ShowFilmButtons()
        {
            bttnFilmDodaj.Size = bttnPaketi.Size;
            bttnFilmDodaj.Show();
            bttnFilmAktuelno.Size = bttnPaketi.Size;
            bttnFilmAktuelno.Show();
            var visina = bttnFilmDodaj.Size.Height + bttnFilmAktuelno.Size.Height + 1;
            pnlFilmoviDropDownLista.Size = new Size(bttnFilmovi.Size.Width, visina);
            pnlFilmoviDropDownLista.Location = new Point(tblMeni.Location.X + tblMeni.Width - bttnFilmovi.Width - 1, pnlFilmoviDropDownLista.Location.Y);
            pnlFilmoviDropDownLista.Show();
        }

        private void bttnPaketi_Click(object sender, EventArgs e)
        {
            if (DropDownListeSakrivene)
            {
                ShowPaketButtons();
                DropDownListeSakrivene = false;
            }
            else
            {
                HideButtons();
                ShowPaketButtons();
            }
        }

        private void bttnFilmovi_Click(object sender, EventArgs e)
        {
            if (DropDownListeSakrivene)
            {
                ShowFilmButtons();
                DropDownListeSakrivene = false;
            }
            else
            {
                HideButtons();
                ShowFilmButtons();
            }
        }

        private void bttnFilmDodaj_Click(object sender, EventArgs e)
        {
            var frmFilmDodaj = new frmFilmDodaj();
            ZatvoriProzore();
            frmFilmDodaj.MdiParent = this;
            pnlPozadina.Hide();
            frmFilmDodaj.Show();
            HideButtons();
        }

        private void rpbAvatar_Click(object sender, EventArgs e)
        {
            frmAccountInfo frm = new frmAccountInfo();
            ZatvoriProzore();
            frm.MdiParent = this;
            pnlPozadina.Hide();
            frm.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            HideButtons();
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            HideButtons();
            ZatvoriProzore();
            pnlPozadina.Show();
        }

        private void bttnFilmAktuelno_Click(object sender, EventArgs e)
        {
            var frmFilmPregled = new frmFilmPregled();
            ZatvoriProzore();
            frmFilmPregled.MdiParent = this;
            pnlPozadina.Hide();
            frmFilmPregled.Show();
            HideButtons();
        }

        private void frmPocetna_Click(object sender, EventArgs e)
        {
            HideButtons();
        }

        private void bttnRezervacije_Click(object sender, EventArgs e)
        {
            var frm = new frmRezervacijaPregled();
            ZatvoriProzore();
            frm.MdiParent = this;
            pnlPozadina.Hide();
            frm.Show();
            HideButtons();
        }

        private void bttnPaketAktuelno_Click(object sender, EventArgs e)
        {
            var frm = new frmPaketPregled();
            ZatvoriProzore();
            frm.MdiParent = this;
            pnlPozadina.Hide();
            frm.Show();
            HideButtons();
        }

        private void ZatvoriProzore()
        {
            var children = this.MdiChildren;
            foreach (var child in children)
            {
                child.Close();
            }
        }

        private void bttnPaketDodaj_Click(object sender, EventArgs e)
        {
            var frm = new frmPaketDodaj();
            ZatvoriProzore();
            frm.MdiParent = this;
            pnlPozadina.Hide();
            frm.Show();
            HideButtons();
        }


        //private async Task Alarm_Timer()
        //{
        //    try
        //    {
        //        var k = _korisnikApiService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email }).FirstOrDefault();
        //        var rezervacije = _rezervacijeApiService.Get<List<Rezervacija>>(new RezervacijaSearchRequest { KorisnikId = k.Id });

        //        string mail = "* Rezeracije \n";
        //        int count = 0;
        //        foreach (var r in rezervacije)
        //        {
        //            var p = _projekcijaApiService.GetById<Projekcija>((int)r.ProjekcijaId);
        //            if (p.DatumProjekcije.AddHours(24).CompareTo(DateTime.Now) >= 0)
        //            {
        //                mail += " [" + p.DatumProjekcije + "] " + p.Opis + "\n";
        //                count++;
        //            }
        //        }

        //        var smtpClient = new SmtpClient("app_alarm@hotmail.com")
        //        {
        //            Port = 587,
        //            Credentials = new NetworkCredential("app_alarm@hotmail.com", "Alarm12345"),
        //            EnableSsl = true,
        //        };
        //        smtpClient.Send("app_alarm@hotmail.com", k.Email, count + " projekcija u naredna 24 sata", mail);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "Error");
        //        //await Task.Delay(10000);
        //    }

        //    //await Task.Delay(20000); // 1h = 3600000
        //}

        //private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    BackgroundWorker worker = sender as BackgroundWorker;


        //    while (worker.CancellationPending != true)
        //    {
        //        await Alarm_Timer();
        //        System.Threading.Thread.Sleep(20000);
        //    }
        //    e.Cancel = true;
        //}
    }
}
