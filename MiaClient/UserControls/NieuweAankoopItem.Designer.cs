namespace MiaClient.UserControls
{
    partial class NieuweAankoopItem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.btnEuro = new System.Windows.Forms.Button();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblAanvrager = new System.Windows.Forms.Label();
            this.lblStatusAanvraag = new System.Windows.Forms.Label();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.lblRichtperiode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEuro
            // 
            this.btnEuro.BackColor = System.Drawing.Color.Transparent;
            this.btnEuro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEuro.FlatAppearance.BorderSize = 0;
            this.btnEuro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEuro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEuro.Location = new System.Drawing.Point(3, 3);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(27, 27);
            this.btnEuro.TabIndex = 0;
            this.btnEuro.UseVisualStyleBackColor = false;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOmschrijving.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOmschrijving.Location = new System.Drawing.Point(59, 0);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(170, 23);
            this.lblOmschrijving.TabIndex = 1;
            this.lblOmschrijving.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAanvrager
            // 
            this.lblAanvrager.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAanvrager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAanvrager.Location = new System.Drawing.Point(245, 0);
            this.lblAanvrager.Name = "lblAanvrager";
            this.lblAanvrager.Size = new System.Drawing.Size(160, 33);
            this.lblAanvrager.TabIndex = 10;
            this.lblAanvrager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStatusAanvraag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatusAanvraag.Location = new System.Drawing.Point(392, 0);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(180, 33);
            this.lblStatusAanvraag.AutoEllipsis = true;
            this.lblStatusAanvraag.TabIndex = 3;
            this.lblStatusAanvraag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFinancieringsjaar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(620, 0);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(100, 33);
            this.lblFinancieringsjaar.TabIndex = 4;
            this.lblFinancieringsjaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // 
            // lblRichtperiode
            // 
            this.lblRichtperiode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRichtperiode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRichtperiode.Location = new System.Drawing.Point(800, 0);
            this.lblRichtperiode.Name = "lblRichtperiode";
            this.lblRichtperiode.Size = new System.Drawing.Size(160, 33);
            this.lblRichtperiode.TabIndex = 5;
            this.lblRichtperiode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NieuweAankoopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.lblAanvrager);
            this.Controls.Add(this.lblStatusAanvraag);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.lblRichtperiode);
            this.Name = "NieuweAankoopItem";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblAanvrager;
        private System.Windows.Forms.Label lblStatusAanvraag;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblRichtperiode;
    }
}
