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

namespace eKino.Desktop
{
    public partial class frmRegistracija : Form
    {
        private readonly ApiService _korisnikApiService = new ApiService("Korisnik");
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void bttnRegistrujSe_Click(object sender, EventArgs e)
        {
            var _gradApiService = new ApiService("Grad");
            var grad = _gradApiService.GetByName<Grad>(txtGrad.Text);
            if (grad == null)
            {
                grad = new Grad
                {
                    Naziv = txtGrad.Text
                };
                _gradApiService.Add(grad);
            }
            var korisnik = new Korisnik
            {
                DatumRegistracije = DateTime.Now,
                DatumRodjenja = dtpDatumRodjenja.Value,
                Email = txtEmail.Text,
                Lozinka = txtSifra.Text,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Biografija = "Dopuni",
                GradId = grad.Id
            };
            _korisnikApiService.Add(korisnik);
            MessageBox.Show("Uspijesno ste se registrovali na sistem");
            var loginForma = new frmIndex();
            loginForma.Show();
        }
    }
}
