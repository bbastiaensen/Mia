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
        public FrmAanvragen()
        {
            InitializeComponent();
            //Maken de connecties met de mannagers.
            PrioriteitManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            FinancieringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            FinancieringsjaarManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            DienstenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AfdelingenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            InvesteringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AankoperManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            KostenplaatsManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            StatusAanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            }
        private void btnNieuweAanvraag_Click(object sender, EventArgs e)
        {
            //Als er op de knop nieuwe aanvraag wordt geklikt kijken we of er al een aanvraagformulier open staaat.
            if (frmAanvraagFormulier == null)
            {
                frmAanvraagFormulier = new frmAanvraagFormulier();
                frmAanvraagFormulier.MdiParent = MdiParent;
                frmAanvraagFormulier.AanvraagBewaard += FrmAanvraagFormulier_AanvraagBewaard;
            }
            //We openen een nieuw aanvraagformulier
            frmAanvraagFormulier.Show();
        }
        public void BindAanvraag(List<Aanvraag> items)
        {
            //Haalt alle aanvragen uit de databank en zet deze in een lijst die we toonen.
            this.pnlAanvragen.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var av in items)
            {
                AanvraagItem avi = new AanvraagItem(av.Id, av.Gebruiker, av.Aanvraagmoment, av.Titel, av.Financieringsjaar, av.Planningsdatum, av.StatusAanvraag, av.Kostenplaats, av.PrijsIndicatieStuk, av.AantalStuk, t % 2 == 0);
                avi.Location = new System.Drawing.Point(xPos, yPos);
                avi.Name = "aanvraagSelection" + t;
                avi.Size = new System.Drawing.Size(1210, 33);
                avi.TabIndex = t + 8;
                avi.AanvraagItemSelected += Gli_AanvraagItemSelected;
                avi.AanvraagDeleted += Avi_AanvraagItemChanged;
                avi.AanvraagItemChanged += Avi_AanvraagItemChanged;
                this.pnlAanvragen.Controls.Add(avi);

                t++;
                yPos += 30;
            }
        }
        private void Avi_AanvraagItemChanged(object sender, EventArgs e)
        {
            try
            { 
                aanvragen = AanvraagManager.GetAanvragen();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void FrmAanvraagFormulier_AanvraagBewaard(object sender, EventArgs e)
        {
            aanvragen = AanvraagManager.GetAanvragen();
            BindAanvraag(aanvragen);
        }
        private void Gli_AanvraagItemSelected(object sender, EventArgs e)
        {
            AanvraagItem geselecteerd = (AanvraagItem)sender;
        }
        private List<Aanvraag> FilteredAanvraagItems(List<Aanvraag> items, bool aanvraagmomentVan, bool aanvraagmomentTot, bool planningsdatumVan, bool planningsdatumTot, bool gebruiker, bool titel, bool statusAanvraag, bool financieringsjaar, bool bedragVan, bool bedragTot, bool kostenPlaats)
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
                if (planningsdatumVan)
                {
                    if (chbxPlaningsdatumVan.Checked == true)
                    {
                        items = items.Where(av => av.Planningsdatum != null && av.Planningsdatum >= Convert.ToDateTime(dtpPlanningsdatumVan.Text)).ToList();
                    }
                }
                if (planningsdatumTot)
                {
                    if (chbxPlaningsdatumTot.Checked == true)
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
                    if (cbBedragVan.Checked == true )
                    {
                        if (txtBedragVan.Text != string.Empty)
                        {
                            items = items.Where(av => av.Bedrag >= Convert.ToInt32(txtBedragVan.Text)).ToList();
                        }
                    } 
                }
                if (bedragTot)
                {
                    if (cbBedragTot.Checked == true)
                    {
                        if(txtBedragTot.Text != string.Empty)
                        {
                            items = items.Where(av => av.Bedrag <= Convert.ToInt32(txtBedragTot.Text)).ToList();
                        }
                    }
                }
                if (kostenPlaats)
                {
                    items = items.Where(av => av.Kostenplaats.ToLower().Contains(txtKostenPlaats.Text.ToLower())).ToList();
                }
            }
           return items;
        }
        private void FrmAanvragen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFinancieringsjaar.Text != string.Empty)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtFinancieringsjaar.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Je kunt alleen cijfers ingeven.");
                        txtFinancieringsjaar.Text = txtFinancieringsjaar.Text.Remove(txtFinancieringsjaar.Text.Length - 1);
                    }
                    filterFinancieringsjaar = true;
                }
                if (txtStatusAanvraag.Text != string.Empty)
                {
                    filterStatusAanvraag = true;
                }
                if (cbBedragTot.Checked != false)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtBedragVan.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Je kunt alleen cijfers ingeven.");
                        txtBedragVan.Text = txtBedragVan.Text.Remove(txtBedragVan.Text.Length - 1);
                    }
                    filterBedragVan = true;
                }
                if (cbBedragTot.Checked != false)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtBedragTot.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Je kunt alleen cijfers ingeven.");
                        txtBedragTot.Text = txtBedragTot.Text.Remove(txtBedragTot.Text.Length - 1);
                    }
                    filterBedragTot = true;
                }
                if (txtTitel.Text != string.Empty)
                {
                    filterTitel = true;
                }
                if (txtKostenPlaats.Text != string.Empty)
                {
                    filterKostenPlaats = true;
                }
                if (txtGebruiker.Text != string.Empty)
                {
                    filterGebruiker = true;
                }
                if (chbxPlaningsdatumTot.Checked != false)
                {
                    filterPlanningsdatumTot = true;
                }
                if (chbxAanvraagmomentVan.Checked != false)
                {
                    filterAanvraagmomentVan = true;
                }
                if (chbxAanvraagmomentTot.Checked != false)
                {
                    filterAanvraagmomentTot = true;
                }
                if (chbxPlaningsdatumVan.Checked != false)
                {
                    filterPlanningsdatumVan = true;
                }
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSortGebruiker_Click(object sender, EventArgs e)
        {
            if(SortGebruiker == true)
            {
                SortGebruiker = false;
                aanvragen = AanvraagManager.GetGebruikerDesc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            else
            {
                SortGebruiker = true;
                aanvragen = AanvraagManager.GetGebruikerAsc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
        }
        private void btnSortTitel_Click(object sender, EventArgs e)
        {
            if(SortTitel == true)
            {
                SortTitel = false;
                aanvragen = AanvraagManager.GetTitelDesc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            else
            {
                SortTitel = true;
                aanvragen = AanvraagManager.GetTitelAsc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
        }
        private void btnSortAanvraagmoment_Click(object sender, EventArgs e)
        {
            if(SortAanvraagmoment == true)
            {
                SortAanvraagmoment = false;
                aanvragen = AanvraagManager.GetAanvraagmomentDesc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            else
            {
                SortAanvraagmoment = true;
                aanvragen = AanvraagManager.GetAanvraagmomentAsc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
        }
        private void btnSortFinancieringsjaar_Click(object sender, EventArgs e)
        {
            if(SortFinancieringsjaar == true)
            {
                SortFinancieringsjaar = false;
                aanvragen = AanvraagManager.GetFinancieringsjaarDesc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            else
            {
                SortFinancieringsjaar = true;
                aanvragen = AanvraagManager.GetFinancieringsjaarAsc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
        }
        private void btnSortStatusAanvraag_Click(object sender, EventArgs e)
        {
            if(SortStatusAanvraag == true)
            {
                SortStatusAanvraag = false;
                aanvragen = AanvraagManager.GetStatusAanvraagDesc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            else
            {
                SortStatusAanvraag = true;
                aanvragen = AanvraagManager.GetStatusAanvraagAsc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
        }
        private void btnBedrag_Click(object sender, EventArgs e)
        {
            if(SortBedrag == true)
            {
                SortBedrag = false;
                aanvragen = AanvraagManager.GetBedragDesc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            else
            {
                SortBedrag = true;
                aanvragen = AanvraagManager.GetBedragAsc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
        }
        private void btnKostenplaats_Click(object sender, EventArgs e)
        {
            if(SortKostenPlaats == true)
            {
                SortKostenPlaats = false;
                aanvragen = AanvraagManager.GetKostenplaatstDesc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            else
            {
                SortKostenPlaats = true;
                aanvragen = AanvraagManager.GetKostenplaatstAsc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
        }
        private void btnPlanningsdatum_Click(object sender, EventArgs e)
        {
            if(SortPlanningsdatum == true)
            {
                SortPlanningsdatum = false;
                aanvragen = AanvraagManager.GetPlanningsdatumDesc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
            else
            {
                SortPlanningsdatum = true;
                aanvragen = AanvraagManager.GetPlanningsdatumAsc();
                BindAanvraag(FilteredAanvraagItems(aanvragen, filterAanvraagmomentVan, filterAanvraagmomentTot, filterPlanningsdatumVan, filterPlanningsdatumTot, filterGebruiker, filterTitel, filterStatusAanvraag, filterFinancieringsjaar, filterBedragVan, filterBedragTot, filterKostenPlaats));
            }
        }
    }
}
