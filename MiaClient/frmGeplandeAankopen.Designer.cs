namespace MiaClient
{
    partial class frmGeplandeAankopen
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
            this.lblLaad1 = new System.Windows.Forms.Label();
            this.lblWacht = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(41, 37);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(411, 114);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.TabStop = false;
            this.btnExcel.Text = "Genereer Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblLaad1
            // 
            this.lblLaad1.AutoSize = true;
            this.lblLaad1.Location = new System.Drawing.Point(45, 156);
            this.lblLaad1.Name = "lblLaad1";
            this.lblLaad1.Size = new System.Drawing.Size(402, 25);
            this.lblLaad1.TabIndex = 7;
            this.lblLaad1.Text = "                                                                              ";
            this.lblLaad1.Visible = false;
            // 
            // lblWacht
            // 
            this.lblWacht.AutoSize = true;
            this.lblWacht.Location = new System.Drawing.Point(45, 186);
            this.lblWacht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWacht.Name = "lblWacht";
            this.lblWacht.Size = new System.Drawing.Size(183, 25);
            this.lblWacht.TabIndex = 6;
            this.lblWacht.Text = "Dit kan even duren...";
            this.lblWacht.Visible = false;
            // 
            // frmGeplandeAankopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 288);
            this.Controls.Add(this.lblLaad1);
            this.Controls.Add(this.lblWacht);
            this.Controls.Add(this.btnExcel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGeplandeAankopen";
            this.Text = "frmGeplandeAankopen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGeplandeAankopen_FormClosing);
            this.Load += new System.EventHandler(this.frmGeplandeAankopen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblLaad1;
        private System.Windows.Forms.Label lblWacht;
    }
}