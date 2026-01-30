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
            this.lblAankoopDetail = new System.Windows.Forms.Label();
            this.lblAankoopId = new System.Windows.Forms.Label();
            this.txtAanvraagId = new System.Windows.Forms.TextBox();
            this.btn_Nieuw = new System.Windows.Forms.Button();
            this.btn_Bewaren = new System.Windows.Forms.Button();
            this.rtxtOmschrijving = new System.Windows.Forms.RichTextBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.ddlWieKooptHet = new System.Windows.Forms.ComboBox();
            this.ddlKostenplaats = new System.Windows.Forms.ComboBox();
            this.ddlFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.lblKostenplaats = new System.Windows.Forms.Label();
            this.lblWieKooptHet = new System.Windows.Forms.Label();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.lblGoedgekeurdeBedrag = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtGoedgekeurdeBedrag = new System.Windows.Forms.TextBox();
            this.lblBedragExBtw = new System.Windows.Forms.Label();
            this.txtBedragExBtw = new System.Windows.Forms.TextBox();
            this.lblBTWPercentage = new System.Windows.Forms.Label();
            this.txtBTWPercentage = new System.Windows.Forms.TextBox();
            this.lblBedragInBTW = new System.Windows.Forms.Label();
            this.txtBedragInBTW = new System.Windows.Forms.TextBox();
            this.lblBedragTransfer = new System.Windows.Forms.Label();
            this.txtBedragTransfer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAankoopDetail
            // 
            this.lblAankoopDetail.AutoSize = true;
            this.lblAankoopDetail.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAankoopDetail.Location = new System.Drawing.Point(14, 9);
            this.lblAankoopDetail.Name = "lblAankoopDetail";
            this.lblAankoopDetail.Size = new System.Drawing.Size(274, 45);
            this.lblAankoopDetail.TabIndex = 11;
            this.lblAankoopDetail.Text = "Aankoop Details";
            // 
            // lblAankoopId
            // 
            this.lblAankoopId.AutoSize = true;
            this.lblAankoopId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAankoopId.Location = new System.Drawing.Point(17, 58);
            this.lblAankoopId.Name = "lblAankoopId";
            this.lblAankoopId.Size = new System.Drawing.Size(169, 28);
            this.lblAankoopId.TabIndex = 12;
            this.lblAankoopId.Text = "Aankoopnummer:";
            // 
            // txtAanvraagId
            // 
            this.txtAanvraagId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAanvraagId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAanvraagId.Location = new System.Drawing.Point(191, 55);
            this.txtAanvraagId.Name = "txtAanvraagId";
            this.txtAanvraagId.ReadOnly = true;
            this.txtAanvraagId.Size = new System.Drawing.Size(71, 34);
            this.txtAanvraagId.TabIndex = 13;
            // 
            // btn_Nieuw
            // 
            this.btn_Nieuw.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Nieuw.Location = new System.Drawing.Point(1045, 49);
            this.btn_Nieuw.Name = "btn_Nieuw";
            this.btn_Nieuw.Size = new System.Drawing.Size(103, 37);
            this.btn_Nieuw.TabIndex = 17;
            this.btn_Nieuw.Text = "Nieuw";
            this.btn_Nieuw.UseVisualStyleBackColor = true;
            this.btn_Nieuw.Click += new System.EventHandler(this.btn_Nieuw_Click);
            // 
            // btn_Bewaren
            // 
            this.btn_Bewaren.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Bewaren.Location = new System.Drawing.Point(1154, 49);
            this.btn_Bewaren.Name = "btn_Bewaren";
            this.btn_Bewaren.Size = new System.Drawing.Size(103, 37);
            this.btn_Bewaren.TabIndex = 18;
            this.btn_Bewaren.Text = "Bewaren";
            this.btn_Bewaren.UseVisualStyleBackColor = true;
            this.btn_Bewaren.Click += new System.EventHandler(this.btn_Bewaren_Click);
            // 
            // rtxtOmschrijving
            // 
            this.rtxtOmschrijving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtOmschrijving.Location = new System.Drawing.Point(191, 120);
            this.rtxtOmschrijving.Name = "rtxtOmschrijving";
            this.rtxtOmschrijving.Size = new System.Drawing.Size(533, 109);
            this.rtxtOmschrijving.TabIndex = 36;
            this.rtxtOmschrijving.Text = "";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOmschrijving.Location = new System.Drawing.Point(19, 122);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(87, 16);
            this.lblOmschrijving.TabIndex = 43;
            this.lblOmschrijving.Text = "Omschrijving:";
            // 
            // ddlWieKooptHet
            // 
            this.ddlWieKooptHet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlWieKooptHet.FormattingEnabled = true;
            this.ddlWieKooptHet.Location = new System.Drawing.Point(956, 192);
            this.ddlWieKooptHet.Name = "ddlWieKooptHet";
            this.ddlWieKooptHet.Size = new System.Drawing.Size(270, 24);
            this.ddlWieKooptHet.TabIndex = 53;
            // 
            // ddlKostenplaats
            // 
            this.ddlKostenplaats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKostenplaats.FormattingEnabled = true;
            this.ddlKostenplaats.Location = new System.Drawing.Point(956, 157);
            this.ddlKostenplaats.Name = "ddlKostenplaats";
            this.ddlKostenplaats.Size = new System.Drawing.Size(270, 24);
            this.ddlKostenplaats.TabIndex = 52;
            // 
            // ddlFinancieringsjaar
            // 
            this.ddlFinancieringsjaar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFinancieringsjaar.FormattingEnabled = true;
            this.ddlFinancieringsjaar.Location = new System.Drawing.Point(956, 122);
            this.ddlFinancieringsjaar.Name = "ddlFinancieringsjaar";
            this.ddlFinancieringsjaar.Size = new System.Drawing.Size(270, 24);
            this.ddlFinancieringsjaar.TabIndex = 51;
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(787, 125);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(113, 16);
            this.lblFinancieringsjaar.TabIndex = 56;
            this.lblFinancieringsjaar.Text = "Financieringsjaar:";
            // 
            // lblKostenplaats
            // 
            this.lblKostenplaats.AutoSize = true;
            this.lblKostenplaats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKostenplaats.Location = new System.Drawing.Point(787, 160);
            this.lblKostenplaats.Name = "lblKostenplaats";
            this.lblKostenplaats.Size = new System.Drawing.Size(88, 16);
            this.lblKostenplaats.TabIndex = 55;
            this.lblKostenplaats.Text = "Kostenplaats:";
            // 
            // lblWieKooptHet
            // 
            this.lblWieKooptHet.AutoSize = true;
            this.lblWieKooptHet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWieKooptHet.Location = new System.Drawing.Point(787, 195);
            this.lblWieKooptHet.Name = "lblWieKooptHet";
            this.lblWieKooptHet.Size = new System.Drawing.Size(69, 16);
            this.lblWieKooptHet.TabIndex = 54;
            this.lblWieKooptHet.Text = "Aankoper:";
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
            this.ddlStatus.Location = new System.Drawing.Point(956, 245);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(270, 24);
            this.ddlStatus.TabIndex = 62;
            // 
            // lblGoedgekeurdeBedrag
            // 
            this.lblGoedgekeurdeBedrag.AutoSize = true;
            this.lblGoedgekeurdeBedrag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGoedgekeurdeBedrag.Location = new System.Drawing.Point(19, 265);
            this.lblGoedgekeurdeBedrag.Name = "lblGoedgekeurdeBedrag";
            this.lblGoedgekeurdeBedrag.Size = new System.Drawing.Size(153, 16);
            this.lblGoedgekeurdeBedrag.TabIndex = 63;
            this.lblGoedgekeurdeBedrag.Text = "Goedgekeurde Bedrag: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(787, 248);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 59;
            this.lblStatus.Text = "Status:";
            // 
            // txtGoedgekeurdeBedrag
            // 
            this.txtGoedgekeurdeBedrag.AccessibleName = "txtGoedgekeurdeBedrag";
            this.txtGoedgekeurdeBedrag.Location = new System.Drawing.Point(188, 262);
            this.txtGoedgekeurdeBedrag.Name = "txtGoedgekeurdeBedrag";
            this.txtGoedgekeurdeBedrag.ReadOnly = true;
            this.txtGoedgekeurdeBedrag.Size = new System.Drawing.Size(270, 22);
            this.txtGoedgekeurdeBedrag.TabIndex = 58;
            // 
            // lblBedragExBtw
            // 
            this.lblBedragExBtw.AutoSize = true;
            this.lblBedragExBtw.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBedragExBtw.Location = new System.Drawing.Point(19, 305);
            this.lblBedragExBtw.Name = "lblBedragExBtw";
            this.lblBedragExBtw.Size = new System.Drawing.Size(107, 16);
            this.lblBedragExBtw.TabIndex = 66;
            this.lblBedragExBtw.Text = "Bedrag Ex BTW:";
            // 
            // txtBedragExBtw
            // 
            this.txtBedragExBtw.AccessibleName = "";
            this.txtBedragExBtw.Location = new System.Drawing.Point(188, 302);
            this.txtBedragExBtw.Name = "txtBedragExBtw";
            this.txtBedragExBtw.Size = new System.Drawing.Size(270, 22);
            this.txtBedragExBtw.TabIndex = 65;
            // 
            // lblBTWPercentage
            // 
            this.lblBTWPercentage.AutoSize = true;
            this.lblBTWPercentage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBTWPercentage.Location = new System.Drawing.Point(19, 343);
            this.lblBTWPercentage.Name = "lblBTWPercentage";
            this.lblBTWPercentage.Size = new System.Drawing.Size(114, 16);
            this.lblBTWPercentage.TabIndex = 68;
            this.lblBTWPercentage.Text = "BTW Percentage:";
            // 
            // txtBTWPercentage
            // 
            this.txtBTWPercentage.AccessibleName = "";
            this.txtBTWPercentage.Location = new System.Drawing.Point(188, 340);
            this.txtBTWPercentage.Name = "txtBTWPercentage";
            this.txtBTWPercentage.Size = new System.Drawing.Size(270, 22);
            this.txtBTWPercentage.TabIndex = 67;
            // 
            // lblBedragInBTW
            // 
            this.lblBedragInBTW.AutoSize = true;
            this.lblBedragInBTW.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBedragInBTW.Location = new System.Drawing.Point(19, 383);
            this.lblBedragInBTW.Name = "lblBedragInBTW";
            this.lblBedragInBTW.Size = new System.Drawing.Size(102, 16);
            this.lblBedragInBTW.TabIndex = 70;
            this.lblBedragInBTW.Text = "Bedrag In BTW:";
            // 
            // txtBedragInBTW
            // 
            this.txtBedragInBTW.AccessibleName = "";
            this.txtBedragInBTW.Location = new System.Drawing.Point(188, 380);
            this.txtBedragInBTW.Name = "txtBedragInBTW";
            this.txtBedragInBTW.ReadOnly = true;
            this.txtBedragInBTW.Size = new System.Drawing.Size(270, 22);
            this.txtBedragInBTW.TabIndex = 69;
            // 
            // lblBedragTransfer
            // 
            this.lblBedragTransfer.AutoSize = true;
            this.lblBedragTransfer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBedragTransfer.Location = new System.Drawing.Point(19, 420);
            this.lblBedragTransfer.Name = "lblBedragTransfer";
            this.lblBedragTransfer.Size = new System.Drawing.Size(102, 16);
            this.lblBedragTransfer.TabIndex = 72;
            this.lblBedragTransfer.Text = "Bedrag transfer:";
            // 
            // txtBedragTransfer
            // 
            this.txtBedragTransfer.AccessibleName = "";
            this.txtBedragTransfer.Location = new System.Drawing.Point(188, 417);
            this.txtBedragTransfer.Name = "txtBedragTransfer";
            this.txtBedragTransfer.ReadOnly = true;
            this.txtBedragTransfer.Size = new System.Drawing.Size(270, 22);
            this.txtBedragTransfer.TabIndex = 71;
            // 
            // frmAankoopDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 686);
            this.Controls.Add(this.lblBedragTransfer);
            this.Controls.Add(this.txtBedragTransfer);
            this.Controls.Add(this.lblBedragInBTW);
            this.Controls.Add(this.txtBedragInBTW);
            this.Controls.Add(this.lblBTWPercentage);
            this.Controls.Add(this.txtBTWPercentage);
            this.Controls.Add(this.lblBedragExBtw);
            this.Controls.Add(this.txtBedragExBtw);
            this.Controls.Add(this.ddlStatus);
            this.Controls.Add(this.lblGoedgekeurdeBedrag);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtGoedgekeurdeBedrag);
            this.Controls.Add(this.ddlWieKooptHet);
            this.Controls.Add(this.ddlKostenplaats);
            this.Controls.Add(this.ddlFinancieringsjaar);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.lblKostenplaats);
            this.Controls.Add(this.lblWieKooptHet);
            this.Controls.Add(this.rtxtOmschrijving);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.btn_Bewaren);
            this.Controls.Add(this.btn_Nieuw);
            this.Controls.Add(this.txtAanvraagId);
            this.Controls.Add(this.lblAankoopId);
            this.Controls.Add(this.lblAankoopDetail);
            this.Name = "frmAankoopDetail";
            this.Text = "AankoopDetail";
            this.Load += new System.EventHandler(this.frmAankoopDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAankoopDetail;
        private System.Windows.Forms.Label lblAankoopId;
        private System.Windows.Forms.TextBox txtAanvraagId;
        private System.Windows.Forms.Button btn_Nieuw;
        private System.Windows.Forms.Button btn_Bewaren;
        private System.Windows.Forms.RichTextBox rtxtOmschrijving;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.ComboBox ddlWieKooptHet;
        private System.Windows.Forms.ComboBox ddlKostenplaats;
        private System.Windows.Forms.ComboBox ddlFinancieringsjaar;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Label lblKostenplaats;
        private System.Windows.Forms.Label lblWieKooptHet;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.Label lblGoedgekeurdeBedrag;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtGoedgekeurdeBedrag;
        private System.Windows.Forms.Label lblBedragExBtw;
        private System.Windows.Forms.TextBox txtBedragExBtw;
        private System.Windows.Forms.Label lblBTWPercentage;
        private System.Windows.Forms.TextBox txtBTWPercentage;
        private System.Windows.Forms.Label lblBedragInBTW;
        private System.Windows.Forms.TextBox txtBedragInBTW;
        private System.Windows.Forms.Label lblBedragTransfer;
        private System.Windows.Forms.TextBox txtBedragTransfer;
    }
}