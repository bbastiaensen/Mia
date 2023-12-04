namespace MiaClient
{
    partial class frmAanvraagFormulier
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
            this.gboxInvestering = new System.Windows.Forms.GroupBox();
            this.gboxTitel = new System.Windows.Forms.GroupBox();
            this.ddlPrioriteit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.gboxIdentificatie = new System.Windows.Forms.GroupBox();
            this.ddlDienst = new System.Windows.Forms.ComboBox();
            this.ddlAfdeling = new System.Windows.Forms.ComboBox();
            this.txtAanvraagmoment = new System.Windows.Forms.TextBox();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.lblDienst = new System.Windows.Forms.Label();
            this.lblAfdeling = new System.Windows.Forms.Label();
            this.lblAanvraagmoment = new System.Windows.Forms.Label();
            this.lblGebruikersNaam = new System.Windows.Forms.Label();
            this.txtAanvraagId = new System.Windows.Forms.TextBox();
            this.lblAanvraagId = new System.Windows.Forms.Label();
            this.lblAanvraagformulier = new System.Windows.Forms.Label();
            this.gboxInvestering.SuspendLayout();
            this.gboxTitel.SuspendLayout();
            this.gboxIdentificatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxInvestering
            // 
            this.gboxInvestering.Controls.Add(this.gboxTitel);
            this.gboxInvestering.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboxInvestering.Location = new System.Drawing.Point(20, 300);
            this.gboxInvestering.Name = "gboxInvestering";
            this.gboxInvestering.Size = new System.Drawing.Size(778, 592);
            this.gboxInvestering.TabIndex = 14;
            this.gboxInvestering.TabStop = false;
            this.gboxInvestering.Text = "Investering";
            // 
            // gboxTitel
            // 
            this.gboxTitel.Controls.Add(this.ddlPrioriteit);
            this.gboxTitel.Controls.Add(this.label1);
            this.gboxTitel.Controls.Add(this.ddlInvestering);
            this.gboxTitel.Controls.Add(this.ddlFinanciering);
            this.gboxTitel.Controls.Add(this.lblInvestering);
            this.gboxTitel.Controls.Add(this.lblFinaciering);
            this.gboxTitel.Controls.Add(this.txtTotaal);
            this.gboxTitel.Controls.Add(this.lblTotaal);
            this.gboxTitel.Controls.Add(this.txtAantalStuks);
            this.gboxTitel.Controls.Add(this.lblAantalStuks);
            this.gboxTitel.Controls.Add(this.txtPrijsindicatie);
            this.gboxTitel.Controls.Add(this.lblPrijsindicatie);
            this.gboxTitel.Controls.Add(this.rtxtOmschrijving);
            this.gboxTitel.Controls.Add(this.lblOmschrijving);
            this.gboxTitel.Controls.Add(this.txtTitel);
            this.gboxTitel.Controls.Add(this.lblTitel);
            this.gboxTitel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboxTitel.Location = new System.Drawing.Point(20, 30);
            this.gboxTitel.Name = "gboxTitel";
            this.gboxTitel.Size = new System.Drawing.Size(742, 525);
            this.gboxTitel.TabIndex = 0;
            this.gboxTitel.TabStop = false;
            this.gboxTitel.Text = "Item";
            // 
            // ddlPrioriteit
            // 
            this.ddlPrioriteit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPrioriteit.FormattingEnabled = true;
            this.ddlPrioriteit.Location = new System.Drawing.Point(150, 195);
            this.ddlPrioriteit.Name = "ddlPrioriteit";
            this.ddlPrioriteit.Size = new System.Drawing.Size(282, 29);
            this.ddlPrioriteit.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(30, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Pioriteit";
            // 
            // ddlInvestering
            // 
            this.ddlInvestering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlInvestering.FormattingEnabled = true;
            this.ddlInvestering.Location = new System.Drawing.Point(150, 385);
            this.ddlInvestering.Name = "ddlInvestering";
            this.ddlInvestering.Size = new System.Drawing.Size(282, 29);
            this.ddlInvestering.TabIndex = 17;
            // 
            // ddlFinanciering
            // 
            this.ddlFinanciering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFinanciering.FormattingEnabled = true;
            this.ddlFinanciering.Location = new System.Drawing.Point(150, 338);
            this.ddlFinanciering.Name = "ddlFinanciering";
            this.ddlFinanciering.Size = new System.Drawing.Size(282, 29);
            this.ddlFinanciering.TabIndex = 16;
            // 
            // lblInvestering
            // 
            this.lblInvestering.AutoSize = true;
            this.lblInvestering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInvestering.Location = new System.Drawing.Point(30, 388);
            this.lblInvestering.Name = "lblInvestering";
            this.lblInvestering.Size = new System.Drawing.Size(87, 21);
            this.lblInvestering.TabIndex = 15;
            this.lblInvestering.Text = "Investering";
            // 
            // lblFinaciering
            // 
            this.lblFinaciering.AutoSize = true;
            this.lblFinaciering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinaciering.Location = new System.Drawing.Point(30, 338);
            this.lblFinaciering.Name = "lblFinaciering";
            this.lblFinaciering.Size = new System.Drawing.Size(95, 21);
            this.lblFinaciering.TabIndex = 14;
            this.lblFinaciering.Text = "Financiering";
            // 
            // txtTotaal
            // 
            this.txtTotaal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotaal.Location = new System.Drawing.Point(137, 290);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.ReadOnly = true;
            this.txtTotaal.Size = new System.Drawing.Size(151, 29);
            this.txtTotaal.TabIndex = 13;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotaal.Location = new System.Drawing.Point(30, 290);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(80, 21);
            this.lblTotaal.TabIndex = 12;
            this.lblTotaal.Text = "Totaalprijs";
            // 
            // txtAantalStuks
            // 
            this.txtAantalStuks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAantalStuks.Location = new System.Drawing.Point(543, 248);
            this.txtAantalStuks.Name = "txtAantalStuks";
            this.txtAantalStuks.Size = new System.Drawing.Size(172, 22);
            this.txtAantalStuks.TabIndex = 11;
            // 
            // lblAantalStuks
            // 
            this.lblAantalStuks.AutoSize = true;
            this.lblAantalStuks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAantalStuks.Location = new System.Drawing.Point(420, 247);
            this.lblAantalStuks.Name = "lblAantalStuks";
            this.lblAantalStuks.Size = new System.Drawing.Size(94, 21);
            this.lblAantalStuks.TabIndex = 10;
            this.lblAantalStuks.Text = "Aantal stuks";
            // 
            // txtPrijsindicatie
            // 
            this.txtPrijsindicatie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrijsindicatie.Location = new System.Drawing.Point(233, 248);
            this.txtPrijsindicatie.Name = "txtPrijsindicatie";
            this.txtPrijsindicatie.Size = new System.Drawing.Size(151, 22);
            this.txtPrijsindicatie.TabIndex = 9;
            // 
            // lblPrijsindicatie
            // 
            this.lblPrijsindicatie.AutoSize = true;
            this.lblPrijsindicatie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrijsindicatie.Location = new System.Drawing.Point(30, 244);
            this.lblPrijsindicatie.Name = "lblPrijsindicatie";
            this.lblPrijsindicatie.Size = new System.Drawing.Size(158, 21);
            this.lblPrijsindicatie.TabIndex = 8;
            this.lblPrijsindicatie.Text = "Prijsindicatie per stuk";
            // 
            // rtxtOmschrijving
            // 
            this.rtxtOmschrijving.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtOmschrijving.Location = new System.Drawing.Point(170, 80);
            this.rtxtOmschrijving.Name = "rtxtOmschrijving";
            this.rtxtOmschrijving.Size = new System.Drawing.Size(545, 100);
            this.rtxtOmschrijving.TabIndex = 7;
            this.rtxtOmschrijving.Text = "";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOmschrijving.Location = new System.Drawing.Point(30, 80);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(103, 21);
            this.lblOmschrijving.TabIndex = 6;
            this.lblOmschrijving.Text = "Omschrijving";
            // 
            // txtTitel
            // 
            this.txtTitel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitel.Location = new System.Drawing.Point(100, 30);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(615, 22);
            this.txtTitel.TabIndex = 5;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitel.Location = new System.Drawing.Point(30, 30);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(39, 21);
            this.lblTitel.TabIndex = 4;
            this.lblTitel.Text = "Titel";
            // 
            // gboxIdentificatie
            // 
            this.gboxIdentificatie.Controls.Add(this.ddlDienst);
            this.gboxIdentificatie.Controls.Add(this.ddlAfdeling);
            this.gboxIdentificatie.Controls.Add(this.txtAanvraagmoment);
            this.gboxIdentificatie.Controls.Add(this.txtGebruiker);
            this.gboxIdentificatie.Controls.Add(this.lblDienst);
            this.gboxIdentificatie.Controls.Add(this.lblAfdeling);
            this.gboxIdentificatie.Controls.Add(this.lblAanvraagmoment);
            this.gboxIdentificatie.Controls.Add(this.lblGebruikersNaam);
            this.gboxIdentificatie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboxIdentificatie.Location = new System.Drawing.Point(20, 100);
            this.gboxIdentificatie.Name = "gboxIdentificatie";
            this.gboxIdentificatie.Size = new System.Drawing.Size(778, 190);
            this.gboxIdentificatie.TabIndex = 13;
            this.gboxIdentificatie.TabStop = false;
            this.gboxIdentificatie.Text = "Identificatie";
            // 
            // ddlDienst
            // 
            this.ddlDienst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDienst.FormattingEnabled = true;
            this.ddlDienst.Location = new System.Drawing.Point(122, 127);
            this.ddlDienst.Name = "ddlDienst";
            this.ddlDienst.Size = new System.Drawing.Size(282, 29);
            this.ddlDienst.TabIndex = 10;
            // 
            // ddlAfdeling
            // 
            this.ddlAfdeling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAfdeling.FormattingEnabled = true;
            this.ddlAfdeling.Location = new System.Drawing.Point(122, 80);
            this.ddlAfdeling.Name = "ddlAfdeling";
            this.ddlAfdeling.Size = new System.Drawing.Size(282, 29);
            this.ddlAfdeling.TabIndex = 9;
            // 
            // txtAanvraagmoment
            // 
            this.txtAanvraagmoment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAanvraagmoment.Location = new System.Drawing.Point(560, 30);
            this.txtAanvraagmoment.Name = "txtAanvraagmoment";
            this.txtAanvraagmoment.ReadOnly = true;
            this.txtAanvraagmoment.Size = new System.Drawing.Size(177, 29);
            this.txtAanvraagmoment.TabIndex = 8;
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGebruiker.Location = new System.Drawing.Point(190, 30);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.ReadOnly = true;
            this.txtGebruiker.Size = new System.Drawing.Size(247, 29);
            this.txtGebruiker.TabIndex = 7;
            // 
            // lblDienst
            // 
            this.lblDienst.AutoSize = true;
            this.lblDienst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDienst.Location = new System.Drawing.Point(30, 130);
            this.lblDienst.Name = "lblDienst";
            this.lblDienst.Size = new System.Drawing.Size(54, 21);
            this.lblDienst.TabIndex = 6;
            this.lblDienst.Text = "Dienst";
            // 
            // lblAfdeling
            // 
            this.lblAfdeling.AutoSize = true;
            this.lblAfdeling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAfdeling.Location = new System.Drawing.Point(30, 80);
            this.lblAfdeling.Name = "lblAfdeling";
            this.lblAfdeling.Size = new System.Drawing.Size(68, 21);
            this.lblAfdeling.TabIndex = 5;
            this.lblAfdeling.Text = "Afdeling";
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.AutoSize = true;
            this.lblAanvraagmoment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAanvraagmoment.Location = new System.Drawing.Point(480, 30);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(57, 21);
            this.lblAanvraagmoment.TabIndex = 4;
            this.lblAanvraagmoment.Text = "Datum";
            // 
            // lblGebruikersNaam
            // 
            this.lblGebruikersNaam.AutoSize = true;
            this.lblGebruikersNaam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGebruikersNaam.Location = new System.Drawing.Point(30, 30);
            this.lblGebruikersNaam.Name = "lblGebruikersNaam";
            this.lblGebruikersNaam.Size = new System.Drawing.Size(125, 21);
            this.lblGebruikersNaam.TabIndex = 3;
            this.lblGebruikersNaam.Text = "Gebruikersnaam";
            // 
            // txtAanvraagId
            // 
            this.txtAanvraagId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAanvraagId.Location = new System.Drawing.Point(189, 55);
            this.txtAanvraagId.Name = "txtAanvraagId";
            this.txtAanvraagId.ReadOnly = true;
            this.txtAanvraagId.Size = new System.Drawing.Size(71, 22);
            this.txtAanvraagId.TabIndex = 12;
            // 
            // lblAanvraagId
            // 
            this.lblAanvraagId.AutoSize = true;
            this.lblAanvraagId.Location = new System.Drawing.Point(15, 58);
            this.lblAanvraagId.Name = "lblAanvraagId";
            this.lblAanvraagId.Size = new System.Drawing.Size(136, 21);
            this.lblAanvraagId.TabIndex = 11;
            this.lblAanvraagId.Text = "Aanvraagnummer";
            // 
            // lblAanvraagformulier
            // 
            this.lblAanvraagformulier.AutoSize = true;
            this.lblAanvraagformulier.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAanvraagformulier.Location = new System.Drawing.Point(12, 9);
            this.lblAanvraagformulier.Name = "lblAanvraagformulier";
            this.lblAanvraagformulier.Size = new System.Drawing.Size(261, 37);
            this.lblAanvraagformulier.TabIndex = 10;
            this.lblAanvraagformulier.Text = "Aanvraagformulier";
            // 
            // frmAanvraagFormulier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(812, 1055);
            this.Controls.Add(this.gboxInvestering);
            this.Controls.Add(this.gboxIdentificatie);
            this.Controls.Add(this.txtAanvraagId);
            this.Controls.Add(this.lblAanvraagId);
            this.Controls.Add(this.lblAanvraagformulier);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAanvraagFormulier";
            this.Text = "frmAanvraagFormulier";
            this.gboxInvestering.ResumeLayout(false);
            this.gboxTitel.ResumeLayout(false);
            this.gboxTitel.PerformLayout();
            this.gboxIdentificatie.ResumeLayout(false);
            this.gboxIdentificatie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxInvestering;
        private System.Windows.Forms.GroupBox gboxTitel;
        private System.Windows.Forms.ComboBox ddlPrioriteit;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.GroupBox gboxIdentificatie;
        private System.Windows.Forms.ComboBox ddlDienst;
        private System.Windows.Forms.ComboBox ddlAfdeling;
        private System.Windows.Forms.TextBox txtAanvraagmoment;
        private System.Windows.Forms.TextBox txtGebruiker;
        private System.Windows.Forms.Label lblDienst;
        private System.Windows.Forms.Label lblAfdeling;
        private System.Windows.Forms.Label lblAanvraagmoment;
        private System.Windows.Forms.Label lblGebruikersNaam;
        private System.Windows.Forms.TextBox txtAanvraagId;
        private System.Windows.Forms.Label lblAanvraagId;
        private System.Windows.Forms.Label lblAanvraagformulier;
    }
}