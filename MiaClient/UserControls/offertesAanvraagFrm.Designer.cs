namespace MiaClient.UserControls
{
    partial class OffertesAanvraagFrm
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
            this.llbl_HyperlinkDetails = new System.Windows.Forms.LinkLabel();
            this.lbl_Offerte = new System.Windows.Forms.Label();
            this.llbl_OffertesDetails = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llbl_HyperlinkDetails
            // 
            this.llbl_HyperlinkDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_HyperlinkDetails.Location = new System.Drawing.Point(303, 4);
            this.llbl_HyperlinkDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_HyperlinkDetails.Name = "llbl_HyperlinkDetails";
            this.llbl_HyperlinkDetails.Size = new System.Drawing.Size(0, 0);
            this.llbl_HyperlinkDetails.TabIndex = 4;
            this.llbl_HyperlinkDetails.TabStop = true;
            this.llbl_HyperlinkDetails.Text = "Details";
            // 
            // lbl_Offerte
            // 
            this.lbl_Offerte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Offerte.Location = new System.Drawing.Point(91, 4);
            this.lbl_Offerte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Offerte.Name = "lbl_Offerte";
            this.lbl_Offerte.Size = new System.Drawing.Size(580, 28);
            this.lbl_Offerte.TabIndex = 6;
            this.lbl_Offerte.Text = "01234567890123456789012345678901234567890123456789";
            // 
            // llbl_OffertesDetails
            // 
            this.llbl_OffertesDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_OffertesDetails.Location = new System.Drawing.Point(4, 4);
            this.llbl_OffertesDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_OffertesDetails.Name = "llbl_OffertesDetails";
            this.llbl_OffertesDetails.Size = new System.Drawing.Size(95, 28);
            this.llbl_OffertesDetails.TabIndex = 5;
            this.llbl_OffertesDetails.TabStop = true;
            this.llbl_OffertesDetails.Text = "Details";
            // 
            // OffertesAanvraagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Offerte);
            this.Controls.Add(this.llbl_OffertesDetails);
            this.Controls.Add(this.llbl_HyperlinkDetails);
            this.Name = "OffertesAanvraagFrm";
            this.Size = new System.Drawing.Size(1000, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbl_HyperlinkDetails;
        private System.Windows.Forms.Label lbl_Offerte;
        private System.Windows.Forms.LinkLabel llbl_OffertesDetails;
    }
}
