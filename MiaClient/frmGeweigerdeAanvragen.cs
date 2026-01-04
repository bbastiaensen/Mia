using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MiaClient
{
    public partial class frmGeweigerdeAanvragen : Form
    {
        public frmGeweigerdeAanvragen()
        {
            InitializeComponent();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // --- Controle: jaar gekozen? ---
            if (cmbJaar.SelectedIndex < 0)
            {
                MessageBox.Show("Gelieve een financieringsjaar te selecteren.");
                return;
            }

            int gekozenJaar = Convert.ToInt32(cmbJaar.SelectedValue);

            //just a way to make the wait seem minder lang
            lblWacht.Visible = true;
            lblWacht.Text = "Dit kan even duren";
            lblLaad1.Visible = true;
            lblLaad1.Text = "Connectie maken met Excel..";

            var app = new Excel.Application();
            app.Visible = false;

            object Nothing = Missing.Value;
            Excel.Workbook workBook = app.Workbooks.Add(Nothing);

            lblLaad1.Text = "Verwerken...";
            lblWacht.Text = "Dit kan lang duren";

            Excel.Worksheet worksheet = (Excel.Worksheet)workBook.Sheets[1];

            lblLaad1.Text = "Data ophalen...";
            lblWacht.Text = "Dit kan even duren";

            List<Richtperiode> rp = RichtperiodeManager.GetRichtperiodes();
            List<Aanvraag> alleAanvragen = AanvraagManager.GetAanvragenByRichtPeriodeAsc();
            List<Aanvraag> Status = new List<Aanvraag>();

            // Alleen geweigerde aanvragen
            foreach (Aanvraag a in alleAanvragen)
            {
                string naam = StatusAanvraagManager.GetStatusAanvraagById(a.StatusAanvraagId).Naam;
                if (naam == "niet bekrachtigd" || naam == "Niet goedgekeurd")
                {
                    Status.Add(a);
                }
            }

            // Filter op het geselecteerde jaar
            List<Aanvraag> inJaar = Status
                .Where(a => Convert.ToInt32(a.Financieringsjaar) == gekozenJaar)
                .ToList();

            string finJaar = gekozenJaar.ToString();
            int add = 2;
            int ri = 0;
            int rs = 2;
            bool even = true;

            lblLaad1.Text = "Excel opstellen...";

            for (int m = 1; m <= rp.Count; m++)
            {
                bool meh = true;
                ri = m + rs;

                worksheet.get_Range("A" + ri, "A" + ri).Value = rp[m - 1].Naam + "_" + finJaar;

                decimal tot = 0;
                ColorExcel(ri, m, worksheet, even, meh);

                meh = false;
                List<Aanvraag> InPer = inJaar.Where(a => a.RichtperiodeId == m).ToList();

                lblLaad1.Text = "Data in Excel verwerken (" + finJaar + ")...";

                for (int p = 0; p < InPer.Count; p++)
                {
                    add = ri + p + 1;
                    rs++;

                    decimal prijs = InPer[p].AantalStuk + InPer[p].PrijsIndicatieStuk;

                    worksheet.get_Range("B" + add, "B" + add).Value = InPer[p].Titel;
                    worksheet.get_Range("C" + add, "C" + add).Value = prijs;

                    if (!string.IsNullOrEmpty(InPer[p].OpmerkingenResultaat))
                        worksheet.get_Range("D" + add, "D" + add).Value = InPer[p].OpmerkingenResultaat;

                    tot += prijs;
                    ColorExcel(add, m, worksheet, even, meh);

                    even = !even;
                }

                rs++;
                ColorExcel((m + rs), m, worksheet, even, meh);

                worksheet.get_Range("C" + ri, "C" + ri).Value = tot;
                worksheet.get_Range("C" + ri, "C" + ri).Font.Bold = true;
            }

            // Layout
            worksheet.Cells[1, 1] = "Geweigerde Aanvragen";
            worksheet.get_Range("A1", "A1").Font.Bold = true;
            worksheet.get_Range("A1", "A1").Font.Underline = true;

            worksheet.get_Range("B1", "B200").ColumnWidth = 55;
            worksheet.get_Range("D1", "D200").ColumnWidth = 20;
            worksheet.get_Range("C2", "C200").NumberFormat = "0.00 €";

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "Overzicht_geweigerde_aanvragen_" + gekozenJaar;
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx";

            lblWacht.Visible = false;
            lblLaad1.Visible = false;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    worksheet.SaveAs(saveFileDialog1.FileName);
                    workBook.Close(false);
                    Marshal.ReleaseComObject(workBook);
                    Marshal.ReleaseComObject(worksheet);
                    app.Quit();
                    MessageBox.Show(
                        $"Het Excel-document met de geweigerde aanvragen voor het financieringsjaar {gekozenJaar} staat klaar!",
                        "MIA - Geweigerde Aanvragen",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch
                {
                    MessageBox.Show("Excel doesn't like OneDrive :(");
                }
            }
        }

        public static Color StringToColor(string colorStr)
        {
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            return (Color)cc.ConvertFromString(colorStr);
        }

        Color text = StringToColor(ParameterManager.GetParameterByCode("TekstExcel").Waarde);
        Color MaandL = StringToColor(ParameterManager.GetParameterByCode("MaandExcelL").Waarde);
        Color MaandD = StringToColor(ParameterManager.GetParameterByCode("MaandExcelD").Waarde);
        Color DataL1 = StringToColor(ParameterManager.GetParameterByCode("DataExcelL1").Waarde);
        Color DataL2 = StringToColor(ParameterManager.GetParameterByCode("DataExcelL2").Waarde);
        Color DataD1 = StringToColor(ParameterManager.GetParameterByCode("DataExcelD1").Waarde);
        Color DataD2 = StringToColor(ParameterManager.GetParameterByCode("DataExcelD2").Waarde);

        public void ColorExcel(int pos, int month, Excel.Worksheet ws, bool even, bool m)
        {
            Color c = text;
            ws.get_Range("A" + pos, "D" + pos).Font.Color = c;

            if (m)
            {
                ws.get_Range("A" + pos, "A" + pos).Font.Bold = true;

                if (month % 2 == 0)
                    c = MaandL;
                else
                    c = MaandD;

                ws.get_Range("A" + pos, "D" + pos).Interior.Color = c;
            }
            else
            {
                if (month % 2 == 0)
                    c = even ? DataL1 : DataL2;
                else
                    c = even ? DataD1 : DataD2;

                ws.get_Range("A" + pos, "D" + pos).Interior.Color = c;
            }
        }

        private void frmGeweigerdeAanvragen_Load(object sender, EventArgs e)
        {

            cmbJaar.ValueMember = "Financieringsjaar";
            cmbJaar.DisplayMember = "Financieringsjaar";
            cmbJaar.DataSource = AanvraagManager.GetAlleFinancieringsjaren();

            // ComboBox leeg tonen
            cmbJaar.SelectedIndex = -1;

            // Excel-knop uitschakelen tot gebruiker iets kiest
            btnExcel.Enabled = false;


        }
        private void frmGeweigerdeAanvragen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }
        private void cmbJaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExcel.Enabled = !string.IsNullOrEmpty(cmbJaar.SelectedValue.ToString());
        }
    }
}
