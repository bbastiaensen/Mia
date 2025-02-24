using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class GoedkeurItem : UserControl
    {
        public int Id { get; set; }
        public string Aanvrager { get; set; }
        public DateTime Aanvraagmoment { get; set; }
        public int AanvraagStatusId { get; set; }
        public string Titel { get; set; }
        public string Financieringsjaar { get; set; }
        public string StatusAanvraag { get; set; }
        public decimal PrijsIndicatieStuk { get; set; }
        public int AantalStuk { get; set; }
        public decimal Bedrag { get; set; }
        public string OpmerkingenResultaat { get; set; }
        public decimal BudgetToegekend { get; set; }
        public Boolean Even { get; set; }


        public event EventHandler GoedkeurDeleted;
        public event EventHandler GoedkeurItemSelected;
        public event EventHandler GoedkeurItemChanged;
        public event EventHandler GoedkeurItemStatusAanvraagChanged;

        frmAanvraagFormulier frmAanvraagFormulier;
        frmGoedkeuring frmGoedkeuring;
        frmStatusAanvraagWijzigingDetail frmSAWD = null;

        public string projectDirectory = Directory.GetCurrentDirectory();
        Image imgInAanvraagNeutral = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-form-80.png"));
        Image imgInAanvraagGreen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-form-80-green.png"));
        Image imgNietGoedgekeurdNeutral = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-niet-goedgekeurd-50-neutral.png"));
        Image imgNietGoedgekeurd = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-niet-goedgekeurd-50.png"));
        Image imgGoedgekeurdNeutral = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-goedgekeurd-50-neutral.png"));
        Image imgGoedgekeurd = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-goedgekeurd-50.png"));
        Image imgNietBekrachtigdNeutral = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-niet-bekrachtigd-50-neutral.png"));
        Image imgNietBekrachtigd = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-niet-bekrachtigd-50.png"));
        Image imgBekrachtigdNeutral = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-bekrachtigd-50-neutral.png"));
        Image imgBekrachtigd = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-bekrachtigd-50.png"));


        public GoedkeurItem()
        {
            InitializeComponent();
        }
        public GoedkeurItem(int id, string aanvrager, DateTime aanvraagmoment, string titel, string financieringsjaar, decimal PrijsIndicatiePerStuk, int AantalStuk, string Statusaanvraag, string opmerkingenResultaat, decimal budgetToegekend, Boolean even)
        {
            InitializeComponent();
            
            Id = id;
            StatusAanvraag = Statusaanvraag;
            Aanvrager = aanvrager;
            Titel = titel;
            Aanvraagmoment = aanvraagmoment;
            Financieringsjaar = financieringsjaar;
            Bedrag = PrijsIndicatiePerStuk * AantalStuk;
            OpmerkingenResultaat = opmerkingenResultaat;
            BudgetToegekend = budgetToegekend;

            switch (StatusAanvraag.ToLower())
            {
                case "in aanvraag":
                    btnInAanvraag.BackgroundImage = imgInAanvraagGreen;
                    btnNietGoedgekeurd.BackgroundImage = imgNietGoedgekeurdNeutral;
                    btnGoedgekeurd.BackgroundImage = imgGoedgekeurdNeutral;
                    btnNietBekrachtigd.BackgroundImage = imgNietBekrachtigdNeutral;
                    btnBekrachtigd.BackgroundImage = imgBekrachtigdNeutral;
                    break;
                case "niet goedgekeurd":
                    btnInAanvraag.BackgroundImage = imgInAanvraagNeutral;
                    btnNietGoedgekeurd.BackgroundImage = imgNietGoedgekeurd;
                    btnGoedgekeurd.BackgroundImage = imgGoedgekeurdNeutral;
                    btnNietBekrachtigd.BackgroundImage = imgNietBekrachtigdNeutral;
                    btnBekrachtigd.BackgroundImage = imgBekrachtigdNeutral;
                    break;
                case "goedgekeurd":
                    btnInAanvraag.BackgroundImage = imgInAanvraagNeutral;
                    btnNietGoedgekeurd.BackgroundImage = imgNietGoedgekeurdNeutral;
                    btnGoedgekeurd.BackgroundImage = imgGoedgekeurd;
                    btnNietBekrachtigd.BackgroundImage = imgNietBekrachtigdNeutral;
                    btnBekrachtigd.BackgroundImage = imgBekrachtigdNeutral;
                    break;
                case "niet bekrachtigd":
                    btnInAanvraag.BackgroundImage = imgInAanvraagNeutral;
                    btnNietGoedgekeurd.BackgroundImage = imgNietGoedgekeurdNeutral;
                    btnGoedgekeurd.BackgroundImage = imgGoedgekeurdNeutral;
                    btnNietBekrachtigd.BackgroundImage = imgNietBekrachtigd;
                    btnBekrachtigd.BackgroundImage = imgBekrachtigdNeutral;
                    break;
                case "bekrachtigd":
                    btnInAanvraag.BackgroundImage = imgInAanvraagNeutral;
                    btnNietGoedgekeurd.BackgroundImage = imgNietGoedgekeurdNeutral;
                    btnGoedgekeurd.BackgroundImage = imgGoedgekeurdNeutral;
                    btnNietBekrachtigd.BackgroundImage = imgNietBekrachtigdNeutral;
                    btnBekrachtigd.BackgroundImage = imgBekrachtigd;
                    break;
                default:
                    //Als de StatusAanvraag niet gekend is.
                    btnInAanvraag.BackgroundImage = imgInAanvraagNeutral;
                    btnNietGoedgekeurd.BackgroundImage = imgNietGoedgekeurdNeutral;
                    btnGoedgekeurd.BackgroundImage = imgGoedgekeurdNeutral;
                    btnNietBekrachtigd.BackgroundImage = imgNietBekrachtigdNeutral;
                    btnBekrachtigd.BackgroundImage = imgBekrachtigdNeutral;
                    break;
            }

            Even = even;
            SetGoedkeurItemWaarden();
        }
        private void SetGoedkeurItemWaarden()
        {
            if (Titel.Length > 25)
            {
                lblTitel.Text = Titel.Substring(0, 22) + "...";
            }
            else
            {
                lblTitel.Text = Titel;
            }
            lblBedrag.Text = Bedrag.ToString("c", CultureInfo.CurrentCulture);
            lblFinancieringsjaar.Text = Financieringsjaar.ToString();
            LblAanvrager.Text = Aanvrager;
            lblAanvraagmoment.Text = Aanvraagmoment.ToString();
            if (Even)
            {
                this.BackColor = StyleParameters.ListItemColor;
            }
            else
            {
                this.BackColor = StyleParameters.AltListItemColor;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (frmAanvraagFormulier == null)
            {
                frmAanvraagFormulier = new frmAanvraagFormulier(Id, "edit");
            }

            frmAanvraagFormulier.MdiParent = this.ParentForm.MdiParent;
            //frmAanvraagFormulier.UpdateAanvraag();
            frmAanvraagFormulier.AanvraagBewaard += GoedkeurFormulieredit_AanvraagBewaard;
            frmAanvraagFormulier.Show();

        }


        public void GoedkeurFormulieredit_AanvraagBewaard(object sender, EventArgs e)
        {
            if (GoedkeurItemChanged != null)
            {
                GoedkeurItemChanged(this, null);
            }
        }

        private void btnInAanvraag_Click(object sender, EventArgs e)
        {
            //Status 'In aanvraag' zetten
        }

        private void btnNietGoedgekeurd_Click(object sender, EventArgs e)
        {
            try
            {
                //Status 'Niet goedgekeurd' zetten
                if (StatusAanvraag.ToLower() == "in aanvraag")
                {
                    //Updaten van de Status
                    Aanvraag aanvraag = new Aanvraag()
                    {
                        Id = this.Id
                    };
                    StatusAanvraag nieuweStatusAanvraag = StatusAanvraagManager.GetStatusAanvraagByName("Niet goedgekeurd");
                    AanvraagManager.UpdateStatusAanvraag(aanvraag, nieuweStatusAanvraag);

                    //Updaten van de Status details van deze aanvraag
                    frmSAWD = new frmStatusAanvraagWijzigingDetail(Id, StatusAanvraag, OpmerkingenResultaat, BudgetToegekend);
                    frmSAWD.StatusAanvraagDetailGewijzigd += FrmSAWD_StatusAanvraagDetailGewijzigd;
                    frmSAWD.Show();
                }
                else
                {
                    MessageBox.Show("Een aanvraag die niet in de status 'In aanvraag' staat kan niet afgekeurd worden.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden - " + ex.Message, "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSAWD_StatusAanvraagDetailGewijzigd(object sender, EventArgs e)
        { 
            frmSAWD = null;
            if (GoedkeurItemStatusAanvraagChanged != null)
            {
                GoedkeurItemStatusAanvraagChanged(this, null);
            }
        }

        private void btnGoedgekeurd_Click(object sender, EventArgs e)
        {
            //Status 'Goedgekeurd' zetten
        }

        private void btnNietBekrachtigd_Click(object sender, EventArgs e)
        {
            //Status 'Niet bekrachtigd' zetten
        }

        private void btnBekrachtigd_Click(object sender, EventArgs e)
        {
            //Status 'Bekrachtigd' zetten
        }
    }
}
