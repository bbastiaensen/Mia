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
using Excel = Microsoft.Office.Interop.Excel;

namespace MiaClient
{
    public partial class frmBudgetspreiding : Form
    {
        public frmBudgetspreiding()
        {
            InitializeComponent();
        }

        private void frmBudgetspreiding_Load(object sender, EventArgs e)
        {
            CreateUI();

            List<string> jaren = FinancieringsjaarManager.GetFinancieringsjaren();
            foreach (string jaar in jaren)
            {
                cmbFinancieringsjaar.Items.Add( jaar );
            }
        }

        private void frmBudgetSpreiding_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void CreateUI()
        {
            //Achtergrondkleur instellen op parameterwaarde
            this.BackColor = StyleParameters.Achtergrondkleur;

            //Opmaak buttons instellen op parameterwaardes
            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }
        }

        private void btnExporteer_Click(object sender, EventArgs e)
        {
            //makes a new excel app
            var app = new Excel.Application();
            //opens the app when you press save (if true)
            app.Visible = false;
            //stuffs for commands
            object Nothing = System.Reflection.Missing.Value;
            Excel.Workbook workBook = app.Workbooks.Add(Nothing);
            Excel.Worksheet worksheet = (Excel.Worksheet)workBook.Sheets[1];
            // Write data+layout
            List<Richtperiode> rp = RichtperiodeManager.GetRichtperiodes();
            List<Aanvraag> aanvragen = AanvraagManager.GetAanvragen();
            List<Aanvraag> inJaar = new List<Aanvraag>();
            foreach (Aanvraag a in aanvragen) {
                try { 
                    if (a.Financieringsjaar == cmbFinancieringsjaar.SelectedItem.ToString())
                    {
                        inJaar.Add(a);
                    }
                } 
                catch {
                    MessageBox.Show("Selecteer een financieringsjaar aub");
                }
            }
            int add = 0;
            for (int m = 1; m < rp.Count; m++)
            {
                string r = (m + 2 +add).ToString();
                if (m % 2 == 0)
                {
                    worksheet.get_Range("A"+r,"C"+r).Interior.Color = Excel.XlRgbColor.rgbGrey;
                }
                else
                {
                    worksheet.get_Range("A"+r, "C"+r).Interior.Color = Excel.XlRgbColor.rgbWhite;
                }
                worksheet.get_Range("A" + r, "A" + r).Value = RichtperiodeManager.GetRichtperiodeById(m).Naam;
                decimal tot = 0;
                List<Aanvraag> InPer = new List<Aanvraag>();
                foreach (Aanvraag a in inJaar)
                {
                    if (a.RichtperiodeId == m)
                    {
                        InPer.Add(a);
                    }
                }
                for (int j = 0; j < InPer.Count; j++)
                {
                    int rs = Convert.ToInt32(r);
                    add = rs + j;
                    decimal prijs = InPer[j].AantalStuk + InPer[j].PrijsIndicatieStuk;
                    worksheet.get_Range("B"+add+r, "B"+add+r).Value = InPer[j].Titel;
                    worksheet.get_Range("C"+add+r, "C"+add+r).Value = (prijs);
                    tot += prijs;
                }
                worksheet.get_Range("C"+r, "C"+r).Value = tot;
                worksheet.get_Range("C"+r, "C"+r).Font.Bold = true;
            }
            //title
            string richtper = cmbFinancieringsjaar.SelectedItem.ToString();

            worksheet.Cells[1, 1] = "Financieringsjaar: " + richtper;
            worksheet.get_Range("A1", "A1").Font.Bold = true;
            worksheet.get_Range("A1", "A1").Font.Underline = true;
            //B
            worksheet.get_Range("B1", "B200").ColumnWidth = 55;
            worksheet.get_Range("C2", "C200").NumberFormat = "0.00 €";
            //
            // Show save file dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //savefile dialog inputs
            saveFileDialog1.FileName = "Budgetoverzicht-" + richtper;
            saveFileDialog1.Filter = "excel files (*.xlsx)|*.xlsx";
            saveFileDialog1.FilterIndex = 1;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                worksheet.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                workBook.Close(false, Type.Missing, Type.Missing);
                app.Quit();
                MessageBox.Show("Het Excel document staat klaar!");
            }
        }

    }
}

