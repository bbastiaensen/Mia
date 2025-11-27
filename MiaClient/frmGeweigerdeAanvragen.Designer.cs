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
            this.cmbJaar = new System.Windows.Forms.ComboBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(13, 81);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(358, 77);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Genereer Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblWacht
            // 
            this.lblWacht.AutoSize = true;
            this.lblWacht.Location = new System.Drawing.Point(8, 220);
            this.lblWacht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWacht.Name = "lblWacht";
            this.lblWacht.Size = new System.Drawing.Size(183, 25);
            this.lblWacht.TabIndex = 4;
            this.lblWacht.Text = "Dit kan even duren...";
            this.lblWacht.Visible = false;
            // 
            // lblLaad1
            // 
            this.lblLaad1.AutoSize = true;
            this.lblLaad1.Location = new System.Drawing.Point(13, 179);
            this.lblLaad1.Name = "lblLaad1";
            this.lblLaad1.Size = new System.Drawing.Size(402, 25);
            this.lblLaad1.TabIndex = 5;
            this.lblLaad1.Text = "                                                                              ";
            this.lblLaad1.Visible = false;
            // 
            // cmbJaar
            // 
            this.cmbJaar.Location = new System.Drawing.Point(289, 31);
            this.cmbJaar.Name = "cmbJaar";
            this.cmbJaar.Size = new System.Drawing.Size(82, 33);
            this.cmbJaar.TabIndex = 12;
            this.cmbJaar.SelectedIndexChanged += new System.EventHandler(this.cmbJaar_SelectedIndexChanged);
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(8, 31);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(275, 25);
            this.lblFinancieringsjaar.TabIndex = 11;
            this.lblFinancieringsjaar.Text = "Selecteer een financieringsjaar:";
            // 
            // frmGeweigerdeAanvragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 256);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.cmbJaar);
            this.Controls.Add(this.lblLaad1);
            this.Controls.Add(this.lblWacht);
            this.Controls.Add(this.btnExcel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeweigerdeAanvragen";
            this.Text = "Geweigerde Aanvragen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGeweigerdeAanvragen_FormClosing);
            this.Load += new System.EventHandler(this.frmGeweigerdeAanvragen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblWacht;
        private System.Windows.Forms.Label lblLaad1;
        private System.Windows.Forms.ComboBox cmbJaar;
        private System.Windows.Forms.Label lblFinancieringsjaar;
    }
}