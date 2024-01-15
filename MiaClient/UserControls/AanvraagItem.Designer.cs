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
            this.llblDetails.Location = new System.Drawing.Point(17, 18);
            this.llblDetails.Name = "llblDetails";
            this.llblDetails.Size = new System.Drawing.Size(49, 16);
            this.llblDetails.TabIndex = 0;
            this.llblDetails.TabStop = true;
            this.llblDetails.Text = "Details";
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Location = new System.Drawing.Point(125, 18);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(66, 16);
            this.lblGebruiker.TabIndex = 1;
            this.lblGebruiker.Text = "Gebruiker";
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.AutoSize = true;
            this.lblAanvraagmoment.Location = new System.Drawing.Point(208, 18);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(113, 16);
            this.lblAanvraagmoment.TabIndex = 2;
            this.lblAanvraagmoment.Text = "aanvraagmoment";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(336, 18);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(27, 16);
            this.lblTitel.TabIndex = 3;
            this.lblTitel.Text = "titel";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(380, 18);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(105, 16);
            this.lblFinancieringsjaar.TabIndex = 4;
            this.lblFinancieringsjaar.Text = "financieringsjaar";
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.AutoSize = true;
            this.lblStatusAanvraag.Location = new System.Drawing.Point(507, 18);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(103, 16);
            this.lblStatusAanvraag.TabIndex = 5;
            this.lblStatusAanvraag.Text = "status aanvraag";
            // 
            // lblKostenplaats
            // 
            this.lblKostenplaats.AutoSize = true;
            this.lblKostenplaats.Location = new System.Drawing.Point(632, 18);
            this.lblKostenplaats.Name = "lblKostenplaats";
            this.lblKostenplaats.Size = new System.Drawing.Size(84, 16);
            this.lblKostenplaats.TabIndex = 6;
            this.lblKostenplaats.Text = "kostenplaats";
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(743, 18);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(51, 16);
            this.lblBedrag.TabIndex = 7;
            this.lblBedrag.Text = "bedrag";
            // 
            // lblPlaningsDatum
            // 
            this.lblPlaningsDatum.AutoSize = true;
            this.lblPlaningsDatum.Location = new System.Drawing.Point(839, 18);
            this.lblPlaningsDatum.Name = "lblPlaningsDatum";
            this.lblPlaningsDatum.Size = new System.Drawing.Size(102, 16);
            this.lblPlaningsDatum.TabIndex = 8;
            this.lblPlaningsDatum.Text = "planningsdatum";
            // 
            // AanvraagItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AanvraagItem";
            this.Size = new System.Drawing.Size(1241, 54);
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
