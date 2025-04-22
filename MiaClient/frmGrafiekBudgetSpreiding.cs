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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmGrafiekBudgetSpreiding : Form
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

        private void frmGrafiekBudgetSpreiding_Load(object sender, EventArgs e)
        {
            CreateUI();

            List<string> finJaren = FinancieringsjaarManager.GetFinancieringsjaren();
            foreach (string jaar in finJaren)
            {
                cmbFinancieringsjaar.Items.Add(jaar);
            }
        }

        private void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            this.Icon = imgFormIcon;
        }

        private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartBudgetspreiding.ResetAutoValues();
            string finjaar = cmbFinancieringsjaar.SelectedItem.ToString();
            chartBudgetspreiding.Series.Clear();

            List<Richtperiode> richtperiodes = RichtperiodeManager.GetRichtperiodes();
            List<Aanvraag> aanvragen = new List<Aanvraag>();
            aanvragen.Clear();
            foreach(Aanvraag ah in AanvraagManager.GetAanvragen())
            {
                if (ah.Financieringsjaar == finjaar)
                {
                    aanvragen.Add(ah);
                }
            }
            chartBudgetspreiding.Series.Add("grafiek");
            foreach (Richtperiode r in richtperiodes) {
                decimal budget = 0;
                foreach (Aanvraag a in aanvragen)
                {
                    if (a.RichtperiodeId == r.Id)
                    {
                        budget += a.AantalStuk * a.PrijsIndicatieStuk;
                    }
                }


                chartBudgetspreiding.Series["grafiek"].IsValueShownAsLabel = true;
                chartBudgetspreiding.Series["grafiek"].Points.AddXY(r.Id, Convert.ToDouble(budget));
                chartBudgetspreiding.Series["grafiek"].Points[0].AxisLabel = "nog geen";
                chartBudgetspreiding.ChartAreas["ChartArea1"].AxisX.Title = "Maanden";
                chartBudgetspreiding.ChartAreas["ChartArea1"].AxisY.Title = "Budget gebruikt";
            }
        }
    }
}
