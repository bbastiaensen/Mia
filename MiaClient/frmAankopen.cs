﻿using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using Microsoft.Office.Interop.Excel;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmAankopen : Form
    {
        bool filterBedragVan = false;
        bool filterBedragTot = false;
        bool filterTitel = false;
        bool filterGebruiker = false;
        bool filterPlanningsdatumTot = false;
        bool filterPlanningsdatumVan = false;
        bool SortTitel = true;
        bool SortTtlBedr = true;
        bool SortAanv = true;
        bool SortRP = true;
        bool SortJaar = false;
        bool RSort = false;
        int aantalItems = 10;
        int huidigePage = 1;
        int aantalPages = 0;
        List<Aanvraag> aanvragen;
        Image imgFilter = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "Filter.png"));
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

        public frmAankopen()
        {
            InitializeComponent();
        }
        private void frmAankopen_Load(object sender, EventArgs e)
        {
            try
            {
                if (cmbFinancieringsjaar.SelectedIndex > -1)
                {
                    SortJaar = true;
                }
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aanvraag_sort_sorteertvologorde_asc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);

                huidigePage = 1;
                StartPaging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.BackColor = StyleParameters.Achtergrondkleur;

            btnFilter.BackgroundImage = imgFilter;
            btnFilter.BackgroundImageLayout = ImageLayout.Stretch;
            btnFilter.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

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
            List<string> jaren = FinancieringsjaarManager.GetFinancieringsjaren();
            foreach (string jaar in jaren)
            {
                cmbFinancieringsjaar.Items.Add(jaar);
            }
            cmbFinancieringsjaar.SelectedItem = DateTime.Now.Year.ToString();
        }

        private void frmAankopen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }
        public void BindAanvraag(List<Aanvraag> items)
        {
            //Haalt alle aanvragen uit de databank en zet deze in een lijst die we toonen.
            this.pnlAanvragen.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int n = 0;
            if (items != null)
            {

                foreach (var av in items)
                {

                    AankopenItem avi = new AankopenItem(av.Id, av.Titel, av.Gebruiker, av.Financieringsjaar, av.PrijsIndicatieStuk, av.AantalStuk, n % 2 == 0, av.RichtperiodeId);

                    avi.Location = new System.Drawing.Point(xPos, yPos);
                    avi.Name = "aanvraagSelection" + n;
                    avi.Size = new System.Drawing.Size(1210, 20);
                    avi.TabIndex = n + 8;
                    avi.AanvraagItemSelected += Gli_AanvraagItemSelected;
                    avi.AanvraagDeleted += Avi_AanvraagItemChanged;
                    avi.AanvraagItemChanged += Avi_AanvraagItemChanged;
                    this.pnlAanvragen.Controls.Add(avi);
                    n++;
                    yPos += 21;
                }
            }
        }
        private void Gli_AanvraagItemSelected(object sender, EventArgs e)
        {
            AankopenItem geselecteerd = (AankopenItem)sender;
        }
        private void Avi_AanvraagItemChanged(object sender, EventArgs e)
        {
            try
            {
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aanvraag_sort_sorteertvologorde_asc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);

                huidigePage = 1;
                StartPaging();
                ShowPages();
                if (huidigePage < aantalPages)
                {
                    BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
                    EnableLastNext(true);
                }
                else if (huidigePage == aantalPages)
                {
                    BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).ToList());
                    EnableLastNext(false);
                }
                EnableFirstPrevious(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Aanvraag> FilteredAanvraagItems(List<Aanvraag> items, bool planningsdatumVan, bool planningsdatumTot, bool gebruiker, bool titel, bool bedragVan, bool bedragTot, bool jaar, bool penis)
        {
            if (items != null)
            {
                if (RSort)
                {
                    //items = items.Where(av =>);              
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
                if (jaar)
                {
                    if (cmbFinancieringsjaar.SelectedIndex > -1)
                    {
                        items = items.Where(av => av.Financieringsjaar.ToString().Contains(cmbFinancieringsjaar.SelectedItem.ToString())).ToList();
                    }
                }
                if (bedragVan)
                {
                    if (cbBedragVan.Checked == true)
                    {
                        if (txtBedragVan.Text != string.Empty)
                        {
                            items = items.Where(av => (av.PrijsIndicatieStuk * av.AantalStuk) >= Convert.ToDecimal(txtBedragVan.Text)).ToList();
                        }
                    }
                }
                if (bedragTot)
                {
                    if (cbBedragTot.Checked == true)
                    {
                        if (txtBedragTot.Text != string.Empty)
                        {
                            items = items.Where(av => (av.PrijsIndicatieStuk * av.AantalStuk) <= Convert.ToDecimal(txtBedragTot.Text)).ToList();
                        }
                    }
                }
            }
            return items;
        }
        private void frmAankopen_AanvraagBewaard(object sender, EventArgs e)
        {
            aanvragen = AanvraagManager.Aanvraag_sort_sorteertvologorde_asc();

            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
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
                if (txtGebruiker.Text != string.Empty)
                {
                    filterGebruiker = true;
                }
                if (chbxPlaningsdatumVan.Checked != false)
                {
                    filterPlanningsdatumTot = true;
                }
                if (chbxPlaningsdatumTot.Checked != false)
                {
                    filterPlanningsdatumTot = true;
                }
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aanvraag_sort_sorteertvologorde_asc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);

                huidigePage = 1;
                StartPaging();

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
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
            }
            else if (huidigePage == aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).ToList());
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
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
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
            BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
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
            BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).ToList());
            EnableLastNext(false);
            if (huidigePage > 1)
            {
                EnableFirstPrevious(true);
            }
        }
        private void StartPaging()
        {
            if (aanvragen.Count > aantalItems)
            {
                //Paging is nodig
                aantalPages = (aanvragen.Count / aantalItems);
                if ((aanvragen.Count % aantalItems) != 0)
                {
                    aantalPages++;
                }

                ShowPages();

                if (huidigePage < aantalPages)
                {
                    BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
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

        private void frmAankopen_Shown(object sender, EventArgs e)
        {
            try
            {
                aanvragen = AanvraagManager.Aanvraag_sort_sorteertvologorde_asc();
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

        private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFinancieringsjaar.SelectedIndex > -1)
                {
                    SortJaar = true;
                }

                aanvragen = FilteredAanvraagItems(AanvraagManager.Aanvraag_sort_sorteertvologorde_asc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);

                huidigePage = 1;
                StartPaging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSortTitel_Click(object sender, EventArgs e)
        {
            if (SortTitel == true)
            {
                SortTitel = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aankopen_sort_aanvrager_desc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);
            }
            else
            {
                SortTitel = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aankopen_sort_aanvrager_asc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);
            }
            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }

        private void btnBedrag_Click(object sender, EventArgs e)
        {
            if (SortTtlBedr == true)
            {
                SortTtlBedr = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aankopen_sort_bedrag_desc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);
            }
            else
            {
                SortTtlBedr = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aankopen_sort_bedrag_asc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);
            }
            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }

        private void btnSortAanvrager_Click(object sender, EventArgs e)
        {
            if (SortAanv == true)
            {
                SortAanv = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aankopen_sort_aanvrager_desc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);
            }
            else
            {
                SortAanv = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aankopen_sort_aanvrager_asc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);
            }
            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }

        private void btnSortRichtperiode_Click(object sender, EventArgs e)
        {
            if (SortRP == true)
            {
                SortRP = false;
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aanvraag_sort_sorteertvologorde_asc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);
            }
            else
            {
                SortRP = true;
                aanvragen = FilteredAanvraagItems(AanvraagManager.Aanvraag_sort_sorteertvologorde_desc(), filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterBedragVan, filterBedragTot, SortJaar, RSort);
            }
            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }
    }
}
