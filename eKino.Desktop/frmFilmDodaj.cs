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
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Odaberi putanju" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtFilm.Text = fbd.SelectedPath;
                    //txtPathOutput.Text = fbd.SelectedPath;
                    //Path = fbd.SelectedPath;
                    //foreach (var item in Directory.GetFiles(fbd.SelectedPath))
                    //{
                    //    imgList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                    //    FileInfo fi = new FileInfo(item);
                    //    ListFiles.Add(fi.FullName);
                    //    lviewPretrega.Items.Add(fi.Name, imgList.Images.Count - 1);
                    //}
                }
            }


            //var frmFileBrowser = new frmFileBrowser();
            //frmFileBrowser.Show();
            //var path = frmFileBrowser.GetPath();
            //txtFilm.Text = path;
        }
        public void SetPath(string path)
        {

        }
        private void txtFilm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
