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
            this.cmbFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.gbxFinancieringsjaar = new System.Windows.Forms.GroupBox();
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
            this.grbxFilterAanvraag = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.gbxFinancieringsjaar.SuspendLayout();
            this.grbxFilterAanvraag.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbFinancieringsjaar
            // 
            this.cmbFinancieringsjaar.FormattingEnabled = true;
            this.cmbFinancieringsjaar.Location = new System.Drawing.Point(143, 84);
            this.cmbFinancieringsjaar.Name = "cmbFinancieringsjaar";
            this.cmbFinancieringsjaar.Size = new System.Drawing.Size(253, 27);
            this.cmbFinancieringsjaar.TabIndex = 2;
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
            this.gbxFinancieringsjaar.Controls.Add(this.btnFilter);
            this.gbxFinancieringsjaar.Controls.Add(this.cmbFinancieringsjaar);
            this.gbxFinancieringsjaar.Controls.Add(this.grbxFilterAanvraag);
            this.gbxFinancieringsjaar.Controls.Add(this.lblFinancieringsjaar);
            this.gbxFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFinancieringsjaar.Location = new System.Drawing.Point(12, 12);
            this.gbxFinancieringsjaar.Name = "gbxFinancieringsjaar";
            this.gbxFinancieringsjaar.Size = new System.Drawing.Size(1043, 253);
            this.gbxFinancieringsjaar.TabIndex = 1;
            this.gbxFinancieringsjaar.TabStop = false;
            this.gbxFinancieringsjaar.Text = "selecteer een richtperiode";
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
            // 
            // frmAankopen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.gbxFinancieringsjaar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAankopen";
            this.Text = "Aankopen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAankopen_FormClosing);
            this.Load += new System.EventHandler(this.frmAankopen_Load);
            this.gbxFinancieringsjaar.ResumeLayout(false);
            this.gbxFinancieringsjaar.PerformLayout();
            this.grbxFilterAanvraag.ResumeLayout(false);
            this.grbxFilterAanvraag.PerformLayout();
            this.ResumeLayout(false);

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
    }
}