using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmGoedkeuring : Form
    {
        frmAanvraagFormulier frmAanvraagFormulier;
        List<Aanvraag> aanvragen;
        public event EventHandler AanvraagBewaard;

        public string projectDirectory = Directory.GetCurrentDirectory();
        int statusId = 0;

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

        bool inaanvraag = true;
        bool goedkeur = true;
        bool afkeur = true;
        bool bekrachtig = true;
        bool nietbekrachtig = true;

        int aantalListItems = 10;
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


        public frmGoedkeuring()
        {
            InitializeComponent();
        }


        public void BindGoedkeuringen(List<Aanvraag> items)
        {
            this.pnlGoedkeuringen.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            if (items != null)
            {
                foreach (var ag in items)
                {
                    GoedkeurItem agi = new GoedkeurItem(ag.Id, ag.Gebruiker, ag.Aanvraagmoment, ag.Titel, ag.Financieringsjaar, ag.PrijsIndicatieStuk, ag.AantalStuk, Convert.ToString(ag.StatusAanvraagId), t % 2 == 0);
                    agi.Location = new System.Drawing.Point(xPos, yPos);
                    agi.Name = "aanvraagSelection" + t;
                    agi.Size = new System.Drawing.Size(1210, 33);
                    agi.TabIndex = t + 8;
                    agi.GoedkeurItemSelected += Gli_GoedkeurItemSelected;
                    agi.GoedkeurItemChanged += Agi_GoedkeurItemChanged;
                    this.pnlGoedkeuringen.Controls.Add(agi);

                    statusId = ag.StatusAanvraagId;

                    t++;
                    yPos += 30;


                    string imagePath = "";
                    if (GoedkeurItem.edit == false)
                    {
                        grbxFilterAanvraag.Enabled = false;

                        btnSave.Visible = true;
                        btnSave.Enabled = true;
                        pcbAfgekeurd.Enabled = true;
                        pcbBekrachtigd.Enabled = true;
                        pcbGoedgekeurd.Enabled = true;
                        pcbNietBekrachtigd.Enabled = true;

                        if (ag.StatusAanvraagId == 1)
                        {
                            string imageDrop = Path.Combine(projectDirectory, "icons", "aanvraagGroot.png");
                            pcbInAanvraag.Image = Image.FromFile(imagePath);
                        }

                        if (ag.StatusAanvraagId == 2)
                        {
                            string imageDrop = Path.Combine(projectDirectory, "icons", "goedgekeurdGroot_aan.png");
                            pcbGoedgekeurd.Image = Image.FromFile(imagePath);
                        }

                        if (ag.StatusAanvraagId == 3)
                        {
                            string imageDrop = Path.Combine(projectDirectory, "icons", "AfgekeurdGroot_aan.png");
                            pcbAfgekeurd.Image = Image.FromFile(imagePath);
                        }

                        if (ag.StatusAanvraagId == 4)
                        {
                            string imageDrop = Path.Combine(projectDirectory, "icons", "bekrachtigdGroot_aan.png");
                            pcbBekrachtigd.Image = Image.FromFile(imagePath);
                        }

                        if (ag.StatusAanvraagId == 5)
                        {
                            string imageDrop = Path.Combine(projectDirectory, "icons", "NietBekrachtigdGroot_aan.png");
                            pcbNietBekrachtigd.Image = Image.FromFile(imagePath);
                        }
                        GoedkeurItem.edit = false;
                    }
                }
            }
        }

        public void frmGoedkeuring_Load(object sender, EventArgs e)
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

            pcbAfgekeurd.Enabled = false;
            pcbBekrachtigd.Enabled = false;
            pcbGoedgekeurd.Enabled = false;
            pcbNietBekrachtigd.Enabled = false;
            btnSave.Enabled = false;            
        }
        private void Agi_GoedkeurItemChanged(object sender, EventArgs e)
        {
            try
            {
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetGoedgekeurdeAanvragen(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);

                huidigePage = 1;
                StartPaging();
                ShowPages();
                if (huidigePage < aantalPages)
                {
                    BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                    EnableLastNext(true);
                }
                else if (huidigePage == aantalPages)
                {
                    BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
                    EnableLastNext(false);
                }
                EnableFirstPrevious(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmGoedkeuring_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }
        public void frmGoedkeuring_Activated(object sender, EventArgs e)
        {
            var lijst = AanvraagManager.GetGoedgekeurdeAanvragen();
            BindGoedkeuringen(lijst);
        }
        private void Gli_GoedkeurItemSelected(object sender, EventArgs e)
        {
            GoedkeurItem geselecteerd = (GoedkeurItem)sender;
        }
        private void FrmGoedkeuring_Shown(object sender, EventArgs e)
        {
            try
            {
                aanvragen = AanvraagManager.GetGoedgekeurdeAanvragen();
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
        private List<Aanvraag> FilteredGoedkeurItems(List<Aanvraag> items, bool aanvraagmomentVan, bool aanvraagmomentTot, bool planningsdatumVan, bool planningsdatumTot, bool gebruiker, bool titel, bool statusAanvraag, bool financieringsjaar, bool bedragVan, bool bedragTot, bool kostenPlaats)
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

                if (gebruiker)
                {
                    items = items.Where(av => av.Gebruiker.ToLower().Contains(txtGebruiker.Text.ToLower())).ToList();
                }

                if (titel)
                {
                    items = items.Where(av => av.Titel.ToLower().Contains(txtTitel.Text.ToLower())).ToList();
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
                    if (cbBedragVan.Checked == true )
                    {
                        if (txtBedragVan.Text != string.Empty)
                        {
                            items = items.Where(av => av.BudgetToegekend >= Convert.ToDecimal(txtBedragVan.Text)).ToList();
                        }
                    } 
                }
                if (bedragTot)
                {
                    if (cbBedragTot.Checked == true)
                    {
                        if(txtBedragTot.Text != string.Empty)
                        {
                            items = items.Where(av => av.BudgetToegekend <= Convert.ToDecimal(txtBedragTot.Text)).ToList();
                        }
                    }
                }
            }
           return items;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFinancieringsjaar.Text != string.Empty)
                {
                    filterFinancieringsjaar = true;
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

                if (txtGebruiker.Text != string.Empty)
                {
                    filterGebruiker = true;
                }

                if (chbxAanvraagmomentVan.Checked != false)
                {
                    filterAanvraagmomentVan = true;
                }
                if (chbxAanvraagmomentTot.Checked != false)
                {
                    filterAanvraagmomentTot = true;
                }

                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetAanvragen(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);

                huidigePage = 1;
                StartPaging();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pcbInAanvraag_Click(object sender, EventArgs e)
        {
            if (inaanvraag == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "aanvraagGroot.png");
                pcbInAanvraag.Image = Image.FromFile(imagePath); 

                inaanvraag = true;
            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Aanvraag_UitGroot.png");
                pcbInAanvraag.Image = Image.FromFile(imagePath);

                inaanvraag = false;
            }

            pcbGoedgekeurd.Enabled = true;
            pcbNietBekrachtigd.Enabled = true;
            pcbAfgekeurd.Enabled = true;
            pcbBekrachtigd.Enabled = true;
        }

        private void pcbGoedgekeurd_Click(object sender, EventArgs e)
        {
            if (goedkeur == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "goedgekeurdGroot_aan.png");
                pcbGoedgekeurd.Image = Image.FromFile(imagePath);

                string imageDrop = Path.Combine(projectDirectory, "icons", "Aanvraag_uitGroot.png");
                pcbInAanvraag.Image = Image.FromFile(imageDrop);

                goedkeur = true;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = false;
                pcbBekrachtigd.Enabled = true;
            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "goedgekeurd_uitGroot.png");
                pcbGoedgekeurd.Image = Image.FromFile(imagePath);

                goedkeur = false;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = true;
                pcbBekrachtigd.Enabled = true;
            }
        }

        private void pcbAfgekeurd_Click(object sender, EventArgs e)
        {
            if (afkeur == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "AfgekeurdGroot_aan.png");
                pcbAfgekeurd.Image = Image.FromFile(imagePath);

                string imageDrop = Path.Combine(projectDirectory, "icons", "Aanvraag_uitGroot.png");
                pcbInAanvraag.Image = Image.FromFile(imageDrop);

                afkeur = true;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = false;
                pcbAfgekeurd.Enabled = true;
                pcbBekrachtigd.Enabled = false;
            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_uitGroot.png");
                pcbAfgekeurd.Image = Image.FromFile(imagePath);

                afkeur = false;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = true;
                pcbBekrachtigd.Enabled = true;
            }
        }

        private void pcbBekrachtigd_Click(object sender, EventArgs e)
        {
            if (bekrachtig == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "bekrachtigdGroot_aan.png");
                pcbBekrachtigd.Image = Image.FromFile(imagePath);

                string imageDrop = Path.Combine(projectDirectory, "icons", "Aanvraag_uitGroot.png");
                pcbInAanvraag.Image = Image.FromFile(imageDrop);

                bekrachtig = true;

                pcbGoedgekeurd.Enabled = false;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = false;
                pcbBekrachtigd.Enabled = true;
            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "bekrachtigd_uitGroot.png");
                pcbBekrachtigd.Image = Image.FromFile(imagePath);

                bekrachtig = false;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = true;
                pcbBekrachtigd.Enabled = true;
            }
        }

        private void pcbNietBekrachtigd_Click(object sender, EventArgs e)
        {
            if (nietbekrachtig == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "NietBekrachtigdGroot_aan.png");
                pcbNietBekrachtigd.Image = Image.FromFile(imagePath);

                string imageDrop = Path.Combine(projectDirectory, "icons", "Aanvraag_uitGroot.png");
                pcbInAanvraag.Image = Image.FromFile(imageDrop);

                nietbekrachtig = true;

                pcbGoedgekeurd.Enabled = false;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = false;
                pcbBekrachtigd.Enabled = false;
            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uitGroot.png");
                pcbNietBekrachtigd.Image = Image.FromFile(imagePath);

                nietbekrachtig = false;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = true;
                pcbBekrachtigd.Enabled = true;
            }
        }
        private void btnSortGebruiker_Click(object sender, EventArgs e)
        {
            if (SortGebruiker == true)
            {
                SortGebruiker = false;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetGebruikerDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortGebruiker = true;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetGebruikerAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }
        private void btnSortTitel_Click(object sender, EventArgs e)
        {
            if (SortTitel == true)
            {
                SortTitel = false;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetTitelDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);

            }
            else
            {
                SortTitel = true;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetTitelAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }
        private void btnSortAanvraagmoment_Click(object sender, EventArgs e)
        {
            if (SortAanvraagmoment == true)
            {
                SortAanvraagmoment = false;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetAanvraagmomentDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortAanvraagmoment = true;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetAanvraagmomentAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }
        private void btnSortFinancieringsjaar_Click(object sender, EventArgs e)
        {
            if (SortFinancieringsjaar == true)
            {
                SortFinancieringsjaar = false;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetFinancieringsjaarDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortFinancieringsjaar = true;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetFinancieringsjaarAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
        }
        private void btnSortBedrag_Click(object sender, EventArgs e)
        {
            if (SortBedrag == true)
            {
                SortBedrag = false;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetBedragDesc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }
            else
            {
                SortBedrag = true;
                aanvragen = FilteredGoedkeurItems(AanvraagManager.GetBedragAsc(), filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats);
            }

            huidigePage = 1;
            StartPaging();
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                EnableLastNext(true);
            }
            else if (huidigePage == aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(false);
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
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
            }
            else if (huidigePage == aantalPages)
            {
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
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
                BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
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
            BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
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
            BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).ToList());
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
                    BindGoedkeuringen(aanvragen.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
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
                BindGoedkeuringen(aanvragen);
                EnableFirstPrevious(false);
                EnableLastNext(false);
            }
        }
        private void ShowPages()
        {
            lblPages.Text = huidigePage.ToString() + " van " + aantalPages.ToString();
        }
    }
}
