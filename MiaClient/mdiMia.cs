using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiaClient
{

    public partial class mdiMia : Form
    {
        private int childFormNumber = 0;

        FrmGebruiksLog frmGebruiksLog;
        frmParameter frmParameter;
        frmAbout frmAbout;
        frmAanvraagFormulier frmAanvraagFormulier;
        public FrmAanvragen frmAanvragen;
        frmGebruikerBeheer frmGebruikerBeheer;


        public mdiMia()
        {
            GetRollen();
            InitializeComponent();
            laadGrafischeParameters();
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
            ParameterManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
            //StyleParameters.LogoG = Image.FromFile(ParameterManager.GetParameterByCode("LogoG").Waarde);
            //StyleParameters.LogoK = Image.FromFile(ParameterManager.GetParameterByCode("LogoK").Waarde);
            StyleParameters.AccentKleur = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("AccentKleur").Waarde);
            StyleParameters.ButtonBack = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("ButtonBack").Waarde);
            StyleParameters.Buttontext = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("ButtonText").Waarde);
            StyleParameters.Achtergrondkleur = System.Drawing.ColorTranslator.FromHtml(ParameterManager.GetParameterByCode("Achtergrondkleur").Waarde);

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

        }
        private void MenubalkSamenstellen()
        {
            //Aanvrager - enkel items voor aanvrager worden getoond
            if (Program.IsAanvrager)
            {
                aanvragenToolStripMenuItem.Visible = true;
                aanvragenToolStripButton.Visible = true;
                beheerToolStripMenuItem.Visible = false;
                gebruiksLogToolStripButton.Visible = false;
                parameterToolStripButton.Visible = false;
                helpMenu.Visible = true;
            }

            //Aankoper - items voor aankoper worden extra bij aangezet
            if (Program.IsAankoper)
            {

            }

            //Goedkeurder - items voor goedkeurder worden extra bij aangezet
            if (Program.IsGoedkeurder)
            {

            }

            //Systeem - items voor systeem worden extra bij aangezet
            if (Program.IsSysteem)
            {
                beheerToolStripMenuItem.Visible = true;
                gebruiksLogToolStripButton.Visible = true;
                parameterToolStripButton.Visible = true;
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


    }
}
