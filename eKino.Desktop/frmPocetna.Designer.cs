namespace eKino.Desktop
{
    partial class frmPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPocetna));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblMeni = new System.Windows.Forms.TableLayoutPanel();
            this.bttnFilmovi = new System.Windows.Forms.Button();
            this.bttnPaketi = new System.Windows.Forms.Button();
            this.bttnProjekcije = new System.Windows.Forms.Button();
            this.roundPictureBox2 = new eKino.Desktop.RoundPictureBox();
            this.roundPictureBox1 = new eKino.Desktop.RoundPictureBox();
            this.labeKino = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPaketiDropDownLista = new System.Windows.Forms.Panel();
            this.bttnPaketIzbrisi = new System.Windows.Forms.Button();
            this.bttnPaketAktuelno = new System.Windows.Forms.Button();
            this.bttnPaketDodaj = new System.Windows.Forms.Button();
            this.pnlFilmoviDropDownLista = new System.Windows.Forms.Panel();
            this.bttnFilmIzbrisi = new System.Windows.Forms.Button();
            this.bttnFilmAktuelno = new System.Windows.Forms.Button();
            this.bttnFilmDodaj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tblMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPaketiDropDownLista.SuspendLayout();
            this.pnlFilmoviDropDownLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.tblMeni);
            this.panel1.Controls.Add(this.roundPictureBox2);
            this.panel1.Controls.Add(this.roundPictureBox1);
            this.panel1.Controls.Add(this.labeKino);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Size = new System.Drawing.Size(804, 100);
            this.panel1.TabIndex = 0;
            // 
            // tblMeni
            // 
            this.tblMeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMeni.ColumnCount = 3;
            this.tblMeni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.23891F));
            this.tblMeni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.42776F));
            this.tblMeni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMeni.Controls.Add(this.bttnFilmovi, 2, 0);
            this.tblMeni.Controls.Add(this.bttnPaketi, 0, 0);
            this.tblMeni.Controls.Add(this.bttnProjekcije, 1, 0);
            this.tblMeni.Location = new System.Drawing.Point(127, 32);
            this.tblMeni.Name = "tblMeni";
            this.tblMeni.RowCount = 1;
            this.tblMeni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMeni.Size = new System.Drawing.Size(563, 55);
            this.tblMeni.TabIndex = 1;
            // 
            // bttnFilmovi
            // 
            this.bttnFilmovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnFilmovi.BackColor = System.Drawing.Color.White;
            this.bttnFilmovi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnFilmovi.FlatAppearance.BorderSize = 2;
            this.bttnFilmovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnFilmovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFilmovi.Location = new System.Drawing.Point(378, 3);
            this.bttnFilmovi.Name = "bttnFilmovi";
            this.bttnFilmovi.Size = new System.Drawing.Size(182, 49);
            this.bttnFilmovi.TabIndex = 5;
            this.bttnFilmovi.Text = "Filmovi";
            this.bttnFilmovi.UseVisualStyleBackColor = false;
            this.bttnFilmovi.Click += new System.EventHandler(this.bttnFilmovi_Click);
            // 
            // bttnPaketi
            // 
            this.bttnPaketi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnPaketi.BackColor = System.Drawing.Color.White;
            this.bttnPaketi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnPaketi.FlatAppearance.BorderSize = 2;
            this.bttnPaketi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnPaketi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPaketi.Location = new System.Drawing.Point(3, 3);
            this.bttnPaketi.Name = "bttnPaketi";
            this.bttnPaketi.Size = new System.Drawing.Size(181, 49);
            this.bttnPaketi.TabIndex = 1;
            this.bttnPaketi.Text = "Paketi";
            this.bttnPaketi.UseVisualStyleBackColor = false;
            this.bttnPaketi.Click += new System.EventHandler(this.bttnPaketi_Click);
            // 
            // bttnProjekcije
            // 
            this.bttnProjekcije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnProjekcije.BackColor = System.Drawing.Color.White;
            this.bttnProjekcije.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnProjekcije.FlatAppearance.BorderSize = 2;
            this.bttnProjekcije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnProjekcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnProjekcije.Location = new System.Drawing.Point(190, 3);
            this.bttnProjekcije.Name = "bttnProjekcije";
            this.bttnProjekcije.Size = new System.Drawing.Size(182, 49);
            this.bttnProjekcije.TabIndex = 4;
            this.bttnProjekcije.Text = "Projekcije";
            this.bttnProjekcije.UseVisualStyleBackColor = false;
            // 
            // roundPictureBox2
            // 
            this.roundPictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.roundPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox2.Image")));
            this.roundPictureBox2.Location = new System.Drawing.Point(709, 3);
            this.roundPictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.roundPictureBox2.MaximumSize = new System.Drawing.Size(90, 90);
            this.roundPictureBox2.MinimumSize = new System.Drawing.Size(90, 90);
            this.roundPictureBox2.Name = "roundPictureBox2";
            this.roundPictureBox2.Size = new System.Drawing.Size(90, 90);
            this.roundPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox2.TabIndex = 1;
            this.roundPictureBox2.TabStop = false;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox1.Image")));
            this.roundPictureBox1.Location = new System.Drawing.Point(12, 31);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(79, 63);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox1.TabIndex = 3;
            this.roundPictureBox1.TabStop = false;
            // 
            // labeKino
            // 
            this.labeKino.AutoSize = true;
            this.labeKino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeKino.Location = new System.Drawing.Point(16, 6);
            this.labeKino.Name = "labeKino";
            this.labeKino.Size = new System.Drawing.Size(68, 25);
            this.labeKino.TabIndex = 0;
            this.labeKino.Text = "eKino";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 363);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPaketiDropDownLista
            // 
            this.pnlPaketiDropDownLista.BackColor = System.Drawing.Color.Transparent;
            this.pnlPaketiDropDownLista.Controls.Add(this.bttnPaketIzbrisi);
            this.pnlPaketiDropDownLista.Controls.Add(this.bttnPaketAktuelno);
            this.pnlPaketiDropDownLista.Controls.Add(this.bttnPaketDodaj);
            this.pnlPaketiDropDownLista.Location = new System.Drawing.Point(130, 84);
            this.pnlPaketiDropDownLista.Name = "pnlPaketiDropDownLista";
            this.pnlPaketiDropDownLista.Size = new System.Drawing.Size(181, 104);
            this.pnlPaketiDropDownLista.TabIndex = 5;
            this.pnlPaketiDropDownLista.Visible = false;
            // 
            // bttnPaketIzbrisi
            // 
            this.bttnPaketIzbrisi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnPaketIzbrisi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnPaketIzbrisi.Location = new System.Drawing.Point(0, -1);
            this.bttnPaketIzbrisi.Name = "bttnPaketIzbrisi";
            this.bttnPaketIzbrisi.Size = new System.Drawing.Size(181, 35);
            this.bttnPaketIzbrisi.TabIndex = 8;
            this.bttnPaketIzbrisi.Text = "Izbrisi";
            this.bttnPaketIzbrisi.UseVisualStyleBackColor = false;
            // 
            // bttnPaketAktuelno
            // 
            this.bttnPaketAktuelno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnPaketAktuelno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnPaketAktuelno.Location = new System.Drawing.Point(0, 34);
            this.bttnPaketAktuelno.Name = "bttnPaketAktuelno";
            this.bttnPaketAktuelno.Size = new System.Drawing.Size(181, 35);
            this.bttnPaketAktuelno.TabIndex = 7;
            this.bttnPaketAktuelno.Text = "Aktuelno";
            this.bttnPaketAktuelno.UseVisualStyleBackColor = false;
            // 
            // bttnPaketDodaj
            // 
            this.bttnPaketDodaj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnPaketDodaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnPaketDodaj.Location = new System.Drawing.Point(0, 69);
            this.bttnPaketDodaj.Name = "bttnPaketDodaj";
            this.bttnPaketDodaj.Size = new System.Drawing.Size(181, 35);
            this.bttnPaketDodaj.TabIndex = 6;
            this.bttnPaketDodaj.Text = "Dodaj";
            this.bttnPaketDodaj.UseVisualStyleBackColor = false;
            // 
            // pnlFilmoviDropDownLista
            // 
            this.pnlFilmoviDropDownLista.BackColor = System.Drawing.Color.Transparent;
            this.pnlFilmoviDropDownLista.Controls.Add(this.bttnFilmIzbrisi);
            this.pnlFilmoviDropDownLista.Controls.Add(this.bttnFilmAktuelno);
            this.pnlFilmoviDropDownLista.Controls.Add(this.bttnFilmDodaj);
            this.pnlFilmoviDropDownLista.Location = new System.Drawing.Point(505, 84);
            this.pnlFilmoviDropDownLista.Name = "pnlFilmoviDropDownLista";
            this.pnlFilmoviDropDownLista.Size = new System.Drawing.Size(182, 104);
            this.pnlFilmoviDropDownLista.TabIndex = 9;
            this.pnlFilmoviDropDownLista.Visible = false;
            // 
            // bttnFilmIzbrisi
            // 
            this.bttnFilmIzbrisi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnFilmIzbrisi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnFilmIzbrisi.Location = new System.Drawing.Point(0, -1);
            this.bttnFilmIzbrisi.Name = "bttnFilmIzbrisi";
            this.bttnFilmIzbrisi.Size = new System.Drawing.Size(182, 35);
            this.bttnFilmIzbrisi.TabIndex = 8;
            this.bttnFilmIzbrisi.Text = "Izbrisi";
            this.bttnFilmIzbrisi.UseVisualStyleBackColor = false;
            // 
            // bttnFilmAktuelno
            // 
            this.bttnFilmAktuelno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnFilmAktuelno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnFilmAktuelno.Location = new System.Drawing.Point(0, 34);
            this.bttnFilmAktuelno.Name = "bttnFilmAktuelno";
            this.bttnFilmAktuelno.Size = new System.Drawing.Size(182, 35);
            this.bttnFilmAktuelno.TabIndex = 7;
            this.bttnFilmAktuelno.Text = "Aktuelno";
            this.bttnFilmAktuelno.UseVisualStyleBackColor = false;
            // 
            // bttnFilmDodaj
            // 
            this.bttnFilmDodaj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnFilmDodaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnFilmDodaj.Location = new System.Drawing.Point(0, 69);
            this.bttnFilmDodaj.Name = "bttnFilmDodaj";
            this.bttnFilmDodaj.Size = new System.Drawing.Size(182, 35);
            this.bttnFilmDodaj.TabIndex = 6;
            this.bttnFilmDodaj.Text = "Dodaj";
            this.bttnFilmDodaj.UseVisualStyleBackColor = false;
            this.bttnFilmDodaj.Click += new System.EventHandler(this.bttnFilmDodaj_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(804, 463);
            this.Controls.Add(this.pnlFilmoviDropDownLista);
            this.Controls.Add(this.pnlPaketiDropDownLista);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmPocetna";
            this.Text = "Pocetna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tblMeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPaketiDropDownLista.ResumeLayout(false);
            this.pnlFilmoviDropDownLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeKino;
        private RoundPictureBox roundPictureBox2;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Button bttnPaketi;
        private System.Windows.Forms.Button bttnProjekcije;
        private System.Windows.Forms.Button bttnFilmovi;
        private System.Windows.Forms.TableLayoutPanel tblMeni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPaketiDropDownLista;
        private System.Windows.Forms.Button bttnPaketIzbrisi;
        private System.Windows.Forms.Button bttnPaketAktuelno;
        private System.Windows.Forms.Button bttnPaketDodaj;
        private System.Windows.Forms.Panel pnlFilmoviDropDownLista;
        private System.Windows.Forms.Button bttnFilmIzbrisi;
        private System.Windows.Forms.Button bttnFilmAktuelno;
        private System.Windows.Forms.Button bttnFilmDodaj;
    }
}