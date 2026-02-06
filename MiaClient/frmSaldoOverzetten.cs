using ProofOfConceptDesign;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmSaldoOverzetten : Form
    {
        Image imgFilter = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "Filter.png"));
        int aankoopId = 0;

        public frmSaldoOverzetten(int aankoopId)
        {
            this.aankoopId = aankoopId;
            InitializeComponent();
        }

        private void frmSaldoOverzetten_Load(object sender, EventArgs e)
        {
            CreateUI();
        }

        private void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            //this.Icon = imgFormIcon;

            foreach (var btn in this.Controls.OfType<Button>())
            {
                if (btn.Name != "btnZoeken")
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = StyleParameters.ButtonBack;
                    btn.ForeColor = StyleParameters.Buttontext;
                }
            }

            btnZoeken.BackgroundImage = imgFilter;
            btnZoeken.BackgroundImageLayout = ImageLayout.Stretch;
            btnZoeken.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            btnSaldoOverzetten.Text = "Saldo van aankoop #" + aankoopId + " overzetten";
        }

        private void frmSaldoOverzetten_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {

            btnSaldoOverzetten.Text = "Saldo van aankoop #" + aankoopId + " overzetten naar aanvraag #" + txtAanvraagId.Text;
            btnSaldoOverzetten.Enabled = true;
        }

        private void btnSaldoOverzetten_Click(object sender, EventArgs e)
        {

        }
    }
}
