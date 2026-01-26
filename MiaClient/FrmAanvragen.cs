using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System.Globalization;
using System.Diagnostics;


namespace MiaClient
{
    public partial class FrmAanvragen : Form
    {
        frmAanvraagFormulier frmAanvraagFormulier;
        List<Aanvraag> aanvragen;

        //frmGoedkeuring frmGoedkeuring = null;
       
        bool filterAanvraagmomentVan = false;
        bool filterAanvraagmomentTot = false;
        bool filterPlanningsdatumVan = false;
        bool filterPlanningsdatumTot = false;
        bool filterGebruiker = false;
        bool filterTitel = false;
        bool filterStatusAanvraag = false;
        bool filterFinancieringsjaar = false;
        bool filterBedragVan = false;
        bool filterBedragTot = false;
        bool filterKostenPlaats = false;

        bool SortGebruiker = true;
        bool SortTitel = true;
        bool SortAanvraagmoment = true;
        bool SortStatusAanvraag = true;
        bool SortBedrag = true;
        bool SortPlanningsdatum = true;
        bool SortKostenPlaats = true;
        bool SortFinancieringsjaar = true;

        int aantalListItems = 12;
        int huidigePage = 1;
        int aantalPages = 0;

        Image imgLast = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-last-50.png"));
        Image imgLastDisable = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-last-50-grey.png"));
        Image imgLastHover = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-last-50-hover.png"));
        Image imgNext = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-next-50.png"));
        Image imgNextDisable = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-next-50-grey.png"));
        Image imgNextHover = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-next-50-hover.png"));
        Image imgPrevious = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-previous-50.png"));
        Image imgPreviousDisable = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-previous-50-grey.png"));
        Image imgPreviousHover = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-previous-50-hover.png"));
        Image imgFirst = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-first-50.png"));
        Image imgFirstDisable = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-first-50-grey.png"));
        Image imgFirstHover = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-first-50-hover.png"));
        Image imgFilter = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "Filter.png"));
        Image imgNieuweAanvraag = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "nieuweAanvraag.png"));
        Image imgExportToExcel = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "excelExport.png"));
        Icon imgFormIcon = Icon.FromHandle((new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-form-80.png")).GetHicon()));

        public FrmAanvragen()
        {
            if (AppForms.frmGoedkeuring != null)
            {
                AppForms.frmGoedkeuring.StatusAanvraagGewijzigd += FrmGoedkeuring_StatusAanvraagGewijzigd;
            }
            InitializeComponent();
        }

        public void HookUp(object sender)
        {
            if (sender != this)
            {
                AppForms.frmGoedkeuring = (frmGoedkeuring)sender;
                if (AppForms.frmGoedkeuring != null)
                {
                    AppForms.frmGoedkeuring.StatusAanvraagGewijzigd += FrmGoedkeuring_StatusAanvraagGewijzigd;
                }
            }
        }

        private void FrmGoedkeuring_StatusAanvraagGewijzigd(object sender, EventArgs e)
        {
            //Er is een status van een aanvraag gewijzigd bij goedkeuringen. Refreshen lijst met aanvragen.
            try
            {
                aanvragen = AanvraagManager.GetAanvragen();
                if (aanvragen != null)
                {
                    StartPaging();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNieuweAanvraag_Click(object sender, EventArgs e)
        {
            //Als er op de knop nieuwe aanvraag wordt geklikt kijken we of er al een aanvraagformulier open staaat.
            if (frmAanvraagFormulier == null)
            {
                frmAanvraagFormulier = new frmAanvraagFormulier();
                frmAanvraagFormulier.MdiParent = MdiParent;
                frmAanvraagFormulier.AanvraagBewaard += FrmAanvraagFormulier_AanvraagBewaard;
            }
            //We openen een nieuw aanvraagformulier
            frmAanvraagFormulier.Show();
        }
        public void BindAanvraag(List<Aanvraag> items)
        {
            //Haalt alle aanvragen uit de databank en zet deze in een lijst die we toonen.
            this.pnlAanvragen.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            if (items != null)
            {
                foreach (var av in items)
                {
                    AanvraagItem avi = new AanvraagItem(av.Id, av.Gebruiker, av.Aanvraagmoment, av.Titel, av.Financieringsjaar, av.Planningsdatum, av.StatusAanvraag, av.Kostenplaats, av.PrijsIndicatieStuk, av.AantalStuk, t % 2 == 0);
                    avi.Location = new System.Drawing.Point(xPos, yPos);
                    avi.Name = "aanvraagSelection" + t;
                    avi.Size = new System.Drawing.Size(1210, 33);
                    avi.TabIndex = t + 8;
                    avi.AanvraagItemSelected += Gli_AanvraagItemSelected;
                    avi.AanvraagDeleted += Avi_AanvraagItemChanged;
                    avi.AanvraagItemChanged += Avi_AanvraagItemChanged;
                    this.pnlAanvragen.Controls.Add(avi);

                    t++;
                    yPos += 30;
                }
            }
        }
        private void Avi_AanvraagItemChanged(object sender, EventArgs e)
        {
            try
            { 
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetAanvragen(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);

                huidigePage = 1;
                StartPaging();
                ShowPages();
                if (huidigePage < aantalPages)
                {
                    BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                    EnableLastNext(true);
                }
                else if (huidigePage == aantalPages)
                {
                    BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
                    EnableLastNext(false);
                }
                EnableFirstPrevious(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmAanvragen_Load(object sender, EventArgs e)
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            btnFirst.BackgroundImage = imgFirst;
            btnFirst.BackgroundImageLayout = ImageLayout.Stretch;
            btnFirst.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            btnPrevious.BackgroundImage = imgPrevious;
            btnPrevious.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrevious.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            btnNext.BackgroundImage = imgNext;
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            btnLast.BackgroundImage = imgLast;
            btnLast.BackgroundImageLayout = ImageLayout.Stretch;
            btnLast.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            btnFilter.BackgroundImage = imgFilter;
            btnFilter.BackgroundImageLayout = ImageLayout.Stretch;
            btnFilter.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            btnNieuweAanvraag.BackgroundImage = imgNieuweAanvraag;
            btnNieuweAanvraag.BackgroundImageLayout = ImageLayout.Stretch;
            btnNieuweAanvraag.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            btnExportToExcel.BackColor = StyleParameters.Achtergrondkleur;
            btnExportToExcel.BackgroundImage = imgExportToExcel;
            btnExportToExcel.BackgroundImageLayout = ImageLayout.Stretch;
            btnExportToExcel.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            this.Icon = imgFormIcon;
            
        }
        private void FrmAanvraagFormulier_AanvraagBewaard(object sender, EventArgs e)
        {
            aanvragen = AanvraagManager.GetAanvragen();

            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }
        private void Gli_AanvraagItemSelected(object sender, EventArgs e)
        {
            AanvraagItem geselecteerd = (AanvraagItem)sender;
        }
        private List<Aanvraag> FilteredAanvraagItems(List<Aanvraag> items, bool aanvraagmomentVan, bool aanvraagmomentTot, bool planningsdatumVan, bool planningsdatumTot, bool gebruiker, bool titel, bool statusAanvraag, bool financieringsjaar, bool bedragVan, bool bedragTot, bool kostenPlaats)
        {
            if (items != null)
            {
                if (aanvraagmomentVan)
                {
                    if (chbxAanvraagmomentVan.Checked == true)
                    {
                        items = items.Where(av => av.Aanvraagmoment >= Convert.ToDateTime(dtpAanvraagmomentVan.Text)).ToList();
                    }
                }
                if (aanvraagmomentTot)
                {
                    if (chbxAanvraagmomentTot.Checked == true)
                    {
                        items = items.Where(av => av.Aanvraagmoment <= (Convert.ToDateTime(dtpAanvraagmomentTot.Text)).Add(new TimeSpan(23, 59, 59))).ToList();
                    }      
                }
                if (planningsdatumVan)
                {
                    if (chbxPlaningsdatumVan.Checked == true)
                    {
                        items = items.Where(av => av.Planningsdatum != null && av.Planningsdatum >= Convert.ToDateTime(dtpPlanningsdatumVan.Text)).ToList();
                    }
                }
                if (planningsdatumTot)
                {
                    if (chbxPlaningsdatumTot.Checked == true)
                    {
                        items = items.Where(av => av.Planningsdatum != null && av.Planningsdatum <= (Convert.ToDateTime(dtpPlanningsdatumTot.Text)).Add(new TimeSpan(23, 59, 59))).ToList();
                    }
                }
                if (gebruiker)
                {
                    items = items.Where(av => av.Gebruiker.ToLower().Contains(txtGebruiker.Text.ToLower())).ToList();
                }
                if (titel)
                {
                    items = items.Where(av => av.Titel.ToLower().Contains(txtTitel.Text.ToLower())).ToList();
                }
                if (statusAanvraag)
                {
                    items = items.Where(av => av.StatusAanvraag.ToLower().Contains(txtStatusAanvraag.Text.ToLower())).ToList();
                }
                if (financieringsjaar)
                {
                    if (txtFinancieringsjaar.Text != string.Empty)
                    {
                        items = items.Where(av => av.Financieringsjaar != null && av.Financieringsjaar.ToString().Contains(txtFinancieringsjaar.Text.ToLower())).ToList();
                    }
                }
                if (bedragVan)
                {
                    if (txtBedragVan.Text != string.Empty)
                    {
                        items = items.Where(av => (decimal)(av.AantalStuk * av.PrijsIndicatieStuk) >= Convert.ToDecimal(txtBedragVan.Text)).ToList();
                    } 
                }
                if (bedragTot)
                {
                    if(txtBedragTot.Text != string.Empty)
                    {
                        items = items.Where(av => (decimal)(av.AantalStuk * av.PrijsIndicatieStuk) <= Convert.ToDecimal(txtBedragTot.Text)).ToList();
                    }
                }
                if (kostenPlaats)
                {
                    items = items.Where(av => av.Kostenplaats.ToLower().Contains(txtKostenPlaats.Text.ToLower())).ToList();
                }
            }
           return items;
        }
        private void FrmAanvragen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFinancieringsjaar.Text != string.Empty)
                {
                    filterFinancieringsjaar = true;
                }
                if (txtStatusAanvraag.Text != string.Empty)
                {
                    filterStatusAanvraag = true;
                }
                if (cbBedragVan.Checked != false)
                {
                    filterBedragVan = true;
                }
                if (cbBedragTot.Checked != false)
                {
                    filterBedragTot = true;
                }
                if (txtTitel.Text != string.Empty)
                {
                    filterTitel = true;
                }
                if (txtKostenPlaats.Text != string.Empty)
                {
                    filterKostenPlaats = true;
                }
                if (txtGebruiker.Text != string.Empty)
                {
                    filterGebruiker = true;
                }
                if (chbxPlaningsdatumTot.Checked != false)
                {
                    filterPlanningsdatumTot = true;
                }
                if (chbxAanvraagmomentVan.Checked != false)
                {
                    filterAanvraagmomentVan = true;
                }
                if (chbxAanvraagmomentTot.Checked != false)
                {
                    filterAanvraagmomentTot = true;
                }
                if (chbxPlaningsdatumVan.Checked != false)
                {
                    filterPlanningsdatumVan = true;
                }

                aanvragen = FilteredAanvraagItems(AanvraagManager.GetAanvragen(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);

                huidigePage = 1;
                StartPaging();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSortGebruiker_Click(object sender, EventArgs e)
        {
            if(SortGebruiker == true)
            {
                SortGebruiker = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetGebruikerDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortGebruiker = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetGebruikerAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
        }
        private void btnSortTitel_Click(object sender, EventArgs e)
        {
            if(SortTitel == true)
            {
                SortTitel = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetTitelDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);

            }
            else
            {
                SortTitel = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetTitelAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
        }
        private void btnSortAanvraagmoment_Click(object sender, EventArgs e)
        {
            if(SortAanvraagmoment == true)
            {
                SortAanvraagmoment = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetAanvraagmomentDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortAanvraagmoment = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetAanvraagmomentAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
        }
        private void btnSortFinancieringsjaar_Click(object sender, EventArgs e)
        {
            if(SortFinancieringsjaar == true)
            {
                SortFinancieringsjaar = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetFinancieringsjaarDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortFinancieringsjaar = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetFinancieringsjaarAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
        }
        private void btnSortStatusAanvraag_Click(object sender, EventArgs e)
        {
            if(SortStatusAanvraag == true)
            {
                SortStatusAanvraag = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetStatusAanvraagDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortStatusAanvraag = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetStatusAanvraagAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
        }
        private void btnBedrag_Click(object sender, EventArgs e)
        {
            if(SortBedrag == true)
            {
                SortBedrag = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetBedragDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortBedrag = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetBedragAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
        }
        private void btnKostenplaats_Click(object sender, EventArgs e)
        {
            if(SortKostenPlaats == true)
            {
                SortKostenPlaats = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetKostenplaatstDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortKostenPlaats = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetKostenplaatstAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
        }
        private void btnPlanningsdatum_Click(object sender, EventArgs e)
        {
            if(SortPlanningsdatum == true)
            {
                SortPlanningsdatum = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetPlanningsdatumDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortPlanningsdatum = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.GetPlanningsdatumAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
        }
        private bool IsGeldigFinancieringsjaar(char c)
        {
            bool isValid = true;

            if ((int)c < 48 || (int)c > 57)
            {
                if((int)c != 8)
                {
                    isValid = false;
                }
                
            }

            return isValid;
        }
        private void txtBedragVan_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (System.Text.RegularExpressions.Regex.IsMatch(txtBedragVan.Text, "[^0-9]"))
            //    {
            //        //MessageBox.Show("Je kunt alleen cijfers ingeven.");
            //        txtBedragVan.Text = txtBedragVan.Text.Remove(txtBedragVan.Text.Length - 1);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void txtBedragTot_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (System.Text.RegularExpressions.Regex.IsMatch(txtBedragTot.Text, "[^0-9]"))
            //    {
            //        //MessageBox.Show("Je kunt alleen cijfers ingeven.");
            //        txtBedragTot.Text = txtBedragTot.Text.Remove(txtBedragTot.Text.Length - 1);
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void FrmAanvragen_Shown(object sender, EventArgs e)
        {
            try
            {
                aanvragen = AanvraagManager.GetAanvragen();
                if (aanvragen != null)
                {
                    StartPaging();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EnableFirstPrevious(bool enable)
        {
            if (enable)
            {
                btnFirst.BackgroundImage = imgFirst;
                btnPrevious.BackgroundImage = imgPrevious;
            }
            else
            {
                btnFirst.BackgroundImage = imgFirstDisable;
                btnPrevious.BackgroundImage = imgPreviousDisable;
            }
            btnFirst.Enabled = enable;
            btnPrevious.Enabled = enable;
        }
        private void EnableLastNext(bool enable)
        {
            if (enable)
            {
                btnLast.BackgroundImage = imgLast;
                btnNext.BackgroundImage = imgNext;
            }
            else
            {
                btnLast.BackgroundImage = imgLastDisable;
                btnNext.BackgroundImage = imgNextDisable;
            }
            btnLast.Enabled = enable;
            btnNext.Enabled = enable;
        }
        private void btnLast_MouseHover(object sender, EventArgs e)
        {
            btnLast.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;
            btnLast.BackgroundImage = imgLastHover;
        }
        private void btnLast_MouseLeave(object sender, EventArgs e)
        {
            if (huidigePage == aantalPages)
            {
                btnLast.BackgroundImage = imgLastDisable;
            }
            else
            {
                btnLast.BackgroundImage = imgLast;
            }
        }
        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = imgNextHover;
        }
        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            if (huidigePage == aantalPages)
            {
                btnNext.BackgroundImage = imgNextDisable;
            }
            else
            {
                btnNext.BackgroundImage = imgNext;
            }
        }
        private void btnPrevious_MouseHover(object sender, EventArgs e)
        {
            btnPrevious.BackgroundImage = imgPreviousHover;
        }
        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            if (huidigePage == 1)
            {
                btnPrevious.BackgroundImage = imgPreviousDisable;
            }
            else
            {
                btnPrevious.BackgroundImage = imgPrevious;
            }
        }
        private void btnFirst_MouseHover(object sender, EventArgs e)
        {
            btnFirst.BackgroundImage = imgFirstHover;
        }
        private void btnFirst_MouseLeave(object sender, EventArgs e)
        {
            if (huidigePage == 1)
            {
                btnFirst.BackgroundImage = imgFirstDisable;
            }
            else
            {
                btnFirst.BackgroundImage = imgFirst;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            huidigePage++;
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
            }
            else if (huidigePage == aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(true);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            huidigePage--;
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
            }
            if (huidigePage == 1)
            {
                EnableFirstPrevious(false);
            }
            EnableLastNext(true);
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            huidigePage = 1;
            ShowPages();
            BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
            EnableFirstPrevious(false);
            if (huidigePage < aantalPages)
            {
                EnableLastNext(true);
            }
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            huidigePage = aantalPages;
            ShowPages();
            BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
            EnableLastNext(false);
            if (huidigePage > 1)
            {
                EnableFirstPrevious(true);
            }
        }
        private void StartPaging()
        {
            if (aanvragen.Count > aantalListItems)
            {
                //Paging is nodig
                aantalPages = (aanvragen.Count / aantalListItems);
                if ((aanvragen.Count % aantalListItems) != 0)
                {
                    aantalPages++;
                }

                ShowPages();

                if (huidigePage < aantalPages)
                {
                    BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                    EnableLastNext(true);
                }
                if (huidigePage == 1)
                {
                    EnableFirstPrevious(false);
                }
            }
            else
            {
                aantalPages = 1;
                ShowPages();
                BindAanvraag(aanvragen);
                EnableFirstPrevious(false);
                EnableLastNext(false);
            }
        }
        private void ShowPages()
        {
            lblPages.Text = huidigePage.ToString() + " van " + aantalPages.ToString();
        }
        private void txtBedragTot_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && (e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            
        }
        public void txtBedragVan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && (e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public void txtFinancieringsjaar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !IsGeldigFinancieringsjaar(e.KeyChar);
        }

        public static Color StringToColor(string colorStr)
        {
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            Color result = (Color)cc.ConvertFromString(colorStr);
            return result;
        }

        Color textKleurExc = StringToColor(ParameterManager.GetParameterByCode("TekstExcel").Waarde);
        Color DataDonkerExc = StringToColor(ParameterManager.GetParameterByCode("MaandExcelD").Waarde);

        Color DataLicht1Exc = StringToColor(ParameterManager.GetParameterByCode("DataExcelL1").Waarde);
        Color DataLicht2Exc = StringToColor(ParameterManager.GetParameterByCode("DataExcelL2").Waarde);
        


        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            lblWachtenExcelAanvragen.Visible = true;
            lblWachtenExcelAanvragen.Text = "Data in Excel verwerken...";

            try
            {
                var app = new Excel.Application();
                app.Visible = false;
                object Nothing = Type.Missing;
                Excel.Workbook workbook = app.Workbooks.Add(Nothing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                List<Aanvraag> gefilterdeAanvragen = aanvragen;

                if (gefilterdeAanvragen == null || gefilterdeAanvragen.Count == 0)
                {
                    MessageBox.Show("Geen aanvragen gevonden om te exporteren.", "Exporteren", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string[] header = new string[] { 
                    "Aanvrager", "Titel", "Aanvraagdatum", 
                    "Afdeling", "Dienst", "Financieringsjaar",
                    "Status aanvraag", "Bedrag", "Kostenplaats",
                    "Planningsdatum" };

                //Opmaak header
                for (int i = 0; i < header.Length; i++)
                {
                    var cell = worksheet.Cells[1, i + 1];
                    cell.Value = header[i];
                    cell.Font.Color = System.Drawing.ColorTranslator.ToOle(textKleurExc);
                    cell.Font.Bold = true;
                    cell.Font.Size = 11;
                    cell.Interior.Color = DataDonkerExc;
                    cell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    
                }

                for (int i = 0; i < header.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = header[i];
                    worksheet.Cells[1, i + 1].Font.Bold = true;
                    worksheet.Cells[1, i + 1].Interior.Color = DataDonkerExc;
                }

                int row = 2;

                foreach (var a in gefilterdeAanvragen)
                {

                    decimal bedrag = a.AantalStuk * a.PrijsIndicatieStuk;

                    worksheet.Cells[row, 1] = a.Gebruiker;
                    worksheet.Cells[row, 2] = a.Titel;

                    if (a.Aanvraagmoment != DateTime.MinValue)
                    {
                        worksheet.Cells[row, 3].Value = a.Aanvraagmoment;
                        worksheet.Cells[row, 3].NumberFormat = "dd/mm/jjjj";
                    }
                    else
                    {
                        worksheet.Cells[row, 3].Value = "Nog niet aangevraagd";
                    }

                    worksheet.Cells[row, 4] = AfdelingenManager.GetAfdelingNaamById(a.AfdelingId);
                    worksheet.Cells[row, 5] = DienstenManager.GetDienstNaamById(a.DienstId);

                    worksheet.Cells[row, 6] = a.Financieringsjaar?.ToString();

                    worksheet.Cells[row, 7] = a.StatusAanvraag;

                    if (bedrag == 0)
                    {
                        worksheet.Cells[row, 8].Value = "Geen Kost";
                        worksheet.Cells[row, 8].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }
                    else
                    {
                        worksheet.Cells[row, 8].Value = bedrag;
                        worksheet.Cells[row, 8].NumberFormat = "€ #.##,00;;";
                        worksheet.Cells[row, 8].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }
                    
                    worksheet.Cells[row, 9] = a.Kostenplaats;
                    
                    if (a.Planningsdatum != DateTime.MinValue)
                    {
                        worksheet.Cells[row, 10].Value = a.Planningsdatum;
                        worksheet.Cells[row, 10].NumberFormat = "dd/mm/jjjj";
                    }
                    else
                    {
                        worksheet.Cells[row, 10].Value = "Nog niet gepland";
                    }

                    Excel.Range rijRange = worksheet.Range[$"A{row}:J{row}"];
                    rijRange.Font.Color = System.Drawing.ColorTranslator.ToOle(textKleurExc);
                    

                    if (row % 2 == 0)
                        rijRange.Interior.Color = DataLicht2Exc;
                    else
                        rijRange.Interior.Color = DataLicht1Exc;

                    row++;

                }

                Excel.Range used = worksheet.Range["A1:J" + (row - 1)];
                used.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                used.Borders.Color = textKleurExc;

                worksheet.Range["A:J"].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                worksheet.Columns[8].HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                worksheet.Columns.AutoFit();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "AanvragenExport";
                saveFileDialog.Filter = "Excel bestanden (*.xlsx)|*.xlsx";
                saveFileDialog.FilterIndex = 1;

                lblWachtenExcelAanvragen.Visible = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK) 
                { 
                    worksheet.SaveAs(saveFileDialog.FileName);
                    workbook.Close(false, saveFileDialog.FileName, false);
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(worksheet);
                    app.Quit();
                     
                    MessageBox.Show("Het Excel bestand staat klaar.", "Exporteren", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblWachtenExcelAanvragen.Visible = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Fout bij export: " + ex.Message, "Exporteren", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
