namespace MiaClient
{
    partial class frmGrafiekStatusAanvraagPerFinancieringsjaar
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.chartStatusAanvraag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatusAanvraag)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFinancieringsjaar
            // 
            this.cmbFinancieringsjaar.FormattingEnabled = true;
            this.cmbFinancieringsjaar.Location = new System.Drawing.Point(204, 48);
            this.cmbFinancieringsjaar.Name = "cmbFinancieringsjaar";
            this.cmbFinancieringsjaar.Size = new System.Drawing.Size(188, 33);
            this.cmbFinancieringsjaar.TabIndex = 0;
            this.cmbFinancieringsjaar.SelectedIndexChanged += new System.EventHandler(this.cmbFinancieringsjaar_SelectedIndexChanged);
            // 
            // chartStatusAanvraag
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatusAanvraag.ChartAreas.Add(chartArea1);
            this.chartStatusAanvraag.Location = new System.Drawing.Point(26, 141);
            this.chartStatusAanvraag.Name = "chartStatusAanvraag";
            this.chartStatusAanvraag.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartStatusAanvraag.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Silver,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Maroon,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Navy,
        System.Drawing.Color.Fuchsia};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Taart";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartStatusAanvraag.Series.Add(series1);
            this.chartStatusAanvraag.Size = new System.Drawing.Size(1017, 539);
            this.chartStatusAanvraag.TabIndex = 1;
            this.chartStatusAanvraag.Text = "Overzicht Aanvraagstatus";
            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.AutoSize = true;
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(26, 51);
            this.lblFinancieringsjaar.Name = "lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(160, 25);
            this.lblFinancieringsjaar.TabIndex = 2;
            this.lblFinancieringsjaar.Text = "Financieringsjaar:";
            // 
            // frmGrafiekStatusAanvraagPerFinancieringsjaar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.lblFinancieringsjaar);
            this.Controls.Add(this.cmbFinancieringsjaar);
            this.Controls.Add(this.chartStatusAanvraag);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrafiekStatusAanvraagPerFinancieringsjaar";
            this.Text = "Status Aanvraag per Financieringsjaar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGrafiekStatusAanvraagPerFinancieringsjaar_FormClosing);
            this.Load += new System.EventHandler(this.frmGrafiekStatusAanvraagPerFinancieringsjaar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatusAanvraag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFinancieringsjaar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatusAanvraag;
        private System.Windows.Forms.Label lblFinancieringsjaar;
    }
}