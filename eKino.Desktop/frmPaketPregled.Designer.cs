using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Forms;

namespace eKino.Desktop
{
    partial class frmPaketPregled
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

        private System.Drawing.Point _point = new System.Drawing.Point(24, 35); // (24, 35)
        public void ResetPoint()
        {
            _point.X = this.Width / 2 - 100; //24;
            _point.Y = 35;
        }
        public void DodajPaket(int paketId, int index, string naziv, string paketocijena, double cijena)
        {
            var tblPaket = new TableLayoutPanel();
            var tblPaketPodTabela = new TableLayoutPanel();
            var lblNazivPaketa = new Label();
            var lblIndex = new Label();
            var lblPaketOcijena = new Label();

            tblPaket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            tblPaket.BackColor = System.Drawing.SystemColors.ActiveBorder;
            tblPaket.ColumnCount = 1;
            tblPaket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblPaket.Controls.Add(tblPaketPodTabela, 0, 1);
            tblPaket.Controls.Add(lblNazivPaketa, 0, 0);
            tblPaket.ForeColor = System.Drawing.Color.Black;
            tblPaket.Location = _point;
            tblPaket.Name = paketId.ToString();
            tblPaket.RowCount = 2;
            tblPaket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblPaket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            tblPaket.MinimumSize = new System.Drawing.Size(400, 130);
            tblPaket.TabIndex = 0;
            tblPaket.Click += paket_Click;

            tblPaketPodTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            tblPaketPodTabela.ColumnCount = 2;
            tblPaketPodTabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblPaketPodTabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            tblPaketPodTabela.Controls.Add(lblIndex, 0, 0);
            tblPaketPodTabela.Controls.Add(lblPaketOcijena, 1, 0);
            tblPaketPodTabela.Location = new System.Drawing.Point(3, 48);
            tblPaketPodTabela.Name = paketId.ToString();
            tblPaketPodTabela.RowCount = 1;
            tblPaketPodTabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tblPaketPodTabela.Size = new System.Drawing.Size(553, 82);
            tblPaketPodTabela.TabIndex = 0;
            tblPaketPodTabela.Click += paket_Click;

            lblNazivPaketa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
           | System.Windows.Forms.AnchorStyles.Left)));
            lblNazivPaketa.AutoSize = true;
            lblNazivPaketa.Location = new System.Drawing.Point(3, 0);
            lblNazivPaketa.Name = paketId.ToString();
            lblNazivPaketa.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            lblNazivPaketa.Size = new System.Drawing.Size(47, 45);
            lblNazivPaketa.TabIndex = 1;
            lblNazivPaketa.Text = naziv;
            lblNazivPaketa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lblNazivPaketa.Click += paket_Click;

            lblIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            lblIndex.AutoSize = true;
            lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIndex.Location = new System.Drawing.Point(3, 0);
            lblIndex.Name = paketId.ToString();
            lblIndex.Size = new System.Drawing.Size(280, 82);
            lblIndex.TabIndex = 0;
            lblIndex.Text = index.ToString() + "#  " + (cijena != 0 ? cijena + "KM" : "Free!");
            tblPaketPodTabela.Click += paket_Click;

            lblPaketOcijena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            lblPaketOcijena.AutoSize = true;
            lblPaketOcijena.Location = new System.Drawing.Point(289, 0);
            lblPaketOcijena.Name = paketId.ToString();
            lblPaketOcijena.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            lblPaketOcijena.Size = new System.Drawing.Size(261, 82);
            lblPaketOcijena.TabIndex = 1;
            lblPaketOcijena.Text = paketocijena;
            lblPaketOcijena.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            lblPaketOcijena.Click += paket_Click;

            this.Controls.Add(tblPaket);
            _point.Y += tblPaket.Height + 10;
        }

        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Location = new System.Drawing.Point(627, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 77);
            this.label4.TabIndex = 1;
            this.label4.Text = "Korisnici mogu kupiti paket po želji i koristiti njegove usluge. Paketi imaju ogr" +
    "aničen vijek trajanja.";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(630, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj paket";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPaketPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(876, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.MinimumSize = new System.Drawing.Size(894, 505);
            this.Name = "frmPaketPregled";
            this.Text = "frmPaketPregled";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPaketPregled_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.TableLayoutPanel tblPaket;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}