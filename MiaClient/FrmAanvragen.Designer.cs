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
            this.grbxFilterAanvraag = new System.Windows.Forms.GroupBox();
            this.cmbxStatusAanvraag = new System.Windows.Forms.ComboBox();
            this.lblPlanningsdatum = new System.Windows.Forms.Label();
            this.lblStatusAanvraag = new System.Windows.Forms.Label();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.lblKostenplaats = new System.Windows.Forms.Label();
            this.dtpAanvraagmoment = new System.Windows.Forms.DateTimePicker();
            this.chbxAanvraagmoment = new System.Windows.Forms.CheckBox();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.btnNieuweAanvraag = new System.Windows.Forms.Button();
            this.cmbGebruiker = new System.Windows.Forms.ComboBox();
            this.cmbTitel = new System.Windows.Forms.ComboBox();
            this.cmbFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.cmbKostenplaats = new System.Windows.Forms.ComboBox();
            this.cmbBedrag = new System.Windows.Forms.ComboBox();
            this.cmbPlanningsdatum = new System.Windows.Forms.ComboBox();
            this.grbxFilterAanvraag.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxFilterAanvraag
            // 
            this.grbxFilterAanvraag.Controls.Add(this.cmbKostenplaats);
            this.grbxFilterAanvraag.Controls.Add(this.cmbGebruiker);
            this.grbxFilterAanvraag.Controls.Add(this.cmbxStatusAanvraag);
            this.grbxFilterAanvraag.Controls.Add(this.lblPlanningsdatum);
            this.grbxFilterAanvraag.Controls.Add(this.lblStatusAanvraag);
            this.grbxFilterAanvraag.Controls.Add(this.lblTitel);
            this.grbxFilterAanvraag.Controls.Add(this.lblBedrag);
            this.grbxFilterAanvraag.Controls.Add(this.lblFinancieringsjaar);
            this.grbxFilterAanvraag.Controls.Add(this.lblKostenplaats);
            this.grbxFilterAanvraag.Controls.Add(this.dtpAanvraagmoment);
            this.grbxFilterAanvraag.Controls.Add(this.chbxAanvraagmoment);
            this.grbxFilterAanvraag.Controls.Add(this.lblGebruiker);
            this.grbxFilterAanvraag.Location = new System.Drawing.Point(12, 77);
            this.grbxFilterAanvraag.Name = "grbxFilterAanvraag";
            this.grbxFilterAanvraag.Size = new System.Drawing.Size(873, 171);
            this.grbxFilterAanvraag.TabIndex = 0;
            this.grbxFilterAanvraag.TabStop = false;
            this.grbxFilterAanvraag.Text = "Filter";
            // 
            // cmbxStatusAanvraag
            // 
            this.cmbxStatusAanvraag.FormattingEnabled = true;
            this.cmbxStatusAanvraag.Location = new System.Drawing.Point(16, 118);
            this.cmbxStatusAanvraag.Name = "cmbxStatusAanvraag";
            this.cmbxStatusAanvraag.Size = new System.Drawing.Size(200, 36);
            this.cmbxStatusAanvraag.TabIndex = 13;
            // 
            // lblPlanningsdatum
            // 
            this.lblPlanningsdatum.AutoSize = true;
            this.lblPlanningsdatum.Location = new System.Drawing.Point(655, 87);
            this.lblPlanningsdatum.Name = "lblPlanningsdatum";
            this.lblPlanningsdatum.Size = new System.Drawing.Size(153, 28);
            this.lblPlanningsdatum.TabIndex = 11;
            this.lblPlanningsdatum.Text = "Planningsdatum";
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.AutoSize = true;
            this.lblStatusAanvraag.Location = new System.Drawing.Point(14, 87);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(153, 28);
            this.lblStatusAanvraag.TabIndex = 10;
            this.lblStatusAanvraag.Text = "Status Aanvraag";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(453, 24);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(49, 28);
            this.lblTitel.TabIndex = 9;
            this.lblTitel.Text = "Titel";
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Location = new System.Drawing.Point(453, 86);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(74, 28);
            this.lblBedrag.TabIndex = 8;
            this.lblBedrag.Text = "Bedrag";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(650, 24);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(158, 28);
            this.lblFinancieringsjaar.TabIndex = 7;
            this.lblFinancieringsjaar.Text = "Financieringsjaar";
            // 
            // lblKostenplaats
            // 
            this.lblKostenplaats.AutoSize = true;
            this.lblKostenplaats.Location = new System.Drawing.Point(222, 87);
            this.lblKostenplaats.Name = "lblKostenplaats";
            this.lblKostenplaats.Size = new System.Drawing.Size(124, 28);
            this.lblKostenplaats.TabIndex = 5;
            this.lblKostenplaats.Text = "Kostenplaats";
            // 
            // dtpAanvraagmoment
            // 
            this.dtpAanvraagmoment.Location = new System.Drawing.Point(225, 55);
            this.dtpAanvraagmoment.Name = "dtpAanvraagmoment";
            this.dtpAanvraagmoment.Size = new System.Drawing.Size(224, 34);
            this.dtpAanvraagmoment.TabIndex = 4;
            // 
            // chbxAanvraagmoment
            // 
            this.chbxAanvraagmoment.AutoSize = true;
            this.chbxAanvraagmoment.Location = new System.Drawing.Point(225, 26);
            this.chbxAanvraagmoment.Name = "chbxAanvraagmoment";
            this.chbxAanvraagmoment.Size = new System.Drawing.Size(191, 32);
            this.chbxAanvraagmoment.TabIndex = 3;
            this.chbxAanvraagmoment.Text = "Aanvraagmoment";
            this.chbxAanvraagmoment.UseVisualStyleBackColor = true;
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Location = new System.Drawing.Point(14, 27);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(98, 28);
            this.lblGebruiker.TabIndex = 1;
            this.lblGebruiker.Text = "Gebruiker";
            // 
            // btnNieuweAanvraag
            // 
            this.btnNieuweAanvraag.Location = new System.Drawing.Point(709, 12);
            this.btnNieuweAanvraag.Name = "btnNieuweAanvraag";
            this.btnNieuweAanvraag.Size = new System.Drawing.Size(179, 40);
            this.btnNieuweAanvraag.TabIndex = 17;
            this.btnNieuweAanvraag.Text = "Nieuwe aanvraag";
            this.btnNieuweAanvraag.UseVisualStyleBackColor = true;
            this.btnNieuweAanvraag.Click += new System.EventHandler(this.btnNieuweAanvraag_Click);
            // 
            // cmbGebruiker
            // 
            this.cmbGebruiker.FormattingEnabled = true;
            this.cmbGebruiker.Location = new System.Drawing.Point(19, 58);
            this.cmbGebruiker.Name = "cmbGebruiker";
            this.cmbGebruiker.Size = new System.Drawing.Size(197, 36);
            this.cmbGebruiker.TabIndex = 14;
            this.cmbGebruiker.SelectedIndexChanged += new System.EventHandler(this.cmbGebruiker_SelectedIndexChanged);
            // 
            // cmbTitel
            // 
            this.cmbTitel.FormattingEnabled = true;
            this.cmbTitel.Location = new System.Drawing.Point(470, 417);
            this.cmbTitel.Name = "cmbTitel";
            this.cmbTitel.Size = new System.Drawing.Size(191, 36);
            this.cmbTitel.TabIndex = 15;
            // 
            // cmbFinancieringsjaar
            // 
            this.cmbFinancieringsjaar.FormattingEnabled = true;
            this.cmbFinancieringsjaar.Location = new System.Drawing.Point(667, 351);
            this.cmbFinancieringsjaar.Name = "cmbFinancieringsjaar";
            this.cmbFinancieringsjaar.Size = new System.Drawing.Size(192, 36);
            this.cmbFinancieringsjaar.TabIndex = 16;
            // 
            // cmbKostenplaats
            // 
            this.cmbKostenplaats.FormattingEnabled = true;
            this.cmbKostenplaats.Location = new System.Drawing.Point(227, 118);
            this.cmbKostenplaats.Name = "cmbKostenplaats";
            this.cmbKostenplaats.Size = new System.Drawing.Size(222, 36);
            this.cmbKostenplaats.TabIndex = 17;
            // 
            // cmbBedrag
            // 
            this.cmbBedrag.FormattingEnabled = true;
            this.cmbBedrag.Location = new System.Drawing.Point(470, 351);
            this.cmbBedrag.Name = "cmbBedrag";
            this.cmbBedrag.Size = new System.Drawing.Size(191, 36);
            this.cmbBedrag.TabIndex = 18;
            // 
            // cmbPlanningsdatum
            // 
            this.cmbPlanningsdatum.FormattingEnabled = true;
            this.cmbPlanningsdatum.Location = new System.Drawing.Point(667, 417);
            this.cmbPlanningsdatum.Name = "cmbPlanningsdatum";
            this.cmbPlanningsdatum.Size = new System.Drawing.Size(192, 36);
            this.cmbPlanningsdatum.TabIndex = 19;
            // 
            // FrmAanvragen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.cmbPlanningsdatum);
            this.Controls.Add(this.btnNieuweAanvraag);
            this.Controls.Add(this.cmbBedrag);
            this.Controls.Add(this.cmbFinancieringsjaar);
            this.Controls.Add(this.grbxFilterAanvraag);
            this.Controls.Add(this.cmbTitel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAanvragen";
            this.Text = "FrmAanvraagen";
            this.grbxFilterAanvraag.ResumeLayout(false);
            this.grbxFilterAanvraag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxFilterAanvraag;
        private System.Windows.Forms.ComboBox cmbxStatusAanvraag;
        private System.Windows.Forms.Label lblPlanningsdatum;
        private System.Windows.Forms.Label lblStatusAanvraag;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblKostenplaats;
        private System.Windows.Forms.DateTimePicker dtpAanvraagmoment;
        private System.Windows.Forms.CheckBox chbxAanvraagmoment;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.Button btnNieuweAanvraag;
        private System.Windows.Forms.ComboBox cmbPlanningsdatum;
        private System.Windows.Forms.ComboBox cmbBedrag;
        private System.Windows.Forms.ComboBox cmbKostenplaats;
        private System.Windows.Forms.ComboBox cmbFinancieringsjaar;
        private System.Windows.Forms.ComboBox cmbTitel;
        private System.Windows.Forms.ComboBox cmbGebruiker;
    }
}