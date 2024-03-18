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
        List<Aanvraag> aanvragen;

        bool filterAanvraagmomentVan = false;
        bool filterAanvraagmomentTot = false;
        bool filterPlanningsdatumVan = false;
        bool filterPlanningsdatumTot = false;
        bool filterGebruiker = false;
        bool filterTitel = false;
        bool filterStatusAanvraag = false;
        bool filterFinancieringsjaar = false;
        bool filterBedrag = false;
        bool filterKostenPlaats = false;




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

                AanvraagItem avi = new AanvraagItem(av.Id,av.Gebruiker, av.Aanvraagmoment, av.Titel, av.Financieringsjaar, av.Planningsdatum, av.StatusAanvraag, av.Kostenplaats,  av.PrijsIndicatieStuk, av.AantalStuk, t % 2 == 0);
                avi.Location = new System.Drawing.Point(xPos, yPos);
                avi.Name = "aanvraagSelection" + t;
                avi.Size = new System.Drawing.Size(1300, 33);
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
        private void frmAanvragen_Load(object sender, EventArgs e)
        {
            try
            {
                aanvragen = AanvraagManager.GetAanvragen();

                BindAanvraag(aanvragen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private List<Aanvraag> FilteredAanvraagItems(List<Aanvraag> items, bool aanvraagmomentVan, bool aanvraagmomentTot, bool planningsdatumVan, bool planningsdatumTot, bool gebruiker, bool titel, bool statusAanvraag, bool financieringsjaar, bool bedragVan, bool bedragTot, bool kostenPlaats)
        {
            if (items != null)
            {
                if (aanvraagmomentVan)
                {
                    items = items.Where(av => av.Aanvraagmoment >= Convert.ToDateTime(dtpAanvraagmomentVan.Text)).ToList();
                }

                if (aanvraagmomentTot)
                {
                    items = items.Where(av => av.Aanvraagmoment <= (Convert.ToDateTime(dtpAanvraagmomentTot.Text)).Add(new TimeSpan(23, 59, 59))).ToList();
                }

                if (planningsdatumVan)
                {
                    if (dtpPlanningsdatumVan.Text != string.Empty)
                    {
                        items = items.Where(av => av.Planningsdatum != null && av.Planningsdatum >= Convert.ToDateTime(dtpPlanningsdatumVan.Text)).ToList();
                    }
                }

                if (planningsdatumTot)
                {
                    if (dtpPlanningsdatumVan.Text != string.Empty)
                    {
                        items = items.Where(av => av.Planningsdatum != null && av.Planningsdatum <= (Convert.ToDateTime(dtpPlanningsdatumTot.Text)).Add(new TimeSpan(23, 59, 59))).ToList();
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

                if (statusAanvraag)
                {
                    items = items.Where(av => av.StatusAanvraag.ToLower().Contains(txtStatusAanvraag.Text.ToLower())).ToList();
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
                    if (txtBedragVan.Text != string.Empty)
                    {
                        items = items.Where(av => av.Bedrag != null && av.Bedrag.ToString().Contains(txtBedragVan.Text.ToLower())).ToList();
                    }
                    
                }
                if (bedragTot)
                {
                    if (txtBedragVan.Text != string.Empty)
                    {
                        items = items.Where(av => av.Bedrag != null && av.Bedrag.ToString().Contains(txtBedragTot.Text.ToLower())).ToList();
                    }

                }

                if (kostenPlaats)
                {
                    items = items.Where(av => av.Kostenplaats.ToLower().Contains(txtKostenPlaats.Text.ToLower())).ToList();
                }

            }

            ////Leegmaken detailvelden
            //txtBedrag.Text = string.Empty;
            //txtFinancieringsjaar.Text = string.Empty;
            //txtGebruiker.Text = string.Empty;
            //txtKostenPlaats.Text = string.Empty;
            //txtStatusAanvraag.Text = string.Empty;
            //txtTitel.Text = string.Empty;
            return items;
        }

        private void FrmAanvragen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void pnlAanvragen_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pnlAanvragen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTitel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterTitel = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStatusAanvraag_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterStatusAanvraag = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFinancieringsjaar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterFinancieringsjaar = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBedrag_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterBedrag = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKostenPlaats_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterKostenPlaats = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbxAanvraagmomentVan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                filterAanvraagmomentVan = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbxAanvraagmomentTot_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                filterAanvraagmomentTot = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbxPlaningsdatumVan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                filterPlanningsdatumVan = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbxPlaningsdatumTot_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                filterPlanningsdatumTot = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGebruiker_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterGebruiker = true;
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedrag, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
