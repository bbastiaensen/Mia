using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBeheerKostenplaatsen : Form
    {
        Boolean isNew = false;

        public frmBeheerKostenplaatsen()
        {
            InitializeComponent();
        }

        private void frmBeheerKostenplaatsen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void frmBeheerKostenplaatsen_Load(object sender, EventArgs e)
        {
            CreateUI();
        }

        private void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            //this.Icon = imgFormIcon;

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }

            try
            {
                BindLsbKostenplaatsen();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een probleem opgetreden bij het inladen van de kostenplaatsen. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindLsbKostenplaatsen()
        {
            lsbKostenplaatsen.DisplayMember = "Naam";
            lsbKostenplaatsen.ValueMember = "Id";
            lsbKostenplaatsen.DataSource = KostenplaatsManager.GetAllKostenplaatsen();
        }

        private void lsbKostenplaatsen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Kostenplaats k = KostenplaatsManager.GetKostenplaatsById(Convert.ToInt32(lsbKostenplaatsen.SelectedValue));

                if (k != null)
                {
                    SetFields(k);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een probleem opgetreden bij het inladen van een kostenplaats. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SetFields(Kostenplaats k)
        {
            txtId.Text = k.Id.ToString();
            txtNaam.Text = k.Naam;
            txtCode.Text = k.Code.ToString();
            chkActief.Checked = k.Actief;
            isNew = false;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            //Formulier klaarmaken voor nieuwe invoer
            txtId.Text = string.Empty; 
            txtNaam.Text = string.Empty; 
            txtCode.Text = string.Empty;
            chkActief.Checked = false;
            isNew = true;
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            try
            {
                Kostenplaats k = new Kostenplaats();

                k.Id = Convert.ToInt32(txtId.Text);
                k.Naam = txtNaam.Text;
                k.Code = Convert.ToInt32(txtCode.Text);
                k.Actief = chkActief.Checked;

                k = KostenplaatsManager.SaveKostenplaats(isNew, k);

                SetFields(k);

                BindLsbKostenplaatsen();

                lsbKostenplaatsen.SelectedValue = k.Id;

                isNew = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een probleem opgetreden bij het bewaren van een kostenplaats. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("De gegevens zijn bewaard", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {

        }
    }
}
