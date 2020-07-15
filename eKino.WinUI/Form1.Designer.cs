namespace eKino.WinUI
{
    partial class Form1
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
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.bttnRequest = new System.Windows.Forms.Button();
            this.tboxInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(25, 71);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.Size = new System.Drawing.Size(679, 234);
            this.dgvOutput.TabIndex = 0;
            // 
            // bttnRequest
            // 
            this.bttnRequest.Location = new System.Drawing.Point(555, 30);
            this.bttnRequest.Name = "bttnRequest";
            this.bttnRequest.Size = new System.Drawing.Size(149, 23);
            this.bttnRequest.TabIndex = 1;
            this.bttnRequest.Text = "Get data";
            this.bttnRequest.UseVisualStyleBackColor = true;
            this.bttnRequest.Click += new System.EventHandler(this.bttnRequest_Click);
            // 
            // tboxInput
            // 
            this.tboxInput.Location = new System.Drawing.Point(25, 30);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(506, 20);
            this.tboxInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 340);
            this.Controls.Add(this.tboxInput);
            this.Controls.Add(this.bttnRequest);
            this.Controls.Add(this.dgvOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Button bttnRequest;
        private System.Windows.Forms.TextBox tboxInput;
    }
}

