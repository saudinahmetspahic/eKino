using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;

namespace eKino.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnRequest_Click(object sender, EventArgs e)
        {
            var value = tboxInput.Text;

            var result = "https://localhost:44321/api/Film/".GetJsonAsync<dynamic>().Result;
            dgvOutput.DataSource = result;
        }
    }
}
