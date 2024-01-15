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

            GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
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
                if (t < 10)
                {
                    yPos += 30;
                }
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
                    items = items.Where(gl => gl.TijdstipActie <= Convert.ToDateTime(dtpTot.Text)).ToList();
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

        private void txtGebruiker_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterGebruiker = true;
                BindGebruiksLogItems(FilteredGebruiksLogItems(gebruiksLogs, filterVan, filterTot, filterGebruiker, filterOmschrijving));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOmschrijving_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterOmschrijving = true;
                BindGebruiksLogItems(FilteredGebruiksLogItems(gebruiksLogs, filterVan, filterTot, filterGebruiker, filterOmschrijving));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkVan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                filterVan = chkVan.Checked;
                BindGebruiksLogItems(FilteredGebruiksLogItems(gebruiksLogs, filterVan, filterTot, filterGebruiker, filterOmschrijving));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkTot_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                filterTot = chkTot.Checked;
                BindGebruiksLogItems(FilteredGebruiksLogItems(gebruiksLogs, filterVan, filterTot, filterGebruiker, filterOmschrijving));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpVan_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BindGebruiksLogItems(FilteredGebruiksLogItems(gebruiksLogs, filterVan, filterTot, filterGebruiker, filterOmschrijving));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpTot_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BindGebruiksLogItems(FilteredGebruiksLogItems(gebruiksLogs, filterVan, filterTot, filterGebruiker, filterOmschrijving));
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
    }
}
