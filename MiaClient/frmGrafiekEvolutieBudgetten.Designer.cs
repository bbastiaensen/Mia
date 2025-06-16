namespace MiaClient
{
    partial class frmGrafiekEvolutieBudgetten
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.evoBudgGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evoBudgDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evo_Budg_DataSet = new MiaClient.Evo_Budg_DataSet();
            this.evo_Budg_G_TableAdapter = new MiaClient.Evo_Budg_DataSetTableAdapters.Evo_Budg_G_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evoBudgGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evoBudgDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evo_Budg_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.evoBudgGBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "aangv. bedr";
            series1.XValueMember = "Jaar";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueMembers = "TotaalBedrag";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "toegk. bedr";
            series2.XValueMember = "Jaar";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueMembers = "SomVanToegekend";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1043, 668);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // evoBudgGBindingSource
            // 
            this.evoBudgGBindingSource.DataMember = "Evo_Budg_G";
            this.evoBudgGBindingSource.DataSource = this.evoBudgDataSetBindingSource;
            // 
            // evoBudgDataSetBindingSource
            // 
            this.evoBudgDataSetBindingSource.DataSource = this.evo_Budg_DataSet;
            this.evoBudgDataSetBindingSource.Position = 0;
            // 
            // evo_Budg_DataSet
            // 
            this.evo_Budg_DataSet.DataSetName = "Evo_Budg_DataSet";
            this.evo_Budg_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evo_Budg_G_TableAdapter
            // 
            this.evo_Budg_G_TableAdapter.ClearBeforeFill = true;
            // 
            // frmGrafiekEvolutieBudgetten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGrafiekEvolutieBudgetten";
            this.Text = "Evolutie Budgetten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGrafiekEvolutieBudgetten_FormClosing);
            this.Load += new System.EventHandler(this.frmGrafiekEvolutieBudgetten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evoBudgGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evoBudgDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evo_Budg_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource evoBudgDataSetBindingSource;
        private Evo_Budg_DataSet evo_Budg_DataSet;
        private System.Windows.Forms.BindingSource evoBudgGBindingSource;
        private Evo_Budg_DataSetTableAdapters.Evo_Budg_G_TableAdapter evo_Budg_G_TableAdapter;
    }
}