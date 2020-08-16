namespace eKino.Desktop
{
    partial class frmUrediAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrediAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblMeni = new System.Windows.Forms.TableLayoutPanel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.rpbAvatar = new eKino.Desktop.RoundPictureBox();
            this.roundPictureBox1 = new eKino.Desktop.RoundPictureBox();
            this.labeKino = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxGrad = new System.Windows.Forms.ComboBox();
            this.cbxUloga = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtLozinkaPotvrda = new System.Windows.Forms.TextBox();
            this.bttnSnimi = new System.Windows.Forms.Button();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.tblMeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel1.Size = new System.Drawing.Size(648, 125);
            this.panel1.TabIndex = 2;
            // 
            // tblMeni
            // 
            this.tblMeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMeni.ColumnCount = 1;
            this.tblMeni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMeni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMeni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMeni.Controls.Add(this.lblNaslov, 0, 0);
            this.tblMeni.Location = new System.Drawing.Point(159, 40);
            this.tblMeni.Margin = new System.Windows.Forms.Padding(4);
            this.tblMeni.Name = "tblMeni";
            this.tblMeni.RowCount = 1;
            this.tblMeni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMeni.Size = new System.Drawing.Size(291, 49);
            this.tblMeni.TabIndex = 1;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(4, 0);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(283, 49);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Modify account";
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpbAvatar
            // 
            this.rpbAvatar.Dock = System.Windows.Forms.DockStyle.Right;
            this.rpbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("rpbAvatar.Image")));
            this.rpbAvatar.Location = new System.Drawing.Point(530, 4);
            this.rpbAvatar.Margin = new System.Windows.Forms.Padding(6);
            this.rpbAvatar.MaximumSize = new System.Drawing.Size(112, 112);
            this.rpbAvatar.MinimumSize = new System.Drawing.Size(112, 112);
            this.rpbAvatar.Name = "rpbAvatar";
            this.rpbAvatar.Padding = new System.Windows.Forms.Padding(1);
            this.rpbAvatar.Size = new System.Drawing.Size(112, 112);
            this.rpbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rpbAvatar.TabIndex = 1;
            this.rpbAvatar.TabStop = false;
            this.rpbAvatar.Click += new System.EventHandler(this.rpbAvatar_Click);
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBox1.Image")));
            this.roundPictureBox1.Location = new System.Drawing.Point(15, 39);
            this.roundPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(99, 79);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox1.TabIndex = 3;
            this.roundPictureBox1.TabStop = false;
            this.roundPictureBox1.Click += new System.EventHandler(this.roundPictureBox1_Click);
            // 
            // labeKino
            // 
            this.labeKino.AutoSize = true;
            this.labeKino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeKino.Location = new System.Drawing.Point(28, 10);
            this.labeKino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeKino.Name = "labeKino";
            this.labeKino.Size = new System.Drawing.Size(68, 25);
            this.labeKino.TabIndex = 0;
            this.labeKino.Text = "eKino";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.48327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.51673F));
            this.tableLayoutPanel1.Controls.Add(this.cbxUloga, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPrezime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbxGrad, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtLozinka, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtLozinkaPotvrda, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatumRodjenja, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 169);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 286);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rodjenja";
            // 
            // txtIme
            // 
            this.txtIme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIme.Location = new System.Drawing.Point(166, 3);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(369, 23);
            this.txtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrezime.Location = new System.Drawing.Point(166, 32);
            this.txtPrezime.Multiline = true;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(369, 23);
            this.txtPrezime.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(166, 61);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(369, 25);
            this.txtEmail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Uloga";
            // 
            // cbxGrad
            // 
            this.cbxGrad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGrad.FormattingEnabled = true;
            this.cbxGrad.Location = new System.Drawing.Point(166, 125);
            this.cbxGrad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbxGrad.Name = "cbxGrad";
            this.cbxGrad.Size = new System.Drawing.Size(369, 24);
            this.cbxGrad.TabIndex = 10;
            // 
            // cbxUloga
            // 
            this.cbxUloga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxUloga.FormattingEnabled = true;
            this.cbxUloga.Location = new System.Drawing.Point(166, 158);
            this.cbxUloga.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbxUloga.Name = "cbxUloga";
            this.cbxUloga.Size = new System.Drawing.Size(369, 24);
            this.cbxUloga.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lozinka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 37);
            this.label8.TabIndex = 13;
            this.label8.Text = "Potvrdi lozinku";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLozinka.Location = new System.Drawing.Point(166, 220);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(369, 22);
            this.txtLozinka.TabIndex = 14;
            // 
            // txtLozinkaPotvrda
            // 
            this.txtLozinkaPotvrda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLozinkaPotvrda.Location = new System.Drawing.Point(166, 252);
            this.txtLozinkaPotvrda.Name = "txtLozinkaPotvrda";
            this.txtLozinkaPotvrda.Size = new System.Drawing.Size(369, 22);
            this.txtLozinkaPotvrda.TabIndex = 15;
            // 
            // bttnSnimi
            // 
            this.bttnSnimi.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnSnimi.Location = new System.Drawing.Point(332, 508);
            this.bttnSnimi.Name = "bttnSnimi";
            this.bttnSnimi.Size = new System.Drawing.Size(238, 38);
            this.bttnSnimi.TabIndex = 4;
            this.bttnSnimi.Text = "Snimi";
            this.bttnSnimi.UseVisualStyleBackColor = false;
            this.bttnSnimi.Click += new System.EventHandler(this.bttnSnimi_Click);
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(166, 94);
            this.dtpDatumRodjenja.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(369, 22);
            this.dtpDatumRodjenja.TabIndex = 16;
            // 
            // frmUrediAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 591);
            this.Controls.Add(this.bttnSnimi);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(666, 638);
            this.Name = "frmUrediAccount";
            this.Text = "frmUrediAccount";
            this.Load += new System.EventHandler(this.frmUrediAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tblMeni.ResumeLayout(false);
            this.tblMeni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tblMeni;
        private System.Windows.Forms.Label lblNaslov;
        private RoundPictureBox rpbAvatar;
        private RoundPictureBox roundPictureBox1;
        private System.Windows.Forms.Label labeKino;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ComboBox cbxUloga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxGrad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtLozinkaPotvrda;
        private System.Windows.Forms.Button bttnSnimi;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
    }
}