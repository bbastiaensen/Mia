using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBudgetspreiding : Form
    {
        int i = 1;
        
        public frmBudgetspreiding()
        {
            InitializeComponent();
        }

        private void frmBudgetspreiding_Load(object sender, EventArgs e)
        {
            CreateUI();
            int xPos = 10;
            int yPos = 0;
            int year = Convert.ToInt32(cmbFinancieringsjaar.SelectedItem);
            List<Richtperiode> richtperiodes = RichtperiodeManager.GetRichtperiodes();
            _ = BudgetManager.GetBudget(i, year);
            for (i = 1; i <  richtperiodes.Count; i++)
            {
                yPos += 25;
                Richtperiode richtperiode = richtperiodes[i];
                var Maanden = richtperiode.Naam.ToString();
                System.Windows.Forms.LinkLabel llbl = new LinkLabel();
                llbl.Location = new Point(xPos, yPos);
                llbl.Name = "llbl";
                llbl.Text = Maanden;
                llbl.Font = new System.Drawing.Font("Comic Sans MS", 12);
                llbl.LinkColor = Color.Black;
                pnlRichtperiode.Controls.Add(llbl);
            }
            List<string> jaren = FinancieringsjaarManager.GetFinancieringsjaren();
            foreach (string jaar in jaren)
            {
                cmbFinancieringsjaar.Items.Add( jaar );
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
        
    }
}
