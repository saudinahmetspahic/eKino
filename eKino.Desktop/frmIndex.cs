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
    public partial class frmIndex : Form
    {
        private readonly ApiService _apiService = new ApiService("Film");
        public frmIndex()
        {
            InitializeComponent();
        }

        private async void bttnLogin_Click(object sender, EventArgs e)
        {
            var ime = txtKorisnickoIme.Text;
            ApiService _korisnikApiService = new ApiService("Korisnik");
            var korisnik = await _korisnikApiService.GetByIme<Korisnik>(ime);
            if(korisnik != null)
            {
                MessageBox.Show("Uspijesno ste se logirali");

            } 
            else
            {
                var registracija = new frmRegistracija();
                registracija.Show();
            }
        }

        private void bttnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija forma = new frmRegistracija();
            forma.Show();
        }
    }
}
