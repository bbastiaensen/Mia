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
using MiaLogic.Manager;
using MiaLogic.Object;

namespace MiaClient
{
    public partial class frmBeheerLanden : Form
    {
        List<Land> landen;
        public event EventHandler LandenChanged;

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;

        public frmBeheerLanden()
        {
            InitializeComponent();
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

        private void frmBeheerLanden_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstLanden();
            AppForms.frmBeheerLanden = this;

            if (AppForms.frmBeheerGemeente != null)
            {
                this.LandenChanged -= AppForms.frmBeheerGemeente.FrmBeheerLanden_LandenChanged;
                this.LandenChanged += AppForms.frmBeheerGemeente.FrmBeheerLanden_LandenChanged;
            }
        }

        private void frmBeheerLanden_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();

            //if (AppForms.frmBeheerLanden == this)
            //{
            //    AppForms.frmBeheerLanden = null;
            //}
        }
        public void BindLstLanden()
        {

            landen = LandenManager.GetLanden();
            LstLanden.DisplayMember = "Naam";

            LstLanden.ValueMember = "Id";
            LstLanden.DataSource = landen;

        }

        private void LstLanden_SelectedIndexChanged(object sender, EventArgs e)
        {
            Land land = (Land)LstLanden.SelectedItem;


            if (land != null)
            {
                txtId.Text = Convert.ToString(land.Id);
                txtNaam.Text = land.Naam;
              

                IsNew = false;
                btnVerwijderen.Enabled = true;
                btnVerwijderen.BackColor = StyleParameters.ButtonBack;
            }
        }
        private void ClearFields()
        {
            txtNaam.Text = string.Empty;
            txtId.Text = string.Empty;
           
            IsNew = true;
            btnVerwijderen.Enabled = false;
            btnVerwijderen.BackColor = Color.Gray;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace( txtNaam.Text))
            {
                MessageBox.Show("Gelieve een geldige naam in te vullen.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtNaam.Text = txtNaam.Text.Trim();
            Land l = new Land();
            l.Id = Convert.ToInt32(LstLanden.SelectedValue);
            l.Naam = txtNaam.Text;
            l.Id = LandenManager.SaveLanden(l, IsNew);
            LandenChanged?.Invoke(this, EventArgs.Empty);
            BindLstLanden();
           
            LstLanden.SelectedValue = l.Id;
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (IsNew)
            {
                MessageBox.Show(
                    "U kunt geen nieuw (onbewaard) land verwijderen.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (LstLanden.SelectedItem == null)
            {
                MessageBox.Show(
                    "Gelieve eerst een land te selecteren.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Land l = (Land)LstLanden.SelectedItem;

            if (MessageBox.Show(
                $"Bent u zeker dat u {l.Naam} wilt verwijderen?",
                "Land verwijderen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                LandenManager.DeleteLand(l);
                LandenChanged?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Het Land is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show(
                    "Het land is succesvol verwijderd.",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                BindLstLanden();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Fout bij verwijderen van het land: {ex.Message}",
                    "MIA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void txtNaam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block the key
            }
        }

    }
}
