using System.Drawing;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    partial class NieuweAankoopItem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.btnEuro = new Button();
            this.lblOmschrijving = new Label();
            this.lblAanvrager = new Label();
            this.lblStatusAanvraag = new Label();
            this.lblFinancieringsjaar = new Label();
            this.lblRichtperiode = new Label();
            this.SuspendLayout();

            // 
            // btnEuro
            // 
            this.btnEuro.FlatStyle = FlatStyle.Flat;
            this.btnEuro.FlatAppearance.BorderSize = 0;
            this.btnEuro.Location = new Point(3, 9);
            this.btnEuro.Size = new Size(20, 20);
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);

            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = false; // Belangrijk!
            this.lblOmschrijving.AutoEllipsis = false; // eigen Paint
            this.lblOmschrijving.Font = new Font("Segoe UI", 12F);
            this.lblOmschrijving.Location = new Point(59, 0);
            this.lblOmschrijving.Size = new Size(170, 32);
            this.lblOmschrijving.Padding = new Padding(0);

            // Paint event om linksonder + EndEllipsis correct te tekenen
            this.lblOmschrijving.Paint += (s, e) =>
            {
                var lbl = (Label)s;
                TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.Bottom | TextFormatFlags.EndEllipsis;
                e.Graphics.Clear(lbl.BackColor);
                TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, lbl.ClientRectangle, lbl.ForeColor, flags);
            };

            // 
            // lblAanvrager
            // 
            this.lblAanvrager.AutoSize = false;
            this.lblAanvrager.Font = new Font("Segoe UI", 12F);
            this.lblAanvrager.Location = new Point(245, 0);
            this.lblAanvrager.Size = new Size(140, 32);
            this.lblAanvrager.TextAlign = ContentAlignment.BottomLeft;
            this.lblAanvrager.AutoEllipsis = true;

            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.AutoSize = false;
            this.lblStatusAanvraag.Font = new Font("Segoe UI", 12F);
            this.lblStatusAanvraag.Location = new Point(392, 0);
            this.lblStatusAanvraag.Size = new Size(200, 32);
            this.lblStatusAanvraag.TextAlign = ContentAlignment.BottomLeft;
            this.lblStatusAanvraag.AutoEllipsis = true;

            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = false;
            this.lblFinancieringsjaar.Font = new Font("Segoe UI", 12F);
            this.lblFinancieringsjaar.Location = new Point(600, 0);
            this.lblFinancieringsjaar.Size = new Size(120, 32);
            this.lblFinancieringsjaar.TextAlign = ContentAlignment.BottomLeft;
            this.lblFinancieringsjaar.AutoEllipsis = true;

            // 
            // lblRichtperiode
            // 
            this.lblRichtperiode.AutoSize = false;
            this.lblRichtperiode.Font = new Font("Segoe UI", 12F);
            this.lblRichtperiode.Location = new Point(740, 0);
            this.lblRichtperiode.Size = new Size(160, 32);
            this.lblRichtperiode.TextAlign = ContentAlignment.BottomLeft;
            this.lblRichtperiode.AutoEllipsis = true;

            // 
            // NieuweAankoopItem
            // 
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.lblAanvrager);
            this.Controls.Add(this.lblStatusAanvraag);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.lblRichtperiode);
            this.Size = new Size(950, 32);
            this.ResumeLayout(false);
        }

        #endregion

        private Button btnEuro;
        private Label lblOmschrijving;
        private Label lblAanvrager;
        private Label lblStatusAanvraag;
        private Label lblFinancieringsjaar;
        private Label lblRichtperiode;
    }
}
