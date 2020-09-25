using eKino.Model;
using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows;
using System.Windows.Forms;

namespace eKino.Desktop
{
    public partial class frmUrediAccount : Form
    {
        private Korisnik _korisnik = null;
        private readonly ApiService _korisnikService = new ApiService("Korisnik");
        private readonly ApiService _gradService = new ApiService("Grad");
        private readonly ApiService _ulogaService = new ApiService("Uloga");
        public frmUrediAccount()
        {
            InitializeComponent();
        }

        private void frmUrediAccount_Load(object sender, EventArgs e)
        {
            var req = new KorisnikSearchRequest { Email = ApiService.Email };
            var k = _korisnikService.Get<List<Korisnik>>(req).FirstOrDefault();

            _korisnik = k;
            if (k != null)
            {
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtEmail.Text = _korisnik.Email;
                var gradLista = _gradService.Get<List<Grad>>(null);
                gradLista.Insert(0, new Grad { Id = 0, Naziv = "Odaberi grad" });
                cbxGrad.DataSource = gradLista;
                cbxGrad.DisplayMember = "Naziv";
                cbxGrad.ValueMember = "Id";
                var grad = gradLista.Where(w => w.Id == _korisnik.GradId).Select(s => s.Naziv).FirstOrDefault();
                var index = cbxGrad.FindString(grad);
                cbxGrad.SelectedIndex = index;
                var ulogaLista = _ulogaService.Get<List<Uloga>>(null);
                ulogaLista.Insert(0, new Uloga { Id = 0, NazivUloge = "Odaberi ulogu" });
                cbxUloga.DataSource = ulogaLista;
                cbxUloga.DisplayMember = "NazivUloge";
                cbxUloga.ValueMember = "Id";
                var uloga = ulogaLista.Where(w => w.Id == _korisnik.UlogaId).Select(s => s.NazivUloge).FirstOrDefault();
                var indexU = cbxUloga.FindString(uloga);
                cbxUloga.SelectedIndex = indexU;
                dtpDatumRodjenja.Value = _korisnik.DatumRodjenja;
            }
            else
            {
                var r = System.Windows.Forms.MessageBox.Show("Login", "Niste ulogovani na sistem.", MessageBoxButtons.OK);
                if (r.Equals(MessageBoxResult.OK))
                {
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void bttnSnimi_Click(object sender, EventArgs e)
        {
            if (txtLozinka.Text != txtLozinkaPotvrda.Text)
            {
                var r = System.Windows.Forms.MessageBox.Show("Lozinka", "Greska: Lozinke se ne poklapaju.", MessageBoxButtons.OK);
                if (r.Equals(MessageBoxResult.OK))
                    return;
            }
            _korisnikService.Update<Model.Korisnik>(_korisnik.Id, new KorisnikInsertRequest
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text,
                GradId = cbxGrad.SelectedIndex,
                UlogaId = cbxUloga.SelectedIndex,
                DatumRodjenja = dtpDatumRodjenja.Value,
                DatumRegistracije = _korisnik.DatumRegistracije,
                Password = txtLozinka.Text,
                PasswordPotvrda = txtLozinkaPotvrda.Text
            });
            if (!string.IsNullOrEmpty(txtLozinka.Text))
            {
                frmLogin frmL = new frmLogin();
                frmL.Show();
                this.Hide();
                return;
            }
            frmPocetna frm = new frmPocetna();
            frm.Show();
            this.Hide();
        }
    }
}
