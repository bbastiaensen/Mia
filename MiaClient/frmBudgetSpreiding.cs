using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBudgetspreiding : Form
    {

        int i = 0;
        List<Richtperiode> richtperiodes = null;
        System.Windows.Forms.Label lbl;

        public frmBudgetspreiding()
        {
            InitializeComponent();
        }

        private void frmBudgetspreiding_Load(object sender, EventArgs e)
        {
            CreateUI();

            int xPos = 10;
            int yPos = 0;

            richtperiodes = RichtperiodeManager.GetRichtperiodes();

            for (i = 0; i < richtperiodes.Count; i++)
            {
                yPos += 25;
                Richtperiode richtperiode = richtperiodes[i];
                var Maanden = richtperiode.Naam.ToString();
                System.Windows.Forms.LinkLabel llbl = new LinkLabel();
                llbl.Location = new Point(xPos, yPos);
                llbl.Name = "llbl";
                llbl.Text = Maanden;
                llbl.Font = new System.Drawing.Font("Segoe UI", 11);
                llbl.LinkColor = Color.Black;
                pnlRichtperiode.Controls.Add(llbl);
            }
            List<string> jaren = FinancieringsjaarManager.GetFinancieringsjaren();
            foreach (string jaar in jaren)
            {
                cmbFinancieringsjaar.Items.Add(jaar);
            }
        }

        private void frmBudgetSpreiding_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void CreateUI()
        {
            //Achtergrondkleur instellen op parameterwaarde
            this.BackColor = StyleParameters.Achtergrondkleur;

            //Opmaak buttons instellen op parameterwaardes
            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }
        }

        private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int xPos = 150;
            int yPos = 0;

            foreach (var richtperiode in richtperiodes)
            {
                lbl = new Label();
                lbl.Text = "";
                string year = cmbFinancieringsjaar.SelectedItem.ToString();
                yPos += 25;
                decimal bedrag = AanvraagManager.GetTotaalPrijsPerRichtperiodeEnFinancieringsjaar(richtperiode.Id, year);
                lbl.Location = new Point(xPos, yPos);
                lbl.Name = $"lbl{i}";
                lbl.Text = bedrag.ToString();
                lbl.Font = new System.Drawing.Font("Segoe UI", 11);     
                pnlRichtperiode.Controls.Add(lbl);            
            }
        }
    }
}
