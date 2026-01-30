

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
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.btnSortAanvrager = new System.Windows.Forms.Button();
            this.btnSortTitel = new System.Windows.Forms.Button();
            this.btnBedrag = new System.Windows.Forms.Button();
            this.btnSortRichtperiode = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPlanningsdatum = new System.Windows.Forms.Button();
            this.btnKostenplaats = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSortStatusAanvraag = new System.Windows.Forms.Button();
            this.btnSortFinancieringsjaar = new System.Windows.Forms.Button();
            this.btnSortGebruiker = new System.Windows.Forms.Button();
            this.btnSortAanvraagmoment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxFinancieringsjaar.SuspendLayout();
            this.grbxFilterAanvraag.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFinancieringsjaar
            // 
            this.cmbFinancieringsjaar.FormattingEnabled = true;
            this.cmbFinancieringsjaar.Location = new System.Drawing.Point(143, 87);
            this.cmbFinancieringsjaar.Name = "cmbFinancieringsjaar";
            this.cmbFinancieringsjaar.Size = new System.Drawing.Size(253, 27);
            this.cmbFinancieringsjaar.TabIndex = 2;
            this.cmbFinancieringsjaar.SelectedIndexChanged += new System.EventHandler(this.cmbFinancieringsjaar_SelectedIndexChanged);
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(6, 87);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(131, 20);
            this.lblFinancieringsjaar.TabIndex = 1;
            this.lblFinancieringsjaar.Text = "Financieringsjaar : ";
            // 
            // gbxFinancieringsjaar
            // 
            this.gbxFinancieringsjaar.Controls.Add(this.btnAdd);
            this.gbxFinancieringsjaar.Controls.Add(this.btnExportToExcel);
            this.gbxFinancieringsjaar.Controls.Add(this.btnFilter);
            this.gbxFinancieringsjaar.Controls.Add(this.cmbFinancieringsjaar);
            this.gbxFinancieringsjaar.Controls.Add(this.grbxFilterAanvraag);
            this.gbxFinancieringsjaar.Controls.Add(this.lblFinancieringsjaar);
            this.gbxFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFinancieringsjaar.Location = new System.Drawing.Point(12, 12);
            this.gbxFinancieringsjaar.Name = "gbxFinancieringsjaar";
            this.gbxFinancieringsjaar.Size = new System.Drawing.Size(1687, 233);
            this.gbxFinancieringsjaar.TabIndex = 1;
            this.gbxFinancieringsjaar.TabStop = false;
            this.gbxFinancieringsjaar.Text = "selecteer een richtperiode";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(880, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.grbxFilterAanvraag.Size = new System.Drawing.Size(1272, 213);
            this.grbxFilterAanvraag.TabIndex = 2;
            this.grbxFilterAanvraag.TabStop = false;
            this.grbxFilterAanvraag.Text = "Filter";
            // 
            // cbBedragTot
            // 
            this.cbBedragTot.AutoSize = true;
            this.cbBedragTot.Location = new System.Drawing.Point(337, 168);
            this.cbBedragTot.Name = "cbBedragTot";
            this.cbBedragTot.Size = new System.Drawing.Size(49, 24);
            this.cbBedragTot.TabIndex = 21;
            this.cbBedragTot.Text = "Tot";
            this.cbBedragTot.UseVisualStyleBackColor = true;
            // 
            // txtBedragTot
            // 
            this.txtBedragTot.Location = new System.Drawing.Point(409, 167);
            this.txtBedragTot.Name = "txtBedragTot";
            this.txtBedragTot.Size = new System.Drawing.Size(200, 27);
            this.txtBedragTot.TabIndex = 26;
            // 
            // cbBedragVan
            // 
            this.cbBedragVan.AutoSize = true;
            this.cbBedragVan.Location = new System.Drawing.Point(337, 130);
            this.cbBedragVan.Name = "cbBedragVan";
            this.cbBedragVan.Size = new System.Drawing.Size(52, 24);
            this.cbBedragVan.TabIndex = 5;
            this.cbBedragVan.Text = "Van";
            this.cbBedragVan.UseVisualStyleBackColor = true;
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.Location = new System.Drawing.Point(11, 58);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.Size = new System.Drawing.Size(272, 27);
            this.txtGebruiker.TabIndex = 25;
            // 
            // txtBedragVan
            // 
            this.txtBedragVan.Location = new System.Drawing.Point(409, 128);
            this.txtBedragVan.Name = "txtBedragVan";
            this.txtBedragVan.Size = new System.Drawing.Size(200, 27);
            this.txtBedragVan.TabIndex = 17;
            // 
            // dtpPlanningsdatumTot
            // 
            this.dtpPlanningsdatumTot.Location = new System.Drawing.Point(88, 169);
            this.dtpPlanningsdatumTot.Name = "dtpPlanningsdatumTot";
            this.dtpPlanningsdatumTot.Size = new System.Drawing.Size(200, 27);
            this.dtpPlanningsdatumTot.TabIndex = 24;
            // 
            // dtpPlanningsdatumVan
            // 
            this.dtpPlanningsdatumVan.Location = new System.Drawing.Point(88, 128);
            this.dtpPlanningsdatumVan.Name = "dtpPlanningsdatumVan";
            this.dtpPlanningsdatumVan.Size = new System.Drawing.Size(200, 27);
            this.dtpPlanningsdatumVan.TabIndex = 23;
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(337, 97);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(57, 20);
            this.lblBedrag.TabIndex = 8;
            this.lblBedrag.Text = "Bedrag";
            // 
            // chbxPlaningsdatumVan
            // 
            this.chbxPlaningsdatumVan.AutoSize = true;
            this.chbxPlaningsdatumVan.Location = new System.Drawing.Point(11, 132);
            this.chbxPlaningsdatumVan.Name = "chbxPlaningsdatumVan";
            this.chbxPlaningsdatumVan.Size = new System.Drawing.Size(52, 24);
            this.chbxPlaningsdatumVan.TabIndex = 4;
            this.chbxPlaningsdatumVan.Text = "Van";
            this.chbxPlaningsdatumVan.UseVisualStyleBackColor = true;
            // 
            // chbxPlaningsdatumTot
            // 
            this.chbxPlaningsdatumTot.AutoSize = true;
            this.chbxPlaningsdatumTot.Location = new System.Drawing.Point(11, 174);
            this.chbxPlaningsdatumTot.Name = "chbxPlaningsdatumTot";
            this.chbxPlaningsdatumTot.Size = new System.Drawing.Size(49, 24);
            this.chbxPlaningsdatumTot.TabIndex = 20;
            this.chbxPlaningsdatumTot.Text = "Tot";
            this.chbxPlaningsdatumTot.UseVisualStyleBackColor = true;
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(337, 58);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(272, 27);
            this.txtTitel.TabIndex = 13;
            // 
            // lblPlanningsdatum
            // 
            this.lblPlanningsdatum.AutoSize = true;
            this.lblPlanningsdatum.Location = new System.Drawing.Point(11, 97);
            this.lblPlanningsdatum.Name = "lblPlanningsdatum";
            this.lblPlanningsdatum.Size = new System.Drawing.Size(115, 20);
            this.lblPlanningsdatum.TabIndex = 11;
            this.lblPlanningsdatum.Text = "Planningsdatum";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(333, 30);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(38, 20);
            this.lblTitel.TabIndex = 9;
            this.lblTitel.Text = "Titel";
            // 
            // lblAanvrager
            // 
            this.lblAanvrager.AutoSize = true;
            this.lblAanvrager.Location = new System.Drawing.Point(7, 30);
            this.lblAanvrager.Name = "lblAanvrager";
            this.lblAanvrager.Size = new System.Drawing.Size(77, 20);
            this.lblAanvrager.TabIndex = 1;
            this.lblAanvrager.Text = "Aanvrager";
            // 
            // pnlAanvragen
            // 
            this.pnlAanvragen.Location = new System.Drawing.Point(12, 278);
            this.pnlAanvragen.Name = "pnlAanvragen";
            this.pnlAanvragen.Size = new System.Drawing.Size(1855, 339);
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
            // btnSortAanvrager
            // 
            this.btnSortAanvrager.Location = new System.Drawing.Point(0, 0);
            this.btnSortAanvrager.Name = "btnSortAanvrager";
            this.btnSortAanvrager.Size = new System.Drawing.Size(75, 23);
            this.btnSortAanvrager.TabIndex = 46;
            // 
            // btnSortTitel
            // 
            this.btnSortTitel.Location = new System.Drawing.Point(0, 0);
            this.btnSortTitel.Name = "btnSortTitel";
            this.btnSortTitel.Size = new System.Drawing.Size(75, 23);
            this.btnSortTitel.TabIndex = 45;
            // 
            // btnBedrag
            // 
            this.btnBedrag.Location = new System.Drawing.Point(0, 0);
            this.btnBedrag.Name = "btnBedrag";
            this.btnBedrag.Size = new System.Drawing.Size(75, 23);
            this.btnBedrag.TabIndex = 44;
            // 
            // btnSortRichtperiode
            // 
            this.btnSortRichtperiode.Location = new System.Drawing.Point(0, 0);
            this.btnSortRichtperiode.Name = "btnSortRichtperiode";
            this.btnSortRichtperiode.Size = new System.Drawing.Size(75, 23);
            this.btnSortRichtperiode.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(739, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 63;
            this.label9.Text = "ingsjaar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlanningsdatum
            // 
            this.btnPlanningsdatum.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanningsdatum.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlanningsdatum.FlatAppearance.BorderSize = 0;
            this.btnPlanningsdatum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlanningsdatum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlanningsdatum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanningsdatum.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanningsdatum.Image")));
            this.btnPlanningsdatum.Location = new System.Drawing.Point(1310, 242);
            this.btnPlanningsdatum.Name = "btnPlanningsdatum";
            this.btnPlanningsdatum.Size = new System.Drawing.Size(27, 27);
            this.btnPlanningsdatum.TabIndex = 62;
            this.btnPlanningsdatum.UseVisualStyleBackColor = false;
            // 
            // btnKostenplaats
            // 
            this.btnKostenplaats.BackColor = System.Drawing.Color.Transparent;
            this.btnKostenplaats.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKostenplaats.FlatAppearance.BorderSize = 0;
            this.btnKostenplaats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnKostenplaats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnKostenplaats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKostenplaats.Image = ((System.Drawing.Image)(resources.GetObject("btnKostenplaats.Image")));
            this.btnKostenplaats.Location = new System.Drawing.Point(1217, 242);
            this.btnKostenplaats.Name = "btnKostenplaats";
            this.btnKostenplaats.Size = new System.Drawing.Size(27, 27);
            this.btnKostenplaats.TabIndex = 61;
            this.btnKostenplaats.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(939, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 60;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSortStatusAanvraag
            // 
            this.btnSortStatusAanvraag.BackColor = System.Drawing.Color.Transparent;
            this.btnSortStatusAanvraag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortStatusAanvraag.FlatAppearance.BorderSize = 0;
            this.btnSortStatusAanvraag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortStatusAanvraag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortStatusAanvraag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortStatusAanvraag.Image = ((System.Drawing.Image)(resources.GetObject("btnSortStatusAanvraag.Image")));
            this.btnSortStatusAanvraag.Location = new System.Drawing.Point(671, 242);
            this.btnSortStatusAanvraag.Name = "btnSortStatusAanvraag";
            this.btnSortStatusAanvraag.Size = new System.Drawing.Size(27, 27);
            this.btnSortStatusAanvraag.TabIndex = 59;
            this.btnSortStatusAanvraag.UseVisualStyleBackColor = false;
            // 
            // btnSortFinancieringsjaar
            // 
            this.btnSortFinancieringsjaar.BackColor = System.Drawing.Color.Transparent;
            this.btnSortFinancieringsjaar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortFinancieringsjaar.FlatAppearance.BorderSize = 0;
            this.btnSortFinancieringsjaar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortFinancieringsjaar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortFinancieringsjaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortFinancieringsjaar.Image = ((System.Drawing.Image)(resources.GetObject("btnSortFinancieringsjaar.Image")));
            this.btnSortFinancieringsjaar.Location = new System.Drawing.Point(812, 245);
            this.btnSortFinancieringsjaar.Name = "btnSortFinancieringsjaar";
            this.btnSortFinancieringsjaar.Size = new System.Drawing.Size(27, 27);
            this.btnSortFinancieringsjaar.TabIndex = 58;
            this.btnSortFinancieringsjaar.UseVisualStyleBackColor = false;
            // 
            // btnSortGebruiker
            // 
            this.btnSortGebruiker.BackColor = System.Drawing.Color.Transparent;
            this.btnSortGebruiker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortGebruiker.FlatAppearance.BorderSize = 0;
            this.btnSortGebruiker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortGebruiker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortGebruiker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortGebruiker.Image = ((System.Drawing.Image)(resources.GetObject("btnSortGebruiker.Image")));
            this.btnSortGebruiker.Location = new System.Drawing.Point(123, 245);
            this.btnSortGebruiker.Name = "btnSortGebruiker";
            this.btnSortGebruiker.Size = new System.Drawing.Size(27, 27);
            this.btnSortGebruiker.TabIndex = 57;
            this.btnSortGebruiker.UseVisualStyleBackColor = false;
            // 
            // btnSortAanvraagmoment
            // 
            this.btnSortAanvraagmoment.BackColor = System.Drawing.Color.Transparent;
            this.btnSortAanvraagmoment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortAanvraagmoment.FlatAppearance.BorderSize = 0;
            this.btnSortAanvraagmoment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortAanvraagmoment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortAanvraagmoment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAanvraagmoment.Image = ((System.Drawing.Image)(resources.GetObject("btnSortAanvraagmoment.Image")));
            this.btnSortAanvraagmoment.Location = new System.Drawing.Point(525, 242);
            this.btnSortAanvraagmoment.Name = "btnSortAanvraagmoment";
            this.btnSortAanvraagmoment.Size = new System.Drawing.Size(27, 27);
            this.btnSortAanvraagmoment.TabIndex = 56;
            this.btnSortAanvraagmoment.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(374, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 55;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Aanvrager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Aankoper";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(737, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Financier-";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Richtperiode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1261, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1071, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "GoedgekeurdBedrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Status Aanvraag";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Titel";
            // 
            // frmAankopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1879, 663);
            this.Controls.Add(this.btnSortFinancieringsjaar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPlanningsdatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKostenplaats);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSortStatusAanvraag);
            this.Controls.Add(this.btnSortGebruiker);
            this.Controls.Add(this.btnSortAanvraagmoment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSortRichtperiode);
            this.Controls.Add(this.btnBedrag);
            this.Controls.Add(this.btnSortTitel);
            this.Controls.Add(this.btnSortAanvrager);
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
            this.Text = "jaar";
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
        private System.Windows.Forms.Button btnSortAanvrager;
        private System.Windows.Forms.Button btnSortTitel;
        private System.Windows.Forms.Button btnBedrag;
        private System.Windows.Forms.Button btnSortRichtperiode;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label lblWachtenExcelAankopen;
        private System.Windows.Forms.Button btnAdd;
        // Filter textboxes - will be added to Designer if needed
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.TextBox txtStatusAankoop;
        private System.Windows.Forms.TextBox txtAankoper;
        private System.Windows.Forms.TextBox txtAanvrager;
        private System.Windows.Forms.TextBox txtRichtperiode;
        private System.Windows.Forms.TextBox txtGoedgekeurdBedragVan;
        private System.Windows.Forms.TextBox txtGoedgekeurdBedragTot;
        private System.Windows.Forms.TextBox txtSaldoVan;
        private System.Windows.Forms.TextBox txtSaldoTot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPlanningsdatum;
        private System.Windows.Forms.Button btnKostenplaats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSortStatusAanvraag;
        private System.Windows.Forms.Button btnSortFinancieringsjaar;
        private System.Windows.Forms.Button btnSortGebruiker;
        private System.Windows.Forms.Button btnSortAanvraagmoment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}