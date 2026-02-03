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
            this.lblAankoopDetail = new System.Windows.Forms.Label();
            this.lblAankoopId = new System.Windows.Forms.Label();
            this.txtAanvraagId = new System.Windows.Forms.TextBox();
            this.btn_Verwijderen = new System.Windows.Forms.Button();
            this.btn_Bewaren = new System.Windows.Forms.Button();
            this.rtxtOmschrijving = new System.Windows.Forms.RichTextBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.lblGoedgekeurdeBedrag = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtGoedgekeurdeBedrag = new System.Windows.Forms.TextBox();
            this.lblBedragExBtw = new System.Windows.Forms.Label();
            this.txtBedragExBtw = new System.Windows.Forms.TextBox();
            this.lblBTWPercentage = new System.Windows.Forms.Label();
            this.txtBTWPercentage = new System.Windows.Forms.TextBox();
            this.lblBedragInBTW = new System.Windows.Forms.Label();
            this.txtBedragInBTW = new System.Windows.Forms.TextBox();
            this.lblBedragTransfer = new System.Windows.Forms.Label();
            this.txtBedragTransfer = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoTekst = new System.Windows.Forms.Label();
            this.dtpBestelDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpVerwachteDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpEffectieveDatum = new System.Windows.Forms.DateTimePicker();
            this.lblBestelDatum = new System.Windows.Forms.Label();
            this.lblVerwachteDatum = new System.Windows.Forms.Label();
            this.lblEffectieveDatum = new System.Windows.Forms.Label();
            this.ddlLeverancier = new System.Windows.Forms.ComboBox();
            this.lblLeveranciers = new System.Windows.Forms.Label();
            this.txtBestelBonNummer = new System.Windows.Forms.TextBox();
            this.lblBestelbonnummer = new System.Windows.Forms.Label();
            this.ckbFactuur = new System.Windows.Forms.CheckBox();
            this.txtFactuurnummer = new System.Windows.Forms.TextBox();
            this.txtInternNummer = new System.Windows.Forms.TextBox();
            this.lblInternnummer = new System.Windows.Forms.Label();
            this.lblFactuurNummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAankoopDetail
            // 
            this.lblAankoopDetail.AutoSize = true;
            this.lblAankoopDetail.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAankoopDetail.Location = new System.Drawing.Point(5, 5);
            this.lblAankoopDetail.Name = "lblAankoopDetail";
            this.lblAankoopDetail.Size = new System.Drawing.Size(274, 45);
            this.lblAankoopDetail.TabIndex = 11;
            this.lblAankoopDetail.Text = "Aankoop Details";
            // 
            // lblAankoopId
            // 
            this.lblAankoopId.AutoSize = true;
            this.lblAankoopId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAankoopId.Location = new System.Drawing.Point(20, 60);
            this.lblAankoopId.Name = "lblAankoopId";
            this.lblAankoopId.Size = new System.Drawing.Size(169, 28);
            this.lblAankoopId.TabIndex = 12;
            this.lblAankoopId.Text = "Aankoopnummer:";
            // 
            // txtAanvraagId
            // 
            this.txtAanvraagId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAanvraagId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAanvraagId.Location = new System.Drawing.Point(250, 60);
            this.txtAanvraagId.Name = "txtAanvraagId";
            this.txtAanvraagId.ReadOnly = true;
            this.txtAanvraagId.Size = new System.Drawing.Size(71, 34);
            this.txtAanvraagId.TabIndex = 13;
            // 
            // btn_Verwijderen
            // 
            this.btn_Verwijderen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Verwijderen.Location = new System.Drawing.Point(1155, 60);
            this.btn_Verwijderen.Name = "btn_Verwijderen";
            this.btn_Verwijderen.Size = new System.Drawing.Size(150, 40);
            this.btn_Verwijderen.TabIndex = 17;
            this.btn_Verwijderen.Text = "Verwijder";
            this.btn_Verwijderen.UseVisualStyleBackColor = true;
            this.btn_Verwijderen.Click += new System.EventHandler(this.btn_Verwijderen_Click);
            // 
            // btn_Bewaren
            // 
            this.btn_Bewaren.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Bewaren.Location = new System.Drawing.Point(1000, 60);
            this.btn_Bewaren.Name = "btn_Bewaren";
            this.btn_Bewaren.Size = new System.Drawing.Size(150, 40);
            this.btn_Bewaren.TabIndex = 18;
            this.btn_Bewaren.Text = "Bewaar";
            this.btn_Bewaren.UseVisualStyleBackColor = true;
            this.btn_Bewaren.Click += new System.EventHandler(this.btn_Bewaren_Click);
            // 
            // rtxtOmschrijving
            // 
            this.rtxtOmschrijving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtOmschrijving.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rtxtOmschrijving.Location = new System.Drawing.Point(250, 115);
            this.rtxtOmschrijving.Name = "rtxtOmschrijving";
            this.rtxtOmschrijving.Size = new System.Drawing.Size(533, 109);
            this.rtxtOmschrijving.TabIndex = 36;
            this.rtxtOmschrijving.Text = "";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOmschrijving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOmschrijving.Location = new System.Drawing.Point(20, 115);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(127, 25);
            this.lblOmschrijving.TabIndex = 43;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.Enabled = false;
            this.ddlStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "In aanvraag",
            "Goedgekeurd",
            "Niet Goedgekeurd",
            "Bekrachtigd",
            "Niet Bekrachtigd",
            ""});
            this.ddlStatus.Location = new System.Drawing.Point(250, 250);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(250, 33);
            this.ddlStatus.TabIndex = 62;
            // 
            // lblGoedgekeurdeBedrag
            // 
            this.lblGoedgekeurdeBedrag.AutoSize = true;
            this.lblGoedgekeurdeBedrag.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblGoedgekeurdeBedrag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGoedgekeurdeBedrag.Location = new System.Drawing.Point(20, 300);
            this.lblGoedgekeurdeBedrag.Name = "lblGoedgekeurdeBedrag";
            this.lblGoedgekeurdeBedrag.Size = new System.Drawing.Size(210, 25);
            this.lblGoedgekeurdeBedrag.TabIndex = 63;
            this.lblGoedgekeurdeBedrag.Text = "Goedgekeurde Bedrag: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(20, 250);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 25);
            this.lblStatus.TabIndex = 59;
            this.lblStatus.Text = "Status:";
            // 
            // txtGoedgekeurdeBedrag
            // 
            this.txtGoedgekeurdeBedrag.AccessibleName = "txtGoedgekeurdeBedrag";
            this.txtGoedgekeurdeBedrag.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGoedgekeurdeBedrag.Location = new System.Drawing.Point(250, 300);
            this.txtGoedgekeurdeBedrag.Name = "txtGoedgekeurdeBedrag";
            this.txtGoedgekeurdeBedrag.ReadOnly = true;
            this.txtGoedgekeurdeBedrag.Size = new System.Drawing.Size(250, 32);
            this.txtGoedgekeurdeBedrag.TabIndex = 58;
            // 
            // lblBedragExBtw
            // 
            this.lblBedragExBtw.AutoSize = true;
            this.lblBedragExBtw.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBedragExBtw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBedragExBtw.Location = new System.Drawing.Point(20, 350);
            this.lblBedragExBtw.Name = "lblBedragExBtw";
            this.lblBedragExBtw.Size = new System.Drawing.Size(143, 25);
            this.lblBedragExBtw.TabIndex = 66;
            this.lblBedragExBtw.Text = "Bedrag Ex BTW:";
            // 
            // txtBedragExBtw
            // 
            this.txtBedragExBtw.AccessibleName = "";
            this.txtBedragExBtw.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBedragExBtw.Location = new System.Drawing.Point(250, 350);
            this.txtBedragExBtw.Name = "txtBedragExBtw";
            this.txtBedragExBtw.Size = new System.Drawing.Size(250, 32);
            this.txtBedragExBtw.TabIndex = 65;
            // 
            // lblBTWPercentage
            // 
            this.lblBTWPercentage.AutoSize = true;
            this.lblBTWPercentage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBTWPercentage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBTWPercentage.Location = new System.Drawing.Point(20, 400);
            this.lblBTWPercentage.Name = "lblBTWPercentage";
            this.lblBTWPercentage.Size = new System.Drawing.Size(153, 25);
            this.lblBTWPercentage.TabIndex = 68;
            this.lblBTWPercentage.Text = "BTW Percentage:";
            // 
            // txtBTWPercentage
            // 
            this.txtBTWPercentage.AccessibleName = "";
            this.txtBTWPercentage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBTWPercentage.Location = new System.Drawing.Point(250, 400);
            this.txtBTWPercentage.Name = "txtBTWPercentage";
            this.txtBTWPercentage.Size = new System.Drawing.Size(250, 32);
            this.txtBTWPercentage.TabIndex = 67;
            // 
            // lblBedragInBTW
            // 
            this.lblBedragInBTW.AutoSize = true;
            this.lblBedragInBTW.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBedragInBTW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBedragInBTW.Location = new System.Drawing.Point(20, 450);
            this.lblBedragInBTW.Name = "lblBedragInBTW";
            this.lblBedragInBTW.Size = new System.Drawing.Size(140, 25);
            this.lblBedragInBTW.TabIndex = 70;
            this.lblBedragInBTW.Text = "Bedrag In BTW:";
            // 
            // txtBedragInBTW
            // 
            this.txtBedragInBTW.AccessibleName = "";
            this.txtBedragInBTW.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBedragInBTW.Location = new System.Drawing.Point(250, 450);
            this.txtBedragInBTW.Name = "txtBedragInBTW";
            this.txtBedragInBTW.ReadOnly = true;
            this.txtBedragInBTW.Size = new System.Drawing.Size(250, 32);
            this.txtBedragInBTW.TabIndex = 69;
            // 
            // lblBedragTransfer
            // 
            this.lblBedragTransfer.AutoSize = true;
            this.lblBedragTransfer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBedragTransfer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBedragTransfer.Location = new System.Drawing.Point(20, 500);
            this.lblBedragTransfer.Name = "lblBedragTransfer";
            this.lblBedragTransfer.Size = new System.Drawing.Size(146, 25);
            this.lblBedragTransfer.TabIndex = 72;
            this.lblBedragTransfer.Text = "Bedrag transfer:";
            // 
            // txtBedragTransfer
            // 
            this.txtBedragTransfer.AccessibleName = "";
            this.txtBedragTransfer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBedragTransfer.Location = new System.Drawing.Point(250, 500);
            this.txtBedragTransfer.Name = "txtBedragTransfer";
            this.txtBedragTransfer.ReadOnly = true;
            this.txtBedragTransfer.Size = new System.Drawing.Size(250, 32);
            this.txtBedragTransfer.TabIndex = 71;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSaldo.Location = new System.Drawing.Point(250, 550);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 25);
            this.lblSaldo.TabIndex = 73;
            // 
            // lblSaldoTekst
            // 
            this.lblSaldoTekst.AutoSize = true;
            this.lblSaldoTekst.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSaldoTekst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSaldoTekst.Location = new System.Drawing.Point(20, 550);
            this.lblSaldoTekst.Name = "lblSaldoTekst";
            this.lblSaldoTekst.Size = new System.Drawing.Size(63, 25);
            this.lblSaldoTekst.TabIndex = 74;
            this.lblSaldoTekst.Text = "Saldo:";
            // 
            // dtpBestelDatum
            // 
            this.dtpBestelDatum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpBestelDatum.Location = new System.Drawing.Point(1000, 115);
            this.dtpBestelDatum.Name = "dtpBestelDatum";
            this.dtpBestelDatum.Size = new System.Drawing.Size(305, 32);
            this.dtpBestelDatum.TabIndex = 75;
            // 
            // dtpVerwachteDatum
            // 
            this.dtpVerwachteDatum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpVerwachteDatum.Location = new System.Drawing.Point(1000, 165);
            this.dtpVerwachteDatum.Name = "dtpVerwachteDatum";
            this.dtpVerwachteDatum.Size = new System.Drawing.Size(305, 32);
            this.dtpVerwachteDatum.TabIndex = 76;
            // 
            // dtpEffectieveDatum
            // 
            this.dtpEffectieveDatum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpEffectieveDatum.Location = new System.Drawing.Point(1000, 215);
            this.dtpEffectieveDatum.Name = "dtpEffectieveDatum";
            this.dtpEffectieveDatum.Size = new System.Drawing.Size(305, 32);
            this.dtpEffectieveDatum.TabIndex = 77;
            // 
            // lblBestelDatum
            // 
            this.lblBestelDatum.AutoSize = true;
            this.lblBestelDatum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBestelDatum.Location = new System.Drawing.Point(800, 115);
            this.lblBestelDatum.Name = "lblBestelDatum";
            this.lblBestelDatum.Size = new System.Drawing.Size(125, 25);
            this.lblBestelDatum.TabIndex = 78;
            this.lblBestelDatum.Text = "Bestel datum:";
            // 
            // lblVerwachteDatum
            // 
            this.lblVerwachteDatum.AutoSize = true;
            this.lblVerwachteDatum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblVerwachteDatum.Location = new System.Drawing.Point(800, 165);
            this.lblVerwachteDatum.Name = "lblVerwachteDatum";
            this.lblVerwachteDatum.Size = new System.Drawing.Size(163, 25);
            this.lblVerwachteDatum.TabIndex = 79;
            this.lblVerwachteDatum.Text = "Verwachte datum:";
            // 
            // lblEffectieveDatum
            // 
            this.lblEffectieveDatum.AutoSize = true;
            this.lblEffectieveDatum.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEffectieveDatum.Location = new System.Drawing.Point(800, 215);
            this.lblEffectieveDatum.Name = "lblEffectieveDatum";
            this.lblEffectieveDatum.Size = new System.Drawing.Size(156, 25);
            this.lblEffectieveDatum.TabIndex = 80;
            this.lblEffectieveDatum.Text = "Effectieve datum:";
            // 
            // ddlLeverancier
            // 
            this.ddlLeverancier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLeverancier.Enabled = false;
            this.ddlLeverancier.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ddlLeverancier.FormattingEnabled = true;
            this.ddlLeverancier.Items.AddRange(new object[] {
            "In aanvraag",
            "Goedgekeurd",
            "Niet Goedgekeurd",
            "Bekrachtigd",
            "Niet Bekrachtigd",
            ""});
            this.ddlLeverancier.Location = new System.Drawing.Point(1000, 300);
            this.ddlLeverancier.Name = "ddlLeverancier";
            this.ddlLeverancier.Size = new System.Drawing.Size(300, 33);
            this.ddlLeverancier.TabIndex = 81;
            // 
            // lblLeveranciers
            // 
            this.lblLeveranciers.AutoSize = true;
            this.lblLeveranciers.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblLeveranciers.Location = new System.Drawing.Point(800, 300);
            this.lblLeveranciers.Name = "lblLeveranciers";
            this.lblLeveranciers.Size = new System.Drawing.Size(121, 25);
            this.lblLeveranciers.TabIndex = 82;
            this.lblLeveranciers.Text = "Leveranciers:";
            // 
            // txtBestelBonNummer
            // 
            this.txtBestelBonNummer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBestelBonNummer.Location = new System.Drawing.Point(1000, 350);
            this.txtBestelBonNummer.Name = "txtBestelBonNummer";
            this.txtBestelBonNummer.Size = new System.Drawing.Size(100, 32);
            this.txtBestelBonNummer.TabIndex = 83;
            // 
            // lblBestelbonnummer
            // 
            this.lblBestelbonnummer.AutoSize = true;
            this.lblBestelbonnummer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblBestelbonnummer.Location = new System.Drawing.Point(800, 350);
            this.lblBestelbonnummer.Name = "lblBestelbonnummer";
            this.lblBestelbonnummer.Size = new System.Drawing.Size(170, 25);
            this.lblBestelbonnummer.TabIndex = 84;
            this.lblBestelbonnummer.Text = "Bestelbonnummer:";
            // 
            // ckbFactuur
            // 
            this.ckbFactuur.AutoSize = true;
            this.ckbFactuur.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ckbFactuur.Location = new System.Drawing.Point(1000, 400);
            this.ckbFactuur.Name = "ckbFactuur";
            this.ckbFactuur.Size = new System.Drawing.Size(96, 29);
            this.ckbFactuur.TabIndex = 85;
            this.ckbFactuur.Text = "Factuur";
            this.ckbFactuur.UseVisualStyleBackColor = true;
            // 
            // txtFactuurnummer
            // 
            this.txtFactuurnummer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFactuurnummer.Location = new System.Drawing.Point(1000, 450);
            this.txtFactuurnummer.Name = "txtFactuurnummer";
            this.txtFactuurnummer.Size = new System.Drawing.Size(100, 32);
            this.txtFactuurnummer.TabIndex = 86;
            // 
            // txtInternNummer
            // 
            this.txtInternNummer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtInternNummer.Location = new System.Drawing.Point(1000, 500);
            this.txtInternNummer.Name = "txtInternNummer";
            this.txtInternNummer.Size = new System.Drawing.Size(100, 32);
            this.txtInternNummer.TabIndex = 87;
            // 
            // lblInternnummer
            // 
            this.lblInternnummer.AutoSize = true;
            this.lblInternnummer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInternnummer.Location = new System.Drawing.Point(800, 500);
            this.lblInternnummer.Name = "lblInternnummer";
            this.lblInternnummer.Size = new System.Drawing.Size(142, 25);
            this.lblInternnummer.TabIndex = 88;
            this.lblInternnummer.Text = "Intern nummer:";
            // 
            // lblFactuurNummer
            // 
            this.lblFactuurNummer.AutoSize = true;
            this.lblFactuurNummer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFactuurNummer.Location = new System.Drawing.Point(800, 450);
            this.lblFactuurNummer.Name = "lblFactuurNummer";
            this.lblFactuurNummer.Size = new System.Drawing.Size(154, 25);
            this.lblFactuurNummer.TabIndex = 89;
            this.lblFactuurNummer.Text = "Factuur nummer:";
            // 
            // frmAankoopDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 581);
            this.Controls.Add(this.lblFactuurNummer);
            this.Controls.Add(this.lblInternnummer);
            this.Controls.Add(this.txtInternNummer);
            this.Controls.Add(this.txtFactuurnummer);
            this.Controls.Add(this.ckbFactuur);
            this.Controls.Add(this.lblBestelbonnummer);
            this.Controls.Add(this.txtBestelBonNummer);
            this.Controls.Add(this.lblLeveranciers);
            this.Controls.Add(this.ddlLeverancier);
            this.Controls.Add(this.lblEffectieveDatum);
            this.Controls.Add(this.lblVerwachteDatum);
            this.Controls.Add(this.lblBestelDatum);
            this.Controls.Add(this.dtpEffectieveDatum);
            this.Controls.Add(this.dtpVerwachteDatum);
            this.Controls.Add(this.dtpBestelDatum);
            this.Controls.Add(this.lblSaldoTekst);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblBedragTransfer);
            this.Controls.Add(this.txtBedragTransfer);
            this.Controls.Add(this.lblBedragInBTW);
            this.Controls.Add(this.txtBedragInBTW);
            this.Controls.Add(this.lblBTWPercentage);
            this.Controls.Add(this.txtBTWPercentage);
            this.Controls.Add(this.lblBedragExBtw);
            this.Controls.Add(this.txtBedragExBtw);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.lblGoedgekeurdeBedrag);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtGoedgekeurdeBedrag);
            this.Controls.Add(this.rtxtOmschrijving);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.btn_Bewaren);
            this.Controls.Add(this.btn_Verwijderen);
            this.Controls.Add(this.txtAanvraagId);
            this.Controls.Add(this.lblAankoopId);
            this.Controls.Add(this.lblAankoopDetail);
            this.MaximizeBox = false;
            this.Name = "frmAankoopDetail";
            this.Text = "AankoopDetail";
            this.Load += new System.EventHandler(this.frmAankoopDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAankoopDetail;
        private System.Windows.Forms.Label lblAankoopId;
        private System.Windows.Forms.TextBox txtAanvraagId;
        private System.Windows.Forms.Button btn_Verwijderen;
        private System.Windows.Forms.Button btn_Bewaren;
        private System.Windows.Forms.RichTextBox rtxtOmschrijving;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Label lblGoedgekeurdeBedrag;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtGoedgekeurdeBedrag;
        private System.Windows.Forms.Label lblBedragExBtw;
        private System.Windows.Forms.TextBox txtBedragExBtw;
        private System.Windows.Forms.Label lblBTWPercentage;
        private System.Windows.Forms.TextBox txtBTWPercentage;
        private System.Windows.Forms.Label lblBedragInBTW;
        private System.Windows.Forms.TextBox txtBedragInBTW;
        private System.Windows.Forms.Label lblBedragTransfer;
        private System.Windows.Forms.TextBox txtBedragTransfer;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoTekst;
        private System.Windows.Forms.DateTimePicker dtpBestelDatum;
        private System.Windows.Forms.DateTimePicker dtpVerwachteDatum;
        private System.Windows.Forms.DateTimePicker dtpEffectieveDatum;
        private System.Windows.Forms.Label lblBestelDatum;
        private System.Windows.Forms.Label lblVerwachteDatum;
        private System.Windows.Forms.Label lblEffectieveDatum;
        private System.Windows.Forms.ComboBox ddlLeverancier;
        private System.Windows.Forms.Label lblLeveranciers;
        private System.Windows.Forms.TextBox txtBestelBonNummer;
        private System.Windows.Forms.Label lblBestelbonnummer;
        private System.Windows.Forms.CheckBox ckbFactuur;
        private System.Windows.Forms.TextBox txtFactuurnummer;
        private System.Windows.Forms.TextBox txtInternNummer;
        private System.Windows.Forms.Label lblInternnummer;
        private System.Windows.Forms.Label lblFactuurNummer;
    }
}