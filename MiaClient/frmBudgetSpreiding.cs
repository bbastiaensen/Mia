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
        List<Richtperiode> richtperiodes = null;
        System.Windows.Forms.Label lbl;
       
        List<decimal> brian = new List<decimal>();
        decimal louis = 0;
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
                catch {
                    MessageBox.Show("Selecteer een financieringsjaar aub");
                }
            }
            //setting up the numbers
            int add = 2;
            int ri;
            int rs = 2;
            //loops over the periods (m=month)
            for (int m = 1; m <= rp.Count; m++)
            {
                //ri = position in int, r = position in string
                ri = m + rs;
                string r = (ri).ToString();
                //the name of the month
                worksheet.get_Range("A" + r, "A" + r).Value = RichtperiodeManager.GetRichtperiodeById(m).Naam;
                decimal tot = 0;
                //background color for months in Excel file
                Color(ri, m, worksheet);
                //Making sure the data in the right month
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
                    rs = j + 3;
                    //calculates the price
                    decimal prijs = InPer[j].AantalStuk + InPer[j].PrijsIndicatieStuk;
                    //puts data on the right position (based on add)
                    worksheet.get_Range("B" + add, "B" + add).Value = InPer[j].Titel;
                    worksheet.get_Range("C" + add, "C" + add).Value = (prijs);
                    //total for the month
                    tot += prijs;
                    //background color for data in Excel file
                    Color(add, m, worksheet);
                }
                rs++;
                Color((m+ rs), m, worksheet);
                //puts total of month on it's spot, makes it bold
                worksheet.get_Range("C"+r, "C"+r).Value = tot;
                worksheet.get_Range("C"+r, "C"+r).Font.Bold = true;
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
        public void Color(int pos, int month, Excel.Worksheet ws)
        {
            if (month % 2 == 0)
            {
                ws.get_Range("A" + pos, "C" + pos).Interior.Color = Excel.XlRgbColor.rgbGrey;
            }
            else
            {
                ws.get_Range("A" + pos, "C" + pos).Interior.Color = Excel.XlRgbColor.rgbWhite;
            }
        }

        private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlRichtperiode.Refresh();
            pnlRichtperiode.Controls.Clear();
            int xPos = 150;
            int yPos = 0;
            richtperiodes = RichtperiodeManager.GetRichtperiodes();
            System.Windows.Forms.Label lblTotal= new Label();
            System.Windows.Forms.Label lblNum = new Label();
            lblTotal.Text = "Totaal:";
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 11);
            lblTotal.Name = "lblTotal";

            for (i = 0; i < richtperiodes.Count; i++)
            {
                yPos += 25;
                Richtperiode richtperiode = richtperiodes[i];
                var Maanden = richtperiode.Naam.ToString();
                System.Windows.Forms.LinkLabel llbl = new LinkLabel();
                llbl.Location = new Point(xPos - 140, yPos);
                lblTotal.Location = new Point(xPos - 140, yPos + 60);
                llbl.Name = "llbl";
                llbl.Text = Maanden;
                llbl.Font = new System.Drawing.Font("Segoe UI", 11);
                llbl.LinkColor = System.Drawing.Color.Black;
                pnlRichtperiode.Controls.Add(llbl);
                pnlRichtperiode.Controls.Add(lblTotal);
            }
            yPos = 0;
            brian.Clear();
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
                brian.Add(bedrag);
                louis = brian.Sum();
                lblNum.Location = new Point(xPos, yPos + 60);
                lblNum.Text = louis.ToString();
                pnlRichtperiode.Controls.Add(lblNum);
                pnlRichtperiode.Controls.Add(lbl);
            }
        }
    }
}

