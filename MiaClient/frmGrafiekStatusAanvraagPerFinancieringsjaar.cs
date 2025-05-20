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
using System.Windows.Forms.DataVisualization.Charting;                      

namespace MiaClient
{
    public partial class frmGrafiekStatusAanvraagPerFinancieringsjaar : Form
    {
        Icon imgFormIcon = Icon.FromHandle((new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-pie-chart-48.png")).GetHicon()));

        public frmGrafiekStatusAanvraagPerFinancieringsjaar()
        {
            InitializeComponent();
        }

        private void frmGrafiekStatusAanvraagPerFinancieringsjaar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            this.Icon = imgFormIcon;
        }

        private void frmGrafiekStatusAanvraagPerFinancieringsjaar_Load(object sender, EventArgs e)
        {
            CreateUI();

            List<string> finJaren = FinancieringsjaarManager.GetFinancieringsjaren();
            foreach (string jaar in finJaren)
            {
                cmbFinancieringsjaar.Items.Add(jaar);
            }
        }

        private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartStatusAanvraag.Series.Clear();
            Series serie = new Series();

            List<StatusAanvraag> statusaanvragen = StatusAanvraagManager.GetStatusAanvragen();

            foreach (StatusAanvraag s in statusaanvragen)
            {
                List<Aanvraag> aanvraag = AanvraagManager.GetStatusAanvraagAsc();
                chartStatusAanvraag.Series.Add(s.Naam);

                
            }
        }
    }
}
