using eKino.Model;
using eKino.Desktop;
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
    public partial class frmLogin : Form
    {
        private readonly ApiService _apiService = new ApiService("Korisnik");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            ApiService.Email = txtEmail.Text;
            ApiService.Sifra = txtSifra.Text;
            try
            {
                var r = _apiService.Get<List<Korisnik>>();
                frmPocetna frm = new frmPocetna();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: Problem sa autentifikacijom.\n" + ex.Message);
                this.Focus();
            }
        }

        private void bttnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija forma = new frmRegistracija();
            forma.Show();
            //Close();
        }
    }
}
