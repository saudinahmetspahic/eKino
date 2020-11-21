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
using eKino.Model.Requests;
using Flurl.Http;
using eKino.Desktop.Izvjestaji;
using System.Net.Mail;

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
            if (this.ValidateChildren())
            {
                ApiService.Email = txtEmail.Text;
                ApiService.Sifra = txtSifra.Text;
                try
                {
                    var r = _apiService.Get<List<Korisnik>>(new KorisnikSearchRequest { Email = ApiService.Email });
                    if (r.Count == 1)
                    {
                        var frm = new frmPocetna();
                        frm.Show();
                        this.Hide();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Login", "Uneseni su neispravni podaci.", MessageBoxButtons.OK);
                }
            }
        }

        private void bttnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija forma = new frmRegistracija();
            forma.Show();
            this.Hide();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtEmail, Messages.Text_Email);
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(txtEmail.Text);
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtEmail, Messages.Text_Email);
                }
            }
        }
    }
}
