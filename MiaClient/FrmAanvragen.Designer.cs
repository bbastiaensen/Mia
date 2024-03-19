namespace MiaClient
{
    partial class FrmAanvragen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAanvragen));
            this.grbxFilterAanvraag = new System.Windows.Forms.GroupBox();
            this.cbBedragTot = new System.Windows.Forms.CheckBox();
            this.txtBedragTot = new System.Windows.Forms.TextBox();
            this.cbBedragVan = new System.Windows.Forms.CheckBox();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.txtKostenPlaats = new System.Windows.Forms.TextBox();
            this.txtBedragVan = new System.Windows.Forms.TextBox();
            this.dtpPlanningsdatumTot = new System.Windows.Forms.DateTimePicker();
            this.dtpPlanningsdatumVan = new System.Windows.Forms.DateTimePicker();
            this.lblKostenplaats = new System.Windows.Forms.Label();
            this.dtpAanvraagmomentTot = new System.Windows.Forms.DateTimePicker();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.txtFinancieringsjaar = new System.Windows.Forms.TextBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.dtpAanvraagmomentVan = new System.Windows.Forms.DateTimePicker();
            this.chbxPlaningsdatumVan = new System.Windows.Forms.CheckBox();
            this.chbxPlaningsdatumTot = new System.Windows.Forms.CheckBox();
            this.chbxAanvraagmomentTot = new System.Windows.Forms.CheckBox();
            this.lblAanvraagmoment = new System.Windows.Forms.Label();
            this.txtStatusAanvraag = new System.Windows.Forms.TextBox();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.lblPlanningsdatum = new System.Windows.Forms.Label();
            this.lblStatusAanvraag = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.chbxAanvraagmomentVan = new System.Windows.Forms.CheckBox();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.btnNieuweAanvraag = new System.Windows.Forms.Button();
            this.pnlAanvragen = new System.Windows.Forms.Panel();
            this.grbxFilterAanvraag.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxFilterAanvraag
            // 
            this.grbxFilterAanvraag.Controls.Add(this.cbBedragTot);
            this.grbxFilterAanvraag.Controls.Add(this.txtBedragTot);
            this.grbxFilterAanvraag.Controls.Add(this.cbBedragVan);
            this.grbxFilterAanvraag.Controls.Add(this.txtGebruiker);
            this.grbxFilterAanvraag.Controls.Add(this.txtKostenPlaats);
            this.grbxFilterAanvraag.Controls.Add(this.txtBedragVan);
            this.grbxFilterAanvraag.Controls.Add(this.dtpPlanningsdatumTot);
            this.grbxFilterAanvraag.Controls.Add(this.dtpPlanningsdatumVan);
            this.grbxFilterAanvraag.Controls.Add(this.lblKostenplaats);
            this.grbxFilterAanvraag.Controls.Add(this.dtpAanvraagmomentTot);
            this.grbxFilterAanvraag.Controls.Add(this.lblBedrag);
            this.grbxFilterAanvraag.Controls.Add(this.txtFinancieringsjaar);
            this.grbxFilterAanvraag.Controls.Add(this.lblFinancieringsjaar);
            this.grbxFilterAanvraag.Controls.Add(this.dtpAanvraagmomentVan);
            this.grbxFilterAanvraag.Controls.Add(this.chbxPlaningsdatumVan);
            this.grbxFilterAanvraag.Controls.Add(this.chbxPlaningsdatumTot);
            this.grbxFilterAanvraag.Controls.Add(this.chbxAanvraagmomentTot);
            this.grbxFilterAanvraag.Controls.Add(this.lblAanvraagmoment);
            this.grbxFilterAanvraag.Controls.Add(this.txtStatusAanvraag);
            this.grbxFilterAanvraag.Controls.Add(this.txtTitel);
            this.grbxFilterAanvraag.Controls.Add(this.lblPlanningsdatum);
            this.grbxFilterAanvraag.Controls.Add(this.lblStatusAanvraag);
            this.grbxFilterAanvraag.Controls.Add(this.lblTitel);
            this.grbxFilterAanvraag.Controls.Add(this.chbxAanvraagmomentVan);
            this.grbxFilterAanvraag.Controls.Add(this.lblGebruiker);
            this.grbxFilterAanvraag.Location = new System.Drawing.Point(15, 54);
            this.grbxFilterAanvraag.Name = "grbxFilterAanvraag";
            this.grbxFilterAanvraag.Size = new System.Drawing.Size(1300, 250);
            this.grbxFilterAanvraag.TabIndex = 0;
            this.grbxFilterAanvraag.TabStop = false;
            this.grbxFilterAanvraag.Text = "Filter";
            // 
            // cbBedragTot
            // 
            this.cbBedragTot.AutoSize = true;
            this.cbBedragTot.Location = new System.Drawing.Point(651, 208);
            this.cbBedragTot.Name = "cbBedragTot";
            this.cbBedragTot.Size = new System.Drawing.Size(61, 32);
            this.cbBedragTot.TabIndex = 21;
            this.cbBedragTot.Text = "Tot";
            this.cbBedragTot.UseVisualStyleBackColor = true;
            this.cbBedragTot.CheckedChanged += new System.EventHandler(this.cbBedragTot_CheckedChanged);
            // 
            // txtBedragTot
            // 
            this.txtBedragTot.Location = new System.Drawing.Point(723, 206);
            this.txtBedragTot.Name = "txtBedragTot";
            this.txtBedragTot.Size = new System.Drawing.Size(200, 34);
            this.txtBedragTot.TabIndex = 26;
            // 
            // cbBedragVan
            // 
            this.cbBedragVan.AutoSize = true;
            this.cbBedragVan.Location = new System.Drawing.Point(651, 170);
            this.cbBedragVan.Name = "cbBedragVan";
            this.cbBedragVan.Size = new System.Drawing.Size(66, 32);
            this.cbBedragVan.TabIndex = 5;
            this.cbBedragVan.Text = "Van";
            this.cbBedragVan.UseVisualStyleBackColor = true;
            this.cbBedragVan.CheckedChanged += new System.EventHandler(this.cbBedragVan_CheckedChanged);
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.Location = new System.Drawing.Point(12, 61);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.Size = new System.Drawing.Size(272, 34);
            this.txtGebruiker.TabIndex = 25;
            this.txtGebruiker.TextChanged += new System.EventHandler(this.txtGebruiker_TextChanged);
            // 
            // txtKostenPlaats
            // 
            this.txtKostenPlaats.Location = new System.Drawing.Point(967, 166);
            this.txtKostenPlaats.Name = "txtKostenPlaats";
            this.txtKostenPlaats.Size = new System.Drawing.Size(272, 34);
            this.txtKostenPlaats.TabIndex = 16;
            this.txtKostenPlaats.TextChanged += new System.EventHandler(this.txtKostenPlaats_TextChanged);
            // 
            // txtBedragVan
            // 
            this.txtBedragVan.Location = new System.Drawing.Point(723, 168);
            this.txtBedragVan.Name = "txtBedragVan";
            this.txtBedragVan.Size = new System.Drawing.Size(200, 34);
            this.txtBedragVan.TabIndex = 17;
            this.txtBedragVan.TextChanged += new System.EventHandler(this.txtBedrag_TextChanged);
            // 
            // dtpPlanningsdatumTot
            // 
            this.dtpPlanningsdatumTot.Location = new System.Drawing.Point(397, 204);
            this.dtpPlanningsdatumTot.Name = "dtpPlanningsdatumTot";
            this.dtpPlanningsdatumTot.Size = new System.Drawing.Size(200, 34);
            this.dtpPlanningsdatumTot.TabIndex = 24;
            // 
            // dtpPlanningsdatumVan
            // 
            this.dtpPlanningsdatumVan.Location = new System.Drawing.Point(397, 166);
            this.dtpPlanningsdatumVan.Name = "dtpPlanningsdatumVan";
            this.dtpPlanningsdatumVan.Size = new System.Drawing.Size(200, 34);
            this.dtpPlanningsdatumVan.TabIndex = 23;
            // 
            // lblKostenplaats
            // 
            this.lblKostenplaats.AutoSize = true;
            this.lblKostenplaats.Location = new System.Drawing.Point(962, 128);
            this.lblKostenplaats.Name = "lblKostenplaats";
            this.lblKostenplaats.Size = new System.Drawing.Size(124, 28);
            this.lblKostenplaats.TabIndex = 5;
            this.lblKostenplaats.Text = "Kostenplaats";
            // 
            // dtpAanvraagmomentTot
            // 
            this.dtpAanvraagmomentTot.Location = new System.Drawing.Point(84, 204);
            this.dtpAanvraagmomentTot.Name = "dtpAanvraagmomentTot";
            this.dtpAanvraagmomentTot.Size = new System.Drawing.Size(200, 34);
            this.dtpAanvraagmomentTot.TabIndex = 22;
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(646, 128);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(74, 28);
            this.lblBedrag.TabIndex = 8;
            this.lblBedrag.Text = "Bedrag";
            // 
            // txtFinancieringsjaar
            // 
            this.txtFinancieringsjaar.Location = new System.Drawing.Point(967, 61);
            this.txtFinancieringsjaar.Name = "txtFinancieringsjaar";
            this.txtFinancieringsjaar.Size = new System.Drawing.Size(272, 34);
            this.txtFinancieringsjaar.TabIndex = 15;
            this.txtFinancieringsjaar.TextChanged += new System.EventHandler(this.txtFinancieringsjaar_TextChanged);
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(962, 27);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(158, 28);
            this.lblFinancieringsjaar.TabIndex = 7;
            this.lblFinancieringsjaar.Text = "Financieringsjaar";
            // 
            // dtpAanvraagmomentVan
            // 
            this.dtpAanvraagmomentVan.Location = new System.Drawing.Point(84, 166);
            this.dtpAanvraagmomentVan.Name = "dtpAanvraagmomentVan";
            this.dtpAanvraagmomentVan.Size = new System.Drawing.Size(200, 34);
            this.dtpAanvraagmomentVan.TabIndex = 21;
            // 
            // chbxPlaningsdatumVan
            // 
            this.chbxPlaningsdatumVan.AutoSize = true;
            this.chbxPlaningsdatumVan.Location = new System.Drawing.Point(325, 170);
            this.chbxPlaningsdatumVan.Name = "chbxPlaningsdatumVan";
            this.chbxPlaningsdatumVan.Size = new System.Drawing.Size(66, 32);
            this.chbxPlaningsdatumVan.TabIndex = 4;
            this.chbxPlaningsdatumVan.Text = "Van";
            this.chbxPlaningsdatumVan.UseVisualStyleBackColor = true;
            this.chbxPlaningsdatumVan.CheckedChanged += new System.EventHandler(this.chbxPlaningsdatumVan_CheckedChanged);
            // 
            // chbxPlaningsdatumTot
            // 
            this.chbxPlaningsdatumTot.AutoSize = true;
            this.chbxPlaningsdatumTot.Location = new System.Drawing.Point(325, 208);
            this.chbxPlaningsdatumTot.Name = "chbxPlaningsdatumTot";
            this.chbxPlaningsdatumTot.Size = new System.Drawing.Size(61, 32);
            this.chbxPlaningsdatumTot.TabIndex = 20;
            this.chbxPlaningsdatumTot.Text = "Tot";
            this.chbxPlaningsdatumTot.UseVisualStyleBackColor = true;
            this.chbxPlaningsdatumTot.CheckedChanged += new System.EventHandler(this.chbxPlaningsdatumTot_CheckedChanged);
            // 
            // chbxAanvraagmomentTot
            // 
            this.chbxAanvraagmomentTot.AutoSize = true;
            this.chbxAanvraagmomentTot.Location = new System.Drawing.Point(12, 208);
            this.chbxAanvraagmomentTot.Name = "chbxAanvraagmomentTot";
            this.chbxAanvraagmomentTot.Size = new System.Drawing.Size(61, 32);
            this.chbxAanvraagmomentTot.TabIndex = 19;
            this.chbxAanvraagmomentTot.Text = "Tot";
            this.chbxAanvraagmomentTot.UseVisualStyleBackColor = true;
            this.chbxAanvraagmomentTot.CheckedChanged += new System.EventHandler(this.chbxAanvraagmomentTot_CheckedChanged);
            // 
            // lblAanvraagmoment
            // 
            this.lblAanvraagmoment.AutoSize = true;
            this.lblAanvraagmoment.Location = new System.Drawing.Point(7, 128);
            this.lblAanvraagmoment.Name = "lblAanvraagmoment";
            this.lblAanvraagmoment.Size = new System.Drawing.Size(169, 28);
            this.lblAanvraagmoment.TabIndex = 18;
            this.lblAanvraagmoment.Text = "Aanvraagmoment";
            // 
            // txtStatusAanvraag
            // 
            this.txtStatusAanvraag.Location = new System.Drawing.Point(651, 58);
            this.txtStatusAanvraag.Name = "txtStatusAanvraag";
            this.txtStatusAanvraag.Size = new System.Drawing.Size(272, 34);
            this.txtStatusAanvraag.TabIndex = 14;
            this.txtStatusAanvraag.TextChanged += new System.EventHandler(this.txtStatusAanvraag_TextChanged);
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(325, 58);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(272, 34);
            this.txtTitel.TabIndex = 13;
            this.txtTitel.TextChanged += new System.EventHandler(this.txtTitel_TextChanged);
            // 
            // lblPlanningsdatum
            // 
            this.lblPlanningsdatum.AutoSize = true;
            this.lblPlanningsdatum.Location = new System.Drawing.Point(320, 128);
            this.lblPlanningsdatum.Name = "lblPlanningsdatum";
            this.lblPlanningsdatum.Size = new System.Drawing.Size(153, 28);
            this.lblPlanningsdatum.TabIndex = 11;
            this.lblPlanningsdatum.Text = "Planningsdatum";
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.AutoSize = true;
            this.lblStatusAanvraag.Location = new System.Drawing.Point(646, 27);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(153, 28);
            this.lblStatusAanvraag.TabIndex = 10;
            this.lblStatusAanvraag.Text = "Status Aanvraag";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(320, 27);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(49, 28);
            this.lblTitel.TabIndex = 9;
            this.lblTitel.Text = "Titel";
            // 
            // chbxAanvraagmomentVan
            // 
            this.chbxAanvraagmomentVan.AutoSize = true;
            this.chbxAanvraagmomentVan.Location = new System.Drawing.Point(12, 170);
            this.chbxAanvraagmomentVan.Name = "chbxAanvraagmomentVan";
            this.chbxAanvraagmomentVan.Size = new System.Drawing.Size(66, 32);
            this.chbxAanvraagmomentVan.TabIndex = 3;
            this.chbxAanvraagmomentVan.Text = "Van";
            this.chbxAanvraagmomentVan.UseVisualStyleBackColor = true;
            this.chbxAanvraagmomentVan.CheckedChanged += new System.EventHandler(this.chbxAanvraagmomentVan_CheckedChanged);
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Location = new System.Drawing.Point(7, 30);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(98, 28);
            this.lblGebruiker.TabIndex = 1;
            this.lblGebruiker.Text = "Gebruiker";
            // 
            // btnNieuweAanvraag
            // 
            this.btnNieuweAanvraag.Location = new System.Drawing.Point(1136, 12);
            this.btnNieuweAanvraag.Name = "btnNieuweAanvraag";
            this.btnNieuweAanvraag.Size = new System.Drawing.Size(179, 40);
            this.btnNieuweAanvraag.TabIndex = 17;
            this.btnNieuweAanvraag.Text = "Nieuwe aanvraag";
            this.btnNieuweAanvraag.UseVisualStyleBackColor = true;
            this.btnNieuweAanvraag.Click += new System.EventHandler(this.btnNieuweAanvraag_Click);
            // 
            // pnlAanvragen
            // 
            this.pnlAanvragen.AutoScroll = true;
            this.pnlAanvragen.Location = new System.Drawing.Point(15, 310);
            this.pnlAanvragen.Name = "pnlAanvragen";
            this.pnlAanvragen.Size = new System.Drawing.Size(1300, 270);
            this.pnlAanvragen.TabIndex = 18;
            this.pnlAanvragen.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlAanvragen_ControlAdded);
            this.pnlAanvragen.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAanvragen_Paint);
            // 
            // FrmAanvragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 702);
            this.Controls.Add(this.pnlAanvragen);
            this.Controls.Add(this.btnNieuweAanvraag);
            this.Controls.Add(this.grbxFilterAanvraag);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAanvragen";
            this.Text = "Aanvragen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAanvragen_FormClosing);
            this.Load += new System.EventHandler(this.frmAanvragen_Load);
            this.grbxFilterAanvraag.ResumeLayout(false);
            this.grbxFilterAanvraag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxFilterAanvraag;
        private System.Windows.Forms.Label lblPlanningsdatum;
        private System.Windows.Forms.Label lblStatusAanvraag;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblKostenplaats;
        private System.Windows.Forms.CheckBox chbxAanvraagmomentVan;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.Button btnNieuweAanvraag;
        private System.Windows.Forms.Panel pnlAanvragen;
        
        private System.Windows.Forms.TextBox txtBedragVan;
        private System.Windows.Forms.TextBox txtKostenPlaats;
        private System.Windows.Forms.TextBox txtFinancieringsjaar;
        private System.Windows.Forms.TextBox txtStatusAanvraag;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label lblAanvraagmoment;
        private System.Windows.Forms.DateTimePicker dtpPlanningsdatumTot;
        private System.Windows.Forms.DateTimePicker dtpPlanningsdatumVan;
        private System.Windows.Forms.DateTimePicker dtpAanvraagmomentTot;
        private System.Windows.Forms.DateTimePicker dtpAanvraagmomentVan;
        private System.Windows.Forms.CheckBox chbxPlaningsdatumVan;
        private System.Windows.Forms.CheckBox chbxPlaningsdatumTot;
        private System.Windows.Forms.CheckBox chbxAanvraagmomentTot;
        private System.Windows.Forms.TextBox txtGebruiker;
        private System.Windows.Forms.CheckBox cbBedragTot;
        private System.Windows.Forms.TextBox txtBedragTot;
        private System.Windows.Forms.CheckBox cbBedragVan;
    }
}