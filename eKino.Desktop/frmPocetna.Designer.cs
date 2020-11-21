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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPocetna));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblMeni = new System.Windows.Forms.TableLayoutPanel();
            this.bttnFilmovi = new System.Windows.Forms.Button();
            this.bttnPaketi = new System.Windows.Forms.Button();
            this.bttnRezervacije = new System.Windows.Forms.Button();
            this.rpbAvatar = new eKino.Desktop.RoundPictureBox();
            this.roundPictureBox1 = new eKino.Desktop.RoundPictureBox();
            this.labeKino = new System.Windows.Forms.Label();
            this.pnlPaketiDropDownLista = new System.Windows.Forms.Panel();
            this.bttnPaketAktuelno = new System.Windows.Forms.Button();
            this.bttnPaketDodaj = new System.Windows.Forms.Button();
            this.pnlFilmoviDropDownLista = new System.Windows.Forms.Panel();
            this.bttnFilmAktuelno = new System.Windows.Forms.Button();
            this.bttnFilmDodaj = new System.Windows.Forms.Button();
            this.pnlPozadina = new System.Windows.Forms.Panel();
            this.notyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.tblMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.pnlPaketiDropDownLista.SuspendLayout();
            this.pnlFilmoviDropDownLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.tblMeni);
            this.panel1.Controls.Add(this.rpbAvatar);
            this.panel1.Controls.Add(this.roundPictureBox1);
            this.panel1.Controls.Add(this.labeKino);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Size = new System.Drawing.Size(804, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.tblMeni.Controls.Add(this.bttnRezervacije, 1, 0);
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
            // bttnRezervacije
            // 
            this.bttnRezervacije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnRezervacije.BackColor = System.Drawing.Color.White;
            this.bttnRezervacije.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bttnRezervacije.FlatAppearance.BorderSize = 2;
            this.bttnRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRezervacije.Location = new System.Drawing.Point(190, 3);
            this.bttnRezervacije.Name = "bttnRezervacije";
            this.bttnRezervacije.Size = new System.Drawing.Size(182, 49);
            this.bttnRezervacije.TabIndex = 4;
            this.bttnRezervacije.Text = "Rezervacije";
            this.bttnRezervacije.UseVisualStyleBackColor = false;
            this.bttnRezervacije.Click += new System.EventHandler(this.bttnRezervacije_Click);
            // 
            // rpbAvatar
            // 
            this.rpbAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.rpbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("rpbAvatar.Image")));
            this.rpbAvatar.Location = new System.Drawing.Point(709, 3);
            this.rpbAvatar.Margin = new System.Windows.Forms.Padding(5);
            this.rpbAvatar.MaximumSize = new System.Drawing.Size(90, 90);
            this.rpbAvatar.MinimumSize = new System.Drawing.Size(90, 90);
            this.rpbAvatar.Name = "rpbAvatar";
            this.rpbAvatar.Padding = new System.Windows.Forms.Padding(1);
            this.rpbAvatar.Size = new System.Drawing.Size(90, 90);
            this.rpbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rpbAvatar.TabIndex = 1;
            this.rpbAvatar.TabStop = false;
            this.rpbAvatar.Click += new System.EventHandler(this.rpbAvatar_Click);
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
            this.roundPictureBox1.Click += new System.EventHandler(this.roundPictureBox1_Click);
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
            // pnlPaketiDropDownLista
            // 
            this.pnlPaketiDropDownLista.BackColor = System.Drawing.Color.Transparent;
            this.pnlPaketiDropDownLista.Controls.Add(this.bttnPaketAktuelno);
            this.pnlPaketiDropDownLista.Controls.Add(this.bttnPaketDodaj);
            this.pnlPaketiDropDownLista.Location = new System.Drawing.Point(130, 84);
            this.pnlPaketiDropDownLista.Name = "pnlPaketiDropDownLista";
            this.pnlPaketiDropDownLista.Size = new System.Drawing.Size(181, 69);
            this.pnlPaketiDropDownLista.TabIndex = 5;
            this.pnlPaketiDropDownLista.Visible = false;
            // 
            // bttnPaketAktuelno
            // 
            this.bttnPaketAktuelno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnPaketAktuelno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnPaketAktuelno.Location = new System.Drawing.Point(0, -1);
            this.bttnPaketAktuelno.Name = "bttnPaketAktuelno";
            this.bttnPaketAktuelno.Size = new System.Drawing.Size(181, 35);
            this.bttnPaketAktuelno.TabIndex = 7;
            this.bttnPaketAktuelno.Text = "Aktuelno";
            this.bttnPaketAktuelno.UseVisualStyleBackColor = false;
            this.bttnPaketAktuelno.Click += new System.EventHandler(this.bttnPaketAktuelno_Click);
            // 
            // bttnPaketDodaj
            // 
            this.bttnPaketDodaj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnPaketDodaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnPaketDodaj.Location = new System.Drawing.Point(0, 34);
            this.bttnPaketDodaj.Name = "bttnPaketDodaj";
            this.bttnPaketDodaj.Size = new System.Drawing.Size(181, 35);
            this.bttnPaketDodaj.TabIndex = 6;
            this.bttnPaketDodaj.Text = "Dodaj";
            this.bttnPaketDodaj.UseVisualStyleBackColor = false;
            this.bttnPaketDodaj.Click += new System.EventHandler(this.bttnPaketDodaj_Click);
            // 
            // pnlFilmoviDropDownLista
            // 
            this.pnlFilmoviDropDownLista.BackColor = System.Drawing.Color.Transparent;
            this.pnlFilmoviDropDownLista.Controls.Add(this.bttnFilmAktuelno);
            this.pnlFilmoviDropDownLista.Controls.Add(this.bttnFilmDodaj);
            this.pnlFilmoviDropDownLista.Location = new System.Drawing.Point(505, 84);
            this.pnlFilmoviDropDownLista.Name = "pnlFilmoviDropDownLista";
            this.pnlFilmoviDropDownLista.Size = new System.Drawing.Size(182, 69);
            this.pnlFilmoviDropDownLista.TabIndex = 9;
            this.pnlFilmoviDropDownLista.Visible = false;
            // 
            // bttnFilmAktuelno
            // 
            this.bttnFilmAktuelno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnFilmAktuelno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnFilmAktuelno.Location = new System.Drawing.Point(0, -1);
            this.bttnFilmAktuelno.Name = "bttnFilmAktuelno";
            this.bttnFilmAktuelno.Size = new System.Drawing.Size(182, 35);
            this.bttnFilmAktuelno.TabIndex = 7;
            this.bttnFilmAktuelno.Text = "Aktuelno";
            this.bttnFilmAktuelno.UseVisualStyleBackColor = false;
            this.bttnFilmAktuelno.Click += new System.EventHandler(this.bttnFilmAktuelno_Click);
            // 
            // bttnFilmDodaj
            // 
            this.bttnFilmDodaj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bttnFilmDodaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnFilmDodaj.Location = new System.Drawing.Point(0, 34);
            this.bttnFilmDodaj.Name = "bttnFilmDodaj";
            this.bttnFilmDodaj.Size = new System.Drawing.Size(182, 35);
            this.bttnFilmDodaj.TabIndex = 6;
            this.bttnFilmDodaj.Text = "Dodaj";
            this.bttnFilmDodaj.UseVisualStyleBackColor = false;
            this.bttnFilmDodaj.Click += new System.EventHandler(this.bttnFilmDodaj_Click);
            // 
            // pnlPozadina
            // 
            this.pnlPozadina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPozadina.BackgroundImage")));
            this.pnlPozadina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPozadina.Location = new System.Drawing.Point(0, 0);
            this.pnlPozadina.Name = "pnlPozadina";
            this.pnlPozadina.Size = new System.Drawing.Size(804, 464);
            this.pnlPozadina.TabIndex = 11;
            // 
            // notyIcon
            // 
            this.notyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notyIcon.Icon")));
            this.notyIcon.Text = "notification";
            this.notyIcon.Visible = true;
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(804, 464);
            this.Controls.Add(this.pnlFilmoviDropDownLista);
            this.Controls.Add(this.pnlPaketiDropDownLista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPozadina);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmPocetna";
            this.Text = "Pocetna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.frmPocetna_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tblMeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.pnlPaketiDropDownLista.ResumeLayout(false);
            this.pnlFilmoviDropDownLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeKino;
        private RoundPictureBox rpbAvatar;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Button bttnPaketi;
        private System.Windows.Forms.Button bttnRezervacije;
        private System.Windows.Forms.Button bttnFilmovi;
        private System.Windows.Forms.TableLayoutPanel tblMeni;
        private System.Windows.Forms.Panel pnlPaketiDropDownLista;
        private System.Windows.Forms.Button bttnPaketAktuelno;
        private System.Windows.Forms.Button bttnPaketDodaj;
        private System.Windows.Forms.Panel pnlFilmoviDropDownLista;
        private System.Windows.Forms.Button bttnFilmAktuelno;
        private System.Windows.Forms.Button bttnFilmDodaj;
        private System.Windows.Forms.Panel pnlPozadina;
        private System.Windows.Forms.NotifyIcon notyIcon;
    }
}