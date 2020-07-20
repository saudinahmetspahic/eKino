using eKino.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.Desktop
{
    public partial class frmFileBrowser : Form
    {
        private List<string> ListFiles = new List<string>();
        private string Path { get; set; }
        public frmFileBrowser()
        {
            InitializeComponent();
        }

        private void bttnOtvori_Click(object sender, EventArgs e)
        {
            ListFiles.Clear();
            lviewPretrega.Items.Clear();
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Odaberi putanju" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPathOutput.Text = fbd.SelectedPath;
                    Path = fbd.SelectedPath;
                    foreach (var item in Directory.GetFiles(fbd.SelectedPath))
                    {
                        imgList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        ListFiles.Add(fi.FullName);
                        lviewPretrega.Items.Add(fi.Name, imgList.Images.Count - 1);
                    }
                }
            }
        }


        public string GetPath()
        {
            return Path;
        }

        private void lviewPretrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviewPretrega.FocusedItem != null)
            {
                //var file = new FileInfo(lviewPretrega.FocusedItem.Name);
                var dest = @"C:\Users\PC\Documents\";
                var source = Path + lviewPretrega.FocusedItem.Text;
                
               // var fi = new FileInfo(lviewPretrega.FocusedItem.Name);
                //File.Copy(source, dest);
                //MessageBox.Show("Uspjesno spremljeno");
            }
        }
    }
}
