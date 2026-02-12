    using MiaClient.UserControls;
    using MiaLogic.Manager;
    using MiaLogic.Object;
    using ProofOfConceptDesign;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    namespace MiaClient
    {
        public partial class frmNieuweAankoop : Form
        {
            private int aantalItems = 12;
            private int huidigePage = 1;
            private int aantalPages = 0;

            private List<Aanvraag> _bekrachtigdeAanvragenPaged;

            private List<Aanvraag> _bekrachtigdeAanvragen;

            public event EventHandler AankoopToegevoegd;

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


            public frmNieuweAankoop()
            {
                InitializeComponent();
            
                pnlAanvragen.HorizontalScroll.Enabled = false;
                pnlAanvragen.HorizontalScroll.Visible = false;

                pnlAanvragen.Resize += pnlAanvragen_Resize;
                MaximizeBox = false;                 
                FormBorderStyle = FormBorderStyle.FixedSingle;
            }

            private void frmNieuweAankoop_Load(object sender, EventArgs e)
            {
            CreateUI();
                btnFirst.BringToFront();
                btnPrevious.BringToFront();
                btnNext.BringToFront();
                btnLast.BringToFront();

                // Zet je iconen standaard
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

                // BELANGRIJK: nu pas laden
                LaadBekrachtigdeAanvragen();

                // En daarna de correcte enabled/disabled refresh
                RefreshPagingButtonImages();
            }

            private void UpdateButtonImage(Button btn, Image normal, Image hover, Image disabled, bool isHover)
            {
                if (!btn.Enabled)
                {
                    btn.BackgroundImage = disabled;
                }
                else if (isHover)
                {
                    btn.BackgroundImage = hover;
                }
                else
                {
                    btn.BackgroundImage = normal;
                }
            }

            public void LaadtAanvraag(Aanvraag aanvraag)
            {
                if (aanvraag == null) return;

                // ⬇️ VERVANG door jouw echte controls
                lblTitel.Text = aanvraag.Titel;
                lblAanvrager.Text = aanvraag.Gebruiker;
                lblFinancieringsjaar.Text = aanvraag.Financieringsjaar;
                lblRichtperiode.Text = aanvraag.RichtperiodeNaam;
                lblStatusAanvraag.Text = aanvraag.StatusAanvraag;
            }
            private void StartPaging()
            {
                if (_bekrachtigdeAanvragenPaged != null && _bekrachtigdeAanvragenPaged.Count > aantalItems)
                {
                    aantalPages = (_bekrachtigdeAanvragenPaged.Count / aantalItems);
                    if ((_bekrachtigdeAanvragenPaged.Count % aantalItems) != 0)
                    {
                        aantalPages++;
                    }

                    ShowPages();

                    if (huidigePage < aantalPages)
                    {
                        BindAanvragen(_bekrachtigdeAanvragenPaged
                            .Skip((huidigePage - 1) * aantalItems)
                            .Take(aantalItems)
                            .ToList());

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

                    if (_bekrachtigdeAanvragenPaged != null)
                    {
                        BindAanvragen(_bekrachtigdeAanvragenPaged);
                    }

                    EnableFirstPrevious(false);
                    EnableLastNext(false);
                }

                RefreshPagingButtonImages();
            }

            private void ShowPages()
            {
                lblPages.Text = huidigePage.ToString() + " van " + aantalPages.ToString();
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

            private void RefreshPagingButtonImages()
            {
                UpdateButtonImage(btnFirst, imgFirst, imgFirstHover, imgFirstDisable, isFirstHover);
                UpdateButtonImage(btnPrevious, imgPrevious, imgPreviousHover, imgPreviousDisable, isPreviousHover);
                UpdateButtonImage(btnNext, imgNext, imgNextHover, imgNextDisable, isNextHover);
                UpdateButtonImage(btnLast, imgLast, imgLastHover, imgLastDisable, isLastHover);
            }
            private void btnNext_Click(object sender, EventArgs e)
            {
                if (_bekrachtigdeAanvragenPaged == null) return;

                huidigePage++;
                ShowPages();

                if (huidigePage < aantalPages)
                {
                    BindAanvragen(_bekrachtigdeAanvragenPaged
                        .Skip((huidigePage - 1) * aantalItems)
                        .Take(aantalItems)
                        .ToList());

                    EnableLastNext(true);
                }
                else if (huidigePage == aantalPages)
                {
                    BindAanvragen(_bekrachtigdeAanvragenPaged
                        .Skip((huidigePage - 1) * aantalItems)
                        .ToList());

                    EnableLastNext(false);
                }

                EnableFirstPrevious(true);


                RefreshPagingButtonImages();
            }
            private void btnPrevious_Click(object sender, EventArgs e)
            {
                if (_bekrachtigdeAanvragenPaged == null) return;

                huidigePage--;
                ShowPages();

                if (huidigePage < aantalPages)
                {
                    BindAanvragen(_bekrachtigdeAanvragenPaged
                        .Skip((huidigePage - 1) * aantalItems)
                        .Take(aantalItems)
                        .ToList());
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
                if (_bekrachtigdeAanvragenPaged == null) return;

                huidigePage = 1;
                ShowPages();

                BindAanvragen(_bekrachtigdeAanvragenPaged
                    .Skip((huidigePage - 1) * aantalItems)
                    .Take(aantalItems)
                    .ToList());

                EnableFirstPrevious(false);

                if (huidigePage < aantalPages)
                {
                    EnableLastNext(true);
                }

                RefreshPagingButtonImages();
            }

            private void btnLast_Click(object sender, EventArgs e)
            {
                if (_bekrachtigdeAanvragenPaged == null) return;

                huidigePage = aantalPages;
                ShowPages();

                BindAanvragen(_bekrachtigdeAanvragenPaged
                    .Skip((huidigePage - 1) * aantalItems)
                    .ToList());

                EnableLastNext(false);

                if (huidigePage > 1)
                {
                    EnableFirstPrevious(true);
                }

                RefreshPagingButtonImages();
            }
            // Hover
            private bool isNextHover = false;
            private bool isPreviousHover = false;
            private bool isFirstHover = false;
            private bool isLastHover = false;



            private void btnNext_MouseHover(object sender, EventArgs e)
            {
                isNextHover = true;
                UpdateButtonImage(btnNext, imgNext, imgNextHover, imgNextDisable, true);
            }

            private void btnNext_MouseLeave(object sender, EventArgs e)
            {
                isNextHover = false;
                UpdateButtonImage(btnNext, imgNext, imgNextHover, imgNextDisable, false);
            }
            private void btnPrevious_MouseHover(object sender, EventArgs e) => UpdateButtonImage(btnPrevious, imgPrevious, imgPreviousHover, imgPreviousDisable, true);
            private void btnFirst_MouseHover(object sender, EventArgs e) => UpdateButtonImage(btnFirst, imgFirst, imgFirstHover, imgFirstDisable, true);
            private void btnLast_MouseHover(object sender, EventArgs e) => UpdateButtonImage(btnLast, imgLast, imgLastHover, imgLastDisable, true);

            // Leave
            private void btnPrevious_MouseLeave(object sender, EventArgs e) => UpdateButtonImage(btnPrevious, imgPrevious, imgPreviousHover, imgPreviousDisable, false);
            private void btnFirst_MouseLeave(object sender, EventArgs e) => UpdateButtonImage(btnFirst, imgFirst, imgFirstHover, imgFirstDisable, false);
            private void btnLast_MouseLeave(object sender, EventArgs e) => UpdateButtonImage(btnLast, imgLast, imgLastHover, imgLastDisable, false);



            public void RefreshBekrachtigdeAanvragen()
            {
                LaadBekrachtigdeAanvragen();
            }

            private void LaadBekrachtigdeAanvragen()
            {
                _bekrachtigdeAanvragenPaged =
                    AanvraagManager.GetBekrachtigdeAanvragenZonderAankoop();

                huidigePage = 1;
                StartPaging();
            }

            public void BindAanvragen(List<Aanvraag> items)
            {
                pnlAanvragen.SuspendLayout();
                pnlAanvragen.Controls.Clear();

                if (items == null) return;

                int yPos = 0;
                int rowHeight = 33;
                int n = 0;

                foreach (var aanvraag in items)
                {
                    var item = new NieuweAankoopItem(
                        aanvraag,
                        n % 2 == 0
                    );

                    item.Location = new Point(0, yPos);
                    item.Width = pnlAanvragen.ClientSize.Width;
                    item.Height = rowHeight;

                    item.EuroClicked += NieuweAankoopItem_EuroClicked;

                    pnlAanvragen.Controls.Add(item);

                    yPos += rowHeight;
                    n++;
                }

                pnlAanvragen.ResumeLayout();
            }
        
            private void pnlAanvragen_Resize(object sender, EventArgs e)
            {
                foreach (NieuweAankoopItem item in pnlAanvragen.Controls)
                {
                    item.Width = pnlAanvragen.ClientSize.Width;
                }
            }

            private void NieuweAankoopItem_EuroClicked(object sender, EventArgs e)
            {
                var item = (NieuweAankoopItem)sender;

                if (item.Aanvraag != null)
                {
                    VoegAanvraagToeAanAankopen(item.Aanvraag);
                }
            }

            private void VoegAanvraagToeAanAankopen(Aanvraag aanvraag)
            {
                try
                {
                    var aankoop = new Aankoop
                    {
                        Titel = aanvraag.Titel ?? "",
                        BTWPercentage = 21,
                        BedragExBtw = 0,
                        StatusAankoopId = 1,
                        LeverancierId = 1,
                        AanvraagId = aanvraag.Id
                    };

                    AankoopManager.CreateAankoop(aankoop);

                    LaadBekrachtigdeAanvragen();
                    AankoopToegevoegd?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Fout bij toevoegen aankoop",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            public void CreateUI()
            {
                this.BackColor = StyleParameters.Achtergrondkleur;
                StyleAllButtons(this);
            }
            private void StyleAllButtons(Control parent)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is Button btn)
                    {
                        // Skip icon buttons
                        if (btn.Tag != null && btn.Tag.ToString() == "icon")
                            continue;

                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        btn.BackColor = StyleParameters.ButtonBack;
                        btn.ForeColor = StyleParameters.Buttontext;
                    }

                    if (c.HasChildren)
                        StyleAllButtons(c);
                }
            }

            private void frmNieuweAankoop_FormClosing(object sender, FormClosingEventArgs e)
            {
                e.Cancel = true;
                Hide();
            }

        }
    }
