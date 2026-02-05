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
    public partial class frmAankoopDetail : Form
    {
        private static readonly DateTime OnbekendeDatum = new DateTime(2000, 1, 1);
        private int _aankoopId;
        private Aankoop _aankoop;
        private Aanvraag _aanvraag;

        public frmAankoopDetail(int aankoopId)
        {
            InitializeComponent();
            _aankoopId = aankoopId;
        }

        private void frmAankoopDetail_Load(object sender, EventArgs e)
        {
            AppForms.frmAankoopDetail = this;

            CreateUI();
            vulDropdowns();
            LaadAankoop();
            BerekenBedragen();
            AfgeslotenStatusRegels();

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

        private void vulDropdowns()
        {
            ddlStatus.DataSource = StatusAankoopManager.GetStatusAankopen();
            ddlStatus.DisplayMember = "Naam";
            ddlStatus.ValueMember = "Id";

            ddlLeverancier.DataSource = LeverancierManager.GetAllLeveranciers();
            ddlLeverancier.DisplayMember = "Leverancier";
            ddlLeverancier.ValueMember = "Id";
        }

        private void LaadAankoop()
        {
            try
            {
                _aankoop = AankoopManager.GetAankoopById(_aankoopId);
                _aanvraag = AanvraagManager.GetAanvraagById(_aankoop.AanvraagId);

                txtAankoopId.Text = _aankoop.Id.ToString();
                rtxtOmschrijving.Text = _aankoop.Omschrijving;
                ddlStatus.SelectedValue = _aankoop.StatusAankoopId;

                txtGoedgekeurdeBedrag.Text = _aankoop.BudgetToegekend.ToString("0.00");
                txtBedragExBtw.Text = _aankoop.BedragExBtw.ToString("0.00");
                txtBTWPercentage.Text = _aankoop.BTWPercentage.ToString("0.00");
                txtBedragTransfer.Text = _aankoop.BedragTransfer.ToString("0.00");

                dtpBestelDatum.Value = _aankoop.BestellingsDatum ?? OnbekendeDatum;
                dtpVerwachteDatum.Value = _aankoop.VerwachteLeveringsDatum ?? OnbekendeDatum;
                dtpEffectieveDatum.Value = _aankoop.EffectieveLeveringsDatum ?? OnbekendeDatum;

                ddlLeverancier.SelectedValue = _aankoop.LeverancierId;
                txtAanvraagId.Text = _aankoop.AanvraagId.ToString();
                txtBestelBonNummer.Text = _aankoop.BestelbonNummer;
                ckbFactuur.Checked = _aankoop.Factuur;
                txtFactuurnummer.Text = _aankoop.FactuurNummer;
                txtInternNummer.Text = _aankoop.InternNummer;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fout bij het laden van de aankoop: " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BerekenBedragen()
        {
            decimal exBTW = ParseDecimal(txtBedragExBtw.Text);
            decimal btw = ParseDecimal(txtBTWPercentage.Text);
            decimal transfer = ParseDecimal(txtBedragTransfer.Text);
            decimal goedgekeurd = ParseDecimal(txtGoedgekeurdeBedrag.Text);

            decimal bedragInBTW = exBTW * (1 + (btw / 100));
            txtBedragInBTW.Text = bedragInBTW.ToString("0.00");

            decimal saldo = goedgekeurd - (bedragInBTW + transfer);
            lblSaldo.Text = saldo.ToString("0.00");

            if (saldo >= 0)
            {
                lblSaldo.BackColor = Color.LightGreen;
                lblSaldo.ForeColor = Color.Black;
                lblSaldo.Font = new Font(lblSaldo.Font, FontStyle.Bold);
            }
            else
            {
                lblSaldo.BackColor = Color.Red;
                lblSaldo.ForeColor = Color.White;
                lblSaldo.Font = new Font(lblSaldo.Font, FontStyle.Bold);
            }
        }
        private decimal ParseDecimal(string value)
        {
            return decimal.TryParse(value, out decimal result) ? result : 0;
        }

        private void AfgeslotenStatusRegels()
        {
            bool afgesloten = _aankoop.StatusAankoopId == 4;

            rtxtOmschrijving.ReadOnly = afgesloten;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb && tb.ReadOnly == false)
                    tb.ReadOnly = afgesloten;

                if (c is ComboBox cb)
                    cb.Enabled = !afgesloten;

                if (c is DateTimePicker dp)
                    dp.Enabled = !afgesloten;
            }

            btn_Verwijderen.Enabled = !afgesloten;
            btn_Bewaren.Enabled = !afgesloten && _aankoop.StatusAankoopId == 1;
        }

        private void btn_Bewaren_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Checks()) return;

                _aankoop.Omschrijving = rtxtOmschrijving.Text;
                _aankoop.StatusAankoopId = Convert.ToInt32(ddlStatus.SelectedValue);
                _aankoop.BedragExBtw = ParseDecimal(txtBedragExBtw.Text);
                _aankoop.BTWPercentage = (int)ParseDecimal(txtBTWPercentage.Text);
                _aankoop.BedragTransfer = ParseDecimal(txtBedragTransfer.Text);

                _aankoop.BestellingsDatum = dtpBestelDatum.Value.Date == OnbekendeDatum
                    ? (DateTime?)null
                    : dtpBestelDatum.Value.Date;

                _aankoop.VerwachteLeveringsDatum = dtpVerwachteDatum.Value.Date == OnbekendeDatum
                    ? (DateTime?)null
                    : dtpVerwachteDatum.Value.Date;

                _aankoop.EffectieveLeveringsDatum = dtpEffectieveDatum.Value.Date == OnbekendeDatum
                    ? (DateTime?)null
                    : dtpEffectieveDatum.Value.Date;

                _aankoop.LeverancierId = Convert.ToInt32(ddlLeverancier.SelectedValue);
                _aankoop.BestelbonNummer = txtBestelBonNummer.Text;
                _aankoop.Factuur = ckbFactuur.Checked;
                _aankoop.FactuurNummer = txtFactuurnummer.Text;
                _aankoop.InternNummer = txtInternNummer.Text;

                AankoopManager.UpdateAankoop(_aankoop);
                AppForms.frmAankopen?.RefreshAankopen();

                MessageBox.Show("Aankoop is succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij het bewaren van de aankoop: " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Checks()
        {
            if (_aankoop == null)
            {
                MessageBox.Show("Geen aankoop geladen.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_aankoop.StatusAankoopId == 4) // Afgesloten
            {
                MessageBox.Show("Een afgesloten aankoop kan niet gewijzigd worden.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtxtOmschrijving.Text))
            {
                MessageBox.Show("Omschrijving is verplicht.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtOmschrijving.Focus();
                return false;
            }

            if (ddlStatus.SelectedItem == null)
            {
                MessageBox.Show("Status is verplicht.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ddlStatus.Focus();
                return false;
            }

            if (ddlLeverancier.SelectedItem == null)
            {
                MessageBox.Show("Leverancier is verplicht.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ddlLeverancier.Focus();
                return false;
            }

            decimal bedragEx = ParseDecimal(txtBedragExBtw.Text);
            decimal btw = ParseDecimal(txtBTWPercentage.Text);

            if (bedragEx < 0)
            {
                MessageBox.Show("Bedrag excl. BTW mag niet negatief zijn.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBedragExBtw.Focus();
                return false;
            }

            if (btw < 0 || btw > 100)
            {
                MessageBox.Show("BTW percentage moet tussen 0 en 100 liggen.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBTWPercentage.Focus();
                return false;
            }
            return true;
        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            if (_aankoop.StatusAankoopId != 1) return;

            var result = MessageBox.Show("Ben je zeker dat je deze aankoop wil verwijderen?", "MIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                AankoopManager.DeleteAankoop(_aankoop.Id);
                AppForms.frmAankopen?.RefreshAankopen();
                this.Close();
            }
        }

        private void btnBeheerLeveranciers_Click(object sender, EventArgs e)
        {
            using (var frm = new frmBeheerLeverancier())
            {
                frm.ShowDialog();
                ddlLeverancier.DataSource = LeverancierManager.GetAllLeveranciers();
            }

        }
    }
}
