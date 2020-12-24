using eKino.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.Desktop
{
    public partial class frmPaketDodaj : Form
    {
        private readonly ApiService _paketService = new ApiService("Paket");
        public frmPaketDodaj()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }


        private void bttnPaketDodaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var paket = new PaketInsertRequest
                {
                    Cijena = (double)nudCijena.Value,
                    DatumIsteka = dtpDatumIsteka.Value,
                    DatumKreiranja = DateTime.Now,
                    Opis = txtOpis.Text,
                    MaxOcijena = cbxOcijena.SelectedIndex
                };
                _paketService.Add(paket);

                var frm = new frmPaketPregled();
                frm.MdiParent = this.MdiParent;
                frm.Show();
                this.Close();
            }
        }

        private void frmPaketDodaj_Load(object sender, EventArgs e)
        {
            dtpDatumIsteka.Value = DateTime.Now;
            var ocijene = new[] {
                new { Id = 0, Opis = "Odaberi ocijenu" },
                new { Id = 1, Opis = "1" },
                new { Id = 2, Opis = "2" },
                new { Id = 3, Opis = "3" },
                new { Id = 4, Opis = "4" },
                new { Id = 5, Opis = "5" },
            };
            cbxOcijena.DataSource = ocijene;
            cbxOcijena.ValueMember = "Id";
            cbxOcijena.DisplayMember = "Opis";
        }
            
        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtOpis.Text) || txtOpis.Text.Length < 15)
            {
                e.Cancel = true;
                errorProvider.SetError(txtOpis, Messages.Text_Opis_15_K);
            }
        }
            
        private void cbxOcijena_Validating(object sender, CancelEventArgs e)
        {
            if (cbxOcijena.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbxOcijena, Messages.CBX_Ocijena);
            }
        }
    }
}
