using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Diagnostics;
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
        List<Foto> foto;
        List<Link> link;
        List<Offerte> offerte;
        bool fotoByAanvraagId = true;
        bool linkByAanvraagId = true;
        bool offerteByAanvraagId = true;
        private int _linkId = 0;

        public frmAanvraagFormulier()
        {
            try
            {
                Initialize();
            }
            catch (SqlException ex)
            {
                ErrorHandler(ex, "FrmAanvraagFormulier");
            }
        }
        private void Initialize()
        {
            Connections();
            InitializeComponent();
            vulFormulier();
            DisableForm();
            GetParam();
        }
        private void GetParam()
        {
            mainPath = ParameterManager.GetParameterByCode("Testmap").Waarde;
        }

        private void ErrorHandler(Exception ex, string location)
        {
            MessageBox.Show($"Error: {ex.Message}, in location {location}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            StatusAanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
        }

        public void DisableForm()
        {
            //Links
            txt_hyperlinkInput.ReadOnly = true;
            btn_bewaarLink.Enabled = false;
            btn_nieuweLink.Enabled = false;


            //Fotos
            txt_fotoURLInput.ReadOnly = true;
            btn_bewaarFoto.Enabled = false;
            btn_nieuweFoto.Enabled = false;
            btn_kiesFoto.Enabled = false;

            //Offertes
            txt_offerteURLInput.ReadOnly = true;
            btn_bewaarOfferte.Enabled = false;
            btn_nieuweOfferte.Enabled = false;
            btn_kiesOfferte.Enabled = false;
        }

        public void EnableForm() //TODO: met bool werken om zo de code beter te optimalizeren
        {
            //Links
            txt_hyperlinkInput.ReadOnly = false;
            btn_bewaarLink.Enabled = true;
            btn_nieuweLink.Enabled = true;
            //Fotos
            txt_fotoURLInput.ReadOnly = true;
            btn_bewaarFoto.Enabled = true;
            btn_nieuweFoto.Enabled = true;
            btn_kiesFoto.Enabled = true;

            //Offertes
            txt_offerteURLInput.ReadOnly = true;
            btn_bewaarOfferte.Enabled = true;
            btn_nieuweOfferte.Enabled = true;
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
            txtAanvraagId.Text = string.Empty;
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
            try
            {
                Initialize();
            }
            catch (SqlException ex)
            {
                ErrorHandler(ex, "FrmAanvraagFormulier");
            }

            Aanvraag aanvraag = new Aanvraag();

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
                ddlAfdeling.SelectedValue = aanvraag.AfdelingId;
                ddlDienst.SelectedValue = aanvraag.DienstId;
                ddlFinanciering.SelectedValue = aanvraag.FinancieringsTypeId;
                ddlInvestering.SelectedValue = aanvraag.InvesteringsTypeId;
                ddlKostenplaats.SelectedValue = aanvraag.KostenplaatsId;
                ddlPrioriteit.SelectedValue = aanvraag.PrioriteitId;
                ddlWieKooptHet.SelectedValue = aanvraag.AankoperId;
                ddlFinancieringsjaar.SelectedItem = aanvraag.Financieringsjaar;

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
                    lblLinkId.Text = string.Empty;
                    TxtLinkTitel.Clear();
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
                ErrorHandler(ex, "SaveFile");
            }
        }
        private Offerte SaveOfferte(string filepath)
        {
            try
            {
                Offerte offerte = new Offerte
                {
                    Titel = TxtOfferteTitel.Text,
                    Url = filepath,
                    AanvraagId = _aanvraagId
                };

                OfferteManager.SaveOfferte(offerte, true);
                return offerte;
            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "SaveOfferte");
                return null;
            }
        }
        private Foto SaveFoto(string filepath)
        {
            try
            {
                Foto foto = new Foto
                {
                    Titel = TxtFotoTitel.Text,
                    Url = filepath,
                    AanvraagId = _aanvraagId
                };
                FotoManager.SaveFoto(foto, true);
                return foto;
            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "SaveFoto");
                return null;
            }
        }
        private Link SaveLink(string hyperlink)
        {
            try
            {
                Link link = new Link
                {
                    Titel = TxtLinkTitel.Text,
                    AanvraagId = _aanvraagId,
                    Url = hyperlink
                };
                LinkManager.SaveLinken(link, insert: true);
                return link;
            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "SaveLinken");
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
            if (string.IsNullOrEmpty(txtPrijsindicatie.Text) || !decimal.TryParse(txtPrijsindicatie.Text, out decimal prijsIndicatie))
            {
                MessageBox.Show("Prijsindicatie is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtAantalStuks.Text) || !int.TryParse(txtAantalStuks.Text, out int aantalStuks))
            {
                MessageBox.Show("Aantalstuks is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                FinancieringsTypeId = Convert.ToInt32(ddlFinanciering.SelectedValue),
                InvesteringsTypeId = Convert.ToInt32(ddlInvestering.SelectedValue),
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
                Id = _aanvraagId,
                TijdstipActie = DateTime.Now,
                OmschrijvingActie = $"Aanvraag {_aanvraagId} werd aangemaakt door gebruiker {Program.Gebruiker}."
            }, true);
        }

        private int GetLastFoto()
        {
            List<Foto> fotos = FotoManager.GetFotos();

            if (fotos.Count > 0)
            {
                Foto lastFoto = fotos[fotos.Count - 1];
                return lastFoto.Id;
            }
            // Return een default wnr er geen bestand word gevonden
            return -1;
        }
        private int GetLastAanvraag()
        {
            int highestAanvraagId = MiaLogic.Manager.AanvraagManager.GetHighestAanvraagId();
            int aanvraagid = highestAanvraagId + 1;
            _aanvraagId = aanvraagid;

            return _aanvraagId;
        }
        private int GetLastOfferte()
        {
            List<Offerte> offertes = OfferteManager.GetOffertes();
            if (offertes.Count > 0)
            {
                Offerte LastOfferte = offertes[offertes.Count - 1];
                return LastOfferte.Id;
            }
            return -1; // Return een default wnr er geen bestand word gevonden
        }
        private int GetLastLink()
        {
            List<Link> Linken = LinkManager.GetLinken();
            if (Linken.Count > 0)
            {
                Link LastLink = Linken[Linken.Count - 1];
                return LastLink.Id;
            }
            return -1; // Return een default wnr er geen bestand word gevonden
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
                    if (txtAanvraagId.Text == string.Empty)
                    {
                        GetLastAanvraag();
                        SaveAanvraag();

                        DialogResult result = MessageBox.Show("Je aanvraag is successvol ingediend, Wil je ook nog bestanden uploaden?", "Succes!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            EnableForm();
                            txtAanvraagId.Text = _aanvraagId.ToString();
                        }
                        else
                        {
                            LeegFormulier();
                        }
                    }
                    else
                    {
                        UpdateAanvraag();
                    }

                }
                if (AanvraagBewaard != null)
                {
                    AanvraagBewaard(this, null);
                }
            }
            catch (FormatException ex)
            {
                ErrorHandler(ex, "IndienenAanvraag: Formatexeption");
            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "IndienenAanvraag: exeption");
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
                if (lblLinkId.Text == string.Empty)
                {
                    hyperlink = txt_hyperlinkInput.Text;
                    Link savedlink = SaveLink(hyperlink);

                    int LastLinkId = GetLastLink();
                    if (savedlink != null)
                    {
                        MessageBox.Show("De link is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                        {
                            Gebruiker = Program.Gebruiker,
                            Id = Convert.ToInt32(_aanvraagId),
                            TijdstipActie = DateTime.Now,
                            OmschrijvingActie = $"Er werd een nieuwe Link opgeslagen met id {LastLinkId}."
                        }, true);
                    }
                    link = LinkManager.GetLinken();
                    BindLink(LinkByAanvraagId(link, linkByAanvraagId));
                }
                else
                {
                    int LastLinkId = GetLastLink();
                    UpdateLink();
                    MessageBox.Show("De link is successvol aangepast en opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(_aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Link opgeslagen met id {LastLinkId}."
                    }, true);
                    link = LinkManager.GetLinken();
                    BindLink(LinkByAanvraagId(link, linkByAanvraagId));
                }
                BindLink(LinkByAanvraagId(link, linkByAanvraagId));

            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "BewaarLink");
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
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";//Dit is de filter die alleen maar foto-extenties laat zien

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
                    int lastFotoId = GetLastFoto();

                    string uniqueFileName = $"{_aanvraagId}-{lastFotoId}-{DateTime.Now:yyyyMMddHHmm}{fileExtension}";

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
                        OmschrijvingActie = $"Er werd een nieuwe Foto opgeslagen met id {lastFotoId}."
                    }, true);
                    foto = FotoByAanvraagId(foto, true);
                    BindFotos(foto);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een foto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "BewaarFoto");
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
                openFileDialog.Filter = "Text files (*.doc, *.docx, *.xls, *.xlsx,*.pdf,*.txt)|*.doc;*.docx;*.xls;*.xlsx;*.pdf;*.txt|All files (*.*)|*.*";

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
                    int LastOfferteId = GetLastOfferte();
                    string uniqueFileName = $"{_aanvraagId}-{LastOfferteId}-{DateTime.Now:yyyyMMddHHmm}-{fileExtension}";

                    string destinationFolder = Path.Combine(mainPath + @"\offertes"); // Hier mpet nog de hardocded map naam voor (test)
                    string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                    SaveFile(selectedPath, destinationPath);


                    MessageBox.Show("De offerte is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Hier returnen we naar de aanvragen formulier, dit doen we met alle 

                    //string relativeUrl = Path.Combine("offertes", uniqueFileName);
                    SaveOfferte(destinationPath);

                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(_aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Offerte opgeslagen met id {LastOfferteId}."
                    }, true);
                    offerte = OfferteByAanvraagId(offerte, true);
                    BindOfferte(offerte);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een offerte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Je aanvraag is opgeslagen!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);



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

        public void Bedrag_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAantalStuks.Text, "[^0-9]"))
            {
                MessageBox.Show("Je kunt alleen cijfers ingeven.");
                txtAantalStuks.Text = txtAantalStuks.Text.Remove(txtAantalStuks.Text.Length - 1);
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrijsindicatie.Text, "[^0-9]"))
            {
                MessageBox.Show("Je kunt alleen cijfers ingeven.");
                txtPrijsindicatie.Text = txtPrijsindicatie.Text.Remove(txtPrijsindicatie.Text.Length - 1);
            }

        }
        public void UpdateAanvraag()
        {
            AanvraagManager.GetAanvraagById(_aanvraagId);
            Aanvraag updateaanvraag = new Aanvraag
            {
                Id = Convert.ToInt32(txtAanvraagId.Text),
                Gebruiker = txtGebruiker.Text,
                AfdelingId = Convert.ToInt32(ddlAfdeling.SelectedValue),
                DienstId = Convert.ToInt32(ddlDienst.SelectedValue),
                Aanvraagmoment = DateTime.Now,
                Titel = txtTitel.Text,
                Omschrijving = rtxtOmschrijving.Text,
                FinancieringsTypeId = Convert.ToInt32(ddlFinanciering.SelectedValue),
                InvesteringsTypeId = Convert.ToInt32(ddlInvestering.SelectedValue),
                PrioriteitId = Convert.ToInt32(ddlPrioriteit.SelectedValue),
                Financieringsjaar = ddlFinancieringsjaar.Text,
                StatusAanvraagId = Convert.ToInt32(1),
                KostenplaatsId = Convert.ToInt32(ddlKostenplaats.SelectedValue),
                PrijsIndicatieStuk = Convert.ToDecimal(txtPrijsindicatie.Text),
                AantalStuk = Convert.ToInt32(txtAantalStuks.Text),
                AankoperId = Convert.ToInt32(ddlWieKooptHet.SelectedValue)
            };
            AanvraagManager.SaveAanvraag(updateaanvraag, insert: false);
        }
        public void DisableBewaarButon()
        {
            btn_Indienen.Enabled = false;
        }
        public void EnableBewaarButon()
        {
            btn_Indienen.Enabled = true;
        }
        public void BindOfferte(List<Offerte> items)
        {
            this.pnlOffertes.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var av in items)
            {
                OffertesItem avi = new OffertesItem(av.Id, av.Titel, av.Url, av.AanvraagId, t % 2 == 0);
                avi.Location = new System.Drawing.Point(xPos, yPos);
                avi.Name = "OfferteSelection" + t;
                avi.Size = new System.Drawing.Size(710, 33);
                avi.TabIndex = t + 8;
                avi.OfferteItemSelected += Gli_OfferteItemSelected;
                avi.OfferteDeleted += Avi_OfferteItemChanged;
                avi.OfferteItemChanged += Avi_OfferteItemChanged;

                this.pnlOffertes.Controls.Add(avi);

                t++;
                yPos += 30;
            }
        }
        private void Gli_OfferteItemSelected(object sender, EventArgs e)
        {
            OffertesItem geselecteerd = (OffertesItem)sender;
            TxtOfferteTitel.Text = geselecteerd.Titel;
            txt_offerteId.Text = geselecteerd.Id.ToString();
            txt_offerteURLInput.Text = geselecteerd.URL;
            offerte = OfferteManager.GetOffertes();
            offerte = OfferteByAanvraagId(offerte, true);
            BindOfferte(offerte);
        }
        public void BindFotos(List<Foto> items)
        {
            this.pnlFotos.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var av in items)
            {
                FotoItem avi = new FotoItem(av.Id, av.Titel, av.Url, av.AanvraagId, t % 2 == 0);
                avi.Location = new System.Drawing.Point(xPos, yPos);
                avi.Name = "FotoSelection" + t;
                avi.Size = new System.Drawing.Size(710, 33);
                avi.TabIndex = t + 8;
                avi.FotoItemSelected += Gli_FotoItemSelected;
                avi.TabIndex = t + 8;
                avi.FotoDeleted += Avi_FotoItemChanged;
                avi.FotoItemChanged += Avi_FotoItemChanged;
                this.pnlFotos.Controls.Add(avi);

                t++;
                yPos += 30;
            }
        }
        private void Gli_FotoItemSelected(object sender, EventArgs e)
        {
            FotoItem geselecteerd = (FotoItem)sender;
            TxtFotoTitel.Text = geselecteerd.Titel;
            txt_FotoId.Text = geselecteerd.Id.ToString();
            txt_fotoURLInput.Text = geselecteerd.URL;
            foto = FotoManager.GetFotos();
            foto = FotoByAanvraagId(foto, true);
            BindFotos(foto);
        }

        private void frmAanvraagFormulier_Load(object sender, EventArgs e)
        {
        }
        public void BindLink(List<Link> items)
        {
            this.pnl_Links.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var av in items)
            {
                LinkItem avi = new LinkItem(av.Id, av.Titel, av.Url, av.AanvraagId, t % 2 == 0);
                avi.Location = new System.Drawing.Point(xPos, yPos);
                avi.Name = "LinkSelection" + t;
                avi.Size = new System.Drawing.Size(705, 33);
                avi.TabIndex = t + 8;
                avi.LinkItemSelected += Gli_LinkItemSelected;
                avi.LinkDeleted += Avi_LinkItemChanged;
                avi.LinkItemChanged += Avi_LinkItemChanged;
                this.pnl_Links.Controls.Add(avi);

                t++;
                yPos += 30;
            }
        }
        private void Gli_LinkItemSelected(object sender, EventArgs e)
        {
            LinkItem geselecteerd = (LinkItem)sender;

            lblLinkId.Text = geselecteerd.Id.ToString();
            txt_hyperlinkInput.Text = geselecteerd.URL;
            TxtLinkTitel.Text = geselecteerd.Titel;

            link = LinkManager.GetLinken();
            BindLink(LinkByAanvraagId(link, linkByAanvraagId));
        }

        private void Avi_LinkItemChanged(object sender, EventArgs e)
        {
            try
            {
                link = LinkManager.GetLinken();
                BindLink(LinkByAanvraagId(link, linkByAanvraagId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Avi_OfferteItemChanged(object sender, EventArgs e)
        {
            try
            {
                offerte = OfferteManager.GetOffertes();
                BindOfferte(offerte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Avi_FotoItemChanged(object sender, EventArgs e)
        {
            try
            {
                foto = FotoManager.GetFotos();
                BindFotos(foto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Foto> FotoByAanvraagId(List<Foto> items, bool fotoByAanvraagId)
        {
            if (items != null)
            {
                if (fotoByAanvraagId)
                {
                    items = items.Where(av => av.AanvraagId == Convert.ToInt32(txtAanvraagId.Text)).ToList();
                }
            }
            return items;
        }
        public void BindFotoByAanvraagId()
        {
            try
            {
                foto = FotoManager.GetFotos();
                BindFotos(FotoByAanvraagId(foto, fotoByAanvraagId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Link> LinkByAanvraagId(List<Link> items, bool linkByAanvraagId)
        {
            if (items != null)
            {
                if (linkByAanvraagId)
                {
                    items = items.Where(av => av.AanvraagId == Convert.ToInt32(txtAanvraagId.Text)).ToList();
                }
            }
            return items;
        }
        public void BindLinkByAanvraagId()
        {
            try
            {
                link = LinkManager.GetLinken();
                BindLink(LinkByAanvraagId(link, linkByAanvraagId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Offerte> OfferteByAanvraagId(List<Offerte> items, bool offerteByAanvraagId)
        {
            if (items != null)
            {
                if (offerteByAanvraagId)
                {
                    items = items.Where(av => av.AanvraagId == Convert.ToInt32(txtAanvraagId.Text)).ToList();
                }
            }
            return items;
        }
        public void BindOfferteByAanvraagId()
        {
            try
            {
                offerte = OfferteManager.GetOffertes();
                BindOfferte(OfferteByAanvraagId(offerte, offerteByAanvraagId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateLink()
        {
            LinkManager.GetLinkenById(Convert.ToInt32(lblLinkId.Text));
            Link updateLink = new Link
            {
                Id = Convert.ToInt32(lblLinkId.Text),
                Titel = TxtLinkTitel.Text,
                Url = txt_hyperlinkInput.Text,
                AanvraagId = Convert.ToInt32(txtAanvraagId.Text)
            };
            LinkManager.SaveLinken(updateLink, insert: false);
        }
        public void UpdateOfferte()
        {
            OfferteManager.GetOfferteById(Convert.ToInt32(txt_offerteId.Text));
            Offerte UpdateOfferte = new Offerte()
            {
                Id = Convert.ToInt32(txt_offerteId),
                Titel = TxtOfferteTitel.Text,
                AanvraagId = Convert.ToInt32(txtAanvraagId.Text)
            };
            OfferteManager.SaveOfferte(UpdateOfferte, insert: false);
        }

        public int GetLastLinkId()
        {
            int highestLinkId = MiaLogic.Manager.LinkManager.GetHighestLinkId();
            int linkid = highestLinkId + 1;
            _linkId = linkid;

            return _linkId;
        }
    }
}
