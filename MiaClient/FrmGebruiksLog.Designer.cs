namespace MiaClient
{
    partial class FrmGebruiksLog
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
            this.lblGebruiksLogTitel = new System.Windows.Forms.Label();
            this.dtpVan = new System.Windows.Forms.DateTimePicker();
            this.grpbxFilter = new System.Windows.Forms.GroupBox();
            this.chkTot = new System.Windows.Forms.CheckBox();
            this.chkVan = new System.Windows.Forms.CheckBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.dtpTot = new System.Windows.Forms.DateTimePicker();
            this.grpbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGebruiksLogTitel
            // 
            this.lblGebruiksLogTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiksLogTitel.Location = new System.Drawing.Point(12, 9);
            this.lblGebruiksLogTitel.Name = "lblGebruiksLogTitel";
            this.lblGebruiksLogTitel.Size = new System.Drawing.Size(865, 24);
            this.lblGebruiksLogTitel.TabIndex = 0;
            this.lblGebruiksLogTitel.Text = "MIA - Gebruikslog";
            this.lblGebruiksLogTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpVan
            // 
            this.dtpVan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVan.Location = new System.Drawing.Point(61, 19);
            this.dtpVan.Name = "dtpVan";
            this.dtpVan.Size = new System.Drawing.Size(192, 29);
            this.dtpVan.TabIndex = 1;
            // 
            // grpbxFilter
            // 
            this.grpbxFilter.Controls.Add(this.chkTot);
            this.grpbxFilter.Controls.Add(this.chkVan);
            this.grpbxFilter.Controls.Add(this.lblOmschrijving);
            this.grpbxFilter.Controls.Add(this.lblGebruiker);
            this.grpbxFilter.Controls.Add(this.txtOmschrijving);
            this.grpbxFilter.Controls.Add(this.txtGebruiker);
            this.grpbxFilter.Controls.Add(this.dtpTot);
            this.grpbxFilter.Controls.Add(this.dtpVan);
            this.grpbxFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxFilter.Location = new System.Drawing.Point(13, 37);
            this.grpbxFilter.Name = "grpbxFilter";
            this.grpbxFilter.Size = new System.Drawing.Size(876, 100);
            this.grpbxFilter.TabIndex = 2;
            this.grpbxFilter.TabStop = false;
            this.grpbxFilter.Text = "Filteren";
            // 
            // chkTot
            // 
            this.chkTot.AutoSize = true;
            this.chkTot.Location = new System.Drawing.Point(6, 56);
            this.chkTot.Name = "chkTot";
            this.chkTot.Size = new System.Drawing.Size(49, 25);
            this.chkTot.TabIndex = 8;
            this.chkTot.Text = "Tot";
            this.chkTot.UseVisualStyleBackColor = true;
            // 
            // chkVan
            // 
            this.chkVan.AutoSize = true;
            this.chkVan.Location = new System.Drawing.Point(6, 24);
            this.chkVan.Name = "chkVan";
            this.chkVan.Size = new System.Drawing.Size(55, 25);
            this.chkVan.TabIndex = 7;
            this.chkVan.Text = "Van";
            this.chkVan.UseVisualStyleBackColor = true;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Location = new System.Drawing.Point(417, 25);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(103, 21);
            this.lblOmschrijving.TabIndex = 6;
            this.lblOmschrijving.Text = "Omschrijving";
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Location = new System.Drawing.Point(259, 25);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(79, 21);
            this.lblGebruiker.TabIndex = 5;
            this.lblGebruiker.Text = "Gebruiker";
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOmschrijving.Location = new System.Drawing.Point(411, 54);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(453, 29);
            this.txtOmschrijving.TabIndex = 4;
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruiker.Location = new System.Drawing.Point(259, 54);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.Size = new System.Drawing.Size(146, 29);
            this.txtGebruiker.TabIndex = 3;
            // 
            // dtpTot
            // 
            this.dtpTot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTot.Location = new System.Drawing.Point(61, 54);
            this.dtpTot.Name = "dtpTot";
            this.dtpTot.Size = new System.Drawing.Size(192, 29);
            this.dtpTot.TabIndex = 2;
            // 
            // FrmGebruiksLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.grpbxFilter);
            this.Controls.Add(this.lblGebruiksLogTitel);
            this.MaximizeBox = false;
            this.Name = "FrmGebruiksLog";
            this.Text = "Gebruikslog";
            this.Load += new System.EventHandler(this.frmGebruiksLogDemo_Load);
            this.grpbxFilter.ResumeLayout(false);
            this.grpbxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGebruiksLogTitel;
        private System.Windows.Forms.DateTimePicker dtpVan;
        private System.Windows.Forms.GroupBox grpbxFilter;
        private System.Windows.Forms.DateTimePicker dtpTot;
        private System.Windows.Forms.TextBox txtGebruiker;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.CheckBox chkTot;
        private System.Windows.Forms.CheckBox chkVan;
    }
}