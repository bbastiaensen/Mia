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
            this.btnStatusEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAanvrager
            // 
            this.LblAanvrager.AutoSize = true;
            this.LblAanvrager.Location = new System.Drawing.Point(124, 1);
            this.LblAanvrager.Name = "LblAanvrager";
            this.LblAanvrager.Size = new System.Drawing.Size(72, 28);
            this.LblAanvrager.TabIndex = 11;
            this.LblAanvrager.Text = "aaaaaa";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(228, 1);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(72, 28);
            this.lblTitel.TabIndex = 12;
            this.lblTitel.Text = "aaaaaa";
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.AutoSize = true;
            this.lblAanvraagmoment.Location = new System.Drawing.Point(409, 1);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(72, 28);
            this.lblAanvraagmoment.TabIndex = 13;
            this.lblAanvraagmoment.Text = "aaaaaa";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(636, 2);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(72, 28);
            this.lblFinancieringsjaar.TabIndex = 14;
            this.lblFinancieringsjaar.Text = "aaaaaa";
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(784, 2);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(72, 28);
            this.lblBedrag.TabIndex = 15;
            this.lblBedrag.Text = "aaaaaa";
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
            this.btnEdit.Location = new System.Drawing.Point(15, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(27, 27);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStatusEdit
            // 
            this.btnStatusEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnStatusEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStatusEdit.FlatAppearance.BorderSize = 0;
            this.btnStatusEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStatusEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStatusEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnStatusEdit.Image")));
            this.btnStatusEdit.Location = new System.Drawing.Point(48, 3);
            this.btnStatusEdit.Name = "btnStatusEdit";
            this.btnStatusEdit.Size = new System.Drawing.Size(27, 27);
            this.btnStatusEdit.TabIndex = 21;
            this.btnStatusEdit.UseVisualStyleBackColor = false;
            // 
            // GoedkeurItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStatusEdit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblBedrag);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.lblAanvraagmoment);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.LblAanvrager);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GoedkeurItem";
            this.Size = new System.Drawing.Size(881, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblAanvrager;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblAanvraagmoment;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnStatusEdit;
    }
}
