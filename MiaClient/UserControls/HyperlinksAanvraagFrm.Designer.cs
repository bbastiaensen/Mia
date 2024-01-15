namespace MiaClient.UserControls
{
    partial class HyperlinksAanvraagFrm
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
            this.lbl_hyperlink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llbl_HyperlinkDetails
            // 
            this.llbl_HyperlinkDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_HyperlinkDetails.Location = new System.Drawing.Point(5, 5);
            this.llbl_HyperlinkDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_HyperlinkDetails.Name = "llbl_HyperlinkDetails";
            this.llbl_HyperlinkDetails.Size = new System.Drawing.Size(95, 28);
            this.llbl_HyperlinkDetails.TabIndex = 3;
            this.llbl_HyperlinkDetails.TabStop = true;
            this.llbl_HyperlinkDetails.Text = "Details";
            // 
            // lbl_hyperlink
            // 
            this.lbl_hyperlink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hyperlink.Location = new System.Drawing.Point(92, 5);
            this.lbl_hyperlink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hyperlink.Name = "lbl_hyperlink";
            this.lbl_hyperlink.Size = new System.Drawing.Size(580, 28);
            this.lbl_hyperlink.TabIndex = 4;
            this.lbl_hyperlink.Text = "01234567890123456789012345678901234567890123456789";
            // 
            // HyperlinksAanvraagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_hyperlink);
            this.Controls.Add(this.llbl_HyperlinkDetails);
            this.Name = "HyperlinksAanvraagFrm";
            this.Size = new System.Drawing.Size(1000, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbl_HyperlinkDetails;
        private System.Windows.Forms.Label lbl_hyperlink;
    }
}
