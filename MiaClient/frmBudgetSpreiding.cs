using MiaLogic.Manager;
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
            int m = 0;
            for (int i = 0; m < 12; i++)
            {
                string r1 = "A" + (i + 2);
                string r2 = "B" + (i + 2);
                string r3 = "C" + (i + 2);
                if (m % 2 == 0 && m != 0)
                {
                    worksheet.get_Range(r1, r3).Interior.Color = Excel.XlRgbColor.rgbGrey;
                }
                else
                {
                    worksheet.get_Range(r1, r3).Interior.Color = Excel.XlRgbColor.rgbWhite;
                }
                if (i % 5 == 0 || i == 0)
                {

                    worksheet.get_Range(r1, r1).Value = GetMonth(m);
                    worksheet.get_Range(r3, r3).Value = "totaal";
                    worksheet.get_Range(r3, r3).Font.Bold = true;
                    m++;
                }
                else
                {
                    Random rnd = new Random();
                    int g = rnd.Next(1, 10);
                    worksheet.get_Range(r2, r2).Value = "titel";
                    worksheet.get_Range(r3, r3).Value = g;
                }


            }
            //layout
            string richtper = cmbFinancieringsjaar.SelectedItem.ToString();
            //title
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
            public string GetMonth(int i)
            {
            switch (i)
            {
                case 1:
                    return "januari";
                case 2:
                    return "februari";
                case 3:
                    return "maart";
                case 4:
                    return "april";
                case 5:
                    return "mei";
                case 6:
                    return "juni";
                case 7:
                    return "juli";
                case 8:
                    return "augustus";
                case 9:
                    return "september";
                case 10:
                    return "oktober";
                case 11:
                    return "november";
                case 12:
                    return "december";
                default:
                    return "";
            }
        }
    }
}

