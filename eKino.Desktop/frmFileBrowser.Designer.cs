namespace eKino.Desktop
{
    partial class frmFileBrowser
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
            this.components = new System.ComponentModel.Container();
            this.bttnOtvori = new System.Windows.Forms.Button();
            this.txtPathOutput = new System.Windows.Forms.TextBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lviewPretrega = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // bttnOtvori
            // 
            this.bttnOtvori.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.bttnOtvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnOtvori.Location = new System.Drawing.Point(620, 408);
            this.bttnOtvori.Name = "bttnOtvori";
            this.bttnOtvori.Size = new System.Drawing.Size(150, 30);
            this.bttnOtvori.TabIndex = 0;
            this.bttnOtvori.Text = "Otvori";
            this.bttnOtvori.UseVisualStyleBackColor = false;
            this.bttnOtvori.Click += new System.EventHandler(this.bttnOtvori_Click);
            // 
            // txtPathOutput
            // 
            this.txtPathOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathOutput.Location = new System.Drawing.Point(12, 408);
            this.txtPathOutput.Name = "txtPathOutput";
            this.txtPathOutput.ReadOnly = true;
            this.txtPathOutput.Size = new System.Drawing.Size(587, 30);
            this.txtPathOutput.TabIndex = 1;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageSize = new System.Drawing.Size(16, 16);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lviewPretrega
            // 
            this.lviewPretrega.HideSelection = false;
            this.lviewPretrega.Location = new System.Drawing.Point(12, 12);
            this.lviewPretrega.Name = "lviewPretrega";
            this.lviewPretrega.Size = new System.Drawing.Size(758, 375);
            this.lviewPretrega.TabIndex = 2;
            this.lviewPretrega.UseCompatibleStateImageBehavior = false;
            this.lviewPretrega.SelectedIndexChanged += new System.EventHandler(this.lviewPretrega_SelectedIndexChanged);
            // 
            // frmFileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lviewPretrega);
            this.Controls.Add(this.txtPathOutput);
            this.Controls.Add(this.bttnOtvori);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmFileBrowser";
            this.Text = "frmFileBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnOtvori;
        private System.Windows.Forms.TextBox txtPathOutput;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ListView lviewPretrega;
    }
}