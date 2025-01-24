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
        int i = 0;
        List<Aanvraag> Aanvragen   = null;
        List<Richtperiode> richtperiodes = null;
        System.Windows.Forms.Label lbl;
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

            foreach (var gb in this.Controls.OfType<GroupBox>())
            {
                foreach (var btn in gb.Controls.OfType<Button>())
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
            List<Aanvraag> aanvragen = AanvraagManager.GetAanvragen();
            List<Aanvraag> inJaar = new List<Aanvraag>();
            //Making sure the data is in the right year
            if (cmbFinancieringsjaar.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst een financieringsjaar", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (Aanvraag a in aanvragen) {
                try { 
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
            int ri;
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
                worksheet.get_Range("A" + ri, "A" + ri).Value = RichtperiodeManager.GetRichtperiodeById(m).Naam;
                //total of the month
                decimal tot = 0;
                //background color for months in Excel file
                ColorExcel(ri, m, worksheet, even, meh);
                //Making sure the data in the right month
                meh = false;
                List<Aanvraag> InPer = new List<Aanvraag>();
                foreach (Aanvraag a in inJaar)
                {
                    if (a.RichtperiodeId == m)
                    {
                        InPer.Add(a);
                    }
                }
                //going over the data
                for (int j = 0; j < InPer.Count; j++)
                {
                    //add = position of data, rs=offset by the data
                    add = ri + j + 1;
                    rs += j;
                    //calculates the price
                    decimal prijs = InPer[j].AantalStuk + InPer[j].PrijsIndicatieStuk;
                    //puts data on the right position (based on add)
                    worksheet.get_Range("B" + add, "B" + add).Value = InPer[j].Titel;
                    worksheet.get_Range("C" + add, "C" + add).Value = (prijs);
                    //total for the month
                    tot += prijs;
                    //background color for data in Excel file
                    ColorExcel(add, m, worksheet, even,meh);
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
                ColorExcel((m + rs), m, worksheet,even, meh);
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
                //it doesn't like onedrive(saves the Excel file)
                try
                {
                    worksheet.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                    workBook.Close(false, Type.Missing, false);
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
        public void ColorExcel(int pos, int month, Excel.Worksheet ws, bool even, bool m)
        {
            //for the color
            Parameter p = new Parameter();
            Color c = new Color();
            //if the data is the richtperiode
            p = ParameterManager.GetParameterByCode("TekstExcel");
            c = StringToColor(p.Waarde);
            ws.get_Range("A" + pos, "C" + pos).Font.Color = c;
            if (m)
            {
                ws.get_Range("A" + pos, "A" + pos).Font.Bold = true;
                //if the month is even
                if (month % 2 == 0)
                {
                    p = ParameterManager.GetParameterByCode("MaandExcelL");
                    c = StringToColor(p.Waarde);
                    ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                }
                //month is uneven
                else
                {
                    p = ParameterManager.GetParameterByCode("MaandExcelD");
                    c = StringToColor(p.Waarde);
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
                        p = ParameterManager.GetParameterByCode("DataExcelL1");
                        c = StringToColor(p.Waarde);
                        ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                    }
                    else
                    {
                        p = ParameterManager.GetParameterByCode("DataExcelL2");
                        c = StringToColor(p.Waarde);
                        ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                    }

                }
                //month is uneven
                else
                {
                    //if the position is even(in comparison to the month
                    if (even)
                    {
                        p = ParameterManager.GetParameterByCode("DataExcelD1");
                        c = StringToColor(p.Waarde);
                        ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                    }
                    else
                    {
                        p = ParameterManager.GetParameterByCode("DataExcelD2");
                        c = StringToColor(p.Waarde);
                        ws.get_Range("A" + pos, "C" + pos).Interior.Color = c;
                    }
                }
            }
        }

        private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            pnlRichtperiode.Refresh();
            pnlRichtperiode.Controls.Clear();
            pnlMaand.Controls.Clear();
            int xPos = 150;
            int yPos = 0;
            richtperiodes = RichtperiodeManager.GetRichtperiodes();
            System.Windows.Forms.Label lblTotal= new Label();
            System.Windows.Forms.Label lblNum = new Label();
            lblTotal.Text = "Totaal:";
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 11);
            lblTotal.Name = "lblTotal";

            List<LinkLabel> linkLabels = new List<LinkLabel>();
            
            for (i = 0; i < richtperiodes.Count; i++)
            {
                yPos += 25;
                 this.richtperiode = richtperiodes[i];
                var richtperiode = this.richtperiode.Naam.ToString();


                linkLabels.Add(new LinkLabel());
                linkLabels[i].Name = "llblRichtperiode" + this.richtperiode.Id;
                linkLabels[i].Location = new Point(xPos - 140, yPos);
                linkLabels[i].Text = richtperiode;
                linkLabels[i].Font = new System.Drawing.Font("Segoe UI", 11);
                linkLabels[i].LinkColor = System.Drawing.Color.Black;

                linkLabels[i].LinkClicked += FrmBudgetspreiding_Click;
              

                lblTotal.Location = new Point(xPos - 140, yPos + 60);
              

                pnlRichtperiode.Controls.Add(linkLabels[i]);
                pnlRichtperiode.Controls.Add(lblTotal);
            }
          
            i = 0;         
            xPos = 150;
            yPos = 0;
            Budgets.Clear();
            foreach (var richtperiode in richtperiodes)
            {
                lbl = new Label();
                pnlRichtperiode.Refresh();
                string year = cmbFinancieringsjaar.SelectedItem.ToString();
                decimal bedrag = AanvraagManager.GetTotaalPrijsPerRichtperiodeEnFinancieringsjaar(richtperiode.Id, year);
                yPos += 25;

                lbl.Location = new Point(xPos, yPos);
                lbl.Name = $"lbl{richtperiode.Id}";
                lbl.Text = bedrag.ToString();
                lbl.Font = new System.Drawing.Font("Segoe UI", 11);
                Budgets.Add(bedrag);
                Totaal = Budgets.Sum();
                lblNum.Location = new Point(xPos, yPos + 60);
                lblNum.Text = Totaal.ToString();
                pnlRichtperiode.Controls.Add(lblNum);
                pnlRichtperiode.Controls.Add(lbl);
            }
           

           
            
        }

        private void FrmBudgetspreiding_Click(object sender, EventArgs e)
        {
            xPos = 10;
            LinkLabel llblRichtperiode = (LinkLabel)sender;
            Label Richtperiode = new Label();
            Label Financieringsjaar = new Label();
            Financieringsjaar.Text = cmbFinancieringsjaar.Text;
            
            Richtperiode.Text = llblRichtperiode.Text; 
                

            int nietIndexLengte = 16;
            int indexLengte = llblRichtperiode.Name.Length - nietIndexLengte;
            
            pnlMaand.Controls.Clear();

            
           
            llblRichtperiode.Location = new Point(xPos, yPos);
           
            Financieringsjaar.Location = new Point(xPos - 10, yPos +25);
            llblRichtperiode.Text = llblRichtperiode.Name.Substring(nietIndexLengte, indexLengte);
            Titels.Clear();
            //foreach (var aanvraag  in Aanvragen)
            //{
               
                
            //    Label lbl = new Label();
            //    Label prijs = new Label();

            //    pnlMaand.Controls.Clear();

            //    string year = Financieringsjaar.Text.ToString();
            //    var titel = AanvraagManager.GetTitelEnTotaalprijsPerRichtperiodeEnFinancieringsjaar(aanvraag.Id, year);

            //    yPos =+ 25;

            //    lbl.Location = new Point(xPos, yPos);
            //    lbl.Name = "hehe";
            //    lbl.Text = titel.ToString();
            //    lbl.Font = new System.Drawing.Font("Segoe UI", 11);
            //    Titels.Add(Convert.ToString(titel));
            //}

            pnlMaand.Controls.Add(Richtperiode);
            pnlMaand.Controls.Add(Financieringsjaar);
            //pnlMaand.Controls.Add(lbl);

        }
    }
}

