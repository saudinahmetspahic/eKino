
namespace eKino.Desktop
{
    partial class frmFilmPrijava
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
            this.dgvPrijave = new System.Windows.Forms.DataGridView();
            this.bttnAktivne = new System.Windows.Forms.CheckBox();
            this.bttnNeaktivne = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijave)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrijave
            // 
            this.dgvPrijave.AllowUserToAddRows = false;
            this.dgvPrijave.AllowUserToDeleteRows = false;
            this.dgvPrijave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvPrijave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrijave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijave.Location = new System.Drawing.Point(31, 90);
            this.dgvPrijave.MinimumSize = new System.Drawing.Size(727, 300);
            this.dgvPrijave.Name = "dgvPrijave";
            this.dgvPrijave.ReadOnly = true;
            this.dgvPrijave.RowHeadersWidth = 51;
            this.dgvPrijave.RowTemplate.Height = 24;
            this.dgvPrijave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrijave.Size = new System.Drawing.Size(809, 333);
            this.dgvPrijave.TabIndex = 0;
            this.dgvPrijave.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrijave_CellDoubleClick);
            // 
            // bttnAktivne
            // 
            this.bttnAktivne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnAktivne.Appearance = System.Windows.Forms.Appearance.Button;
            this.bttnAktivne.Checked = true;
            this.bttnAktivne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bttnAktivne.Location = new System.Drawing.Point(31, 25);
            this.bttnAktivne.Name = "bttnAktivne";
            this.bttnAktivne.Size = new System.Drawing.Size(149, 48);
            this.bttnAktivne.TabIndex = 1;
            this.bttnAktivne.Text = "Aktivne";
            this.bttnAktivne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnAktivne.UseVisualStyleBackColor = true;
            this.bttnAktivne.CheckedChanged += new System.EventHandler(this.bttnAktivne_CheckedChanged);
            // 
            // bttnNeaktivne
            // 
            this.bttnNeaktivne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnNeaktivne.Appearance = System.Windows.Forms.Appearance.Button;
            this.bttnNeaktivne.Checked = true;
            this.bttnNeaktivne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bttnNeaktivne.Location = new System.Drawing.Point(200, 25);
            this.bttnNeaktivne.Name = "bttnNeaktivne";
            this.bttnNeaktivne.Size = new System.Drawing.Size(149, 48);
            this.bttnNeaktivne.TabIndex = 2;
            this.bttnNeaktivne.Text = "Neaktivne";
            this.bttnNeaktivne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnNeaktivne.UseVisualStyleBackColor = true;
            this.bttnNeaktivne.CheckedChanged += new System.EventHandler(this.bttnNeaktivne_CheckedChanged);
            // 
            // frmFilmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 461);
            this.Controls.Add(this.bttnNeaktivne);
            this.Controls.Add(this.bttnAktivne);
            this.Controls.Add(this.dgvPrijave);
            this.Name = "frmFilmPrijava";
            this.Text = "frmFilmPrijava";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrijave;
        private System.Windows.Forms.CheckBox bttnAktivne;
        private System.Windows.Forms.CheckBox bttnNeaktivne;
    }
}