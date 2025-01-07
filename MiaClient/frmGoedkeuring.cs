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
        List<Goedkeuring> aanvragen;

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


        public frmGoedkeuring()
        {
            InitializeComponent();
        }

        public void BindAanvraag(List<Goedkeuring> items)
        {
            this.pnlGoedkeuringen.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            if (items != null)
            {
                foreach (var ag in items)
                {
                    GoedkeurItem agi = new GoedkeurItem(ag.Id, ag.Gebruiker, ag.Aanvraagmoment, ag.Titel, ag.Financieringsjaar, ag.PrijsIndicatieStuk, ag.AantalStuk, ag.Statusaanvraag, t % 2 == 0);
                    agi.Location = new System.Drawing.Point(xPos, yPos);
                    agi.Name = "aanvraagSelection" + t;
                    agi.Size = new System.Drawing.Size(1210, 33);
                    agi.TabIndex = t + 8;
                    agi.GoedkeurItemSelected += Gli_GoedkeurItemSelected;
                    this.pnlGoedkeuringen.Controls.Add(agi);

                    t++;
                    yPos += 30;
                }
            }
        }

        private void frmGoedkeuring_Load(object sender, EventArgs e)
        {

        }

        private void frmGoedkeuring_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        public void frmGoedkeuring_Activated(object sender, EventArgs e)
        {
            var lijst = GoedkeuringManager.GetGoedkeuringen();
            BindAanvraag(lijst);
        }

        private void Gli_GoedkeurItemSelected(object sender, EventArgs e)
        {
            GoedkeurItem geselecteerd = (GoedkeurItem)sender;
        }

        private void FrmAanvragen_Shown(object sender, EventArgs e)
        {
            try
            {
                aanvragen = GoedkeuringManager.GetGoedkeuringen();
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

        }

        private void btnLast_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnPrevious_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnFirst_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnFirst_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {

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
    }
}
