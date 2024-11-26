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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmGoedkeuring : Form
    {


        bool filterAanvraagmomentVan = false;
        bool filterAanvraagmomentTot = false;
        bool filterGebruiker = false;
        bool filterTitel = false;
        bool filterFinancieringsjaar = false;
        bool filterBedragVan = false;
        bool filterBedragTot = false;


        bool SortGebruiker = true;
        bool SortTitel = true;
        bool SortAanvraagmoment = true;
        bool SortBedrag = true;
        bool SortPlanningsdatum = true;
        bool SortFinancieringsjaar = true;


        Image imgFilter = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "Filter.png"));
        public frmGoedkeuring()
        {
            InitializeComponent();
        }

        public void BindAanvraag(List<Aanvraag> items)
        {
            this.pnlGoedkeuringen.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            if (items != null)
            {
                foreach (var av in items)
                {
                    GoedkeurItem item = new GoedkeurItem(av.Id, av.Gebruiker, av.Aanvraagmoment, av.StatusAanvraagId, av.Titel, av.Financieringsjaar, av.Bedrag, t % 2 == 0);
                    item.Location = new System.Drawing.Point(xPos, yPos);
                    item.Name = "GoedkeurSelection" + t;
                    item.Size = new System.Drawing.Size(1034, 33);
                    item.TabIndex = t + 8;

                    this.pnlGoedkeuringen.Controls.Add(item);

                    t++;
                    yPos += 30;
                }
            }
        }

        private void frmGoedkeuring_Load(object sender, EventArgs e)
        {
            btnFilter.BackgroundImage = imgFilter;
            btnFilter.BackgroundImageLayout = ImageLayout.Stretch;
            btnFilter.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

        }

        private void frmGoedkeuring_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void frmGoedkeuring_Activated(object sender, EventArgs e)
        {
            var lijst = AanvraagManager.GetAanvragen();
            BindAanvraag(lijst);
        }

       

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFinancieringsjaar.Text != string.Empty)
                {
                    filterFinancieringsjaar = true;
                }
                if (chbxBedragVan.Checked != false)
                {
                    filterBedragVan = true;
                }
                if (chbxBedragTot.Checked != false)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}
