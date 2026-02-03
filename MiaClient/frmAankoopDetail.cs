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

            //ddlLeverancier.DataSource = LeverancierManager.GetLeveranciers();
            ddlLeverancier.DisplayMember = "Naam";
            ddlLeverancier.ValueMember = "Id";
        }

        private void LaadAankoop()
        {

            _aankoop = AankoopManager.GetAankoopById(_aankoopId);
            _aanvraag = AanvraagManager.GetAanvraagById(_aankoop.AanvraagId);

            //txtId.Text = _aankoop.Id.ToString();
            rtxtOmschrijving.Text = _aankoop.Omschrijving;
            ddlStatus.SelectedValue = _aankoop.StatusAankoopId;

            txtGoedgekeurdeBedrag.Text = _aanvraag.BudgetToegekend.ToString("0.00");
            txtBedragExBtw.Text = _aankoop.BedragExBtw.ToString("0.00");
            txtBTWPercentage.Text = _aankoop.BTWPercentage.ToString("0.00");
            txtBedragTransfer.Text = _aankoop.BedragTransfer.ToString("0.00");

            dtpBestelDatum.Value =
                _aankoop.BestellingsDatum == DateTime.MinValue
                ? new DateTime(2000, 1, 1) : _aankoop.BestellingsDatum;

            dtpVerwachteDatum.Value =
                _aankoop.VerwachteLeveringsDatum == DateTime.MinValue
                ? new DateTime(2000, 1, 1) : _aankoop.VerwachteLeveringsDatum;

            dtpEffectieveDatum.Value =
                _aankoop.EffectieveLeveringsDatum == DateTime.MinValue
                ? new DateTime(2000, 1, 1) : _aankoop.EffectieveLeveringsDatum;

            ddlLeverancier.SelectedValue = _aankoop.LeverancierId;

            txtAanvraagId.Text = _aankoop.AanvraagId.ToString();
            txtBestelBonNummer.Text = _aankoop.BestelbonNummer;
            ckbFactuur.Checked = _aankoop.Factuur;
            txtFactuurnummer.Text = _aankoop.FactuurNummer;
            txtInternNummer.Text = _aankoop.InternNummer;
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

            foreach (Control c in this.Controls)
            {
                if (c is TextBox tb && tb.ReadOnly == false)
                    tb.ReadOnly = afgesloten;

                if (c is ComboBox cb)
                    cb.Enabled = !afgesloten;

                if (c is DateTimePicker dp)
                    dp.Enabled = !afgesloten;
            }

            btn_Bewaren.Enabled = !afgesloten;
            btn_Bewaren.Enabled = !afgesloten && _aankoop.StatusAankoopId == 1;
        }

        private void btn_Bewaren_Click(object sender, EventArgs e)
        {
            if (!Checks()) return;

            _aankoop.Omschrijving = rtxtOmschrijving.Text;
            _aankoop.StatusAankoopId = Convert.ToInt32(ddlStatus.SelectedValue);
            _aankoop.BedragExBtw = ParseDecimal(txtBedragExBtw.Text);
            _aankoop.BTWPercentage = (int)ParseDecimal(txtBTWPercentage.Text);
            _aankoop.BedragTransfer = ParseDecimal(txtBedragTransfer.Text);
            _aankoop.BestellingsDatum = dtpBestelDatum.Value;
            _aankoop.VerwachteLeveringsDatum = dtpVerwachteDatum.Value;
            _aankoop.EffectieveLeveringsDatum = dtpEffectieveDatum.Value;
            _aankoop.LeverancierId = Convert.ToInt32(ddlLeverancier.SelectedValue);
            _aankoop.BestelbonNummer = txtBestelBonNummer.Text;
            _aankoop.Factuur = ckbFactuur.Checked;
            _aankoop.FactuurNummer = txtFactuurnummer.Text;
            _aankoop.InternNummer = txtInternNummer.Text;
        }

        private bool Checks()
        {
            if (string.IsNullOrWhiteSpace(rtxtOmschrijving.Text))
            {
                MessageBox.Show("Omschrijving is verplicht.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ddlStatus.SelectedItem == null)
            {
                MessageBox.Show("Status is verplicht.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_Verwijderen_Click(object sender, EventArgs e)
        {

        }
    }
}
