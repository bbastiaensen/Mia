namespace MiaClient
{
    partial class FrmGebruiksLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGebruiksLog));
            this.lblGebruiksLogTitel = new System.Windows.Forms.Label();
            this.dtpVan = new System.Windows.Forms.DateTimePicker();
            this.grpbxFilter = new System.Windows.Forms.GroupBox();
            this.chkTot = new System.Windows.Forms.CheckBox();
            this.chkVan = new System.Windows.Forms.CheckBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblGebruiker = new System.Windows.Forms.Label();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.txtGebruiker = new System.Windows.Forms.TextBox();
            this.dtpTot = new System.Windows.Forms.DateTimePicker();
            this.pnlGebruiksLogItems = new System.Windows.Forms.Panel();
            this.lblIdDetail = new System.Windows.Forms.Label();
            this.lblGebruikerDetail = new System.Windows.Forms.Label();
            this.lblTijdstipActieDetail = new System.Windows.Forms.Label();
            this.lblOmschrijvingDetail = new System.Windows.Forms.Label();
            this.txtIdDetail = new System.Windows.Forms.TextBox();
            this.txtOmschrijvingDetail = new System.Windows.Forms.TextBox();
            this.txtGebruikerDetail = new System.Windows.Forms.TextBox();
            this.txtTijdstipActieDetail = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.picFirst = new System.Windows.Forms.PictureBox();
            this.grpbxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGebruiksLogTitel
            // 
            this.lblGebruiksLogTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruiksLogTitel.Location = new System.Drawing.Point(12, 9);
            this.lblGebruiksLogTitel.Name = "lblGebruiksLogTitel";
            this.lblGebruiksLogTitel.Size = new System.Drawing.Size(865, 24);
            this.lblGebruiksLogTitel.TabIndex = 0;
            this.lblGebruiksLogTitel.Text = "MIA - Gebruikslog";
            this.lblGebruiksLogTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpVan
            // 
            this.dtpVan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVan.Location = new System.Drawing.Point(61, 19);
            this.dtpVan.Name = "dtpVan";
            this.dtpVan.Size = new System.Drawing.Size(192, 29);
            this.dtpVan.TabIndex = 1;
            // 
            // grpbxFilter
            // 
            this.grpbxFilter.Controls.Add(this.chkTot);
            this.grpbxFilter.Controls.Add(this.chkVan);
            this.grpbxFilter.Controls.Add(this.lblOmschrijving);
            this.grpbxFilter.Controls.Add(this.lblGebruiker);
            this.grpbxFilter.Controls.Add(this.txtOmschrijving);
            this.grpbxFilter.Controls.Add(this.txtGebruiker);
            this.grpbxFilter.Controls.Add(this.dtpTot);
            this.grpbxFilter.Controls.Add(this.dtpVan);
            this.grpbxFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxFilter.Location = new System.Drawing.Point(13, 37);
            this.grpbxFilter.Name = "grpbxFilter";
            this.grpbxFilter.Size = new System.Drawing.Size(929, 100);
            this.grpbxFilter.TabIndex = 2;
            this.grpbxFilter.TabStop = false;
            this.grpbxFilter.Text = "Filteren";
            // 
            // chkTot
            // 
            this.chkTot.AutoSize = true;
            this.chkTot.Location = new System.Drawing.Point(6, 56);
            this.chkTot.Name = "chkTot";
            this.chkTot.Size = new System.Drawing.Size(49, 25);
            this.chkTot.TabIndex = 8;
            this.chkTot.Text = "Tot";
            this.chkTot.UseVisualStyleBackColor = true;
            // 
            // chkVan
            // 
            this.chkVan.AutoSize = true;
            this.chkVan.Location = new System.Drawing.Point(6, 24);
            this.chkVan.Name = "chkVan";
            this.chkVan.Size = new System.Drawing.Size(55, 25);
            this.chkVan.TabIndex = 7;
            this.chkVan.Text = "Van";
            this.chkVan.UseVisualStyleBackColor = true;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Location = new System.Drawing.Point(417, 25);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(103, 21);
            this.lblOmschrijving.TabIndex = 6;
            this.lblOmschrijving.Text = "Omschrijving";
            // 
            // lblGebruiker
            // 
            this.lblGebruiker.AutoSize = true;
            this.lblGebruiker.Location = new System.Drawing.Point(259, 25);
            this.lblGebruiker.Name = "lblGebruiker";
            this.lblGebruiker.Size = new System.Drawing.Size(79, 21);
            this.lblGebruiker.TabIndex = 5;
            this.lblGebruiker.Text = "Gebruiker";
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOmschrijving.Location = new System.Drawing.Point(411, 54);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(512, 29);
            this.txtOmschrijving.TabIndex = 4;
            // 
            // txtGebruiker
            // 
            this.txtGebruiker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruiker.Location = new System.Drawing.Point(259, 54);
            this.txtGebruiker.Name = "txtGebruiker";
            this.txtGebruiker.Size = new System.Drawing.Size(146, 29);
            this.txtGebruiker.TabIndex = 3;
            // 
            // dtpTot
            // 
            this.dtpTot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTot.Location = new System.Drawing.Point(61, 54);
            this.dtpTot.Name = "dtpTot";
            this.dtpTot.Size = new System.Drawing.Size(192, 29);
            this.dtpTot.TabIndex = 2;
            // 
            // pnlGebruiksLogItems
            // 
            this.pnlGebruiksLogItems.AutoScroll = true;
            this.pnlGebruiksLogItems.Location = new System.Drawing.Point(12, 143);
            this.pnlGebruiksLogItems.Name = "pnlGebruiksLogItems";
            this.pnlGebruiksLogItems.Size = new System.Drawing.Size(930, 311);
            this.pnlGebruiksLogItems.TabIndex = 3;
            this.pnlGebruiksLogItems.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGebruiksLogItems_Paint);
            // 
            // lblIdDetail
            // 
            this.lblIdDetail.AutoSize = true;
            this.lblIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDetail.Location = new System.Drawing.Point(17, 499);
            this.lblIdDetail.Name = "lblIdDetail";
            this.lblIdDetail.Size = new System.Drawing.Size(26, 21);
            this.lblIdDetail.TabIndex = 4;
            this.lblIdDetail.Text = "Id:";
            // 
            // lblGebruikerDetail
            // 
            this.lblGebruikerDetail.AutoSize = true;
            this.lblGebruikerDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruikerDetail.Location = new System.Drawing.Point(17, 534);
            this.lblGebruikerDetail.Name = "lblGebruikerDetail";
            this.lblGebruikerDetail.Size = new System.Drawing.Size(82, 21);
            this.lblGebruikerDetail.TabIndex = 5;
            this.lblGebruikerDetail.Text = "Gebruiker:";
            // 
            // lblTijdstipActieDetail
            // 
            this.lblTijdstipActieDetail.AutoSize = true;
            this.lblTijdstipActieDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTijdstipActieDetail.Location = new System.Drawing.Point(486, 499);
            this.lblTijdstipActieDetail.Name = "lblTijdstipActieDetail";
            this.lblTijdstipActieDetail.Size = new System.Drawing.Size(99, 21);
            this.lblTijdstipActieDetail.TabIndex = 6;
            this.lblTijdstipActieDetail.Text = "Tijdstip actie:";
            // 
            // lblOmschrijvingDetail
            // 
            this.lblOmschrijvingDetail.AutoSize = true;
            this.lblOmschrijvingDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmschrijvingDetail.Location = new System.Drawing.Point(17, 569);
            this.lblOmschrijvingDetail.Name = "lblOmschrijvingDetail";
            this.lblOmschrijvingDetail.Size = new System.Drawing.Size(106, 21);
            this.lblOmschrijvingDetail.TabIndex = 7;
            this.lblOmschrijvingDetail.Text = "Omschrijving:";
            // 
            // txtIdDetail
            // 
            this.txtIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetail.Location = new System.Drawing.Point(148, 496);
            this.txtIdDetail.Name = "txtIdDetail";
            this.txtIdDetail.ReadOnly = true;
            this.txtIdDetail.Size = new System.Drawing.Size(302, 29);
            this.txtIdDetail.TabIndex = 8;
            // 
            // txtOmschrijvingDetail
            // 
            this.txtOmschrijvingDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOmschrijvingDetail.Location = new System.Drawing.Point(148, 566);
            this.txtOmschrijvingDetail.Multiline = true;
            this.txtOmschrijvingDetail.Name = "txtOmschrijvingDetail";
            this.txtOmschrijvingDetail.ReadOnly = true;
            this.txtOmschrijvingDetail.Size = new System.Drawing.Size(788, 228);
            this.txtOmschrijvingDetail.TabIndex = 9;
            // 
            // txtGebruikerDetail
            // 
            this.txtGebruikerDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGebruikerDetail.Location = new System.Drawing.Point(148, 531);
            this.txtGebruikerDetail.Name = "txtGebruikerDetail";
            this.txtGebruikerDetail.ReadOnly = true;
            this.txtGebruikerDetail.Size = new System.Drawing.Size(788, 29);
            this.txtGebruikerDetail.TabIndex = 10;
            // 
            // txtTijdstipActieDetail
            // 
            this.txtTijdstipActieDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTijdstipActieDetail.Location = new System.Drawing.Point(591, 496);
            this.txtTijdstipActieDetail.Name = "txtTijdstipActieDetail";
            this.txtTijdstipActieDetail.ReadOnly = true;
            this.txtTijdstipActieDetail.Size = new System.Drawing.Size(345, 29);
            this.txtTijdstipActieDetail.TabIndex = 11;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(13, 11);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(129, 30);
            this.btnFilter.TabIndex = 28;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // picFirst
            // 
            this.picFirst.Location = new System.Drawing.Point(12, 460);
            this.picFirst.Name = "picFirst";
            this.picFirst.Size = new System.Drawing.Size(30, 30);
            this.picFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFirst.TabIndex = 29;
            this.picFirst.TabStop = false;
            // 
            // FrmGebruiksLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 806);
            this.Controls.Add(this.picFirst);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtTijdstipActieDetail);
            this.Controls.Add(this.txtGebruikerDetail);
            this.Controls.Add(this.txtOmschrijvingDetail);
            this.Controls.Add(this.txtIdDetail);
            this.Controls.Add(this.lblOmschrijvingDetail);
            this.Controls.Add(this.lblTijdstipActieDetail);
            this.Controls.Add(this.lblGebruikerDetail);
            this.Controls.Add(this.lblIdDetail);
            this.Controls.Add(this.pnlGebruiksLogItems);
            this.Controls.Add(this.grpbxFilter);
            this.Controls.Add(this.lblGebruiksLogTitel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGebruiksLog";
            this.Text = "Gebruikslog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGebruiksLog_FormClosing);
            this.Load += new System.EventHandler(this.frmGebruiksLogDemo_Load);
            this.Shown += new System.EventHandler(this.FrmGebruiksLog_Shown);
            this.grpbxFilter.ResumeLayout(false);
            this.grpbxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGebruiksLogTitel;
        private System.Windows.Forms.DateTimePicker dtpVan;
        private System.Windows.Forms.GroupBox grpbxFilter;
        private System.Windows.Forms.DateTimePicker dtpTot;
        private System.Windows.Forms.TextBox txtGebruiker;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblGebruiker;
        private System.Windows.Forms.CheckBox chkTot;
        private System.Windows.Forms.CheckBox chkVan;
        private System.Windows.Forms.Panel pnlGebruiksLogItems;
        private System.Windows.Forms.Label lblIdDetail;
        private System.Windows.Forms.Label lblGebruikerDetail;
        private System.Windows.Forms.Label lblTijdstipActieDetail;
        private System.Windows.Forms.Label lblOmschrijvingDetail;
        private System.Windows.Forms.TextBox txtIdDetail;
        private System.Windows.Forms.TextBox txtOmschrijvingDetail;
        private System.Windows.Forms.TextBox txtGebruikerDetail;
        private System.Windows.Forms.TextBox txtTijdstipActieDetail;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.PictureBox picFirst;
    }
}