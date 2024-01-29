using MiaClient.UserControls;
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
        frmAanvraagFormulier frmAanvraagFormulier;

        public FrmAanvragen()
        {
            InitializeComponent();
            
            AanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
        }

        private void btnNieuweAanvraag_Click(object sender, EventArgs e)
        {
            if (frmAanvraagFormulier == null)
            {
                frmAanvraagFormulier = new frmAanvraagFormulier();
                frmAanvraagFormulier.MdiParent = MdiParent;
            }
            frmAanvraagFormulier.Show();
        }
        private void BindAanvraag(List<Aanvraag> items)
        {
            this.pnlAanvragen.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var av in items)
            {

                AanvraagItem avi = new AanvraagItem(av.Gebruiker, av.Aanvraagmoment, av.Titel, av.Financieringsjaar, av.Planningsdatum, av.StatusAanvraag, av.Kostenplaats,  av.PrijsIndicatieStuk, av.AantalStuk, av.Bedrag, t % 2 == 0);
                avi.Location = new System.Drawing.Point(xPos, yPos);
                avi.Name = "aanvraagSelection" + t;
                avi.Size = new System.Drawing.Size(881, 33);
                avi.TabIndex = t + 8;
                avi.AanvraagItemSelected += Gli_AanvraagItemSelected;
                this.pnlAanvragen.Controls.Add(avi);

                t++;
                if(t < 10)
                {
                    yPos += 30;
                }
            }
        }
        private void Gli_AanvraagItemSelected(object sender, EventArgs e)
        {
            AanvraagItem geselecteerd = (AanvraagItem)sender;

            //txtIdDetail.Text = geselecteerd.Id.ToString();
            //txtTijdstipActieDetail.Text = geselecteerd.TijdstipActie.ToString();
            //txtGebruikerDetail.Text = geselecteerd.Gebruiker;
            //txtOmschrijvingDetail.Text = geselecteerd.OmschrijvingActie.ToString();
        }
        private void cmbGebruiker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAanvragen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }
    }
}
