namespace eKino.Desktop
{
    partial class frmPaketDetalji
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDatumKreiranja = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.dtpDatumIsteka = new System.Windows.Forms.DateTimePicker();
            this.nudOcijena = new System.Windows.Forms.NumericUpDown();
            this.nudCijena = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnKupiPaket = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnIzmijeni = new System.Windows.Forms.Button();
            this.bttnIzbrisiPaket = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.22795F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.77205F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDatumKreiranja, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOpis, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpDatumIsteka, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudOcijena, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudCijena, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.16667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.83333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum kreiranja";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum isteka";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maksimalna ocijena filma";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cijena paketa";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Opis";
            // 
            // lblDatumKreiranja
            // 
            this.lblDatumKreiranja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatumKreiranja.AutoSize = true;
            this.lblDatumKreiranja.Location = new System.Drawing.Point(269, 0);
            this.lblDatumKreiranja.Name = "lblDatumKreiranja";
            this.lblDatumKreiranja.Size = new System.Drawing.Size(465, 49);
            this.lblDatumKreiranja.TabIndex = 5;
            this.lblDatumKreiranja.Text = "label6";
            // 
            // lblOpis
            // 
            this.lblOpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(269, 201);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(465, 128);
            this.lblOpis.TabIndex = 9;
            this.lblOpis.Text = "label10";
            // 
            // dtpDatumIsteka
            // 
            this.dtpDatumIsteka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumIsteka.Location = new System.Drawing.Point(269, 52);
            this.dtpDatumIsteka.Name = "dtpDatumIsteka";
            this.dtpDatumIsteka.Size = new System.Drawing.Size(465, 22);
            this.dtpDatumIsteka.TabIndex = 11;
            // 
            // nudOcijena
            // 
            this.nudOcijena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudOcijena.Location = new System.Drawing.Point(269, 103);
            this.nudOcijena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudOcijena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOcijena.Name = "nudOcijena";
            this.nudOcijena.Size = new System.Drawing.Size(465, 22);
            this.nudOcijena.TabIndex = 12;
            this.nudOcijena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCijena
            // 
            this.nudCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCijena.Location = new System.Drawing.Point(269, 151);
            this.nudCijena.Name = "nudCijena";
            this.nudCijena.Size = new System.Drawing.Size(465, 22);
            this.nudCijena.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.bttnKupiPaket, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(269, 332);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(465, 45);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // bttnKupiPaket
            // 
            this.bttnKupiPaket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnKupiPaket.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnKupiPaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnKupiPaket.Location = new System.Drawing.Point(235, 3);
            this.bttnKupiPaket.Name = "bttnKupiPaket";
            this.bttnKupiPaket.Size = new System.Drawing.Size(227, 39);
            this.bttnKupiPaket.TabIndex = 15;
            this.bttnKupiPaket.Text = "Kupi";
            this.bttnKupiPaket.UseVisualStyleBackColor = false;
            this.bttnKupiPaket.Click += new System.EventHandler(this.bttnKupiPaket_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.bttnIzmijeni, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bttnIzbrisiPaket, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 332);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(260, 45);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // bttnIzmijeni
            // 
            this.bttnIzmijeni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnIzmijeni.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnIzmijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnIzmijeni.Location = new System.Drawing.Point(133, 3);
            this.bttnIzmijeni.Name = "bttnIzmijeni";
            this.bttnIzmijeni.Size = new System.Drawing.Size(122, 39);
            this.bttnIzmijeni.TabIndex = 14;
            this.bttnIzmijeni.Text = "Sacuvaj";
            this.bttnIzmijeni.UseVisualStyleBackColor = false;
            this.bttnIzmijeni.Click += new System.EventHandler(this.bttnIzmijeni_Click);
            // 
            // bttnIzbrisiPaket
            // 
            this.bttnIzbrisiPaket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnIzbrisiPaket.BackColor = System.Drawing.Color.Coral;
            this.bttnIzbrisiPaket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnIzbrisiPaket.Location = new System.Drawing.Point(5, 3);
            this.bttnIzbrisiPaket.Name = "bttnIzbrisiPaket";
            this.bttnIzbrisiPaket.Size = new System.Drawing.Size(122, 39);
            this.bttnIzbrisiPaket.TabIndex = 10;
            this.bttnIzbrisiPaket.Text = "Izbrisi";
            this.bttnIzbrisiPaket.UseVisualStyleBackColor = false;
            this.bttnIzbrisiPaket.Click += new System.EventHandler(this.bttnIzbrisiPaket_Click);
            // 
            // frmPaketDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 447);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(820, 494);
            this.Name = "frmPaketDetalji";
            this.Text = "frmPaketDetalji";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPaketDetalji_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOcijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDatumKreiranja;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.DateTimePicker dtpDatumIsteka;
        private System.Windows.Forms.NumericUpDown nudOcijena;
        private System.Windows.Forms.NumericUpDown nudCijena;
        private System.Windows.Forms.Button bttnIzbrisiPaket;
        private System.Windows.Forms.Button bttnIzmijeni;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bttnKupiPaket;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}