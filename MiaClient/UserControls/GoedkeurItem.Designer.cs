namespace MiaClient.UserControls
{
    partial class GoedkeurItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoedkeurItem));
            this.LblAanvrager = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblAanvraagmoment = new System.Windows.Forms.Label();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInAanvraag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAanvrager
            // 
            this.LblAanvrager.Location = new System.Drawing.Point(175, 2);
            this.LblAanvrager.Name = "LblAanvrager";
            this.LblAanvrager.Size = new System.Drawing.Size(113, 21);
            this.LblAanvrager.TabIndex = 11;
            this.LblAanvrager.Text = "01234567890";
            this.LblAanvrager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitel
            // 
            this.lblTitel.Location = new System.Drawing.Point(294, 2);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(256, 21);
            this.lblTitel.TabIndex = 12;
            this.lblTitel.Text = "01234567890123456789012345";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.Location = new System.Drawing.Point(556, 2);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(203, 21);
            this.lblAanvraagmoment.TabIndex = 13;
            this.lblAanvraagmoment.Text = "aaaaaa";
            this.lblAanvraagmoment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(799, 2);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(77, 21);
            this.lblFinancieringsjaar.TabIndex = 14;
            this.lblFinancieringsjaar.Text = "aaaaaa";
            this.lblFinancieringsjaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBedrag
            // 
            this.lblBedrag.Location = new System.Drawing.Point(882, 2);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(115, 21);
            this.lblBedrag.TabIndex = 15;
            this.lblBedrag.Text = "01234567890";
            this.lblBedrag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(4, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(27, 27);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInAanvraag
            // 
            this.btnInAanvraag.BackColor = System.Drawing.Color.Transparent;
            this.btnInAanvraag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInAanvraag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInAanvraag.FlatAppearance.BorderSize = 0;
            this.btnInAanvraag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInAanvraag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInAanvraag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInAanvraag.Location = new System.Drawing.Point(37, 2);
            this.btnInAanvraag.Name = "btnInAanvraag";
            this.btnInAanvraag.Size = new System.Drawing.Size(27, 27);
            this.btnInAanvraag.TabIndex = 21;
            this.btnInAanvraag.UseVisualStyleBackColor = false;
            // 
            // GoedkeurItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInAanvraag);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblBedrag);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.lblAanvraagmoment);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.LblAanvrager);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GoedkeurItem";
            this.Size = new System.Drawing.Size(1000, 33);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblAanvrager;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblAanvraagmoment;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInAanvraag;
    }
}
