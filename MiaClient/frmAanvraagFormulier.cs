using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    //Mensen dat verwijderd worden moeten ook gelogd zijn.
    // soms wordt er alleen een vermoedelijke prijs ingevuld. Niet altijd offerte of afbeelding.
    //Moeten de bestandsnamen specifiek zijn of niet : Id + uploaddatum+fotoId
    //Wat gebeurt er met de bestanden als de map verplaatst word? Moeten de bestanden mee verplaatst worden of : ja deze worden mee verplaatst
    //Submappen voor offertes en fotos investeringen/afbeeldingen - / offertess
    public partial class frmAanvraagFormulier : Form
    {
        private string selectedPath;
        private string Mainpath;// De folder voor het opslagen, dit wordt de parameter
        private string link = string.Empty;
        public FrmAanvragen frmAanvragen;

        public frmAanvraagFormulier()
        {
            InitializeComponent();
            //Mainpath = ParameterManager.GetParameter(parameterId: 11).Waarde;
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
            List<Afdeling> afdelingen = MiaLogic.Manager.AfdelingenManager.GetAfdelingen();

            cmbAfdeling.DataSource = afdelingen;
            cmbAfdeling.DisplayMember = "Naam";
            cmbAfdeling.ValueMember = "Id";
            cmbAfdeling.SelectedIndex = -1;
        }
        public void VulDienstDropDown(ComboBox cmbDienst)
        {
            List<Dienst> diensten = MiaLogic.Manager.DienstenManager.GetDiensten();

            cmbDienst.DataSource = diensten;
            cmbDienst.DisplayMember = "Naam";
            cmbDienst.ValueMember = "Id";
            cmbDienst.SelectedIndex = -1;
        }
        public void VulPrioriteitDropDown(ComboBox cmbPrioriteit)
        {
            List<Prioriteit> prioriteiten = MiaLogic.Manager.PrioriteitManager.GetPrioriteiten();

            cmbPrioriteit.DataSource = prioriteiten;
            cmbPrioriteit.DisplayMember = "Naam";
            cmbPrioriteit.ValueMember = "Id";
            cmbPrioriteit.SelectedIndex = -1;
        }
        public void VulFinancieringDropDown(ComboBox cmbFinanciering)
        {
            List<Financiering> financieringen = MiaLogic.Manager.FinancieringenManager.GetFinancieringen();

            cmbFinanciering.DataSource = financieringen;
            cmbFinanciering.DisplayMember = "Naam";
            cmbFinanciering.ValueMember = "Id";
            cmbFinanciering.SelectedIndex = -1;
        }
        public void VulInvesteringDropDown(ComboBox cmbInvestering)
        {
            List<Investering> investeringen = MiaLogic.Manager.InvesteringenManager.GetInvesteringen();

            cmbInvestering.DataSource = investeringen;
            cmbInvestering.DisplayMember = "Naam";
            cmbInvestering.ValueMember = "Id";
            cmbInvestering.SelectedIndex = -1;
        }
        public void VulFinancieringsjaarDropDown(ComboBox cmbFinancieringsjaar)
        {
            List<string> financieringsjaren = MiaLogic.Manager.FinancieringsjaarManager.GetFinancieringsjaren();

            cmbFinancieringsjaar.DataSource = financieringsjaren;
            cmbFinancieringsjaar.SelectedIndex = -1;
        }
        public void VulKostenplaatsDropDown(ComboBox cmbKostenplaats)
        {
            List<Kostenplaats> kostenplaatsen = MiaLogic.Manager.KostenplaatsManager.GetKostenplaatsen();

            cmbKostenplaats.DataSource = kostenplaatsen;
            cmbKostenplaats.DisplayMember = "Naam";
            cmbKostenplaats.ValueMember = "Id";
            cmbKostenplaats.SelectedIndex = -1;
        }
        public void VulAankoperDropDown(ComboBox cmbAankoper)
        {
            //List<string> aankoper = MiaLogic.Manager.AankoperManager.GetAankoper();
            List<Aankoper> aankoper = MiaLogic.Manager.AankoperManager.GetAankoper();

            cmbAankoper.DataSource = aankoper;
            cmbAankoper.DisplayMember = "FullName";
            cmbAankoper.ValueMember = "Id";
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
        public void RefreshBoxes(TabControl tabControl) //Dit is het deelprobleem om alle textboxes etc leeg te maken
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    txt_hyperlinkInput.Clear();
                    break;
                case 1:
                    txt_fotoURLInput.Clear();
                    break;
                case 2:
                    txt_offerteURLInput.Clear();
                    break;
            }
        }
        public static void Delete() //het deelrpobleem om de hyperlink/foto/offerte te verwijderen
        {

        }
        private void btn_bewaarLink_Click(object sender, EventArgs e)
        {
            //Hier moet ik de link naar de databank sturen in de tabel linken
        }
        private void btn_nieuweLink_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);
        }
        private void btn_verwijderLink_Click(object sender, EventArgs e)
        {

        }
        private void btn_nieuweFoto_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);
        }
        private void btn_bewaarFoto_Click(object sender, EventArgs e)
        {
            if (txt_fotoURLInput != null)
            {
                link = txt_fotoURLInput.Text;
                //De link is het pad en moet alleen read only zijn
            }
            if (!string.IsNullOrEmpty(selectedPath)) // als de string != null is
            {
                string FileName = Path.GetFileName(selectedPath);//Hier haal ik de bestandsnaam op
                string DestinationPath = Path.Combine(Mainpath, FileName); //OM het volledige pad te vinden moet ik deze 2 samen plakken
                SaveFoto(DestinationPath);

                try
                {
                    File.Copy(selectedPath, DestinationPath, true);//Hier slaag ik de afbeelding op
                    MessageBox.Show("De foto is succesvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Er is een fout opgetreden bij het opslaan van de foto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een afbeelding aub", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Als de string == Null is geef hij deze error
            }
        }
        private void btn_verwijderFoto_Click(object sender, EventArgs e)
        {

        }
        private void btn_nieuweOfferte_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);
        }
        private void btn_bewaarOfferte_Click(object sender, EventArgs e)
        {
            //De link is het pad en moet alleen read only zijn
            if (!string.IsNullOrEmpty(selectedPath))
            {
                string fileName = Path.GetFileName(selectedPath);
                string destinationPath = Path.Combine(Mainpath, fileName);
                try
                {
                    File.Copy(selectedPath, destinationPath, true);
                    MessageBox.Show("De offerte is succesvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SaveOfferte(destinationPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Er is een fout opgetreden bij het opslaan van de offerte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een offerte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveOfferte(string filepath)
        {
            try
            {
                Offerte offerte = new Offerte
                {
                    Url = filepath
                };

                OfferteManager.SaveOfferte(offerte);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het opslaan van de offerte in de database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveFoto(string filepath)
        {
            try
            {
                Foto foto = new Foto
                { Url = filepath };
                FotoManager.SaveFoto(foto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het opslaan van de foto in de database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveLink(string filepath)
        {
            try
            {
                Link link = new Link
                {
                    Url = filepath
                };
                LinkManager.SaveLinken(link);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het opslaan van de link in de database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_verwijderOfferte_Click(object sender, EventArgs e)
        {

        }
        private void btn_kiesOfferte_Click(object sender, EventArgs e)
        {
            //Hier opent de filedialog voor een word /exel file te selecteren
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Text files (*.doc, *.docx, *.xls, *.xlsx)|*.doc;*.docx;*.xls;*.xlsx|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = openFileDialog.FileName;
                    MessageBox.Show($"De offerte is succesvol geslecteerd. Dit is het pad :{selectedPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_kiesFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";//Dit is de originele directory
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";//Dit is de filter die alleen maar foto-extenties laat zien

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = openFileDialog.FileName;
                    MessageBox.Show($"De foto is succesvol geslecteerd. Dit is het pad :{selectedPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btn_Indienen_Click(object sender, EventArgs e)
        {
            try
            {
                Aanvraag nieuweAanvraag = new Aanvraag
                {
                    Gebruiker = txtGebruiker.Text,
                    AfdelingId = AfdelingenManager.GetAfdelingById(Convert.ToInt32(ddlAfdeling.SelectedValue)).Id,
                    DienstId = DienstenManager.GetDienstById(Convert.ToInt32(ddlDienst.SelectedValue)).Id,
                    Aanvraagmoment = DateTime.Now,
                    Titel = txtTitel.Text,
                    Omschrijving = rtxtOmschrijving.Text,
                    FinancieringsTypeId = FinancieringenManager.GetFinancieringById(Convert.ToInt32(ddlFinanciering.SelectedValue)).Id,
                    InvesteringsTypeId = InvesteringenManager.GetInvesteringById(Convert.ToInt32(ddlInvestering.SelectedValue)).Id,
                    PrioriteitId = PrioriteitManager.GetPrioriteitById(Convert.ToInt32(ddlPrioriteit.SelectedValue)).Id,
                    Financieringsjaar = ddlFinancieringsjaar.Text,
                    StatusAanvraagId = Convert.ToInt32(1.ToString()),
                    KostenplaatsId = KostenplaatsManager.GetKostenplaatsById(Convert.ToInt32(ddlKostenplaats.SelectedValue)).Id,
                    PrijsIndicatieStuk = Convert.ToDecimal(txtPrijsindicatie.Text),
                    AantalStuk = Convert.ToInt32(txtAantalStuks.Text),
                    AankoperId = AankoperManager.GetAankoperById(Convert.ToInt32(ddlWieKooptHet.SelectedValue)).Id
                };

                AanvraagManager.SaveAanvraag(nieuweAanvraag, insert: true);

                MessageBox.Show("Je aanvraag is opgeslagen!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Wil je nog iets wijzigen aan deze aanvraag?", "Aanvragen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                }
                else
                {
                    RefreshBoxes(tabControl);
                }
                frmAanvragen = new FrmAanvragen();
                List<Aanvraag> aanvragen = MiaLogic.Manager.AanvraagManager.GetAanvragen();
                frmAanvragen.BindAanvraag(aanvragen);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }    
}
