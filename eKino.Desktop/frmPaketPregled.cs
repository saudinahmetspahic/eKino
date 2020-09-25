using eKino.Model;
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
                        maxocijena += " i " + (i + 1).ToString() + " ★";
                    }
                    else
                    {
                        if (i != 0)
                            maxocijena += ", ";
                        maxocijena += (i + 1).ToString();
                    }
                }
                DodajPaket(index, paket.Opis, maxocijena);
                index++;
            }
        }
    }
}
