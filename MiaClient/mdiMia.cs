using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiaClient
{
    //We starten op 12/11/2024 met versie 2 van MIA

    public partial class mdiMia : Form
    {
        private int childFormNumber = 0;

        FrmGebruiksLog frmGebruiksLog;
        frmParameter frmParameter;
        frmAbout frmAbout;
        frmAanvraagFormulier frmAanvraagFormulier;
        frmBudgetspreiding frmBudgetspreiding;
        public FrmAanvragen frmAanvragen;
        frmGebruikerBeheer frmGebruikerBeheer;
        frmGoedkeuring FrmGoedkeuring;

        Image imgGebruikersbeheer;
        Image imgGoedkeuringen;
        Image imgParameters;
        Image imgGebruikslog;
        Image imgAanvragen;


        public mdiMia()
        {
            try
            {
                GetRollen();
            }
            catch (Exception ex)
            {
                ErrorHandler("Ophalen van de rollen", ex, "mdiMia");
            }
            InitializeComponent();
            try
            {  
                laadGrafischeParameters();
            }
            catch (Exception ex)
            {
                ErrorHandler("Laden van grafische parameters", ex, "mdiMia");
            }
        }

        private static void ErrorHandler(string customMessage, Exception ex, string location)
        {
            MessageBox.Show($"Error: {customMessage} - {ex.Message} in {location}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string GetRollen()
        {
            string rollen = string.Empty;

            if (Program.IsAanvrager)
            {
                rollen = "Aanvrager";
            }

            if (Program.IsAankoper)
            {
                if (!string.IsNullOrEmpty(rollen))
                {
                    rollen += " / ";
                }
                rollen += "Aankoper";
            }

            if (Program.IsGoedkeurder)
            {
                if (!string.IsNullOrEmpty(rollen))
                {
                    rollen += " / ";
                }
                rollen += "Goedkeurder";
            }

            if (Program.IsSysteem)
            {
                if (!string.IsNullOrEmpty(rollen))
                {
                    rollen += " / ";
                }
                rollen += "Systeem";
            }

            return rollen;

        }

        private void laadGrafischeParameters()
        {
            string projectDirectory = Directory.GetCurrentDirectory();
            string imagePath = Path.Combine(projectDirectory, "Foto's", ParameterManager.GetParameterByCode("LogoG").Waarde);
            StyleParameters.LogoG = Image.FromFile(imagePath);
            string imagePath2 = Path.Combine(projectDirectory, "Foto's", ParameterManager.GetParameterByCode("LogoK").Waarde);
            StyleParameters.LogoK = Image.FromFile(imagePath2);
            StyleParameters.AccentKleur = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("AccentKleur").Waarde);
            StyleParameters.ButtonBack = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("ButtonBack").Waarde);
            StyleParameters.Buttontext = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("ButtonText").Waarde);
            StyleParameters.Achtergrondkleur = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("Achtergrondkleur").Waarde);
            StyleParameters.ListItemColor = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("ListItemColor").Waarde);
            StyleParameters.AltListItemColor = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("AltListItemColor").Waarde);
            StyleParameters.AltButtons = Convert.ToBoolean(ParameterManager.GetParameterByCode("AltButtons").Waarde);
        }
        private void stelGrafischeWaardeIn()
        {

            toolStrip.BackColor = StyleParameters.AccentKleur;
            menuStrip.BackColor = StyleParameters.AccentKleur;
            menuStrip.ForeColor = StyleParameters.Buttontext;
            beheerToolStripMenuItem.BackColor = StyleParameters.AccentKleur;

            beheerToolStripMenuItem.DropDown.BackColor = StyleParameters.AccentKleur;
            beheerToolStripMenuItem.DropDown.ForeColor = StyleParameters.Buttontext;

            this.BackgroundImage = StyleParameters.LogoG;
            this.BackgroundImageLayout = ImageLayout.Center;

            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = StyleParameters.Achtergrondkleur;
                }
            }

            helpMenu.DropDown.BackColor = StyleParameters.AccentKleur;
            helpMenu.DropDown.ForeColor = StyleParameters.Buttontext;

            if (StyleParameters.AltButtons)
            {
                imgGebruikersbeheer = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-users-48-alt.png"));
                imgGoedkeuringen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-approval-50-alt.png"));
                imgParameters = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-parameters-66-alt.png"));
                imgGebruikslog = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-log-80-alt.png"));
                imgAanvragen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-form-80-alt.png"));
            }
            else
            {
                imgGebruikersbeheer = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-users-48.png"));
                imgGoedkeuringen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-approval-50.png"));
                imgParameters = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-parameters-66.png"));
                imgGebruikslog = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-log-80.png"));
                imgAanvragen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-form-80.png"));
            }

            gebruikersToolStripButton.Image = imgGebruikersbeheer;
            goedkeuringenToolStripButton.Image = imgGoedkeuringen;
            aanvragenToolStripButton.Image = imgAanvragen;
            gebruiksLogToolStripButton.Image = imgGebruikslog;
            parameterToolStripButton.Image = imgParameters;

        }
        private void MenubalkSamenstellen()
        {
            //Aanvrager - enkel items voor aanvrager worden getoond
            if (Program.IsAanvrager)
            {
                aanvragenToolStripMenuItem.Visible = true;
                aanvragenToolStripButton.Visible = true;
                goedkeuringenToolStripButton.Visible = false;
                beheerToolStripMenuItem.Visible = false;
                gebruiksLogToolStripButton.Visible = false;
                parameterToolStripButton.Visible = false;
                gebruikersToolStripButton.Visible = false;
                helpMenu.Visible = true;
                goedkeuringenToolStripMenuItem.Visible = false;
            }

            //Aankoper - items voor aankoper worden extra bij aangezet
            if (Program.IsAankoper)
            {

            }

            //Goedkeurder - items voor goedkeurder worden extra bij aangezet
            if (Program.IsGoedkeurder)
            {
                tss1.Visible = true;
                goedkeuringenToolStripMenuItem.Visible = true;
                goedkeuringenToolStripButton.Visible = true;
                budgetSpreidingToolStripMenuItem.Visible = true;
            }

            //Systeem - items voor systeem worden extra bij aangezet
           
            if (Program.IsSysteem)
            {
                tss2.Visible = true;
                goedkeuringenToolStripMenuItem.Visible = true;
                goedkeuringenToolStripButton.Visible = true;
                beheerToolStripMenuItem.Visible = true;
                gebruiksLogToolStripButton.Visible = true;
                parameterToolStripButton.Visible = true;
                gebruikersToolStripButton.Visible = true;
            }
        }

        private void gebruikslogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGebruiksLog == null)
            {
                frmGebruiksLog = new FrmGebruiksLog();
                frmGebruiksLog.MdiParent = this;
            }
            frmGebruiksLog.Show();
        }

        private void parametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmParameter == null)
            {
                frmParameter = new frmParameter();
                frmParameter.MdiParent = this;
            }
            frmParameter.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAbout == null)
            {
                frmAbout = new frmAbout();
                frmAbout.MdiParent = this;
            }
            frmAbout.Show();
        }

        private void gebruiksLogToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmGebruiksLog == null)
            {
                frmGebruiksLog = new FrmGebruiksLog();
                frmGebruiksLog.MdiParent = this;
            }
            frmGebruiksLog.Show();
        }

        private void parameterToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmParameter == null)
            {
                frmParameter = new frmParameter();
                frmParameter.MdiParent = this;
            }
            frmParameter.Show();
        }

        private void kleuronhover(object sender, EventArgs e)
        {

            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            item.ForeColor = StyleParameters.AccentKleur;



        }

        private void kleuronleave(object sender, EventArgs e)
        {

            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            item.ForeColor = StyleParameters.Buttontext;




        }

        private void mdiMia_Load(object sender, EventArgs e)
        {
            string rollen = GetRollen();
            toolStripStatusLabel.Text = $"Gebruiker: {Program.Gebruiker} Rollen: {rollen}";

            MenubalkSamenstellen();
            stelGrafischeWaardeIn();
        }

        private void aanvragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAanvragen == null)
            {
                frmAanvragen = new FrmAanvragen();
                frmAanvragen.MdiParent = this;
            }
            frmAanvragen.Show();
        }

        private void gebruikersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGebruikerBeheer == null)
            {
                frmGebruikerBeheer = new frmGebruikerBeheer();
                frmGebruikerBeheer.MdiParent = this;
            }
            frmGebruikerBeheer.Show();
        }

        private void aanvragenToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmAanvragen == null)
            {
                frmAanvragen = new FrmAanvragen();
                frmAanvragen.MdiParent = this;
            }
            frmAanvragen.Show();

        }

        private void goedkeuringenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmGoedkeuring == null)
            {
                FrmGoedkeuring = new frmGoedkeuring();
                FrmGoedkeuring.MdiParent = this;
            }
            FrmGoedkeuring.Show();
        }

        private void gebruikersToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmGebruikerBeheer == null)
            {
                frmGebruikerBeheer = new frmGebruikerBeheer();
                frmGebruikerBeheer.MdiParent = this;
            }
            frmGebruikerBeheer.Show();
        }

        private void goedkeuringenToolStripButton_Click(object sender, EventArgs e)
        {
            if (FrmGoedkeuring == null)
            {
                FrmGoedkeuring = new frmGoedkeuring();
                FrmGoedkeuring.MdiParent = this;
            }
            FrmGoedkeuring.Show();
        }

        private void beheerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void budgetSpreidingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmBudgetspreiding == null)
            {
                frmBudgetspreiding = new frmBudgetspreiding();
                frmBudgetspreiding.MdiParent = this;
            }
            frmBudgetspreiding.Show();
        }
    }
}

