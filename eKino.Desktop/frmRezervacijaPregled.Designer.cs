namespace eKino.Desktop
{
    partial class frmRezervacijaPregled
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
            this.dgvListaRezervacija = new System.Windows.Forms.DataGridView();
            this.cbxAktivne = new System.Windows.Forms.CheckBox();
            this.cbxNeaktivne = new System.Windows.Forms.CheckBox();
            this.bttnDodajRezervaciju = new System.Windows.Forms.Button();
            this.tblDodajRezervaciju = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxListaProjZaDodavanjePrez = new System.Windows.Forms.ComboBox();
            this.tblPotvrda = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnDa = new System.Windows.Forms.Button();
            this.bttnNe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRezervacija)).BeginInit();
            this.tblDodajRezervaciju.SuspendLayout();
            this.tblPotvrda.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaRezervacija
            // 
            this.dgvListaRezervacija.AllowUserToAddRows = false;
            this.dgvListaRezervacija.AllowUserToDeleteRows = false;
            this.dgvListaRezervacija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvListaRezervacija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRezervacija.Location = new System.Drawing.Point(12, 62);
            this.dgvListaRezervacija.Name = "dgvListaRezervacija";
            this.dgvListaRezervacija.ReadOnly = true;
            this.dgvListaRezervacija.RowHeadersWidth = 51;
            this.dgvListaRezervacija.RowTemplate.Height = 24;
            this.dgvListaRezervacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRezervacija.Size = new System.Drawing.Size(990, 377);
            this.dgvListaRezervacija.TabIndex = 2;
            this.dgvListaRezervacija.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaRezervacija_CellDoubleClick);
            // 
            // cbxAktivne
            // 
            this.cbxAktivne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxAktivne.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxAktivne.Checked = true;
            this.cbxAktivne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAktivne.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAktivne.Location = new System.Drawing.Point(12, 12);
            this.cbxAktivne.Name = "cbxAktivne";
            this.cbxAktivne.Size = new System.Drawing.Size(124, 37);
            this.cbxAktivne.TabIndex = 3;
            this.cbxAktivne.Text = "Aktivne";
            this.cbxAktivne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxAktivne.UseVisualStyleBackColor = true;
            this.cbxAktivne.Click += new System.EventHandler(this.cbxAktivne_Click);
            // 
            // cbxNeaktivne
            // 
            this.cbxNeaktivne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxNeaktivne.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxNeaktivne.Checked = true;
            this.cbxNeaktivne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNeaktivne.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNeaktivne.Location = new System.Drawing.Point(142, 12);
            this.cbxNeaktivne.Name = "cbxNeaktivne";
            this.cbxNeaktivne.Size = new System.Drawing.Size(124, 37);
            this.cbxNeaktivne.TabIndex = 4;
            this.cbxNeaktivne.Text = "Neaktivne";
            this.cbxNeaktivne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxNeaktivne.UseVisualStyleBackColor = true;
            this.cbxNeaktivne.Click += new System.EventHandler(this.cbxNeaktivne_Click);
            // 
            // bttnDodajRezervaciju
            // 
            this.bttnDodajRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnDodajRezervaciju.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnDodajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDodajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDodajRezervaciju.Location = new System.Drawing.Point(878, 12);
            this.bttnDodajRezervaciju.Name = "bttnDodajRezervaciju";
            this.bttnDodajRezervaciju.Size = new System.Drawing.Size(124, 37);
            this.bttnDodajRezervaciju.TabIndex = 5;
            this.bttnDodajRezervaciju.Text = "Dodaj";
            this.bttnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.bttnDodajRezervaciju.Click += new System.EventHandler(this.bttnDodajRezervaciju_Click);
            // 
            // tblDodajRezervaciju
            // 
            this.tblDodajRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tblDodajRezervaciju.ColumnCount = 2;
            this.tblDodajRezervaciju.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.22034F));
            this.tblDodajRezervaciju.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.77966F));
            this.tblDodajRezervaciju.Controls.Add(this.label1, 0, 0);
            this.tblDodajRezervaciju.Controls.Add(this.cbxListaProjZaDodavanjePrez, 1, 0);
            this.tblDodajRezervaciju.Location = new System.Drawing.Point(512, 17);
            this.tblDodajRezervaciju.Name = "tblDodajRezervaciju";
            this.tblDodajRezervaciju.RowCount = 1;
            this.tblDodajRezervaciju.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDodajRezervaciju.Size = new System.Drawing.Size(360, 27);
            this.tblDodajRezervaciju.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj rezervaciju za";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxListaProjZaDodavanjePrez
            // 
            this.cbxListaProjZaDodavanjePrez.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxListaProjZaDodavanjePrez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListaProjZaDodavanjePrez.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxListaProjZaDodavanjePrez.FormattingEnabled = true;
            this.cbxListaProjZaDodavanjePrez.Location = new System.Drawing.Point(158, 3);
            this.cbxListaProjZaDodavanjePrez.Name = "cbxListaProjZaDodavanjePrez";
            this.cbxListaProjZaDodavanjePrez.Size = new System.Drawing.Size(199, 24);
            this.cbxListaProjZaDodavanjePrez.TabIndex = 1;
            // 
            // tblPotvrda
            // 
            this.tblPotvrda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tblPotvrda.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.tblPotvrda.ColumnCount = 1;
            this.tblPotvrda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPotvrda.Controls.Add(this.label2, 0, 0);
            this.tblPotvrda.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tblPotvrda.Location = new System.Drawing.Point(353, 127);
            this.tblPotvrda.Name = "tblPotvrda";
            this.tblPotvrda.RowCount = 2;
            this.tblPotvrda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.30612F));
            this.tblPotvrda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.69388F));
            this.tblPotvrda.Size = new System.Drawing.Size(311, 122);
            this.tblPotvrda.TabIndex = 7;
            this.tblPotvrda.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 79);
            this.label2.TabIndex = 0;
            this.label2.Text = "Da li zelite izbrisati zeljenu rezervaciju?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.Controls.Add(this.bttnDa, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bttnNe, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 82);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(305, 37);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // bttnDa
            // 
            this.bttnDa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnDa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDa.ForeColor = System.Drawing.Color.Black;
            this.bttnDa.Location = new System.Drawing.Point(3, 3);
            this.bttnDa.Name = "bttnDa";
            this.bttnDa.Size = new System.Drawing.Size(146, 31);
            this.bttnDa.TabIndex = 0;
            this.bttnDa.Text = "Da";
            this.bttnDa.UseVisualStyleBackColor = true;
            this.bttnDa.Click += new System.EventHandler(this.bttnDa_Click);
            // 
            // bttnNe
            // 
            this.bttnNe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnNe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnNe.Location = new System.Drawing.Point(155, 3);
            this.bttnNe.Name = "bttnNe";
            this.bttnNe.Size = new System.Drawing.Size(147, 31);
            this.bttnNe.TabIndex = 1;
            this.bttnNe.Text = "Ne";
            this.bttnNe.UseVisualStyleBackColor = true;
            this.bttnNe.Click += new System.EventHandler(this.bttnNe_Click);
            // 
            // frmRezervacijaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 464);
            this.Controls.Add(this.tblPotvrda);
            this.Controls.Add(this.tblDodajRezervaciju);
            this.Controls.Add(this.bttnDodajRezervaciju);
            this.Controls.Add(this.cbxNeaktivne);
            this.Controls.Add(this.cbxAktivne);
            this.Controls.Add(this.dgvListaRezervacija);
            this.MinimumSize = new System.Drawing.Size(1032, 511);
            this.Name = "frmRezervacijaPregled";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRezervacijaPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRezervacija)).EndInit();
            this.tblDodajRezervaciju.ResumeLayout(false);
            this.tblDodajRezervaciju.PerformLayout();
            this.tblPotvrda.ResumeLayout(false);
            this.tblPotvrda.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListaRezervacija;
        private System.Windows.Forms.CheckBox cbxAktivne;
        private System.Windows.Forms.CheckBox cbxNeaktivne;
        private System.Windows.Forms.Button bttnDodajRezervaciju;
        private System.Windows.Forms.TableLayoutPanel tblDodajRezervaciju;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxListaProjZaDodavanjePrez;
        private System.Windows.Forms.TableLayoutPanel tblPotvrda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bttnDa;
        private System.Windows.Forms.Button bttnNe;
    }
}