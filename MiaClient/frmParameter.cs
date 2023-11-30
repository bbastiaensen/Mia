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
    public partial class frmParameter : Form
    {
        List<Parameter> parameters;

        bool filterCode = false;
        bool filterWaarde = false;
        bool filterEenheid = false;
        bool isNieuw = true;

        public frmParameter()
        {
            InitializeComponent();

            ParameterManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
        }

        private void frmParameter_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void frmParameter_Load(object sender, EventArgs e)
        {
            try
            {
                parameters = ParameterManager.GetParameters();

                BindParameters(parameters);

                btnVerwijderen.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindParameters(List<Parameter> items)
        {
            //Eventueel bestaande lijst verwijderen
            this.pnlParameters.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var p in items)
            {
                ParameterItem pi = new ParameterItem(p.Id, p.Code, p.Waarde, p.Eenheid, t % 2 == 0);
                pi.Location = new System.Drawing.Point(xPos, yPos);
                pi.Name = "parameterSelection" + t;
                pi.Size = new System.Drawing.Size(881, 33);
                pi.TabIndex = t + 8;
                pi.ParameterSelected += Pi_ParameterSelected;
                this.pnlParameters.Controls.Add(pi);

                //Voorbereiden voor de volgende control
                t++;
                if (t < 10)
                {
                    yPos += 30;
                }
            }
        }

        private void Pi_ParameterSelected(object sender, EventArgs e)
        {
            ParameterItem geselecteerd = (ParameterItem)sender;

            txtIdDetail.Text = geselecteerd.Id.ToString();
            txtCodeDetail.Text = geselecteerd.Code;
            txtWaardeDetail.Text = geselecteerd.Waarde;
            txtEenheidDetail.Text = geselecteerd.Eenheid;

            isNieuw = false;
            btnVerwijderen.Enabled = true;
        }

        private void detailsWissen()
        {
            txtIdDetail.Text = string.Empty;
            txtCodeDetail.Text = string.Empty;
            txtWaardeDetail.Text = string.Empty;
            txtEenheidDetail.Text = string.Empty;

            isNieuw = true;
            btnVerwijderen.Enabled = false;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            //Detailformulier leegmaken voor nieuwe invoer.
            detailsWissen();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            try
            {
                //Controle op verplichte velden
                if (string.IsNullOrWhiteSpace(txtCodeDetail.Text))
                {
                    MessageBox.Show("Het veld 'Code' moet ingevuld zijn.","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtWaardeDetail.Text))
                {
                    MessageBox.Show("Het veld 'Waarde' moet ingevuld zijn.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEenheidDetail.Text))
                {
                    MessageBox.Show("Het veld 'Eenheid' moet ingevuld zijn.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Nieuw parameter object aanmaken en vullen met de waarden uit het formulier
                Parameter p = new Parameter();
                p.Code = txtCodeDetail.Text;
                p.Waarde = txtWaardeDetail.Text;
                p.Eenheid = txtEenheidDetail.Text;
                if (!isNieuw)
                {
                    p.Id = Convert.ToInt32(txtIdDetail.Text);
                }
                p.Id = ParameterManager.SaveParameter(p, isNieuw);
                txtIdDetail.Text = p.Id.ToString();

                isNieuw = false;
                btnVerwijderen.Enabled = true;

                parameters = ParameterManager.GetParameters();
                BindParameters(parameters);

                MessageBox.Show("De gegevens zijn bewaard.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            try
            {
                //Nieuw parameter object aanmaken en vullen met de waarden uit het formulier
                Parameter p = new Parameter();
                if (!isNieuw)
                {
                    p.Id = Convert.ToInt32(txtIdDetail.Text);
                }
                ParameterManager.DeleteParameter(p);

                parameters = ParameterManager.GetParameters();
                BindParameters(parameters);

                detailsWissen();

                MessageBox.Show("De gegevens zijn verwijderd.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodeDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Voorkomt dat er spaties in code worden gebruikt.
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
        private List<Parameter> FilteredParameters(List<Parameter> items, bool code, bool waarde, bool eenheid)
        {
            if (items != null)
            {
                if (code)
                {
                    items = items.Where(p => p.Code.ToLower().Contains(txtCode.Text.ToLower())).ToList();
                }

                if (waarde)
                {
                    items = items.Where(p => p.Waarde.ToLower().Contains(txtWaarde.Text.ToLower())).ToList();
                }

                if (eenheid)
                {
                    items = items.Where(p => p.Eenheid.ToLower().Contains(txtEenheid.Text.ToLower())).ToList();
                }
            }

            //Leegmaken detailvelden
            txtIdDetail.Text = string.Empty;
            txtCodeDetail.Text = string.Empty;
            txtWaardeDetail.Text = string.Empty;
            txtEenheidDetail.Text = string.Empty;

            return items;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterCode = true;
                BindParameters(FilteredParameters(parameters, filterCode, filterWaarde, filterEenheid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtWaarde_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterWaarde = true;
                BindParameters(FilteredParameters(parameters, filterCode, filterWaarde, filterEenheid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEenheid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterEenheid = true;
                BindParameters(FilteredParameters(parameters, filterCode, filterWaarde, filterEenheid));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
