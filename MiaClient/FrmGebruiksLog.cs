using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class FrmGebruiksLog : Form
    {
        List<GebruiksLog> gebruiksLogs;

        bool filterVan = false;
        bool filterTot = false;
        bool filterGebruiker = false;
        bool filterOmschrijving = false;

        public FrmGebruiksLog()
        {
            InitializeComponent();
        }

        private void BindGebruiksLogItems(List<GebruiksLog> items)
        {
            //Eventueel bestaande lijst verwijderen
            this.pnlGebruiksLogItems.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var gl in items)
            {
                GebruikslogItem gli = new GebruikslogItem(gl.Id, gl.TijdstipActie, gl.Gebruiker, gl.OmschrijvingActie, t % 2 == 0);
                gli.Location = new System.Drawing.Point(xPos, yPos);
                gli.Name = "gebruiksLogSelection" + t;
                gli.Size = new System.Drawing.Size(881, 33);
                gli.TabIndex = t + 8;
                gli.GebruiksLogItemSelected += Gli_GebruiksLogItemSelected;
                this.pnlGebruiksLogItems.Controls.Add(gli);

                //Voorbereiden voor de volgende control
                t++;
                yPos += 30;
            }
        }

        private void Gli_GebruiksLogItemSelected(object sender, EventArgs e)
        {
            GebruikslogItem geselecteerd = (GebruikslogItem)sender;

            txtIdDetail.Text = geselecteerd.Id.ToString();
            txtTijdstipActieDetail.Text = geselecteerd.TijdstipActie.ToString();
            txtGebruikerDetail.Text = geselecteerd.Gebruiker;
            txtOmschrijvingDetail.Text = geselecteerd.OmschrijvingActie.ToString();
        }

        private List<GebruiksLog> FilteredGebruiksLogItems(List<GebruiksLog> items, bool van, bool tot, bool gebruiker, bool omschrijving)
        {
            if (items != null)
            {
                if (van)
                {
                    items = items.Where(gl => gl.TijdstipActie >= Convert.ToDateTime(dtpVan.Text)).ToList();
                }

                if (tot)
                {
                    items = items.Where(gl => gl.TijdstipActie <= (Convert.ToDateTime(dtpTot.Text)).Add(new TimeSpan(23, 59, 59))).ToList();
                }

                if (gebruiker)
                {
                    items = items.Where(gl => gl.Gebruiker.ToLower().Contains(txtGebruiker.Text.ToLower())).ToList();
                }

                if (omschrijving)
                {
                    items = items.Where(gl => gl.OmschrijvingActie.ToLower().Contains(txtOmschrijving.Text.ToLower())).ToList();
                }
            }

            //Leegmaken detailvelden
            txtIdDetail.Text = string.Empty;
            txtGebruikerDetail.Text = string.Empty;
            txtTijdstipActieDetail.Text = string.Empty;
            txtOmschrijvingDetail.Text = string.Empty;

            return items;
        }

        private void frmGebruiksLogDemo_Load(object sender, EventArgs e)
        {
            try
            {
                gebruiksLogs = GebruiksLogManager.GetGebruiksLogs();

                BindGebruiksLogItems(gebruiksLogs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGebruiksLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void pnlGebruiksLogItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGebruiker.Text != string.Empty)
                {
                    filterGebruiker = true;
                }
                if (txtOmschrijving.Text != string.Empty)
                {
                    filterOmschrijving = true;
                }
                if (chkTot.Checked != false)
                {
                    filterTot = chkTot.Checked;
                }
                if (chkVan.Checked != false)
                {
                    filterTot = chkTot.Checked;
                }

                BindGebruiksLogItems(FilteredGebruiksLogItems(gebruiksLogs, filterVan, filterTot, filterGebruiker, filterOmschrijving));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
