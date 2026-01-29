namespace MiaClient
{
    partial class frmSaldoOverzetten
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAanvraagId = new System.Windows.Forms.TextBox();
            this.lblAanvraagId = new System.Windows.Forms.Label();
            this.btnZoeken = new System.Windows.Forms.Button();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.txtAanvrager = new System.Windows.Forms.TextBox();
            this.lblAanvrager = new System.Windows.Forms.Label();
            this.lblGoedgekeurdBedrag = new System.Windows.Forms.Label();
            this.txtGoedgekeurdBedrag = new System.Windows.Forms.TextBox();
            this.lblStatusAanvraag = new System.Windows.Forms.Label();
            this.txtStatusAanvraag = new System.Windows.Forms.TextBox();
            this.btnSaldoOverzetten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAanvraagId
            // 
            this.txtAanvraagId.Location = new System.Drawing.Point(169, 9);
            this.txtAanvraagId.Name = "txtAanvraagId";
            this.txtAanvraagId.Size = new System.Drawing.Size(268, 27);
            this.txtAanvraagId.TabIndex = 0;
            // 
            // lblAanvraagId
            // 
            this.lblAanvraagId.AutoSize = true;
            this.lblAanvraagId.Location = new System.Drawing.Point(12, 12);
            this.lblAanvraagId.Name = "lblAanvraagId";
            this.lblAanvraagId.Size = new System.Drawing.Size(130, 20);
            this.lblAanvraagId.TabIndex = 1;
            this.lblAanvraagId.Text = "Aanvraagnummer:";
            // 
            // btnZoeken
            // 
            this.btnZoeken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoeken.FlatAppearance.BorderSize = 0;
            this.btnZoeken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoeken.Location = new System.Drawing.Point(443, 2);
            this.btnZoeken.Name = "btnZoeken";
            this.btnZoeken.Size = new System.Drawing.Size(40, 40);
            this.btnZoeken.TabIndex = 28;
            this.btnZoeken.UseVisualStyleBackColor = true;
            this.btnZoeken.Click += new System.EventHandler(this.btnZoeken_Click);
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Location = new System.Drawing.Point(169, 64);
            this.txtOmschrijving.Multiline = true;
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.ReadOnly = true;
            this.txtOmschrijving.Size = new System.Drawing.Size(314, 94);
            this.txtOmschrijving.TabIndex = 29;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Location = new System.Drawing.Point(12, 64);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(98, 20);
            this.lblOmschrijving.TabIndex = 30;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // txtAanvrager
            // 
            this.txtAanvrager.Location = new System.Drawing.Point(169, 165);
            this.txtAanvrager.Name = "txtAanvrager";
            this.txtAanvrager.ReadOnly = true;
            this.txtAanvrager.Size = new System.Drawing.Size(314, 27);
            this.txtAanvrager.TabIndex = 31;
            // 
            // lblAanvrager
            // 
            this.lblAanvrager.AutoSize = true;
            this.lblAanvrager.Location = new System.Drawing.Point(12, 168);
            this.lblAanvrager.Name = "lblAanvrager";
            this.lblAanvrager.Size = new System.Drawing.Size(80, 20);
            this.lblAanvrager.TabIndex = 32;
            this.lblAanvrager.Text = "Aanvrager:";
            // 
            // lblGoedgekeurdBedrag
            // 
            this.lblGoedgekeurdBedrag.AutoSize = true;
            this.lblGoedgekeurdBedrag.Location = new System.Drawing.Point(12, 201);
            this.lblGoedgekeurdBedrag.Name = "lblGoedgekeurdBedrag";
            this.lblGoedgekeurdBedrag.Size = new System.Drawing.Size(154, 20);
            this.lblGoedgekeurdBedrag.TabIndex = 34;
            this.lblGoedgekeurdBedrag.Text = "Goedgekeurd bedrag:";
            // 
            // txtGoedgekeurdBedrag
            // 
            this.txtGoedgekeurdBedrag.Location = new System.Drawing.Point(169, 198);
            this.txtGoedgekeurdBedrag.Name = "txtGoedgekeurdBedrag";
            this.txtGoedgekeurdBedrag.ReadOnly = true;
            this.txtGoedgekeurdBedrag.Size = new System.Drawing.Size(314, 27);
            this.txtGoedgekeurdBedrag.TabIndex = 33;
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.AutoSize = true;
            this.lblStatusAanvraag.Location = new System.Drawing.Point(12, 234);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(117, 20);
            this.lblStatusAanvraag.TabIndex = 36;
            this.lblStatusAanvraag.Text = "Status aanvraag:";
            // 
            // txtStatusAanvraag
            // 
            this.txtStatusAanvraag.Location = new System.Drawing.Point(169, 231);
            this.txtStatusAanvraag.Name = "txtStatusAanvraag";
            this.txtStatusAanvraag.ReadOnly = true;
            this.txtStatusAanvraag.Size = new System.Drawing.Size(314, 27);
            this.txtStatusAanvraag.TabIndex = 35;
            // 
            // btnSaldoOverzetten
            // 
            this.btnSaldoOverzetten.Enabled = false;
            this.btnSaldoOverzetten.Location = new System.Drawing.Point(16, 264);
            this.btnSaldoOverzetten.Name = "btnSaldoOverzetten";
            this.btnSaldoOverzetten.Size = new System.Drawing.Size(467, 50);
            this.btnSaldoOverzetten.TabIndex = 37;
            this.btnSaldoOverzetten.Text = "button1";
            this.btnSaldoOverzetten.UseVisualStyleBackColor = true;
            this.btnSaldoOverzetten.Click += new System.EventHandler(this.btnSaldoOverzetten_Click);
            // 
            // frmSaldoOverzetten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 322);
            this.Controls.Add(this.btnSaldoOverzetten);
            this.Controls.Add(this.lblStatusAanvraag);
            this.Controls.Add(this.txtStatusAanvraag);
            this.Controls.Add(this.lblGoedgekeurdBedrag);
            this.Controls.Add(this.txtGoedgekeurdBedrag);
            this.Controls.Add(this.lblAanvrager);
            this.Controls.Add(this.txtAanvrager);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.btnZoeken);
            this.Controls.Add(this.lblAanvraagId);
            this.Controls.Add(this.txtAanvraagId);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmSaldoOverzetten";
            this.Text = "Saldo Overzetten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSaldoOverzetten_FormClosing);
            this.Load += new System.EventHandler(this.frmSaldoOverzetten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAanvraagId;
        private System.Windows.Forms.Label lblAanvraagId;
        private System.Windows.Forms.Button btnZoeken;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.TextBox txtAanvrager;
        private System.Windows.Forms.Label lblAanvrager;
        private System.Windows.Forms.Label lblGoedgekeurdBedrag;
        private System.Windows.Forms.TextBox txtGoedgekeurdBedrag;
        private System.Windows.Forms.Label lblStatusAanvraag;
        private System.Windows.Forms.TextBox txtStatusAanvraag;
        private System.Windows.Forms.Button btnSaldoOverzetten;
    }
}