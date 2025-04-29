namespace MiaClient
{
    partial class frmGrafiekBudgetSpreiding
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.gbxFinancieringsjaar = new System.Windows.Forms.GroupBox();
            this.cmbFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            this.chartBudgetspreiding = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxFinancieringsjaar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudgetspreiding)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFinancieringsjaar
            // 
            this.gbxFinancieringsjaar.Controls.Add(this.cmbFinancieringsjaar);
            this.gbxFinancieringsjaar.Controls.Add(this.lblFinancieringsjaar);
            this.gbxFinancieringsjaar.Location = new System.Drawing.Point(13, 13);
            this.gbxFinancieringsjaar.Name = "gbxFinancieringsjaar";
            this.gbxFinancieringsjaar.Size = new System.Drawing.Size(1042, 110);
            this.gbxFinancieringsjaar.TabIndex = 0;
            this.gbxFinancieringsjaar.TabStop = false;
            this.gbxFinancieringsjaar.Text = "Selecteer een financieringsjaar";
            // 
            // cmbFinancieringsjaar
            // 
            this.cmbFinancieringsjaar.FormattingEnabled = true;
            this.cmbFinancieringsjaar.Location = new System.Drawing.Point(145, 44);
            this.cmbFinancieringsjaar.Name = "cmbFinancieringsjaar";
            this.cmbFinancieringsjaar.Size = new System.Drawing.Size(209, 33);
            this.cmbFinancieringsjaar.TabIndex = 4;
            this.cmbFinancieringsjaar.SelectedIndexChanged += new System.EventHandler(this.cmbFinancieringsjaar_SelectedIndexChanged);
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(8, 47);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(156, 25);
            this.lblFinancieringsjaar.TabIndex = 3;
            this.lblFinancieringsjaar.Text = "Financieringsjaar : ";
            // 
            // chartBudgetspreiding
            // 
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.Name = "ChartArea1";
            this.chartBudgetspreiding.ChartAreas.Add(chartArea1);
            this.chartBudgetspreiding.Location = new System.Drawing.Point(13, 129);
            this.chartBudgetspreiding.Name = "chartBudgetspreiding";
            this.chartBudgetspreiding.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.chartBudgetspreiding.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartBudgetspreiding.Size = new System.Drawing.Size(1042, 551);
            this.chartBudgetspreiding.TabIndex = 1;
            this.chartBudgetspreiding.Text = "chart1";
            // 
            // frmGrafiekBudgetSpreiding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.chartBudgetspreiding);
            this.Controls.Add(this.gbxFinancieringsjaar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrafiekBudgetSpreiding";
            this.Text = "Budgetspreiding";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGrafiekBudgetSpreiding_FormClosing);
            this.Load += new System.EventHandler(this.frmGrafiekBudgetSpreiding_Load);
            this.gbxFinancieringsjaar.ResumeLayout(false);
            this.gbxFinancieringsjaar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBudgetspreiding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFinancieringsjaar;
        private System.Windows.Forms.ComboBox cmbFinancieringsjaar;
        private System.Windows.Forms.Label lblFinancieringsjaar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBudgetspreiding;
    }
}