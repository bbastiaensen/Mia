namespace MiaClient
{
    partial class frmAankopen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAankopen));
            this.cmbFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.gbxFinancieringsjaar = new System.Windows.Forms.GroupBox();
            this.lblWachtenExcelAankopen = new System.Windows.Forms.Label();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.grbxFilterAanvraag = new System.Windows.Forms.GroupBox();
            this.cbBedragTot = new System.Windows.Forms.CheckBox();
            this.txtBedragTot = new System.Windows.Forms.TextBox();
            this.cbBedragVan = new System.Windows.Forms.CheckBox();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.txtBedragVan = new System.Windows.Forms.TextBox();
            this.dtpPlanningsdatumTot = new System.Windows.Forms.DateTimePicker();
            this.dtpPlanningsdatumVan = new System.Windows.Forms.DateTimePicker();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.chbxPlaningsdatumVan = new System.Windows.Forms.CheckBox();
            this.chbxPlaningsdatumTot = new System.Windows.Forms.CheckBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.lblPlanningsdatum = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblAanvrager = new System.Windows.Forms.Label();
            this.pnlAanvragen = new System.Windows.Forms.Panel();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSortAanvrager = new System.Windows.Forms.Button();
            this.btnSortTitel = new System.Windows.Forms.Button();
            this.btnBedrag = new System.Windows.Forms.Button();
            this.btnSortRichtperiode = new System.Windows.Forms.Button();
            this.btnTesten = new System.Windows.Forms.Button();
            this.gbxFinancieringsjaar.SuspendLayout();
            this.grbxFilterAanvraag.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFinancieringsjaar
            // 
            this.cmbFinancieringsjaar.FormattingEnabled = true;
            this.cmbFinancieringsjaar.Location = new System.Drawing.Point(143, 84);
            this.cmbFinancieringsjaar.Name = "cmbFinancieringsjaar";
            this.cmbFinancieringsjaar.Size = new System.Drawing.Size(253, 33);
            this.cmbFinancieringsjaar.TabIndex = 2;
            this.cmbFinancieringsjaar.SelectedIndexChanged += new System.EventHandler(this.cmbFinancieringsjaar_SelectedIndexChanged);
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(6, 87);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(156, 25);
            this.lblFinancieringsjaar.TabIndex = 1;
            this.lblFinancieringsjaar.Text = "Financieringsjaar : ";
            // 
            // gbxFinancieringsjaar
            // 
            this.gbxFinancieringsjaar.Controls.Add(this.btnTesten);
            this.gbxFinancieringsjaar.Controls.Add(this.lblWachtenExcelAankopen);
            this.gbxFinancieringsjaar.Controls.Add(this.btnExportToExcel);
            this.gbxFinancieringsjaar.Controls.Add(this.btnFilter);
            this.gbxFinancieringsjaar.Controls.Add(this.cmbFinancieringsjaar);
            this.gbxFinancieringsjaar.Controls.Add(this.grbxFilterAanvraag);
            this.gbxFinancieringsjaar.Controls.Add(this.lblFinancieringsjaar);
            this.gbxFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFinancieringsjaar.Location = new System.Drawing.Point(12, 12);
            this.gbxFinancieringsjaar.Name = "gbxFinancieringsjaar";
            this.gbxFinancieringsjaar.Size = new System.Drawing.Size(1043, 233);
            this.gbxFinancieringsjaar.TabIndex = 1;
            this.gbxFinancieringsjaar.TabStop = false;
            this.gbxFinancieringsjaar.Text = "selecteer een richtperiode";
            // 
            // lblWachtenExcelAankopen
            // 
            this.lblWachtenExcelAankopen.AutoSize = true;
            this.lblWachtenExcelAankopen.Location = new System.Drawing.Point(755, 8);
            this.lblWachtenExcelAankopen.Name = "lblWachtenExcelAankopen";
            this.lblWachtenExcelAankopen.Size = new System.Drawing.Size(0, 25);
            this.lblWachtenExcelAankopen.TabIndex = 45;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExportToExcel.FlatAppearance.BorderSize = 0;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportToExcel.Location = new System.Drawing.Point(930, 0);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExportToExcel.TabIndex = 44;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(356, 26);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(40, 40);
            this.btnFilter.TabIndex = 28;
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
            this.grbxFilterAanvraag.Controls.Add(this.dtpPlanningsdatumTot);
            this.grbxFilterAanvraag.Controls.Add(this.dtpPlanningsdatumVan);
            this.grbxFilterAanvraag.Controls.Add(this.lblBedrag);
            this.grbxFilterAanvraag.Controls.Add(this.chbxPlaningsdatumVan);
            this.grbxFilterAanvraag.Controls.Add(this.chbxPlaningsdatumTot);
            this.grbxFilterAanvraag.Controls.Add(this.txtTitel);
            this.grbxFilterAanvraag.Controls.Add(this.lblPlanningsdatum);
            this.grbxFilterAanvraag.Controls.Add(this.lblTitel);
            this.grbxFilterAanvraag.Controls.Add(this.lblAanvrager);
            this.grbxFilterAanvraag.Location = new System.Drawing.Point(402, 26);
            this.grbxFilterAanvraag.Name = "grbxFilterAanvraag";
            this.grbxFilterAanvraag.Size = new System.Drawing.Size(625, 213);
            this.grbxFilterAanvraag.TabIndex = 2;
            this.grbxFilterAanvraag.TabStop = false;
            this.grbxFilterAanvraag.Text = "Filter";
            // 
            // cbBedragTot
            // 
            this.cbBedragTot.AutoSize = true;
            this.cbBedragTot.Location = new System.Drawing.Point(337, 168);
            this.cbBedragTot.Name = "cbBedragTot";
            this.cbBedragTot.Size = new System.Drawing.Size(58, 29);
            this.cbBedragTot.TabIndex = 21;
            this.cbBedragTot.Text = "Tot";
            this.cbBedragTot.UseVisualStyleBackColor = true;
            // 
            // txtBedragTot
            // 
            this.txtBedragTot.Location = new System.Drawing.Point(409, 167);
            this.txtBedragTot.Name = "txtBedragTot";
            this.txtBedragTot.Size = new System.Drawing.Size(200, 31);
            this.txtBedragTot.TabIndex = 26;
            // 
            // cbBedragVan
            // 
            this.cbBedragVan.AutoSize = true;
            this.cbBedragVan.Location = new System.Drawing.Point(337, 130);
            this.cbBedragVan.Name = "cbBedragVan";
            this.cbBedragVan.Size = new System.Drawing.Size(63, 29);
            this.cbBedragVan.TabIndex = 5;
            this.cbBedragVan.Text = "Van";
            this.cbBedragVan.UseVisualStyleBackColor = true;
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.Location = new System.Drawing.Point(11, 58);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.Size = new System.Drawing.Size(272, 31);
            this.txtGebruiker.TabIndex = 25;
            // 
            // txtBedragVan
            // 
            this.txtBedragVan.Location = new System.Drawing.Point(409, 128);
            this.txtBedragVan.Name = "txtBedragVan";
            this.txtBedragVan.Size = new System.Drawing.Size(200, 31);
            this.txtBedragVan.TabIndex = 17;
            // 
            // dtpPlanningsdatumTot
            // 
            this.dtpPlanningsdatumTot.Location = new System.Drawing.Point(88, 169);
            this.dtpPlanningsdatumTot.Name = "dtpPlanningsdatumTot";
            this.dtpPlanningsdatumTot.Size = new System.Drawing.Size(200, 31);
            this.dtpPlanningsdatumTot.TabIndex = 24;
            // 
            // dtpPlanningsdatumVan
            // 
            this.dtpPlanningsdatumVan.Location = new System.Drawing.Point(88, 128);
            this.dtpPlanningsdatumVan.Name = "dtpPlanningsdatumVan";
            this.dtpPlanningsdatumVan.Size = new System.Drawing.Size(200, 31);
            this.dtpPlanningsdatumVan.TabIndex = 23;
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(337, 97);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(68, 25);
            this.lblBedrag.TabIndex = 8;
            this.lblBedrag.Text = "Bedrag";
            // 
            // chbxPlaningsdatumVan
            // 
            this.chbxPlaningsdatumVan.AutoSize = true;
            this.chbxPlaningsdatumVan.Location = new System.Drawing.Point(11, 132);
            this.chbxPlaningsdatumVan.Name = "chbxPlaningsdatumVan";
            this.chbxPlaningsdatumVan.Size = new System.Drawing.Size(63, 29);
            this.chbxPlaningsdatumVan.TabIndex = 4;
            this.chbxPlaningsdatumVan.Text = "Van";
            this.chbxPlaningsdatumVan.UseVisualStyleBackColor = true;
            // 
            // chbxPlaningsdatumTot
            // 
            this.chbxPlaningsdatumTot.AutoSize = true;
            this.chbxPlaningsdatumTot.Location = new System.Drawing.Point(11, 174);
            this.chbxPlaningsdatumTot.Name = "chbxPlaningsdatumTot";
            this.chbxPlaningsdatumTot.Size = new System.Drawing.Size(58, 29);
            this.chbxPlaningsdatumTot.TabIndex = 20;
            this.chbxPlaningsdatumTot.Text = "Tot";
            this.chbxPlaningsdatumTot.UseVisualStyleBackColor = true;
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(337, 58);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(272, 31);
            this.txtTitel.TabIndex = 13;
            // 
            // lblPlanningsdatum
            // 
            this.lblPlanningsdatum.AutoSize = true;
            this.lblPlanningsdatum.Location = new System.Drawing.Point(11, 97);
            this.lblPlanningsdatum.Name = "lblPlanningsdatum";
            this.lblPlanningsdatum.Size = new System.Drawing.Size(140, 25);
            this.lblPlanningsdatum.TabIndex = 11;
            this.lblPlanningsdatum.Text = "Planningsdatum";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(333, 30);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(44, 25);
            this.lblTitel.TabIndex = 9;
            this.lblTitel.Text = "Titel";
            // 
            // lblAanvrager
            // 
            this.lblAanvrager.AutoSize = true;
            this.lblAanvrager.Location = new System.Drawing.Point(7, 30);
            this.lblAanvrager.Name = "lblAanvrager";
            this.lblAanvrager.Size = new System.Drawing.Size(93, 25);
            this.lblAanvrager.TabIndex = 1;
            this.lblAanvrager.Text = "Aanvrager";
            // 
            // pnlAanvragen
            // 
            this.pnlAanvragen.Location = new System.Drawing.Point(12, 278);
            this.pnlAanvragen.Name = "pnlAanvragen";
            this.pnlAanvragen.Size = new System.Drawing.Size(1043, 339);
            this.pnlAanvragen.TabIndex = 2;
            // 
            // lblPages
            // 
            this.lblPages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(258, 620);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(551, 47);
            this.lblPages.TabIndex = 0;
            this.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(942, 629);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnLast_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Transparent;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(991, 629);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 30);
            this.btnLast.TabIndex = 4;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            this.btnLast.MouseLeave += new System.EventHandler(this.btnLast_MouseLeave);
            this.btnLast.MouseHover += new System.EventHandler(this.btnLast_MouseHover);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Transparent;
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirst.Location = new System.Drawing.Point(34, 629);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 30);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            this.btnFirst.MouseLeave += new System.EventHandler(this.btnFirst_MouseLeave);
            this.btnFirst.MouseHover += new System.EventHandler(this.btnFirst_MouseHover);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrevious.Location = new System.Drawing.Point(81, 629);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnPrevious_MouseLeave);
            this.btnPrevious.MouseHover += new System.EventHandler(this.btnPrevious_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "TITEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "BEDRAG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "AANVRAGER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(886, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "RICHTPERIODE";
            // 
            // btnSortAanvrager
            // 
            this.btnSortAanvrager.BackColor = System.Drawing.Color.Transparent;
            this.btnSortAanvrager.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortAanvrager.FlatAppearance.BorderSize = 0;
            this.btnSortAanvrager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortAanvrager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortAanvrager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAanvrager.Image = ((System.Drawing.Image)(resources.GetObject("btnSortAanvrager.Image")));
            this.btnSortAanvrager.Location = new System.Drawing.Point(712, 247);
            this.btnSortAanvrager.Name = "btnSortAanvrager";
            this.btnSortAanvrager.Size = new System.Drawing.Size(27, 27);
            this.btnSortAanvrager.TabIndex = 33;
            this.btnSortAanvrager.UseVisualStyleBackColor = false;
            this.btnSortAanvrager.Click += new System.EventHandler(this.btnSortAanvrager_Click);
            // 
            // btnSortTitel
            // 
            this.btnSortTitel.BackColor = System.Drawing.Color.Transparent;
            this.btnSortTitel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortTitel.FlatAppearance.BorderSize = 0;
            this.btnSortTitel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortTitel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortTitel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortTitel.Image = ((System.Drawing.Image)(resources.GetObject("btnSortTitel.Image")));
            this.btnSortTitel.Location = new System.Drawing.Point(174, 248);
            this.btnSortTitel.Name = "btnSortTitel";
            this.btnSortTitel.Size = new System.Drawing.Size(27, 27);
            this.btnSortTitel.TabIndex = 34;
            this.btnSortTitel.UseVisualStyleBackColor = false;
            this.btnSortTitel.Click += new System.EventHandler(this.btnSortTitel_Click);
            // 
            // btnBedrag
            // 
            this.btnBedrag.BackColor = System.Drawing.Color.Transparent;
            this.btnBedrag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBedrag.FlatAppearance.BorderSize = 0;
            this.btnBedrag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBedrag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBedrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBedrag.Image = ((System.Drawing.Image)(resources.GetObject("btnBedrag.Image")));
            this.btnBedrag.Location = new System.Drawing.Point(451, 248);
            this.btnBedrag.Name = "btnBedrag";
            this.btnBedrag.Size = new System.Drawing.Size(27, 27);
            this.btnBedrag.TabIndex = 35;
            this.btnBedrag.UseVisualStyleBackColor = false;
            this.btnBedrag.Click += new System.EventHandler(this.btnBedrag_Click);
            // 
            // btnSortRichtperiode
            // 
            this.btnSortRichtperiode.BackColor = System.Drawing.Color.Transparent;
            this.btnSortRichtperiode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortRichtperiode.FlatAppearance.BorderSize = 0;
            this.btnSortRichtperiode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortRichtperiode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortRichtperiode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortRichtperiode.Image = ((System.Drawing.Image)(resources.GetObject("btnSortRichtperiode.Image")));
            this.btnSortRichtperiode.Location = new System.Drawing.Point(1028, 247);
            this.btnSortRichtperiode.Name = "btnSortRichtperiode";
            this.btnSortRichtperiode.Size = new System.Drawing.Size(27, 27);
            this.btnSortRichtperiode.TabIndex = 36;
            this.btnSortRichtperiode.UseVisualStyleBackColor = false;
            this.btnSortRichtperiode.Click += new System.EventHandler(this.btnSortRichtperiode_Click);
            // 
            // btnTesten
            // 
            this.btnTesten.Location = new System.Drawing.Point(732, -18);
            this.btnTesten.Name = "btnTesten";
            this.btnTesten.Size = new System.Drawing.Size(95, 51);
            this.btnTesten.TabIndex = 46;
            this.btnTesten.Text = "TESTEN";
            this.btnTesten.UseVisualStyleBackColor = true;
            this.btnTesten.Click += new System.EventHandler(this.btnTesten_Click);
            // 
            // frmAankopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 663);
            this.Controls.Add(this.btnSortRichtperiode);
            this.Controls.Add(this.btnBedrag);
            this.Controls.Add(this.btnSortTitel);
            this.Controls.Add(this.btnSortAanvrager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.pnlAanvragen);
            this.Controls.Add(this.gbxFinancieringsjaar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmAankopen";
            this.Text = "Aankopen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAankopen_FormClosing);
            this.Load += new System.EventHandler(this.frmAankopen_Load);
            this.Shown += new System.EventHandler(this.frmAankopen_Shown);
            this.gbxFinancieringsjaar.ResumeLayout(false);
            this.gbxFinancieringsjaar.PerformLayout();
            this.grbxFilterAanvraag.ResumeLayout(false);
            this.grbxFilterAanvraag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFinancieringsjaar;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.GroupBox gbxFinancieringsjaar;
        private System.Windows.Forms.CheckBox cbBedragTot;
        private System.Windows.Forms.TextBox txtBedragTot;
        private System.Windows.Forms.CheckBox cbBedragVan;
        private System.Windows.Forms.TextBox txtGebruiker;
        private System.Windows.Forms.TextBox txtBedragVan;
        private System.Windows.Forms.DateTimePicker dtpPlanningsdatumTot;
        private System.Windows.Forms.DateTimePicker dtpPlanningsdatumVan;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.CheckBox chbxPlaningsdatumVan;
        private System.Windows.Forms.CheckBox chbxPlaningsdatumTot;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label lblPlanningsdatum;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblAanvrager;
        private System.Windows.Forms.GroupBox grbxFilterAanvraag;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel pnlAanvragen;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSortAanvrager;
        private System.Windows.Forms.Button btnSortTitel;
        private System.Windows.Forms.Button btnBedrag;
        private System.Windows.Forms.Button btnSortRichtperiode;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label lblWachtenExcelAankopen;
        private System.Windows.Forms.Button btnTesten;
    }
}