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
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblRichtperiode = new System.Windows.Forms.Label();
            this.lblAanvrager = new System.Windows.Forms.Label();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAanvragen
            // 
            this.pnlAanvragen.Location = new System.Drawing.Point(0, 50);
            this.pnlAanvragen.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAanvragen.Name = "pnlAanvragen";
            this.pnlAanvragen.Size = new System.Drawing.Size(973, 400);
            this.pnlAanvragen.TabIndex = 5;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblStatusAanvraag);
            this.pnlHeader.Controls.Add(this.lblTitel);
            this.pnlHeader.Controls.Add(this.lblRichtperiode);
            this.pnlHeader.Controls.Add(this.lblAanvrager);
            this.pnlHeader.Controls.Add(this.lblFinancieringsjaar);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(973, 57);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.Location = new System.Drawing.Point(415, 15);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(166, 35);
            this.lblStatusAanvraag.TabIndex = 7;
            this.lblStatusAanvraag.Text = "STATUS AANVRAG";
            // 
            // lblTitel
            // 
            this.lblTitel.Location = new System.Drawing.Point(50, 15);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(145, 25);
            this.lblTitel.TabIndex = 5;
            this.lblTitel.Text = "Titel";
            // 
            // lblRichtperiode
            // 
            this.lblRichtperiode.Location = new System.Drawing.Point(800, 15);
            this.lblRichtperiode.Name = "lblRichtperiode";
            this.lblRichtperiode.Size = new System.Drawing.Size(137, 25);
            this.lblRichtperiode.TabIndex = 9;
            this.lblRichtperiode.Text = "RICHTPERIODE";
            // 
            // lblAanvrager
            // 
            this.lblAanvrager.Location = new System.Drawing.Point(250, 15);
            this.lblAanvrager.Name = "lblAanvrager";
            this.lblAanvrager.Size = new System.Drawing.Size(119, 25);
            this.lblAanvrager.TabIndex = 6;
            this.lblAanvrager.Text = "AANVRAGER";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(615, 15);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(188, 25);
            this.lblFinancieringsjaar.TabIndex = 8;
            this.lblFinancieringsjaar.Text = "FINANCIERINGSJAAR";
            // 
            // lblPages
            // 
            this.lblPages.Location = new System.Drawing.Point(333, 466);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(280, 28);
            this.lblPages.TabIndex = 7;
            this.lblPages.Text = "lable";
            this.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(855, 464);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 30);
            this.btnLast.TabIndex = 4;
            this.btnLast.Tag = "icon";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            this.btnLast.MouseLeave += new System.EventHandler(this.btnLast_MouseLeave);
            this.btnLast.MouseHover += new System.EventHandler(this.btnLast_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(796, 464);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 3;
            this.btnNext.Tag = "icon";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirst.Location = new System.Drawing.Point(84, 464);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 30);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Tag = "icon";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            this.btnFirst.MouseLeave += new System.EventHandler(this.btnFirst_MouseLeave);
            this.btnFirst.MouseHover += new System.EventHandler(this.btnFirst_MouseHover);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrevious.Location = new System.Drawing.Point(143, 464);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Tag = "icon";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnPrevious_MouseLeave);
            this.btnPrevious.MouseHover += new System.EventHandler(this.btnPrevious_MouseHover);
            // 
            // frmNieuweAankoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 503);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pnlAanvragen);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.btnNext);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblRichtperiode;
        private System.Windows.Forms.Label lblAanvrager;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblStatusAanvraag;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
    }
}
