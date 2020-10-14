using eKino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.Desktop
{
    public partial class frmPaketPregled : Form
    {
        private readonly ApiService _paketiService = new ApiService("Paket");


        public frmPaketPregled()
        {
            InitializeComponent();
        }


        private void frmPaketPregled_Load(object sender, EventArgs e)
        {
            var paketi = _paketiService.Get<List<Paket>>();
            var index = 1;
            foreach (var paket in paketi)
            {
                string maxocijena = "Gledaj filmove sa ";
                var o = paket.MaxOcijena;
                for (int i = 0; i < o; i++)
                {
                    if (i + 1 == o)
                    {
                        if (i + 1 != 1)
                            maxocijena += " i ";
                        maxocijena += (i + 1).ToString() + " ★";
                    }
                    else
                    {
                        if (i != 0)
                            maxocijena += ", ";
                        maxocijena += (i + 1).ToString();
                    }
                }
                DodajPaket(paket.Id, index, paket.Opis, maxocijena, paket.Cijena ?? 0);
                index++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmPaketDodaj();
            frm.MdiParent = this.MdiParent;
            this.Hide();
            frm.Show();
            this.Close();
        }

        private void paket_Click(object sender, EventArgs e)
        {
            int paketId = 0;
            if (sender is Label)
                paketId = Int32.Parse(((Label)sender).Name);
            else
                paketId = Int32.Parse(((TableLayoutPanel)sender).Name);
            if (paketId <= 0)
                return;
            var frm = new frmPaketDetalji(paketId);
            frm.MdiParent = this.MdiParent;
            this.Hide();
            frm.Show();
            this.Close();
        }
    }
}
