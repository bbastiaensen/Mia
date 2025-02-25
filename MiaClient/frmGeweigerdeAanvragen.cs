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
            DateTime begin = DateTime.Now;
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
            DateTime ehb = DateTime.Now;
            lblLaad1.Text = "Verwerken...";
            lblWacht.Text = "Dit kan lang duren";
            Excel.Worksheet worksheet = (Excel.Worksheet)workBook.Sheets[1];
            DateTime ehe = DateTime.Now;
            lblLaad1.Text = "Data ophalen...";
            lblWacht.Text = "Dit kan even duren";
            // Getting data
            List<Richtperiode> rp = RichtperiodeManager.GetRichtperiodes();
            List<Aanvraag> aanvragen = AanvraagManager.GetRichtPeriodeAsc();
            List<Aanvraag> Status = new List<Aanvraag>();
            //Making sure the data is in the right year, and it's refused
            foreach (Aanvraag a in aanvragen)
            {
                if (StatusAanvraagManager.GetStatusAanvraagById(a.StatusAanvraagId).Naam == "niet bekrachtigd" || StatusAanvraagManager.GetStatusAanvraagById(a.StatusAanvraagId).Naam == "Niet goedgekeurd")
                {
                    Status.Add(a);
                }
            }
            //current year
            int jaar = DateTime.Now.Year;
            //total offset by year
            int js = 0;
            for (int j = jaar; j <= jaar + 4; j++)
            {
                lblLaad1.Text = "Excel opstellen...";
                //making sure it's in the right year
                List<Aanvraag> inJaar = new List<Aanvraag>();
                foreach (Aanvraag a in Status)
                {
                    if (!(Convert.ToInt32(a.Financieringsjaar) < j))
                    {
                        if (Convert.ToInt32(a.Financieringsjaar) == j)
                        {
                            inJaar.Add(a);
                        }
                        if (Convert.ToInt32(a.Financieringsjaar) > j)
                        {
                            break;
                        }
                    }
                }
                //setting up the numbers
                //year in string
                string finJaar = j.ToString();
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
                    bool meh = true;
                    //ri = position in int, r = position in string
                    ri = m + rs + js;
                    //the name of the month
                    worksheet.get_Range("A" + ri, "A" + ri).Value = rp[m - 1].Naam + "_" + finJaar;
                    //total of the month
                    decimal tot = 0;
                    //background color for months in Excel file
                    ColorExcel(ri, m, worksheet, even, meh);
                    //Making sure the data in the right month
                    meh = false;
                    List<Aanvraag> InPer = new List<Aanvraag>();
                    lblLaad1.Text = "Data in Excel verwerken(" + finJaar + ")...";
                    foreach (Aanvraag a in inJaar)
                    {
                        if (!(a.RichtperiodeId < m))
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
                        rs ++;
                        //calculates the price
                        decimal prijs = InPer[p-1].AantalStuk + InPer[p-1].PrijsIndicatieStuk;
                        //puts data on the right position (based on add)
                        worksheet.get_Range("B" + add, "B" + add).Value = InPer[p - 1].Titel;
                        worksheet.get_Range("C" + add, "C" + add).Value = (prijs);
                        if (InPer[p - 1].OpmerkingenResultaat != null)
                        {
                            worksheet.get_Range("D" + add, "D" + add).Value = InPer[p - 1].OpmerkingenResultaat;
                        }
                        //total for the month
                        tot += prijs;
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
                    ColorExcel((m + rs + js), m, worksheet, even, meh);
                    //puts total of month on it's spot, makes it bold
                    worksheet.get_Range("C" + ri, "C" + ri).Value = tot;
                    worksheet.get_Range("C" + ri, "C" + ri).Font.Bold = true;
                }
                //calculating the offset of the year
                js = (rs-m-1) + ri;
                if(j > jaar + 2)
                {
                    lblWacht.Text = "Bijna klaar!";
                }
            }
            //===============just layout=================
            //title
            worksheet.Cells[1, 1] = "Geweigerde Aanvragen ";
            //layout title
            worksheet.get_Range("A1", "A1").Font.Bold = true;
            worksheet.get_Range("A1", "A1").Font.Underline = true;
            //layout data
            worksheet.get_Range("B1", "B200").ColumnWidth = 55;
            worksheet.get_Range("D1", "D200").ColumnWidth= 20;
            worksheet.get_Range("C2", "C200").NumberFormat = "0.00 €";

            // Show save file dialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //savefile dialog inputs
            saveFileDialog1.FileName = "Overzicht_geweigerde_aanvragen";
            saveFileDialog1.Filter = "excel files (*.xlsx)|*.xlsx";
            saveFileDialog1.FilterIndex = 1;
            //shows save file dialog
            lblWacht.Visible = false;
            lblLaad1.Visible = false;
            DateTime end = DateTime.Now;
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

            ws.get_Range("A" + pos, "D" + pos).Font.Color = c;
            if (m)
            {
                ws.get_Range("A" + pos, "A" + pos).Font.Bold = true;
                //if the month is even
                if (month % 2 == 0)
                {
                    c = MaandL;
                    ws.get_Range("A" + pos, "D" + pos).Interior.Color = c;
                }
                //month is uneven
                else
                {
                    c = MaandD;
                    ws.get_Range("A" + pos, "D" + pos).Interior.Color = c;
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
                        ws.get_Range("A" + pos, "D" + pos).Interior.Color = c;
                    }
                    else
                    {
                        c = DataL2;
                        ws.get_Range("A" + pos, "D" + pos).Interior.Color = c;
                    }

                }
                //month is uneven
                else
                {
                    //if the position is even(in comparison to the month
                    if (even)
                    {
                        c = DataD1;
                        ws.get_Range("A" + pos, "D" + pos).Interior.Color = c;
                    }
                    else
                    {
                        c = DataD2;
                        ws.get_Range("A" + pos, "D" + pos).Interior.Color = c;
                    }
                }
            }
        }
        private void frmGeweigerdeAanvragen_Load(object sender, EventArgs e)
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

        private void frmGeweigerdeAanvragen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }
    }
}
