namespace MiaClient.UserControls
{
    partial class GebruikslogItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTijdstipActie = new System.Windows.Forms.Label();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.llblDetails = new System.Windows.Forms.LinkLabel();
            this.lblOmschrijvingActieKort = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTijdstipActie
            // 
            this.lblTijdstipActie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijdstipActie.Location = new System.Drawing.Point(81, 4);
            this.lblTijdstipActie.Name = "lblTijdstipActie";
            this.lblTijdstipActie.Size = new System.Drawing.Size(170, 23);
            this.lblTijdstipActie.TabIndex = 0;
            this.lblTijdstipActie.Text = "31/12/2023 - 23:59:59";
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiker.Location = new System.Drawing.Point(257, 4);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(150, 23);
            this.lblGebruiker.TabIndex = 1;
            this.lblGebruiker.Text = "Davy Vueghs";
            // 
            // llblDetails
            // 
            this.llblDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblDetails.Location = new System.Drawing.Point(4, 4);
            this.llblDetails.Name = "llblDetails";
            this.llblDetails.Size = new System.Drawing.Size(71, 23);
            this.llblDetails.TabIndex = 2;
            this.llblDetails.TabStop = true;
            this.llblDetails.Text = "Details";
            this.llblDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDetails_LinkClicked);
            // 
            // lblOmschrijvingActieKort
            // 
            this.lblOmschrijvingActieKort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmschrijvingActieKort.Location = new System.Drawing.Point(413, 4);
            this.lblOmschrijvingActieKort.Name = "lblOmschrijvingActieKort";
            this.lblOmschrijvingActieKort.Size = new System.Drawing.Size(461, 23);
            this.lblOmschrijvingActieKort.TabIndex = 3;
            this.lblOmschrijvingActieKort.Text = "01234567890123456789012345678901234567890123456789";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(60, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Visible = false;
            // 
            // GebruikslogItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblOmschrijvingActieKort);
            this.Controls.Add(this.llblDetails);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.lblTijdstipActie);
            this.Name = "GebruikslogItem";
            this.Size = new System.Drawing.Size(881, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTijdstipActie;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.LinkLabel llblDetails;
        private System.Windows.Forms.Label lblOmschrijvingActieKort;
        private System.Windows.Forms.Label lblId;
    }
}
