using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{

    //Moeten de bestandsnamen specifiek zijn of niet
    //Wat gebeurt er met de bestanden als de map verplaatst word? Moeten de bestanden mee verplaatst worden of
    public partial class frmAanvraagFormulier : Form
    {
        private string selectedPath;
        string Mainpath = "C:\\Users\\TimMeeus\\Downloads"; // De folder voor het opslagen, dit wordt de parameter
        private string link = string.Empty;

        public frmAanvraagFormulier()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_Voorstellen_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_Offertes_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAanvraagFormulier_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }
        public void RefreshBoxes(TabControl tabControl) //Dit is het deelprobleem om alle textoxes etc leeg te maken
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    txt_hyperlinkInput.Clear();
                    break;
                case 1:
                    txt_fotoURLInput.Clear();
                    break;
                case 2:
                    txt_offerteURLInput.Clear();
                    break;
            }

        }


        public static void Delete() //het deelrpobleem om de hyperlink/foto/offerte te verwijderen
        {

        }


        private void btn_bewaarLink_Click(object sender, EventArgs e)
        {
            //Hier moet ik de link naar de databank sturen in de tabel linken

        }

        private void btn_nieuweLink_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);

        }

        private void btn_verwijderLink_Click(object sender, EventArgs e)
        {

        }

        private void btn_nieuweFoto_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);

        }

        private void btn_bewaarFoto_Click(object sender, EventArgs e)
        {
            if (txt_fotoURLInput != null)
            {
                link = txt_fotoURLInput.Text;
                //De link is het pad en moet alleen read only zijn

            }
            if (!string.IsNullOrEmpty(selectedPath)) // als de string != null is
            {
                string FileName = Path.GetFileName(selectedPath);//Hier haal ik de bestandsnaam op
                string DestinationPath = Path.Combine(Mainpath, FileName); //OM het volledige pad te vinden moet ik deze 2 samen plakken

                try
                {
                    File.Copy(selectedPath, DestinationPath, true);//Hier slaag ik de afbeelding op
                    MessageBox.Show("De foto is succesvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Er is een fout opgetreden bij het opslaan van de foto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecteer eers een afbeelding aub", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //Als de string == Null is geef hij deze error
            }


        }

        private void btn_verwijderFoto_Click(object sender, EventArgs e)
        {

        }

        private void btn_nieuweOfferte_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);

        }

        private void btn_bewaarOfferte_Click(object sender, EventArgs e)
        {
            //De link is het pad en moet alleen read only zijn

        }

        private void btn_verwijderOfferte_Click(object sender, EventArgs e)
        {

        }

        private void btn_kiesOfferte_Click(object sender, EventArgs e)
        {
            //Hier opent de filedialog voor een foto / word /exel file te selecteren
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_kiesFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";//Dit is de originele directory
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";//Dit is de filter die alleen maar foto-extenties laat zien

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = openFileDialog.FileName;
                    MessageBox.Show($"De foto is succesvol geslecteerd. Dit is het pad :{selectedPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
    }
}
