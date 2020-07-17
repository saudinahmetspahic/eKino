using eKino.Model;
using eKino.WinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace eKino.Desktop
{
    public partial class frmRegistracija : Form
    {
        private readonly ApiService _korisnikApiService = new ApiService("Korisnik");
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private async void bttnRegistrujSe_Click(object sender, EventArgs e)
        {
            var gId = (int)cbGrad.SelectedValue;
            var korisnik = new Korisnik
            {
                DatumRegistracije = DateTime.Now,
                DatumRodjenja = dtpDatumRodjenja.Value,
                Email = txtEmail.Text,
                Lozinka = txtSifra.Text,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Biografija = "Dopuni",
                GradId = gId
            };
            _korisnikApiService.Add(korisnik);
            var dodaniKorisnik = await _korisnikApiService.GetByIme<Korisnik>(txtIme.Text);
            if (dodaniKorisnik != null)
            {
                MessageBox.Show("Uspijesno ste se registrovali na sistem");
            }
            else
            {
                MessageBox.Show("Neuspijesna registracija");
            }
            var loginForma = new frmIndex();
            loginForma.Show();
        }
    }
}
