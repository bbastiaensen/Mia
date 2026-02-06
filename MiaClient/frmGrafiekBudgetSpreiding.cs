using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MiaClient
{
    public partial class frmGrafiekBudgetSpreiding : MdiChildBoundedForm
    {
        Icon imgFormIcon = Icon.FromHandle((new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-pie-chart-48.png")).GetHicon()));

        public frmGrafiekBudgetSpreiding()
        {
            InitializeComponent();
        }

        private void frmGrafiekBudgetSpreiding_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }
        List<Color> kleuren = new List<Color>();
        private void frmGrafiekBudgetSpreiding_Load(object sender, EventArgs e)
        {
            CreateUI();

            List<string> finJaren = AanvraagManager.GetAlleFinancieringsjaren();
            cmbFinancieringsjaar.ValueMember = "Financieringsjaar";
            cmbFinancieringsjaar.DisplayMember = "Financieringsjaar";
            cmbFinancieringsjaar.DataSource = finJaren;
        }

        public void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            this.Icon = imgFormIcon;
        }

        private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //values worden gereset 
                chartBudgetspreiding.ResetAutoValues();
                chartBudgetspreiding.Series.Clear();
                //finjaar wordt opgehaald
                string finjaar = cmbFinancieringsjaar.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(finjaar))
                {
                    //aanvragen en richtperiodes worden gevraagd en gefilterd
                    List<Richtperiode> richtperiodes = RichtperiodeManager.GetRichtperiodes();
                    List<Aanvraag> aanvragen = AanvraagManager.GetAanvragenByFinancieringsjaarAndStatus(finjaar, 4);

                    if (aanvragen != null)
                    {
                        //series voor de chart
                        chartBudgetspreiding.Series.Add("Grafiek").Font = new Font("Segoe UI", 11);
                        //voor elke richtperiode
                        foreach (Richtperiode r in richtperiodes)
                        {
                            decimal budget = 0;
                            //voor elke aanvraag
                            foreach (Aanvraag a in aanvragen)
                            {
                                //richtperiode wordt nagekeken en budget berekend
                                if (a.RichtperiodeId == r.Id)
                                {
                                    budget += a.BudgetToegekend;
                                }
                            }
                            //punt wordt toegevoegd -> een voor elke richtperiode
                            chartBudgetspreiding.Series["Grafiek"].IsValueShownAsLabel = true;
                            chartBudgetspreiding.Series["Grafiek"].Points.AddXY(r.Id, Convert.ToDouble(budget));

                        }
                        //titels voor de grafiek
                        chartBudgetspreiding.ChartAreas["ChartArea1"].AxisX.Title = "Maanden";
                        chartBudgetspreiding.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Segoe UI", 11);
                        chartBudgetspreiding.ChartAreas["ChartArea1"].AxisY.Title = "Budget gebruikt";
                        chartBudgetspreiding.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Segoe UI", 11);
                        //label voor richtperiode nog geen
                        chartBudgetspreiding.Series["Grafiek"].Points[0].AxisLabel = "nog geen";
                    }
                    else
                    {
                        MessageBox.Show("Er zijn geen aanvragen die bekrachtigd zijn voor het geselecteerde jaar.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het genereren van het de grafiek. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
