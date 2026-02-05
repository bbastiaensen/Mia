using System.Drawing;
namespace MiaClient
{
    partial class frmNieuweAankoop
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlAanvragen = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblStatusAanvraag = new System.Windows.Forms.Label();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblRichtperiode = new System.Windows.Forms.Label();
            this.lblAanvrager = new System.Windows.Forms.Label();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAanvragen
            // 
            this.pnlAanvragen.AutoScroll = true;
            this.pnlAanvragen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAanvragen.Location = new System.Drawing.Point(0, 46);
            this.pnlAanvragen.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAanvragen.Name = "pnlAanvragen";
            this.pnlAanvragen.Size = new System.Drawing.Size(973, 495);
            this.pnlAanvragen.TabIndex = 5;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblStatusAanvraag);
            this.pnlHeader.Controls.Add(this.lblOmschrijving);
            this.pnlHeader.Controls.Add(this.lblRichtperiode);
            this.pnlHeader.Controls.Add(this.lblAanvrager);
            this.pnlHeader.Controls.Add(this.lblFinancieringsjaar);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(973, 46);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.Location = new System.Drawing.Point(50, 11);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(145, 25);
            this.lblOmschrijving.TabIndex = 5;
            this.lblOmschrijving.Text = "OMSCHRIJVING";

            // 
            // lblAanvrager
            // 
            this.lblAanvrager.Location = new System.Drawing.Point(250, 11);
            this.lblAanvrager.Name = "lblAanvrager";
            this.lblAanvrager.Size = new System.Drawing.Size(119, 25);
            this.lblAanvrager.TabIndex = 6;
            this.lblAanvrager.Text = "AANVRAGER";

            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.Location = new System.Drawing.Point(415, 9);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(166, 35);
            this.lblStatusAanvraag.TabIndex = 7;
            this.lblStatusAanvraag.Text = "STATUS AANVRAG";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(615, 9);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(188, 25);
            this.lblFinancieringsjaar.TabIndex = 8;
            this.lblFinancieringsjaar.Text = "FINANCIERINGSJAAR";
            // 
            // lblRichtperiode
            // 
            this.lblRichtperiode.Location = new System.Drawing.Point(800, 11);
            this.lblRichtperiode.Name = "lblRichtperiode";
            this.lblRichtperiode.Size = new System.Drawing.Size(137, 25);
            this.lblRichtperiode.TabIndex = 9;
            this.lblRichtperiode.Text = "RICHTPERIODE";
            // 
            // frmNieuweAankoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 541);
            this.Controls.Add(this.pnlAanvragen);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNieuweAankoop";
            this.Text = "Nieuwe aankoop toevoegen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNieuweAankoop_FormClosing);
            this.Load += new System.EventHandler(this.frmNieuweAankoop_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAanvragen;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblRichtperiode;
        private System.Windows.Forms.Label lblAanvrager;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblStatusAanvraag;
    }
}
