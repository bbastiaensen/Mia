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
    public partial class frmStatusAanvraagWijzigingDetail : MdiChildBoundedForm
    {
        public event EventHandler StatusAanvraagDetailGewijzigd;

        private int aanvraagId;

        public frmStatusAanvraagWijzigingDetail()
        {
            InitializeComponent();
        }

        public frmStatusAanvraagWijzigingDetail(int aanvraagId, StatusAanvraag statusAanvraag, string opmerkingenResultaat, decimal budgetToegekend)
        {
            InitializeComponent();

            this.aanvraagId = aanvraagId;
            txtStatusAanvraag.Text = statusAanvraag.Naam;
            txtOpmerking.Text = opmerkingenResultaat;
            if (statusAanvraag.Naam.ToLower() == "goedgekeurd" || statusAanvraag.Naam.ToLower() == "bekrachtigd")
            {
                txtToegekendBedrag.Text = budgetToegekend.ToString();
                txtToegekendBedrag.ReadOnly = false;
            }
            else
            {
                txtToegekendBedrag.Text = "0,00";
                txtToegekendBedrag.ReadOnly = true;
            }
        }   

        private void frmStatusAanvraagWijzigingDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            try
            {
                //Aanpassen van OpmerkingenResultaat en BudgetToegekend
                Aanvraag aanvraag = new Aanvraag()
                {
                    Id = aanvraagId
                };
                AanvraagManager.UpdateStatusAanvraagDetails(aanvraag, txtOpmerking.Text, Convert.ToDecimal(txtToegekendBedrag.Text));

                //Notify GoedkeurItem dat gegevens bewaard zijn.
                this.Hide();
                if (StatusAanvraagDetailGewijzigd != null)
                {
                    StatusAanvraagDetailGewijzigd(this, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden - " + ex.Message, "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmStatusAanvraagWijzigingDetail_Load(object sender, EventArgs e)
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

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
