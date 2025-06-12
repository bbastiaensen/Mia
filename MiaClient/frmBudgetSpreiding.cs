using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MiaClient
{
    public partial class frmBudgetspreiding : Form
    { 
        int i = 0;
        List<Aanvraag> Aanvragen   = null;
        List<Richtperiode> richtperiodes = null;
        Aanvraag zoinks = null;
        Richtperiode richtperiode = null;
        List<decimal> Budgets = new List<decimal>();
        List<string> Titels = new List<string>();
        decimal Totaal = 0;
        int xPos = 0;
        int yPos = 0;
        public frmBudgetspreiding()
        {
            InitializeComponent();
        }

        private void frmBudgetspreiding_Load(object sender, EventArgs e)
        {
            CreateUI();

            List<string> finJaren = AanvraagManager.GetAlleFinancieringsjaren();
            cmbFinancieringsjaar.ValueMember = "Financieringsjaar";
            cmbFinancieringsjaar.DisplayMember = "Financieringsjaar";
            cmbFinancieringsjaar.DataSource = finJaren;


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
            foreach (var btn in this.Controls.OfType<System.Windows.Forms.Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }

            foreach (var gb in this.Controls.OfType<GroupBox>())
            {
                foreach (var btn in gb.Controls.OfType<System.Windows.Forms.Button>())
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = StyleParameters.ButtonBack;
                    btn.ForeColor = StyleParameters.Buttontext;
                }
            }
        }

        private void btnExporteer_Click(object sender, EventArgs e)
        {
            try
            {
                lblWacht.Visible = true;
                //makes a new excel app
                var app = new Excel.Application();
                //opens the app when you press save (if true)
                app.Visible = false;
                //stuffs for commands
                object Nothing = System.Reflection.Missing.Value;
                Excel.Workbook workBook = app.Workbooks.Add(Nothing);
                Excel.Worksheet worksheet = (Excel.Worksheet)workBook.Sheets[1];
                // Getting data
                List<Richtperiode> rp = RichtperiodeManager.GetRichtperiodes();
                List<Aanvraag> aanvragen = AanvraagManager.GetAanvragenByRichtPeriodeAsc();
                List<Aanvraag> inJaar = new List<Aanvraag>();
                //for charts===
                List<StatusAanvraag> stat = StatusAanvraagManager.GetStatusAanvragen();
                int[] hStatus = new int[stat.Count()];
                //============
                //Making sure the data is in the right year
                if (cmbFinancieringsjaar.SelectedItem == null)
                {
                    MessageBox.Show("Selecteer eerst een financieringsjaar", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblWacht.Visible = false;
                    return;
                }
                foreach (Aanvraag a in aanvragen)
                {
                    try
                    {
                        if (a.Financieringsjaar == cmbFinancieringsjaar.SelectedItem.ToString())
                        {
                            inJaar.Add(a);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                //setting up the numbers
                //position for the data
                int add = 2;
                //position
                int ri = 0;
                //offset by data
                int rs = 2;
                bool even = true;
                //loops over the periods (m=month)
                for (int m = 1; m <= rp.Count; m++)
                {
                    bool meh = true;
                    //ri = position in int, r = position in string
                    ri = m + rs;
                    //the name of the month
                    worksheet.get_Range("A" + ri, "A" + ri).Value = rp[m - 1].Naam;
                    //total of the month
                    decimal tot = 0;
                    //background color for months in Excel file
                    ColorExcel(ri, m, worksheet, even, meh);
                    //Making sure the data in the right month
                    meh = false;
                    List<Aanvraag> InPer = new List<Aanvraag>();
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
                    for (int j = 0; j < InPer.Count; j++)
                    {
                        //add = position of data, rs=offset by the data
                        add = ri + j + 1;
                        rs += j;
                        //calculates the price
                        decimal prijs = InPer[j].BudgetToegekend;
                        //puts data on the right position (based on add)
                        worksheet.get_Range("B" + add, "B" + add).Value = InPer[j].Titel;
                        worksheet.get_Range("C" + add, "C" + add).Value = (prijs);
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
                        //========for charts==========
                        int statusId = InPer[j].StatusAanvraagId;

                        hStatus[statusId] += 1;
                        //==================
                    }
                    rs++;
                    ColorExcel((m + rs), m, worksheet, even, meh);
                    //puts total of month on it's spot, makes it bold
                    worksheet.get_Range("C" + ri, "C" + ri).Value = tot;
                    worksheet.get_Range("C" + ri, "C" + ri).Font.Bold = true;
                }
                //===============just layout=================
                //title
                string richtper = cmbFinancieringsjaar.SelectedItem.ToString();

                worksheet.Cells[1, 1] = "Financieringsjaar: " + richtper;
                //layout title
                worksheet.get_Range("A1", "A1").Font.Bold = true;
                worksheet.get_Range("A1", "A1").Font.Underline = true;
                //layout data
                worksheet.get_Range("B1", "B200").ColumnWidth = 55;
                worksheet.get_Range("C2", "C200").NumberFormat = "0.00 €";
                //=============testing charts======
                Excel.Range chartRange;

                Excel.ChartObjects xlCharts = (Excel.ChartObjects)worksheet.ChartObjects(Type.Missing);
                Excel.ChartObject chartObj = (Excel.ChartObject)xlCharts.Add(468, 160, 348, 268);
                Excel.Chart chart = chartObj.Chart;


                chartRange = worksheet.Range[worksheet.Cells[3, 6], worksheet.Cells[(2 + stat.Count), 7]];
                chart.SetSourceData(chartRange, Type.Missing);
                chart.ChartType = Excel.XlChartType.xlPie;
                chart.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowLabelAndPercent,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                            Type.Missing);
                chart.ApplyLayout(1);
                chart.ChartTitle.Text = "Status in elke aanvraag(jaar " + richtper + ")";
                for (int i = 1; i < stat.Count; i++)
                {
                    int p = i + 3;
                    string stt = StatusAanvraagManager.GetStatusAanvraagById(i).Naam;
                    worksheet.get_Range("F" + p, "F" + p).Value = stt;
                    worksheet.get_Range("G" + p, "G" + p).Value = hStatus[i].ToString();
                }

                //=================================
                // Show save file dialog
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //savefile dialog inputs
                saveFileDialog1.FileName = "Budgetoverzicht-" + richtper;
                saveFileDialog1.Filter = "excel files (*.xlsx)|*.xlsx";
                saveFileDialog1.FilterIndex = 1;
                //shows save file dialog
                lblWacht.Visible = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    worksheet.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, false, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                    workBook.Close(false, saveFileDialog1.FileName, false);
                    Marshal.ReleaseComObject(workBook);
                    Marshal.ReleaseComObject(worksheet);
                    app.Quit();
                    MessageBox.Show("Het Excel document staat klaar!", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het genereren van het Excel bestand. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            ws.get_Range("A" + pos, "C" + pos).Font.Color = c;
            if (m)
            {
                ws.get_Range("A" + pos, "A" + pos).Font.Bold = true;
                //if the month is even
                if (month % 2 == 0)
                {
                    c = MaandL;
                    ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                }
                //month is uneven
                else
                {
                    c = MaandD;
                    ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
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
                        ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                    }
                    else
                    {
                        c = DataL2;
                        ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                    }

                }
                //month is uneven
                else
                {
                    //if the position is even(in comparison to the month
                    if (even)
                    {
                        c = DataD1;
                        ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                    }
                    else
                    {
                        c = DataD2;
                        ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                    }
                }
            }
        }
        private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbFinancieringsjaar.SelectedValue.ToString()))
                {
                    pnlRichtperiode.Controls.Clear();
                    pnlMaand.Controls.Clear();
                    int xPos = 150;
                    int yPos = 0;
                    richtperiodes = RichtperiodeManager.GetRichtperiodes();
                    Label lblTotal = new Label();
                    Label lblTotalValue = new Label();
                    lblTotal.Text = "Totaal:";
                    lblTotal.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    lblTotal.Name = "lblTotal";

                    if (richtperiodes != null)
                    {
                        Budgets.Clear();
                        foreach (var richtperiode in richtperiodes)
                        {
                            yPos += 25;

                            LinkLabel llblRichtperiode = new LinkLabel();
                            llblRichtperiode.Name = "llblRichtperiode" + richtperiode.Id;
                            llblRichtperiode.Location = new Point(xPos - 140, yPos);
                            llblRichtperiode.Text = richtperiode.Naam;
                            llblRichtperiode.Font = new System.Drawing.Font("Segoe UI", 11);
                            llblRichtperiode.LinkColor = System.Drawing.Color.Black;
                            llblRichtperiode.LinkClicked += llblRichtperiode_Click;

                            decimal bedrag = AanvraagManager.GetTotaalPrijsPerRichtperiodeEnFinancieringsjaar(richtperiode.Id, cmbFinancieringsjaar.SelectedValue.ToString());
                            Label lblBedrag = new Label();
                            lblBedrag.Location = new Point(xPos, yPos);
                            lblBedrag.Name = $"lbl{richtperiode.Id}";
                            lblBedrag.Text = bedrag.ToString("c", CultureInfo.CurrentCulture);
                            lblBedrag.Font = new System.Drawing.Font("Segoe UI", 11);
                            lblBedrag.AutoSize = false;
                            lblBedrag.Size = new Size(100, 24);
                            lblBedrag.TextAlign = ContentAlignment.MiddleRight;
                            Budgets.Add(bedrag);

                            pnlRichtperiode.Controls.Add(llblRichtperiode);
                            pnlRichtperiode.Controls.Add(lblBedrag);

                        }

                        lblTotal.Location = new Point(xPos - 140, yPos + 60);
                        pnlRichtperiode.Controls.Add(lblTotal);

                        lblTotalValue.Location = new Point(xPos, yPos + 60);
                        lblTotalValue.Text = Budgets.Sum().ToString("c", CultureInfo.CurrentCulture);
                        lblTotalValue.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        lblTotalValue.AutoSize = false;
                        lblTotalValue.Size = new Size(100, 24);
                        lblTotalValue.TextAlign = ContentAlignment.MiddleRight;
                        pnlRichtperiode.Controls.Add(lblTotalValue);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden bij het ophalen van de budgetspreiding. - " + ex.Message, "MIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillRichtperiodes(IProgress<int> progress, string financieringsjaar, Panel pnlRichtperiode)
        {
            
        }

        private void llblRichtperiode_Click(object sender, EventArgs e)
        {
            xPos = 10;
            Label lblRichtperiode = new Label();
            LinkLabel llblRichtperiode = (LinkLabel)sender;
            
            int nietIndexLengte = 16;
            int indexLengte = llblRichtperiode.Name.Length - nietIndexLengte;
            Richtperiode r = new Richtperiode()
            {
                Id = Convert.ToInt32(llblRichtperiode.Name.Substring(nietIndexLengte, indexLengte))
            };

            //Panel leegmaken
            pnlMaand.Controls.Clear();
            //Richtperiode en jaar in titel van maandoverzicht zetten
            lblRichtperiode.Text = llblRichtperiode.Text + " - " + cmbFinancieringsjaar.Text;
            lblRichtperiode.Location = new Point(10, 10);
            lblRichtperiode.AutoSize = false;
            lblRichtperiode.Size = new Size(200, 24);
            lblRichtperiode.Font = new Font("Segoe UI", 12, FontStyle.Underline | FontStyle.Bold);
            pnlMaand.Controls.Add(lblRichtperiode);

            Titels.Clear();
            List<Aanvraag> Aanvragen = AanvraagManager.GetAanvragenByRichtperiodeAndFinancieringsjaarAndStatusAanvraag(r, cmbFinancieringsjaar.Text, new StatusAanvraag() { Id = 4 });

            if (Aanvragen != null)
            {
                yPos = 50;
                foreach (var aanvraag in Aanvragen)
                {
                    Label lblTitel = new Label();
                    Label lblPrijs = new Label();

                    lblTitel.Text = aanvraag.Titel;
                    lblPrijs.Text = aanvraag.BudgetToegekend.ToString("c", CultureInfo.CurrentCulture);

                    lblTitel.Location = new Point(15, yPos);
                    lblPrijs.Location = new Point(300, yPos);

                    lblTitel.AutoSize = false;
                    lblTitel.Size = new Size(250, 24);

                    lblPrijs.AutoSize = false;
                    lblPrijs.Size = new Size(100, 24);
                    lblPrijs.TextAlign = ContentAlignment.MiddleRight;

                    pnlMaand.Controls.Add((Label)lblTitel);
                    pnlMaand.Controls.Add((Label)lblPrijs);

                    yPos += 25;
                }

                Label lblTotaal = new Label();
                Label lblTotaalPrijs = new Label();

                lblTotaal.Text = "Totaal";
                lblTotaalPrijs.Text = AanvraagManager.GetTotaalPrijsPerRichtperiodeEnFinancieringsjaar(r.Id, cmbFinancieringsjaar.Text).ToString("c", CultureInfo.CurrentCulture);

                lblTotaal.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblTotaalPrijs.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                lblTotaal.Location = new Point(15, yPos);
                lblTotaalPrijs.Location = new Point(300, yPos);

                lblTotaal.AutoSize = false;
                lblTotaal.Size = new Size(250, 24);

                lblTotaalPrijs.AutoSize = false;
                lblTotaalPrijs.Size = new Size(100, 24);
                lblTotaalPrijs.TextAlign = ContentAlignment.MiddleRight;

                pnlMaand.Controls.Add((Label)lblTotaal);
                pnlMaand.Controls.Add((Label)lblTotaalPrijs);
            }

        }
    }
}

