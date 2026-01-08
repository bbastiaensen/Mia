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
    public partial class frmPrioriteit : Form
    {
        List<Prioriteit> prioriteiten = new List<Prioriteit>();

        bool IsNew = false;

        public frmPrioriteit()
        {
            InitializeComponent();
        }

        private void frmPrioriteit_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmPrioriteit_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindlstPrioriteiten();
        }
        public void BindlstPrioriteiten()
        {
            prioriteiten = PrioriteitManager.GetPrioriteiten();
            lstPrioriteiten.DisplayMember = "Naam";
            lstPrioriteiten.ValueMember = "Id";
            lstPrioriteiten.DataSource = prioriteiten;
        }

        private void lstPrioriteiten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prioriteit prioriteit = (Prioriteit)lstPrioriteiten.SelectedItem;

            if (prioriteit != null) 
            {
                txtId.Text = Convert.ToString(prioriteit.Id);
                txtNaam.Text = Convert.ToString(prioriteit.Naam);
                if (prioriteit.Actief)
                {
                    chkActief.Checked = true;
                }
                else
                {
                    chkActief.Checked = false;
                }
                 IsNew = false;

            }
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
             IsNew = true;

        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            Prioriteit p = new Prioriteit();
            p.Id = Convert.ToInt32(lstPrioriteiten.SelectedValue);
            p.Naam = txtNaam.Text;
            if (chkActief.Checked)
            {
                p.Actief = true;
            }
            else
            {
                p.Actief = false;
            }
            p.Id = PrioriteitManager.SavePrioriteit(p, IsNew);

            BindlstPrioriteiten();
            ClearFields();
            lstPrioriteiten.SelectedValue = p.Id.ToString();
            IsNew = false;

            MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            Prioriteit p = new Prioriteit();
            p.Id = Convert.ToInt32(lstPrioriteiten.SelectedValue);
            p.Naam = txtNaam.Text;
            if (chkActief.Checked)
            {
                p.Actief = true;
            }
            else
            {
                p.Actief = false;
            }

            if (MessageBox.Show($"Bent u dat u {lstPrioriteiten.Text} wilt verwijderen?", "Aankoper verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                PrioriteitManager.DeletePrioriteit(p);
                BindlstPrioriteiten();
                MessageBox.Show("De Prioriteit is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        public void ClearFields()
        {
            txtId.Text = string.Empty;
            txtNaam.Text = string.Empty;
            chkActief.Checked = false;
        }
    }
}
