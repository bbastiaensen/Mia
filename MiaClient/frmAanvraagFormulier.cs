using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using Microsoft.Office.Interop.Excel;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Button = System.Windows.Forms.Button;

namespace MiaClient
{
    //Soms wordt er alleen een vermoedelijke prijs ingevuld. Niet altijd offerte of afbeelding.
    //Wat gebeurt er met de bestanden als de map verplaatst word? Moeten de bestanden mee verplaatst worden of : ja deze worden mee verplaatst
    
    public partial class frmAanvraagFormulier : Form
    {
        //Variables
        private string selectedPath;
        private string mainPath;// De folder voor het opslagen, dit wordt de parameter
        private string PhotoPath;
        private string OffertePath;
        private string MaxBedragStuk;
        private string hyperlink = string.Empty;
        public FrmAanvragen frmAanvragen;
        public event EventHandler AanvraagBewaard;
        private int aanvraagId = 0;
        List<Foto> fotos;
        List<Link> links;
        List<Offerte> offertes;
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
            InitializeComponent();
            vulFormulier();
            
            SetFormStatus(false);
            GetParam();
           
        }
        private void GetParam()
        {
            mainPath = ParameterManager.GetParameterByCode("HoofdMap").Waarde;
            PhotoPath = ParameterManager.GetParameterByCode("FotoMap").Waarde;
            OffertePath = ParameterManager.GetParameterByCode("OfferteMap").Waarde;
            MaxBedragStuk = ParameterManager.GetParameterByCode("MaxBedragStuk").Waarde;
        }

        private void ErrorHandler(Exception ex, string location)
        {
            MessageBox.Show($"Error: {ex.Message}, in location {location}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Connections()
        {
        }

        public void SetFormStatus(bool enabled)
        {
            //Links
            TxtLinkTitel.Enabled = enabled;
            txt_hyperlinkInput.Enabled = enabled;
            btn_bewaarLink.Enabled = enabled;
            btn_nieuweLink.Enabled = enabled;
            //Fotos
            TxtFotoTitel.Enabled = enabled;
            txt_fotoURLInput.Enabled = enabled;
            btn_bewaarFoto.Enabled = enabled;
            btn_nieuweFoto.Enabled = enabled;
            btn_kiesFoto.Enabled = enabled;

            //Offertes
            TxtOfferteTitel.Enabled = enabled;
            txt_offerteURLInput.Enabled = enabled;
            btn_bewaarOfferte.Enabled = enabled;
            btn_nieuweOfferte.Enabled = enabled;
            btn_kiesOfferte.Enabled = enabled;

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
            BindStatusAanvraag(ddlStatus);
            ddlStatus.SelectedIndex = 0;
            BindRichtperiode(ddlRichtperiode);
            ddlRichtperiode.SelectedIndex = 0;
            
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
            txtGoedgekeurdeBedrag.Text = "0,00";
            ddlInvestering.SelectedItem = null;
            ddlStatus.SelectedIndex = 0;
            ddlStatus.Enabled = false;
            //Bijlagen
            LeegLinken();
            LeegFoto();
            LeegOffertes();
            this.pnl_Links.Controls.Clear();
            this.pnlFotos.Controls.Clear();
            this.pnlOffertes.Controls.Clear();
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

            aanvraagId = id;
            Aanvraag aanvraag = new Aanvraag();
            Richtperiode periode = new Richtperiode();
            if (action == "edit")
            {
                //zet de informatie van de aanvraag in de form
                aanvraag = AanvraagManager.GetAanvraagById(aanvraagId);
                periode = RichtperiodeManager.GetRichtperiodeById(aanvraag.RichtperiodeId);
                BindStatusAanvraag(ddlStatus);
                BindRichtperiode(ddlRichtperiode);

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
                ddlStatus.Enabled = true;
                txtResultaat.ReadOnly = false;
                txtResultaat.Text = aanvraag.OpmerkingenResultaat;
                ddlStatus.SelectedValue = aanvraag.StatusAanvraagId;
                ddlRichtperiode.SelectedValue = periode.Id;
                ddlRichtperiode.Enabled = true;
                txtGoedgekeurdeBedrag.Text = aanvraag.BudgetToegekend.ToString();
                txtGoedgekeurdeBedrag.ReadOnly = false;
                
            }
        }

        // Ophalen van de data voor de dropdownlists
        //public void VulAanvraagId()
        //{
        //    int highestAanvraagId = MiaLogic.Manager.AanvraagManager.GetHighestAanvraagId();

        //    txtAanvraagId.Text = (highestAanvraagId + 1).ToString();
        //}
        private void BindStatusAanvraag(ComboBox ddlStatus)
        {
            ddlStatus.DataSource = MiaLogic.Manager.StatusAanvraagManager.GetStatusAanvragen();
            ddlStatus.ValueMember = "Id";
            ddlStatus.DisplayMember = "Naam";
            ddlStatus.SelectedIndex = -1;
        }
        private void BindRichtperiode(ComboBox ddlRichtperiode)
        {
            ddlRichtperiode.DataSource = MiaLogic.Manager.RichtperiodeManager.GetRichtperiodes();
            ddlRichtperiode.ValueMember = "Id";
            ddlRichtperiode.DisplayMember = "Naam";
            ddlRichtperiode.SelectedIndex = -1;
            
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
            List<Kostenplaats> kostenplaatsen = MiaLogic.Manager.KostenplaatsManager.GetAllKostenplaatsen().Where(k => k.Actief == true).ToList();

            cmbKostenplaats.DataSource = kostenplaatsen;
            cmbKostenplaats.DisplayMember = "Naam";
            cmbKostenplaats.ValueMember = "Id";
            cmbKostenplaats.SelectedIndex = -1;
        }
        public void VulAankoperDropDown(ComboBox cmbAankoper)
        {
            List<Aankoper> aankoper = MiaLogic.Manager.AankoperManager.GetActiveAankopers();

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
            double one = 1;
            try
            {
                txtPrijsindicatie.Refresh();
                string temp = txtPrijsindicatie.Text;
                double number = Convert.ToDouble(temp);
                if (number <= Convert.ToDouble(MaxBedragStuk) || number == 0)
                {
                    txtPrijsindicatie.Text = temp;
                    txtPrijsindicatie.Refresh();
                }
                else
                {
                    txtPrijsindicatie.Text = MaxBedragStuk;
                    txtPrijsindicatie.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Veld kan niet leeg zijn");
                txtPrijsindicatie.Text = one.ToString();
            }
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
                    LeegLinken();
                    break;
                case 1:
                    LeegFoto();
                    selectedPath = string.Empty;
                    break;
                case 2:
                    LeegOffertes();
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
        private void Delete_File(string filePath)
        {
            try
            {
                File.Delete(filePath);
            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "DeleteFile");
            }
        }

        private Offerte SaveOfferte(string filepath)
        {
            Offerte offerte = new Offerte
            {
                Titel = TxtOfferteTitel.Text,
                Url = filepath,
                AanvraagId = aanvraagId
            };

            bool isNieuweOfferte = true;
            if (!string.IsNullOrEmpty(txt_offerteId.Text))
            {
                offerte.Id = Convert.ToInt32(txt_offerteId.Text);
                isNieuweOfferte = false;
            }

            OfferteManager.SaveOfferte(offerte, isNieuweOfferte);

            if (isNieuweOfferte)
            {
                offerte.Id = OfferteManager.GetHighestOfferteId();
            }

            return offerte;
        }
        private Foto SaveFoto(string filepath)
        {
            Foto foto = new Foto
            {
                Titel = TxtFotoTitel.Text,
                Url = filepath,
                AanvraagId = aanvraagId
            };

            bool isNieuweFoto = true;
            if (!string.IsNullOrEmpty(txt_FotoId.Text))
            {
                foto.Id = Convert.ToInt32(txt_FotoId.Text);
                isNieuweFoto = false;
            }

            FotoManager.SaveFoto(foto, isNieuweFoto);

            if (isNieuweFoto)
            {
                foto.Id = FotoManager.GetHighestFotoId();
            }

            return foto;
        }
        private Link SaveLink(string hyperlink)
        {
            Link link = new Link
            {
                Titel = TxtLinkTitel.Text,
                AanvraagId = aanvraagId,
                Url = hyperlink
            };
            LinkManager.SaveLinken(link, insert: true);
            return link;
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
            if (Convert.ToDecimal(txtPrijsindicatie.Text) > Convert.ToDecimal(MaxBedragStuk))
            {
                txtPrijsindicatie.Text = MaxBedragStuk;
                txtTotaal.Text = BerekenTotaalprijs().ToString();
                MessageBox.Show("De prijsindicatie is buiten de maximale waarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void SaveAanvraag()
        {
            if (txtGoedgekeurdeBedrag.Text == "")
            {
                txtGoedgekeurdeBedrag.Text = "0,00";
            }

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
                StatusAanvraagId = Convert.ToInt32(ddlStatus.SelectedValue),
                StatusAanvraag = Convert.ToString(ddlStatus.SelectedItem),
                KostenplaatsId = Convert.ToInt32(ddlKostenplaats.SelectedValue),
                PrijsIndicatieStuk = Convert.ToDecimal(txtPrijsindicatie.Text),
                AantalStuk = Convert.ToInt32(txtAantalStuks.Text),
                AankoperId = Convert.ToInt32(ddlWieKooptHet.SelectedValue),
                OpmerkingenResultaat = txtResultaat.Text,
                RichtperiodeId = Convert.ToInt32(ddlRichtperiode.SelectedValue),
                BudgetToegekend = Convert.ToDecimal(txtGoedgekeurdeBedrag.Text)
            };
            AanvraagManager.SaveAanvraag(nieuweAanvraag, true);
            GetLastAanvraag();
            LogAanvraag(nieuweAanvraag);
        }
        private void LogAanvraag(Aanvraag aanvraag)
        {
            GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
            {
                Gebruiker = Program.Gebruiker,
                Id = aanvraagId,
                TijdstipActie = DateTime.Now,
                OmschrijvingActie = $"Aanvraag {aanvraagId} werd aangemaakt door gebruiker {Program.Gebruiker}."
            }, true);
        }

        private int GetLastAanvraag()
        {
            aanvraagId = MiaLogic.Manager.AanvraagManager.GetHighestAanvraagId();

            return aanvraagId;
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
                        //Toevoegen van een nieuwe aanvraag.
                        SaveAanvraag();

                        DialogResult result = MessageBox.Show("Je aanvraag is successvol ingediend, Wil je ook nog bestanden uploaden?", "Succes!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            SetFormStatus(true);
                            txtAanvraagId.Text = aanvraagId.ToString();
                            AanvraagItem.edit = true;
                            AanvraagItem.delete = true;
                        }
                        else
                        {
                            LeegFormulier();
                            if (AanvraagBewaard != null)
                            {
                                AanvraagBewaard(this, null);
                            }
                        }
                    }
                    else
                    {
                        //Bewaren van een bestaande aanvraag.
                        UpdateAanvraag();
                        MessageBox.Show("Je aanvraag is successvol bewaard.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (AanvraagBewaard != null)
                    {
                        AanvraagBewaard(this, null);
                    }
                }
            }
            catch (FormatException ex)
            {
                ErrorHandler(ex, "IndienenAanvraag: Formatexeption; Checks = null");
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
                if (txt_hyperlinkInput.Text != string.Empty)
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
                                Id = Convert.ToInt32(aanvraagId),
                                TijdstipActie = DateTime.Now,
                                OmschrijvingActie = $"Er werd een nieuwe Link opgeslagen met id {LastLinkId} voor aanvraag {aanvraagId} door gebruiker {Program.Gebruiker}."
                            }, true);
                            links = LinkManager.GetLinken();
                            BindLink(LinkByAanvraagId(links, linkByAanvraagId));

                        }
                    }
                    else
                    {
                        int LastLinkId = GetLastLink();
                        UpdateLink();
                        MessageBox.Show("De link is successvol aangepast en opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                        {
                            Gebruiker = Program.Gebruiker,
                            Id = Convert.ToInt32(aanvraagId),
                            TijdstipActie = DateTime.Now,
                            OmschrijvingActie = $"Er werd een nieuwe Link opgeslagen met id {LastLinkId} voor aanvraag {aanvraagId} door gebruiker {Program.Gebruiker}."
                        }, true);
                        links = LinkManager.GetLinken();
                        BindLink(LinkByAanvraagId(links, linkByAanvraagId));
                    }
                }
                else
                {
                    MessageBox.Show("Error : Je kan geen lege link opslagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


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
                    txt_fotoURLInput.Text = openFileDialog.FileName;
                    //MessageBox.Show($"De foto is succesvol geslecteerd. Dit is het pad :{selectedPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_nieuweFoto_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);
        }

        private void btn_bewaarFoto_Click(object sender, EventArgs e)
        {

            try
            {
                selectedPath = txt_fotoURLInput.Text;
                if (!string.IsNullOrEmpty(selectedPath))
                {
                    string fileName = Path.GetFileName(selectedPath);
                    string fileExtension = Path.GetExtension(selectedPath);
                    int newFotoId = FotoManager.GetHighestFotoId() + 1;

                    string uniqueFileName = $"{aanvraagId}-{newFotoId}-{DateTime.Now:yyyyMMddHHmm}{fileExtension}";

                    string destinationFolder = PhotoPath;
                    string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                    // check of de gekozen offerte diegene is die al bewaard is.
                    Foto foto = null;
                    //Image image = Image.FromFile(fileName);
                    //ImageFormat format = image.RawFormat;
                    //ImageAttributes imageAttributes = new ImageAttributes();
                    //DateTime lastWrite = File.GetLastWriteTime(fileName);
                    //DateTime sysTime = DateTime.Now;
                    //TimeSpan dif = sysTime.Subtract(lastWrite);
                    if (!string.IsNullOrEmpty(txt_FotoId.Text))
                    {
                        Foto f = FotoManager.GetFotoById(Convert.ToInt32(txt_FotoId.Text));
                        string url = f.Url.ToString();
                        if (f != null)
                        {
                            if (f.Url != selectedPath)
                            {
                                //Verwijder de oude foto
                                Delete_File(url);
                                FotoManager.UpdateFoto(f, uniqueFileName);
                                SaveFile(selectedPath, destinationPath);
                            }
                        }
                    }
                    else
                    {
                        SaveFile(selectedPath, destinationPath); 
                    }
                    foto = SaveFoto(destinationPath);
                    if (foto != null)
                    {
                        txt_FotoId.Text = foto.Id.ToString();
                        TxtFotoTitel.Text = foto.Titel;
                        txt_fotoURLInput.Text = foto.Url;
                    }

                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Foto opgeslagen met id {newFotoId} voor aanvraag {aanvraagId} door gebruiker {Program.Gebruiker}."
                    }, true);
                    fotos = FotoManager.GetFotos();
                    BindFotos(FotoByAanvraagId(fotos, fotoByAanvraagId));
                    selectedPath = string.Empty;

                    MessageBox.Show("De foto is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een foto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //BindFotos(FotoByAanvraagId(foto, fotoByAanvraagId));
            }
            catch (Exception ex)
            {
                ErrorHandler(ex, "BewaarFoto");
            }

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
                    txt_offerteURLInput.Text = openFileDialog.FileName;
                    //MessageBox.Show($"De offerte is succesvol geslecteerd. Dit is het pad :{selectedPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_nieuweOfferte_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);
        }

        private void btn_bewaarOfferte_Click(object sender, EventArgs e)
        {
            try
            {
                selectedPath = txt_offerteURLInput.Text;
                if (!string.IsNullOrEmpty(selectedPath))
                {
                    string fileName = Path.GetFileName(selectedPath);
                    string fileExtension = Path.GetExtension(selectedPath);
                    int LastOfferteId = OfferteManager.GetHighestOfferteId() + 1;
                    string uniqueFileName = $"{aanvraagId}-{LastOfferteId}-{DateTime.Now:yyyyMMddHHmm}-{fileExtension}";

                    string destinationFolder = OffertePath;
                    string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                    //check of de gekozen offerte diegene is die al bewaard is.
                    if (!string.IsNullOrEmpty(txt_offerteId.Text))
                    {
                        Offerte o = OfferteManager.GetOfferteById(Convert.ToInt32(txt_offerteId.Text));
                        string url = o.Url;
                        if (o != null)
                        {
                            if (o.Url != selectedPath)
                            {
                                //Verwijder de oude offerte
                                Delete_File(url);
                                SaveFile(selectedPath, destinationPath);
                            }
                        }
                    }
                    else
                    {
                        SaveFile(selectedPath, destinationPath);
                    }

                    //string relativeUrl = Path.Combine("offertes", uniqueFileName);
                    Offerte offerte = SaveOfferte(destinationPath);
                    txt_offerteId.Text = offerte.Id.ToString();
                    TxtOfferteTitel.Text = offerte.Titel;
                    txt_offerteURLInput.Text = offerte.Url;

                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Offerte opgeslagen met id {LastOfferteId} voor aanvraag {aanvraagId} door gebruiker {Program.Gebruiker}."
                    }, true);
                    offertes = OfferteManager.GetOffertes();
                    BindOfferte(OfferteByAanvraagId(offertes, offerteByAanvraagId));
                    selectedPath = string.Empty;


                    MessageBox.Show("De offerte is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een offerte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout gebeurt tijdens het opslaan van de offerte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_verwijderOfferte_Click(object sender, EventArgs e)
        {

        }

        public void Bedrag_TextChanged(object sender, EventArgs e)
        {

        }
        public void UpdateAanvraag()
        {
           
            if (txtGoedgekeurdeBedrag.Text == "")
            {
                txtGoedgekeurdeBedrag.Text = "0";
            }

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
                StatusAanvraagId = Convert.ToInt32(ddlStatus.SelectedValue),
                KostenplaatsId = Convert.ToInt32(ddlKostenplaats.SelectedValue),
                PrijsIndicatieStuk = Convert.ToDecimal(txtPrijsindicatie.Text),
                AantalStuk = Convert.ToInt32(txtAantalStuks.Text),
                AankoperId = Convert.ToInt32(ddlWieKooptHet.SelectedValue),
                RichtperiodeId = Convert.ToInt32(ddlRichtperiode.SelectedValue),
                OpmerkingenResultaat = txtResultaat.Text,
                BudgetToegekend = Convert.ToDecimal(txtGoedgekeurdeBedrag.Text)
            };
            AanvraagManager.SaveAanvraag(updateaanvraag, insert: false);

            Aanvraag aanvraag1 = new Aanvraag();
            aanvraag1.Id = Convert.ToInt32(txtAanvraagId.Text);
            GebruiksLog gebruiksLog1 = new GebruiksLog();
            gebruiksLog1.Gebruiker = Program.Gebruiker;
            gebruiksLog1.TijdstipActie = DateTime.Now;
            gebruiksLog1.OmschrijvingActie = "Aanvraag " + aanvraag1.Id + " werd aangepast door Gebruiker " + Program.Gebruiker.ToString();

            GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);
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
            offertes = OfferteManager.GetOffertes();
            offertes = OfferteByAanvraagId(offertes, true);
            BindOfferte(OfferteByAanvraagId(offertes, offerteByAanvraagId));
        }
        public void BindFotos(List<Foto> items)
        {
            this.pnlFotos.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            if (items != null)
            {
                foreach (var av in items)
                {
                    FotoItem avi = new FotoItem(av.Id, av.Titel, av.Url, av.AanvraagId, t % 2 == 0);
                    avi.Location = new System.Drawing.Point(xPos, yPos);
                    avi.Name = "FotoSelection" + t;
                    avi.Size = new System.Drawing.Size(710, 33);
                    avi.TabIndex = t + 8;
                    avi.FotoItemSelected += Gli_FotoItemSelected;
                    avi.FotoDeleted += Avi_FotoItemChanged;
                    avi.FotoItemChanged += Avi_FotoItemChanged;
                    this.pnlFotos.Controls.Add(avi);

                    t++;
                    yPos += 30;
                }
            }
        }
        private void Gli_FotoItemSelected(object sender, EventArgs e)
        {
            FotoItem geselecteerd = (FotoItem)sender;
            TxtFotoTitel.Text = geselecteerd.Titel;
            txt_FotoId.Text = geselecteerd.Id.ToString();
            txt_fotoURLInput.Text = geselecteerd.URL;
            fotos = FotoManager.GetFotos();
            fotos = FotoByAanvraagId(fotos, true);
            BindFotos(FotoByAanvraagId(fotos, fotoByAanvraagId));
        }

        private void frmAanvraagFormulier_Load(object sender, EventArgs e)
        {
            CreateUI();
            ddlDisabler();
          
        }

        private void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;
            tabControl_Aanvraagformulier.BackColor = this.BackColor;
            tabControl.BackColor = this.BackColor;

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }

            foreach (var tp in tabControl.Controls.OfType<TabPage>())
            {
                foreach (var btn in tp.Controls.OfType<Button>())
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = StyleParameters.ButtonBack;
                    btn.ForeColor = StyleParameters.Buttontext;
                }
            }
        }

        public void BindLink(List<Link> items)
        {
            this.pnl_Links.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var av in items)
            {
                LinkItem li = new LinkItem(av.Id, av.Titel, av.Url, av.AanvraagId, t % 2 == 0);
                li.Location = new System.Drawing.Point(xPos, yPos);
                li.Name = "LinkSelection" + t;
                li.Size = new System.Drawing.Size(480, 22);
                li.TabIndex = t + 8;
                li.LinkItemSelected += Gli_LinkItemSelected;
                li.LinkDeleted += Avi_LinkItemChanged;
                li.LinkItemChanged += Avi_LinkItemChanged;
                this.pnl_Links.Controls.Add(li);
                pnl_Links.HorizontalScroll.Maximum = 0;
                pnl_Links.AutoScroll = false;

                t++;
                yPos += 22;
            }
        }
        private void Gli_LinkItemSelected(object sender, EventArgs e)
        {
            LinkItem geselecteerd = (LinkItem)sender;

            lblLinkId.Text = geselecteerd.Id.ToString();
            txt_hyperlinkInput.Text = geselecteerd.URL;
            TxtLinkTitel.Text = geselecteerd.Titel;

            links = LinkManager.GetLinken();
            BindLink(LinkByAanvraagId(links, linkByAanvraagId));
        }

        private void Avi_LinkItemChanged(object sender, EventArgs e)
        {
            try
            {
                links = LinkManager.GetLinken();
                BindLink(LinkByAanvraagId(links, linkByAanvraagId));
                LeegLinken();
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
                offertes = OfferteManager.GetOffertes();
                BindOfferte(OfferteByAanvraagId(offertes, offerteByAanvraagId));
                LeegOffertes();
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
                fotos = FotoManager.GetFotos();
                BindFotos(FotoByAanvraagId(fotos, fotoByAanvraagId));
                LeegFoto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Foto> FotoByAanvraagId(List<Foto> items, bool aanvraagId)
        {
            if (items != null)
            {
                if (aanvraagId)
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
                fotos = FotoManager.GetFotos();
                BindFotos(FotoByAanvraagId(fotos, fotoByAanvraagId));
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
                links = LinkManager.GetLinken();
                BindLink(LinkByAanvraagId(links, linkByAanvraagId));
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
                offertes = OfferteManager.GetOffertes();
                BindOfferte(OfferteByAanvraagId(offertes, offerteByAanvraagId));
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
            Link link1 = new Link();
            link1.Id = Convert.ToInt32(lblLinkId.Text);
            link1.AanvraagId = Convert.ToInt32(txtAanvraagId.Text);
            GebruiksLog gebruiksLog1 = new GebruiksLog();
            gebruiksLog1.Gebruiker = Program.Gebruiker;
            gebruiksLog1.TijdstipActie = DateTime.Now;
            gebruiksLog1.OmschrijvingActie = "Link " + link1.Id + "van aanvraag" + link1.AanvraagId + " werd aangepast door Gebruiker " + Program.Gebruiker.ToString();

            GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);
            LeegLinken();
        }
        public void UpdateOfferte()
        {
            //OfferteManager.GetOfferteById(Convert.ToInt32(txt_offerteId.Text));
            Offerte UpdateOfferte = new Offerte()
            {
                Id = Convert.ToInt32(txt_offerteId),
                Titel = TxtOfferteTitel.Text,
                AanvraagId = Convert.ToInt32(txtAanvraagId.Text)
            };
            OfferteManager.SaveOfferte(UpdateOfferte, insert: false);
        }

        public void LeegLinken()
        {
            lblLinkId.Text = string.Empty;
            TxtLinkTitel.Clear();
            txt_hyperlinkInput.Clear();
        }
        public void LeegOffertes()
        {
            txt_offerteId.Clear();
            TxtOfferteTitel.Clear();
            txt_offerteURLInput.Clear();
        }
        public void LeegFoto()
        {
            txt_FotoId.Clear();
            TxtFotoTitel.Clear();
            txt_fotoURLInput.Clear();
        }

        private void txtPrijsindicatie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Program.IsGeldigBedrag(e.KeyChar);
        }

        private void txtAantalStuks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Program.IsGeldigBedrag(e.KeyChar);
        }
        private void txtGoedgekeurdeBedrag_KeyPress(object sender, KeyPressEventArgs e) 
        {
            e.Handled = !Program.IsGeldigBedrag(e.KeyChar);
        }
        private void ddlDisabler()
        {
            
            decimal totaal = Convert.ToDecimal(txtTotaal.Text);
            string p;
            try
            {
                p = ParameterManager.GetParameterByCode("MaxBedragRichtper").Waarde;
                int m = Convert.ToInt32(p);
                if(Program.IsSysteem != true)
                {
                    if(Program.IsGoedkeurder != true)
                    {
                        if(Program.IsAankoper != true)
                        {
                            if (Program.IsAanvrager == true)
                            {
                                if (m < Convert.ToDecimal(totaal))
                                {
                                    ddlRichtperiode.Enabled = false;
                                }

                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                ErrorHandler(ex, "frmAanvraagFormulier");
            }
          

        }

        private void frmAanvraagFormulier_Activated(object sender, EventArgs e)
        {
            //Doen we hier niet meer, want dan zijn de waarden in de dropdownlists
            //niet meer geselecteerd.
            //vulFormulier();
        }
    }
}