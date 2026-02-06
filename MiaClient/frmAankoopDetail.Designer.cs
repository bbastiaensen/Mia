namespace MiaClient
{
    partial class frmAankoopDetail
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
            this.ddlPrioriteit = new System.Windows.Forms.ComboBox();
            this.lblPrioriteit = new System.Windows.Forms.Label();
            this.ddlInvestering = new System.Windows.Forms.ComboBox();
            this.ddlFinanciering = new System.Windows.Forms.ComboBox();
            this.lblInvestering = new System.Windows.Forms.Label();
            this.lblFinaciering = new System.Windows.Forms.Label();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.txtAantalStuks = new System.Windows.Forms.TextBox();
            this.lblAantalStuks = new System.Windows.Forms.Label();
            this.txtPrijsindicatie = new System.Windows.Forms.TextBox();
            this.lblPrijsindicatie = new System.Windows.Forms.Label();
            this.rtxtOmschrijving = new System.Windows.Forms.RichTextBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtAanvraagId = new System.Windows.Forms.TextBox();
            this.lblAanvraagId = new System.Windows.Forms.Label();
            this.lblAankoopDetail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlPrioriteit
            // 
            this.ddlPrioriteit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPrioriteit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlPrioriteit.FormattingEnabled = true;
            this.ddlPrioriteit.Location = new System.Drawing.Point(196, 274);
            this.ddlPrioriteit.Name = "ddlPrioriteit";
            this.ddlPrioriteit.Size = new System.Drawing.Size(282, 33);
            this.ddlPrioriteit.TabIndex = 21;
            // 
            // lblPrioriteit
            // 
            this.lblPrioriteit.AutoSize = true;
            this.lblPrioriteit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioriteit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrioriteit.Location = new System.Drawing.Point(54, 277);
            this.lblPrioriteit.Name = "lblPrioriteit";
            this.lblPrioriteit.Size = new System.Drawing.Size(76, 25);
            this.lblPrioriteit.TabIndex = 34;
            this.lblPrioriteit.Text = "Pioriteit:";
            // 
            // ddlInvestering
            // 
            this.ddlInvestering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlInvestering.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlInvestering.FormattingEnabled = true;
            this.ddlInvestering.Location = new System.Drawing.Point(196, 449);
            this.ddlInvestering.Name = "ddlInvestering";
            this.ddlInvestering.Size = new System.Drawing.Size(282, 33);
            this.ddlInvestering.TabIndex = 28;
            // 
            // ddlFinanciering
            // 
            this.ddlFinanciering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFinanciering.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFinanciering.FormattingEnabled = true;
            this.ddlFinanciering.Location = new System.Drawing.Point(196, 414);
            this.ddlFinanciering.Name = "ddlFinanciering";
            this.ddlFinanciering.Size = new System.Drawing.Size(282, 33);
            this.ddlFinanciering.TabIndex = 26;
            // 
            // lblInvestering
            // 
            this.lblInvestering.AutoSize = true;
            this.lblInvestering.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInvestering.Location = new System.Drawing.Point(54, 452);
            this.lblInvestering.Name = "lblInvestering";
            this.lblInvestering.Size = new System.Drawing.Size(103, 25);
            this.lblInvestering.TabIndex = 33;
            this.lblInvestering.Text = "Investering:";
            // 
            // lblFinaciering
            // 
            this.lblFinaciering.AutoSize = true;
            this.lblFinaciering.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinaciering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinaciering.Location = new System.Drawing.Point(54, 417);
            this.lblFinaciering.Name = "lblFinaciering";
            this.lblFinaciering.Size = new System.Drawing.Size(110, 25);
            this.lblFinaciering.TabIndex = 32;
            this.lblFinaciering.Text = "Financiering:";
            // 
            // txtTotaal
            // 
            this.txtTotaal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotaal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotaal.Location = new System.Drawing.Point(196, 379);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.ReadOnly = true;
            this.txtTotaal.Size = new System.Drawing.Size(282, 31);
            this.txtTotaal.TabIndex = 25;
            this.txtTotaal.Text = "0";
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotaal.Location = new System.Drawing.Point(54, 381);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(95, 25);
            this.lblTotaal.TabIndex = 31;
            this.lblTotaal.Text = "Totaalprijs:";
            // 
            // txtAantalStuks
            // 
            this.txtAantalStuks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAantalStuks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAantalStuks.Location = new System.Drawing.Point(196, 344);
            this.txtAantalStuks.MaxLength = 3;
            this.txtAantalStuks.Name = "txtAantalStuks";
            this.txtAantalStuks.Size = new System.Drawing.Size(282, 31);
            this.txtAantalStuks.TabIndex = 23;
            // 
            // lblAantalStuks
            // 
            this.lblAantalStuks.AutoSize = true;
            this.lblAantalStuks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantalStuks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAantalStuks.Location = new System.Drawing.Point(54, 346);
            this.lblAantalStuks.Name = "lblAantalStuks";
            this.lblAantalStuks.Size = new System.Drawing.Size(112, 25);
            this.lblAantalStuks.TabIndex = 30;
            this.lblAantalStuks.Text = "Aantal stuks:";
            // 
            // txtPrijsindicatie
            // 
            this.txtPrijsindicatie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrijsindicatie.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrijsindicatie.Location = new System.Drawing.Point(196, 309);
            this.txtPrijsindicatie.MaxLength = 999;
            this.txtPrijsindicatie.Name = "txtPrijsindicatie";
            this.txtPrijsindicatie.Size = new System.Drawing.Size(282, 31);
            this.txtPrijsindicatie.TabIndex = 22;
            // 
            // lblPrijsindicatie
            // 
            this.lblPrijsindicatie.AutoSize = true;
            this.lblPrijsindicatie.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrijsindicatie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrijsindicatie.Location = new System.Drawing.Point(54, 311);
            this.lblPrijsindicatie.Name = "lblPrijsindicatie";
            this.lblPrijsindicatie.Size = new System.Drawing.Size(153, 25);
            this.lblPrijsindicatie.TabIndex = 29;
            this.lblPrijsindicatie.Text = "Prijsindicatie/stuk:";
            // 
            // rtxtOmschrijving
            // 
            this.rtxtOmschrijving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtOmschrijving.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOmschrijving.Location = new System.Drawing.Point(196, 159);
            this.rtxtOmschrijving.Name = "rtxtOmschrijving";
            this.rtxtOmschrijving.Size = new System.Drawing.Size(533, 109);
            this.rtxtOmschrijving.TabIndex = 20;
            this.rtxtOmschrijving.Text = "";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmschrijving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOmschrijving.Location = new System.Drawing.Point(54, 161);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(120, 25);
            this.lblOmschrijving.TabIndex = 27;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // txtTitel
            // 
            this.txtTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitel.Location = new System.Drawing.Point(196, 124);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(533, 31);
            this.txtTitel.TabIndex = 19;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitel.Location = new System.Drawing.Point(50, 126);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(48, 25);
            this.lblTitel.TabIndex = 24;
            this.lblTitel.Text = "Titel:";
            // 
            // txtAanvraagId
            // 
            this.txtAanvraagId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAanvraagId.Location = new System.Drawing.Point(189, 55);
            this.txtAanvraagId.Name = "txtAanvraagId";
            this.txtAanvraagId.ReadOnly = true;
            this.txtAanvraagId.Size = new System.Drawing.Size(71, 22);
            this.txtAanvraagId.TabIndex = 37;
            // 
            // lblAanvraagId
            // 
            this.lblAanvraagId.AutoSize = true;
            this.lblAanvraagId.Location = new System.Drawing.Point(15, 58);
            this.lblAanvraagId.Name = "lblAanvraagId";
            this.lblAanvraagId.Size = new System.Drawing.Size(114, 16);
            this.lblAanvraagId.TabIndex = 36;
            this.lblAanvraagId.Text = "Aanvraagnummer";
            // 
            // lblAankoopDetail
            // 
            this.lblAankoopDetail.AutoSize = true;
            this.lblAankoopDetail.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAankoopDetail.Location = new System.Drawing.Point(15, 10);
            this.lblAankoopDetail.Name = "lblAankoopDetail";
            this.lblAankoopDetail.Size = new System.Drawing.Size(268, 46);
            this.lblAankoopDetail.TabIndex = 35;
            this.lblAankoopDetail.Text = "Aankoop Detail";
            this.lblAankoopDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAankoopDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 686);
            this.Controls.Add(this.txtAanvraagId);
            this.Controls.Add(this.lblAanvraagId);
            this.Controls.Add(this.lblAankoopDetail);
            this.Controls.Add(this.ddlPrioriteit);
            this.Controls.Add(this.lblPrioriteit);
            this.Controls.Add(this.ddlInvestering);
            this.Controls.Add(this.ddlFinanciering);
            this.Controls.Add(this.lblInvestering);
            this.Controls.Add(this.lblFinaciering);
            this.Controls.Add(this.txtTotaal);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.txtAantalStuks);
            this.Controls.Add(this.lblAantalStuks);
            this.Controls.Add(this.txtPrijsindicatie);
            this.Controls.Add(this.lblPrijsindicatie);
            this.Controls.Add(this.rtxtOmschrijving);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.lblTitel);
            this.Name = "frmAankoopDetail";
            this.Text = "frmAankoopDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlPrioriteit;
        private System.Windows.Forms.Label lblPrioriteit;
        private System.Windows.Forms.ComboBox ddlInvestering;
        private System.Windows.Forms.ComboBox ddlFinanciering;
        private System.Windows.Forms.Label lblInvestering;
        private System.Windows.Forms.Label lblFinaciering;
        private System.Windows.Forms.TextBox txtTotaal;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.TextBox txtAantalStuks;
        private System.Windows.Forms.Label lblAantalStuks;
        private System.Windows.Forms.TextBox txtPrijsindicatie;
        private System.Windows.Forms.Label lblPrijsindicatie;
        private System.Windows.Forms.RichTextBox rtxtOmschrijving;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtAanvraagId;
        private System.Windows.Forms.Label lblAanvraagId;
        private System.Windows.Forms.Label lblAankoopDetail;
    }
}