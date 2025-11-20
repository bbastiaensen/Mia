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
        public partial class frmBeheerAankopers : Form
        {
            public frmBeheerAankopers()
            {
                InitializeComponent();
            }

            private void frmBeheerAankopers_FormClosing(object sender, FormClosingEventArgs e)
            {
                //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
                //keren naast elkaar kan geopend worden.
                e.Cancel = true;
                ((Form)sender).Hide();
            }

        private void frmBeheerAankopers_Load(object sender, EventArgs e)
        {
            btnGenereer.Enabled = false;
            cmbFinancieringsjaar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFinancieringsjaar.Items.Clear();

            // Haal de aanvragen op
            var aanvragen = AanvraagManager.GetAanvragenByRichtPeriodeAsc();

            if (aanvragen != null && aanvragen.Any())
            {
                var jaren = aanvragen
                    .Select(a => Convert.ToInt32(a.Financieringsjaar))
                    .Distinct()
                    .OrderBy(j => j)
                    .ToList();

                cmbFinancieringsjaar.Items.AddRange(jaren.Select(j => j.ToString()).ToArray());

                // **Verwijder automatische selectie van laatste jaar**
                cmbFinancieringsjaar.SelectedIndex = -1; // geen vooraf geselecteerd jaar
            }
            else
            {
                MessageBox.Show(
                      "Er werden geen financieringsjaren gevonden in de databank.\n" +
                      "Controleer of er aanvragen geregistreerd zijn.",
                      "MIA – Geen financieringsjaren",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                );
            }
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

            private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
            {
                btnGenereer.Enabled = cmbFinancieringsjaar.SelectedIndex >= 0;
            }

        private void btnGenereer_Click(object sender, EventArgs e)
        {
            if (cmbFinancieringsjaar.SelectedItem == null) return;

            // Gekozen jaar ophalen
            int gekozenJaar = int.Parse(cmbFinancieringsjaar.SelectedItem.ToString());

            // Alle aanvragen ophalen
            List<Aanvraag> alleAanvragen = AanvraagManager.GetAanvragenByRichtPeriodeAsc();

            // Alleen geweigerde aanvragen filteren
            var geweigerdeAanvragen = alleAanvragen
                .Where(a =>
                {
                    var statusNaam = StatusAanvraagManager.GetStatusAanvraagById(a.StatusAanvraagId).Naam?.ToLower().Trim();
                    return (statusNaam == "niet bekrachtigd" || statusNaam == "niet goedgekeurd")
                           && !string.IsNullOrEmpty(a.Financieringsjaar)
                           && Convert.ToInt32(a.Financieringsjaar) == gekozenJaar;
                })
                .ToList();

            // Tonen in datagridview
            dataGridView.DataSource = geweigerdeAanvragen;

            if (geweigerdeAanvragen.Count == 0)
            {
                MessageBox.Show(
                    $"Er werden geen geweigerde aanvragen gevonden voor financieringsjaar {gekozenJaar}.",
                    "MIA – Geen resultaten",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }

    }


}
    
