using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eKino.WinUI
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var value = input.Text;
            var result = "https://localhost:44321/api/Film".GetJsonAsync<dynamic>().Result;
            //output. = result;
        }
    }
}
