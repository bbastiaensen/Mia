

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
            this.testtest = new System.Windows.Forms.Button();
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
            this.label9 = new System.Windows.Forms.Label();
            this.btnSortSaldo = new System.Windows.Forms.Button();
            this.btnSortTitel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSortSatusaanvraag = new System.Windows.Forms.Button();
            this.btnSortAankoperr = new System.Windows.Forms.Button();
            this.btnSortAanvrager = new System.Windows.Forms.Button();
            this.btnFinancieringssjaar = new System.Windows.Forms.Button();
            this.btnRichtperiode = new System.Windows.Forms.Button();
            this.btnSortGoedgekeurdbedrag = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.gbxFinancieringsjaar.SuspendLayout();
            this.grbxFilterAanvraag.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFinancieringsjaar
            // 
            this.cmbFinancieringsjaar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinancieringsjaar.FormattingEnabled = true;
            this.cmbFinancieringsjaar.Location = new System.Drawing.Point(143, 87);
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
            this.gbxFinancieringsjaar.Controls.Add(this.btnAdd);
            this.gbxFinancieringsjaar.Controls.Add(this.btnExportToExcel);
            this.gbxFinancieringsjaar.Controls.Add(this.btnFilter);
            this.gbxFinancieringsjaar.Controls.Add(this.cmbFinancieringsjaar);
            this.gbxFinancieringsjaar.Controls.Add(this.grbxFilterAanvraag);
            this.gbxFinancieringsjaar.Controls.Add(this.lblFinancieringsjaar);
            this.gbxFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFinancieringsjaar.Location = new System.Drawing.Point(12, 12);
            this.gbxFinancieringsjaar.Name = "gbxFinancieringsjaar";
            this.gbxFinancieringsjaar.Size = new System.Drawing.Size(1274, 233);
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
            this.grbxFilterAanvraag.Controls.Add(this.testtest);
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
            this.grbxFilterAanvraag.Size = new System.Drawing.Size(855, 213);
            this.grbxFilterAanvraag.TabIndex = 2;
            this.grbxFilterAanvraag.TabStop = false;
            this.grbxFilterAanvraag.Text = "Filter";
            // 
            // testtest
            // 
            this.testtest.BackColor = System.Drawing.Color.Transparent;
            this.testtest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.testtest.FlatAppearance.BorderSize = 0;
            this.testtest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.testtest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.testtest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testtest.Location = new System.Drawing.Point(728, 95);
            this.testtest.Margin = new System.Windows.Forms.Padding(2);
            this.testtest.Name = "testtest";
            this.testtest.Size = new System.Drawing.Size(20, 22);
            this.testtest.TabIndex = 27;
            this.testtest.UseVisualStyleBackColor = false;
            // 
            // cbBedragTot
            // 
            this.cbBedragTot.AutoSize = true;
            this.cbBedragTot.Location = new System.Drawing.Point(355, 168);
            this.cbBedragTot.Name = "cbBedragTot";
            this.cbBedragTot.Size = new System.Drawing.Size(58, 29);
            this.cbBedragTot.TabIndex = 21;
            this.cbBedragTot.Text = "Tot";
            this.cbBedragTot.UseVisualStyleBackColor = true;
            // 
            // txtBedragTot
            // 
            this.txtBedragTot.Location = new System.Drawing.Point(427, 167);
            this.txtBedragTot.MaxLength = 20;
            this.txtBedragTot.Name = "txtBedragTot";
            this.txtBedragTot.Size = new System.Drawing.Size(200, 31);
            this.txtBedragTot.TabIndex = 26;
            // 
            // cbBedragVan
            // 
            this.cbBedragVan.AutoSize = true;
            this.cbBedragVan.Location = new System.Drawing.Point(355, 130);
            this.cbBedragVan.Name = "cbBedragVan";
            this.cbBedragVan.Size = new System.Drawing.Size(63, 29);
            this.cbBedragVan.TabIndex = 5;
            this.cbBedragVan.Text = "Van";
            this.cbBedragVan.UseVisualStyleBackColor = true;
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.Location = new System.Drawing.Point(11, 58);
            this.txtGebruiker.MaxLength = 50;
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.Size = new System.Drawing.Size(272, 31);
            this.txtGebruiker.TabIndex = 25;
            // 
            // txtBedragVan
            // 
            this.txtBedragVan.Location = new System.Drawing.Point(427, 128);
            this.txtBedragVan.MaxLength = 20;
            this.txtBedragVan.Name = "txtBedragVan";
            this.txtBedragVan.Size = new System.Drawing.Size(200, 31);
            this.txtBedragVan.TabIndex = 17;
            // 
            // dtpPlanningsdatumTot
            // 
            this.dtpPlanningsdatumTot.Location = new System.Drawing.Point(88, 169);
            this.dtpPlanningsdatumTot.Name = "dtpPlanningsdatumTot";
            this.dtpPlanningsdatumTot.Size = new System.Drawing.Size(216, 31);
            this.dtpPlanningsdatumTot.TabIndex = 24;
            // 
            // dtpPlanningsdatumVan
            // 
            this.dtpPlanningsdatumVan.Location = new System.Drawing.Point(88, 128);
            this.dtpPlanningsdatumVan.Name = "dtpPlanningsdatumVan";
            this.dtpPlanningsdatumVan.Size = new System.Drawing.Size(216, 31);
            this.dtpPlanningsdatumVan.TabIndex = 23;
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(355, 97);
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
            this.txtTitel.Location = new System.Drawing.Point(355, 58);
            this.txtTitel.MaxLength = 50;
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
            this.lblTitel.Location = new System.Drawing.Point(351, 30);
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
            this.pnlAanvragen.Size = new System.Drawing.Size(1274, 339);
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
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(739, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 63;
            this.label9.Text = "ingsjaar";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSortSaldo
            // 
            this.btnSortSaldo.BackColor = System.Drawing.Color.Transparent;
            this.btnSortSaldo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortSaldo.FlatAppearance.BorderSize = 0;
            this.btnSortSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortSaldo.Location = new System.Drawing.Point(1220, 242);
            this.btnSortSaldo.Name = "btnSortSaldo";
            this.btnSortSaldo.Size = new System.Drawing.Size(27, 27);
            this.btnSortSaldo.TabIndex = 62;
            this.btnSortSaldo.UseVisualStyleBackColor = false;
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
            this.btnSortTitel.Location = new System.Drawing.Point(123, 248);
            this.btnSortTitel.Name = "btnSortTitel";
            this.btnSortTitel.Size = new System.Drawing.Size(27, 27);
            this.btnSortTitel.TabIndex = 57;
            this.btnSortTitel.UseVisualStyleBackColor = false;
            this.btnSortTitel.Click += new System.EventHandler(this.btnSortGebruiker_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "Aanvrager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
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
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Richtperiode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1171, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 25);
            this.label8.TabIndex = 54;
            this.label8.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(981, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "GoedgekeurdBedrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Status Aanvraag";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(85, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 25);
            this.label10.TabIndex = 47;
            this.label10.Text = "Titel";
            // 
            // btnSortSatusaanvraag
            // 
            this.btnSortSatusaanvraag.BackColor = System.Drawing.Color.Transparent;
            this.btnSortSatusaanvraag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortSatusaanvraag.FlatAppearance.BorderSize = 0;
            this.btnSortSatusaanvraag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortSatusaanvraag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortSatusaanvraag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortSatusaanvraag.Image = ((System.Drawing.Image)(resources.GetObject("btnSortSatusaanvraag.Image")));
            this.btnSortSatusaanvraag.Location = new System.Drawing.Point(401, 246);
            this.btnSortSatusaanvraag.Name = "btnSortSatusaanvraag";
            this.btnSortSatusaanvraag.Size = new System.Drawing.Size(27, 27);
            this.btnSortSatusaanvraag.TabIndex = 64;
            this.btnSortSatusaanvraag.UseVisualStyleBackColor = false;
            this.btnSortSatusaanvraag.Click += new System.EventHandler(this.btnSortSatusaanvraag_Click);
            // 
            // btnSortAankoperr
            // 
            this.btnSortAankoperr.BackColor = System.Drawing.Color.Transparent;
            this.btnSortAankoperr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortAankoperr.FlatAppearance.BorderSize = 0;
            this.btnSortAankoperr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortAankoperr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortAankoperr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortAankoperr.Image = ((System.Drawing.Image)(resources.GetObject("btnSortAankoperr.Image")));
            this.btnSortAankoperr.Location = new System.Drawing.Point(513, 248);
            this.btnSortAankoperr.Name = "btnSortAankoperr";
            this.btnSortAankoperr.Size = new System.Drawing.Size(27, 27);
            this.btnSortAankoperr.TabIndex = 65;
            this.btnSortAankoperr.UseVisualStyleBackColor = false;
            this.btnSortAankoperr.Click += new System.EventHandler(this.btnSortAankoperr_Click);
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
            this.btnSortAanvrager.Location = new System.Drawing.Point(683, 248);
            this.btnSortAanvrager.Name = "btnSortAanvrager";
            this.btnSortAanvrager.Size = new System.Drawing.Size(27, 27);
            this.btnSortAanvrager.TabIndex = 66;
            this.btnSortAanvrager.UseVisualStyleBackColor = false;
            this.btnSortAanvrager.Click += new System.EventHandler(this.btnSortAanvrager_Click);
            // 
            // btnFinancieringssjaar
            // 
            this.btnFinancieringssjaar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinancieringssjaar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFinancieringssjaar.FlatAppearance.BorderSize = 0;
            this.btnFinancieringssjaar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFinancieringssjaar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFinancieringssjaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancieringssjaar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinancieringssjaar.Image")));
            this.btnFinancieringssjaar.Location = new System.Drawing.Point(812, 246);
            this.btnFinancieringssjaar.Name = "btnFinancieringssjaar";
            this.btnFinancieringssjaar.Size = new System.Drawing.Size(27, 27);
            this.btnFinancieringssjaar.TabIndex = 71;
            this.btnFinancieringssjaar.UseVisualStyleBackColor = false;
            this.btnFinancieringssjaar.Click += new System.EventHandler(this.btnFinancieringssjaar_Click);
            // 
            // btnRichtperiode
            // 
            this.btnRichtperiode.BackColor = System.Drawing.Color.Transparent;
            this.btnRichtperiode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRichtperiode.FlatAppearance.BorderSize = 0;
            this.btnRichtperiode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRichtperiode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRichtperiode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRichtperiode.Image = ((System.Drawing.Image)(resources.GetObject("btnRichtperiode.Image")));
            this.btnRichtperiode.Location = new System.Drawing.Point(942, 247);
            this.btnRichtperiode.Name = "btnRichtperiode";
            this.btnRichtperiode.Size = new System.Drawing.Size(27, 27);
            this.btnRichtperiode.TabIndex = 72;
            this.btnRichtperiode.UseVisualStyleBackColor = false;
            this.btnRichtperiode.Click += new System.EventHandler(this.btnRichtperiode_Click);
            // 
            // btnSortGoedgekeurdbedrag
            // 
            this.btnSortGoedgekeurdbedrag.BackColor = System.Drawing.Color.Transparent;
            this.btnSortGoedgekeurdbedrag.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortGoedgekeurdbedrag.FlatAppearance.BorderSize = 0;
            this.btnSortGoedgekeurdbedrag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSortGoedgekeurdbedrag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSortGoedgekeurdbedrag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortGoedgekeurdbedrag.Image = ((System.Drawing.Image)(resources.GetObject("btnSortGoedgekeurdbedrag.Image")));
            this.btnSortGoedgekeurdbedrag.Location = new System.Drawing.Point(1124, 248);
            this.btnSortGoedgekeurdbedrag.Name = "btnSortGoedgekeurdbedrag";
            this.btnSortGoedgekeurdbedrag.Size = new System.Drawing.Size(27, 27);
            this.btnSortGoedgekeurdbedrag.TabIndex = 73;
            this.btnSortGoedgekeurdbedrag.UseVisualStyleBackColor = false;
            this.btnSortGoedgekeurdbedrag.Click += new System.EventHandler(this.btnSortGoedgekeurdbedrag_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.Color.Transparent;
            this.btnSaldo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaldo.FlatAppearance.BorderSize = 0;
            this.btnSaldo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaldo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaldo.Image = ((System.Drawing.Image)(resources.GetObject("btnSaldo.Image")));
            this.btnSaldo.Location = new System.Drawing.Point(1224, 248);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(27, 27);
            this.btnSaldo.TabIndex = 74;
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // frmAankopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 663);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.btnSortGoedgekeurdbedrag);
            this.Controls.Add(this.btnRichtperiode);
            this.Controls.Add(this.btnFinancieringssjaar);
            this.Controls.Add(this.btnSortAankoperr);
            this.Controls.Add(this.btnSortAanvrager);
            this.Controls.Add(this.btnSortSatusaanvraag);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSortSaldo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSortTitel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
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
        private System.Windows.Forms.Button btnSortSaldo;
        private System.Windows.Forms.Button btnSortTitel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSortSatusaanvraag;
        private System.Windows.Forms.Button btnSortAankoperr;
        private System.Windows.Forms.Button btnSortAanvrager;
        private System.Windows.Forms.Button btnFinancieringssjaar;
        private System.Windows.Forms.Button btnRichtperiode;
        private System.Windows.Forms.Button btnSortGoedgekeurdbedrag;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button testtest;
    }
}