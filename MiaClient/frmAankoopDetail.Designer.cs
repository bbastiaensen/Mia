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
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblBedragIncBtw = new System.Windows.Forms.Label();
            this.txtBtwPercentage = new System.Windows.Forms.TextBox();
            this.lblBtwPer = new System.Windows.Forms.Label();
            this.txtExBtw = new System.Windows.Forms.TextBox();
            this.lblExBtw = new System.Windows.Forms.Label();
            this.txtGoedgekeurdBedrag = new System.Windows.Forms.TextBox();
            this.lblGbedrag = new System.Windows.Forms.Label();
            this.rtxtOmschrijving = new System.Windows.Forms.RichTextBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.txtAankoopId = new System.Windows.Forms.TextBox();
            this.lblAankoopId = new System.Windows.Forms.Label();
            this.lblAankoopDetail = new System.Windows.Forms.Label();
            this.dtpBestelDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpVerwachteDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpEffectieveDatum = new System.Windows.Forms.DateTimePicker();
            this.lblBestelDatum = new System.Windows.Forms.Label();
            this.lblVerwachteDatum = new System.Windows.Forms.Label();
            this.lblEffectieveDatum = new System.Windows.Forms.Label();
            this.ddlLeverancier = new System.Windows.Forms.ComboBox();
            this.lblLeveranciers = new System.Windows.Forms.Label();
            this.lblAanvraagId = new System.Windows.Forms.Label();
            this.txtAanvraagId = new System.Windows.Forms.TextBox();
            this.lblBestelbon = new System.Windows.Forms.Label();
            this.txtBestelbonNummer = new System.Windows.Forms.TextBox();
            this.txtFactuurnummer = new System.Windows.Forms.TextBox();
            this.txtInternNummer = new System.Windows.Forms.TextBox();
            this.lblFactuurNummer = new System.Windows.Forms.Label();
            this.lblInternnummer = new System.Windows.Forms.Label();
            this.chBFactuur = new System.Windows.Forms.CheckBox();
            this.txtIncBtw = new System.Windows.Forms.TextBox();
            this.lblBedragSaldo = new System.Windows.Forms.Label();
            this.btnBewaren = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnLeveranciers = new System.Windows.Forms.Button();
            this.lblTransferBedrag = new System.Windows.Forms.Label();
            this.txtBedragTransfer = new System.Windows.Forms.TextBox();
            this.btnEuro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Location = new System.Drawing.Point(188, 203);
            this.ddlStatus.Margin = new System.Windows.Forms.Padding(2);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(151, 27);
            this.ddlStatus.TabIndex = 21;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(15, 203);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(114, 20);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Aankoop status:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSaldo.Location = new System.Drawing.Point(15, 447);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(50, 20);
            this.lblSaldo.TabIndex = 33;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblBedragIncBtw
            // 
            this.lblBedragIncBtw.AutoSize = true;
            this.lblBedragIncBtw.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedragIncBtw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBedragIncBtw.Location = new System.Drawing.Point(15, 366);
            this.lblBedragIncBtw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBedragIncBtw.Name = "lblBedragIncBtw";
            this.lblBedragIncBtw.Size = new System.Drawing.Size(112, 20);
            this.lblBedragIncBtw.TabIndex = 32;
            this.lblBedragIncBtw.Text = "Bedrag Inc Btw:";
            // 
            // txtBtwPercentage
            // 
            this.txtBtwPercentage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBtwPercentage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBtwPercentage.Location = new System.Drawing.Point(188, 325);
            this.txtBtwPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.txtBtwPercentage.Name = "txtBtwPercentage";
            this.txtBtwPercentage.Size = new System.Drawing.Size(113, 27);
            this.txtBtwPercentage.TabIndex = 25;
            this.txtBtwPercentage.Leave += new System.EventHandler(this.txtBtwPercentage_Leave);
            // 
            // lblBtwPer
            // 
            this.lblBtwPer.AutoSize = true;
            this.lblBtwPer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtwPer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBtwPer.Location = new System.Drawing.Point(15, 325);
            this.lblBtwPer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBtwPer.Name = "lblBtwPer";
            this.lblBtwPer.Size = new System.Drawing.Size(116, 20);
            this.lblBtwPer.TabIndex = 31;
            this.lblBtwPer.Text = "Btw percentage:";
            // 
            // txtExBtw
            // 
            this.txtExBtw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExBtw.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExBtw.Location = new System.Drawing.Point(188, 284);
            this.txtExBtw.Margin = new System.Windows.Forms.Padding(2);
            this.txtExBtw.MaxLength = 999;
            this.txtExBtw.Name = "txtExBtw";
            this.txtExBtw.Size = new System.Drawing.Size(113, 27);
            this.txtExBtw.TabIndex = 23;
            this.txtExBtw.Leave += new System.EventHandler(this.txtExBtw_Leave);
            // 
            // lblExBtw
            // 
            this.lblExBtw.AutoSize = true;
            this.lblExBtw.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExBtw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExBtw.Location = new System.Drawing.Point(15, 284);
            this.lblExBtw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExBtw.Name = "lblExBtw";
            this.lblExBtw.Size = new System.Drawing.Size(108, 20);
            this.lblExBtw.TabIndex = 30;
            this.lblExBtw.Text = "Bedrag Ex Btw:";
            // 
            // txtGoedgekeurdBedrag
            // 
            this.txtGoedgekeurdBedrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGoedgekeurdBedrag.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoedgekeurdBedrag.Location = new System.Drawing.Point(188, 244);
            this.txtGoedgekeurdBedrag.Margin = new System.Windows.Forms.Padding(2);
            this.txtGoedgekeurdBedrag.MaxLength = 999;
            this.txtGoedgekeurdBedrag.Name = "txtGoedgekeurdBedrag";
            this.txtGoedgekeurdBedrag.ReadOnly = true;
            this.txtGoedgekeurdBedrag.Size = new System.Drawing.Size(113, 27);
            this.txtGoedgekeurdBedrag.TabIndex = 22;
            // 
            // lblGbedrag
            // 
            this.lblGbedrag.AutoSize = true;
            this.lblGbedrag.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGbedrag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGbedrag.Location = new System.Drawing.Point(15, 244);
            this.lblGbedrag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGbedrag.Name = "lblGbedrag";
            this.lblGbedrag.Size = new System.Drawing.Size(151, 20);
            this.lblGbedrag.TabIndex = 29;
            this.lblGbedrag.Text = "Goedgekeurd bedrag";
            // 
            // rtxtOmschrijving
            // 
            this.rtxtOmschrijving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtOmschrijving.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOmschrijving.Location = new System.Drawing.Point(188, 102);
            this.rtxtOmschrijving.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtOmschrijving.Name = "rtxtOmschrijving";
            this.rtxtOmschrijving.Size = new System.Drawing.Size(376, 89);
            this.rtxtOmschrijving.TabIndex = 20;
            this.rtxtOmschrijving.Text = "";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmschrijving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOmschrijving.Location = new System.Drawing.Point(19, 102);
            this.lblOmschrijving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(98, 20);
            this.lblOmschrijving.TabIndex = 27;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // txtAankoopId
            // 
            this.txtAankoopId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAankoopId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAankoopId.Location = new System.Drawing.Point(188, 57);
            this.txtAankoopId.Margin = new System.Windows.Forms.Padding(2);
            this.txtAankoopId.Name = "txtAankoopId";
            this.txtAankoopId.ReadOnly = true;
            this.txtAankoopId.Size = new System.Drawing.Size(57, 27);
            this.txtAankoopId.TabIndex = 37;
            // 
            // lblAankoopId
            // 
            this.lblAankoopId.AutoSize = true;
            this.lblAankoopId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAankoopId.Location = new System.Drawing.Point(19, 57);
            this.lblAankoopId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAankoopId.Name = "lblAankoopId";
            this.lblAankoopId.Size = new System.Drawing.Size(124, 20);
            this.lblAankoopId.TabIndex = 36;
            this.lblAankoopId.Text = "Aankoopnummer";
            // 
            // lblAankoopDetail
            // 
            this.lblAankoopDetail.AutoSize = true;
            this.lblAankoopDetail.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblAankoopDetail.Location = new System.Drawing.Point(8, 8);
            this.lblAankoopDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAankoopDetail.Name = "lblAankoopDetail";
            this.lblAankoopDetail.Size = new System.Drawing.Size(217, 37);
            this.lblAankoopDetail.TabIndex = 35;
            this.lblAankoopDetail.Text = "Aankoop Detail";
            this.lblAankoopDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpBestelDatum
            // 
            this.dtpBestelDatum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBestelDatum.Location = new System.Drawing.Point(731, 102);
            this.dtpBestelDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBestelDatum.Name = "dtpBestelDatum";
            this.dtpBestelDatum.Size = new System.Drawing.Size(217, 27);
            this.dtpBestelDatum.TabIndex = 38;
            // 
            // dtpVerwachteDatum
            // 
            this.dtpVerwachteDatum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVerwachteDatum.Location = new System.Drawing.Point(731, 142);
            this.dtpVerwachteDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpVerwachteDatum.Name = "dtpVerwachteDatum";
            this.dtpVerwachteDatum.Size = new System.Drawing.Size(217, 27);
            this.dtpVerwachteDatum.TabIndex = 39;
            // 
            // dtpEffectieveDatum
            // 
            this.dtpEffectieveDatum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEffectieveDatum.Location = new System.Drawing.Point(731, 183);
            this.dtpEffectieveDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEffectieveDatum.Name = "dtpEffectieveDatum";
            this.dtpEffectieveDatum.Size = new System.Drawing.Size(217, 27);
            this.dtpEffectieveDatum.TabIndex = 40;
            // 
            // lblBestelDatum
            // 
            this.lblBestelDatum.AutoSize = true;
            this.lblBestelDatum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestelDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBestelDatum.Location = new System.Drawing.Point(581, 102);
            this.lblBestelDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBestelDatum.Name = "lblBestelDatum";
            this.lblBestelDatum.Size = new System.Drawing.Size(99, 20);
            this.lblBestelDatum.TabIndex = 41;
            this.lblBestelDatum.Text = "Bestel datum:";
            // 
            // lblVerwachteDatum
            // 
            this.lblVerwachteDatum.AutoSize = true;
            this.lblVerwachteDatum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerwachteDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVerwachteDatum.Location = new System.Drawing.Point(581, 142);
            this.lblVerwachteDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerwachteDatum.Name = "lblVerwachteDatum";
            this.lblVerwachteDatum.Size = new System.Drawing.Size(127, 20);
            this.lblVerwachteDatum.TabIndex = 42;
            this.lblVerwachteDatum.Text = "Verwachte datum:";
            // 
            // lblEffectieveDatum
            // 
            this.lblEffectieveDatum.AutoSize = true;
            this.lblEffectieveDatum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectieveDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEffectieveDatum.Location = new System.Drawing.Point(581, 183);
            this.lblEffectieveDatum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEffectieveDatum.Name = "lblEffectieveDatum";
            this.lblEffectieveDatum.Size = new System.Drawing.Size(124, 20);
            this.lblEffectieveDatum.TabIndex = 43;
            this.lblEffectieveDatum.Text = "Effectieve datum:";
            // 
            // ddlLeverancier
            // 
            this.ddlLeverancier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLeverancier.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlLeverancier.FormattingEnabled = true;
            this.ddlLeverancier.Location = new System.Drawing.Point(731, 264);
            this.ddlLeverancier.Margin = new System.Windows.Forms.Padding(2);
            this.ddlLeverancier.Name = "ddlLeverancier";
            this.ddlLeverancier.Size = new System.Drawing.Size(151, 27);
            this.ddlLeverancier.TabIndex = 44;
            // 
            // lblLeveranciers
            // 
            this.lblLeveranciers.AutoSize = true;
            this.lblLeveranciers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeveranciers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLeveranciers.Location = new System.Drawing.Point(581, 264);
            this.lblLeveranciers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeveranciers.Name = "lblLeveranciers";
            this.lblLeveranciers.Size = new System.Drawing.Size(93, 20);
            this.lblLeveranciers.TabIndex = 45;
            this.lblLeveranciers.Text = "Leveranciers:";
            // 
            // lblAanvraagId
            // 
            this.lblAanvraagId.AutoSize = true;
            this.lblAanvraagId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAanvraagId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAanvraagId.Location = new System.Drawing.Point(581, 305);
            this.lblAanvraagId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAanvraagId.Name = "lblAanvraagId";
            this.lblAanvraagId.Size = new System.Drawing.Size(85, 20);
            this.lblAanvraagId.TabIndex = 46;
            this.lblAanvraagId.Text = "AanvraagId";
            // 
            // txtAanvraagId
            // 
            this.txtAanvraagId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAanvraagId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAanvraagId.Location = new System.Drawing.Point(731, 305);
            this.txtAanvraagId.Margin = new System.Windows.Forms.Padding(2);
            this.txtAanvraagId.Name = "txtAanvraagId";
            this.txtAanvraagId.ReadOnly = true;
            this.txtAanvraagId.Size = new System.Drawing.Size(76, 27);
            this.txtAanvraagId.TabIndex = 47;
            // 
            // lblBestelbon
            // 
            this.lblBestelbon.AutoSize = true;
            this.lblBestelbon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestelbon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBestelbon.Location = new System.Drawing.Point(581, 345);
            this.lblBestelbon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBestelbon.Name = "lblBestelbon";
            this.lblBestelbon.Size = new System.Drawing.Size(137, 20);
            this.lblBestelbon.TabIndex = 48;
            this.lblBestelbon.Text = "Bestelbon nummer:";
            // 
            // txtBestelbonNummer
            // 
            this.txtBestelbonNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBestelbonNummer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBestelbonNummer.Location = new System.Drawing.Point(731, 345);
            this.txtBestelbonNummer.Margin = new System.Windows.Forms.Padding(2);
            this.txtBestelbonNummer.MaxLength = 50;
            this.txtBestelbonNummer.Name = "txtBestelbonNummer";
            this.txtBestelbonNummer.Size = new System.Drawing.Size(76, 27);
            this.txtBestelbonNummer.TabIndex = 49;
            // 
            // txtFactuurnummer
            // 
            this.txtFactuurnummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFactuurnummer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactuurnummer.Location = new System.Drawing.Point(731, 386);
            this.txtFactuurnummer.Margin = new System.Windows.Forms.Padding(2);
            this.txtFactuurnummer.MaxLength = 50;
            this.txtFactuurnummer.Name = "txtFactuurnummer";
            this.txtFactuurnummer.Size = new System.Drawing.Size(76, 27);
            this.txtFactuurnummer.TabIndex = 50;
            // 
            // txtInternNummer
            // 
            this.txtInternNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInternNummer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternNummer.Location = new System.Drawing.Point(731, 427);
            this.txtInternNummer.Margin = new System.Windows.Forms.Padding(2);
            this.txtInternNummer.MaxLength = 50;
            this.txtInternNummer.Name = "txtInternNummer";
            this.txtInternNummer.Size = new System.Drawing.Size(76, 27);
            this.txtInternNummer.TabIndex = 51;
            // 
            // lblFactuurNummer
            // 
            this.lblFactuurNummer.AutoSize = true;
            this.lblFactuurNummer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactuurNummer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFactuurNummer.Location = new System.Drawing.Point(581, 386);
            this.lblFactuurNummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFactuurNummer.Name = "lblFactuurNummer";
            this.lblFactuurNummer.Size = new System.Drawing.Size(118, 20);
            this.lblFactuurNummer.TabIndex = 52;
            this.lblFactuurNummer.Text = "Factuur nummer:";
            // 
            // lblInternnummer
            // 
            this.lblInternnummer.AutoSize = true;
            this.lblInternnummer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternnummer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInternnummer.Location = new System.Drawing.Point(581, 427);
            this.lblInternnummer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInternnummer.Name = "lblInternnummer";
            this.lblInternnummer.Size = new System.Drawing.Size(109, 20);
            this.lblInternnummer.TabIndex = 53;
            this.lblInternnummer.Text = "Intern nummer:";
            // 
            // chBFactuur
            // 
            this.chBFactuur.AutoSize = true;
            this.chBFactuur.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBFactuur.Location = new System.Drawing.Point(825, 386);
            this.chBFactuur.Margin = new System.Windows.Forms.Padding(2);
            this.chBFactuur.Name = "chBFactuur";
            this.chBFactuur.Size = new System.Drawing.Size(75, 24);
            this.chBFactuur.TabIndex = 54;
            this.chBFactuur.Text = "Factuur";
            this.chBFactuur.UseVisualStyleBackColor = true;
            // 
            // txtIncBtw
            // 
            this.txtIncBtw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncBtw.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncBtw.Location = new System.Drawing.Point(188, 366);
            this.txtIncBtw.Margin = new System.Windows.Forms.Padding(2);
            this.txtIncBtw.Name = "txtIncBtw";
            this.txtIncBtw.ReadOnly = true;
            this.txtIncBtw.Size = new System.Drawing.Size(113, 27);
            this.txtIncBtw.TabIndex = 55;
            // 
            // lblBedragSaldo
            // 
            this.lblBedragSaldo.AutoSize = true;
            this.lblBedragSaldo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedragSaldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBedragSaldo.Location = new System.Drawing.Point(184, 447);
            this.lblBedragSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBedragSaldo.Name = "lblBedragSaldo";
            this.lblBedragSaldo.Size = new System.Drawing.Size(0, 20);
            this.lblBedragSaldo.TabIndex = 56;
            // 
            // btnBewaren
            // 
            this.btnBewaren.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewaren.Location = new System.Drawing.Point(746, 57);
            this.btnBewaren.Margin = new System.Windows.Forms.Padding(2);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(77, 30);
            this.btnBewaren.TabIndex = 57;
            this.btnBewaren.Text = "Bewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijder.Location = new System.Drawing.Point(851, 57);
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(81, 30);
            this.btnVerwijder.TabIndex = 58;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnLeveranciers
            // 
            this.btnLeveranciers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeveranciers.Location = new System.Drawing.Point(886, 263);
            this.btnLeveranciers.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeveranciers.Name = "btnLeveranciers";
            this.btnLeveranciers.Size = new System.Drawing.Size(52, 27);
            this.btnLeveranciers.TabIndex = 59;
            this.btnLeveranciers.Text = "+ / -";
            this.btnLeveranciers.UseVisualStyleBackColor = true;
            this.btnLeveranciers.Click += new System.EventHandler(this.btnLeveranciers_Click);
            // 
            // lblTransferBedrag
            // 
            this.lblTransferBedrag.AutoSize = true;
            this.lblTransferBedrag.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferBedrag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTransferBedrag.Location = new System.Drawing.Point(15, 406);
            this.lblTransferBedrag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransferBedrag.Name = "lblTransferBedrag";
            this.lblTransferBedrag.Size = new System.Drawing.Size(116, 20);
            this.lblTransferBedrag.TabIndex = 60;
            this.lblTransferBedrag.Text = "Transfer bedrag:";
            // 
            // txtBedragTransfer
            // 
            this.txtBedragTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBedragTransfer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedragTransfer.Location = new System.Drawing.Point(188, 406);
            this.txtBedragTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.txtBedragTransfer.Name = "txtBedragTransfer";
            this.txtBedragTransfer.ReadOnly = true;
            this.txtBedragTransfer.Size = new System.Drawing.Size(113, 27);
            this.txtBedragTransfer.TabIndex = 61;
            // 
            // btnEuro
            // 
            this.btnEuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEuro.FlatAppearance.BorderSize = 0;
            this.btnEuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEuro.Location = new System.Drawing.Point(261, 447);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(40, 40);
            this.btnEuro.TabIndex = 62;
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // frmAankoopDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 499);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.txtBedragTransfer);
            this.Controls.Add(this.lblTransferBedrag);
            this.Controls.Add(this.btnLeveranciers);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.lblBedragSaldo);
            this.Controls.Add(this.txtIncBtw);
            this.Controls.Add(this.chBFactuur);
            this.Controls.Add(this.lblInternnummer);
            this.Controls.Add(this.lblFactuurNummer);
            this.Controls.Add(this.txtInternNummer);
            this.Controls.Add(this.txtFactuurnummer);
            this.Controls.Add(this.txtBestelbonNummer);
            this.Controls.Add(this.lblBestelbon);
            this.Controls.Add(this.txtAanvraagId);
            this.Controls.Add(this.lblAanvraagId);
            this.Controls.Add(this.lblLeveranciers);
            this.Controls.Add(this.ddlLeverancier);
            this.Controls.Add(this.lblEffectieveDatum);
            this.Controls.Add(this.lblVerwachteDatum);
            this.Controls.Add(this.lblBestelDatum);
            this.Controls.Add(this.dtpEffectieveDatum);
            this.Controls.Add(this.dtpVerwachteDatum);
            this.Controls.Add(this.dtpBestelDatum);
            this.Controls.Add(this.txtAankoopId);
            this.Controls.Add(this.lblAankoopId);
            this.Controls.Add(this.lblAankoopDetail);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblBedragIncBtw);
            this.Controls.Add(this.txtBtwPercentage);
            this.Controls.Add(this.lblBtwPer);
            this.Controls.Add(this.txtExBtw);
            this.Controls.Add(this.lblExBtw);
            this.Controls.Add(this.txtGoedgekeurdBedrag);
            this.Controls.Add(this.lblGbedrag);
            this.Controls.Add(this.rtxtOmschrijving);
            this.Controls.Add(this.lblOmschrijving);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmAankoopDetail";
            this.Text = "frmAankoopDetail";
            this.Load += new System.EventHandler(this.frmAankoopDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblBedragIncBtw;
        private System.Windows.Forms.TextBox txtBtwPercentage;
        private System.Windows.Forms.Label lblBtwPer;
        private System.Windows.Forms.TextBox txtExBtw;
        private System.Windows.Forms.Label lblExBtw;
        private System.Windows.Forms.TextBox txtGoedgekeurdBedrag;
        private System.Windows.Forms.Label lblGbedrag;
        private System.Windows.Forms.RichTextBox rtxtOmschrijving;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.TextBox txtAankoopId;
        private System.Windows.Forms.Label lblAankoopId;
        private System.Windows.Forms.Label lblAankoopDetail;
        private System.Windows.Forms.DateTimePicker dtpBestelDatum;
        private System.Windows.Forms.DateTimePicker dtpVerwachteDatum;
        private System.Windows.Forms.DateTimePicker dtpEffectieveDatum;
        private System.Windows.Forms.Label lblBestelDatum;
        private System.Windows.Forms.Label lblVerwachteDatum;
        private System.Windows.Forms.Label lblEffectieveDatum;
        private System.Windows.Forms.ComboBox ddlLeverancier;
        private System.Windows.Forms.Label lblLeveranciers;
        private System.Windows.Forms.Label lblAanvraagId;
        private System.Windows.Forms.TextBox txtAanvraagId;
        private System.Windows.Forms.Label lblBestelbon;
        private System.Windows.Forms.TextBox txtBestelbonNummer;
        private System.Windows.Forms.TextBox txtFactuurnummer;
        private System.Windows.Forms.TextBox txtInternNummer;
        private System.Windows.Forms.Label lblFactuurNummer;
        private System.Windows.Forms.Label lblInternnummer;
        private System.Windows.Forms.CheckBox chBFactuur;
        private System.Windows.Forms.TextBox txtIncBtw;
        private System.Windows.Forms.Label lblBedragSaldo;
        private System.Windows.Forms.Button btnBewaren;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnLeveranciers;
        private System.Windows.Forms.Label lblTransferBedrag;
        private System.Windows.Forms.TextBox txtBedragTransfer;
        private System.Windows.Forms.Button btnEuro;
    }
}