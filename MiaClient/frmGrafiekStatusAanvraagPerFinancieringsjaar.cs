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
            chartStatusAanvraag.Series["Taart"].Points.Clear();
            chartStatusAanvraag.Legends.Clear();
            Series serie = new Series();

            List<StatusAanvraag> statusaanvragen = StatusAanvraagManager.GetStatusAanvragen();

           

            foreach (StatusAanvraag s in statusaanvragen)
            {
                int teller = 0;
                int aanvragen = 0;

                List<Aanvraag> aanvraag = AanvraagManager.GetStatusAanvraagAsc();

                foreach(Aanvraag a in aanvraag)
                {
                    if(a.Financieringsjaar == cmbFinancieringsjaar.SelectedItem.ToString()) 
                    {
                        aanvragen++;

                        if(s.Id == a.StatusAanvraagId)
                        {
                            teller ++;
                        }
                    }
                }


                double procent = teller * 100;
                procent = procent / aanvragen;

                chartStatusAanvraag.Series["Taart"].IsValueShownAsLabel = true;
                chartStatusAanvraag.Legends.Add(s.Naam);
                chartStatusAanvraag.Series["Taart"].Points.AddXY(s.Naam, Math.Round(procent, 2));
            }

            chartStatusAanvraag.Titles.Add("Status aanvragen Financieringsjaar " + cmbFinancieringsjaar.SelectedItem.ToString() + " (in procent)");
        }
    }
}
