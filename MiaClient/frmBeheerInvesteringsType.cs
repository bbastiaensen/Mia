using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmBeheerInvesteringsType : Form
    {
        private Investering huidige;
        private bool isNew;

        public frmBeheerInvesteringsType()
        {
            InitializeComponent();
        }

        private void frmBeheerInvesteringsType_Load(object sender, EventArgs e)
        {
            CreateUI();
            LoadList();

            btnNieuw.Click += btnNieuw_Click;
            btnBewaren.Click += btnBewaren_Click;
            btnVerwijderen.Click += btnVerwijderen_Click;
            InvesteringsTypes.SelectedIndexChanged += InvesteringsTypes_SelectedIndexChanged;
        }

        private void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }
        }

        private void LoadList()
        {
            InvesteringsTypes.DataSource = null;
            InvesteringsTypes.DataSource = InvesteringenManager.GetInvesteringen();
        }

        private void InvesteringsTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            huidige = InvesteringsTypes.SelectedItem as Investering;
            if (huidige == null) return;

            txtId.Text = huidige.Id.ToString();
            txtVoornaam.Text = huidige.Naam;
            checkActief.Checked = huidige.Actief;
            isNew = false;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            huidige = new Investering();
            isNew = true;

            txtId.Clear();
            txtVoornaam.Clear();
            checkActief.Checked = true;
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVoornaam.Text))
            {
                MessageBox.Show("Naam is verplicht");
                return;
            }

            huidige.Naam = txtVoornaam.Text;
            huidige.Actief = checkActief.Checked;

            huidige.Id = InvesteringenManager.SaveInvestering(huidige, isNew);
            LoadList();
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if (huidige == null) return;

            if (MessageBox.Show(
                "Ben je zeker dat je dit InvesteringsType wil verwijderen?",
                "Bevestiging",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                InvesteringenManager.DeleteInvestering(huidige);
                LoadList();
                btnNieuw_Click(null, null);
            }
        }

        private void frmBeheerInvesteringsType_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
