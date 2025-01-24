namespace MiaClient
{
    partial class frmGoedkeuring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoedkeuring));
            this.pnlGoedkeuringen = new System.Windows.Forms.Panel();
            this.GoedkeuringFinancieringsjaar = new System.Windows.Forms.Label();
            this.btnSortBedrag = new System.Windows.Forms.Button();
            this.btnSortFinancieringsjaar = new System.Windows.Forms.Button();
            this.btnSortAanvraagmoment = new System.Windows.Forms.Button();
            this.btnSortTitel = new System.Windows.Forms.Button();
            this.GoedkeuringAanvraagmoment = new System.Windows.Forms.Label();
            this.GoedkeuringBedrag = new System.Windows.Forms.Label();
            this.GoedkeuringTitel = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSortGebruiker = new System.Windows.Forms.Button();
            this.GoedkeuringGebruiker = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.grbxFilterAanvraag = new System.Windows.Forms.GroupBox();
            this.pcbNietBekrachtigd = new System.Windows.Forms.PictureBox();
            this.pcbBekrachtigd = new System.Windows.Forms.PictureBox();
            this.pcbAfgekeurd = new System.Windows.Forms.PictureBox();
            this.pcbGoedgekeurd = new System.Windows.Forms.PictureBox();
            this.pcbInAanvraag = new System.Windows.Forms.PictureBox();
            this.cbBedragTot = new System.Windows.Forms.CheckBox();
            this.txtBedragTot = new System.Windows.Forms.TextBox();
            this.cbBedragVan = new System.Windows.Forms.CheckBox();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.txtBedragVan = new System.Windows.Forms.TextBox();
            this.dtpAanvraagmomentTot = new System.Windows.Forms.DateTimePicker();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.txtFinancieringsjaar = new System.Windows.Forms.TextBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.dtpAanvraagmomentVan = new System.Windows.Forms.DateTimePicker();
            this.chbxAanvraagmomentTot = new System.Windows.Forms.CheckBox();
            this.lblAanvraagmoment = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.chbxAanvraagmomentVan = new System.Windows.Forms.CheckBox();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbxFilterAanvraag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNietBekrachtigd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBekrachtigd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAfgekeurd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGoedgekeurd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInAanvraag)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGoedkeuringen
            // 
            this.pnlGoedkeuringen.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlGoedkeuringen.Location = new System.Drawing.Point(101, 332);
            this.pnlGoedkeuringen.Name = "pnlGoedkeuringen";
            this.pnlGoedkeuringen.Size = new System.Drawing.Size(1210, 413);
            this.pnlGoedkeuringen.TabIndex = 0;
            // 
            // GoedkeuringFinancieringsjaar
            // 
            this.GoedkeuringFinancieringsjaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GoedkeuringFinancieringsjaar.Location = new System.Drawing.Point(865, 293);
            this.GoedkeuringFinancieringsjaar.Name = "GoedkeuringFinancieringsjaar";
            this.GoedkeuringFinancieringsjaar.Size = new System.Drawing.Size(219, 29);
            this.GoedkeuringFinancieringsjaar.TabIndex = 59;
            this.GoedkeuringFinancieringsjaar.Text = "Financieringsingsjaar";
            this.GoedkeuringFinancieringsjaar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSortBedrag
            // 
            this.btnSortBedrag.BackColor = System.Drawing.Color.Transparent;
            this.btnSortBedrag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortBedrag.FlatAppearance.BorderSize = 0;
            this.btnSortBedrag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortBedrag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortBedrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSortBedrag.Image = ((System.Drawing.Image)(resources.GetObject("btnSortBedrag.Image")));
            this.btnSortBedrag.Location = new System.Drawing.Point(1206, 289);
            this.btnSortBedrag.Name = "btnSortBedrag";
            this.btnSortBedrag.Size = new System.Drawing.Size(27, 27);
            this.btnSortBedrag.TabIndex = 56;
            this.btnSortBedrag.UseVisualStyleBackColor = false;
            this.btnSortBedrag.Click += new System.EventHandler(this.btnSortBedrag_Click);
            // 
            // btnSortFinancieringsjaar
            // 
            this.btnSortFinancieringsjaar.BackColor = System.Drawing.Color.Transparent;
            this.btnSortFinancieringsjaar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortFinancieringsjaar.FlatAppearance.BorderSize = 0;
            this.btnSortFinancieringsjaar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortFinancieringsjaar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortFinancieringsjaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortFinancieringsjaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSortFinancieringsjaar.Image = ((System.Drawing.Image)(resources.GetObject("btnSortFinancieringsjaar.Image")));
            this.btnSortFinancieringsjaar.Location = new System.Drawing.Point(1081, 289);
            this.btnSortFinancieringsjaar.Name = "btnSortFinancieringsjaar";
            this.btnSortFinancieringsjaar.Size = new System.Drawing.Size(27, 27);
            this.btnSortFinancieringsjaar.TabIndex = 54;
            this.btnSortFinancieringsjaar.UseVisualStyleBackColor = false;
            this.btnSortFinancieringsjaar.Click += new System.EventHandler(this.btnSortFinancieringsjaar_Click);
            // 
            // btnSortAanvraagmoment
            // 
            this.btnSortAanvraagmoment.BackColor = System.Drawing.Color.Transparent;
            this.btnSortAanvraagmoment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortAanvraagmoment.FlatAppearance.BorderSize = 0;
            this.btnSortAanvraagmoment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortAanvraagmoment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortAanvraagmoment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAanvraagmoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSortAanvraagmoment.Image = ((System.Drawing.Image)(resources.GetObject("btnSortAanvraagmoment.Image")));
            this.btnSortAanvraagmoment.Location = new System.Drawing.Point(820, 289);
            this.btnSortAanvraagmoment.Name = "btnSortAanvraagmoment";
            this.btnSortAanvraagmoment.Size = new System.Drawing.Size(27, 27);
            this.btnSortAanvraagmoment.TabIndex = 52;
            this.btnSortAanvraagmoment.UseVisualStyleBackColor = false;
            this.btnSortAanvraagmoment.Click += new System.EventHandler(this.btnSortAanvraagmoment_Click);
            // 
            // btnSortTitel
            // 
            this.btnSortTitel.BackColor = System.Drawing.Color.Transparent;
            this.btnSortTitel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortTitel.FlatAppearance.BorderSize = 0;
            this.btnSortTitel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortTitel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortTitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSortTitel.Image = ((System.Drawing.Image)(resources.GetObject("btnSortTitel.Image")));
            this.btnSortTitel.Location = new System.Drawing.Point(461, 289);
            this.btnSortTitel.Name = "btnSortTitel";
            this.btnSortTitel.Size = new System.Drawing.Size(27, 27);
            this.btnSortTitel.TabIndex = 51;
            this.btnSortTitel.UseVisualStyleBackColor = false;
            this.btnSortTitel.Click += new System.EventHandler(this.btnSortTitel_Click);
            // 
            // GoedkeuringAanvraagmoment
            // 
            this.GoedkeuringAanvraagmoment.AutoSize = true;
            this.GoedkeuringAanvraagmoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GoedkeuringAanvraagmoment.Location = new System.Drawing.Point(647, 295);
            this.GoedkeuringAanvraagmoment.Name = "GoedkeuringAanvraagmoment";
            this.GoedkeuringAanvraagmoment.Size = new System.Drawing.Size(167, 25);
            this.GoedkeuringAanvraagmoment.TabIndex = 45;
            this.GoedkeuringAanvraagmoment.Text = "Aanvraagmoment";
            // 
            // GoedkeuringBedrag
            // 
            this.GoedkeuringBedrag.AutoSize = true;
            this.GoedkeuringBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GoedkeuringBedrag.Location = new System.Drawing.Point(1125, 295);
            this.GoedkeuringBedrag.Name = "GoedkeuringBedrag";
            this.GoedkeuringBedrag.Size = new System.Drawing.Size(75, 25);
            this.GoedkeuringBedrag.TabIndex = 48;
            this.GoedkeuringBedrag.Text = "Bedrag";
            // 
            // GoedkeuringTitel
            // 
            this.GoedkeuringTitel.AutoSize = true;
            this.GoedkeuringTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GoedkeuringTitel.Location = new System.Drawing.Point(406, 295);
            this.GoedkeuringTitel.Name = "GoedkeuringTitel";
            this.GoedkeuringTitel.Size = new System.Drawing.Size(49, 25);
            this.GoedkeuringTitel.TabIndex = 44;
            this.GoedkeuringTitel.Text = "Titel";
            // 
            // lblPages
            // 
            this.lblPages.Location = new System.Drawing.Point(184, 766);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(1156, 30);
            this.lblPages.TabIndex = 64;
            this.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(1346, 766);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 62;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(1382, 766);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 30);
            this.btnLast.TabIndex = 63;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(148, 766);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 61;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(112, 766);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 30);
            this.btnFirst.TabIndex = 60;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSortGebruiker
            // 
            this.btnSortGebruiker.BackColor = System.Drawing.Color.Transparent;
            this.btnSortGebruiker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortGebruiker.FlatAppearance.BorderSize = 0;
            this.btnSortGebruiker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortGebruiker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortGebruiker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortGebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSortGebruiker.Image = ((System.Drawing.Image)(resources.GetObject("btnSortGebruiker.Image")));
            this.btnSortGebruiker.Location = new System.Drawing.Point(352, 289);
            this.btnSortGebruiker.Name = "btnSortGebruiker";
            this.btnSortGebruiker.Size = new System.Drawing.Size(27, 27);
            this.btnSortGebruiker.TabIndex = 53;
            this.btnSortGebruiker.UseVisualStyleBackColor = false;
            this.btnSortGebruiker.Click += new System.EventHandler(this.btnSortGebruiker_Click);
            // 
            // GoedkeuringGebruiker
            // 
            this.GoedkeuringGebruiker.AutoSize = true;
            this.GoedkeuringGebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GoedkeuringGebruiker.Location = new System.Drawing.Point(249, 295);
            this.GoedkeuringGebruiker.Name = "GoedkeuringGebruiker";
            this.GoedkeuringGebruiker.Size = new System.Drawing.Size(97, 25);
            this.GoedkeuringGebruiker.TabIndex = 43;
            this.GoedkeuringGebruiker.Text = "Gebruiker";
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(12, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(73, 73);
            this.btnFilter.TabIndex = 66;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // grbxFilterAanvraag
            // 
            this.grbxFilterAanvraag.Controls.Add(this.cbBedragTot);
            this.grbxFilterAanvraag.Controls.Add(this.txtBedragTot);
            this.grbxFilterAanvraag.Controls.Add(this.cbBedragVan);
            this.grbxFilterAanvraag.Controls.Add(this.txtGebruiker);
            this.grbxFilterAanvraag.Controls.Add(this.txtBedragVan);
            this.grbxFilterAanvraag.Controls.Add(this.dtpAanvraagmomentTot);
            this.grbxFilterAanvraag.Controls.Add(this.lblBedrag);
            this.grbxFilterAanvraag.Controls.Add(this.txtFinancieringsjaar);
            this.grbxFilterAanvraag.Controls.Add(this.lblFinancieringsjaar);
            this.grbxFilterAanvraag.Controls.Add(this.dtpAanvraagmomentVan);
            this.grbxFilterAanvraag.Controls.Add(this.chbxAanvraagmomentTot);
            this.grbxFilterAanvraag.Controls.Add(this.lblAanvraagmoment);
            this.grbxFilterAanvraag.Controls.Add(this.txtTitel);
            this.grbxFilterAanvraag.Controls.Add(this.lblTitel);
            this.grbxFilterAanvraag.Controls.Add(this.chbxAanvraagmomentVan);
            this.grbxFilterAanvraag.Controls.Add(this.lblGebruiker);
            this.grbxFilterAanvraag.Location = new System.Drawing.Point(101, 46);
            this.grbxFilterAanvraag.Name = "grbxFilterAanvraag";
            this.grbxFilterAanvraag.Size = new System.Drawing.Size(634, 213);
            this.grbxFilterAanvraag.TabIndex = 65;
            this.grbxFilterAanvraag.TabStop = false;
            this.grbxFilterAanvraag.Text = "Filter";
            // 
            // pcbNietBekrachtigd
            // 
            this.pcbNietBekrachtigd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbNietBekrachtigd.Image = ((System.Drawing.Image)(resources.GetObject("pcbNietBekrachtigd.Image")));
            this.pcbNietBekrachtigd.Location = new System.Drawing.Point(1152, 144);
            this.pcbNietBekrachtigd.Name = "pcbNietBekrachtigd";
            this.pcbNietBekrachtigd.Size = new System.Drawing.Size(55, 55);
            this.pcbNietBekrachtigd.TabIndex = 31;
            this.pcbNietBekrachtigd.TabStop = false;
            this.pcbNietBekrachtigd.Click += new System.EventHandler(this.pcbNietBekrachtigd_Click);
            // 
            // pcbBekrachtigd
            // 
            this.pcbBekrachtigd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbBekrachtigd.Image = ((System.Drawing.Image)(resources.GetObject("pcbBekrachtigd.Image")));
            this.pcbBekrachtigd.Location = new System.Drawing.Point(1062, 144);
            this.pcbBekrachtigd.Name = "pcbBekrachtigd";
            this.pcbBekrachtigd.Size = new System.Drawing.Size(55, 55);
            this.pcbBekrachtigd.TabIndex = 30;
            this.pcbBekrachtigd.TabStop = false;
            this.pcbBekrachtigd.Click += new System.EventHandler(this.pcbBekrachtigd_Click);
            // 
            // pcbAfgekeurd
            // 
            this.pcbAfgekeurd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbAfgekeurd.Image = ((System.Drawing.Image)(resources.GetObject("pcbAfgekeurd.Image")));
            this.pcbAfgekeurd.Location = new System.Drawing.Point(957, 144);
            this.pcbAfgekeurd.Name = "pcbAfgekeurd";
            this.pcbAfgekeurd.Size = new System.Drawing.Size(55, 55);
            this.pcbAfgekeurd.TabIndex = 29;
            this.pcbAfgekeurd.TabStop = false;
            this.pcbAfgekeurd.Click += new System.EventHandler(this.pcbAfgekeurd_Click);
            // 
            // pcbGoedgekeurd
            // 
            this.pcbGoedgekeurd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbGoedgekeurd.Image = ((System.Drawing.Image)(resources.GetObject("pcbGoedgekeurd.Image")));
            this.pcbGoedgekeurd.Location = new System.Drawing.Point(860, 144);
            this.pcbGoedgekeurd.Name = "pcbGoedgekeurd";
            this.pcbGoedgekeurd.Size = new System.Drawing.Size(55, 55);
            this.pcbGoedgekeurd.TabIndex = 28;
            this.pcbGoedgekeurd.TabStop = false;
            this.pcbGoedgekeurd.Click += new System.EventHandler(this.pcbGoedgekeurd_Click);
            // 
            // pcbInAanvraag
            // 
            this.pcbInAanvraag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbInAanvraag.Image = ((System.Drawing.Image)(resources.GetObject("pcbInAanvraag.Image")));
            this.pcbInAanvraag.Location = new System.Drawing.Point(759, 144);
            this.pcbInAanvraag.Name = "pcbInAanvraag";
            this.pcbInAanvraag.Size = new System.Drawing.Size(55, 55);
            this.pcbInAanvraag.TabIndex = 27;
            this.pcbInAanvraag.TabStop = false;
            this.pcbInAanvraag.Click += new System.EventHandler(this.pcbInAanvraag_Click);
            // 
            // cbBedragTot
            // 
            this.cbBedragTot.AutoSize = true;
            this.cbBedragTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbBedragTot.Location = new System.Drawing.Point(324, 169);
            this.cbBedragTot.Name = "cbBedragTot";
            this.cbBedragTot.Size = new System.Drawing.Size(52, 22);
            this.cbBedragTot.TabIndex = 21;
            this.cbBedragTot.Text = "Tot";
            this.cbBedragTot.UseVisualStyleBackColor = true;
            // 
            // txtBedragTot
            // 
            this.txtBedragTot.Location = new System.Drawing.Point(396, 168);
            this.txtBedragTot.Name = "txtBedragTot";
            this.txtBedragTot.Size = new System.Drawing.Size(66, 22);
            this.txtBedragTot.TabIndex = 26;
            // 
            // cbBedragVan
            // 
            this.cbBedragVan.AutoSize = true;
            this.cbBedragVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cbBedragVan.Location = new System.Drawing.Point(324, 131);
            this.cbBedragVan.Name = "cbBedragVan";
            this.cbBedragVan.Size = new System.Drawing.Size(55, 22);
            this.cbBedragVan.TabIndex = 5;
            this.cbBedragVan.Text = "Van";
            this.cbBedragVan.UseVisualStyleBackColor = true;
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.Location = new System.Drawing.Point(11, 58);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.Size = new System.Drawing.Size(272, 22);
            this.txtGebruiker.TabIndex = 25;
            // 
            // txtBedragVan
            // 
            this.txtBedragVan.Location = new System.Drawing.Point(396, 129);
            this.txtBedragVan.Name = "txtBedragVan";
            this.txtBedragVan.Size = new System.Drawing.Size(66, 22);
            this.txtBedragVan.TabIndex = 17;
            // 
            // dtpAanvraagmomentTot
            // 
            this.dtpAanvraagmomentTot.Location = new System.Drawing.Point(83, 170);
            this.dtpAanvraagmomentTot.Name = "dtpAanvraagmomentTot";
            this.dtpAanvraagmomentTot.Size = new System.Drawing.Size(200, 22);
            this.dtpAanvraagmomentTot.TabIndex = 22;
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBedrag.Location = new System.Drawing.Point(324, 98);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(63, 20);
            this.lblBedrag.TabIndex = 8;
            this.lblBedrag.Text = "Bedrag";
            // 
            // txtFinancieringsjaar
            // 
            this.txtFinancieringsjaar.Location = new System.Drawing.Point(486, 160);
            this.txtFinancieringsjaar.Name = "txtFinancieringsjaar";
            this.txtFinancieringsjaar.Size = new System.Drawing.Size(132, 22);
            this.txtFinancieringsjaar.TabIndex = 15;
            this.txtFinancieringsjaar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(481, 129);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(137, 20);
            this.lblFinancieringsjaar.TabIndex = 7;
            this.lblFinancieringsjaar.Text = "Financieringsjaar";
            // 
            // dtpAanvraagmomentVan
            // 
            this.dtpAanvraagmomentVan.Location = new System.Drawing.Point(83, 129);
            this.dtpAanvraagmomentVan.Name = "dtpAanvraagmomentVan";
            this.dtpAanvraagmomentVan.Size = new System.Drawing.Size(200, 22);
            this.dtpAanvraagmomentVan.TabIndex = 21;
            // 
            // chbxAanvraagmomentTot
            // 
            this.chbxAanvraagmomentTot.AutoSize = true;
            this.chbxAanvraagmomentTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbxAanvraagmomentTot.Location = new System.Drawing.Point(11, 172);
            this.chbxAanvraagmomentTot.Name = "chbxAanvraagmomentTot";
            this.chbxAanvraagmomentTot.Size = new System.Drawing.Size(52, 22);
            this.chbxAanvraagmomentTot.TabIndex = 19;
            this.chbxAanvraagmomentTot.Text = "Tot";
            this.chbxAanvraagmomentTot.UseVisualStyleBackColor = true;
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.AutoSize = true;
            this.lblAanvraagmoment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAanvraagmoment.Location = new System.Drawing.Point(6, 98);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(139, 20);
            this.lblAanvraagmoment.TabIndex = 18;
            this.lblAanvraagmoment.Text = "Aanvraagmoment";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(325, 58);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(293, 22);
            this.txtTitel.TabIndex = 13;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTitel.Location = new System.Drawing.Point(320, 27);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(41, 20);
            this.lblTitel.TabIndex = 9;
            this.lblTitel.Text = "Titel";
            // 
            // chbxAanvraagmomentVan
            // 
            this.chbxAanvraagmomentVan.AutoSize = true;
            this.chbxAanvraagmomentVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chbxAanvraagmomentVan.Location = new System.Drawing.Point(12, 129);
            this.chbxAanvraagmomentVan.Name = "chbxAanvraagmomentVan";
            this.chbxAanvraagmomentVan.Size = new System.Drawing.Size(55, 22);
            this.chbxAanvraagmomentVan.TabIndex = 3;
            this.chbxAanvraagmomentVan.Text = "Van";
            this.chbxAanvraagmomentVan.UseVisualStyleBackColor = true;
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGebruiker.Location = new System.Drawing.Point(7, 30);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(82, 20);
            this.lblGebruiker.TabIndex = 1;
            this.lblGebruiker.Text = "Gebruiker";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(860, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(257, 23);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Bewaar Status";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmGoedkeuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 836);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pcbNietBekrachtigd);
            this.Controls.Add(this.pcbGoedgekeurd);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.pcbBekrachtigd);
            this.Controls.Add(this.grbxFilterAanvraag);
            this.Controls.Add(this.pcbInAanvraag);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.pcbAfgekeurd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.GoedkeuringFinancieringsjaar);
            this.Controls.Add(this.pnlGoedkeuringen);
            this.Controls.Add(this.GoedkeuringGebruiker);
            this.Controls.Add(this.GoedkeuringTitel);
            this.Controls.Add(this.btnSortBedrag);
            this.Controls.Add(this.btnSortFinancieringsjaar);
            this.Controls.Add(this.GoedkeuringBedrag);
            this.Controls.Add(this.btnSortGebruiker);
            this.Controls.Add(this.btnSortAanvraagmoment);
            this.Controls.Add(this.GoedkeuringAanvraagmoment);
            this.Controls.Add(this.btnSortTitel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmGoedkeuring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Goedkeuringen";
            this.Activated += new System.EventHandler(this.frmGoedkeuring_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoedkeuring_FormClosing);
            this.Load += new System.EventHandler(this.frmGoedkeuring_Load);
            this.Shown += new System.EventHandler(this.FrmGoedkeuring_Shown);
            this.grbxFilterAanvraag.ResumeLayout(false);
            this.grbxFilterAanvraag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNietBekrachtigd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBekrachtigd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAfgekeurd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGoedgekeurd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbInAanvraag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGoedkeuringen;
        private System.Windows.Forms.Label GoedkeuringFinancieringsjaar;
        private System.Windows.Forms.Button btnSortBedrag;
        private System.Windows.Forms.Button btnSortFinancieringsjaar;
        private System.Windows.Forms.Button btnSortAanvraagmoment;
        private System.Windows.Forms.Button btnSortTitel;
        private System.Windows.Forms.Label GoedkeuringAanvraagmoment;
        private System.Windows.Forms.Label GoedkeuringBedrag;
        private System.Windows.Forms.Label GoedkeuringTitel;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSortGebruiker;
        private System.Windows.Forms.Label GoedkeuringGebruiker;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox grbxFilterAanvraag;
        private System.Windows.Forms.CheckBox cbBedragTot;
        private System.Windows.Forms.TextBox txtBedragTot;
        private System.Windows.Forms.CheckBox cbBedragVan;
        private System.Windows.Forms.TextBox txtGebruiker;
        private System.Windows.Forms.TextBox txtBedragVan;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.TextBox txtFinancieringsjaar;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.CheckBox chbxAanvraagmomentTot;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.CheckBox chbxAanvraagmomentVan;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.DateTimePicker dtpAanvraagmomentTot;
        private System.Windows.Forms.DateTimePicker dtpAanvraagmomentVan;
        private System.Windows.Forms.Label lblAanvraagmoment;
        private System.Windows.Forms.PictureBox pcbAfgekeurd;
        private System.Windows.Forms.PictureBox pcbGoedgekeurd;
        private System.Windows.Forms.PictureBox pcbInAanvraag;
        private System.Windows.Forms.PictureBox pcbNietBekrachtigd;
        private System.Windows.Forms.PictureBox pcbBekrachtigd;
        private System.Windows.Forms.Button btnSave;
    }
}