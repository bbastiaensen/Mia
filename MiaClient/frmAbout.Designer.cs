namespace MiaClient
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.llblProjectLogoAttribution = new System.Windows.Forms.LinkLabel();
            this.pbxProjectLogo = new System.Windows.Forms.PictureBox();
            this.lblProjectTitel = new System.Windows.Forms.Label();
            this.lblOntwikkeldVoor = new System.Windows.Forms.Label();
            this.lblOntwikkeldDoor = new System.Windows.Forms.Label();
            this.llblMuylenberg = new System.Windows.Forms.LinkLabel();
            this.llblTaTu = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblIconsByIcon8 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProjectLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblProjectLogoAttribution
            // 
            this.llblProjectLogoAttribution.AutoSize = true;
            this.llblProjectLogoAttribution.Location = new System.Drawing.Point(6, 25);
            this.llblProjectLogoAttribution.Name = "llblProjectLogoAttribution";
            this.llblProjectLogoAttribution.Size = new System.Drawing.Size(249, 21);
            this.llblProjectLogoAttribution.TabIndex = 0;
            this.llblProjectLogoAttribution.TabStop = true;
            this.llblProjectLogoAttribution.Text = "Projectlogo door Freepik - Flaticon";
            this.llblProjectLogoAttribution.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblProjectLogoAttribution_LinkClicked);
            // 
            // pbxProjectLogo
            // 
            this.pbxProjectLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxProjectLogo.Image")));
            this.pbxProjectLogo.Location = new System.Drawing.Point(19, 67);
            this.pbxProjectLogo.Name = "pbxProjectLogo";
            this.pbxProjectLogo.Size = new System.Drawing.Size(125, 125);
            this.pbxProjectLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxProjectLogo.TabIndex = 1;
            this.pbxProjectLogo.TabStop = false;
            this.pbxProjectLogo.DoubleClick += new System.EventHandler(this.pbxProjectLogo_DoubleClick);
            // 
            // lblProjectTitel
            // 
            this.lblProjectTitel.AutoSize = true;
            this.lblProjectTitel.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitel.Location = new System.Drawing.Point(12, 9);
            this.lblProjectTitel.Name = "lblProjectTitel";
            this.lblProjectTitel.Size = new System.Drawing.Size(544, 37);
            this.lblProjectTitel.TabIndex = 2;
            this.lblProjectTitel.Text = "MIA: Muylenberg InvesteringsAanvragen";
            // 
            // lblOntwikkeldVoor
            // 
            this.lblOntwikkeldVoor.AutoSize = true;
            this.lblOntwikkeldVoor.Location = new System.Drawing.Point(165, 67);
            this.lblOntwikkeldVoor.Name = "lblOntwikkeldVoor";
            this.lblOntwikkeldVoor.Size = new System.Drawing.Size(233, 126);
            this.lblOntwikkeldVoor.TabIndex = 3;
            this.lblOntwikkeldVoor.Text = "Ontwikkeld in opdracht van:\r\n     KMSL (vzw) \r\n     Korte Begijnenstraat 22 \r\n   " +
    "  2300 Turnhout\r\n\r\n    Product owner: Hild Van Rooy\r\n";
            // 
            // lblOntwikkeldDoor
            // 
            this.lblOntwikkeldDoor.AutoSize = true;
            this.lblOntwikkeldDoor.Location = new System.Drawing.Point(496, 67);
            this.lblOntwikkeldDoor.Name = "lblOntwikkeldDoor";
            this.lblOntwikkeldDoor.Size = new System.Drawing.Size(300, 273);
            this.lblOntwikkeldDoor.TabIndex = 4;
            this.lblOntwikkeldDoor.Text = resources.GetString("lblOntwikkeldDoor.Text");
            // 
            // llblMuylenberg
            // 
            this.llblMuylenberg.AutoSize = true;
            this.llblMuylenberg.Location = new System.Drawing.Point(182, 209);
            this.llblMuylenberg.Name = "llblMuylenberg";
            this.llblMuylenberg.Size = new System.Drawing.Size(153, 21);
            this.llblMuylenberg.TabIndex = 5;
            this.llblMuylenberg.TabStop = true;
            this.llblMuylenberg.Text = "www.muylenberg.be";
            this.llblMuylenberg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMuylenberg_LinkClicked);
            // 
            // llblTaTu
            // 
            this.llblTaTu.AutoSize = true;
            this.llblTaTu.Location = new System.Drawing.Point(516, 353);
            this.llblTaTu.Name = "llblTaTu";
            this.llblTaTu.Size = new System.Drawing.Size(231, 21);
            this.llblTaTu.TabIndex = 6;
            this.llblTaTu.TabStop = true;
            this.llblTaTu.Text = "www.talentenschoolturnhout.be";
            this.llblTaTu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTaTu_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llblIconsByIcon8);
            this.groupBox1.Controls.Add(this.llblProjectLogoAttribution);
            this.groupBox1.Location = new System.Drawing.Point(12, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credits";
            // 
            // llblIconsByIcon8
            // 
            this.llblIconsByIcon8.AutoSize = true;
            this.llblIconsByIcon8.Location = new System.Drawing.Point(6, 46);
            this.llblIconsByIcon8.Name = "llblIconsByIcon8";
            this.llblIconsByIcon8.Size = new System.Drawing.Size(125, 21);
            this.llblIconsByIcon8.TabIndex = 1;
            this.llblIconsByIcon8.TabStop = true;
            this.llblIconsByIcon8.Text = "Icons door Icon8";
            this.llblIconsByIcon8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblIconsByIcon8_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llblTaTu);
            this.Controls.Add(this.llblMuylenberg);
            this.Controls.Add(this.lblOntwikkeldDoor);
            this.Controls.Add(this.lblOntwikkeldVoor);
            this.Controls.Add(this.lblProjectTitel);
            this.Controls.Add(this.pbxProjectLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Over MIA";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProjectLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblProjectLogoAttribution;
        private System.Windows.Forms.PictureBox pbxProjectLogo;
        private System.Windows.Forms.Label lblProjectTitel;
        private System.Windows.Forms.Label lblOntwikkeldVoor;
        private System.Windows.Forms.Label lblOntwikkeldDoor;
        private System.Windows.Forms.LinkLabel llblMuylenberg;
        private System.Windows.Forms.LinkLabel llblTaTu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llblIconsByIcon8;
    }
}