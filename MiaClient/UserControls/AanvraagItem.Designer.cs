namespace MiaClient.UserControls
{
    partial class AanvraagItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AanvraagItem));
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.lblAanvraagmoment = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.lblStatusAanvraag = new System.Windows.Forms.Label();
            this.lblKostenplaats = new System.Windows.Forms.Label();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.lblPlaningsDatum = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.Location = new System.Drawing.Point(118, 2);
            this.lblGebruiker.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(150, 28);
            this.lblGebruiker.TabIndex = 1;
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.Location = new System.Drawing.Point(278, 2);
            this.lblAanvraagmoment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(150, 28);
            this.lblAanvraagmoment.TabIndex = 2;
            this.lblAanvraagmoment.Click += new System.EventHandler(this.lblAanvraagmoment_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.Location = new System.Drawing.Point(438, 5);
            this.lblTitel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(150, 28);
            this.lblTitel.TabIndex = 3;
            this.lblTitel.Click += new System.EventHandler(this.lblTitel_Click);
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(734, 2);
            this.lblFinancieringsjaar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(60, 28);
            this.lblFinancieringsjaar.TabIndex = 4;
            this.lblFinancieringsjaar.Click += new System.EventHandler(this.lblFinancieringsjaar_Click);
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.Location = new System.Drawing.Point(804, 5);
            this.lblStatusAanvraag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(260, 28);
            this.lblStatusAanvraag.TabIndex = 5;
            this.lblStatusAanvraag.Click += new System.EventHandler(this.lblStatusAanvraag_Click);
            // 
            // lblKostenplaats
            // 
            this.lblKostenplaats.Location = new System.Drawing.Point(1074, 2);
            this.lblKostenplaats.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKostenplaats.Name = "lblKostenplaats";
            this.lblKostenplaats.Size = new System.Drawing.Size(150, 28);
            this.lblKostenplaats.TabIndex = 6;
            this.lblKostenplaats.Click += new System.EventHandler(this.lblKostenplaats_Click);
            // 
            // lblBedrag
            // 
            this.lblBedrag.Location = new System.Drawing.Point(1234, 5);
            this.lblBedrag.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(61, 28);
            this.lblBedrag.TabIndex = 7;
            // 
            // lblPlaningsDatum
            // 
            this.lblPlaningsDatum.Location = new System.Drawing.Point(598, 5);
            this.lblPlaningsDatum.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlaningsDatum.Name = "lblPlaningsDatum";
            this.lblPlaningsDatum.Size = new System.Drawing.Size(150, 28);
            this.lblPlaningsDatum.TabIndex = 8;
            this.lblPlaningsDatum.Click += new System.EventHandler(this.lblPlaningsDatum_Click);
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
            this.btnEdit.TabIndex = 9;
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
            this.btnDelete.TabIndex = 10;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(66, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 28);
            this.lblId.TabIndex = 11;
            this.lblId.Visible = false;
            // 
            // AanvraagItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPlaningsDatum);
            this.Controls.Add(this.lblBedrag);
            this.Controls.Add(this.lblKostenplaats);
            this.Controls.Add(this.lblStatusAanvraag);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.lblAanvraagmoment);
            this.Controls.Add(this.lblGebruiker);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AanvraagItem";
            this.Size = new System.Drawing.Size(1300, 33);
            this.Load += new System.EventHandler(this.AanvraagItem_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblStatusAanvraag;
        private System.Windows.Forms.Label lblKostenplaats;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Label lblPlaningsDatum;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAanvraagmoment;
        private System.Windows.Forms.Label lblId;
    }
}
