using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmGrafiekEvolutieBudgetten : Form
    {
        Icon imgFormIcon = Icon.FromHandle((new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-pie-chart-48.png")).GetHicon()));

        public frmGrafiekEvolutieBudgetten()
        {
            InitializeComponent();
        }

        private void frmGrafiekEvolutieBudgetten_Load(object sender, EventArgs e)
        {
            CreateUI();
        }

        private void frmGrafiekEvolutieBudgetten_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            this.Icon = imgFormIcon;
        }
    }
}
