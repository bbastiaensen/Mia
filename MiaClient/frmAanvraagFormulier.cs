using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    //Mensen dat verwijderd worden moeten ook gelogd zijn.
    //Soms wordt er alleen een vermoedelijke prijs ingevuld. Niet altijd offerte of afbeelding.
    //Moeten de bestandsnamen specifiek zijn of niet : Id + uploaddatum+fotoId
    //Wat gebeurt er met de bestanden als de map verplaatst word? Moeten de bestanden mee verplaatst worden of : ja deze worden mee verplaatst
    //Submappen voor offertes en fotos investeringen/afbeeldingen - / offertess
    public partial class frmAanvraagFormulier : Form
    {
        private string selectedPath;
        private string Mainpath;// De folder voor het opslagen, dit wordt de parameter

        public frmAanvraagFormulier()
        {
            try
            {
                Connections();
                InitializeComponent();
                Mainpath = ParameterManager.GetParameterByCode("Testmap").Waarde;
                vulFormulier();
            }

            catch (SqlException ex)
            {

                MessageBox.Show($"Error, {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Connections()
        {
            //Leg de connectie met de databank, dit deelprobleem wordt in de main opnieuw opgeroepen
            ParameterManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            PrioriteitManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            FinancieringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            DienstenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AfdelingenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            InvesteringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AankoperManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            KostenplaatsManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            OfferteManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;


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
            List<string> aankoper = MiaLogic.Manager.AankoperManager.GetAankoper();

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
        private void SaveFile(string sourcePath, string destinationPath)
        {
            File.Copy(sourcePath, destinationPath, true);
        }

        private void btn_bewaarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectedPath))
                {
                    string fileName = Path.GetFileName(selectedPath);
                    string fileExtension = Path.GetExtension(selectedPath);

                    string uniqueFileName = $"{txtAanvraagId.Text}-{txt_FotoId.Text}-{DateTime.Now:yyyyMMddHHmmss}{fileExtension}";

                    string destinationFolder = Path.Combine(Mainpath, "fotos");
                    string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                    SaveFile(selectedPath, destinationPath);

                    MessageBox.Show("De foto is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    SaveFoto(destinationPath);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een foto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een error gebeurt tijdens het opslaan van de foto: {ex.Message}");
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
            try
            {
                if (!string.IsNullOrEmpty(selectedPath))
                {
                    string fileName = Path.GetFileName(selectedPath);
                    string fileExtension = Path.GetExtension(selectedPath);


                    string uniqueFileName = $"{txtAanvraagId.Text}-{txt_offerteId.Text}-{DateTime.Now:yyyyMMddHHmmss}-{fileExtension}";

                    string destinationFolder = Path.Combine(Mainpath, "\\offertes"); // Hier mpet nog de hardocded map naam voor (test)
                    string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                    SaveFile(selectedPath, destinationPath);

                    MessageBox.Show("De offerte is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string relativeUrl = Path.Combine("offertes", uniqueFileName);
                    SaveOfferte(relativeUrl);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een offerte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout gebeurt tijdens het opslaan van de offerte: {ex.Message}");
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
            txt_offerteId.Text = selectedPath;
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
            txt_FotoId.Text = selectedPath;
        }

        private void btn_Indienen_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checks())
                {
                    Aanvraag nieuweAanvraag = new Aanvraag
                    {
                        Gebruiker = txtGebruiker.Text,
                        //AfdelingId = Convert.ToInt32(ddlAfdeling.SelectedValue),
                        //DienstId = Convert.ToInt32(ddlDienst.SelectedValue),
                        //Aanvraagmoment = DateTime.Now,
                        //Titel = txtTitel.Text,
                        //Omschrijving = rtxtOmschrijving.Text,
                        //FinancieringsTypeId = Convert.ToInt32(ddlFinanciering.SelectedValue),
                        //InvesteringsTypeId = Convert.ToInt32(ddlFinanciering.SelectedValue),
                        //PrioriteitId = Convert.ToInt32(ddlPrioriteit.SelectedValue),
                        //Financieringsjaar = ddlFinancieringsjaar.Text,
                        //StatusAanvraagId = 1,

                        //KostenplaatsId = Convert.ToInt32(ddlKostenplaats.SelectedValue),
                        //PrijsIndicatieStuk = Convert.ToDecimal(txtPrijsindicatie.Text),
                        //AantalStuk = Convert.ToInt32(txtAantalStuks.Text),
                        //AankoperId = Convert.ToInt32(ddlWieKooptHet.SelectedValue)
                    };

                    AanvraagManager.SaveAanvraag(nieuweAanvraag, true);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog //Wanneer de aanvraag wordt opgeslagen logt deze code dit
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(txtAanvraagId.Text),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Aanvraag {txtAanvraagId.Text} werd aangemaakt door gebruiker {Program.Gebruiker}."
                    }, true);


                    MessageBox.Show("Je aanvraag is opgeslagen!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Format Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private bool Checks()
        {

            if (string.IsNullOrWhiteSpace(txtGebruiker.Text))
            {
                MessageBox.Show("Gebruiker is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ddlAfdeling.SelectedItem == null)
            {
                MessageBox.Show("Afdeling is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ddlDienst.SelectedItem == null)
            {
                MessageBox.Show("Dienst is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTitel.Text))
            {
                MessageBox.Show("Titel is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ddlFinanciering.SelectedItem == null)
            {
                MessageBox.Show("Financiering is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ddlInvestering.SelectedItem == null)
            {
                MessageBox.Show("Investering is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ddlPrioriteit.SelectedItem == null)
            {
                MessageBox.Show("Prioriteit is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ddlKostenplaats.SelectedItem == null)
            {
                MessageBox.Show("Kostenplaats is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ddlWieKooptHet.SelectedItem == null)
            {
                MessageBox.Show("Aankoper is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }

    }
}
