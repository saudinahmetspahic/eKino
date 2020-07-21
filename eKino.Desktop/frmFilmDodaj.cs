using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.Desktop
{
    public partial class frmFilmDodaj : Form
    {
        public frmFilmDodaj()
        {
            InitializeComponent();
        }

        private void txtFilm_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fbd = new OpenFileDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtFilm.Text = fbd.FileName;
                }
            }
        }
    }
}
