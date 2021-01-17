using eKino.Model;
using eKino.Model.Requests;
using eKino.Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Net.Mail;

namespace eKino.Desktop
{
    public partial class frmRegistracija : Form
    {
        private readonly ApiService _korisnikApiService = new ApiService("Korisnik");
        private readonly ApiService _gradApiService = new ApiService("Grad");
        private readonly ApiService _ulogaApiService = new ApiService("Uloga");
        public frmRegistracija()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void bttnRegistrujSe_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var korisnik = new KorisnikInsertRequest
                {
                    DatumRegistracije = DateTime.Now,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    Email = txtEmail.Text,
                    Password = txtSifra.Text,
                    PasswordPotvrda = txtSifraPotvrda.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text, 
                    UlogaId = _ulogaApiService.Get<List<Uloga>>(new UlogaSearchRequest { NazivUloge = "User" }).FirstOrDefault().Id,
                    GradId = cbGrad.SelectedIndex
                };
                _korisnikApiService.Add(korisnik);
                var loginForma = new frmLogin();
                loginForma.Show();
                Hide();
            }
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            var frm = new frmLogin();
            frm.Show();
            Hide();
        }

        private void bttlAvatarUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fbd = new OpenFileDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    pbSlika.Image = Image.FromFile(fbd.FileName);
                }
            }
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            var lista = _gradApiService.Get<List<Grad>>();
            lista.Insert(0, new Grad { Id = 0, Naziv = "Odaberi" });
            cbGrad.DataSource = lista;
            cbGrad.ValueMember = "Id";
            cbGrad.DisplayMember = "Naziv";
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

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifra.Text) || txtSifra.Text.Length < 6 || txtSifra.Text.Length > 15)
            {
                e.Cancel = true;
                errorProvider.SetError(txtSifra, Messages.Text_Sifra);
            }
        }

        private void txtSifraPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (txtSifra.Text != txtSifraPotvrda.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(txtSifraPotvrda, Messages.Text_Sifra_Potvrda);
            }
        }

        private void cbGrad_Validating(object sender, CancelEventArgs e)
        {
            if (cbGrad.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbGrad, Messages.CBX_Grad);
            }
        }
    }
}
