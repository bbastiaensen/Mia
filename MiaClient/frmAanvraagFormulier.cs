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
    public partial class frmAanvraagFormulier : Form
    {
        public frmAanvraagFormulier()
        {
            InitializeComponent();
            vulFormulier();
        }

        public void vulFormulier()
        {
            txtGebruiker.Text = Program.Gebruiker;
            txtAanvraagmoment.Text = System.DateTime.Now.Date.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAanvraagFormulier_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }
    }
}
