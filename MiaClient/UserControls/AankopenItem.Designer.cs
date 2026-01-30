namespace MiaClient.UserControls
{
    partial class AankopenItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AankopenItem));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblStatusAankoop = new System.Windows.Forms.Label();
            this.lblAankoper = new System.Windows.Forms.Label();
            this.lblAanvrager = new System.Windows.Forms.Label();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.lblRichtperiode = new System.Windows.Forms.Label();
            this.lblGoedgekeurdBedrag = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnEdit.Location = new System.Drawing.Point(0, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(27, 27);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(33, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 27);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblOmschrijving.Location = new System.Drawing.Point(66, 0);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(200, 33);
            this.lblOmschrijving.TabIndex = 2;
            this.lblOmschrijving.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusAankoop
            // 
            this.lblStatusAankoop.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStatusAankoop.Location = new System.Drawing.Point(272, 0);
            this.lblStatusAankoop.Name = "lblStatusAankoop";
            this.lblStatusAankoop.Size = new System.Drawing.Size(150, 33);
            this.lblStatusAankoop.TabIndex = 3;
            this.lblStatusAankoop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAankoper
            // 
            this.lblAankoper.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAankoper.Location = new System.Drawing.Point(428, 0);
            this.lblAankoper.Name = "lblAankoper";
            this.lblAankoper.Size = new System.Drawing.Size(150, 33);
            this.lblAankoper.TabIndex = 4;
            this.lblAankoper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAanvrager
            // 
            this.lblAanvrager.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAanvrager.Location = new System.Drawing.Point(584, 0);
            this.lblAanvrager.Name = "lblAanvrager";
            this.lblAanvrager.Size = new System.Drawing.Size(150, 33);
            this.lblAanvrager.TabIndex = 5;
            this.lblAanvrager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(740, 0);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(100, 33);
            this.lblFinancieringsjaar.TabIndex = 6;
            this.lblFinancieringsjaar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRichtperiode
            // 
            this.lblRichtperiode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRichtperiode.Location = new System.Drawing.Point(846, 0);
            this.lblRichtperiode.Name = "lblRichtperiode";
            this.lblRichtperiode.Size = new System.Drawing.Size(150, 33);
            this.lblRichtperiode.TabIndex = 7;
            this.lblRichtperiode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoedgekeurdBedrag
            // 
            this.lblGoedgekeurdBedrag.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGoedgekeurdBedrag.Location = new System.Drawing.Point(1002, 0);
            this.lblGoedgekeurdBedrag.Name = "lblGoedgekeurdBedrag";
            this.lblGoedgekeurdBedrag.Size = new System.Drawing.Size(150, 33);
            this.lblGoedgekeurdBedrag.TabIndex = 8;
            this.lblGoedgekeurdBedrag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSaldo.Location = new System.Drawing.Point(1158, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(150, 33);
            this.lblSaldo.TabIndex = 9;
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AankopenItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblGoedgekeurdBedrag);
            this.Controls.Add(this.lblRichtperiode);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.lblAanvrager);
            this.Controls.Add(this.lblAankoper);
            this.Controls.Add(this.lblStatusAankoop);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AankopenItem";
            this.Size = new System.Drawing.Size(1308, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblStatusAankoop;
        private System.Windows.Forms.Label lblAankoper;
        private System.Windows.Forms.Label lblAanvrager;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblRichtperiode;
        private System.Windows.Forms.Label lblGoedgekeurdBedrag;
        private System.Windows.Forms.Label lblSaldo;
    }
}
