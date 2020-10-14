using System;
using System.Collections.Generic;
using System.Drawing;

namespace eKino.Desktop
{
    partial class frmRezervacijaDodavanje
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

        private void GenerisiPolja(int sirinaTabele, int visinaTabele, int BrojRedova, int BrojKolona, List<Sjediste> zauzetaSjedista)
        {
            tblSjedista.Controls.Clear();
            tblRedovi.Controls.Clear();
            tblKolone.Controls.Clear();

            tblRedovi.RowCount = BrojRedova;
            tblKolone.ColumnCount = BrojKolona;

            // generisanje slova za redove
            var pR = visinaTabele / BrojRedova;
            for (int i = 0; i < BrojRedova; i++)
            {
                this.tblRedovi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, pR));
                var lab = new System.Windows.Forms.Label();
                this.tblRedovi.Controls.Add(lab);
                lab.Dock = System.Windows.Forms.DockStyle.Fill;
                lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lab.Text = (Convert.ToChar(i + 65)).ToString();
            }

            // generisanje brojeva za kolone
            var pK = sirinaTabele / BrojKolona;
            for (int i = 0; i < BrojKolona; i++)
            {
                this.tblKolone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, pK));
                var lab = new System.Windows.Forms.Label();
                this.tblKolone.Controls.Add(lab);
                lab.Dock = System.Windows.Forms.DockStyle.Fill;
                lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lab.Text = (i + 1).ToString();
            }

            // generisanje kruzica za sjedista
            tblSjedista.RowCount = BrojRedova;
            tblSjedista.ColumnCount = BrojKolona;
            for (int i = 0; i < BrojRedova; i++)
            {
                this.tblSjedista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, pR));
            }
            for (int i = 0; i < BrojKolona; i++)
            {
                this.tblSjedista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, pK));
            }

            for (int i = 0; i < BrojRedova; i++)
            {
                for (int j = 0; j < BrojKolona; j++)
                {
                    var lab = new System.Windows.Forms.Label();
                    tblSjedista.Controls.Add(lab);
                    lab.Name = i.ToString() + "/" + j.ToString();
                    lab.Text = "●";
                    lab.Font = new Font("Microsoft Sans Serif", 25);
                    lab.Dock = System.Windows.Forms.DockStyle.Fill;
                    lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    if (zauzetaSjedista.Contains(new Sjediste{ Red = i, Kolona = j }) == true)
                        lab.ForeColor = Color.FromArgb(230, 92, 92);
                    else
                        lab.ForeColor = Color.FromArgb(113, 217, 154);
                    lab.Click += PointClick_Click;
                }
            }
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervacijaDodavanje));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tblRedovi = new System.Windows.Forms.TableLayoutPanel();
            this.tblKolone = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblSjedista = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnPonistiRezervacije = new System.Windows.Forms.Button();
            this.bttnOdustaniOdRezervacije = new System.Windows.Forms.Button();
            this.bttnPotvrdiRezervacije = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBrojRezervacija = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.58034F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.41966F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 529);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.351039F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.64896F));
            this.tableLayoutPanel2.Controls.Add(this.tblRedovi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tblKolone, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tblSjedista, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 95);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.07889F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.92111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(866, 431);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tblRedovi
            // 
            this.tblRedovi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblRedovi.ColumnCount = 1;
            this.tblRedovi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRedovi.Location = new System.Drawing.Point(3, 3);
            this.tblRedovi.Name = "tblRedovi";
            this.tblRedovi.RowCount = 1;
            this.tblRedovi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRedovi.Size = new System.Drawing.Size(49, 365);
            this.tblRedovi.TabIndex = 0;
            // 
            // tblKolone
            // 
            this.tblKolone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblKolone.ColumnCount = 1;
            this.tblKolone.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblKolone.Location = new System.Drawing.Point(58, 374);
            this.tblKolone.Name = "tblKolone";
            this.tblKolone.RowCount = 1;
            this.tblKolone.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblKolone.Size = new System.Drawing.Size(805, 54);
            this.tblKolone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "R/K";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblSjedista
            // 
            this.tblSjedista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblSjedista.ColumnCount = 1;
            this.tblSjedista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSjedista.Location = new System.Drawing.Point(58, 3);
            this.tblSjedista.Name = "tblSjedista";
            this.tblSjedista.RowCount = 1;
            this.tblSjedista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSjedista.Size = new System.Drawing.Size(805, 365);
            this.tblSjedista.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.351039F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.64896F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(866, 86);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bttnPonistiRezervacije
            // 
            this.bttnPonistiRezervacije.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnPonistiRezervacije.Location = new System.Drawing.Point(30, 599);
            this.bttnPonistiRezervacije.Name = "bttnPonistiRezervacije";
            this.bttnPonistiRezervacije.Size = new System.Drawing.Size(205, 48);
            this.bttnPonistiRezervacije.TabIndex = 1;
            this.bttnPonistiRezervacije.Text = "Ponisti";
            this.bttnPonistiRezervacije.UseVisualStyleBackColor = true;
            this.bttnPonistiRezervacije.Click += new System.EventHandler(this.bttnPonistiRezervacije_Click);
            // 
            // bttnOdustaniOdRezervacije
            // 
            this.bttnOdustaniOdRezervacije.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnOdustaniOdRezervacije.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnOdustaniOdRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOdustaniOdRezervacije.Location = new System.Drawing.Point(323, 599);
            this.bttnOdustaniOdRezervacije.Name = "bttnOdustaniOdRezervacije";
            this.bttnOdustaniOdRezervacije.Size = new System.Drawing.Size(271, 48);
            this.bttnOdustaniOdRezervacije.TabIndex = 2;
            this.bttnOdustaniOdRezervacije.Text = "Odustani";
            this.bttnOdustaniOdRezervacije.UseVisualStyleBackColor = false;
            this.bttnOdustaniOdRezervacije.Click += new System.EventHandler(this.bttnOdustaniOdRezervacije_Click);
            // 
            // bttnPotvrdiRezervacije
            // 
            this.bttnPotvrdiRezervacije.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnPotvrdiRezervacije.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnPotvrdiRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnPotvrdiRezervacije.Location = new System.Drawing.Point(600, 599);
            this.bttnPotvrdiRezervacije.Name = "bttnPotvrdiRezervacije";
            this.bttnPotvrdiRezervacije.Size = new System.Drawing.Size(296, 48);
            this.bttnPotvrdiRezervacije.TabIndex = 3;
            this.bttnPotvrdiRezervacije.Text = "Odaberi";
            this.bttnPotvrdiRezervacije.UseVisualStyleBackColor = false;
            this.bttnPotvrdiRezervacije.Click += new System.EventHandler(this.bttnPotvrdiRezervacije_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(927, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 76);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberite jedno ili više mjesta za vašu rezervaciju.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(926, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj rezervacija";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(929, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ukupna cijena";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.AutoSize = true;
            this.txtUkupnaCijena.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUkupnaCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUkupnaCijena.Location = new System.Drawing.Point(3, 0);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(84, 31);
            this.txtUkupnaCijena.TabIndex = 10;
            this.txtUkupnaCijena.Text = "label5";
            this.txtUkupnaCijena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtUkupnaCijena, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(942, 397);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(90, 31);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.txtBrojRezervacija, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(942, 252);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(90, 29);
            this.tableLayoutPanel5.TabIndex = 12;
            // 
            // txtBrojRezervacija
            // 
            this.txtBrojRezervacija.AutoSize = true;
            this.txtBrojRezervacija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBrojRezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojRezervacija.Location = new System.Drawing.Point(3, 0);
            this.txtBrojRezervacija.Name = "txtBrojRezervacija";
            this.txtBrojRezervacija.Size = new System.Drawing.Size(84, 29);
            this.txtBrojRezervacija.TabIndex = 0;
            this.txtBrojRezervacija.Text = "label5";
            this.txtBrojRezervacija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRezervacijaDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 706);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnPotvrdiRezervacije);
            this.Controls.Add(this.bttnOdustaniOdRezervacije);
            this.Controls.Add(this.bttnPonistiRezervacije);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1124, 669);
            this.Name = "frmRezervacijaDodavanje";
            this.Text = "frmRezervacijaDodavanje";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRezervacijaDodavanje_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tblRedovi;
        private System.Windows.Forms.TableLayoutPanel tblKolone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnPonistiRezervacije;
        private System.Windows.Forms.Button bttnOdustaniOdRezervacije;
        private System.Windows.Forms.Button bttnPotvrdiRezervacije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tblSjedista;
        private System.Windows.Forms.Label txtUkupnaCijena;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label txtBrojRezervacija;
    }
}