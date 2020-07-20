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
            bttnPaketIzbrisi.Hide();
            bttnPaketDodaj.Hide();
            bttnPaketAktuelno.Hide();
            pnlPaketiDropDownLista.Hide();

            bttnFilmAktuelno.Hide();
            bttnFilmDodaj.Hide();
            bttnFilmIzbrisi.Hide();
            pnlFilmoviDropDownLista.Hide();
        }

        private void ShowPaketButtons()
        {
            bttnPaketIzbrisi.Size = bttnPaketi.Size;
            bttnPaketIzbrisi.Show();
            bttnPaketDodaj.Size = bttnPaketi.Size;
            bttnPaketDodaj.Show();
            bttnPaketAktuelno.Size = bttnPaketi.Size;
            bttnPaketAktuelno.Show();
            var visina = bttnPaketIzbrisi.Size.Height + bttnPaketDodaj.Size.Height + bttnPaketAktuelno.Size.Height + 1;
            pnlPaketiDropDownLista.Size = new Size(bttnPaketi.Size.Width, visina);
            pnlPaketiDropDownLista.Show();
        }

        private void ShowFilmButtons()
        {
            bttnFilmAktuelno.Size = bttnPaketi.Size;
            bttnFilmIzbrisi.Show();
            bttnFilmDodaj.Size = bttnPaketi.Size;
            bttnFilmDodaj.Show();
            bttnFilmAktuelno.Size = bttnPaketi.Size;
            bttnFilmAktuelno.Show();
            var visina = bttnFilmIzbrisi.Size.Height + bttnFilmDodaj.Size.Height + bttnFilmAktuelno.Size.Height + 1;
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
                DropDownListeSakrivene = true;
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
                DropDownListeSakrivene = true;
            }
        }

        private void bttnFilmDodaj_Click(object sender, EventArgs e)
        {
            var frmFilmDodaj = new frmFilmDodaj();
            frmFilmDodaj.Show();
        }
    }
}
 