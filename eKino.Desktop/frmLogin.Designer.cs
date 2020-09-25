namespace eKino.Desktop
{
    partial class frmLogin
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
            this.bttnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labKorisnickoIme = new System.Windows.Forms.Label();
            this.labSifra = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.bttnRegistracija = new System.Windows.Forms.Button();
            this.labNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnLogin
            // 
            this.bttnLogin.Location = new System.Drawing.Point(69, 256);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(507, 51);
            this.bttnLogin.TabIndex = 0;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(68, 78);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(509, 28);
            this.txtEmail.TabIndex = 2;
            // 
            // labKorisnickoIme
            // 
            this.labKorisnickoIme.AutoSize = true;
            this.labKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labKorisnickoIme.Location = new System.Drawing.Point(65, 46);
            this.labKorisnickoIme.Name = "labKorisnickoIme";
            this.labKorisnickoIme.Size = new System.Drawing.Size(57, 24);
            this.labKorisnickoIme.TabIndex = 3;
            this.labKorisnickoIme.Text = "Email";
            // 
            // labSifra
            // 
            this.labSifra.AutoSize = true;
            this.labSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSifra.Location = new System.Drawing.Point(64, 131);
            this.labSifra.Name = "labSifra";
            this.labSifra.Size = new System.Drawing.Size(46, 24);
            this.labSifra.TabIndex = 5;
            this.labSifra.Text = "Sifra";
            // 
            // txtSifra
            // 
            this.txtSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifra.Location = new System.Drawing.Point(67, 163);
            this.txtSifra.Multiline = true;
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.PasswordChar = '*';
            this.txtSifra.Size = new System.Drawing.Size(509, 28);
            this.txtSifra.TabIndex = 4;
            // 
            // bttnRegistracija
            // 
            this.bttnRegistracija.Location = new System.Drawing.Point(67, 327);
            this.bttnRegistracija.Name = "bttnRegistracija";
            this.bttnRegistracija.Size = new System.Drawing.Size(507, 51);
            this.bttnRegistracija.TabIndex = 6;
            this.bttnRegistracija.Text = "Registracija";
            this.bttnRegistracija.UseVisualStyleBackColor = true;
            this.bttnRegistracija.Click += new System.EventHandler(this.bttnRegistracija_Click);
            // 
            // labNaslov
            // 
            this.labNaslov.AutoSize = true;
            this.labNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNaslov.Location = new System.Drawing.Point(272, 9);
            this.labNaslov.Name = "labNaslov";
            this.labNaslov.Size = new System.Drawing.Size(81, 29);
            this.labNaslov.TabIndex = 8;
            this.labNaslov.Text = "eKino";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(642, 404);
            this.Controls.Add(this.labNaslov);
            this.Controls.Add(this.bttnRegistracija);
            this.Controls.Add(this.labSifra);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.labKorisnickoIme);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.bttnLogin);
            this.MaximumSize = new System.Drawing.Size(660, 451);
            this.MinimumSize = new System.Drawing.Size(660, 451);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labKorisnickoIme;
        private System.Windows.Forms.Label labSifra;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Button bttnRegistracija;
        private System.Windows.Forms.Label labNaslov;
    }
}

