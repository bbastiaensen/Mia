using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MiaClient
{
    public partial class frmGeplandeAankopen : Form
    {
        public frmGeplandeAankopen()
        {
            InitializeComponent();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            //just a way to make the wait seem less long
            lblWacht.Visible = true;
            lblWacht.Text = "Dit kan even duren";
            lblLaad1.Visible = true;
            lblLaad1.Text = "Connectie maken met Excel..";
            //makes a new excel app
            var app = new Excel.Application();
            //opens the app when you press save (if true)
            app.Visible = false;
            //stuffs for commands
            object Nothing = System.Reflection.Missing.Value;
            Excel.Workbook workBook = app.Workbooks.Add(Nothing);
            lblLaad1.Text = "Verwerken...";
            lblWacht.Text = "Dit kan lang duren";
            Excel.Worksheet worksheet = (Excel.Worksheet)workBook.Sheets[1];
            lblLaad1.Text = "Data ophalen...";
            lblWacht.Text = "Dit kan even duren";
            // Getting data
            List<Richtperiode> rp = RichtperiodeManager.GetRichtperiodes();
            List<Aanvraag> aanvragen = AanvraagManager.GetRichtPeriodeAsc();
            List<Aanvraag> Status = new List<Aanvraag>();
            //Making sure the data is in the right year, and it's refused
            foreach (Aanvraag a in aanvragen)
            {
                if (/*StatusAanvraagManager.GetStatusAanvraagById(a.StatusAanvraagId).Naam == "Bekrachtigd" &&*/ a.Financieringsjaar == DateTime.Parse(DateTime.Now.ToString()).Year.ToString())
                {
                    Status.Add(a);
                }
            }
            //setting up the numbers
            //color for the red/green
            Color c = new Color();
            //position for the data
            int add = 2;
            //position
            int ri = 0;
            //offset by data
            int rs = 2;
            //for the layout
            bool even = true;
            //loops over the periods (m=month)
            int m = 0;
            for (m = 1; m <= rp.Count; m++)
            {
                lblLaad1.Text = "Excel opstellen...";
                bool meh = true;
                //ri = position in int, r = position in string
                ri = m + rs;
                //the name of the month
                worksheet.get_Range("A" + ri, "A" + ri).Value = rp[m-1].Naam;
                //total of the month
                decimal tot = 0;
                //background color for months in Excel file
                ColorExcel(ri, m, worksheet, even, meh);
                //Making sure the data in the right month
                meh = false;
                List<Aanvraag> InPer = new List<Aanvraag>();
                lblLaad1.Text = "Data in Excel verwerken " + /*(" + finJaar + ")*/ "...";
                foreach (Aanvraag a in Status)
                {
                    if(!(a.RichtperiodeId < m))
                    {
                        if (a.RichtperiodeId == m)
                        {
                            InPer.Add(a);
                        }
                        if (a.RichtperiodeId > m)
                        {
                            break;
                        }
                    }
                }
                //going over the data
                for (int p = 1; p <= InPer.Count; p++)
                {
                    //add = position of data, rs=offset by data
                    add = ri + p;
                    rs++;
                    //calculates the price
                    decimal prijs = InPer[p - 1].AantalStuk * InPer[p - 1].PrijsIndicatieStuk;
                    //if Aankoop in the database has something :(
                    //Aankoop a = AankoopManager.GetAankoopByAanvraagId(InPer[p - 1].Id);
                    //decimal prijs = (a.BedragExBtw / 100)* a.BTWPercentage; )

                    //puts data on the right position (based on add)
                    worksheet.get_Range("B" + add, "B" + add).Value = InPer[p - 1].Titel;
                    worksheet.get_Range("C" + add, "C" + add).Value = InPer[p - 1].Gebruiker;
                    Aankoper aankoper = AankoperManager.GetAankoperById(InPer[p - 1].AankoperId);
                    worksheet.get_Range("D" + add, "D" + add).Value = aankoper.Voornaam + aankoper.Achternaam;
                    worksheet.get_Range("E" + add, "E" + add).Value = InPer[p - 1].BudgetToegekend;
                    worksheet.get_Range("F" + add, "F" + add).Value = prijs;
                    worksheet.get_Range("G" + add, "G" + add).Formula = ("=E"+add + "-" + "F"+add);
                    if ((InPer[p - 1].BudgetToegekend - prijs) >= 0)
                    {
                        c = StringToColor("#2FFF2F");
                    }
                    else
                    {
                        c = StringToColor("#B61638");
                    }
                    worksheet.get_Range("G" + add, "G" + add).Font.Color = c;
                    DateTime pl = new DateTime();
                    if (InPer[p - 1].Planningsdatum != pl)
                    {
                        worksheet.get_Range("H" + add, "H" + add).Value = InPer[p - 1].Planningsdatum;
                    }
                    else
                    {
                        worksheet.get_Range("H" + add, "H" + add).Value = "geen ingesteld";
                    }
                    if (InPer[p - 1].OpmerkingenResultaat != null)
                    {
                        worksheet.get_Range("D" + add, "D" + add).Value = InPer[p - 1].OpmerkingenResultaat;
                    }
                    //total for the month
                    tot += InPer[p - 1].BudgetToegekend - prijs;
                    //background color for data in Excel file
                    ColorExcel(add, m, worksheet, even, meh);
                    //voor opmaak
                    if (even)
                    {
                        even = false;
                    }
                    else
                    {
                        even = true;
                    }
                }
                rs++;
                ColorExcel((m + rs), m, worksheet, even, meh);
                //puts total of month on it's spot, makes it bold
                if (tot >= 0)
                {
                    c = StringToColor("#2FFF2F");
                }
                else
                {
                    c = StringToColor("#B61638");
                }
                worksheet.get_Range("G" + ri, "G" + ri).Font.Color = c;
                worksheet.get_Range("G" + ri, "G" + ri).Value = tot;
                worksheet.get_Range("A" + ri, "H" + ri).Font.Bold = true;

            }
            lblWacht.Text = "Bijna klaar!";

            //===============just layout=================

            //title
            worksheet.Cells[1, 1] = "Geplande aankopen";
            worksheet.Cells[2, 1] = "Maand";
            worksheet.Cells[2, 2] = "Titel";
            worksheet.Cells[2, 3] = "Aanvrager";
            worksheet.Cells[2, 4] = "Aakoper";
            worksheet.Cells[2, 5] = "Goedgekeurd bedrag";
            worksheet.Cells[2, 6] = "Aangekochte bedrag";
            worksheet.Cells[2, 7] = "Overschreden/niet gebruik bedrag";
            worksheet.Cells[2, 8] = "PlanningsDatum";
            //layout title
            worksheet.get_Range("A1", "A1").Font.Bold = true;
            worksheet.get_Range("A1", "A1").Font.Underline = true;
            //layout data
            worksheet.get_Range("B1", "B200").ColumnWidth = 55;
            worksheet.get_Range("C1", "H200").ColumnWidth = 20;
            worksheet.get_Range("E2", "G200").NumberFormat = "0.00 €";
            // Show save file dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //savefile dialog inputs
            saveFileDialog1.FileName = "Overzicht_Geplande_Aankopen";
            saveFileDialog1.Filter = "excel files (*.xlsx)|*.xlsx";
            saveFileDialog1.FilterIndex = 1;
            //shows save file dialog
            lblWacht.Visible = false;
            lblLaad1.Visible = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //it doesn't like onedrive(saves the Excel file)
                try
                {
                    worksheet.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, false, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                    workBook.Close(false, saveFileDialog1.FileName, false);
                    Marshal.ReleaseComObject(workBook);
                    Marshal.ReleaseComObject(worksheet);
                    app.Quit();
                    MessageBox.Show("Het Excel document staat klaar!");
                }
                catch
                {
                    MessageBox.Show("Excel doesn't like onedrive :(");
                }
            }
        }
        public static Color StringToColor(string colorStr)
        {
            //a way to go from string to system.Color
            TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));
            Color result = (Color)cc.ConvertFromString(colorStr);
            return result;
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
            //for the color
            Color c = new Color();
            //if the data is the richtperiode
            c = text;
            
            ws.get_Range("A" + pos, "F" + pos).Font.Color = c;
            ws.get_Range("H" + pos, "H" + pos).Font.Color = c;
            if (m)
            {
                ws.get_Range("A" + pos, "A" + pos).Font.Bold = true;
                //if the month is even
                if (month % 2 == 0)
                {
                    c = MaandL;
                    ws.get_Range("A" + pos, "H" + pos).Interior.Color = c;
                }
                //month is uneven
                else
                {
                    c = MaandD;
                    ws.get_Range("A" + pos, "H" + pos).Interior.Color = c;
                }
            }
            //if the data isnt' the richtperiode
            else
            {
                //if the month is even
                if (month % 2 == 0)
                {
                    //if the position is even(in comparison to the month)
                    if (even)
                    {
                        c = DataL1;
                        ws.get_Range("A" + pos, "H" + pos).Interior.Color = c;
                    }
                    else
                    {
                        c = DataL2;
                        ws.get_Range("A" + pos, "H" + pos).Interior.Color = c;
                    }

                }
                //month is uneven
                else
                {
                    //if the position is even(in comparison to the month
                    if (even)
                    {
                        c = DataD1;
                        ws.get_Range("A" + pos, "H" + pos).Interior.Color = c;
                    }
                    else
                    {
                        c = DataD2;
                        ws.get_Range("A" + pos, "H" + pos).Interior.Color = c;
                    }
                }
            }
        }

        private void frmGeplandeAankopen_Load(object sender, EventArgs e)
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

        private void frmGeplandeAankopen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }
    }
}
