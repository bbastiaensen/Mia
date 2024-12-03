using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAanvraagFormulier));
            this.txtAanvraagId = new System.Windows.Forms.TextBox();
            this.lblAanvraagId = new System.Windows.Forms.Label();
            this.lblAanvraagformulier = new System.Windows.Forms.Label();
            this.btn_Indienen = new System.Windows.Forms.Button();
            this.btn_Nieuw = new System.Windows.Forms.Button();
            this.tabPage_Investering = new System.Windows.Forms.TabPage();
            this.pnl_Investeringen = new System.Windows.Forms.Panel();
            this.gboxInvestering = new System.Windows.Forms.GroupBox();
            this.gboxPlanning = new System.Windows.Forms.GroupBox();
            this.ddlWieKooptHet = new System.Windows.Forms.ComboBox();
            this.ddlKostenplaats = new System.Windows.Forms.ComboBox();
            this.ddlFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.lblKostenplaats = new System.Windows.Forms.Label();
            this.lblWieKooptHet = new System.Windows.Forms.Label();
            this.gboxStatusAanvraag = new System.Windows.Forms.GroupBox();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.ddlRichtperiode = new System.Windows.Forms.ComboBox();
            this.lblGoedgekeurdeBedrag = new System.Windows.Forms.Label();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.txtRichtperiode = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtResultaat = new System.Windows.Forms.RichTextBox();
            this.txtGoedgekeurdeBedrag = new System.Windows.Forms.TextBox();
            this.gboxTitel = new System.Windows.Forms.GroupBox();
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
            this.tabPage_Identificatie = new System.Windows.Forms.TabPage();
            this.gboxIdentificatie = new System.Windows.Forms.GroupBox();
            this.ddlDienst = new System.Windows.Forms.ComboBox();
            this.ddlAfdeling = new System.Windows.Forms.ComboBox();
            this.txtAanvraagmoment = new System.Windows.Forms.TextBox();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.lblDienst = new System.Windows.Forms.Label();
            this.lblAfdeling = new System.Windows.Forms.Label();
            this.lblAanvraagmoment = new System.Windows.Forms.Label();
            this.lblGebruikersNaam = new System.Windows.Forms.Label();
            this.tabControl_Aanvraagformulier = new System.Windows.Forms.TabControl();
            this.Tabpage_bestanden = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Links = new System.Windows.Forms.TabPage();
            this.lblLinkId = new System.Windows.Forms.Label();
            this.TxtLinkTitel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_bewaarLink = new System.Windows.Forms.Button();
            this.btn_nieuweLink = new System.Windows.Forms.Button();
            this.txt_hyperlinkInput = new System.Windows.Forms.TextBox();
            this.lbl_hyperlinkDetail = new System.Windows.Forms.Label();
            this.lbl_linksTitel = new System.Windows.Forms.Label();
            this.pnl_Links = new System.Windows.Forms.Panel();
            this.tabPage_Fotos = new System.Windows.Forms.TabPage();
            this.TxtFotoTitel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_bewaarFoto = new System.Windows.Forms.Button();
            this.btn_nieuweFoto = new System.Windows.Forms.Button();
            this.btn_kiesFoto = new System.Windows.Forms.Button();
            this.txt_FotoId = new System.Windows.Forms.TextBox();
            this.lbl_fotoIdDetail = new System.Windows.Forms.Label();
            this.txt_fotoURLInput = new System.Windows.Forms.TextBox();
            this.lbl_fotoUrlDetail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlFotos = new System.Windows.Forms.Panel();
            this.lbl_fotosTitel = new System.Windows.Forms.Label();
            this.tabPage_Offertes = new System.Windows.Forms.TabPage();
            this.TxtOfferteTitel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_bewaarOfferte = new System.Windows.Forms.Button();
            this.btn_nieuweOfferte = new System.Windows.Forms.Button();
            this.btn_kiesOfferte = new System.Windows.Forms.Button();
            this.txt_offerteId = new System.Windows.Forms.TextBox();
            this.lbl_offerteIdDetail = new System.Windows.Forms.Label();
            this.txt_offerteURLInput = new System.Windows.Forms.TextBox();
            this.lbl_offerteURLDetail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_offertesTitel = new System.Windows.Forms.Label();
            this.pnlOffertes = new System.Windows.Forms.Panel();
            this.tabPage_Investering.SuspendLayout();
            this.pnl_Investeringen.SuspendLayout();
            this.gboxInvestering.SuspendLayout();
            this.gboxPlanning.SuspendLayout();
            this.gboxStatusAanvraag.SuspendLayout();
            this.gboxTitel.SuspendLayout();
            this.tabPage_Identificatie.SuspendLayout();
            this.gboxIdentificatie.SuspendLayout();
            this.tabControl_Aanvraagformulier.SuspendLayout();
            this.Tabpage_bestanden.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_Links.SuspendLayout();
            this.tabPage_Fotos.SuspendLayout();
            this.tabPage_Offertes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAanvraagId
            // 
            this.txtAanvraagId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAanvraagId.Location = new System.Drawing.Point(191, 55);
            this.txtAanvraagId.Name = "txtAanvraagId";
            this.txtAanvraagId.ReadOnly = true;
            this.txtAanvraagId.Size = new System.Drawing.Size(71, 34);
            this.txtAanvraagId.TabIndex = 12;
            // 
            // lblAanvraagId
            // 
            this.lblAanvraagId.AutoSize = true;
            this.lblAanvraagId.Location = new System.Drawing.Point(17, 58);
            this.lblAanvraagId.Name = "lblAanvraagId";
            this.lblAanvraagId.Size = new System.Drawing.Size(168, 28);
            this.lblAanvraagId.TabIndex = 11;
            this.lblAanvraagId.Text = "Aanvraagnummer";
            // 
            // lblAanvraagformulier
            // 
            this.lblAanvraagformulier.AutoSize = true;
            this.lblAanvraagformulier.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAanvraagformulier.Location = new System.Drawing.Point(14, 9);
            this.lblAanvraagformulier.Name = "lblAanvraagformulier";
            this.lblAanvraagformulier.Size = new System.Drawing.Size(313, 45);
            this.lblAanvraagformulier.TabIndex = 10;
            this.lblAanvraagformulier.Text = "Aanvraagformulier";
            // 
            // btn_Indienen
            // 
            this.btn_Indienen.Location = new System.Drawing.Point(1154, 49);
            this.btn_Indienen.Name = "btn_Indienen";
            this.btn_Indienen.Size = new System.Drawing.Size(103, 37);
            this.btn_Indienen.TabIndex = 15;
            this.btn_Indienen.Text = "Bewaren";
            this.btn_Indienen.UseVisualStyleBackColor = true;
            this.btn_Indienen.Click += new System.EventHandler(this.btn_Indienen_Click);
            // 
            // btn_Nieuw
            // 
            this.btn_Nieuw.Location = new System.Drawing.Point(1045, 49);
            this.btn_Nieuw.Name = "btn_Nieuw";
            this.btn_Nieuw.Size = new System.Drawing.Size(103, 37);
            this.btn_Nieuw.TabIndex = 16;
            this.btn_Nieuw.Text = "Nieuw";
            this.btn_Nieuw.UseVisualStyleBackColor = true;
            this.btn_Nieuw.Click += new System.EventHandler(this.btn_Nieuw_Click);
            // 
            // tabPage_Investering
            // 
            this.tabPage_Investering.Controls.Add(this.pnl_Investeringen);
            this.tabPage_Investering.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Investering.Name = "tabPage_Investering";
            this.tabPage_Investering.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Investering.Size = new System.Drawing.Size(1227, 546);
            this.tabPage_Investering.TabIndex = 1;
            this.tabPage_Investering.Text = "Investering";
            this.tabPage_Investering.UseVisualStyleBackColor = true;
            // 
            // pnl_Investeringen
            // 
            this.pnl_Investeringen.AutoScroll = true;
            this.pnl_Investeringen.Controls.Add(this.gboxInvestering);
            this.pnl_Investeringen.Location = new System.Drawing.Point(6, 6);
            this.pnl_Investeringen.Name = "pnl_Investeringen";
            this.pnl_Investeringen.Size = new System.Drawing.Size(1218, 527);
            this.pnl_Investeringen.TabIndex = 0;
            // 
            // gboxInvestering
            // 
            this.gboxInvestering.Controls.Add(this.gboxPlanning);
            this.gboxInvestering.Controls.Add(this.gboxStatusAanvraag);
            this.gboxInvestering.Controls.Add(this.gboxTitel);
            this.gboxInvestering.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboxInvestering.Location = new System.Drawing.Point(3, 3);
            this.gboxInvestering.Name = "gboxInvestering";
            this.gboxInvestering.Size = new System.Drawing.Size(1194, 514);
            this.gboxInvestering.TabIndex = 21;
            this.gboxInvestering.TabStop = false;
            this.gboxInvestering.Text = "Investering";
            // 
            // gboxPlanning
            // 
            this.gboxPlanning.Controls.Add(this.ddlWieKooptHet);
            this.gboxPlanning.Controls.Add(this.ddlKostenplaats);
            this.gboxPlanning.Controls.Add(this.ddlFinancieringsjaar);
            this.gboxPlanning.Controls.Add(this.lblFinancieringsjaar);
            this.gboxPlanning.Controls.Add(this.lblKostenplaats);
            this.gboxPlanning.Controls.Add(this.lblWieKooptHet);
            this.gboxPlanning.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboxPlanning.Location = new System.Drawing.Point(731, 31);
            this.gboxPlanning.Name = "gboxPlanning";
            this.gboxPlanning.Size = new System.Drawing.Size(451, 158);
            this.gboxPlanning.TabIndex = 3;
            this.gboxPlanning.TabStop = false;
            this.gboxPlanning.Text = "Planning";
            // 
            // ddlWieKooptHet
            // 
            this.ddlWieKooptHet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlWieKooptHet.FormattingEnabled = true;
            this.ddlWieKooptHet.Location = new System.Drawing.Point(175, 97);
            this.ddlWieKooptHet.Name = "ddlWieKooptHet";
            this.ddlWieKooptHet.Size = new System.Drawing.Size(270, 36);
            this.ddlWieKooptHet.TabIndex = 2;
            // 
            // ddlKostenplaats
            // 
            this.ddlKostenplaats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKostenplaats.FormattingEnabled = true;
            this.ddlKostenplaats.Location = new System.Drawing.Point(175, 62);
            this.ddlKostenplaats.Name = "ddlKostenplaats";
            this.ddlKostenplaats.Size = new System.Drawing.Size(270, 36);
            this.ddlKostenplaats.TabIndex = 1;
            // 
            // ddlFinancieringsjaar
            // 
            this.ddlFinancieringsjaar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFinancieringsjaar.FormattingEnabled = true;
            this.ddlFinancieringsjaar.Location = new System.Drawing.Point(175, 27);
            this.ddlFinancieringsjaar.Name = "ddlFinancieringsjaar";
            this.ddlFinancieringsjaar.Size = new System.Drawing.Size(270, 36);
            this.ddlFinancieringsjaar.TabIndex = 0;
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(14, 30);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(162, 28);
            this.lblFinancieringsjaar.TabIndex = 18;
            this.lblFinancieringsjaar.Text = "Financieringsjaar:";
            // 
            // lblKostenplaats
            // 
            this.lblKostenplaats.AutoSize = true;
            this.lblKostenplaats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKostenplaats.Location = new System.Drawing.Point(14, 65);
            this.lblKostenplaats.Name = "lblKostenplaats";
            this.lblKostenplaats.Size = new System.Drawing.Size(128, 28);
            this.lblKostenplaats.TabIndex = 17;
            this.lblKostenplaats.Text = "Kostenplaats:";
            // 
            // lblWieKooptHet
            // 
            this.lblWieKooptHet.AutoSize = true;
            this.lblWieKooptHet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWieKooptHet.Location = new System.Drawing.Point(14, 100);
            this.lblWieKooptHet.Name = "lblWieKooptHet";
            this.lblWieKooptHet.Size = new System.Drawing.Size(101, 28);
            this.lblWieKooptHet.TabIndex = 16;
            this.lblWieKooptHet.Text = "Aankoper:";
            // 
            // gboxStatusAanvraag
            // 
            this.gboxStatusAanvraag.Controls.Add(this.ddlStatus);
            this.gboxStatusAanvraag.Controls.Add(this.ddlRichtperiode);
            this.gboxStatusAanvraag.Controls.Add(this.lblGoedgekeurdeBedrag);
            this.gboxStatusAanvraag.Controls.Add(this.lblResultaat);
            this.gboxStatusAanvraag.Controls.Add(this.txtRichtperiode);
            this.gboxStatusAanvraag.Controls.Add(this.lblStatus);
            this.gboxStatusAanvraag.Controls.Add(this.txtResultaat);
            this.gboxStatusAanvraag.Controls.Add(this.txtGoedgekeurdeBedrag);
            this.gboxStatusAanvraag.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboxStatusAanvraag.Location = new System.Drawing.Point(731, 194);
            this.gboxStatusAanvraag.Name = "gboxStatusAanvraag";
            this.gboxStatusAanvraag.Size = new System.Drawing.Size(451, 238);
            this.gboxStatusAanvraag.TabIndex = 2;
            this.gboxStatusAanvraag.TabStop = false;
            this.gboxStatusAanvraag.Text = "Status Aanvraag";
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.Enabled = false;
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Items.AddRange(new object[] {
            "In aanvraag",
            "Goedgekeurd",
            "Niet Goedgekeurd",
            "Bekrachtigd",
            "Niet Bekrachtigd",
            ""});
            this.ddlStatus.Location = new System.Drawing.Point(175, 22);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(270, 36);
            this.ddlStatus.TabIndex = 7;
            // 
            // ddlRichtperiode
            // 
            this.ddlRichtperiode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRichtperiode.FormattingEnabled = true;
            this.ddlRichtperiode.Location = new System.Drawing.Point(175, 60);
            this.ddlRichtperiode.Name = "ddlRichtperiode";
            this.ddlRichtperiode.Size = new System.Drawing.Size(270, 36);
            this.ddlRichtperiode.TabIndex = 9;
            // 
            // lblGoedgekeurdeBedrag
            // 
            this.lblGoedgekeurdeBedrag.AutoSize = true;
            this.lblGoedgekeurdeBedrag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGoedgekeurdeBedrag.Location = new System.Drawing.Point(6, 195);
            this.lblGoedgekeurdeBedrag.Name = "lblGoedgekeurdeBedrag";
            this.lblGoedgekeurdeBedrag.Size = new System.Drawing.Size(218, 28);
            this.lblGoedgekeurdeBedrag.TabIndex = 7;
            this.lblGoedgekeurdeBedrag.Text = "Goedgekeurde Bedrag: ";
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResultaat.Location = new System.Drawing.Point(6, 98);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(95, 28);
            this.lblResultaat.TabIndex = 6;
            this.lblResultaat.Text = "Resultaat:";
            // 
            // txtRichtperiode
            // 
            this.txtRichtperiode.AutoSize = true;
            this.txtRichtperiode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRichtperiode.Location = new System.Drawing.Point(6, 63);
            this.txtRichtperiode.Name = "txtRichtperiode";
            this.txtRichtperiode.Size = new System.Drawing.Size(128, 28);
            this.txtRichtperiode.TabIndex = 5;
            this.txtRichtperiode.Text = "Richtperiode:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(6, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(69, 28);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(175, 95);
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.Size = new System.Drawing.Size(270, 91);
            this.txtResultaat.TabIndex = 1;
            this.txtResultaat.Text = "";
            // 
            // txtGoedgekeurdeBedrag
            // 
            this.txtGoedgekeurdeBedrag.Location = new System.Drawing.Point(175, 192);
            this.txtGoedgekeurdeBedrag.Name = "txtGoedgekeurdeBedrag";
            this.txtGoedgekeurdeBedrag.Size = new System.Drawing.Size(270, 34);
            this.txtGoedgekeurdeBedrag.TabIndex = 2;
            // 
            // gboxTitel
            // 
            this.gboxTitel.Controls.Add(this.ddlPrioriteit);
            this.gboxTitel.Controls.Add(this.lblPrioriteit);
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
            this.gboxTitel.Location = new System.Drawing.Point(20, 31);
            this.gboxTitel.Name = "gboxTitel";
            this.gboxTitel.Size = new System.Drawing.Size(703, 401);
            this.gboxTitel.TabIndex = 1;
            this.gboxTitel.TabStop = false;
            this.gboxTitel.Text = "Item";
            // 
            // ddlPrioriteit
            // 
            this.ddlPrioriteit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPrioriteit.FormattingEnabled = true;
            this.ddlPrioriteit.Location = new System.Drawing.Point(156, 180);
            this.ddlPrioriteit.Name = "ddlPrioriteit";
            this.ddlPrioriteit.Size = new System.Drawing.Size(282, 36);
            this.ddlPrioriteit.TabIndex = 2;
            // 
            // lblPrioriteit
            // 
            this.lblPrioriteit.AutoSize = true;
            this.lblPrioriteit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrioriteit.Location = new System.Drawing.Point(14, 183);
            this.lblPrioriteit.Name = "lblPrioriteit";
            this.lblPrioriteit.Size = new System.Drawing.Size(85, 28);
            this.lblPrioriteit.TabIndex = 18;
            this.lblPrioriteit.Text = "Pioriteit:";
            // 
            // ddlInvestering
            // 
            this.ddlInvestering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlInvestering.FormattingEnabled = true;
            this.ddlInvestering.Location = new System.Drawing.Point(156, 355);
            this.ddlInvestering.Name = "ddlInvestering";
            this.ddlInvestering.Size = new System.Drawing.Size(282, 36);
            this.ddlInvestering.TabIndex = 7;
            // 
            // ddlFinanciering
            // 
            this.ddlFinanciering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFinanciering.FormattingEnabled = true;
            this.ddlFinanciering.Location = new System.Drawing.Point(156, 320);
            this.ddlFinanciering.Name = "ddlFinanciering";
            this.ddlFinanciering.Size = new System.Drawing.Size(282, 36);
            this.ddlFinanciering.TabIndex = 6;
            // 
            // lblInvestering
            // 
            this.lblInvestering.AutoSize = true;
            this.lblInvestering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInvestering.Location = new System.Drawing.Point(14, 358);
            this.lblInvestering.Name = "lblInvestering";
            this.lblInvestering.Size = new System.Drawing.Size(112, 28);
            this.lblInvestering.TabIndex = 15;
            this.lblInvestering.Text = "Investering:";
            // 
            // lblFinaciering
            // 
            this.lblFinaciering.AutoSize = true;
            this.lblFinaciering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinaciering.Location = new System.Drawing.Point(14, 323);
            this.lblFinaciering.Name = "lblFinaciering";
            this.lblFinaciering.Size = new System.Drawing.Size(122, 28);
            this.lblFinaciering.TabIndex = 14;
            this.lblFinaciering.Text = "Financiering:";
            // 
            // txtTotaal
            // 
            this.txtTotaal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotaal.Location = new System.Drawing.Point(156, 285);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.ReadOnly = true;
            this.txtTotaal.Size = new System.Drawing.Size(282, 34);
            this.txtTotaal.TabIndex = 5;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotaal.Location = new System.Drawing.Point(14, 287);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(105, 28);
            this.lblTotaal.TabIndex = 12;
            this.lblTotaal.Text = "Totaalprijs:";
            // 
            // txtAantalStuks
            // 
            this.txtAantalStuks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAantalStuks.Location = new System.Drawing.Point(156, 250);
            this.txtAantalStuks.Name = "txtAantalStuks";
            this.txtAantalStuks.Size = new System.Drawing.Size(282, 34);
            this.txtAantalStuks.TabIndex = 4;
            this.txtAantalStuks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAantalStuks_KeyPress);
            this.txtAantalStuks.Leave += new System.EventHandler(this.txtAantalStuks_Leave);
            // 
            // lblAantalStuks
            // 
            this.lblAantalStuks.AutoSize = true;
            this.lblAantalStuks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAantalStuks.Location = new System.Drawing.Point(14, 252);
            this.lblAantalStuks.Name = "lblAantalStuks";
            this.lblAantalStuks.Size = new System.Drawing.Size(121, 28);
            this.lblAantalStuks.TabIndex = 10;
            this.lblAantalStuks.Text = "Aantal stuks:";
            // 
            // txtPrijsindicatie
            // 
            this.txtPrijsindicatie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrijsindicatie.Location = new System.Drawing.Point(156, 215);
            this.txtPrijsindicatie.Name = "txtPrijsindicatie";
            this.txtPrijsindicatie.Size = new System.Drawing.Size(282, 34);
            this.txtPrijsindicatie.TabIndex = 3;
            this.txtPrijsindicatie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrijsindicatie_KeyPress);
            this.txtPrijsindicatie.Leave += new System.EventHandler(this.txtPrijsindicatie_Leave);
            // 
            // lblPrijsindicatie
            // 
            this.lblPrijsindicatie.AutoSize = true;
            this.lblPrijsindicatie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrijsindicatie.Location = new System.Drawing.Point(14, 217);
            this.lblPrijsindicatie.Name = "lblPrijsindicatie";
            this.lblPrijsindicatie.Size = new System.Drawing.Size(170, 28);
            this.lblPrijsindicatie.TabIndex = 8;
            this.lblPrijsindicatie.Text = "Prijsindicatie/stuk:";
            // 
            // rtxtOmschrijving
            // 
            this.rtxtOmschrijving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtOmschrijving.Location = new System.Drawing.Point(156, 65);
            this.rtxtOmschrijving.Name = "rtxtOmschrijving";
            this.rtxtOmschrijving.Size = new System.Drawing.Size(533, 109);
            this.rtxtOmschrijving.TabIndex = 1;
            this.rtxtOmschrijving.Text = "";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOmschrijving.Location = new System.Drawing.Point(14, 67);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(131, 28);
            this.lblOmschrijving.TabIndex = 6;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // txtTitel
            // 
            this.txtTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitel.Location = new System.Drawing.Point(156, 30);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(533, 34);
            this.txtTitel.TabIndex = 0;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitel.Location = new System.Drawing.Point(14, 32);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(53, 28);
            this.lblTitel.TabIndex = 4;
            this.lblTitel.Text = "Titel:";
            // 
            // tabPage_Identificatie
            // 
            this.tabPage_Identificatie.Controls.Add(this.gboxIdentificatie);
            this.tabPage_Identificatie.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Identificatie.Name = "tabPage_Identificatie";
            this.tabPage_Identificatie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Identificatie.Size = new System.Drawing.Size(1227, 546);
            this.tabPage_Identificatie.TabIndex = 0;
            this.tabPage_Identificatie.Text = "Identificatie";
            this.tabPage_Identificatie.UseVisualStyleBackColor = true;
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
            this.gboxIdentificatie.Location = new System.Drawing.Point(5, 5);
            this.gboxIdentificatie.Name = "gboxIdentificatie";
            this.gboxIdentificatie.Size = new System.Drawing.Size(1216, 185);
            this.gboxIdentificatie.TabIndex = 13;
            this.gboxIdentificatie.TabStop = false;
            this.gboxIdentificatie.Text = "Identificatie";
            // 
            // ddlDienst
            // 
            this.ddlDienst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDienst.FormattingEnabled = true;
            this.ddlDienst.Location = new System.Drawing.Point(210, 133);
            this.ddlDienst.Name = "ddlDienst";
            this.ddlDienst.Size = new System.Drawing.Size(282, 36);
            this.ddlDienst.TabIndex = 3;
            // 
            // ddlAfdeling
            // 
            this.ddlAfdeling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAfdeling.FormattingEnabled = true;
            this.ddlAfdeling.Location = new System.Drawing.Point(210, 98);
            this.ddlAfdeling.Name = "ddlAfdeling";
            this.ddlAfdeling.Size = new System.Drawing.Size(282, 36);
            this.ddlAfdeling.TabIndex = 2;
            // 
            // txtAanvraagmoment
            // 
            this.txtAanvraagmoment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAanvraagmoment.Location = new System.Drawing.Point(211, 63);
            this.txtAanvraagmoment.Name = "txtAanvraagmoment";
            this.txtAanvraagmoment.ReadOnly = true;
            this.txtAanvraagmoment.Size = new System.Drawing.Size(281, 34);
            this.txtAanvraagmoment.TabIndex = 1;
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGebruiker.Location = new System.Drawing.Point(210, 28);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.ReadOnly = true;
            this.txtGebruiker.Size = new System.Drawing.Size(282, 34);
            this.txtGebruiker.TabIndex = 0;
            // 
            // lblDienst
            // 
            this.lblDienst.AutoSize = true;
            this.lblDienst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDienst.Location = new System.Drawing.Point(30, 136);
            this.lblDienst.Name = "lblDienst";
            this.lblDienst.Size = new System.Drawing.Size(71, 28);
            this.lblDienst.TabIndex = 6;
            this.lblDienst.Text = "Dienst:";
            // 
            // lblAfdeling
            // 
            this.lblAfdeling.AutoSize = true;
            this.lblAfdeling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAfdeling.Location = new System.Drawing.Point(30, 101);
            this.lblAfdeling.Name = "lblAfdeling";
            this.lblAfdeling.Size = new System.Drawing.Size(90, 28);
            this.lblAfdeling.TabIndex = 5;
            this.lblAfdeling.Text = "Afdeling:";
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.AutoSize = true;
            this.lblAanvraagmoment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAanvraagmoment.Location = new System.Drawing.Point(30, 65);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(220, 28);
            this.lblAanvraagmoment.TabIndex = 4;
            this.lblAanvraagmoment.Text = "Datum laatste wijziging:";
            // 
            // lblGebruikersNaam
            // 
            this.lblGebruikersNaam.AutoSize = true;
            this.lblGebruikersNaam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGebruikersNaam.Location = new System.Drawing.Point(30, 32);
            this.lblGebruikersNaam.Name = "lblGebruikersNaam";
            this.lblGebruikersNaam.Size = new System.Drawing.Size(158, 28);
            this.lblGebruikersNaam.TabIndex = 3;
            this.lblGebruikersNaam.Text = "Gebruikersnaam:";
            // 
            // tabControl_Aanvraagformulier
            // 
            this.tabControl_Aanvraagformulier.Controls.Add(this.tabPage_Identificatie);
            this.tabControl_Aanvraagformulier.Controls.Add(this.tabPage_Investering);
            this.tabControl_Aanvraagformulier.Controls.Add(this.Tabpage_bestanden);
            this.tabControl_Aanvraagformulier.Location = new System.Drawing.Point(22, 95);
            this.tabControl_Aanvraagformulier.Name = "tabControl_Aanvraagformulier";
            this.tabControl_Aanvraagformulier.SelectedIndex = 0;
            this.tabControl_Aanvraagformulier.Size = new System.Drawing.Size(1235, 587);
            this.tabControl_Aanvraagformulier.TabIndex = 14;
            // 
            // Tabpage_bestanden
            // 
            this.Tabpage_bestanden.Controls.Add(this.tabControl);
            this.Tabpage_bestanden.Location = new System.Drawing.Point(4, 37);
            this.Tabpage_bestanden.Name = "Tabpage_bestanden";
            this.Tabpage_bestanden.Padding = new System.Windows.Forms.Padding(3);
            this.Tabpage_bestanden.Size = new System.Drawing.Size(1227, 546);
            this.Tabpage_bestanden.TabIndex = 2;
            this.Tabpage_bestanden.Text = "Bestanden";
            this.Tabpage_bestanden.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Links);
            this.tabControl.Controls.Add(this.tabPage_Fotos);
            this.tabControl.Controls.Add(this.tabPage_Offertes);
            this.tabControl.Location = new System.Drawing.Point(1, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(782, 549);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_Links
            // 
            this.tabPage_Links.Controls.Add(this.lblLinkId);
            this.tabPage_Links.Controls.Add(this.TxtLinkTitel);
            this.tabPage_Links.Controls.Add(this.label1);
            this.tabPage_Links.Controls.Add(this.btn_bewaarLink);
            this.tabPage_Links.Controls.Add(this.btn_nieuweLink);
            this.tabPage_Links.Controls.Add(this.txt_hyperlinkInput);
            this.tabPage_Links.Controls.Add(this.lbl_hyperlinkDetail);
            this.tabPage_Links.Controls.Add(this.lbl_linksTitel);
            this.tabPage_Links.Controls.Add(this.pnl_Links);
            this.tabPage_Links.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Links.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Links.Name = "tabPage_Links";
            this.tabPage_Links.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Links.Size = new System.Drawing.Size(774, 508);
            this.tabPage_Links.TabIndex = 0;
            this.tabPage_Links.Text = "Links";
            this.tabPage_Links.UseVisualStyleBackColor = true;
            // 
            // lblLinkId
            // 
            this.lblLinkId.Location = new System.Drawing.Point(17, 293);
            this.lblLinkId.Name = "lblLinkId";
            this.lblLinkId.Size = new System.Drawing.Size(44, 16);
            this.lblLinkId.TabIndex = 13;
            this.lblLinkId.Visible = false;
            // 
            // TxtLinkTitel
            // 
            this.TxtLinkTitel.Location = new System.Drawing.Point(99, 396);
            this.TxtLinkTitel.Name = "TxtLinkTitel";
            this.TxtLinkTitel.Size = new System.Drawing.Size(668, 34);
            this.TxtLinkTitel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Titel:";
            // 
            // btn_bewaarLink
            // 
            this.btn_bewaarLink.Location = new System.Drawing.Point(567, 469);
            this.btn_bewaarLink.Name = "btn_bewaarLink";
            this.btn_bewaarLink.Size = new System.Drawing.Size(200, 40);
            this.btn_bewaarLink.TabIndex = 3;
            this.btn_bewaarLink.Text = "Bewaren";
            this.btn_bewaarLink.UseVisualStyleBackColor = true;
            this.btn_bewaarLink.Click += new System.EventHandler(this.btn_bewaarLink_Click);
            // 
            // btn_nieuweLink
            // 
            this.btn_nieuweLink.Location = new System.Drawing.Point(5, 469);
            this.btn_nieuweLink.Name = "btn_nieuweLink";
            this.btn_nieuweLink.Size = new System.Drawing.Size(200, 40);
            this.btn_nieuweLink.TabIndex = 2;
            this.btn_nieuweLink.Text = "Nieuw";
            this.btn_nieuweLink.UseVisualStyleBackColor = true;
            this.btn_nieuweLink.Click += new System.EventHandler(this.btn_nieuweLink_Click);
            // 
            // txt_hyperlinkInput
            // 
            this.txt_hyperlinkInput.Location = new System.Drawing.Point(99, 431);
            this.txt_hyperlinkInput.Name = "txt_hyperlinkInput";
            this.txt_hyperlinkInput.Size = new System.Drawing.Size(668, 34);
            this.txt_hyperlinkInput.TabIndex = 1;
            // 
            // lbl_hyperlinkDetail
            // 
            this.lbl_hyperlinkDetail.AutoSize = true;
            this.lbl_hyperlinkDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hyperlinkDetail.Location = new System.Drawing.Point(12, 433);
            this.lbl_hyperlinkDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hyperlinkDetail.Name = "lbl_hyperlinkDetail";
            this.lbl_hyperlinkDetail.Size = new System.Drawing.Size(100, 28);
            this.lbl_hyperlinkDetail.TabIndex = 6;
            this.lbl_hyperlinkDetail.Text = "Hyperlink:";
            this.lbl_hyperlinkDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_linksTitel
            // 
            this.lbl_linksTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_linksTitel.Location = new System.Drawing.Point(0, 0);
            this.lbl_linksTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_linksTitel.Name = "lbl_linksTitel";
            this.lbl_linksTitel.Size = new System.Drawing.Size(772, 42);
            this.lbl_linksTitel.TabIndex = 1;
            this.lbl_linksTitel.Text = "Links";
            this.lbl_linksTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Links
            // 
            this.pnl_Links.AutoScroll = true;
            this.pnl_Links.Location = new System.Drawing.Point(5, 51);
            this.pnl_Links.Name = "pnl_Links";
            this.pnl_Links.Size = new System.Drawing.Size(762, 339);
            this.pnl_Links.TabIndex = 0;
            // 
            // tabPage_Fotos
            // 
            this.tabPage_Fotos.Controls.Add(this.TxtFotoTitel);
            this.tabPage_Fotos.Controls.Add(this.label2);
            this.tabPage_Fotos.Controls.Add(this.btn_bewaarFoto);
            this.tabPage_Fotos.Controls.Add(this.btn_nieuweFoto);
            this.tabPage_Fotos.Controls.Add(this.btn_kiesFoto);
            this.tabPage_Fotos.Controls.Add(this.txt_FotoId);
            this.tabPage_Fotos.Controls.Add(this.lbl_fotoIdDetail);
            this.tabPage_Fotos.Controls.Add(this.txt_fotoURLInput);
            this.tabPage_Fotos.Controls.Add(this.lbl_fotoUrlDetail);
            this.tabPage_Fotos.Controls.Add(this.label5);
            this.tabPage_Fotos.Controls.Add(this.pnlFotos);
            this.tabPage_Fotos.Controls.Add(this.lbl_fotosTitel);
            this.tabPage_Fotos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Fotos.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Fotos.Name = "tabPage_Fotos";
            this.tabPage_Fotos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Fotos.Size = new System.Drawing.Size(774, 508);
            this.tabPage_Fotos.TabIndex = 1;
            this.tabPage_Fotos.Text = "Foto\'s";
            this.tabPage_Fotos.UseVisualStyleBackColor = true;
            // 
            // TxtFotoTitel
            // 
            this.TxtFotoTitel.Location = new System.Drawing.Point(74, 396);
            this.TxtFotoTitel.Name = "TxtFotoTitel";
            this.TxtFotoTitel.Size = new System.Drawing.Size(603, 34);
            this.TxtFotoTitel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Titel:";
            // 
            // btn_bewaarFoto
            // 
            this.btn_bewaarFoto.Location = new System.Drawing.Point(567, 469);
            this.btn_bewaarFoto.Name = "btn_bewaarFoto";
            this.btn_bewaarFoto.Size = new System.Drawing.Size(200, 40);
            this.btn_bewaarFoto.TabIndex = 3;
            this.btn_bewaarFoto.Text = "Bewaren";
            this.btn_bewaarFoto.UseVisualStyleBackColor = true;
            this.btn_bewaarFoto.Click += new System.EventHandler(this.btn_bewaarFoto_Click);
            // 
            // btn_nieuweFoto
            // 
            this.btn_nieuweFoto.Location = new System.Drawing.Point(5, 469);
            this.btn_nieuweFoto.Name = "btn_nieuweFoto";
            this.btn_nieuweFoto.Size = new System.Drawing.Size(200, 40);
            this.btn_nieuweFoto.TabIndex = 2;
            this.btn_nieuweFoto.Text = "Nieuw";
            this.btn_nieuweFoto.UseVisualStyleBackColor = true;
            this.btn_nieuweFoto.Click += new System.EventHandler(this.btn_nieuweFoto_Click);
            // 
            // btn_kiesFoto
            // 
            this.btn_kiesFoto.Location = new System.Drawing.Point(683, 431);
            this.btn_kiesFoto.Name = "btn_kiesFoto";
            this.btn_kiesFoto.Size = new System.Drawing.Size(84, 29);
            this.btn_kiesFoto.TabIndex = 18;
            this.btn_kiesFoto.Text = "...";
            this.btn_kiesFoto.UseVisualStyleBackColor = true;
            this.btn_kiesFoto.Click += new System.EventHandler(this.btn_kiesFoto_Click);
            // 
            // txt_FotoId
            // 
            this.txt_FotoId.Location = new System.Drawing.Point(74, 361);
            this.txt_FotoId.Name = "txt_FotoId";
            this.txt_FotoId.ReadOnly = true;
            this.txt_FotoId.Size = new System.Drawing.Size(603, 34);
            this.txt_FotoId.TabIndex = 17;
            // 
            // lbl_fotoIdDetail
            // 
            this.lbl_fotoIdDetail.AutoSize = true;
            this.lbl_fotoIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fotoIdDetail.Location = new System.Drawing.Point(12, 363);
            this.lbl_fotoIdDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fotoIdDetail.Name = "lbl_fotoIdDetail";
            this.lbl_fotoIdDetail.Size = new System.Drawing.Size(33, 28);
            this.lbl_fotoIdDetail.TabIndex = 16;
            this.lbl_fotoIdDetail.Text = "Id:";
            this.lbl_fotoIdDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_fotoURLInput
            // 
            this.txt_fotoURLInput.Location = new System.Drawing.Point(74, 431);
            this.txt_fotoURLInput.Name = "txt_fotoURLInput";
            this.txt_fotoURLInput.Size = new System.Drawing.Size(603, 34);
            this.txt_fotoURLInput.TabIndex = 1;
            // 
            // lbl_fotoUrlDetail
            // 
            this.lbl_fotoUrlDetail.AutoSize = true;
            this.lbl_fotoUrlDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fotoUrlDetail.Location = new System.Drawing.Point(12, 433);
            this.lbl_fotoUrlDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fotoUrlDetail.Name = "lbl_fotoUrlDetail";
            this.lbl_fotoUrlDetail.Size = new System.Drawing.Size(51, 28);
            this.lbl_fotoUrlDetail.TabIndex = 11;
            this.lbl_fotoUrlDetail.Text = "URL:";
            this.lbl_fotoUrlDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 8;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlFotos
            // 
            this.pnlFotos.AutoScroll = true;
            this.pnlFotos.Location = new System.Drawing.Point(5, 51);
            this.pnlFotos.Name = "pnlFotos";
            this.pnlFotos.Size = new System.Drawing.Size(762, 304);
            this.pnlFotos.TabIndex = 3;
            // 
            // lbl_fotosTitel
            // 
            this.lbl_fotosTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fotosTitel.Location = new System.Drawing.Point(0, 0);
            this.lbl_fotosTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fotosTitel.Name = "lbl_fotosTitel";
            this.lbl_fotosTitel.Size = new System.Drawing.Size(772, 42);
            this.lbl_fotosTitel.TabIndex = 2;
            this.lbl_fotosTitel.Text = "Foto\'s";
            this.lbl_fotosTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_Offertes
            // 
            this.tabPage_Offertes.Controls.Add(this.TxtOfferteTitel);
            this.tabPage_Offertes.Controls.Add(this.label3);
            this.tabPage_Offertes.Controls.Add(this.btn_bewaarOfferte);
            this.tabPage_Offertes.Controls.Add(this.btn_nieuweOfferte);
            this.tabPage_Offertes.Controls.Add(this.btn_kiesOfferte);
            this.tabPage_Offertes.Controls.Add(this.txt_offerteId);
            this.tabPage_Offertes.Controls.Add(this.lbl_offerteIdDetail);
            this.tabPage_Offertes.Controls.Add(this.txt_offerteURLInput);
            this.tabPage_Offertes.Controls.Add(this.lbl_offerteURLDetail);
            this.tabPage_Offertes.Controls.Add(this.label9);
            this.tabPage_Offertes.Controls.Add(this.lbl_offertesTitel);
            this.tabPage_Offertes.Controls.Add(this.pnlOffertes);
            this.tabPage_Offertes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Offertes.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Offertes.Name = "tabPage_Offertes";
            this.tabPage_Offertes.Size = new System.Drawing.Size(774, 508);
            this.tabPage_Offertes.TabIndex = 2;
            this.tabPage_Offertes.Text = "Offertes";
            this.tabPage_Offertes.UseVisualStyleBackColor = true;
            // 
            // TxtOfferteTitel
            // 
            this.TxtOfferteTitel.Location = new System.Drawing.Point(74, 396);
            this.TxtOfferteTitel.Name = "TxtOfferteTitel";
            this.TxtOfferteTitel.Size = new System.Drawing.Size(603, 34);
            this.TxtOfferteTitel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Titel:";
            // 
            // btn_bewaarOfferte
            // 
            this.btn_bewaarOfferte.Location = new System.Drawing.Point(567, 469);
            this.btn_bewaarOfferte.Name = "btn_bewaarOfferte";
            this.btn_bewaarOfferte.Size = new System.Drawing.Size(200, 40);
            this.btn_bewaarOfferte.TabIndex = 3;
            this.btn_bewaarOfferte.Text = "Bewaren";
            this.btn_bewaarOfferte.UseVisualStyleBackColor = true;
            this.btn_bewaarOfferte.Click += new System.EventHandler(this.btn_bewaarOfferte_Click);
            // 
            // btn_nieuweOfferte
            // 
            this.btn_nieuweOfferte.Location = new System.Drawing.Point(5, 469);
            this.btn_nieuweOfferte.Name = "btn_nieuweOfferte";
            this.btn_nieuweOfferte.Size = new System.Drawing.Size(200, 40);
            this.btn_nieuweOfferte.TabIndex = 2;
            this.btn_nieuweOfferte.Text = "Nieuw";
            this.btn_nieuweOfferte.UseVisualStyleBackColor = true;
            this.btn_nieuweOfferte.Click += new System.EventHandler(this.btn_nieuweOfferte_Click);
            // 
            // btn_kiesOfferte
            // 
            this.btn_kiesOfferte.Location = new System.Drawing.Point(683, 431);
            this.btn_kiesOfferte.Name = "btn_kiesOfferte";
            this.btn_kiesOfferte.Size = new System.Drawing.Size(84, 29);
            this.btn_kiesOfferte.TabIndex = 27;
            this.btn_kiesOfferte.Text = "...";
            this.btn_kiesOfferte.UseVisualStyleBackColor = true;
            this.btn_kiesOfferte.Click += new System.EventHandler(this.btn_kiesOfferte_Click);
            // 
            // txt_offerteId
            // 
            this.txt_offerteId.Location = new System.Drawing.Point(74, 361);
            this.txt_offerteId.Name = "txt_offerteId";
            this.txt_offerteId.ReadOnly = true;
            this.txt_offerteId.Size = new System.Drawing.Size(603, 34);
            this.txt_offerteId.TabIndex = 26;
            // 
            // lbl_offerteIdDetail
            // 
            this.lbl_offerteIdDetail.AutoSize = true;
            this.lbl_offerteIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offerteIdDetail.Location = new System.Drawing.Point(12, 363);
            this.lbl_offerteIdDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_offerteIdDetail.Name = "lbl_offerteIdDetail";
            this.lbl_offerteIdDetail.Size = new System.Drawing.Size(33, 28);
            this.lbl_offerteIdDetail.TabIndex = 25;
            this.lbl_offerteIdDetail.Text = "Id:";
            this.lbl_offerteIdDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_offerteURLInput
            // 
            this.txt_offerteURLInput.Location = new System.Drawing.Point(74, 431);
            this.txt_offerteURLInput.Name = "txt_offerteURLInput";
            this.txt_offerteURLInput.Size = new System.Drawing.Size(603, 34);
            this.txt_offerteURLInput.TabIndex = 1;
            // 
            // lbl_offerteURLDetail
            // 
            this.lbl_offerteURLDetail.AutoSize = true;
            this.lbl_offerteURLDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offerteURLDetail.Location = new System.Drawing.Point(12, 433);
            this.lbl_offerteURLDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_offerteURLDetail.Name = "lbl_offerteURLDetail";
            this.lbl_offerteURLDetail.Size = new System.Drawing.Size(51, 28);
            this.lbl_offerteURLDetail.TabIndex = 23;
            this.lbl_offerteURLDetail.Text = "URL:";
            this.lbl_offerteURLDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 284);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 28);
            this.label9.TabIndex = 22;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_offertesTitel
            // 
            this.lbl_offertesTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offertesTitel.Location = new System.Drawing.Point(0, 0);
            this.lbl_offertesTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_offertesTitel.Name = "lbl_offertesTitel";
            this.lbl_offertesTitel.Size = new System.Drawing.Size(772, 42);
            this.lbl_offertesTitel.TabIndex = 12;
            this.lbl_offertesTitel.Text = "Offertes";
            this.lbl_offertesTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOffertes
            // 
            this.pnlOffertes.Location = new System.Drawing.Point(5, 51);
            this.pnlOffertes.Name = "pnlOffertes";
            this.pnlOffertes.Size = new System.Drawing.Size(762, 304);
            this.pnlOffertes.TabIndex = 11;
            // 
            // frmAanvraagFormulier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1273, 686);
            this.Controls.Add(this.btn_Nieuw);
            this.Controls.Add(this.btn_Indienen);
            this.Controls.Add(this.tabControl_Aanvraagformulier);
            this.Controls.Add(this.txtAanvraagId);
            this.Controls.Add(this.lblAanvraagId);
            this.Controls.Add(this.lblAanvraagformulier);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAanvraagFormulier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Aanvraagformulier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAanvraagFormulier_FormClosing);
            this.Load += new System.EventHandler(this.frmAanvraagFormulier_Load);
            this.tabPage_Investering.ResumeLayout(false);
            this.pnl_Investeringen.ResumeLayout(false);
            this.gboxInvestering.ResumeLayout(false);
            this.gboxPlanning.ResumeLayout(false);
            this.gboxPlanning.PerformLayout();
            this.gboxStatusAanvraag.ResumeLayout(false);
            this.gboxStatusAanvraag.PerformLayout();
            this.gboxTitel.ResumeLayout(false);
            this.gboxTitel.PerformLayout();
            this.tabPage_Identificatie.ResumeLayout(false);
            this.gboxIdentificatie.ResumeLayout(false);
            this.gboxIdentificatie.PerformLayout();
            this.tabControl_Aanvraagformulier.ResumeLayout(false);
            this.Tabpage_bestanden.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Links.ResumeLayout(false);
            this.tabPage_Links.PerformLayout();
            this.tabPage_Fotos.ResumeLayout(false);
            this.tabPage_Fotos.PerformLayout();
            this.tabPage_Offertes.ResumeLayout(false);
            this.tabPage_Offertes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.TextBox txtAanvraagId;
        private System.Windows.Forms.Label lblAanvraagId;
        private System.Windows.Forms.Label lblAanvraagformulier;
        private System.Windows.Forms.Button btn_Indienen;
        private System.Windows.Forms.Button btn_Nieuw;
        private System.Windows.Forms.TabPage tabPage_Investering;
        private System.Windows.Forms.Panel pnl_Investeringen;
        private System.Windows.Forms.GroupBox gboxInvestering;
        private System.Windows.Forms.GroupBox gboxPlanning;
        private System.Windows.Forms.ComboBox ddlWieKooptHet;
        private System.Windows.Forms.ComboBox ddlKostenplaats;
        private System.Windows.Forms.ComboBox ddlFinancieringsjaar;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblKostenplaats;
        private System.Windows.Forms.Label lblWieKooptHet;
        private System.Windows.Forms.GroupBox gboxTitel;
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
        private System.Windows.Forms.TabPage tabPage_Identificatie;
        private System.Windows.Forms.GroupBox gboxIdentificatie;
        private System.Windows.Forms.ComboBox ddlDienst;
        private System.Windows.Forms.ComboBox ddlAfdeling;
        private System.Windows.Forms.TextBox txtAanvraagmoment;
        private System.Windows.Forms.TextBox txtGebruiker;
        private System.Windows.Forms.Label lblDienst;
        private System.Windows.Forms.Label lblAfdeling;
        private System.Windows.Forms.Label lblAanvraagmoment;
        private System.Windows.Forms.Label lblGebruikersNaam;
        private System.Windows.Forms.TabControl tabControl_Aanvraagformulier;
        private System.Windows.Forms.TabPage Tabpage_bestanden;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Links;
        private System.Windows.Forms.Button btn_bewaarLink;
        private System.Windows.Forms.Button btn_nieuweLink;
        private System.Windows.Forms.TextBox txt_hyperlinkInput;
        private System.Windows.Forms.Label lbl_hyperlinkDetail;
        private System.Windows.Forms.Label lbl_linksTitel;
        private System.Windows.Forms.Panel pnl_Links;
        private System.Windows.Forms.TabPage tabPage_Fotos;
        private System.Windows.Forms.Button btn_bewaarFoto;
        private System.Windows.Forms.Button btn_nieuweFoto;
        private System.Windows.Forms.Button btn_kiesFoto;
        private System.Windows.Forms.TextBox txt_FotoId;
        private System.Windows.Forms.Label lbl_fotoIdDetail;
        private System.Windows.Forms.TextBox txt_fotoURLInput;
        private System.Windows.Forms.Label lbl_fotoUrlDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlFotos;
        private System.Windows.Forms.Label lbl_fotosTitel;
        private System.Windows.Forms.TabPage tabPage_Offertes;
        private System.Windows.Forms.Button btn_bewaarOfferte;
        private System.Windows.Forms.Button btn_nieuweOfferte;
        private System.Windows.Forms.Button btn_kiesOfferte;
        private System.Windows.Forms.TextBox txt_offerteId;
        private System.Windows.Forms.Label lbl_offerteIdDetail;
        private System.Windows.Forms.TextBox txt_offerteURLInput;
        private System.Windows.Forms.Label lbl_offerteURLDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_offertesTitel;
        private System.Windows.Forms.Panel pnlOffertes;
        private System.Windows.Forms.TextBox TxtLinkTitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFotoTitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOfferteTitel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLinkId;
        private System.Windows.Forms.GroupBox gboxStatusAanvraag;
        private System.Windows.Forms.Label txtRichtperiode;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtGoedgekeurdeBedrag;
        private System.Windows.Forms.RichTextBox txtResultaat;
        private System.Windows.Forms.Label lblGoedgekeurdeBedrag;
        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.ComboBox ddlRichtperiode;
        private System.Windows.Forms.ComboBox ddlStatus;
    }
}