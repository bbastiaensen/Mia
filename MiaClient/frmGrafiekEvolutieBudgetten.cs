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
    public partial class frmGrafiekEvolutieBudgetten : MdiChildBoundedForm
    {
        Icon imgFormIcon = Icon.FromHandle((new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-pie-chart-48.png")).GetHicon()));

        public frmGrafiekEvolutieBudgetten()
        {
            InitializeComponent();
        }
        private void frmGrafiekEvolutieBudgetten_Load(object sender, EventArgs e)
        {
            List<EvolutieBudgetten> alleEvoluties = AanvraagManager.GetEvolutieBudgetten();

            foreach (var evolutie in alleEvoluties)
            {
                chrtEvolutieBudgetten.Series["Aangevraagd bedrag"].Points.AddXY(evolutie.Financieringsjaar, evolutie.TotaalbedragAlle);
                chrtEvolutieBudgetten.Series["Toegekend bedrag"].Points.AddXY(evolutie.Financieringsjaar, evolutie.TotaalbedragBekrachtigd);
            }

            chrtEvolutieBudgetten.Dock = DockStyle.Fill; 
            CreateUI();
        }

        private void frmGrafiekEvolutieBudgetten_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        public void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            this.Icon = imgFormIcon;

            
        }
    }
}
