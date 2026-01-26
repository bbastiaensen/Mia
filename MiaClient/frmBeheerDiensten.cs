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
    public partial class frmBeheerDiensten : Form
    {
        public frmBeheerDiensten()
        {
            InitializeComponent();
        }

        private void frmBeheerDiensten_Load(object sender, EventArgs e)
        {
            CreateUI();
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

        private void frmBeheerDiensten_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void ClearFields()
        {
            txtAchternaam.Text = string.Empty;
            txtId.Text = string.Empty;
            txtVoornaam.Text = string.Empty;
            checkActief.Checked = false;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {

        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {

        }
    }
}
