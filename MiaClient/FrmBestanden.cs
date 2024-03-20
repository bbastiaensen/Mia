using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class FrmBestanden : Form
    {
        //Variables
        private string selectedPath;
        private string mainPath;// De folder voor het opslagen, dit wordt de parameter
        private string hyperlink;
        private int _aanvraagId = 0;


        //Connections
        private void Connections()
        {
            ParameterManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            PrioriteitManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            FinancieringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            FinancieringsjaarManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            DienstenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AfdelingenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            InvesteringenManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AanvraagManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            AankoperManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            KostenplaatsManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            LinkManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            OfferteManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            FotoManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
        }
        private void GetId()
        {
            int highestAanvraagId = MiaLogic.Manager.AanvraagManager.GetHighestAanvraagId();
            txt_FotoId.Text = (highestAanvraagId + 1).ToString();
            txt_offerteId.Text = (highestAanvraagId + 1).ToString();
        }
        public void RefreshBoxes(TabControl tabControl) //Dit is het deelprobleem om alle textboxes etc leeg te maken
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    txt_hyperlinkInput.Clear();

                    break;
                case 1:
                    txt_fotoURLInput.Clear();
                    selectedPath = string.Empty;
                    break;
                case 2:
                    txt_offerteURLInput.Clear();
                    selectedPath = string.Empty;
                    break;
            }
        }


        public static void Delete() //het deelrpobleem om de hyperlink/foto/offerte te verwijderen
        {

        }
        private void SaveFile(string sourcePath, string destinationPath)
        {
            File.Copy(sourcePath, destinationPath, true);
        }
        private Offerte SaveOfferte(string filepath)
        {
            try
            {
                Offerte offerte = new Offerte
                {
                    Url = filepath,
                    AanvraagId = _aanvraagId
                };

                OfferteManager.SaveOfferte(offerte);
                return offerte;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het opslaan van de offerte in de database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private Foto SaveFoto(string filepath)
        {
            try
            {
                Foto foto = new Foto
                {

                    Url = filepath,
                    AanvraagId = _aanvraagId
                };
                FotoManager.SaveFoto(foto);
                return foto;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het opslaan van de foto in de database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private Link SaveLink(string hyperlink)
        {
            try
            {
                Link link = new Link
                {
                    AanvraagId = _aanvraagId,
                    Url = hyperlink
                };
                LinkManager.SaveLinken(link);
                return link;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden bij het opslaan van de link in de database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public FrmBestanden(int aanvraagId)
        {
            InitializeComponent();
            mainPath = ParameterManager.GetParameterByCode("Testmap").Waarde;
            Connections();
            GetId();
            _aanvraagId = aanvraagId;



        }

        private void btn_nieuweLink_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);
        }

        private void btn_bewaarLink_Click(object sender, EventArgs e)
        {
            try
            {
                hyperlink = txt_hyperlinkInput.Text;
                Link savedlink = SaveLink(hyperlink);
                if (savedlink != null)
                {
                    MessageBox.Show("De link is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(_aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Link opgeslagen met id {savedlink.Id}."
                    }, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout opgetreden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                if (!string.IsNullOrEmpty(selectedPath))
                {
                    string fileName = Path.GetFileName(selectedPath);
                    string fileExtension = Path.GetExtension(selectedPath);

                    string uniqueFileName = $"{_aanvraagId}-{txt_FotoId.Text}-{DateTime.Now:yyyyMMddHHmm}{fileExtension}";

                    string destinationFolder = Path.Combine(mainPath + @"\fotos");
                    string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                    SaveFile(selectedPath, destinationPath);

                    MessageBox.Show("De foto is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SaveFoto(destinationPath);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(_aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Foto opgeslagen met id {_aanvraagId}."
                    }, true);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een foto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een error gebeurt tijdens het opslaan van de foto: {ex.Message}");
            }

        }

        private void btn_verwijderFoto_Click(object sender, EventArgs e)
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
            txt_fotoURLInput.Text = selectedPath;

        }

        private void btn_nieuweOfferte_Click(object sender, EventArgs e)
        {
            RefreshBoxes(tabControl);
        }

        private void btn_bewaarOfferte_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectedPath))
                {
                    string fileName = Path.GetFileName(selectedPath);
                    string fileExtension = Path.GetExtension(selectedPath);


                    string uniqueFileName = $"{_aanvraagId}-{txt_offerteId.Text}-{DateTime.Now:yyyyMMddHHmm}-{fileExtension}";

                    string destinationFolder = Path.Combine(mainPath + @"\offertes"); // Hier mpet nog de hardocded map naam voor (test)
                    string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                    SaveFile(selectedPath, destinationPath);

                    MessageBox.Show("De offerte is successvol opgeslagen.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Hier returnen we naar de aanvragen formulier, dit doen we met alle 

                    string relativeUrl = Path.Combine("offertes", uniqueFileName);
                    SaveOfferte(relativeUrl);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                    {
                        Gebruiker = Program.Gebruiker,
                        Id = Convert.ToInt32(_aanvraagId),
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Er werd een nieuwe Offerte opgeslagen met id {_aanvraagId}."
                    }, true);
                }
                else
                {
                    MessageBox.Show("Selecteer eerst een offerte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er is een fout gebeurt tijdens het opslaan van de offerte: {ex.Message}");
            }

        }

        private void btn_verwijderOfferte_Click(object sender, EventArgs e)
        {

        }

        private void btn_kiesOfferte_Click(object sender, EventArgs e)
        {
            //Hier opent de filedialog voor een word /exel file te selecteren
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Text files (*.doc, *.docx, *.xls, *.xlsx)|*.doc;*.docx;*.xls;*.xlsx|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = openFileDialog.FileName;
                    MessageBox.Show($"De offerte is succesvol geslecteerd. Dit is het pad :{selectedPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txt_offerteURLInput.Text = selectedPath;

        }
    }
}
