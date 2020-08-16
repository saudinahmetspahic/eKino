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
        }

        private void bttnRegistrujSe_Click(object sender, EventArgs e)
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
                UlogaId = _ulogaApiService.GetByName<Uloga>("User").Id,
                GradId = cbGrad.SelectedIndex
            };
            _korisnikApiService.Add(korisnik);
            var loginForma = new frmLogin();
            loginForma.Show();
            Hide();
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
            var lista = _gradApiService.Get<List<Grad>>(false);
            lista.Insert(0, new Grad { Id = 0, Naziv = "Odaberi" });
            cbGrad.DataSource = lista;
            cbGrad.ValueMember = "Id";
            cbGrad.DisplayMember = "Naziv";
        }
    }
}
