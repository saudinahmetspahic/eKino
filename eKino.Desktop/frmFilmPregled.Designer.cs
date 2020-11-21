namespace eKino.Desktop
{
    partial class frmFilmPregled
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
            this.tblListaFilmova = new System.Windows.Forms.TableLayoutPanel();
            this.bttnBack = new System.Windows.Forms.Button();
            this.bttnNext = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNazivFilter = new System.Windows.Forms.TextBox();
            this.cbxKategorijaFilter = new System.Windows.Forms.ComboBox();
            this.cbxZanrFilter = new System.Windows.Forms.ComboBox();
            this.cbxPopularnoFilter = new System.Windows.Forms.ComboBox();
            this.bttnFiltriraj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblListaFilmova
            // 
            this.tblListaFilmova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tblListaFilmova.AutoScroll = true;
            this.tblListaFilmova.ColumnCount = 2;
            this.tblListaFilmova.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblListaFilmova.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblListaFilmova.Location = new System.Drawing.Point(339, 25);
            this.tblListaFilmova.Name = "tblListaFilmova";
            this.tblListaFilmova.RowCount = 1;
            this.tblListaFilmova.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblListaFilmova.Size = new System.Drawing.Size(518, 521);
            this.tblListaFilmova.TabIndex = 0;
            // 
            // bttnBack
            // 
            this.bttnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttnBack.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnBack.Location = new System.Drawing.Point(339, 552);
            this.bttnBack.Name = "bttnBack";
            this.bttnBack.Size = new System.Drawing.Size(259, 52);
            this.bttnBack.TabIndex = 2;
            this.bttnBack.Text = "Nazad";
            this.bttnBack.UseVisualStyleBackColor = false;
            this.bttnBack.Click += new System.EventHandler(this.bttnBack_Click);
            // 
            // bttnNext
            // 
            this.bttnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttnNext.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnNext.Location = new System.Drawing.Point(595, 552);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(262, 52);
            this.bttnNext.TabIndex = 3;
            this.bttnNext.Text = "Sljedeca";
            this.bttnNext.UseVisualStyleBackColor = false;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNazivFilter, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxKategorijaFilter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxZanrFilter, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbxPopularnoFilter, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.bttnFiltriraj, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 394);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategorija";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zanr";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Popularno";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNazivFilter
            // 
            this.txtNazivFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNazivFilter.Location = new System.Drawing.Point(3, 23);
            this.txtNazivFilter.Name = "txtNazivFilter";
            this.txtNazivFilter.Size = new System.Drawing.Size(194, 22);
            this.txtNazivFilter.TabIndex = 4;
            // 
            // cbxKategorijaFilter
            // 
            this.cbxKategorijaFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxKategorijaFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategorijaFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxKategorijaFilter.FormattingEnabled = true;
            this.cbxKategorijaFilter.Location = new System.Drawing.Point(3, 108);
            this.cbxKategorijaFilter.Name = "cbxKategorijaFilter";
            this.cbxKategorijaFilter.Size = new System.Drawing.Size(194, 24);
            this.cbxKategorijaFilter.TabIndex = 5;
            // 
            // cbxZanrFilter
            // 
            this.cbxZanrFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxZanrFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxZanrFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxZanrFilter.FormattingEnabled = true;
            this.cbxZanrFilter.Location = new System.Drawing.Point(3, 202);
            this.cbxZanrFilter.Name = "cbxZanrFilter";
            this.cbxZanrFilter.Size = new System.Drawing.Size(194, 24);
            this.cbxZanrFilter.TabIndex = 6;
            // 
            // cbxPopularnoFilter
            // 
            this.cbxPopularnoFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPopularnoFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPopularnoFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxPopularnoFilter.FormattingEnabled = true;
            this.cbxPopularnoFilter.Location = new System.Drawing.Point(3, 296);
            this.cbxPopularnoFilter.Name = "cbxPopularnoFilter";
            this.cbxPopularnoFilter.Size = new System.Drawing.Size(194, 24);
            this.cbxPopularnoFilter.TabIndex = 7;
            // 
            // bttnFiltriraj
            // 
            this.bttnFiltriraj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFiltriraj.Location = new System.Drawing.Point(3, 360);
            this.bttnFiltriraj.Name = "bttnFiltriraj";
            this.bttnFiltriraj.Size = new System.Drawing.Size(194, 31);
            this.bttnFiltriraj.TabIndex = 8;
            this.bttnFiltriraj.Text = "Filtriraj";
            this.bttnFiltriraj.UseVisualStyleBackColor = true;
            this.bttnFiltriraj.Click += new System.EventHandler(this.bttnFiltriraj_Click);
            // 
            // frmFilmPregled
            // 
            this.ClientSize = new System.Drawing.Size(969, 627);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bttnBack);
            this.Controls.Add(this.bttnNext);
            this.Controls.Add(this.tblListaFilmova);
            this.MinimumSize = new System.Drawing.Size(987, 674);
            this.Name = "frmFilmPregled";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFilmPregled_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel pnlPreporuka;
        //private System.Windows.Forms.FlowLayoutPanel pnlPregledFilmova;
        //private System.Windows.Forms.TableLayoutPanel tblFilmovi;
        //private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.TableLayoutPanel tblPreporuke;
        //private System.Windows.Forms.PictureBox pbxFilmSlika;
        //private System.Windows.Forms.TableLayoutPanel tblFilmInfo;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label txtNazivFilma;
        //private System.Windows.Forms.Label txtZanrFilma;
        //private System.Windows.Forms.Label txtTrajanjeFilma;
        //public System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        //private System.Windows.Forms.Label label4;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.Label lblPreporukaNaziv;
        //private System.Windows.Forms.Label lblPreporukaZanr;
        //private System.Windows.Forms.Label lblPreporukaTrajanje;
        private System.Windows.Forms.TableLayoutPanel tblListaFilmova;
        private System.Windows.Forms.Button bttnBack;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNazivFilter;
        private System.Windows.Forms.ComboBox cbxKategorijaFilter;
        private System.Windows.Forms.ComboBox cbxZanrFilter;
        private System.Windows.Forms.ComboBox cbxPopularnoFilter;
        private System.Windows.Forms.Button bttnFiltriraj;
    }
}