using MiaLogic.Manager;
using MiaLogic.Object;
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
    public partial class frmAanvraagFormulier : Form
    {
        public frmAanvraagFormulier()
        {
            InitializeComponent();
            vulFormulier();
        }


        // Ophalen van de data voor de dropdownlists
        public void VulAanvraagId()
        {
            int highestAanvraagId = MiaLogic.Manager.AanvraagManager.GetHighestAanvraagId();

            txtAanvraagId.Text = (highestAanvraagId + 1).ToString();
        }
        public void VulAfdelingDropDown(ComboBox cmbAfdeling)
        {
            List<Afdeling> afdelingen = MiaLogic.Manager.AanvraagManager.GetAfdelingen();

            cmbAfdeling.DataSource = afdelingen;
            cmbAfdeling.DisplayMember = "Naam";
            cmbAfdeling.ValueMember = "Id";
            cmbAfdeling.SelectedIndex = -1;
        }
        public void VulDienstDropDown(ComboBox cmbDienst)
        {
            List<Dienst> diensten = MiaLogic.Manager.AanvraagManager.GetDiensten();

            cmbDienst.DataSource = diensten;
            cmbDienst.DisplayMember = "Naam";
            cmbDienst.ValueMember = "Id";
            cmbDienst.SelectedIndex = -1;
        }
        public void VulPrioriteitDropDown(ComboBox cmbPrioriteit)
        {
            List<Prioriteit> prioriteiten = MiaLogic.Manager.AanvraagManager.GetPrioriteiten();

            cmbPrioriteit.DataSource = prioriteiten;
            cmbPrioriteit.DisplayMember = "Naam";
            cmbPrioriteit.ValueMember = "Id";
            cmbPrioriteit.SelectedIndex = -1;
        }
        public void VulFinancieringDropDown(ComboBox cmbFinanciering)
        {
            List<Financiering> financieringen = MiaLogic.Manager.AanvraagManager.GetFinancieringen();

            cmbFinanciering.DataSource = financieringen;
            cmbFinanciering.DisplayMember = "Naam";
            cmbFinanciering.ValueMember = "Id";
            cmbFinanciering.SelectedIndex = -1;
        }
        public void VulInvesteringDropDown(ComboBox cmbInvestering)
        {
            List<Investering> investeringen = MiaLogic.Manager.AanvraagManager.GetInvesteringen();

            cmbInvestering.DataSource = investeringen;
            cmbInvestering.DisplayMember = "Naam";
            cmbInvestering.ValueMember = "Id";
            cmbInvestering.SelectedIndex = -1;
        }
        public void VulFinancieringsjaarDropDown(ComboBox cmbFinancieringsjaar)
        {
            List<string> financieringsjaren = MiaLogic.Manager.AanvraagManager.GetFinancieringsjaren();

            cmbFinancieringsjaar.DataSource = financieringsjaren;
            cmbFinancieringsjaar.SelectedIndex = -1;
        }
        public void VulKostenplaatsDropDown(ComboBox cmbKostenplaats)
        {
            List<Kostenplaats> kostenplaatsen = MiaLogic.Manager.AanvraagManager.GetKostenplaatsen();

            cmbKostenplaats.DataSource = kostenplaatsen;
            cmbKostenplaats.DisplayMember = "Naam";
            cmbKostenplaats.ValueMember = "Id";
            cmbKostenplaats.SelectedIndex = -1;
        }
        public void VulAankoperDropDown(ComboBox cmbAankoper)
        {
            List<string> aankoper = MiaLogic.Manager.AanvraagManager.GetWieKooptHet();

            cmbAankoper.DataSource = aankoper;
            cmbAankoper.SelectedIndex = -1;
        }
        private decimal BerekenTotaalprijs()
        {
            // Controleer of tekstvak prijsindicatie niet leeg is en de waarde is numeriek.
            if (string.IsNullOrEmpty(txtPrijsindicatie.Text) || !decimal.TryParse(txtPrijsindicatie.Text, out decimal prijsIndicatie))
            {
                return 0;
            }

            // Controleer of tekstvak aantalstuks niet leeg is en de waarde is numeriek.

            if (string.IsNullOrEmpty(txtAantalStuks.Text) || !int.TryParse(txtAantalStuks.Text, out int aantalStuks))
            {
                return 0;
            }

            // Als beide een correcte waarde hebben berekenen we de totaalprijs
            decimal totaalprijs = prijsIndicatie * aantalStuks;
            return totaalprijs;
        }

        // Vullen van dropdownlists
        public void vulFormulier()
        {
            txtGebruiker.Text = Program.Gebruiker;
            txtAanvraagmoment.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            VulAanvraagId();
            // Identificatie
            VulAfdelingDropDown(ddlAfdeling);
            VulDienstDropDown(ddlDienst);
            // Investering
            VulPrioriteitDropDown(ddlPrioriteit);
            VulFinancieringDropDown(ddlFinanciering);
            VulInvesteringDropDown(ddlInvestering);
            VulFinancieringsjaarDropDown(ddlFinancieringsjaar);
            VulKostenplaatsDropDown(ddlKostenplaats);
            VulAankoperDropDown(ddlWieKooptHet);
        }

        private void txtPrijsindicatie_Leave(object sender, EventArgs e)
        {
            txtTotaal.Text = BerekenTotaalprijs().ToString();
        }
        private void txtAantalStuks_Leave(object sender, EventArgs e)
        {
            txtTotaal.Text = BerekenTotaalprijs().ToString();
        }





        private void frmAanvraagFormulier_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        public void btn_Indienen_Click(object sender, EventArgs e)
        {
            try
            {
                Aanvraag nieuweAanvraag = new Aanvraag
                {
                    Gebruiker = txtGebruiker.Text,
                    AfdelingId = AanvraagManager.GetAfdelingById(Convert.ToInt32(ddlAfdeling.SelectedValue),
                    DienstId = AanvraagManager.GetDienstById(Convert.ToInt32(ddlDienst.SelectedValue),
                    Aanvraagmoment = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Titel = txtTitel.Text,
                    Omschrijving = rtxtOmschrijving.Text,
                    FinancieringsTypeId = ddlFinanciering.SelectedValue.ToString(),
                    InvesteringsTypeId = ddlInvesterings.SelectedValue.ToString(),
                    PrioriteitId = ddlPrioriteit.SelectedValue.ToString(),
                    Financieringsjaar = txtFinancieringsjaar.Text,
                    Planningsdatum = DateTime.Parse(dtpPlanningsdatum.Text),
                    StatusAanvraag = txtStatusAanvraag.Text,
                    KostenplaatsId = ddlKostenplaats.SelectedValue.ToString(),
                    PrijsIndicatieStuk = decimal.Parse(txtPrijsIndicatieStuk.Text),
                    AantalStuk = int.Parse(txtAantalStuk.Text),
                    AankoperId = GetAankoperIdFromFullName(txtAankoperFullName.Text)))
                };

               AanvraagManager.SaveAanvraag(nieuweAanvraag, insert: true);

                MessageBox.Show("Aanvraag saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // You can also reset the form or perform other actions as needed
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }    
}
