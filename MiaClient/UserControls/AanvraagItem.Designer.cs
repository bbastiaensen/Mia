namespace MiaClient.UserControls
{
    partial class AanvraagItem
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
            this.llblDetails = new System.Windows.Forms.LinkLabel();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.lblAanvraagmoment = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.lblStatusAanvraag = new System.Windows.Forms.Label();
            this.lblKostenplaats = new System.Windows.Forms.Label();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.lblPlaningsDatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llblDetails
            // 
            this.llblDetails.AutoSize = true;
            this.llblDetails.Location = new System.Drawing.Point(62, 19);
            this.llblDetails.Margin = new System.Windows.Forms.Padding(4);
            this.llblDetails.Name = "llblDetails";
            this.llblDetails.Size = new System.Drawing.Size(71, 28);
            this.llblDetails.TabIndex = 0;
            this.llblDetails.TabStop = true;
            this.llblDetails.Text = "Details";
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Location = new System.Drawing.Point(143, 19);
            this.lblGebruiker.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(148, 28);
            this.lblGebruiker.TabIndex = 1;
            this.lblGebruiker.Text = "Ellen Van Eygen";
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.AutoSize = true;
            this.lblAanvraagmoment.Location = new System.Drawing.Point(332, 19);
            this.lblAanvraagmoment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(116, 28);
            this.lblAanvraagmoment.TabIndex = 2;
            this.lblAanvraagmoment.Text = "00/00/0000";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(482, 19);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(134, 28);
            this.lblTitel.TabIndex = 3;
            this.lblTitel.Text = "20 tekens titel";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(655, 19);
            this.lblFinancieringsjaar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(56, 28);
            this.lblFinancieringsjaar.TabIndex = 4;
            this.lblFinancieringsjaar.Text = "2024";
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.AutoSize = true;
            this.lblStatusAanvraag.Location = new System.Drawing.Point(913, 19);
            this.lblStatusAanvraag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(101, 28);
            this.lblStatusAanvraag.TabIndex = 5;
            this.lblStatusAanvraag.Text = "Niet actief";
            // 
            // lblKostenplaats
            // 
            this.lblKostenplaats.AutoSize = true;
            this.lblKostenplaats.Location = new System.Drawing.Point(762, 19);
            this.lblKostenplaats.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKostenplaats.Name = "lblKostenplaats";
            this.lblKostenplaats.Size = new System.Drawing.Size(122, 28);
            this.lblKostenplaats.TabIndex = 6;
            this.lblKostenplaats.Text = "kostenplaats";
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(1255, 31);
            this.lblBedrag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(75, 28);
            this.lblBedrag.TabIndex = 7;
            this.lblBedrag.Text = "bedrag";
            // 
            // lblPlaningsDatum
            // 
            this.lblPlaningsDatum.AutoSize = true;
            this.lblPlaningsDatum.Location = new System.Drawing.Point(1081, 19);
            this.lblPlaningsDatum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlaningsDatum.Name = "lblPlaningsDatum";
            this.lblPlaningsDatum.Size = new System.Drawing.Size(116, 28);
            this.lblPlaningsDatum.TabIndex = 8;
            this.lblPlaningsDatum.Text = "00/00/0000";
            // 
            // AanvraagItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPlaningsDatum);
            this.Controls.Add(this.lblBedrag);
            this.Controls.Add(this.lblKostenplaats);
            this.Controls.Add(this.lblStatusAanvraag);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblAanvraagmoment);
            this.Controls.Add(this.lblGebruiker);
            this.Controls.Add(this.llblDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "AanvraagItem";
            this.Size = new System.Drawing.Size(1250, 53);
            this.Load += new System.EventHandler(this.AanvraagItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblDetails;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.Label lblAanvraagmoment;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblStatusAanvraag;
        private System.Windows.Forms.Label lblKostenplaats;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Label lblPlaningsDatum;
    }
}
