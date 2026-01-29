using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmNieuweAankoop : Form
    {
        private List<Aanvraag> _bekrachtigdeAanvragen;
        public event EventHandler AankoopToegevoegd;

        public frmNieuweAankoop()
        {
            InitializeComponent();
        }

        private void frmNieuweAankoop_Load(object sender, EventArgs e)
        {
            CreateUI();
            LaadBekrachtigdeAanvragen();
        }

        private void LaadBekrachtigdeAanvragen()
        {
            _bekrachtigdeAanvragen = AanvraagManager.GetBekrachtigdeAanvragenZonderAankoop();

            dgvAanvragen.DataSource = null;
            dgvAanvragen.Columns.Clear();

            if (_bekrachtigdeAanvragen != null && _bekrachtigdeAanvragen.Any())
            {
                // Data kolommen eerst (via DataSource)
                var dgvData = _bekrachtigdeAanvragen.Select(a => new
                {
                    Id = a.Id,
                    Omschrijving = a.Omschrijving ?? "",
                    Aanvrager = a.Gebruiker ?? "",
                    StatusAanvraag = a.StatusAanvraag ?? "",
                    Financieringsjaar = a.Financieringsjaar ?? "",
                    Richtperiode = a.RichtperiodeNaam ?? ""
                }).ToList();

                dgvAanvragen.DataSource = dgvData;

                // € kolom links - als icoon (toevoegen na DataSource)
                var euroIconPath = Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-euro-50.png");
                Image euroIcon = File.Exists(euroIconPath) ? Image.FromFile(euroIconPath) : null;

                var colEuro = new DataGridViewImageColumn
                {
                    Name = "colEuro",
                    HeaderText = "",
                    Width = 40,
                    ReadOnly = true,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                if (euroIcon != null)
                {
                    colEuro.Image = euroIcon;
                }
                dgvAanvragen.Columns.Insert(0, colEuro);

                // Kolomnamen en zichtbaarheid
                dgvAanvragen.Columns["Id"].Visible = false;
                dgvAanvragen.Columns["Omschrijving"].HeaderText = "Omschrijving";
                dgvAanvragen.Columns["Aanvrager"].HeaderText = "Aanvrager";
                dgvAanvragen.Columns["StatusAanvraag"].HeaderText = "Status aanvraag";
                dgvAanvragen.Columns["Financieringsjaar"].HeaderText = "Financieringsjaar";
                dgvAanvragen.Columns["Richtperiode"].HeaderText = "Richtperiode";
            }
        }

        private void dgvAanvragen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Negeer klik op rijheader of kolomheader (ColumnIndex of RowIndex is -1)
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || _bekrachtigdeAanvragen == null) return;

            // Alleen reageren op klik op de € kolom
            if (dgvAanvragen.Columns[e.ColumnIndex].Name == "colEuro")
            {
                VoegAanvraagToeAanAankopen(e.RowIndex);
            }
        }

        private void VoegAanvraagToeAanAankopen(int rowIndex)
        {
            if (_bekrachtigdeAanvragen == null || rowIndex < 0 || rowIndex >= _bekrachtigdeAanvragen.Count)
                return;

            var aanvraag = _bekrachtigdeAanvragen[rowIndex];

            try
            {
                var aankoop = new Aankoop
                {
                    Omschrijving = aanvraag.Omschrijving ?? "",
                    BTWPercentage = 21,
                    BedragExBtw = 0,
                    StatusAankoopId = 1,
                    LeverancierId = 1,
                    AanvraagId = aanvraag.Id
                };

                AankoopManager.CreateAankoop(aankoop);

                // Refresh beide lijsten
                LaadBekrachtigdeAanvragen();
                AankoopToegevoegd?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout bij toevoegen aankoop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            // Rijnummers zichtbaar maken in de DataGridView
            dgvAanvragen.RowHeadersVisible = true;
            dgvAanvragen.RowHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            dgvAanvragen.RowHeadersDefaultCellStyle.ForeColor = SystemColors.ControlText;

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }
        }

        private void frmNieuweAankoop_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

  
    }
}
