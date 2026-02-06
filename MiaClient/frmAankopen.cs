using MiaClient.UserControls;
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
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmAankopen : Form
    {
        private frmNieuweAankoop frmNieuweAankoop;

        bool filterOmschrijving = false;
        bool filterStatusAankoop = false;
        bool filterAankoper = false;
        bool filterAanvrager = false;
        bool filterFinancieringsjaar = false;
        bool filterRichtperiode = false;
        bool filterGoedgekeurdBedragVan = false;
        bool filterGoedgekeurdBedragTot = false;
        bool filterSaldoVan = false;
        bool filterSaldoTot = false;

        bool SortGebruiker = true;
        bool SortStatusAankoop = true;
        bool SortAankoper = true;
        bool SortTitel = true;
        bool SortFinancieringsjaar = true;
        bool SortRichtperiode = true;
        bool SortGoedgekeurdBedrag = true;
        bool SortSaldo = true;
        bool SortAanvraagmoment = true;
        bool SortAanvrager = true;
        int aantalItems = 10;
        int huidigePage = 1;
        int aantalPages = 0;
        List<AankoopOverzichtItem> aankopen;
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
        Image imgExportToExcel = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "excelExport.png"));
        Image imgAdd = null;

   

        public frmAankopen()
        {
            InitializeComponent();
            
            // Load add icon if available, otherwise use nieuweAanvraag.png
            string addIconPath = Path.Combine(Directory.GetCurrentDirectory(), "icons", "add.png");
            if (File.Exists(addIconPath))
            {
                imgAdd = (Image)new Bitmap(addIconPath);
            }
            else
            {
                // Fallback to nieuweAanvraag.png if add.png doesn't exist
                string nieuweAanvraagPath = Path.Combine(Directory.GetCurrentDirectory(), "icons", "nieuweAanvraag.png");
                if (File.Exists(nieuweAanvraagPath))
                {
                    imgAdd = (Image)new Bitmap(nieuweAanvraagPath);
                }
            }
        }
        private void frmAankopen_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            try
            {
                LoadAankopen();
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

            btnExportToExcel.BackColor = StyleParameters.Achtergrondkleur;
            btnExportToExcel.BackgroundImage = imgExportToExcel;
            btnExportToExcel.BackgroundImageLayout = ImageLayout.Stretch;
            btnExportToExcel.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            // Add button (placeholder for future functionality)
            if (btnAdd != null && imgAdd != null)
            {

                btnAdd.BackColor = StyleParameters.Achtergrondkleur;
                btnAdd.BackgroundImage = imgAdd;
                btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
                btnAdd.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;
            }

            List<string> jaren = FinancieringsjaarManager.GetFinancieringsjaren();
            foreach (string jaar in jaren)
            {
                cmbFinancieringsjaar.Items.Add(jaar);
            }
            cmbFinancieringsjaar.SelectedItem = DateTime.Now.Year.ToString();
        }

        private void LoadAankopen()
        {
            aankopen = AankoopManager.GetAllAankopen();
            aankopen = FilteredAankoopItems(aankopen);
            huidigePage = 1;
            StartPaging();
        }

        private List<AankoopOverzichtItem> GetFilteredAankopen()
        {
            var baseList = AankoopManager.GetAllAankopen();
            return FilteredAankoopItems(baseList);
        }
   
        private void frmAankopen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }
        public void BindAankopen(List<AankoopOverzichtItem> items)
        {
            //Haalt alle aankopen uit de databank en zet deze in een lijst die we tonen.
            this.pnlAanvragen.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int n = 0;
            if (items != null)
            {
                foreach (var ak in items)
                {
                    AankopenItem aki = new AankopenItem();
                    aki.BindAankoop(ak, n % 2 == 0);
                    aki.Location = new System.Drawing.Point(xPos, yPos);
                    aki.Name = "aankoopSelection" + n;
                    aki.Size = new System.Drawing.Size(1855, 33);
                    aki.TabIndex = n + 8;
                    aki.AankoopItemSelected += Aki_AankoopItemSelected;
                    aki.AankoopDeleted += Aki_AankoopDeleted;
                    aki.AankoopItemChanged += Aki_AankoopItemChanged;
                    this.pnlAanvragen.Controls.Add(aki);
                    n++;
                    yPos += 34;
                }
            }
        }

        private void Aki_AankoopItemSelected(object sender, EventArgs e)
        {
            AankopenItem geselecteerd = (AankopenItem)sender;
            // Open frmAankoopDetail with the purchase ID
            // This will be implemented in another User Story
            // frmAankoopDetail detailForm = new frmAankoopDetail(geselecteerd.AankoopId);
            // detailForm.Show();
        }

        private void Aki_AankoopDeleted(object sender, EventArgs e)
        {
            try
            {
                AankopenItem item = (AankopenItem)sender;
                Aankoop aankoop = AankoopManager.GetAankoopById(item.AankoopId);
                StatusAankoop status = StatusAankoopManager.GetStatusAankoopById(aankoop.StatusAankoopId);

                if (status != null && status.Naam != null && status.Naam.Equals("Gepland", StringComparison.OrdinalIgnoreCase))
                {
                    if (MessageBox.Show("Ben je zeker dat je deze aankoop wilt verwijderen?", "Aankopen", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AankoopManager.DeleteAankoop(item.AankoopId);
                        MessageBox.Show("De aankoop is succesvol verwijderd.", "Succes", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAankopen();
                    }
                }
                else
                {
                    MessageBox.Show("De aankoop kan niet meer verwijderd worden uit het systeem.", 
                        "Geen Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Aanvraag> FilteredAanvraagItems(List<Aanvraag> items, bool planningsdatumVan, bool planningsdatumTot, bool gebruiker, bool titel, bool bedragVan, bool bedragTot, bool jaar, bool on)
        {
            if (items != null)
            {
                //if (RSort)
                //{
                //    //items = items.Where(av =>);              
                //}
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

        private void Aki_AankoopItemChanged(object sender, EventArgs e)
        {
            try
            {
                LoadAankopen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<AankoopOverzichtItem> FilteredAankoopItems(List<AankoopOverzichtItem> items)
        {
            if (items == null) return new List<AankoopOverzichtItem>();

            var filtered = items.AsEnumerable();

            // Filter on Omschrijving - can use existing txtTitel if available, or add txtOmschrijving later
            if (filterOmschrijving)
            {
                string filterValue = "";
                if (txtOmschrijving != null && !string.IsNullOrEmpty(txtOmschrijving.Text))
                    filterValue = txtOmschrijving.Text;
                else if (txtTitel != null && !string.IsNullOrEmpty(txtTitel.Text))
                    filterValue = txtTitel.Text; // Fallback to existing control
                
                if (!string.IsNullOrEmpty(filterValue))
                {
                    filtered = filtered.Where(ak => ak.Omschrijving != null && 
                        ak.Omschrijving.ToLower().Contains(filterValue.ToLower()));
                }
            }

            // Filter on StatusAankoop
            if (filterStatusAankoop && txtStatusAankoop != null && !string.IsNullOrEmpty(txtStatusAankoop.Text))
            {
                filtered = filtered.Where(ak => ak.StatusAankoop != null && 
                    ak.StatusAankoop.ToLower().Contains(txtStatusAankoop.Text.ToLower()));
            }

            // Filter on Aankoper
            if (filterAankoper && txtAankoper != null && !string.IsNullOrEmpty(txtAankoper.Text))
            {
                filtered = filtered.Where(ak => ak.Aankoper != null && 
                    ak.Aankoper.ToLower().Contains(txtAankoper.Text.ToLower()));
            }

            // Filter on Aanvrager - can use existing txtGebruiker
            if (filterAanvrager)
            {
                string filterValue = "";
                if (txtAanvrager != null && !string.IsNullOrEmpty(txtAanvrager.Text))
                    filterValue = txtAanvrager.Text;
                else if (txtGebruiker != null && !string.IsNullOrEmpty(txtGebruiker.Text))
                    filterValue = txtGebruiker.Text; // Fallback to existing control
                
                if (!string.IsNullOrEmpty(filterValue))
                {
                    filtered = filtered.Where(ak => ak.Aanvrager != null && 
                        ak.Aanvrager.ToLower().Contains(filterValue.ToLower()));
                }
            }

            // Filter on Financieringsjaar
            if (filterFinancieringsjaar && cmbFinancieringsjaar != null && cmbFinancieringsjaar.SelectedIndex > -1)
            {
                string selectedJaar = cmbFinancieringsjaar.SelectedItem.ToString();
                filtered = filtered.Where(ak => ak.Financieringsjaar != null && 
                    ak.Financieringsjaar.Contains(selectedJaar));
            }

            // Filter on Richtperiode
            if (filterRichtperiode && txtRichtperiode != null && !string.IsNullOrEmpty(txtRichtperiode.Text))
            {
                filtered = filtered.Where(ak => ak.Richtperiode != null && 
                    ak.Richtperiode.ToLower().Contains(txtRichtperiode.Text.ToLower()));
            }

            // Filter on GoedgekeurdBedrag - can use existing txtBedragVan/txtBedragTot
            if (filterGoedgekeurdBedragVan)
            {
                decimal bedragVan = 0;
                bool hasValue = false;
                if (txtGoedgekeurdBedragVan != null && decimal.TryParse(txtGoedgekeurdBedragVan.Text, out bedragVan))
                    hasValue = true;
                else if (txtBedragVan != null && decimal.TryParse(txtBedragVan.Text, out bedragVan))
                    hasValue = true; // Fallback to existing control
                
                if (hasValue)
                {
                    filtered = filtered.Where(ak => ak.GoedgekeurdBedrag >= bedragVan);
                }
            }

            if (filterGoedgekeurdBedragTot)
            {
                decimal bedragTot = 0;
                bool hasValue = false;
                if (txtGoedgekeurdBedragTot != null && decimal.TryParse(txtGoedgekeurdBedragTot.Text, out bedragTot))
                    hasValue = true;
                else if (txtBedragTot != null && decimal.TryParse(txtBedragTot.Text, out bedragTot))
                    hasValue = true; // Fallback to existing control
                
                if (hasValue)
                {
                    filtered = filtered.Where(ak => ak.GoedgekeurdBedrag <= bedragTot);
                }
            }

            // Filter on Saldo
            if (filterSaldoVan && txtSaldoVan != null && !string.IsNullOrEmpty(txtSaldoVan.Text))
            {
                if (decimal.TryParse(txtSaldoVan.Text, out decimal saldoVan))
                {
                    filtered = filtered.Where(ak => ak.Saldo >= saldoVan);
                }
            }

            if (filterSaldoTot && txtSaldoTot != null && !string.IsNullOrEmpty(txtSaldoTot.Text))
            {
                if (decimal.TryParse(txtSaldoTot.Text, out decimal saldoTot))
                {
                    filtered = filtered.Where(ak => ak.Saldo <= saldoTot);
                }
            }

            return filtered.ToList();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset filters
                filterOmschrijving = false;
                filterStatusAankoop = false;
                filterAankoper = false;
                filterAanvrager = false;
                filterFinancieringsjaar = false;
                filterRichtperiode = false;
                filterGoedgekeurdBedragVan = false;
                filterGoedgekeurdBedragTot = false;
                filterSaldoVan = false;
                filterSaldoTot = false;

                // Set active filters based on input
                if ((txtOmschrijving != null && !string.IsNullOrEmpty(txtOmschrijving.Text)) ||
                    (txtTitel != null && !string.IsNullOrEmpty(txtTitel.Text)))
                    filterOmschrijving = true;
                if (txtStatusAankoop != null && !string.IsNullOrEmpty(txtStatusAankoop.Text))
                    filterStatusAankoop = true;
                if (txtAankoper != null && !string.IsNullOrEmpty(txtAankoper.Text))
                    filterAankoper = true;
                if ((txtAanvrager != null && !string.IsNullOrEmpty(txtAanvrager.Text)) ||
                    (txtGebruiker != null && !string.IsNullOrEmpty(txtGebruiker.Text)))
                    filterAanvrager = true;
                if (cmbFinancieringsjaar != null && cmbFinancieringsjaar.SelectedIndex > -1)
                    filterFinancieringsjaar = true;
                if (txtRichtperiode != null && !string.IsNullOrEmpty(txtRichtperiode.Text))
                    filterRichtperiode = true;
                if ((txtGoedgekeurdBedragVan != null && !string.IsNullOrEmpty(txtGoedgekeurdBedragVan.Text)) ||
                    (txtBedragVan != null && !string.IsNullOrEmpty(txtBedragVan.Text)))
                    filterGoedgekeurdBedragVan = true;
                if ((txtGoedgekeurdBedragTot != null && !string.IsNullOrEmpty(txtGoedgekeurdBedragTot.Text)) ||
                    (txtBedragTot != null && !string.IsNullOrEmpty(txtBedragTot.Text)))
                    filterGoedgekeurdBedragTot = true;
                if (txtSaldoVan != null && !string.IsNullOrEmpty(txtSaldoVan.Text))
                    filterSaldoVan = true;
                if (txtSaldoTot != null && !string.IsNullOrEmpty(txtSaldoTot.Text))
                    filterSaldoTot = true;

                LoadAankopen();
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

            btnNext.Invalidate(); // force redraw
            btnNext.Refresh();
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
            if (aankopen == null) return;
            huidigePage++;
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAankopen(aankopen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindAankopen(aankopen.Skip((huidigePage - 1) * aantalItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(true);
            RefreshPagingButtonImages();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (aankopen == null) return;
            huidigePage--;
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindAankopen(aankopen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
            }
            if (huidigePage == 1)
            {
                EnableFirstPrevious(false);
            }
            EnableLastNext(true);
            RefreshPagingButtonImages();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (aankopen == null) return;
            huidigePage = 1;
            ShowPages();
            BindAankopen(aankopen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
            EnableFirstPrevious(false);
            if (huidigePage < aantalPages)
            {
                EnableLastNext(true);
            }
            RefreshPagingButtonImages();
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            if (aankopen == null) return;
            huidigePage = aantalPages;
            ShowPages();
            BindAankopen(aankopen.Skip((huidigePage - 1) * aantalItems).ToList());
            EnableLastNext(false);
            if (huidigePage > 1)
            {
                EnableFirstPrevious(true);
            }
            RefreshPagingButtonImages();
        }
        private void StartPaging()
        {
            if (aankopen != null && aankopen.Count > aantalItems)
            {
                //Paging is nodig
                aantalPages = (aankopen.Count / aantalItems);
                if ((aankopen.Count % aantalItems) != 0)
                {
                    aantalPages++;
                }

                ShowPages();

                if (huidigePage < aantalPages)
                {
                    BindAankopen(aankopen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
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
                if (aankopen != null)
                {
                    BindAankopen(aankopen);
                }
                EnableFirstPrevious(false);
                EnableLastNext(false);
            }
        }
        private void ShowPages()
        {
            lblPages.Text = huidigePage.ToString() + " van " + aantalPages.ToString();
        }
        private void RefreshPagingButtonImages()
        {
            btnFirst.BackgroundImage = huidigePage == 1 ? imgFirstDisable : imgFirst;
            btnPrevious.BackgroundImage = huidigePage == 1 ? imgPreviousDisable : imgPrevious;
            btnNext.BackgroundImage = huidigePage == aantalPages ? imgNextDisable : imgNext;
            btnLast.BackgroundImage = huidigePage == aantalPages ? imgLastDisable : imgLast;
        }

        private void frmAankopen_Shown(object sender, EventArgs e)
        {
            try
            {
                LoadAankopen();
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
                LoadAankopen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySortAndRefresh()
        {
            huidigePage = 1;
            StartPaging();
            ShowPages();
        }

        private void btnSortGebruiker_Click(object sender, EventArgs e)
        {
            aankopen = GetFilteredAankopen();
            if (SortGebruiker)
            {
                SortGebruiker = false;
                aankopen = aankopen.OrderByDescending(ak => ak.Aanvrager ?? "").ToList();
            }
            else
            {
                SortGebruiker = true;
                aankopen = aankopen.OrderBy(ak => ak.Aanvrager ?? "").ToList();
            }
            ApplySortAndRefresh();
        }

        //private void btnSortStatusAanvraag_Click(object sender, EventArgs e)
        //{
 
        //}



        //private void btnSortTitel_Click(object sender, EventArgs e)
        //{
        //    aankopen = GetFilteredAankopen();
        //    if (SortTitel)
        //    {
        //        SortTitel = false;
        //        aankopen = aankopen.OrderByDescending(ak => ak.Titel ?? "").ToList();
        //    }
        //    else
        //    {
        //        SortTitel = true;
        //        aankopen = aankopen.OrderBy(ak => ak.Titel ?? "").ToList();
        //    }
        //    ApplySortAndRefresh();
        //}

        //private void btnSortAanvraagmoment_Click(object sender, EventArgs e)
        //{
        //    aankopen = GetFilteredAankopen();
        //    if (SortAanvraagmoment)
        //    {
        //        SortAanvraagmoment = false;
        //        aankopen = aankopen.OrderByDescending(ak => ak.Aanvraagmoment).ToList();
        //    }
        //    else
        //    {
        //        SortAanvraagmoment = true;
        //        aankopen = aankopen.OrderBy(ak => ak.Aanvraagmoment).ToList();
        //    }
        //    ApplySortAndRefresh();
        //}






        //private void btnSortSaldo_Click(object sender, EventArgs e)
        //{
        //    aankopen = GetFilteredAankopen();
        //    if (SortSaldo)
        //    {
        //        SortSaldo = false;
        //        aankopen = aankopen.OrderByDescending(ak => ak.Saldo).ToList();
        //    }
        //    else
        //    {
        //        SortSaldo = true;
        //        aankopen = aankopen.OrderBy(ak => ak.Saldo).ToList();
        //    }
        //    ApplySortAndRefresh();
        //}

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

        const string euroFormaat = "€ #.##,00; - € #.##,00 ; € 0,00";

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Bestaat het formulier al?
            if (frmNieuweAankoop == null || frmNieuweAankoop.IsDisposed)
            {
                frmNieuweAankoop = new frmNieuweAankoop();
                frmNieuweAankoop.MdiParent = this.MdiParent;

                // Event koppelen: aankoop toegevoegd
                frmNieuweAankoop.AankoopToegevoegd += FrmNieuweAankoop_AankoopToegevoegd;
            }

            // Altijd verse data tonen
            frmNieuweAankoop.RefreshBekrachtigdeAanvragen();
            frmNieuweAankoop.Show();
            frmNieuweAankoop.BringToFront();
        }
        private void FrmNieuweAankoop_AankoopToegevoegd(object sender, EventArgs e)
        {
            try
            {
                // Aankopen opnieuw ophalen + filters toepassen
                aankopen = GetFilteredAankopen();

                huidigePage = 1;
                StartPaging();
                RefreshPagingButtonImages();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSortSatusaanvraag_Click(object sender, EventArgs e)
        {
            aankopen = GetFilteredAankopen();
            if (SortStatusAankoop)
            {
                SortStatusAankoop = false;
                aankopen = aankopen.OrderByDescending(ak => ak.StatusAankoop ?? "").ToList();
            }
            else
            {
                SortStatusAankoop = true;
                aankopen = aankopen.OrderBy(ak => ak.StatusAankoop ?? "").ToList();
            }
            ApplySortAndRefresh();
        }

        private void btnSortAankoperr_Click(object sender, EventArgs e)
        {
            aankopen = GetFilteredAankopen();
            if (SortAankoper)
            {
                SortAankoper = false;
                aankopen = aankopen.OrderByDescending(ak => ak.Aankoper ?? "").ToList();
            }
            else
            {
                SortAankoper = true;
                aankopen = aankopen.OrderBy(ak => ak.Aankoper ?? "").ToList();
            }
            ApplySortAndRefresh();
        }

        private void btnFinancieringssjaar_Click(object sender, EventArgs e)
        {
            aankopen = GetFilteredAankopen();
            if (SortFinancieringsjaar)
            {
                SortFinancieringsjaar = false;
                aankopen = aankopen.OrderByDescending(ak => ak.Financieringsjaar ?? "").ToList();
            }
            else
            {
                SortFinancieringsjaar = true;
                aankopen = aankopen.OrderBy(ak => ak.Financieringsjaar ?? "").ToList();
            }
            ApplySortAndRefresh();
        }

        private void btnRichtperiode_Click(object sender, EventArgs e)
        {
            aankopen = GetFilteredAankopen();
            if (SortRichtperiode)
            {
                SortRichtperiode = false;
                aankopen = aankopen.OrderByDescending(ak => ak.Richtperiode ?? "").ToList();
            }
            else
            {
                SortRichtperiode = true;
                aankopen = aankopen.OrderBy(ak => ak.Richtperiode ?? "").ToList();
            }
            ApplySortAndRefresh();
        }

        private void btnSortGoedgekeurdbedrag_Click(object sender, EventArgs e)
        {
            aankopen = GetFilteredAankopen();
            if (SortGoedgekeurdBedrag)
            {
                SortGoedgekeurdBedrag = false;
                aankopen = aankopen.OrderByDescending(ak => ak.GoedgekeurdBedrag).ToList();
            }
            else
            {
                SortGoedgekeurdBedrag = true;
                aankopen = aankopen.OrderBy(ak => ak.GoedgekeurdBedrag).ToList();
            }
            ApplySortAndRefresh();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            aankopen = GetFilteredAankopen();
            if (SortSaldo)
            {
                SortSaldo = false;
                aankopen = aankopen.OrderByDescending(ak => ak.Saldo).ToList();
            }
            else
            {
                SortSaldo = true;
                aankopen = aankopen.OrderBy(ak => ak.Saldo).ToList();
            }
            ApplySortAndRefresh();
        }

        private void btnSortAanvrager_Click(object sender, EventArgs e)
        {
            aankopen = GetFilteredAankopen();
            if (SortAanvrager)
            {
                SortAanvrager = false;
                aankopen = aankopen.OrderByDescending(ak => ak.Aanvrager).ToList();
            }
            else
            {
                SortAanvrager = true;
                aankopen = aankopen.OrderBy(ak => ak.Aanvrager).ToList();
            }
            ApplySortAndRefresh();
        }

  
    }
}
