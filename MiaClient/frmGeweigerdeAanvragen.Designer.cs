namespace MiaClient
{
    partial class frmGeweigerdeAanvragen
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblWacht = new System.Windows.Forms.Label();
            this.lblLaad1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(16, 49);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(140, 57);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Genereer Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblWacht
            // 
            this.lblWacht.AutoSize = true;
            this.lblWacht.Location = new System.Drawing.Point(13, 126);
            this.lblWacht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWacht.Name = "lblWacht";
            this.lblWacht.Size = new System.Drawing.Size(127, 16);
            this.lblWacht.TabIndex = 4;
            this.lblWacht.Text = "Dit kan even duren...";
            this.lblWacht.Visible = false;
            // 
            // lblLaad1
            // 
            this.lblLaad1.AutoSize = true;
            this.lblLaad1.Location = new System.Drawing.Point(13, 110);
            this.lblLaad1.Name = "lblLaad1";
            this.lblLaad1.Size = new System.Drawing.Size(241, 16);
            this.lblLaad1.TabIndex = 5;
            this.lblLaad1.Text = "                                                                              ";
            this.lblLaad1.Visible = false;
            // 
            // frmGeweigerdeAanvragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 438);
            this.Controls.Add(this.lblLaad1);
            this.Controls.Add(this.lblWacht);
            this.Controls.Add(this.btnExcel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGeweigerdeAanvragen";
            this.Text = "frmGeweigerdeAanvragen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblWacht;
        private System.Windows.Forms.Label lblLaad1;
    }
}