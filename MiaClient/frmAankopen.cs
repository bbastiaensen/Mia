using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using Microsoft.Office.Interop.Excel;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
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

        // Filters
        bool filterBedragVan = false;
        bool filterBedragTot = false;
        bool filterTitel = false;
        bool filterGebruiker = false;
        bool filterPlanningsdatumVan = false;
        bool filterPlanningsdatumTot = false;

        // Sort
        bool SortTitel = true;
        bool SortTtlBedr = true;
        bool SortAanv = true;
        bool SortRP = true;
        bool SortJaar = false;

        int aantalItems = 10;
        int huidigePage = 1;
        int aantalPages = 0;

        List<Aanvraag> aanvragen;

        // Images
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
        Image imgNieuweAankoop = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "nieuweAankoop.png"));

        public frmAankopen()
        {
            InitializeComponent();
        }

        private void frmAankopen_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;

            try
            {
                huidigePage = 1;
                aanvragen = GetFilteredEnSortedAanvragen();
                StartPaging();

                // Fill financieringsjaren
                List<string> jaren = FinancieringsjaarManager.GetFinancieringsjaren();
                foreach (string jaar in jaren)
                    cmbFinancieringsjaar.Items.Add(jaar);

                cmbFinancieringsjaar.SelectedItem = DateTime.Now.Year.ToString();

                // Buttons images
                btnFilter.BackgroundImage = imgFilter;
                btnFilter.BackgroundImageLayout = ImageLayout.Stretch;
                btnFilter.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

                btnNieuweAankoop.BackgroundImage = imgNieuweAankoop;
                btnNieuweAankoop.BackgroundImageLayout = ImageLayout.Stretch;
                btnNieuweAankoop.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void frmAankopen_Shown(object sender, EventArgs e)
        {
            try
            {
                aanvragen = GetFilteredEnSortedAanvragen();
                StartPaging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAankopen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #region Nieuwe aankoop
        private void btnNieuweAankoop_Click(object sender, EventArgs e)
        {
            if (frmNieuweAankoop == null || frmNieuweAankoop.IsDisposed)
            {
                frmNieuweAankoop = new frmNieuweAankoop();
                frmNieuweAankoop.MdiParent = MdiParent;
                frmNieuweAankoop.AankoopToegevoegd += frmNieuweAankoop_AankoopToegevoegd;
            }

            frmNieuweAankoop.RefreshBekrachtigdeAanvragen();
            frmNieuweAankoop.Show();
            frmNieuweAankoop.BringToFront();
        }

        private void frmNieuweAankoop_AankoopToegevoegd(object sender, EventArgs e)
        {
            aanvragen = GetFilteredEnSortedAanvragen();
            huidigePage = 1;
            StartPaging();
        }
        #endregion

        #region Filters & Sort
        private void btnFilter_Click(object sender, EventArgs e)
        {
            filterBedragVan = cbBedragVan.Checked;
            filterBedragTot = cbBedragTot.Checked;
            filterTitel = !string.IsNullOrEmpty(txtTitel.Text);
            filterGebruiker = !string.IsNullOrEmpty(txtGebruiker.Text);
            filterPlanningsdatumVan = chbxPlaningsdatumVan.Checked;
            filterPlanningsdatumTot = chbxPlaningsdatumTot.Checked;

            huidigePage = 1;
            aanvragen = GetFilteredEnSortedAanvragen();
            StartPaging();
        }

        private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortJaar = true;
            huidigePage = 1;
            aanvragen = GetFilteredEnSortedAanvragen();
            StartPaging();
        }

        private void btnSortTitel_Click(object sender, EventArgs e)
        {
            SortTitel = !SortTitel;
            huidigePage = 1;
            aanvragen = GetFilteredEnSortedAanvragen();
            StartPaging();
        }

        private void btnBedrag_Click(object sender, EventArgs e)
        {
            SortTtlBedr = !SortTtlBedr;
            huidigePage = 1;
            aanvragen = GetFilteredEnSortedAanvragen();
            StartPaging();
        }

        private void btnSortAanvrager_Click(object sender, EventArgs e)
        {
            SortAanv = !SortAanv;
            huidigePage = 1;
            aanvragen = GetFilteredEnSortedAanvragen();
            StartPaging();
        }

        private void btnSortRichtperiode_Click(object sender, EventArgs e)
        {
            SortRP = !SortRP;
            huidigePage = 1;
            aanvragen = GetFilteredEnSortedAanvragen();
            StartPaging();
        }
        #endregion

        #region Paging
        private void btnFirst_Click(object sender, EventArgs e)
        {
            huidigePage = 1;
            StartPaging();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (huidigePage > 1) huidigePage--;
            StartPaging();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (huidigePage < aantalPages) huidigePage++;
            StartPaging();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            huidigePage = aantalPages;
            StartPaging();
        }

        private void StartPaging()
        {
            if (aanvragen == null) aanvragen = new List<Aanvraag>();

            if (aanvragen.Count > aantalItems)
            {
                aantalPages = (aanvragen.Count / aantalItems);
                if (aanvragen.Count % aantalItems != 0) aantalPages++;

                BindAanvraag(aanvragen.Skip((huidigePage - 1) * aantalItems).Take(aantalItems).ToList());
            }
            else
            {
                aantalPages = 1;
                BindAanvraag(aanvragen);
            }

            ShowPages();
            EnableFirstPrevious(huidigePage > 1);
            EnableLastNext(huidigePage < aantalPages);
        }

        private void ShowPages()
        {
            lblPages.Text = $"{huidigePage} van {aantalPages}";
        }

        private void EnableFirstPrevious(bool enable)
        {
            btnFirst.Enabled = enable;
            btnPrevious.Enabled = enable;
            btnFirst.BackgroundImage = enable ? imgFirst : imgFirstDisable;
            btnPrevious.BackgroundImage = enable ? imgPrevious : imgPreviousDisable;
        }

        private void EnableLastNext(bool enable)
        {
            btnLast.Enabled = enable;
            btnNext.Enabled = enable;
            btnLast.BackgroundImage = enable ? imgLast : imgLastDisable;
            btnNext.BackgroundImage = enable ? imgNext : imgNextDisable;
        }
        #endregion

        #region Bind items
        public void BindAanvraag(List<Aanvraag> items)
        {
            pnlAanvragen.Controls.Clear();
            if (items == null) return;

            int yPos = 0;
            int n = 0;
            foreach (var av in items)
            {
                AankopenItem avi = new AankopenItem(
                    av.Id,
                    av.Titel,
                    av.Gebruiker,
                    av.Financieringsjaar,
                    av.PrijsIndicatieStuk,
                    av.AantalStuk,
                    n % 2 == 0,
                    av.RichtperiodeId
                );

                avi.Location = new System.Drawing.Point(0, yPos);
                avi.Size = new Size(1210, 20);
                avi.AanvraagItemSelected += Gli_AanvraagItemSelected;
                avi.AanvraagDeleted += Avi_AanvraagItemChanged;
                avi.AanvraagItemChanged += Avi_AanvraagItemChanged;

                pnlAanvragen.Controls.Add(avi);
                yPos += 21;
                n++;
            }
        }

        private void Gli_AanvraagItemSelected(object sender, EventArgs e) { }
        private void Avi_AanvraagItemChanged(object sender, EventArgs e)
        {
            aanvragen = GetFilteredEnSortedAanvragen();
            StartPaging();
        }
        #endregion

        #region Filter & Sort Logica
        private List<Aanvraag> GetFilteredEnSortedAanvragen()
        {
            var items = AanvraagManager.Aanvraag_sort_sorteertvologorde_asc();

            if (filterPlanningsdatumVan && chbxPlaningsdatumVan.Checked)
                items = items.Where(av => av.Planningsdatum >= dtpPlanningsdatumVan.Value).ToList();

            if (filterPlanningsdatumTot && chbxPlaningsdatumTot.Checked)
                items = items.Where(av => av.Planningsdatum <= dtpPlanningsdatumTot.Value.AddDays(1).AddSeconds(-1)).ToList();

            if (filterGebruiker && !string.IsNullOrEmpty(txtGebruiker.Text))
                items = items.Where(av => av.Gebruiker.ToLower().Contains(txtGebruiker.Text.ToLower())).ToList();

            if (filterTitel && !string.IsNullOrEmpty(txtTitel.Text))
                items = items.Where(av => av.Titel.ToLower().Contains(txtTitel.Text.ToLower())).ToList();

            if (filterBedragVan && cbBedragVan.Checked && decimal.TryParse(txtBedragVan.Text, out decimal bedragVan))
                items = items.Where(av => (av.PrijsIndicatieStuk * av.AantalStuk) >= bedragVan).ToList();

            if (filterBedragTot && cbBedragTot.Checked && decimal.TryParse(txtBedragTot.Text, out decimal bedragTot))
                items = items.Where(av => (av.PrijsIndicatieStuk * av.AantalStuk) <= bedragTot).ToList();

            if (cmbFinancieringsjaar.SelectedIndex > -1)
                items = items.Where(av => av.Financieringsjaar.ToString() == cmbFinancieringsjaar.SelectedItem.ToString()).ToList();

            // Sort
            if (!SortTitel) items = items.OrderByDescending(av => av.Titel).ToList();
            if (!SortTtlBedr) items = items.OrderByDescending(av => av.PrijsIndicatieStuk * av.AantalStuk).ToList();
            if (!SortAanv) items = items.OrderByDescending(av => av.Gebruiker).ToList();
            if (!SortRP) items = items.OrderByDescending(av => av.RichtperiodeId).ToList();

            return items;
        }

        // Hover / Leave events
        private void btnFirst_MouseHover(object sender, EventArgs e) { btnFirst.BackgroundImage = imgFirstHover; }
        private void btnFirst_MouseLeave(object sender, EventArgs e) { btnFirst.BackgroundImage = huidigePage == 1 ? imgFirstDisable : imgFirst; }

        private void btnPrevious_MouseHover(object sender, EventArgs e) { btnPrevious.BackgroundImage = imgPreviousHover; }
        private void btnPrevious_MouseLeave(object sender, EventArgs e) { btnPrevious.BackgroundImage = huidigePage == 1 ? imgPreviousDisable : imgPrevious; }

        private void btnNext_MouseHover(object sender, EventArgs e) { btnNext.BackgroundImage = imgNextHover; }
        private void btnNext_MouseLeave(object sender, EventArgs e) { btnNext.BackgroundImage = huidigePage == aantalPages ? imgNextDisable : imgNext; }

        private void btnLast_MouseHover(object sender, EventArgs e) { btnLast.BackgroundImage = imgLastHover; }
        private void btnLast_MouseLeave(object sender, EventArgs e) { btnLast.BackgroundImage = huidigePage == aantalPages ? imgLastDisable : imgLast; }

        private void pnlAanvragen_Paint(object sender, PaintEventArgs e) { }
        #endregion
    }
}
