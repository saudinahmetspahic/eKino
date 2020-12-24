using System.Drawing;

namespace eKino.Desktop
{
    partial class frmFilmDetalji
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
        /// 


        private void DodajKomentar(int KomentarId, string ImeKomentatora, string Komentar, int Likes, int Dislikes)
        {
            //this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20));
            //this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150));

            var lblIme = new System.Windows.Forms.Label();
            lblIme.Text = ImeKomentatora + " (" + Likes.ToString() + "👍 | " + Dislikes.ToString() + " 👎)";

            var lblText = new System.Windows.Forms.Label();
            lblText.Text = Komentar;

            this.tblKomentari.Controls.Add(lblIme);
            this.tblKomentari.Controls.Add(lblText);

            //lblIme.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            //lblText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblIme.Dock = System.Windows.Forms.DockStyle.Fill;
            lblIme.BackColor = Color.FromArgb(168, 170, 173);
            lblIme.TextAlign = ContentAlignment.BottomLeft;
            lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            lblText.AutoSize = true;
            lblText.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);

            lblIme.Name = KomentarId.ToString();
            lblIme.Click += KomentarClick_Click;
            lblText.Name = KomentarId.ToString();
            lblText.Click += KomentarClick_Click;
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxSlika = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProjekcija = new System.Windows.Forms.Label();
            this.pnlGlumci = new System.Windows.Forms.TableLayoutPanel();
            this.pnlScenaristi = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPrKuce = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnDodajGlumca = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnDodajScenaristu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnDodajPrKucu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnDodajProjekciju = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.tblOcijena = new System.Windows.Forms.TableLayoutPanel();
            this.lblOcijena5 = new System.Windows.Forms.Label();
            this.lblOcijena4 = new System.Windows.Forms.Label();
            this.lblOcijena3 = new System.Windows.Forms.Label();
            this.lblOcijena2 = new System.Windows.Forms.Label();
            this.lblOcijena1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblDodavanjeGlumca = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxListGlumaca = new System.Windows.Forms.ComboBox();
            this.lblNoviNaslov = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cbxGrad = new System.Windows.Forms.ComboBox();
            this.txtBiografija = new System.Windows.Forms.RichTextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.bttnDodajGlumcaOdustani = new System.Windows.Forms.Button();
            this.bttnDodajGlumcaDodaj = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tblDodajPrKucu = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxListKuca = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtKucaNaziv = new System.Windows.Forms.TextBox();
            this.cbxKucaGrad = new System.Windows.Forms.ComboBox();
            this.bttnDodajPrKucuOdustani = new System.Windows.Forms.Button();
            this.bttnDodajPrKucuDodaj = new System.Windows.Forms.Button();
            this.tblDodajProjekciju = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpDatumProjekcije = new System.Windows.Forms.DateTimePicker();
            this.cbxDvoranaProjekcije = new System.Windows.Forms.ComboBox();
            this.txtCijenaProjekcije = new System.Windows.Forms.TextBox();
            this.txtOpisProjekcije = new System.Windows.Forms.RichTextBox();
            this.bttnDodajProjekcijuOdustani = new System.Windows.Forms.Button();
            this.bttnDodajProjekcijuDodaj = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.tblKomentari = new System.Windows.Forms.TableLayoutPanel();
            this.bttnOcijeniFilm = new System.Windows.Forms.Button();
            this.bttnDodajKomentar = new System.Windows.Forms.Button();
            this.tblZaOcjenjivanjeFilma = new System.Windows.Forms.TableLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnPotvrdiOcijenu = new System.Windows.Forms.Button();
            this.bttnOdustaniOdOcijenjivanja = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.cbxListOcijena = new System.Windows.Forms.ComboBox();
            this.tblZaDodavanjeKomentara = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.txtKomentar = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnPotvrdiKomentar = new System.Windows.Forms.Button();
            this.bttnOdustaniOdKomentara = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.tblLikeAndDislike = new System.Windows.Forms.TableLayoutPanel();
            this.bttnLike = new System.Windows.Forms.Button();
            this.bttnDislike = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bttnPrijave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblOcijena.SuspendLayout();
            this.tblDodavanjeGlumca.SuspendLayout();
            this.tblDodajPrKucu.SuspendLayout();
            this.tblDodajProjekciju.SuspendLayout();
            this.tblZaOcjenjivanjeFilma.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tblZaDodavanjeKomentara.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tblLikeAndDislike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxSlika
            // 
            this.pbxSlika.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxSlika.Location = new System.Drawing.Point(304, 21);
            this.pbxSlika.Name = "pbxSlika";
            this.pbxSlika.Size = new System.Drawing.Size(329, 230);
            this.pbxSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSlika.TabIndex = 0;
            this.pbxSlika.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.07295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.92705F));
            this.tableLayoutPanel1.Controls.Add(this.lblDatum, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTip, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblZanr, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNaziv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblProjekcija, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.pnlGlumci, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pnlScenaristi, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pnlPrKuce, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(216, 273);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 281);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatum.Location = new System.Drawing.Point(186, 75);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(228, 35);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "label8";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Datum izlaska";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTip.Location = new System.Drawing.Point(186, 50);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(228, 25);
            this.lblTip.TabIndex = 5;
            this.lblTip.Text = "label6";
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tip";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZanr.Location = new System.Drawing.Point(186, 25);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(228, 25);
            this.lblZanr.TabIndex = 3;
            this.lblZanr.Text = "label4";
            this.lblZanr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNaziv.Location = new System.Drawing.Point(186, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(228, 25);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "label2";
            this.lblNaziv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Žanr";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProjekcija
            // 
            this.lblProjekcija.AutoSize = true;
            this.lblProjekcija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProjekcija.Location = new System.Drawing.Point(186, 224);
            this.lblProjekcija.Name = "lblProjekcija";
            this.lblProjekcija.Size = new System.Drawing.Size(228, 57);
            this.lblProjekcija.TabIndex = 14;
            // 
            // pnlGlumci
            // 
            this.pnlGlumci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGlumci.AutoSize = true;
            this.pnlGlumci.ColumnCount = 1;
            this.pnlGlumci.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlGlumci.Location = new System.Drawing.Point(186, 113);
            this.pnlGlumci.Name = "pnlGlumci";
            this.pnlGlumci.RowCount = 1;
            this.pnlGlumci.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlGlumci.Size = new System.Drawing.Size(228, 33);
            this.pnlGlumci.TabIndex = 15;
            // 
            // pnlScenaristi
            // 
            this.pnlScenaristi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScenaristi.AutoSize = true;
            this.pnlScenaristi.ColumnCount = 1;
            this.pnlScenaristi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlScenaristi.Location = new System.Drawing.Point(186, 152);
            this.pnlScenaristi.Name = "pnlScenaristi";
            this.pnlScenaristi.RowCount = 1;
            this.pnlScenaristi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlScenaristi.Size = new System.Drawing.Size(228, 32);
            this.pnlScenaristi.TabIndex = 16;
            // 
            // pnlPrKuce
            // 
            this.pnlPrKuce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrKuce.AutoSize = true;
            this.pnlPrKuce.ColumnCount = 1;
            this.pnlPrKuce.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlPrKuce.Location = new System.Drawing.Point(186, 190);
            this.pnlPrKuce.Name = "pnlPrKuce";
            this.pnlPrKuce.RowCount = 1;
            this.pnlPrKuce.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlPrKuce.Size = new System.Drawing.Size(228, 31);
            this.pnlPrKuce.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.bttnDodajGlumca, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(142, 33);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Glumci";
            // 
            // bttnDodajGlumca
            // 
            this.bttnDodajGlumca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnDodajGlumca.Location = new System.Drawing.Point(113, 3);
            this.bttnDodajGlumca.Name = "bttnDodajGlumca";
            this.bttnDodajGlumca.Size = new System.Drawing.Size(26, 26);
            this.bttnDodajGlumca.TabIndex = 6;
            this.bttnDodajGlumca.Text = "+";
            this.bttnDodajGlumca.UseVisualStyleBackColor = true;
            this.bttnDodajGlumca.Click += new System.EventHandler(this.bttnDodajGlumca_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.61539F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.38461F));
            this.tableLayoutPanel4.Controls.Add(this.bttnDodajScenaristu, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 152);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(147, 32);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // bttnDodajScenaristu
            // 
            this.bttnDodajScenaristu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnDodajScenaristu.Location = new System.Drawing.Point(114, 3);
            this.bttnDodajScenaristu.Name = "bttnDodajScenaristu";
            this.bttnDodajScenaristu.Size = new System.Drawing.Size(27, 26);
            this.bttnDodajScenaristu.TabIndex = 7;
            this.bttnDodajScenaristu.Text = "+";
            this.bttnDodajScenaristu.UseVisualStyleBackColor = true;
            this.bttnDodajScenaristu.Click += new System.EventHandler(this.bttnDodajScenaristu_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scenaristi";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.38461F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.61539F));
            this.tableLayoutPanel5.Controls.Add(this.bttnDodajPrKucu, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 190);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(147, 31);
            this.tableLayoutPanel5.TabIndex = 20;
            // 
            // bttnDodajPrKucu
            // 
            this.bttnDodajPrKucu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnDodajPrKucu.Location = new System.Drawing.Point(115, 3);
            this.bttnDodajPrKucu.Name = "bttnDodajPrKucu";
            this.bttnDodajPrKucu.Size = new System.Drawing.Size(27, 25);
            this.bttnDodajPrKucu.TabIndex = 8;
            this.bttnDodajPrKucu.Text = "+";
            this.bttnDodajPrKucu.UseVisualStyleBackColor = true;
            this.bttnDodajPrKucu.Click += new System.EventHandler(this.bttnDodajPrKucu_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prod. kuce";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.38461F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.61539F));
            this.tableLayoutPanel6.Controls.Add(this.bttnDodajProjekciju, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 227);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(147, 51);
            this.tableLayoutPanel6.TabIndex = 21;
            // 
            // bttnDodajProjekciju
            // 
            this.bttnDodajProjekciju.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnDodajProjekciju.Location = new System.Drawing.Point(115, 3);
            this.bttnDodajProjekciju.Name = "bttnDodajProjekciju";
            this.bttnDodajProjekciju.Size = new System.Drawing.Size(27, 28);
            this.bttnDodajProjekciju.TabIndex = 9;
            this.bttnDodajProjekciju.Text = "+";
            this.bttnDodajProjekciju.UseVisualStyleBackColor = true;
            this.bttnDodajProjekciju.Click += new System.EventHandler(this.bttnDodajProjekciju_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 51);
            this.label8.TabIndex = 10;
            this.label8.Text = "Projekcija";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.59925F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.40075F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblOpis, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(657, 21);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(267, 230);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 230);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Opis";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(57, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(54, 17);
            this.lblOpis.TabIndex = 1;
            this.lblOpis.Text = "label10";
            // 
            // tblOcijena
            // 
            this.tblOcijena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblOcijena.ColumnCount = 5;
            this.tblOcijena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOcijena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOcijena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOcijena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOcijena.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblOcijena.Controls.Add(this.lblOcijena5, 4, 0);
            this.tblOcijena.Controls.Add(this.lblOcijena4, 3, 0);
            this.tblOcijena.Controls.Add(this.lblOcijena3, 2, 0);
            this.tblOcijena.Controls.Add(this.lblOcijena2, 1, 0);
            this.tblOcijena.Controls.Add(this.lblOcijena1, 0, 0);
            this.tblOcijena.Location = new System.Drawing.Point(216, 569);
            this.tblOcijena.Name = "tblOcijena";
            this.tblOcijena.RowCount = 1;
            this.tblOcijena.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOcijena.Size = new System.Drawing.Size(707, 56);
            this.tblOcijena.TabIndex = 4;
            // 
            // lblOcijena5
            // 
            this.lblOcijena5.AutoSize = true;
            this.lblOcijena5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOcijena5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcijena5.Location = new System.Drawing.Point(567, 0);
            this.lblOcijena5.Name = "lblOcijena5";
            this.lblOcijena5.Size = new System.Drawing.Size(137, 56);
            this.lblOcijena5.TabIndex = 4;
            this.lblOcijena5.Text = "☆";
            this.lblOcijena5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOcijena4
            // 
            this.lblOcijena4.AutoSize = true;
            this.lblOcijena4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOcijena4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcijena4.Location = new System.Drawing.Point(426, 0);
            this.lblOcijena4.Name = "lblOcijena4";
            this.lblOcijena4.Size = new System.Drawing.Size(135, 56);
            this.lblOcijena4.TabIndex = 3;
            this.lblOcijena4.Text = "☆";
            this.lblOcijena4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOcijena3
            // 
            this.lblOcijena3.AutoSize = true;
            this.lblOcijena3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOcijena3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcijena3.Location = new System.Drawing.Point(285, 0);
            this.lblOcijena3.Name = "lblOcijena3";
            this.lblOcijena3.Size = new System.Drawing.Size(135, 56);
            this.lblOcijena3.TabIndex = 2;
            this.lblOcijena3.Text = "☆";
            this.lblOcijena3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOcijena2
            // 
            this.lblOcijena2.AutoSize = true;
            this.lblOcijena2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOcijena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcijena2.Location = new System.Drawing.Point(144, 0);
            this.lblOcijena2.Name = "lblOcijena2";
            this.lblOcijena2.Size = new System.Drawing.Size(135, 56);
            this.lblOcijena2.TabIndex = 1;
            this.lblOcijena2.Text = "☆";
            this.lblOcijena2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOcijena1
            // 
            this.lblOcijena1.AutoSize = true;
            this.lblOcijena1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOcijena1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcijena1.Location = new System.Drawing.Point(3, 0);
            this.lblOcijena1.Name = "lblOcijena1";
            this.lblOcijena1.Size = new System.Drawing.Size(135, 56);
            this.lblOcijena1.TabIndex = 0;
            this.lblOcijena1.Text = "☆";
            this.lblOcijena1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(216, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblDodavanjeGlumca
            // 
            this.tblDodavanjeGlumca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDodavanjeGlumca.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tblDodavanjeGlumca.ColumnCount = 2;
            this.tblDodavanjeGlumca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDodavanjeGlumca.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tblDodavanjeGlumca.Controls.Add(this.label10, 0, 0);
            this.tblDodavanjeGlumca.Controls.Add(this.cbxListGlumaca, 1, 0);
            this.tblDodavanjeGlumca.Controls.Add(this.lblNoviNaslov, 0, 1);
            this.tblDodavanjeGlumca.Controls.Add(this.label12, 0, 2);
            this.tblDodavanjeGlumca.Controls.Add(this.label13, 0, 3);
            this.tblDodavanjeGlumca.Controls.Add(this.label14, 0, 4);
            this.tblDodavanjeGlumca.Controls.Add(this.label15, 0, 5);
            this.tblDodavanjeGlumca.Controls.Add(this.label16, 0, 6);
            this.tblDodavanjeGlumca.Controls.Add(this.dtpDatum, 1, 4);
            this.tblDodavanjeGlumca.Controls.Add(this.cbxGrad, 1, 5);
            this.tblDodavanjeGlumca.Controls.Add(this.txtBiografija, 1, 6);
            this.tblDodavanjeGlumca.Controls.Add(this.txtIme, 1, 2);
            this.tblDodavanjeGlumca.Controls.Add(this.txtPrezime, 1, 3);
            this.tblDodavanjeGlumca.Controls.Add(this.bttnDodajGlumcaOdustani, 0, 7);
            this.tblDodavanjeGlumca.Controls.Add(this.bttnDodajGlumcaDodaj, 1, 7);
            this.tblDodavanjeGlumca.Location = new System.Drawing.Point(914, 337);
            this.tblDodavanjeGlumca.Name = "tblDodavanjeGlumca";
            this.tblDodavanjeGlumca.RowCount = 8;
            this.tblDodavanjeGlumca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblDodavanjeGlumca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblDodavanjeGlumca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblDodavanjeGlumca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblDodavanjeGlumca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblDodavanjeGlumca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblDodavanjeGlumca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblDodavanjeGlumca.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tblDodavanjeGlumca.Size = new System.Drawing.Size(318, 329);
            this.tblDodavanjeGlumca.TabIndex = 10;
            this.tblDodavanjeGlumca.Visible = false;
            this.tblDodavanjeGlumca.VisibleChanged += new System.EventHandler(this.tblDodavanjeGlumca_VisibleChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 35);
            this.label10.TabIndex = 0;
            this.label10.Text = "Odaberi glumca";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxListGlumaca
            // 
            this.cbxListGlumaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListGlumaca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxListGlumaca.FormattingEnabled = true;
            this.cbxListGlumaca.Location = new System.Drawing.Point(126, 3);
            this.cbxListGlumaca.Name = "cbxListGlumaca";
            this.cbxListGlumaca.Size = new System.Drawing.Size(156, 24);
            this.cbxListGlumaca.TabIndex = 1;
            // 
            // lblNoviNaslov
            // 
            this.lblNoviNaslov.AutoSize = true;
            this.lblNoviNaslov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoviNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoviNaslov.Location = new System.Drawing.Point(3, 35);
            this.lblNoviNaslov.Name = "lblNoviNaslov";
            this.lblNoviNaslov.Size = new System.Drawing.Size(117, 50);
            this.lblNoviNaslov.TabIndex = 2;
            this.lblNoviNaslov.Text = "Novi glumac";
            this.lblNoviNaslov.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(3, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ime";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(3, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Prezime";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(3, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Datum rođenja";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(3, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Grad";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Location = new System.Drawing.Point(3, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Biografija";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(126, 168);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(156, 22);
            this.dtpDatum.TabIndex = 10;
            // 
            // cbxGrad
            // 
            this.cbxGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGrad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxGrad.FormattingEnabled = true;
            this.cbxGrad.Location = new System.Drawing.Point(126, 208);
            this.cbxGrad.Name = "cbxGrad";
            this.cbxGrad.Size = new System.Drawing.Size(156, 24);
            this.cbxGrad.TabIndex = 11;
            this.cbxGrad.Validating += new System.ComponentModel.CancelEventHandler(this.cbxGrad_Validating);
            // 
            // txtBiografija
            // 
            this.txtBiografija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBiografija.Location = new System.Drawing.Point(126, 248);
            this.txtBiografija.Name = "txtBiografija";
            this.txtBiografija.Size = new System.Drawing.Size(156, 45);
            this.txtBiografija.TabIndex = 12;
            this.txtBiografija.Text = "";
            this.txtBiografija.Validating += new System.ComponentModel.CancelEventHandler(this.txtBiografija_Validating);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(126, 88);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(156, 22);
            this.txtIme.TabIndex = 13;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(126, 128);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(156, 22);
            this.txtPrezime.TabIndex = 14;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // bttnDodajGlumcaOdustani
            // 
            this.bttnDodajGlumcaOdustani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnDodajGlumcaOdustani.Location = new System.Drawing.Point(3, 299);
            this.bttnDodajGlumcaOdustani.Name = "bttnDodajGlumcaOdustani";
            this.bttnDodajGlumcaOdustani.Size = new System.Drawing.Size(117, 27);
            this.bttnDodajGlumcaOdustani.TabIndex = 15;
            this.bttnDodajGlumcaOdustani.Text = "Odustani";
            this.bttnDodajGlumcaOdustani.UseVisualStyleBackColor = true;
            this.bttnDodajGlumcaOdustani.Click += new System.EventHandler(this.bttnDodajGlumcaOdustani_Click);
            // 
            // bttnDodajGlumcaDodaj
            // 
            this.bttnDodajGlumcaDodaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnDodajGlumcaDodaj.Location = new System.Drawing.Point(126, 299);
            this.bttnDodajGlumcaDodaj.Name = "bttnDodajGlumcaDodaj";
            this.bttnDodajGlumcaDodaj.Size = new System.Drawing.Size(189, 27);
            this.bttnDodajGlumcaDodaj.TabIndex = 16;
            this.bttnDodajGlumcaDodaj.Text = "Dodaj";
            this.bttnDodajGlumcaDodaj.UseVisualStyleBackColor = true;
            this.bttnDodajGlumcaDodaj.Click += new System.EventHandler(this.bttnDodajGlumcaDodaj_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(702, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 18);
            this.label17.TabIndex = 11;
            this.label17.Text = "Komentari";
            // 
            // tblDodajPrKucu
            // 
            this.tblDodajPrKucu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDodajPrKucu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tblDodajPrKucu.ColumnCount = 2;
            this.tblDodajPrKucu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.56863F));
            this.tblDodajPrKucu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.43137F));
            this.tblDodajPrKucu.Controls.Add(this.label11, 0, 0);
            this.tblDodajPrKucu.Controls.Add(this.label18, 0, 1);
            this.tblDodajPrKucu.Controls.Add(this.cbxListKuca, 1, 0);
            this.tblDodajPrKucu.Controls.Add(this.label19, 0, 2);
            this.tblDodajPrKucu.Controls.Add(this.label20, 0, 3);
            this.tblDodajPrKucu.Controls.Add(this.txtKucaNaziv, 1, 2);
            this.tblDodajPrKucu.Controls.Add(this.cbxKucaGrad, 1, 3);
            this.tblDodajPrKucu.Controls.Add(this.bttnDodajPrKucuOdustani, 0, 4);
            this.tblDodajPrKucu.Controls.Add(this.bttnDodajPrKucuDodaj, 1, 4);
            this.tblDodajPrKucu.Location = new System.Drawing.Point(919, 520);
            this.tblDodajPrKucu.Name = "tblDodajPrKucu";
            this.tblDodajPrKucu.RowCount = 5;
            this.tblDodajPrKucu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tblDodajPrKucu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tblDodajPrKucu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblDodajPrKucu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblDodajPrKucu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblDodajPrKucu.Size = new System.Drawing.Size(318, 150);
            this.tblDodajPrKucu.TabIndex = 12;
            this.tblDodajPrKucu.Visible = false;
            this.tblDodajPrKucu.VisibleChanged += new System.EventHandler(this.tblDodajPrKucu_VisibleChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Odaberi";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 18);
            this.label18.TabIndex = 1;
            this.label18.Text = "Nova pr. kuca";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbxListKuca
            // 
            this.cbxListKuca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxListKuca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListKuca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxListKuca.FormattingEnabled = true;
            this.cbxListKuca.Location = new System.Drawing.Point(135, 3);
            this.cbxListKuca.Name = "cbxListKuca";
            this.cbxListKuca.Size = new System.Drawing.Size(146, 24);
            this.cbxListKuca.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "Naziv";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "Grad";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKucaNaziv
            // 
            this.txtKucaNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKucaNaziv.Location = new System.Drawing.Point(135, 64);
            this.txtKucaNaziv.Name = "txtKucaNaziv";
            this.txtKucaNaziv.Size = new System.Drawing.Size(146, 22);
            this.txtKucaNaziv.TabIndex = 5;
            this.txtKucaNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtKucaNaziv_Validating);
            // 
            // cbxKucaGrad
            // 
            this.cbxKucaGrad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxKucaGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKucaGrad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxKucaGrad.FormattingEnabled = true;
            this.cbxKucaGrad.Location = new System.Drawing.Point(135, 89);
            this.cbxKucaGrad.Name = "cbxKucaGrad";
            this.cbxKucaGrad.Size = new System.Drawing.Size(146, 24);
            this.cbxKucaGrad.TabIndex = 6;
            this.cbxKucaGrad.Validating += new System.ComponentModel.CancelEventHandler(this.cbxKucaGrad_Validating);
            // 
            // bttnDodajPrKucuOdustani
            // 
            this.bttnDodajPrKucuOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDodajPrKucuOdustani.Location = new System.Drawing.Point(3, 120);
            this.bttnDodajPrKucuOdustani.Name = "bttnDodajPrKucuOdustani";
            this.bttnDodajPrKucuOdustani.Size = new System.Drawing.Size(126, 27);
            this.bttnDodajPrKucuOdustani.TabIndex = 7;
            this.bttnDodajPrKucuOdustani.Text = "Odustani";
            this.bttnDodajPrKucuOdustani.UseVisualStyleBackColor = true;
            this.bttnDodajPrKucuOdustani.Click += new System.EventHandler(this.bttnDodajPrKucuOdustani_Click);
            // 
            // bttnDodajPrKucuDodaj
            // 
            this.bttnDodajPrKucuDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDodajPrKucuDodaj.Location = new System.Drawing.Point(135, 120);
            this.bttnDodajPrKucuDodaj.Name = "bttnDodajPrKucuDodaj";
            this.bttnDodajPrKucuDodaj.Size = new System.Drawing.Size(180, 27);
            this.bttnDodajPrKucuDodaj.TabIndex = 8;
            this.bttnDodajPrKucuDodaj.Text = "Dodaj";
            this.bttnDodajPrKucuDodaj.UseVisualStyleBackColor = true;
            this.bttnDodajPrKucuDodaj.Click += new System.EventHandler(this.bttnDodajPrKucuDodaj_Click);
            // 
            // tblDodajProjekciju
            // 
            this.tblDodajProjekciju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDodajProjekciju.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tblDodajProjekciju.ColumnCount = 2;
            this.tblDodajProjekciju.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.25157F));
            this.tblDodajProjekciju.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.74843F));
            this.tblDodajProjekciju.Controls.Add(this.label22, 0, 2);
            this.tblDodajProjekciju.Controls.Add(this.label21, 0, 1);
            this.tblDodajProjekciju.Controls.Add(this.label23, 0, 3);
            this.tblDodajProjekciju.Controls.Add(this.label24, 0, 4);
            this.tblDodajProjekciju.Controls.Add(this.dtpDatumProjekcije, 1, 1);
            this.tblDodajProjekciju.Controls.Add(this.cbxDvoranaProjekcije, 1, 3);
            this.tblDodajProjekciju.Controls.Add(this.txtCijenaProjekcije, 1, 2);
            this.tblDodajProjekciju.Controls.Add(this.txtOpisProjekcije, 1, 4);
            this.tblDodajProjekciju.Controls.Add(this.bttnDodajProjekcijuOdustani, 0, 5);
            this.tblDodajProjekciju.Controls.Add(this.bttnDodajProjekcijuDodaj, 1, 5);
            this.tblDodajProjekciju.Controls.Add(this.label26, 0, 0);
            this.tblDodajProjekciju.Location = new System.Drawing.Point(917, 466);
            this.tblDodajProjekciju.Name = "tblDodajProjekciju";
            this.tblDodajProjekciju.RowCount = 6;
            this.tblDodajProjekciju.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblDodajProjekciju.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDodajProjekciju.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDodajProjekciju.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblDodajProjekciju.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblDodajProjekciju.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblDodajProjekciju.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDodajProjekciju.Size = new System.Drawing.Size(318, 204);
            this.tblDodajProjekciju.TabIndex = 13;
            this.tblDodajProjekciju.Visible = false;
            this.tblDodajProjekciju.VisibleChanged += new System.EventHandler(this.tblDodajProjekciju_VisibleChanged);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "Cijena";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "Datum";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 95);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 17);
            this.label23.TabIndex = 2;
            this.label23.Text = "Dvorana";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 123);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 17);
            this.label24.TabIndex = 3;
            this.label24.Text = "Opis";
            this.label24.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dtpDatumProjekcije
            // 
            this.dtpDatumProjekcije.Location = new System.Drawing.Point(130, 46);
            this.dtpDatumProjekcije.Name = "dtpDatumProjekcije";
            this.dtpDatumProjekcije.Size = new System.Drawing.Size(153, 22);
            this.dtpDatumProjekcije.TabIndex = 4;
            // 
            // cbxDvoranaProjekcije
            // 
            this.cbxDvoranaProjekcije.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxDvoranaProjekcije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDvoranaProjekcije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxDvoranaProjekcije.FormattingEnabled = true;
            this.cbxDvoranaProjekcije.Location = new System.Drawing.Point(130, 98);
            this.cbxDvoranaProjekcije.Name = "cbxDvoranaProjekcije";
            this.cbxDvoranaProjekcije.Size = new System.Drawing.Size(153, 24);
            this.cbxDvoranaProjekcije.TabIndex = 5;
            this.cbxDvoranaProjekcije.Validating += new System.ComponentModel.CancelEventHandler(this.cbxDvoranaProjekcije_Validating);
            // 
            // txtCijenaProjekcije
            // 
            this.txtCijenaProjekcije.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCijenaProjekcije.Location = new System.Drawing.Point(130, 72);
            this.txtCijenaProjekcije.Name = "txtCijenaProjekcije";
            this.txtCijenaProjekcije.Size = new System.Drawing.Size(153, 22);
            this.txtCijenaProjekcije.TabIndex = 6;
            this.txtCijenaProjekcije.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijenaProjekcije_Validating);
            // 
            // txtOpisProjekcije
            // 
            this.txtOpisProjekcije.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOpisProjekcije.Location = new System.Drawing.Point(130, 126);
            this.txtOpisProjekcije.Name = "txtOpisProjekcije";
            this.txtOpisProjekcije.Size = new System.Drawing.Size(153, 45);
            this.txtOpisProjekcije.TabIndex = 7;
            this.txtOpisProjekcije.Text = "";
            this.txtOpisProjekcije.Validating += new System.ComponentModel.CancelEventHandler(this.txtOpisProjekcije_Validating);
            // 
            // bttnDodajProjekcijuOdustani
            // 
            this.bttnDodajProjekcijuOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDodajProjekcijuOdustani.Location = new System.Drawing.Point(3, 177);
            this.bttnDodajProjekcijuOdustani.Name = "bttnDodajProjekcijuOdustani";
            this.bttnDodajProjekcijuOdustani.Size = new System.Drawing.Size(121, 24);
            this.bttnDodajProjekcijuOdustani.TabIndex = 8;
            this.bttnDodajProjekcijuOdustani.Text = "Odustani";
            this.bttnDodajProjekcijuOdustani.UseVisualStyleBackColor = true;
            this.bttnDodajProjekcijuOdustani.Click += new System.EventHandler(this.bttnDodajProjekcijuOdustani_Click);
            // 
            // bttnDodajProjekcijuDodaj
            // 
            this.bttnDodajProjekcijuDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDodajProjekcijuDodaj.Location = new System.Drawing.Point(130, 177);
            this.bttnDodajProjekcijuDodaj.Name = "bttnDodajProjekcijuDodaj";
            this.bttnDodajProjekcijuDodaj.Size = new System.Drawing.Size(185, 24);
            this.bttnDodajProjekcijuDodaj.TabIndex = 9;
            this.bttnDodajProjekcijuDodaj.Text = "Dodaj";
            this.bttnDodajProjekcijuDodaj.UseVisualStyleBackColor = true;
            this.bttnDodajProjekcijuDodaj.Click += new System.EventHandler(this.bttnDodajProjekcijuDodaj_Click);
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(121, 43);
            this.label26.TabIndex = 12;
            this.label26.Text = "Nova projekcija";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblKomentari
            // 
            this.tblKomentari.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblKomentari.AutoScroll = true;
            this.tblKomentari.ColumnCount = 1;
            this.tblKomentari.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.09091F));
            this.tblKomentari.Location = new System.Drawing.Point(657, 289);
            this.tblKomentari.MaximumSize = new System.Drawing.Size(266, 265);
            this.tblKomentari.Name = "tblKomentari";
            this.tblKomentari.RowCount = 20;
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblKomentari.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblKomentari.Size = new System.Drawing.Size(266, 265);
            this.tblKomentari.TabIndex = 3;
            // 
            // bttnOcijeniFilm
            // 
            this.bttnOcijeniFilm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnOcijeniFilm.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnOcijeniFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOcijeniFilm.Location = new System.Drawing.Point(222, 645);
            this.bttnOcijeniFilm.Name = "bttnOcijeniFilm";
            this.bttnOcijeniFilm.Size = new System.Drawing.Size(366, 39);
            this.bttnOcijeniFilm.TabIndex = 14;
            this.bttnOcijeniFilm.Text = "Ocijeni film";
            this.bttnOcijeniFilm.UseVisualStyleBackColor = false;
            this.bttnOcijeniFilm.Click += new System.EventHandler(this.bttnOcijeniFilm_Click);
            // 
            // bttnDodajKomentar
            // 
            this.bttnDodajKomentar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnDodajKomentar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnDodajKomentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDodajKomentar.Location = new System.Drawing.Point(594, 645);
            this.bttnDodajKomentar.Name = "bttnDodajKomentar";
            this.bttnDodajKomentar.Size = new System.Drawing.Size(329, 39);
            this.bttnDodajKomentar.TabIndex = 15;
            this.bttnDodajKomentar.Text = "Dodaj komentar";
            this.bttnDodajKomentar.UseVisualStyleBackColor = false;
            this.bttnDodajKomentar.Click += new System.EventHandler(this.bttnDodajKomentar_Click);
            // 
            // tblZaOcjenjivanjeFilma
            // 
            this.tblZaOcjenjivanjeFilma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblZaOcjenjivanjeFilma.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblZaOcjenjivanjeFilma.ColumnCount = 1;
            this.tblZaOcjenjivanjeFilma.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblZaOcjenjivanjeFilma.Controls.Add(this.label25, 0, 0);
            this.tblZaOcjenjivanjeFilma.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tblZaOcjenjivanjeFilma.Location = new System.Drawing.Point(412, 212);
            this.tblZaOcjenjivanjeFilma.Name = "tblZaOcjenjivanjeFilma";
            this.tblZaOcjenjivanjeFilma.RowCount = 2;
            this.tblZaOcjenjivanjeFilma.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.25581F));
            this.tblZaOcjenjivanjeFilma.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.74419F));
            this.tblZaOcjenjivanjeFilma.Size = new System.Drawing.Size(368, 129);
            this.tblZaOcjenjivanjeFilma.TabIndex = 0;
            this.tblZaOcjenjivanjeFilma.Visible = false;
            this.tblZaOcjenjivanjeFilma.VisibleChanged += new System.EventHandler(this.tblZaOcjenjivanjeFilma_VisibleChanged);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(4, 1);
            this.label25.Name = "label25";
            this.label25.Padding = new System.Windows.Forms.Padding(3);
            this.label25.Size = new System.Drawing.Size(360, 24);
            this.label25.TabIndex = 0;
            this.label25.Text = "Unesite ocjenu za odabrani film";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.label27, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cbxListOcijena, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 34);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(360, 91);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.bttnPotvrdiOcijenu, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.bttnOdustaniOdOcijenjivanja, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(83, 48);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(274, 40);
            this.tableLayoutPanel8.TabIndex = 2;
            // 
            // bttnPotvrdiOcijenu
            // 
            this.bttnPotvrdiOcijenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnPotvrdiOcijenu.Location = new System.Drawing.Point(3, 3);
            this.bttnPotvrdiOcijenu.Name = "bttnPotvrdiOcijenu";
            this.bttnPotvrdiOcijenu.Size = new System.Drawing.Size(131, 34);
            this.bttnPotvrdiOcijenu.TabIndex = 0;
            this.bttnPotvrdiOcijenu.Text = "Potvrdi";
            this.bttnPotvrdiOcijenu.UseVisualStyleBackColor = true;
            this.bttnPotvrdiOcijenu.Click += new System.EventHandler(this.bttnPotvrdiOcijenu_Click);
            // 
            // bttnOdustaniOdOcijenjivanja
            // 
            this.bttnOdustaniOdOcijenjivanja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnOdustaniOdOcijenjivanja.Location = new System.Drawing.Point(140, 3);
            this.bttnOdustaniOdOcijenjivanja.Name = "bttnOdustaniOdOcijenjivanja";
            this.bttnOdustaniOdOcijenjivanja.Size = new System.Drawing.Size(131, 34);
            this.bttnOdustaniOdOcijenjivanja.TabIndex = 1;
            this.bttnOdustaniOdOcijenjivanja.Text = "Odustani";
            this.bttnOdustaniOdOcijenjivanja.UseVisualStyleBackColor = true;
            this.bttnOdustaniOdOcijenjivanja.Click += new System.EventHandler(this.bttnOdustaniOdOcijenjivanja_Click);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(21, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 45);
            this.label27.TabIndex = 0;
            this.label27.Text = "Ocijena";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxListOcijena
            // 
            this.cbxListOcijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxListOcijena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListOcijena.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxListOcijena.FormattingEnabled = true;
            this.cbxListOcijena.Location = new System.Drawing.Point(83, 10);
            this.cbxListOcijena.Name = "cbxListOcijena";
            this.cbxListOcijena.Size = new System.Drawing.Size(274, 24);
            this.cbxListOcijena.TabIndex = 1;
            this.cbxListOcijena.Validating += new System.ComponentModel.CancelEventHandler(this.cbxListOcijena_Validating);
            // 
            // tblZaDodavanjeKomentara
            // 
            this.tblZaDodavanjeKomentara.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblZaDodavanjeKomentara.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblZaDodavanjeKomentara.ColumnCount = 1;
            this.tblZaDodavanjeKomentara.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblZaDodavanjeKomentara.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tblZaDodavanjeKomentara.Controls.Add(this.label28, 0, 0);
            this.tblZaDodavanjeKomentara.Location = new System.Drawing.Point(405, 227);
            this.tblZaDodavanjeKomentara.Name = "tblZaDodavanjeKomentara";
            this.tblZaDodavanjeKomentara.RowCount = 2;
            this.tblZaDodavanjeKomentara.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.11594F));
            this.tblZaDodavanjeKomentara.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.88406F));
            this.tblZaDodavanjeKomentara.Size = new System.Drawing.Size(379, 188);
            this.tblZaDodavanjeKomentara.TabIndex = 16;
            this.tblZaDodavanjeKomentara.Visible = false;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.75F));
            this.tableLayoutPanel9.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtKomentar, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 1, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 38);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.86301F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.13699F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(371, 146);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(43, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(69, 101);
            this.label29.TabIndex = 0;
            this.label29.Text = "Komentar";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKomentar.Location = new System.Drawing.Point(118, 10);
            this.txtKomentar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(224, 81);
            this.txtKomentar.TabIndex = 1;
            this.txtKomentar.Text = "";
            this.txtKomentar.Validating += new System.ComponentModel.CancelEventHandler(this.txtKomentar_Validating);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel10.Controls.Add(this.bttnPotvrdiKomentar, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.bttnOdustaniOdKomentara, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(118, 104);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(224, 39);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // bttnPotvrdiKomentar
            // 
            this.bttnPotvrdiKomentar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnPotvrdiKomentar.Location = new System.Drawing.Point(3, 3);
            this.bttnPotvrdiKomentar.Name = "bttnPotvrdiKomentar";
            this.bttnPotvrdiKomentar.Size = new System.Drawing.Size(110, 33);
            this.bttnPotvrdiKomentar.TabIndex = 0;
            this.bttnPotvrdiKomentar.Text = "Potvrdi";
            this.bttnPotvrdiKomentar.UseVisualStyleBackColor = true;
            this.bttnPotvrdiKomentar.Click += new System.EventHandler(this.bttnPotvrdiKomentar_Click);
            // 
            // bttnOdustaniOdKomentara
            // 
            this.bttnOdustaniOdKomentara.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnOdustaniOdKomentara.Location = new System.Drawing.Point(119, 3);
            this.bttnOdustaniOdKomentara.Name = "bttnOdustaniOdKomentara";
            this.bttnOdustaniOdKomentara.Size = new System.Drawing.Size(102, 33);
            this.bttnOdustaniOdKomentara.TabIndex = 1;
            this.bttnOdustaniOdKomentara.Text = "Odustani";
            this.bttnOdustaniOdKomentara.UseVisualStyleBackColor = true;
            this.bttnOdustaniOdKomentara.Click += new System.EventHandler(this.bttnOdustaniOdKomentara_Click);
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(4, 1);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(371, 18);
            this.label28.TabIndex = 0;
            this.label28.Text = "Unesite vaš komentar";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblLikeAndDislike
            // 
            this.tblLikeAndDislike.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblLikeAndDislike.ColumnCount = 1;
            this.tblLikeAndDislike.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLikeAndDislike.Controls.Add(this.bttnLike, 0, 0);
            this.tblLikeAndDislike.Controls.Add(this.bttnDislike, 0, 1);
            this.tblLikeAndDislike.Location = new System.Drawing.Point(929, 289);
            this.tblLikeAndDislike.Name = "tblLikeAndDislike";
            this.tblLikeAndDislike.RowCount = 2;
            this.tblLikeAndDislike.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLikeAndDislike.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLikeAndDislike.Size = new System.Drawing.Size(63, 115);
            this.tblLikeAndDislike.TabIndex = 17;
            this.tblLikeAndDislike.Visible = false;
            // 
            // bttnLike
            // 
            this.bttnLike.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLike.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.bttnLike.Location = new System.Drawing.Point(3, 3);
            this.bttnLike.Name = "bttnLike";
            this.bttnLike.Size = new System.Drawing.Size(57, 51);
            this.bttnLike.TabIndex = 0;
            this.bttnLike.Text = "👍";
            this.bttnLike.UseVisualStyleBackColor = true;
            this.bttnLike.Click += new System.EventHandler(this.bttnLike_Click);
            // 
            // bttnDislike
            // 
            this.bttnDislike.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDislike.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDislike.ForeColor = System.Drawing.Color.Red;
            this.bttnDislike.Location = new System.Drawing.Point(3, 60);
            this.bttnDislike.Name = "bttnDislike";
            this.bttnDislike.Size = new System.Drawing.Size(57, 52);
            this.bttnDislike.TabIndex = 1;
            this.bttnDislike.Text = "👎";
            this.bttnDislike.UseVisualStyleBackColor = true;
            this.bttnDislike.Click += new System.EventHandler(this.bttnDislike_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bttnPrijave
            // 
            this.bttnPrijave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnPrijave.BackColor = System.Drawing.Color.LightSalmon;
            this.bttnPrijave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPrijave.Location = new System.Drawing.Point(216, 93);
            this.bttnPrijave.Name = "bttnPrijave";
            this.bttnPrijave.Size = new System.Drawing.Size(82, 66);
            this.bttnPrijave.TabIndex = 18;
            this.bttnPrijave.Text = "Prijave";
            this.bttnPrijave.UseVisualStyleBackColor = false;
            this.bttnPrijave.Click += new System.EventHandler(this.bttnPrijave_Click);
            // 
            // frmFilmDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1227, 721);
            this.Controls.Add(this.bttnPrijave);
            this.Controls.Add(this.tblDodajProjekciju);
            this.Controls.Add(this.tblDodavanjeGlumca);
            this.Controls.Add(this.tblDodajPrKucu);
            this.Controls.Add(this.tblLikeAndDislike);
            this.Controls.Add(this.tblZaDodavanjeKomentara);
            this.Controls.Add(this.tblZaOcjenjivanjeFilma);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblKomentari);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbxSlika);
            this.Controls.Add(this.bttnDodajKomentar);
            this.Controls.Add(this.bttnOcijeniFilm);
            this.Controls.Add(this.tblOcijena);
            this.MinimumSize = new System.Drawing.Size(922, 768);
            this.Name = "frmFilmDetalji";
            this.Text = "frmFilmDetalji";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFilmDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tblOcijena.ResumeLayout(false);
            this.tblOcijena.PerformLayout();
            this.tblDodavanjeGlumca.ResumeLayout(false);
            this.tblDodavanjeGlumca.PerformLayout();
            this.tblDodajPrKucu.ResumeLayout(false);
            this.tblDodajPrKucu.PerformLayout();
            this.tblDodajProjekciju.ResumeLayout(false);
            this.tblDodajProjekciju.PerformLayout();
            this.tblZaOcjenjivanjeFilma.ResumeLayout(false);
            this.tblZaOcjenjivanjeFilma.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tblZaDodavanjeKomentara.ResumeLayout(false);
            this.tblZaDodavanjeKomentara.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tblLikeAndDislike.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSlika;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblZanr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProjekcija;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TableLayoutPanel tblOcijena;
        private System.Windows.Forms.Label lblOcijena1;
        private System.Windows.Forms.Label lblOcijena5;
        private System.Windows.Forms.Label lblOcijena4;
        private System.Windows.Forms.Label lblOcijena3;
        private System.Windows.Forms.Label lblOcijena2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttnDodajGlumca;
        private System.Windows.Forms.Button bttnDodajScenaristu;
        private System.Windows.Forms.Button bttnDodajPrKucu;
        private System.Windows.Forms.Button bttnDodajProjekciju;
        private System.Windows.Forms.TableLayoutPanel tblDodavanjeGlumca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxListGlumaca;
        private System.Windows.Forms.Label lblNoviNaslov;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cbxGrad;
        private System.Windows.Forms.RichTextBox txtBiografija;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button bttnDodajGlumcaOdustani;
        private System.Windows.Forms.Button bttnDodajGlumcaDodaj;
        private System.Windows.Forms.TableLayoutPanel pnlGlumci;
        private System.Windows.Forms.TableLayoutPanel pnlScenaristi;
        private System.Windows.Forms.TableLayoutPanel pnlPrKuce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tblDodajPrKucu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxListKuca;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtKucaNaziv;
        private System.Windows.Forms.ComboBox cbxKucaGrad;
        private System.Windows.Forms.Button bttnDodajPrKucuOdustani;
        private System.Windows.Forms.Button bttnDodajPrKucuDodaj;
        private System.Windows.Forms.TableLayoutPanel tblDodajProjekciju;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpDatumProjekcije;
        private System.Windows.Forms.ComboBox cbxDvoranaProjekcije;
        private System.Windows.Forms.TextBox txtCijenaProjekcije;
        private System.Windows.Forms.RichTextBox txtOpisProjekcije;
        private System.Windows.Forms.Button bttnDodajProjekcijuOdustani;
        private System.Windows.Forms.Button bttnDodajProjekcijuDodaj;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TableLayoutPanel tblKomentari;
        private System.Windows.Forms.Button bttnOcijeniFilm;
        private System.Windows.Forms.Button bttnDodajKomentar;
        private System.Windows.Forms.TableLayoutPanel tblZaOcjenjivanjeFilma;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbxListOcijena;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button bttnPotvrdiOcijenu;
        private System.Windows.Forms.Button bttnOdustaniOdOcijenjivanja;
        private System.Windows.Forms.TableLayoutPanel tblZaDodavanjeKomentara;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RichTextBox txtKomentar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button bttnPotvrdiKomentar;
        private System.Windows.Forms.Button bttnOdustaniOdKomentara;
        private System.Windows.Forms.TableLayoutPanel tblLikeAndDislike;
        private System.Windows.Forms.Button bttnLike;
        private System.Windows.Forms.Button bttnDislike;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button bttnPrijave;
    }
}