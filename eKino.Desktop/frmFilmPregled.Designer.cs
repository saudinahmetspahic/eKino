namespace eKino.Desktop
{
    partial class frmFilmPregled
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblListaFilmova = new System.Windows.Forms.TableLayoutPanel();
            this.tblPreporukaFilmova = new System.Windows.Forms.TableLayoutPanel();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tblListaFilmova
            // 
            this.tblListaFilmova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tblListaFilmova.AutoScroll = true;
            this.tblListaFilmova.ColumnCount = 2;
            this.tblListaFilmova.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblListaFilmova.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblListaFilmova.Location = new System.Drawing.Point(12, 12);
            this.tblListaFilmova.Name = "tblListaFilmova";
            this.tblListaFilmova.RowCount = 1;
            this.tblListaFilmova.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblListaFilmova.Size = new System.Drawing.Size(518, 544);
            this.tblListaFilmova.TabIndex = 0;
            // 
            // tblPreporukaFilmova
            // 
            this.tblPreporukaFilmova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tblPreporukaFilmova.ColumnCount = 1;
            this.tblPreporukaFilmova.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPreporukaFilmova.Location = new System.Drawing.Point(536, 12);
            this.tblPreporukaFilmova.Name = "tblPreporukaFilmova";
            this.tblPreporukaFilmova.RowCount = 1;
            this.tblPreporukaFilmova.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPreporukaFilmova.Size = new System.Drawing.Size(294, 603);
            this.tblPreporukaFilmova.TabIndex = 1;
            // 
            // bttnBack
            // 
            this.bttnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttnBack.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBack.Location = new System.Drawing.Point(12, 562);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(259, 52);
            this.bttnBack.TabIndex = 2;
            this.bttnBack.Text = "Nazad";
            this.bttnBack.UseVisualStyleBackColor = false;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnNext
            // 
            this.bttnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttnNext.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNext.Location = new System.Drawing.Point(268, 562);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(262, 52);
            this.bttnNext.TabIndex = 3;
            this.bttnNext.Text = "Sljedeca";
            this.bttnNext.UseVisualStyleBackColor = false;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click);
            // 
            // frmFilmPregled
            // 
            this.ClientSize = new System.Drawing.Size(842, 627);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.bttnNext);
            this.Controls.Add(this.tblPreporukaFilmova);
            this.Controls.Add(this.tblListaFilmova);
            this.MinimumSize = new System.Drawing.Size(860, 674);
            this.Name = "frmFilmPregled";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFilmPregled_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel pnlPreporuka;
        //private System.Windows.Forms.FlowLayoutPanel pnlPregledFilmova;
        //private System.Windows.Forms.TableLayoutPanel tblFilmovi;
        //private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.TableLayoutPanel tblPreporuke;
        //private System.Windows.Forms.PictureBox pbxFilmSlika;
        //private System.Windows.Forms.TableLayoutPanel tblFilmInfo;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label txtNazivFilma;
        //private System.Windows.Forms.Label txtZanrFilma;
        //private System.Windows.Forms.Label txtTrajanjeFilma;
        //public System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.Label lblPreporukaNaziv;
        //private System.Windows.Forms.Label lblPreporukaZanr;
        //private System.Windows.Forms.Label lblPreporukaTrajanje;
        private System.Windows.Forms.TableLayoutPanel tblListaFilmova;
        private System.Windows.Forms.TableLayoutPanel tblPreporukaFilmova;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnNext;
    }
}