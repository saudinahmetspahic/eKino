namespace eKino.Desktop
{
    partial class frmFilmDodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmDodaj));
            this.pnlMeni = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labeKino = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labGlumci = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labProjekcijaDatum = new System.Windows.Forms.Label();
            this.labZanr = new System.Windows.Forms.Label();
            this.labOpis = new System.Windows.Forms.Label();
            this.labProjekcijaCijenaUlaznice = new System.Windows.Forms.Label();
            this.labProjekcijaBrojKarata = new System.Windows.Forms.Label();
            this.labFilmUpload = new System.Windows.Forms.Label();
            this.cbxVrsta = new System.Windows.Forms.ComboBox();
            this.txtNazivFilma = new System.Windows.Forms.TextBox();
            this.txtGlumci = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.txtProjekcijaDatum = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtProjekcijaCijenaUlaznice = new System.Windows.Forms.TextBox();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.txtProjekcijaBrojKarata = new System.Windows.Forms.TextBox();
            this.roundPictureBox2 = new eKino.Desktop.RoundPictureBox();
            this.roundPictureBox1 = new eKino.Desktop.RoundPictureBox();
            this.pnlMeni.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMeni
            // 
            this.pnlMeni.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnlMeni.Controls.Add(this.label1);
            this.pnlMeni.Controls.Add(this.roundPictureBox2);
            this.pnlMeni.Controls.Add(this.roundPictureBox1);
            this.pnlMeni.Controls.Add(this.labeKino);
            this.pnlMeni.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMeni.Location = new System.Drawing.Point(0, 0);
            this.pnlMeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMeni.Name = "pnlMeni";
            this.pnlMeni.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMeni.Size = new System.Drawing.Size(716, 81);
            this.pnlMeni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "DODAVANJE NOVOG FILMA";
            // 
            // labeKino
            // 
            this.labeKino.AutoSize = true;
            this.labeKino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeKino.Location = new System.Drawing.Point(14, 6);
            this.labeKino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeKino.Name = "labeKino";
            this.labeKino.Size = new System.Drawing.Size(54, 20);
            this.labeKino.TabIndex = 4;
            this.labeKino.Text = "eKino";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labGlumci, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labProjekcijaDatum, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labZanr, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labOpis, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labProjekcijaCijenaUlaznice, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labProjekcijaBrojKarata, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labFilmUpload, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbxVrsta, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNazivFilma, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtGlumci, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtZanr, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtProjekcijaDatum, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtOpis, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtProjekcijaCijenaUlaznice, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtFilm, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtProjekcijaBrojKarata, 1, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 97);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.27076F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.02166F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.27076F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.43682F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 358);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv fIlma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vrsta";
            // 
            // labGlumci
            // 
            this.labGlumci.AutoSize = true;
            this.labGlumci.Location = new System.Drawing.Point(4, 81);
            this.labGlumci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGlumci.Name = "labGlumci";
            this.labGlumci.Size = new System.Drawing.Size(39, 13);
            this.labGlumci.TabIndex = 4;
            this.labGlumci.Text = "Glumci";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(251, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ocijena (1-5)";
            // 
            // labProjekcijaDatum
            // 
            this.labProjekcijaDatum.AutoSize = true;
            this.labProjekcijaDatum.Location = new System.Drawing.Point(251, 152);
            this.labProjekcijaDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labProjekcijaDatum.Name = "labProjekcijaDatum";
            this.labProjekcijaDatum.Size = new System.Drawing.Size(86, 13);
            this.labProjekcijaDatum.TabIndex = 5;
            this.labProjekcijaDatum.Text = "Datum projekcije";
            // 
            // labZanr
            // 
            this.labZanr.AutoSize = true;
            this.labZanr.Location = new System.Drawing.Point(4, 152);
            this.labZanr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labZanr.Name = "labZanr";
            this.labZanr.Size = new System.Drawing.Size(29, 13);
            this.labZanr.TabIndex = 7;
            this.labZanr.Text = "Zanr";
            // 
            // labOpis
            // 
            this.labOpis.AutoSize = true;
            this.labOpis.Location = new System.Drawing.Point(4, 231);
            this.labOpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labOpis.Name = "labOpis";
            this.labOpis.Size = new System.Drawing.Size(28, 13);
            this.labOpis.TabIndex = 9;
            this.labOpis.Text = "Opis";
            // 
            // labProjekcijaCijenaUlaznice
            // 
            this.labProjekcijaCijenaUlaznice.AutoSize = true;
            this.labProjekcijaCijenaUlaznice.Location = new System.Drawing.Point(251, 231);
            this.labProjekcijaCijenaUlaznice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labProjekcijaCijenaUlaznice.Name = "labProjekcijaCijenaUlaznice";
            this.labProjekcijaCijenaUlaznice.Size = new System.Drawing.Size(78, 13);
            this.labProjekcijaCijenaUlaznice.TabIndex = 10;
            this.labProjekcijaCijenaUlaznice.Text = "Cijena ulaznice";
            // 
            // labProjekcijaBrojKarata
            // 
            this.labProjekcijaBrojKarata.AutoSize = true;
            this.labProjekcijaBrojKarata.Location = new System.Drawing.Point(251, 315);
            this.labProjekcijaBrojKarata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labProjekcijaBrojKarata.Name = "labProjekcijaBrojKarata";
            this.labProjekcijaBrojKarata.Size = new System.Drawing.Size(110, 13);
            this.labProjekcijaBrojKarata.TabIndex = 8;
            this.labProjekcijaBrojKarata.Text = "Broj karata za prodaju";
            // 
            // labFilmUpload
            // 
            this.labFilmUpload.AutoSize = true;
            this.labFilmUpload.Location = new System.Drawing.Point(4, 315);
            this.labFilmUpload.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labFilmUpload.Name = "labFilmUpload";
            this.labFilmUpload.Size = new System.Drawing.Size(25, 13);
            this.labFilmUpload.TabIndex = 11;
            this.labFilmUpload.Text = "Film";
            // 
            // cbxVrsta
            // 
            this.cbxVrsta.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxVrsta.FormattingEnabled = true;
            this.cbxVrsta.Location = new System.Drawing.Point(251, 20);
            this.cbxVrsta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxVrsta.MaximumSize = new System.Drawing.Size(376, 0);
            this.cbxVrsta.MinimumSize = new System.Drawing.Size(226, 0);
            this.cbxVrsta.Name = "cbxVrsta";
            this.cbxVrsta.Size = new System.Drawing.Size(244, 21);
            this.cbxVrsta.TabIndex = 21;
            // 
            // txtNazivFilma
            // 
            this.txtNazivFilma.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNazivFilma.Location = new System.Drawing.Point(4, 20);
            this.txtNazivFilma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNazivFilma.MaximumSize = new System.Drawing.Size(376, 20);
            this.txtNazivFilma.MinimumSize = new System.Drawing.Size(226, 20);
            this.txtNazivFilma.Name = "txtNazivFilma";
            this.txtNazivFilma.Size = new System.Drawing.Size(243, 20);
            this.txtNazivFilma.TabIndex = 2;
            // 
            // txtGlumci
            // 
            this.txtGlumci.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGlumci.Location = new System.Drawing.Point(4, 99);
            this.txtGlumci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGlumci.MaximumSize = new System.Drawing.Size(376, 20);
            this.txtGlumci.MinimumSize = new System.Drawing.Size(226, 20);
            this.txtGlumci.Name = "txtGlumci";
            this.txtGlumci.Size = new System.Drawing.Size(243, 20);
            this.txtGlumci.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox4.Location = new System.Drawing.Point(251, 99);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.MaximumSize = new System.Drawing.Size(376, 4);
            this.textBox4.MinimumSize = new System.Drawing.Size(226, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(244, 20);
            this.textBox4.TabIndex = 14;
            // 
            // txtZanr
            // 
            this.txtZanr.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtZanr.Location = new System.Drawing.Point(4, 170);
            this.txtZanr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtZanr.MaximumSize = new System.Drawing.Size(376, 4);
            this.txtZanr.MinimumSize = new System.Drawing.Size(226, 20);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(243, 20);
            this.txtZanr.TabIndex = 15;
            // 
            // txtProjekcijaDatum
            // 
            this.txtProjekcijaDatum.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProjekcijaDatum.Location = new System.Drawing.Point(251, 170);
            this.txtProjekcijaDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProjekcijaDatum.MaximumSize = new System.Drawing.Size(376, 4);
            this.txtProjekcijaDatum.MinimumSize = new System.Drawing.Size(226, 20);
            this.txtProjekcijaDatum.Name = "txtProjekcijaDatum";
            this.txtProjekcijaDatum.Size = new System.Drawing.Size(244, 20);
            this.txtProjekcijaDatum.TabIndex = 16;
            // 
            // txtOpis
            // 
            this.txtOpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOpis.Location = new System.Drawing.Point(4, 249);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpis.MaximumSize = new System.Drawing.Size(376, 58);
            this.txtOpis.MinimumSize = new System.Drawing.Size(226, 17);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(243, 50);
            this.txtOpis.TabIndex = 17;
            // 
            // txtProjekcijaCijenaUlaznice
            // 
            this.txtProjekcijaCijenaUlaznice.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProjekcijaCijenaUlaznice.Location = new System.Drawing.Point(251, 249);
            this.txtProjekcijaCijenaUlaznice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProjekcijaCijenaUlaznice.MaximumSize = new System.Drawing.Size(376, 4);
            this.txtProjekcijaCijenaUlaznice.MinimumSize = new System.Drawing.Size(226, 20);
            this.txtProjekcijaCijenaUlaznice.Name = "txtProjekcijaCijenaUlaznice";
            this.txtProjekcijaCijenaUlaznice.Size = new System.Drawing.Size(244, 20);
            this.txtProjekcijaCijenaUlaznice.TabIndex = 18;
            // 
            // txtFilm
            // 
            this.txtFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilm.Location = new System.Drawing.Point(4, 333);
            this.txtFilm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilm.MaximumSize = new System.Drawing.Size(376, 4);
            this.txtFilm.MinimumSize = new System.Drawing.Size(226, 20);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.ReadOnly = true;
            this.txtFilm.Size = new System.Drawing.Size(243, 20);
            this.txtFilm.TabIndex = 19;
            this.txtFilm.Click += new System.EventHandler(this.txtFilm_Click);
            // 
            // txtProjekcijaBrojKarata
            // 
            this.txtProjekcijaBrojKarata.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProjekcijaBrojKarata.Location = new System.Drawing.Point(251, 333);
            this.txtProjekcijaBrojKarata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProjekcijaBrojKarata.MaximumSize = new System.Drawing.Size(376, 4);
            this.txtProjekcijaBrojKarata.MinimumSize = new System.Drawing.Size(226, 20);
            this.txtProjekcijaBrojKarata.Name = "txtProjekcijaBrojKarata";
            this.txtProjekcijaBrojKarata.Size = new System.Drawing.Size(244, 20);
            this.txtProjekcijaBrojKarata.TabIndex = 20;
            // 
            // roundPictureBox2
            // 
            this.roundPictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.roundPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox2.Image")));
            this.roundPictureBox2.Location = new System.Drawing.Point(646, 2);
            this.roundPictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.roundPictureBox2.MaximumSize = new System.Drawing.Size(68, 73);
            this.roundPictureBox2.MinimumSize = new System.Drawing.Size(68, 73);
            this.roundPictureBox2.Name = "roundPictureBox2";
            this.roundPictureBox2.Size = new System.Drawing.Size(68, 73);
            this.roundPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox2.TabIndex = 5;
            this.roundPictureBox2.TabStop = false;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox1.Image")));
            this.roundPictureBox1.Location = new System.Drawing.Point(9, 25);
            this.roundPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(59, 51);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox1.TabIndex = 6;
            this.roundPictureBox1.TabStop = false;
            // 
            // frmFilmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlMeni);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(732, 621);
            this.Name = "frmFilmDodaj";
            this.Text = "frmFilmDodaj";
            this.pnlMeni.ResumeLayout(false);
            this.pnlMeni.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMeni;
        private RoundPictureBox roundPictureBox2;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label labeKino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNazivFilma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labGlumci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labProjekcijaDatum;
        private System.Windows.Forms.Label labZanr;
        private System.Windows.Forms.Label labOpis;
        private System.Windows.Forms.Label labProjekcijaCijenaUlaznice;
        private System.Windows.Forms.Label labProjekcijaBrojKarata;
        private System.Windows.Forms.Label labFilmUpload;
        private System.Windows.Forms.TextBox txtGlumci;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.TextBox txtProjekcijaDatum;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtProjekcijaCijenaUlaznice;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.TextBox txtProjekcijaBrojKarata;
        private System.Windows.Forms.ComboBox cbxVrsta;
    }
}