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
            this.gboxTitel = new System.Windows.Forms.GroupBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.rtxtOmschrijving = new System.Windows.Forms.RichTextBox();
            this.lblPrijsindicatie = new System.Windows.Forms.Label();
            this.txtPrijsindicatie = new System.Windows.Forms.TextBox();
            this.lblAantalStuks = new System.Windows.Forms.Label();
            this.txtAantalStuks = new System.Windows.Forms.TextBox();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.txtTotaal = new System.Windows.Forms.TextBox();
            this.lblFinaciering = new System.Windows.Forms.Label();
            this.lblInvestering = new System.Windows.Forms.Label();
            this.ddlFinanciering = new System.Windows.Forms.ComboBox();
            this.ddlInvestering = new System.Windows.Forms.ComboBox();
            this.lblPrioriteit = new System.Windows.Forms.Label();
            this.ddlPrioriteit = new System.Windows.Forms.ComboBox();
            this.gboxPlanning = new System.Windows.Forms.GroupBox();
            this.lblWieKooptHet = new System.Windows.Forms.Label();
            this.lblKostenplaats = new System.Windows.Forms.Label();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.ddlFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.ddlKostenplaats = new System.Windows.Forms.ComboBox();
            this.ddlWieKooptHet = new System.Windows.Forms.ComboBox();
            this.tabPage_Identificatie = new System.Windows.Forms.TabPage();
            this.gboxIdentificatie = new System.Windows.Forms.GroupBox();
            this.lblGebruikersNaam = new System.Windows.Forms.Label();
            this.lblAanvraagmoment = new System.Windows.Forms.Label();
            this.lblAfdeling = new System.Windows.Forms.Label();
            this.lblDienst = new System.Windows.Forms.Label();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.txtAanvraagmoment = new System.Windows.Forms.TextBox();
            this.ddlAfdeling = new System.Windows.Forms.ComboBox();
            this.ddlDienst = new System.Windows.Forms.ComboBox();
            this.tabControl_Aanvraagformulier = new System.Windows.Forms.TabControl();
            this.tabPage_Investering.SuspendLayout();
            this.pnl_Investeringen.SuspendLayout();
            this.gboxInvestering.SuspendLayout();
            this.gboxTitel.SuspendLayout();
            this.gboxPlanning.SuspendLayout();
            this.tabPage_Identificatie.SuspendLayout();
            this.gboxIdentificatie.SuspendLayout();
            this.tabControl_Aanvraagformulier.SuspendLayout();
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
            this.btn_Indienen.Location = new System.Drawing.Point(714, 55);
            this.btn_Indienen.Name = "btn_Indienen";
            this.btn_Indienen.Size = new System.Drawing.Size(103, 37);
            this.btn_Indienen.TabIndex = 15;
            this.btn_Indienen.Text = "Bewaren";
            this.btn_Indienen.UseVisualStyleBackColor = true;
            this.btn_Indienen.Click += new System.EventHandler(this.btn_Indienen_Click);
            // 
            // btn_Nieuw
            // 
            this.btn_Nieuw.Location = new System.Drawing.Point(605, 55);
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
            this.tabPage_Investering.Size = new System.Drawing.Size(791, 558);
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
            this.pnl_Investeringen.Size = new System.Drawing.Size(779, 518);
            this.pnl_Investeringen.TabIndex = 0;
            // 
            // gboxInvestering
            // 
            this.gboxInvestering.Controls.Add(this.gboxPlanning);
            this.gboxInvestering.Controls.Add(this.gboxTitel);
            this.gboxInvestering.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gboxInvestering.Location = new System.Drawing.Point(3, 3);
            this.gboxInvestering.Name = "gboxInvestering";
            this.gboxInvestering.Size = new System.Drawing.Size(752, 674);
            this.gboxInvestering.TabIndex = 21;
            this.gboxInvestering.TabStop = false;
            this.gboxInvestering.Text = "Investering";
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
            this.gboxTitel.Size = new System.Drawing.Size(726, 438);
            this.gboxTitel.TabIndex = 0;
            this.gboxTitel.TabStop = false;
            this.gboxTitel.Text = "Item";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitel.Location = new System.Drawing.Point(30, 30);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(49, 28);
            this.lblTitel.TabIndex = 4;
            this.lblTitel.Text = "Titel";
            // 
            // txtTitel
            // 
            this.txtTitel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitel.Location = new System.Drawing.Point(85, 30);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(630, 34);
            this.txtTitel.TabIndex = 5;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOmschrijving.Location = new System.Drawing.Point(30, 80);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(127, 28);
            this.lblOmschrijving.TabIndex = 6;
            this.lblOmschrijving.Text = "Omschrijving";
            // 
            // rtxtOmschrijving
            // 
            this.rtxtOmschrijving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtOmschrijving.Location = new System.Drawing.Point(170, 71);
            this.rtxtOmschrijving.Name = "rtxtOmschrijving";
            this.rtxtOmschrijving.Size = new System.Drawing.Size(545, 109);
            this.rtxtOmschrijving.TabIndex = 7;
            this.rtxtOmschrijving.Text = "";
            // 
            // lblPrijsindicatie
            // 
            this.lblPrijsindicatie.AutoSize = true;
            this.lblPrijsindicatie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrijsindicatie.Location = new System.Drawing.Point(30, 243);
            this.lblPrijsindicatie.Name = "lblPrijsindicatie";
            this.lblPrijsindicatie.Size = new System.Drawing.Size(197, 28);
            this.lblPrijsindicatie.TabIndex = 8;
            this.lblPrijsindicatie.Text = "Prijsindicatie per stuk";
            // 
            // txtPrijsindicatie
            // 
            this.txtPrijsindicatie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrijsindicatie.Location = new System.Drawing.Point(233, 244);
            this.txtPrijsindicatie.Name = "txtPrijsindicatie";
            this.txtPrijsindicatie.Size = new System.Drawing.Size(151, 34);
            this.txtPrijsindicatie.TabIndex = 9;
            this.txtPrijsindicatie.Leave += new System.EventHandler(this.txtPrijsindicatie_Leave);
            // 
            // lblAantalStuks
            // 
            this.lblAantalStuks.AutoSize = true;
            this.lblAantalStuks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAantalStuks.Location = new System.Drawing.Point(420, 243);
            this.lblAantalStuks.Name = "lblAantalStuks";
            this.lblAantalStuks.Size = new System.Drawing.Size(117, 28);
            this.lblAantalStuks.TabIndex = 10;
            this.lblAantalStuks.Text = "Aantal stuks";
            // 
            // txtAantalStuks
            // 
            this.txtAantalStuks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAantalStuks.Location = new System.Drawing.Point(543, 244);
            this.txtAantalStuks.Name = "txtAantalStuks";
            this.txtAantalStuks.Size = new System.Drawing.Size(172, 34);
            this.txtAantalStuks.TabIndex = 11;
            this.txtAantalStuks.Leave += new System.EventHandler(this.txtAantalStuks_Leave);
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotaal.Location = new System.Drawing.Point(30, 291);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(101, 28);
            this.lblTotaal.TabIndex = 12;
            this.lblTotaal.Text = "Totaalprijs";
            // 
            // txtTotaal
            // 
            this.txtTotaal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotaal.Location = new System.Drawing.Point(150, 285);
            this.txtTotaal.Name = "txtTotaal";
            this.txtTotaal.ReadOnly = true;
            this.txtTotaal.Size = new System.Drawing.Size(151, 34);
            this.txtTotaal.TabIndex = 13;
            // 
            // lblFinaciering
            // 
            this.lblFinaciering.AutoSize = true;
            this.lblFinaciering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinaciering.Location = new System.Drawing.Point(30, 339);
            this.lblFinaciering.Name = "lblFinaciering";
            this.lblFinaciering.Size = new System.Drawing.Size(118, 28);
            this.lblFinaciering.TabIndex = 14;
            this.lblFinaciering.Text = "Financiering";
            // 
            // lblInvestering
            // 
            this.lblInvestering.AutoSize = true;
            this.lblInvestering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInvestering.Location = new System.Drawing.Point(30, 387);
            this.lblInvestering.Name = "lblInvestering";
            this.lblInvestering.Size = new System.Drawing.Size(108, 28);
            this.lblInvestering.TabIndex = 15;
            this.lblInvestering.Text = "Investering";
            // 
            // ddlFinanciering
            // 
            this.ddlFinanciering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFinanciering.FormattingEnabled = true;
            this.ddlFinanciering.Location = new System.Drawing.Point(150, 333);
            this.ddlFinanciering.Name = "ddlFinanciering";
            this.ddlFinanciering.Size = new System.Drawing.Size(282, 36);
            this.ddlFinanciering.TabIndex = 16;
            // 
            // ddlInvestering
            // 
            this.ddlInvestering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlInvestering.FormattingEnabled = true;
            this.ddlInvestering.Location = new System.Drawing.Point(150, 383);
            this.ddlInvestering.Name = "ddlInvestering";
            this.ddlInvestering.Size = new System.Drawing.Size(282, 36);
            this.ddlInvestering.TabIndex = 17;
            // 
            // lblPrioriteit
            // 
            this.lblPrioriteit.AutoSize = true;
            this.lblPrioriteit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrioriteit.Location = new System.Drawing.Point(30, 195);
            this.lblPrioriteit.Name = "lblPrioriteit";
            this.lblPrioriteit.Size = new System.Drawing.Size(81, 28);
            this.lblPrioriteit.TabIndex = 18;
            this.lblPrioriteit.Text = "Pioriteit";
            // 
            // ddlPrioriteit
            // 
            this.ddlPrioriteit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPrioriteit.FormattingEnabled = true;
            this.ddlPrioriteit.Location = new System.Drawing.Point(150, 194);
            this.ddlPrioriteit.Name = "ddlPrioriteit";
            this.ddlPrioriteit.Size = new System.Drawing.Size(282, 36);
            this.ddlPrioriteit.TabIndex = 19;
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
            this.gboxPlanning.Location = new System.Drawing.Point(20, 475);
            this.gboxPlanning.Name = "gboxPlanning";
            this.gboxPlanning.Size = new System.Drawing.Size(732, 194);
            this.gboxPlanning.TabIndex = 3;
            this.gboxPlanning.TabStop = false;
            this.gboxPlanning.Text = "Planning";
            // 
            // lblWieKooptHet
            // 
            this.lblWieKooptHet.AutoSize = true;
            this.lblWieKooptHet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWieKooptHet.Location = new System.Drawing.Point(30, 146);
            this.lblWieKooptHet.Name = "lblWieKooptHet";
            this.lblWieKooptHet.Size = new System.Drawing.Size(137, 28);
            this.lblWieKooptHet.TabIndex = 16;
            this.lblWieKooptHet.Text = "Wie koopt het";
            // 
            // lblKostenplaats
            // 
            this.lblKostenplaats.AutoSize = true;
            this.lblKostenplaats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKostenplaats.Location = new System.Drawing.Point(30, 88);
            this.lblKostenplaats.Name = "lblKostenplaats";
            this.lblKostenplaats.Size = new System.Drawing.Size(124, 28);
            this.lblKostenplaats.TabIndex = 17;
            this.lblKostenplaats.Text = "Kostenplaats";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(30, 30);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(158, 28);
            this.lblFinancieringsjaar.TabIndex = 18;
            this.lblFinancieringsjaar.Text = "Financieringsjaar";
            // 
            // ddlFinancieringsjaar
            // 
            this.ddlFinancieringsjaar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFinancieringsjaar.FormattingEnabled = true;
            this.ddlFinancieringsjaar.Location = new System.Drawing.Point(190, 27);
            this.ddlFinancieringsjaar.Name = "ddlFinancieringsjaar";
            this.ddlFinancieringsjaar.Size = new System.Drawing.Size(282, 36);
            this.ddlFinancieringsjaar.TabIndex = 19;
            // 
            // ddlKostenplaats
            // 
            this.ddlKostenplaats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKostenplaats.FormattingEnabled = true;
            this.ddlKostenplaats.Location = new System.Drawing.Point(190, 82);
            this.ddlKostenplaats.Name = "ddlKostenplaats";
            this.ddlKostenplaats.Size = new System.Drawing.Size(282, 36);
            this.ddlKostenplaats.TabIndex = 20;
            // 
            // ddlWieKooptHet
            // 
            this.ddlWieKooptHet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlWieKooptHet.FormattingEnabled = true;
            this.ddlWieKooptHet.Location = new System.Drawing.Point(190, 137);
            this.ddlWieKooptHet.Name = "ddlWieKooptHet";
            this.ddlWieKooptHet.Size = new System.Drawing.Size(282, 36);
            this.ddlWieKooptHet.TabIndex = 21;
            // 
            // tabPage_Identificatie
            // 
            this.tabPage_Identificatie.Controls.Add(this.gboxIdentificatie);
            this.tabPage_Identificatie.Location = new System.Drawing.Point(4, 37);
            this.tabPage_Identificatie.Name = "tabPage_Identificatie";
            this.tabPage_Identificatie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Identificatie.Size = new System.Drawing.Size(791, 558);
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
            this.gboxIdentificatie.Size = new System.Drawing.Size(758, 190);
            this.gboxIdentificatie.TabIndex = 13;
            this.gboxIdentificatie.TabStop = false;
            this.gboxIdentificatie.Text = "Identificatie";
            // 
            // lblGebruikersNaam
            // 
            this.lblGebruikersNaam.AutoSize = true;
            this.lblGebruikersNaam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGebruikersNaam.Location = new System.Drawing.Point(30, 30);
            this.lblGebruikersNaam.Name = "lblGebruikersNaam";
            this.lblGebruikersNaam.Size = new System.Drawing.Size(154, 28);
            this.lblGebruikersNaam.TabIndex = 3;
            this.lblGebruikersNaam.Text = "Gebruikersnaam";
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.AutoSize = true;
            this.lblAanvraagmoment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAanvraagmoment.Location = new System.Drawing.Point(480, 30);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(71, 28);
            this.lblAanvraagmoment.TabIndex = 4;
            this.lblAanvraagmoment.Text = "Datum";
            // 
            // lblAfdeling
            // 
            this.lblAfdeling.AutoSize = true;
            this.lblAfdeling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAfdeling.Location = new System.Drawing.Point(30, 80);
            this.lblAfdeling.Name = "lblAfdeling";
            this.lblAfdeling.Size = new System.Drawing.Size(86, 28);
            this.lblAfdeling.TabIndex = 5;
            this.lblAfdeling.Text = "Afdeling";
            // 
            // lblDienst
            // 
            this.lblDienst.AutoSize = true;
            this.lblDienst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDienst.Location = new System.Drawing.Point(30, 130);
            this.lblDienst.Name = "lblDienst";
            this.lblDienst.Size = new System.Drawing.Size(67, 28);
            this.lblDienst.TabIndex = 6;
            this.lblDienst.Text = "Dienst";
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGebruiker.Location = new System.Drawing.Point(190, 30);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.ReadOnly = true;
            this.txtGebruiker.Size = new System.Drawing.Size(247, 34);
            this.txtGebruiker.TabIndex = 7;
            // 
            // txtAanvraagmoment
            // 
            this.txtAanvraagmoment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAanvraagmoment.Location = new System.Drawing.Point(560, 30);
            this.txtAanvraagmoment.Name = "txtAanvraagmoment";
            this.txtAanvraagmoment.ReadOnly = true;
            this.txtAanvraagmoment.Size = new System.Drawing.Size(177, 34);
            this.txtAanvraagmoment.TabIndex = 8;
            // 
            // ddlAfdeling
            // 
            this.ddlAfdeling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAfdeling.FormattingEnabled = true;
            this.ddlAfdeling.Location = new System.Drawing.Point(122, 80);
            this.ddlAfdeling.Name = "ddlAfdeling";
            this.ddlAfdeling.Size = new System.Drawing.Size(282, 36);
            this.ddlAfdeling.TabIndex = 9;
            // 
            // ddlDienst
            // 
            this.ddlDienst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDienst.FormattingEnabled = true;
            this.ddlDienst.Location = new System.Drawing.Point(122, 127);
            this.ddlDienst.Name = "ddlDienst";
            this.ddlDienst.Size = new System.Drawing.Size(282, 36);
            this.ddlDienst.TabIndex = 10;
            // 
            // tabControl_Aanvraagformulier
            // 
            this.tabControl_Aanvraagformulier.Controls.Add(this.tabPage_Identificatie);
            this.tabControl_Aanvraagformulier.Controls.Add(this.tabPage_Investering);
            this.tabControl_Aanvraagformulier.Location = new System.Drawing.Point(22, 95);
            this.tabControl_Aanvraagformulier.Name = "tabControl_Aanvraagformulier";
            this.tabControl_Aanvraagformulier.SelectedIndex = 0;
            this.tabControl_Aanvraagformulier.Size = new System.Drawing.Size(799, 599);
            this.tabControl_Aanvraagformulier.TabIndex = 14;
            // 
            // frmAanvraagFormulier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(832, 717);
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
            this.Text = "frmAanvraagFormulier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAanvraagFormulier_FormClosing);
            this.tabPage_Investering.ResumeLayout(false);
            this.pnl_Investeringen.ResumeLayout(false);
            this.gboxInvestering.ResumeLayout(false);
            this.gboxTitel.ResumeLayout(false);
            this.gboxTitel.PerformLayout();
            this.gboxPlanning.ResumeLayout(false);
            this.gboxPlanning.PerformLayout();
            this.tabPage_Identificatie.ResumeLayout(false);
            this.gboxIdentificatie.ResumeLayout(false);
            this.gboxIdentificatie.PerformLayout();
            this.tabControl_Aanvraagformulier.ResumeLayout(false);
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
    }
}