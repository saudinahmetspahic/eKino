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

namespace eKino.Desktop
{
    public partial class frmPocetna : Form
    {
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
    }
}
