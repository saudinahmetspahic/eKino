namespace eKino.WinUI
{
    partial class fmrIndex
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnGet = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnGet
            // 
            this.bttnGet.Location = new System.Drawing.Point(546, 119);
            this.bttnGet.Name = "bttnGet";
            this.bttnGet.Size = new System.Drawing.Size(94, 29);
            this.bttnGet.TabIndex = 0;
            this.bttnGet.Text = "Get";
            this.bttnGet.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(84, 128);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(233, 20);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Klikni na Get da bi dobio podatke";
            // 
            // fmrIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.bttnGet);
            this.Name = "fmrIndex";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnGet;
        private System.Windows.Forms.Label lblText;
    }
}

