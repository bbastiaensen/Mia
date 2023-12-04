using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class FrmAanvragen : Form
    {
        public FrmAanvragen()
        {
            InitializeComponent();
            BindAanvraag();
        }

        private void btnNieuweAanvraag_Click(object sender, EventArgs e)
        {
            //if (mdiMia. == null)
            //{
            //    frmAanvraagFormulier = new frmAanvraagFormulier();
            //    frmAanvraagFormulier.MdiParent = this;
            //}
            //frmAanvraagFormulier.Show();
        }
        private void BindAanvraag()
        {
            AanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;

            cmbGebruiker.ValueMember = "Gebruiker";
            cmbGebruiker.DisplayMember = "Gebruiker";
            cmbGebruiker.DataSource = AanvraagManager.GetAanvraag();
            //cmbTitel.DisplayMember = "Titel";
            //cmbTitel.DataSource = AanvraagManager.GetAanvraag();
            //cmbFinancieringsjaar.DisplayMember = "Financieringsjaar";
            //cmbFinancieringsjaar.DataSource = AanvraagManager.GetAanvraag();
            //cmbxStatusAanvraag.DisplayMember = "StatusAanvraag";
            //cmbxStatusAanvraag.DataSource = AanvraagManager.GetAanvraag();
            //cmbKostenplaats.DisplayMember = "Kostenplaats";
            //cmbKostenplaats.DataSource = AanvraagManager.GetAanvraag();
            //cmbBedrag.DisplayMember = "Bedrag";
            //cmbBedrag.DataSource = AanvraagManager.GetAanvraag();
            //cmbPlanningsdatum.DisplayMember = "Planningsdatum";
            //cmbPlanningsdatum.DataSource = AanvraagManager.GetAanvraag();
        }
        private void cmbGebruiker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
