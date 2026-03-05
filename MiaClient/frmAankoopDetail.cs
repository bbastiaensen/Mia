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
using System.Globalization;

namespace MiaClient
{
    public partial class frmAankoopDetail : Form
    {
        private static readonly DateTime OnbekendeDatum = new DateTime(2000, 1, 1);
        private int _aankoopId;
        private Aankoop _aankoop;
        private Aanvraag _aanvraag;
        private static readonly CultureInfo cultuur = new CultureInfo("nl-BE");

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
            ButtonLogica();
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
            ddlStatus.DataSource = StatusAankoopManager.GetAllStatusAankoop();
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

                txtGoedgekeurdBedrag.Text = _aankoop.BudgetToegekend.ToString("N2", cultuur);
                txtExBtw.Text = _aankoop.BedragExBtw.ToString("N2", cultuur);
                txtBtwPercentage.Text = _aankoop.BTWPercentage.ToString("N2", cultuur);
                txtBedragTransfer.Text = _aankoop.BedragTransfer.ToString("N2", cultuur);

                dtpBestelDatum.Value = _aankoop.BestellingsDatum ?? OnbekendeDatum;
                dtpVerwachteDatum.Value = _aankoop.VerwachteLeveringsDatum ?? OnbekendeDatum;
                dtpEffectieveDatum.Value = _aankoop.EffectieveLeveringsDatum ?? OnbekendeDatum;

                ddlLeverancier.SelectedValue = _aankoop.LeverancierId;
                txtAanvraagId.Text = _aankoop.AanvraagId.ToString();
                txtBestelbonNummer.Text = _aankoop.BestelbonNummer;
                chBFactuur.Checked = _aankoop.Factuur;
                txtFactuurnummer.Text = _aankoop.FactuurNummer;
                txtInternNummer.Text = _aankoop.InternNummer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij het laden van de aankoop: " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BerekenBedragen()
        {
            decimal exBTW = ParseDecimal(txtExBtw.Text);
            decimal btw = ParseDecimal(txtBtwPercentage.Text);
            decimal transfer = ParseDecimal(txtBedragTransfer.Text);
            decimal goedgekeurd = ParseDecimal(txtGoedgekeurdBedrag.Text);

            decimal bedragInBTW = exBTW * (1 + (btw / 100));
            txtIncBtw.Text = bedragInBTW.ToString("N2", cultuur);

            decimal saldo = goedgekeurd - (bedragInBTW + transfer);
            lblBedragSaldo.Size = new Size(150,31);
            lblBedragSaldo.Text = saldo.ToString("N2", cultuur);

            if (saldo >= 0)
            {
                lblBedragSaldo.BackColor = Color.LightGreen;
                lblBedragSaldo.ForeColor = Color.Black;
                lblBedragSaldo.Font = new Font(lblBedragSaldo.Font, FontStyle.Bold);
            }
            else
            {
                lblBedragSaldo.BackColor = Color.Red;
                lblBedragSaldo.ForeColor = Color.White;
                lblBedragSaldo.Font = new Font(lblBedragSaldo.Font, FontStyle.Bold);
            }
        }
        private decimal ParseDecimal(string value)
        {
            return decimal.TryParse(value, NumberStyles.Any, new CultureInfo("nl-BE"), out decimal result) ? result : 0;
        }

        private void ButtonLogica()
        {
            bool afgesloten = ddlStatus.Text == "Afgesloten";
            bool gepland = ddlStatus.Text == "Gepland";
            
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

            btnBewaren.Enabled = !afgesloten;
            btnVerwijder.Enabled = gepland && !afgesloten;

        }
        private void btnBewaren_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Checks()) return;

                _aankoop.Omschrijving = rtxtOmschrijving.Text;
                _aankoop.StatusAankoopId = Convert.ToInt32(ddlStatus.SelectedValue);
                _aankoop.BedragExBtw = ParseDecimal(txtExBtw.Text);
                _aankoop.BTWPercentage = (int)ParseDecimal(txtBtwPercentage.Text);
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
                _aankoop.BestelbonNummer = txtBestelbonNummer.Text;
                _aankoop.Factuur = chBFactuur.Checked;
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

        private void btnVerwijder_Click(object sender, EventArgs e)
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

        private void btnLeveranciers_Click(object sender, EventArgs e)
        {
            int? vorigeLeverancierId = ddlLeverancier.SelectedValue as int?;

            using (var frm = new frmBeheerLeverancier())
            {
                frm.ShowDialog();
            }

            ddlLeverancier.DataSource = LeverancierManager.GetAllLeveranciers();
            ddlLeverancier.DisplayMember = "Leverancier";
            ddlLeverancier.ValueMember = "Id";

            if (vorigeLeverancierId.HasValue)
            {
                ddlLeverancier.SelectedValue = vorigeLeverancierId.Value;
            }
            else
            {
                ddlLeverancier.SelectedIndex = 0;
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

            decimal bedragEx = ParseDecimal(txtExBtw.Text);
            decimal btw = ParseDecimal(txtBtwPercentage.Text);

            if (bedragEx < 0)
            {
                MessageBox.Show("Bedrag excl. BTW mag niet negatief zijn.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExBtw.Focus();
                return false;
            }

            if (btw < 0 || btw > 100)
            {
                MessageBox.Show("BTW percentage moet tussen 0 en 100 liggen.", "MIA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBtwPercentage.Focus();
                return false;
            }
            return true;
        }

        private void txtExBtw_Leave(object sender, EventArgs e)
        {
            decimal waarde = ParseDecimal(txtExBtw.Text);

            txtExBtw.Text = waarde.ToString("N2", cultuur);

            LeegGeldVak(txtExBtw);
            BerekenBedragen();
        }

        private void txtBtwPercentage_Leave(object sender, EventArgs e)
        {
            decimal waarde = ParseDecimal(txtBtwPercentage.Text);

            txtBtwPercentage.Text = waarde.ToString("N2", cultuur);

            if (string.IsNullOrWhiteSpace(txtBtwPercentage.Text))
                txtBtwPercentage.Text = "0";

            BerekenBedragen();
        }

        private void LeegGeldVak(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
                tb.Text = 0m.ToString("N2", cultuur);
            else
                tb.Text = ParseDecimal(tb.Text).ToString("N2", cultuur);
        }

    }
}
