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
        public Boolean Even { get; set; }


        public event EventHandler GoedkeurDeleted;
        public event EventHandler GoedkeurItemSelected;
        public event EventHandler GoedkeurItemChanged;
        frmAanvraagFormulier frmAanvraagFormulier;


        static public bool edit = false;

        public string projectDirectory = Directory.GetCurrentDirectory();

        public GoedkeurItem()
        {
            InitializeComponent();
        }
        public GoedkeurItem(int id, string aanvrager, DateTime aanvraagmoment, string titel, string financieringsjaar, decimal PrijsIndicatiePerStuk, int AantalStuk, string Statusaanvraag, Boolean even)
        {
            InitializeComponent();
            Id = id;
            StatusAanvraag = Statusaanvraag;
            Aanvrager = aanvrager;
            Titel = titel;
            Aanvraagmoment = aanvraagmoment;
            Financieringsjaar = financieringsjaar;

            Even = even;
            SetGoedkeurItemWaarden();
        }
        private void SetGoedkeurItemWaarden()
        {
            lblTitel.Text = Titel;
            lblBedrag.Text = Bedrag.ToString("c", CultureInfo.CurrentCulture);
            lblFinancieringsjaar.Text = Financieringsjaar.ToString();
            LblAanvrager.Text = Aanvrager;
            lblAanvraagmoment.Text = Aanvraagmoment.ToString();
            if (Even)
            {
                this.BackColor = Color.White;
            }

            else
            {

                this.BackColor = StyleParameters.AccentKleur;
                this.ForeColor = StyleParameters.Buttontext;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (frmAanvraagFormulier == null)
            {
                frmAanvraagFormulier = new frmAanvraagFormulier(Id, "edit");
            }

            edit = true;
            frmAanvraagFormulier.MdiParent = this.ParentForm.MdiParent;
            //frmAanvraagFormulier.UpdateAanvraag();
            frmAanvraagFormulier.AanvraagBewaard += GoedkeurFormulieredit_AanvraagBewaard;
            frmAanvraagFormulier.Show();

        }


        private void GoedkeurFormulieredit_AanvraagBewaard(object sender, EventArgs e)
        {
            if (GoedkeurItemChanged != null)
            {
                GoedkeurItemChanged(this, null);
            }
        }

        private void btnStatusEdit_Click(object sender, EventArgs e)
        {

        }
    }

}
