namespace eKino.Desktop
{
    partial class frmRegistracija
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
            this.bttnRegistrujSe = new System.Windows.Forms.Button();
            this.labIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.labRegistracijaNaslov = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.labPrezime = new System.Windows.Forms.Label();
            this.labDatumRodjenja = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.labSifra = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.labGrad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnRegistrujSe
            // 
            this.bttnRegistrujSe.Location = new System.Drawing.Point(610, 384);
            this.bttnRegistrujSe.Name = "bttnRegistrujSe";
            this.bttnRegistrujSe.Size = new System.Drawing.Size(161, 36);
            this.bttnRegistrujSe.TabIndex = 0;
            this.bttnRegistrujSe.Text = "Registruj se";
            this.bttnRegistrujSe.UseVisualStyleBackColor = true;
            this.bttnRegistrujSe.Click += new System.EventHandler(this.bttnRegistrujSe_Click);
            // 
            // labIme
            // 
            this.labIme.AutoSize = true;
            this.labIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIme.Location = new System.Drawing.Point(28, 52);
            this.labIme.Name = "labIme";
            this.labIme.Size = new System.Drawing.Size(36, 20);
            this.labIme.TabIndex = 1;
            this.labIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(32, 75);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(323, 22);
            this.txtIme.TabIndex = 2;
            // 
            // labRegistracijaNaslov
            // 
            this.labRegistracijaNaslov.AutoSize = true;
            this.labRegistracijaNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRegistracijaNaslov.Location = new System.Drawing.Point(320, 9);
            this.labRegistracijaNaslov.Name = "labRegistracijaNaslov";
            this.labRegistracijaNaslov.Size = new System.Drawing.Size(124, 25);
            this.labRegistracijaNaslov.TabIndex = 3;
            this.labRegistracijaNaslov.Text = "Registracija";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(32, 144);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(323, 22);
            this.txtPrezime.TabIndex = 5;
            // 
            // labPrezime
            // 
            this.labPrezime.AutoSize = true;
            this.labPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPrezime.Location = new System.Drawing.Point(28, 121);
            this.labPrezime.Name = "labPrezime";
            this.labPrezime.Size = new System.Drawing.Size(71, 20);
            this.labPrezime.TabIndex = 4;
            this.labPrezime.Text = "Prezime";
            // 
            // labDatumRodjenja
            // 
            this.labDatumRodjenja.AutoSize = true;
            this.labDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDatumRodjenja.Location = new System.Drawing.Point(28, 201);
            this.labDatumRodjenja.Name = "labDatumRodjenja";
            this.labDatumRodjenja.Size = new System.Drawing.Size(119, 20);
            this.labDatumRodjenja.TabIndex = 6;
            this.labDatumRodjenja.Text = "Datum rođenja";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(32, 300);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmail.Location = new System.Drawing.Point(28, 277);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(51, 20);
            this.labEmail.TabIndex = 8;
            this.labEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Slika";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(443, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 146);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(32, 383);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(323, 22);
            this.txtSifra.TabIndex = 13;
            // 
            // labSifra
            // 
            this.labSifra.AutoSize = true;
            this.labSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSifra.Location = new System.Drawing.Point(28, 360);
            this.labSifra.Name = "labSifra";
            this.labSifra.Size = new System.Drawing.Size(44, 20);
            this.labSifra.TabIndex = 12;
            this.labSifra.Text = "Sifra";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(32, 225);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(323, 22);
            this.dtpDatumRodjenja.TabIndex = 14;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(443, 300);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(323, 22);
            this.txtGrad.TabIndex = 16;
            // 
            // labGrad
            // 
            this.labGrad.AutoSize = true;
            this.labGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGrad.Location = new System.Drawing.Point(439, 277);
            this.labGrad.Name = "labGrad";
            this.labGrad.Size = new System.Drawing.Size(46, 20);
            this.labGrad.TabIndex = 15;
            this.labGrad.Text = "Grad";
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.labGrad);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.labSifra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labDatumRodjenja);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.labPrezime);
            this.Controls.Add(this.labRegistracijaNaslov);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.labIme);
            this.Controls.Add(this.bttnRegistrujSe);
            this.Name = "frmRegistracija";
            this.Text = "frmRegistracija";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnRegistrujSe;
        private System.Windows.Forms.Label labIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label labRegistracijaNaslov;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label labPrezime;
        private System.Windows.Forms.Label labDatumRodjenja;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label labSifra;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label labGrad;
    }
}