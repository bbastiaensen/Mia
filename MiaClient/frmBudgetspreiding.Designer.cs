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
            this.pnlBudgetspreiding = new System.Windows.Forms.Panel();
            this.gbxFinanciersjaar = new System.Windows.Forms.GroupBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.cmbJaar = new System.Windows.Forms.ComboBox();
            this.gbxFinanciersjaar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBudgetspreiding
            // 
            this.pnlBudgetspreiding.Location = new System.Drawing.Point(12, 167);
            this.pnlBudgetspreiding.Name = "pnlBudgetspreiding";
            this.pnlBudgetspreiding.Size = new System.Drawing.Size(776, 271);
            this.pnlBudgetspreiding.TabIndex = 0;
            // 
            // gbxFinanciersjaar
            // 
            this.gbxFinanciersjaar.Controls.Add(this.cmbJaar);
            this.gbxFinanciersjaar.Controls.Add(this.btnExport);
            this.gbxFinanciersjaar.Controls.Add(this.lblFinancieringsjaar);
            this.gbxFinanciersjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFinanciersjaar.Location = new System.Drawing.Point(49, 41);
            this.gbxFinanciersjaar.Name = "gbxFinanciersjaar";
            this.gbxFinanciersjaar.Size = new System.Drawing.Size(652, 100);
            this.gbxFinanciersjaar.TabIndex = 1;
            this.gbxFinanciersjaar.TabStop = false;
            this.gbxFinanciersjaar.Text = "Selecteer de richtperiode";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(32, 48);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(151, 25);
            this.lblFinancieringsjaar.TabIndex = 0;
            this.lblFinancieringsjaar.Text = "Financieringsjaar :";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(488, 38);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(111, 35);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Exporteer";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // cmbJaar
            // 
            this.cmbJaar.FormattingEnabled = true;
            this.cmbJaar.Location = new System.Drawing.Point(256, 45);
            this.cmbJaar.Name = "cmbJaar";
            this.cmbJaar.Size = new System.Drawing.Size(121, 33);
            this.cmbJaar.TabIndex = 2;
            // 
            // frmBudgetspreiding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxFinanciersjaar);
            this.Controls.Add(this.pnlBudgetspreiding);
            this.Name = "frmBudgetspreiding";
            this.Text = "frmBudgetspreiding";
            this.Load += new System.EventHandler(this.frmBudgetspreiding_Load);
            this.gbxFinanciersjaar.ResumeLayout(false);
            this.gbxFinanciersjaar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBudgetspreiding;
        private System.Windows.Forms.GroupBox gbxFinanciersjaar;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cmbJaar;
    }
}