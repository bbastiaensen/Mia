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
    public partial class frmBeheerFinancieringsType : Form
    {

        public event EventHandler FinancieringstypenGewijzigd;
        List<Financiering> financierings;

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;
   
        public frmBeheerFinancieringsType()
        {
            InitializeComponent();
        }

        private void frmBeheerFinancieringsType_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstFinancieringsTypen();
        }

        private void frmBeheerFinancieringsType_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
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
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {

            txtId.Text = string.Empty;
            txtNaam.Text = string.Empty;
            checkActief.Checked = false;

            IsNew = true;
        }
        private void btnBewaren_Click(object sender, EventArgs e)
        {
            Financiering a = new Financiering();
            a.Id = Convert.ToInt32(LstFinancieringsTypen.SelectedValue);
            a.Naam = txtNaam.Text;

            if (checkActief.Checked)
            {
                a.Actief = true;
            }
            else
            {
                a.Actief = false;
            }

            a.Id = FinancieringenManager.SaveFinancieringType(a, IsNew);

            BindLstFinancieringsTypen();
            ClearFields();
            LstFinancieringsTypen.SelectedValue = a.Id;

            IsNew = false;

            // Event triggeren
            FinancieringstypenGewijzigd?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Financiering a = new Financiering();
            a.Id = Convert.ToInt32(LstFinancieringsTypen.SelectedValue);
            a.Naam = txtNaam.Text;
            a.Actief = checkActief.Checked;

            if (MessageBox.Show($"Bent u zeker dat u {LstFinancieringsTypen.Text} wilt verwijderen?",
                                "Financiering verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Controleer of deze financiering al gebruikt is
                if (FinancieringenManager.IsFinancieringGebruikt(a.Id))
                {
                    // Niet verwijderen, alleen deactiveren
                    FinancieringenManager.DeactiveerFinanciering(a.Id);
                    MessageBox.Show("Deze financiering is al gekoppeld aan een aanvraag en is daarom op niet-actief gezet.",
                                    "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Kan veilig verwijderen (logisch hier nog steeds via Deactiveer als je geen echte delete wilt)
                    FinancieringenManager.DeleteFinancier(a);
                    MessageBox.Show("De financiering is succesvol verwijderd.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Event triggeren
                FinancieringstypenGewijzigd?.Invoke(this, EventArgs.Empty);
            }

            BindLstFinancieringsTypen();
            ClearFields();
        }

        public void BindLstFinancieringsTypen()
        {

            financierings = FinancieringenManager.GetFinancieringen();

            LstFinancieringsTypen.DisplayMember = "Naam";
            LstFinancieringsTypen.ValueMember = "Id";
            LstFinancieringsTypen.DataSource = financierings;

        }

        private void LstFinancieringsTypen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Financiering financier = (Financiering)LstFinancieringsTypen.SelectedItem;


            if (financier != null)
            {
                txtId.Text = Convert.ToString(financier.Id);
                txtNaam.Text = financier.Naam;

                if (financier.Actief)
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
    }
}
