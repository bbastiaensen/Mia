using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class FrmGebruiksLog : Form
    {
        List<GebruiksLog> gebruiksLogs;

        bool filterVan = false;
        bool filterTot = false;
        bool filterGebruiker = false;
        bool filterOmschrijving = false;

        int aantalListItems = 10;
        int huidigePage = 1;
        int aantalPages = 0;

        Image imgLast = (Image) new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-last-50.png"));
        Image imgLastDisable = (Image) new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-last-50-grey.png"));
        Image imgLastHover = (Image) new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-last-50-hover.png"));
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

        public FrmGebruiksLog()
        {
            InitializeComponent();
        }

        private void BindGebruiksLogItems(List<GebruiksLog> items)
        {
            //Eventueel bestaande lijst verwijderen
            this.pnlGebruiksLogItems.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var gl in items)
            {
                GebruikslogItem gli = new GebruikslogItem(gl.Id, gl.TijdstipActie, gl.Gebruiker, gl.OmschrijvingActie, t % 2 == 0);
                gli.Location = new System.Drawing.Point(xPos, yPos);
                gli.Name = "gebruiksLogSelection" + t;
                gli.Size = new System.Drawing.Size(881, 33);
                gli.TabIndex = t + 8;
                gli.GebruiksLogItemSelected += Gli_GebruiksLogItemSelected;
                this.pnlGebruiksLogItems.Controls.Add(gli);

                //Voorbereiden voor de volgende control
                t++;
                yPos += 30;
            }
        }

        private void Gli_GebruiksLogItemSelected(object sender, EventArgs e)
        {
            GebruikslogItem geselecteerd = (GebruikslogItem)sender;

            txtIdDetail.Text = geselecteerd.Id.ToString();
            txtTijdstipActieDetail.Text = geselecteerd.TijdstipActie.ToString();
            txtGebruikerDetail.Text = geselecteerd.Gebruiker;
            txtOmschrijvingDetail.Text = geselecteerd.OmschrijvingActie.ToString();
        }

        private List<GebruiksLog> FilteredGebruiksLogItems(List<GebruiksLog> items, bool van, bool tot, bool gebruiker, bool omschrijving)
        {

            DateTime vanDate;
            DateTime totDate;

            // Filteren op "van" datum
            if (van && chkVan.Checked && DateTime.TryParse(dtpVan.Text, out vanDate))
            {
                items = items.Where(gl => gl.TijdstipActie >= vanDate).ToList();
            }

            // Filteren op "tot" datum
            if (tot && chkTot.Checked && DateTime.TryParse(dtpTot.Text, out totDate))
            {
                items = items.Where(gl => gl.TijdstipActie <= totDate.Add(new TimeSpan(23, 59, 59))).ToList();
            }

            // Filteren op gebruiker
            if (gebruiker && !string.IsNullOrWhiteSpace(txtGebruiker.Text))
            {
                string gebruikerText = txtGebruiker.Text.ToLower();
                items = items.Where(gl => gl.Gebruiker.ToLower().Contains(gebruikerText)).ToList();
            }

            // Filteren op omschrijving
            if (omschrijving && !string.IsNullOrWhiteSpace(txtOmschrijving.Text))
            {
                string omschrijvingText = txtOmschrijving.Text.ToLower();
                items = items.Where(gl => gl.OmschrijvingActie.ToLower().Contains(omschrijvingText)).ToList();
            }

            // Leegmaken van velden
            txtIdDetail.Text = string.Empty;
            txtGebruikerDetail.Text = string.Empty;
            txtTijdstipActieDetail.Text = string.Empty;
            txtOmschrijvingDetail.Text = string.Empty;

            return items;
        }

        private void frmGebruiksLogDemo_Load(object sender, EventArgs e)
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
            btnFilter.BackgroundImageLayout= ImageLayout.Stretch;
            btnFilter.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;
        }

        private void FrmGebruiksLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void pnlGebruiksLogItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                filterVan = chkVan.Checked && !string.IsNullOrWhiteSpace(dtpVan.Text);
                filterTot = chkTot.Checked && !string.IsNullOrWhiteSpace(dtpTot.Text);
                filterGebruiker = !string.IsNullOrWhiteSpace(txtGebruiker.Text);
                filterOmschrijving = !string.IsNullOrWhiteSpace(txtOmschrijving.Text);

                gebruiksLogs = FilteredGebruiksLogItems(GebruiksLogManager.GetGebruiksLogs(), filterVan, filterTot, filterGebruiker, filterOmschrijving);

                huidigePage = 1;
                StartPaging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartPaging()
        {
            if (gebruiksLogs.Count > aantalListItems)
            {
                // Paging is nodig
                aantalPages = (gebruiksLogs.Count / aantalListItems);
                if ((gebruiksLogs.Count % aantalListItems) != 0)
                {
                    aantalPages++;
                }

                ShowPages();

                EnableLastNext(huidigePage < aantalPages);

                if (huidigePage < aantalPages)
                {
                    BindGebruiksLogItems(gebruiksLogs.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                }
                if (huidigePage == 1)
                {
                    EnableFirstPrevious(false);
                }
            }
            else
            {
                BindGebruiksLogItems(gebruiksLogs);
                EnableFirstPrevious(false);
                EnableLastNext(false);
            }
        }

        private void FrmGebruiksLog_Shown(object sender, EventArgs e)
        {
            try
            {
                gebruiksLogs = GebruiksLogManager.GetGebruiksLogs();
                if (gebruiksLogs != null) 
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
                BindGebruiksLogItems(gebruiksLogs.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
            }
            else if(huidigePage == aantalPages) 
            {
                BindGebruiksLogItems(gebruiksLogs.Skip((huidigePage - 1) * aantalListItems).ToList());
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
                BindGebruiksLogItems(gebruiksLogs.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
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
            BindGebruiksLogItems(gebruiksLogs.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
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
            BindGebruiksLogItems(gebruiksLogs.Skip((huidigePage - 1) * aantalListItems).ToList());
            EnableLastNext(false);
            if (huidigePage > 1)
            {
                EnableFirstPrevious(true);
            }
        }

        private void ShowPages()
        {
            lblPages.Text = huidigePage.ToString() + " van " + aantalPages.ToString();
        }
    }
}
