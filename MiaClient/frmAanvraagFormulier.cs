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
    //Soms wordt er alleen een vermoedelijke prijs ingevuld. Niet altijd offerte of afbeelding.
    //Wat gebeurt er met de bestanden als de map verplaatst word? Moeten de bestanden mee verplaatst worden of : ja deze worden mee verplaatst

    public partial class frmAanvraagFormulier : Form
    {
        //Variables
        private string selectedPath;
        private string mainPath;// De folder voor het opslagen, dit wordt de parameter
        private string hyperlink = string.Empty;
        public FrmAanvragen frmAanvragen;
        public event EventHandler AanvraagBewaard;
        private int _aanvraagId = 0;

        public frmAanvraagFormulier()
        {
            try
            {
                Initialize();
            }
            catch (SqlException ex)
            {
                ErrorHandler(ex);
            }
        }
        private void Initialize()
        {
            Connections();
            InitializeComponent();
            vulFormulier();
            DisableForm();
        }

        private void ErrorHandler(Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Connections()
        {
            //Leg de connectie met de databank, dit deelprobleem wordt in de main opnieuw opgeroepen
            ParameterManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            PrioriteitManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            FinancieringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            FinancieringsjaarManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            DienstenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AfdelingenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            InvesteringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AankoperManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            KostenplaatsManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            LinkManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            OfferteManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            FotoManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
        }

        private void DisableForm()
        {
            //Links
            txt_hyperlinkInput.ReadOnly = true;
            btn_bewaarLink.Enabled = false;
            btn_nieuweLink.Enabled = false;
            btn_verwijderLink.Enabled = false;

            //Fotos
            txt_fotoURLInput.ReadOnly = true;
            btn_bewaarFoto.Enabled = false;
            btn_nieuweFoto.Enabled = false;
            btn_verwijderFoto.Enabled = false;
            btn_kiesFoto.Enabled = false;

            //Offertes
            txt_offerteURLInput.ReadOnly = true;
            btn_bewaarOfferte.Enabled = false;
            btn_nieuweOfferte.Enabled = false;
            btn_verwijderOfferte.Enabled = false;
            btn_kiesOfferte.Enabled = false;
        }

        private void EnableForm()
        {
            //Links
            txt_hyperlinkInput.ReadOnly = false;
            btn_bewaarLink.Enabled = true;
            btn_nieuweLink.Enabled = true;
            btn_verwijderLink.Enabled = true;

            //Fotos
            txt_fotoURLInput.ReadOnly = false;
            btn_bewaarFoto.Enabled = true;
            btn_nieuweFoto.Enabled = true;
            btn_verwijderFoto.Enabled = true;
            btn_kiesFoto.Enabled = true;

            //Offertes
            txt_offerteURLInput.ReadOnly = false;
            btn_bewaarOfferte.Enabled = true;
            btn_nieuweOfferte.Enabled = true;
            btn_verwijderOfferte.Enabled = true;
            btn_kiesOfferte.Enabled = true;

        }
        public void vulFormulier()
        {
            txtGebruiker.Text = Program.Gebruiker;
            txtAanvraagmoment.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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

        public void LeegFormulier()
        {
            txtGebruiker.Text = Program.Gebruiker;
            txtAanvraagmoment.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            ddlAfdeling.SelectedItem = null;
            ddlDienst.SelectedItem = null;
            ddlPrioriteit.SelectedItem = null;
            ddlFinanciering.SelectedItem = null;
            ddlFinancieringsjaar.SelectedItem = null;
            ddlKostenplaats.SelectedItem = null;
            ddlWieKooptHet.SelectedItem = null;
            //Andere tablat
            txtTitel.Text = string.Empty;
            txtTotaal.Text = string.Empty;
            txtAantalStuks.Text = string.Empty;
            rtxtOmschrijving.Text = string.Empty;
            txtPrijsindicatie.Text = string.Empty;
            ddlInvestering.SelectedItem = null;


        }
        public frmAanvraagFormulier(int id, string action)
        {

            Aanvraag aanvraag = null;
            if (action == "edit")
            {
                aanvraag = AanvraagManager.GetAanvraagById(id);

                txtAanvraagId.Text = aanvraag.Id.ToString();
                txtAantalStuks.Text = aanvraag.AantalStuk.ToString();
                txtAanvraagmoment.Text = aanvraag.Aanvraagmoment.ToString();
                txtGebruiker.Text = aanvraag.Gebruiker.ToString();
                txtPrijsindicatie.Text = aanvraag.PrijsIndicatieStuk.ToString();
                txtTitel.Text = aanvraag.Titel.ToString();
                txtTotaal.Text = (aanvraag.PrijsIndicatieStuk * aanvraag.AantalStuk).ToString();
                rtxtOmschrijving.Text = aanvraag.Omschrijving.ToString();
            }

        }

        // Ophalen van de data voor de dropdownlists
        //public void VulAanvraagId()
        //{
        //    int highestAanvraagId = MiaLogic.Manager.AanvraagManager.GetHighestAanvraagId();

        //    txtAanvraagId.Text = (highestAanvraagId + 1).ToString();
        //}
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
                    selectedPath = string.Empty;
                    break;
                case 2:
                    txt_offerteURLInput.Clear();
                    selectedPath = string.Empty;
                    break;
            }
        }
        private void SaveFile(string sourcePath, string destinationPath)
        {
            try
            {
                File.Copy(sourcePath, destinationPath, true);
            }

            catch (Exception ex)
            {
                ErrorHandler(ex);
            }
        }
        private Offerte SaveOfferte(string filepath)
        {
            try
            {
                Offerte offerte = new Offerte
                {
                    Url = filepath,
                    AanvraagId = _aanvraagId
                };

                OfferteManager.SaveOfferte(offerte);
                return offerte;
            }
            catch (Exception ex)
            {
                ErrorHandler(ex);
                return null;
            }
        }
        private Foto SaveFoto(string filepath)
        {
            try
            {
                Foto foto = new Foto
                {

                    Url = filepath,
                    AanvraagId = _aanvraagId
                };
                FotoManager.SaveFoto(foto);
                return foto;
            }
            catch (Exception ex)
            {
                ErrorHandler(ex);
                return null;
            }
        }
        private Link SaveLink(string hyperlink)
        {
            try
            {
                Link link = new Link
                {
                    AanvraagId = _aanvraagId,
                    Url = hyperlink
                };
                LinkManager.SaveLinken(link);
                return link;
            }
            catch (Exception ex)
            {
                ErrorHandler(ex);
                return null;
            }
        }
        public static void Delete() //het deelrpobleem om de hyperlink/foto/offerte te verwijderen
        {

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
        private void SaveAanvraag()
        {
            Aanvraag nieuweAanvraag = new Aanvraag
            {
                Gebruiker = txtGebruiker.Text,
                AfdelingId = Convert.ToInt32(ddlAfdeling.SelectedValue),
                DienstId = Convert.ToInt32(ddlDienst.SelectedValue),
                Aanvraagmoment = DateTime.Now,
                Titel = txtTitel.Text,
                Omschrijving = rtxtOmschrijving.Text,
                FinancieringsTypeId = Convert.ToInt32(ddlInvestering.SelectedValue),
                InvesteringsTypeId = Convert.ToInt32(ddlFinanciering.SelectedValue),
                PrioriteitId = Convert.ToInt32(ddlPrioriteit.SelectedValue),
                Financieringsjaar = ddlFinancieringsjaar.Text,
                StatusAanvraagId = Convert.ToInt32(1),
                KostenplaatsId = Convert.ToInt32(ddlKostenplaats.SelectedValue),
                PrijsIndicatieStuk = Convert.ToDecimal(txtPrijsindicatie.Text),
                AantalStuk = Convert.ToInt32(txtAantalStuks.Text),
                AankoperId = Convert.ToInt32(ddlWieKooptHet.SelectedValue)
            };
            AanvraagManager.SaveAanvraag(nieuweAanvraag, true);
            LogAanvraag(nieuweAanvraag);
        }
        private void LogAanvraag(Aanvraag aanvraag)
        {
            GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
            {
                Gebruiker = Program.Gebruiker,
                Id = aanvraag.Id,
                TijdstipActie = DateTime.Now,
                OmschrijvingActie = $"Aanvraag {aanvraag.Id} werd aangemaakt door gebruiker {Program.Gebruiker}."
            }, true);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_Indienen_Click(object sender, EventArgs e)
        {
            try
            {
                if (Checks())
                {
                    SaveAanvraag();
                    DialogResult result = MessageBox.Show("Je aanvraag is successvol ingediend, Wil je ook nog bestanden uploaden?", "Succes!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        EnableForm();
                    }
                    else
                    {
                        LeegFormulier();
                    }
                }
            }
            catch (FormatException ex)
            {
                ErrorHandler(ex);
            }
            catch (Exception ex)
            {
                ErrorHandler(ex);
            }
        }
        private void btn_Nieuw_Click(object sender, EventArgs e)
        {
            LeegFormulier();
        }

        private void btn_nieuweLink_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);

        }

        private void btn_bewaarLink_Click(object sender, EventArgs e)
        {
            try
            {
                hyperlink = txt_hyperlinkInput.Text;
                Link savedlink = SaveLink(hyperlink);
                if (savedlink != null)
                {
                    MessageBox.Show("De link is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(_aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Link opgeslagen met id {savedlink.Id}."
                    }, true);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler(ex);
            }

        }

        private void btn_verwijderLink_Click(object sender, EventArgs e)
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
            txt_fotoURLInput.Text = selectedPath;
        }

        private void btn_nieuweFoto_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);
        }

        private void btn_bewaarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectedPath))
                {
                    string fileName = Path.GetFileName(selectedPath);
                    string fileExtension = Path.GetExtension(selectedPath);

                    string uniqueFileName = $"{_aanvraagId}-{txt_FotoId.Text}-{DateTime.Now:yyyyMMddHHmm}{fileExtension}";

                    string destinationFolder = Path.Combine(mainPath + @"\fotos");
                    string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                    SaveFile(selectedPath, destinationPath);

                    MessageBox.Show("De foto is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SaveFoto(destinationPath);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(_aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Foto opgeslagen met id {_aanvraagId}."
                    }, true);
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
            txt_offerteURLInput.Text = selectedPath;

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

                    string uniqueFileName = $"{_aanvraagId}-{txt_offerteId.Text}-{DateTime.Now:yyyyMMddHHmm}-{fileExtension}";

                    string destinationFolder = Path.Combine(mainPath + @"\offertes"); // Hier mpet nog de hardocded map naam voor (test)
                    string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                    SaveFile(selectedPath, destinationPath);

                    MessageBox.Show("De offerte is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Hier returnen we naar de aanvragen formulier, dit doen we met alle 

                    string relativeUrl = Path.Combine("offertes", uniqueFileName);
                    SaveOfferte(relativeUrl);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(_aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Offerte opgeslagen met id {_aanvraagId}."
                    }, true);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een offerte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Je aanvraag is opgeslagen!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    if (AanvraagBewaard != null)
                    {
                        AanvraagBewaard(this, null);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout gebeurt tijdens het opslaan van de offerte: {ex.Message}");
            }

        }

        private void btn_verwijderOfferte_Click(object sender, EventArgs e)
        {

        }
    }
}
