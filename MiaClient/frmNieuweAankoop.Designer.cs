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
            this.pnlAanvragen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAanvragen.Location = new System.Drawing.Point(0, 46);
            this.pnlAanvragen.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAanvragen.Name = "pnlAanvragen";
            this.pnlAanvragen.Size = new System.Drawing.Size(967, 547);
            this.pnlAanvragen.TabIndex = 5;
            this.pnlAanvragen.HorizontalScroll.Enabled = false;
            this.pnlAanvragen.HorizontalScroll.Visible = false;
            this.pnlAanvragen.HorizontalScroll.Maximum = 0;
            this.pnlAanvragen.AutoScrollMinSize = new Size(0, 0);
            this.pnlAanvragen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAanvragen.HorizontalScroll.Enabled = false;
            this.pnlAanvragen.HorizontalScroll.Visible = false;
            this.pnlAanvragen.VerticalScroll.Enabled = true;



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
            this.pnlHeader.Size = new System.Drawing.Size(967, 46);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.AutoSize = false;
            this.lblStatusAanvraag.Location = new System.Drawing.Point(392, 9);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(166, 35);
            this.lblStatusAanvraag.TabIndex = 7;
            this.lblStatusAanvraag.Text = "STATUS AANVRAG";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = false;
            this.lblOmschrijving.Location = new System.Drawing.Point(59, 11);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(145, 25);
            this.lblOmschrijving.TabIndex = 5;
            this.lblOmschrijving.Text = "OMSCHRIJVING";
            // 
            // lblRichtperiode
            // 
            this.lblRichtperiode.AutoSize = false;
            this.lblRichtperiode.Location = new System.Drawing.Point(791, 11);
            this.lblRichtperiode.Name = "lblRichtperiode";
            this.lblRichtperiode.Size = new System.Drawing.Size(137, 25);
            this.lblRichtperiode.TabIndex = 9;
            this.lblRichtperiode.Text = "RICHTPERIODE";
            // 
            // lblAanvrager
            // 
            this.lblAanvrager.AutoSize = false;
            this.lblAanvrager.Location = new System.Drawing.Point(245, 11);
            this.lblAanvrager.Name = "lblAanvrager";
            this.lblAanvrager.Size = new System.Drawing.Size(119, 25);
            this.lblAanvrager.TabIndex = 6;
            this.lblAanvrager.Text = "AANVRAGER";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = false;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(576, 9);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(188, 25);
            this.lblFinancieringsjaar.TabIndex = 8;
            this.lblFinancieringsjaar.Text = "FINANCIERINGSJAAR";
            // 
            // frmNieuweAankoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 547);
            this.Controls.Add(this.pnlAanvragen);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNieuweAankoop";
            this.Text = "Nieuwe aankoop toevoegen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNieuweAankoop_FormClosing);
            this.Load += new System.EventHandler(this.frmNieuweAankoop_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
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
