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
using Excel = Microsoft.Office.Interop.Excel;

namespace MiaClient
{
    //Versie 2 - Release 1 van MIA

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
        frmAankopen frmAankopen;
        frmGeplandeAankopen frmGeplandeAankopen;
        frmGeweigerdeAanvragen frmGeweigerdeAanvragen;
        frmGrafiekStatusAanvraagPerFinancieringsjaar frmGrafiekStatusAanvraagPerFinancieringsjaar;
        frmGrafiekBudgetSpreiding frmGrafiekBudgetSpreiding;
        frmGrafiekEvolutieBudgetten frmGrafiekEvolutieBugetten;

        Image imgGebruikersbeheer;
        Image imgGoedkeuringen;
        Image imgParameters;
        Image imgGebruikslog;
        Image imgAanvragen;
        Image imgBudgetspreiding;


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
                imgBudgetspreiding = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-euro-50-alt.png"));
            }
            else
            {
                imgGebruikersbeheer = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-users-48.png"));
                imgGoedkeuringen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-approval-50.png"));
                imgParameters = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-parameters-66.png"));
                imgGebruikslog = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-log-80.png"));
                imgAanvragen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-form-80.png"));
                imgBudgetspreiding = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-euro-50.png"));
            }

            gebruikersToolStripButton.Image = imgGebruikersbeheer;
            goedkeuringenToolStripButton.Image = imgGoedkeuringen;
            aanvragenToolStripButton.Image = imgAanvragen;
            gebruiksLogToolStripButton.Image = imgGebruikslog;
            parameterToolStripButton.Image = imgParameters;
            budgetSpreidingtoolStripButton.Image = imgBudgetspreiding;

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
                overzichtenToolStripMenuItem.Visible = false;
                budgetoverzichtToolStripMenuItem.Visible = false;
                budgetSpreidingtoolStripButton.Visible = false;
                aankopenToolStripMenuItem.Visible = false;
            }

            //Aankoper - items voor aankoper worden extra bij aangezet
            if (Program.IsAankoper)
            {
                tss3.Visible = true;
                overzichtenToolStripMenuItem.Visible = true;
                budgetoverzichtToolStripMenuItem.Visible = true;
                budgetSpreidingtoolStripButton.Visible = true;

                tss1.Visible = false;
                goedkeuringenToolStripMenuItem.Visible = false;
                goedkeuringenToolStripButton.Visible = false;

                //TO DO: Dit is onvoldoende uitgewerkt om al gebruikt te worden.
                //aankopenToolStripMenuItem.Visible = true;

                beheerToolStripMenuItem.Visible = false;
                gebruiksLogToolStripButton.Visible = false;
                parameterToolStripButton.Visible = false;
                gebruikersToolStripButton.Visible = false;
            }

            //Goedkeurder - items voor goedkeurder worden extra bij aangezet
            if (Program.IsGoedkeurder)
            {
                tss1.Visible = true;
                goedkeuringenToolStripMenuItem.Visible = true;
                goedkeuringenToolStripButton.Visible = true;

                tss3.Visible = true;
                overzichtenToolStripMenuItem.Visible = true;
                budgetoverzichtToolStripMenuItem.Visible = true;
                budgetSpreidingtoolStripButton.Visible = true;

                beheerToolStripMenuItem.Visible = false;
                gebruiksLogToolStripButton.Visible = false;
                parameterToolStripButton.Visible = false;
                gebruikersToolStripButton.Visible = false;

                aankopenToolStripMenuItem.Visible = false;
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

                tss3.Visible = true;
                overzichtenToolStripMenuItem.Visible = true;
                budgetoverzichtToolStripMenuItem.Visible = true;
                budgetSpreidingtoolStripButton.Visible = true;

                //TO DO: Dit is onvoldoende uitgewerkt om al gebruikt te worden.
                //aankopenToolStripMenuItem.Visible = true;
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

        private void budgetoverzichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBudgetspreiding == null)
            {
                frmBudgetspreiding = new frmBudgetspreiding();
                frmBudgetspreiding.MdiParent = this;
            }
            frmBudgetspreiding.Show();
        }

        private void budgetSpreidingtoolStripButton_Click(object sender, EventArgs e)
        {
            if (frmBudgetspreiding == null)
            {
                frmBudgetspreiding = new frmBudgetspreiding();
                frmBudgetspreiding.MdiParent = this;
            }
            frmBudgetspreiding.Show();
        }

        private void aankopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAankopen == null)
            {
                frmAankopen = new frmAankopen();
                frmAankopen.MdiParent = this;
            }
            frmAankopen.Show();
        }

        private void geplandeAanvragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGeplandeAankopen == null)
            {
                frmGeplandeAankopen = new frmGeplandeAankopen();
                frmGeplandeAankopen.MdiParent = this;
            }
            frmGeplandeAankopen.Show();
        }

        private void geweigerdeAanvragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGeweigerdeAanvragen == null)
            {
                frmGeweigerdeAanvragen = new frmGeweigerdeAanvragen();
                frmGeweigerdeAanvragen.MdiParent = this;
            }
            frmGeweigerdeAanvragen.Show();
        }

        private void statusAanvragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGrafiekStatusAanvraagPerFinancieringsjaar == null)
            {
                frmGrafiekStatusAanvraagPerFinancieringsjaar = new frmGrafiekStatusAanvraagPerFinancieringsjaar();
                frmGrafiekStatusAanvraagPerFinancieringsjaar.MdiParent = this;
            }
            frmGrafiekStatusAanvraagPerFinancieringsjaar.Show();
        }

        private void budgetSpreidingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGrafiekBudgetSpreiding == null)
            {
                frmGrafiekBudgetSpreiding = new frmGrafiekBudgetSpreiding();
                frmGrafiekBudgetSpreiding.MdiParent = this;
            }
            frmGrafiekBudgetSpreiding.Show();
        }

        private void evolutieBudgettenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmGrafiekEvolutieBugetten == null)
            {
                frmGrafiekEvolutieBugetten = new frmGrafiekEvolutieBudgetten();
                frmGrafiekEvolutieBugetten.MdiParent = this;
            }
            frmGrafiekEvolutieBugetten.Show();
        }
    }
}

