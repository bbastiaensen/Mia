namespace MiaClient
{
    partial class frmBudgetspreiding
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
            this.gbxFinancieringsjaar = new System.Windows.Forms.GroupBox();
            this.btnExporteer = new System.Windows.Forms.Button();
            this.cmbFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.pnlRichtperiode = new System.Windows.Forms.Panel();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lblLineThe2nd = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.gbxFinancieringsjaar.SuspendLayout();
            this.pnlRichtperiode.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFinancieringsjaar
            // 
            this.gbxFinancieringsjaar.Controls.Add(this.btnExporteer);
            this.gbxFinancieringsjaar.Controls.Add(this.cmbFinancieringsjaar);
            this.gbxFinancieringsjaar.Controls.Add(this.lblFinancieringsjaar);
            this.gbxFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFinancieringsjaar.Location = new System.Drawing.Point(12, 12);
            this.gbxFinancieringsjaar.Name = "gbxFinancieringsjaar";
            this.gbxFinancieringsjaar.Size = new System.Drawing.Size(776, 83);
            this.gbxFinancieringsjaar.TabIndex = 0;
            this.gbxFinancieringsjaar.TabStop = false;
            this.gbxFinancieringsjaar.Text = "selecteer een richtperiode";
            // 
            // btnExporteer
            // 
            this.btnExporteer.Location = new System.Drawing.Point(486, 33);
            this.btnExporteer.Name = "btnExporteer";
            this.btnExporteer.Size = new System.Drawing.Size(215, 27);
            this.btnExporteer.TabIndex = 2;
            this.btnExporteer.Text = "Exporteer";
            this.btnExporteer.UseVisualStyleBackColor = true;
            // 
            // cmbFinancieringsjaar
            // 
            this.cmbFinancieringsjaar.FormattingEnabled = true;
            this.cmbFinancieringsjaar.Location = new System.Drawing.Point(143, 33);
            this.cmbFinancieringsjaar.Name = "cmbFinancieringsjaar";
            this.cmbFinancieringsjaar.Size = new System.Drawing.Size(209, 33);
            this.cmbFinancieringsjaar.TabIndex = 2;
            this.cmbFinancieringsjaar.SelectedIndexChanged += new System.EventHandler(this.cmbFinancieringsjaar_SelectedIndexChanged);
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(6, 36);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(156, 25);
            this.lblFinancieringsjaar.TabIndex = 1;
            this.lblFinancieringsjaar.Text = "Financieringsjaar : ";
            // 
            // pnlRichtperiode
            // 
            this.pnlRichtperiode.Controls.Add(this.lblTotaal);
            this.pnlRichtperiode.Controls.Add(this.lblLineThe2nd);
            this.pnlRichtperiode.Controls.Add(this.lblLine);
            this.pnlRichtperiode.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRichtperiode.Location = new System.Drawing.Point(12, 101);
            this.pnlRichtperiode.Name = "pnlRichtperiode";
            this.pnlRichtperiode.Size = new System.Drawing.Size(776, 450);
            this.pnlRichtperiode.TabIndex = 1;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaal.Location = new System.Drawing.Point(16, 390);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(72, 25);
            this.lblTotaal.TabIndex = 17;
            this.lblTotaal.Text = "Totaal : ";
            // 
            // lblLineThe2nd
            // 
            this.lblLineThe2nd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLineThe2nd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLineThe2nd.Location = new System.Drawing.Point(11, 361);
            this.lblLineThe2nd.Name = "lblLineThe2nd";
            this.lblLineThe2nd.Size = new System.Drawing.Size(200, 10);
            this.lblLineThe2nd.TabIndex = 16;
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(217, 7);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(10, 364);
            this.lblLine.TabIndex = 15;
            // 
            // frmBudgetspreiding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.pnlRichtperiode);
            this.Controls.Add(this.gbxFinancieringsjaar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmBudgetspreiding";
            this.Text = "Budgetspreiding";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBudgetSpreiding_FormClosing);
            this.Load += new System.EventHandler(this.frmBudgetspreiding_Load);
            this.gbxFinancieringsjaar.ResumeLayout(false);
            this.gbxFinancieringsjaar.PerformLayout();
            this.pnlRichtperiode.ResumeLayout(false);
            this.pnlRichtperiode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFinancieringsjaar;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Panel pnlRichtperiode;
        private System.Windows.Forms.Button btnExporteer;
        private System.Windows.Forms.ComboBox cmbFinancieringsjaar;
        private System.Windows.Forms.Label lblLineThe2nd;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblTotaal;
    }
}