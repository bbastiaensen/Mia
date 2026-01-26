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
    public partial class frmBeheerAfdelingen : Form
    {
        List<Afdeling> afdelingen;
        bool IsNew = false;


        public frmBeheerAfdelingen()
        {
            InitializeComponent();
        }

        private void frmBeheerAfdelingen_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstAfdelingen();
        }

        public void CreateUI()
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
        }

        private void frmBeheerAfdelingen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        public void BindLstAfdelingen()
        {
            afdelingen = AfdelingenManager.GetAfdelingen();
            LstAfdelingen.DisplayMember = "Naam";

            LstAfdelingen.ValueMember = "Id";
            LstAfdelingen.DataSource = afdelingen;


        }

        private void LstAfdelingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Afdeling afdeling = (Afdeling)LstAfdelingen.SelectedItem;


            if (afdeling != null)
            {
                txtId.Text = Convert.ToString(afdeling.Id);
                txtNaam.Text = afdeling.Naam;
                if (afdeling.actief)
                {
                    checkActief.Checked = true;
                }
                else
                {
                    checkActief.Checked = false;
                }

                IsNew = false;
            }
        }

        private void ClearFields()
        {
            txtNaam.Text = string.Empty;
            txtId.Text = string.Empty;
            checkActief.Checked = false;
            IsNew = true;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            Afdeling a = new Afdeling();
            a.Id = Convert.ToInt32(LstAfdelingen.SelectedValue);
            a.Naam = txtNaam.Text;
            if (checkActief.Checked)
            {
                a.actief = true;
            }
            else
            {
                a.actief = false;
            }


            a.Id = AfdelingenManager.SaveAfdeling(a, IsNew);

            BindLstAfdelingen();
            ClearFields();
            LstAfdelingen.SelectedValue = a.Id;
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Afdeling a = new Afdeling();
            if (!IsNew)
                a.Id = (int)LstAfdelingen.SelectedValue; a.Naam = txtNaam.Text;
            if (checkActief.Checked)
            {
                a.actief = true;
            }
            else
            {
                a.actief = false;
            }



            if (MessageBox.Show($"Bent u zeker dat u {LstAfdelingen.Text} wilt verwijderen?", "Afdeling verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("De Afdeling is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AfdelingenManager.DeleteAfdeling(a);
            }



            BindLstAfdelingen();
            ClearFields();

        }
    }
}
