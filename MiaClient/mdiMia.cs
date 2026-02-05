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

        private MdiClient mdiClient;

        FrmGebruiksLog frmGebruiksLog;
        frmParameter frmParameter;
        frmAanvraagFormulier frmAanvraagFormulier;
        frmBudgetspreiding frmBudgetspreiding;
        frmGebruikerBeheer frmGebruikerBeheer;
        frmAankopen frmAankopen;
        frmGeplandeAankopen frmGeplandeAankopen;
        frmGeweigerdeAanvragen frmGeweigerdeAanvragen;
        frmGrafiekStatusAanvraagPerFinancieringsjaar frmGrafiekStatusAanvraagPerFinancieringsjaar;
        frmGrafiekBudgetSpreiding frmGrafiekBudgetSpreiding;
        frmGrafiekEvolutieBudgetten frmGrafiekEvolutieBugetten;
        frmBeheerKostenplaatsen frmBeheerKostenplaatsen;
        frmBeheerAfdelingen frmBeheerAfdelingen;
        frmBeheerDiensten frmBeheerDiensten;
        frmBeheerInvesteringsType frmBeheerInvesteringsType;
        frmBeheerFinancieringsType frmBeheerFinancieringsType;
        frmPrioriteit frmPrioriteit;
        frmBeheerLanden frmBeheerLanden;
        frmBeheerLeverancier frmBeheerLeverancier;

        Image imgGebruikersbeheer;
        Image imgGoedkeuringen;
        Image imgParameters;
        Image imgGebruikslog;
        Image imgAanvragen;
        Image imgBudgetspreiding;
        Image imgAankopers;
        Image imgAfdelingen;
        Image imgDiensten;
        Image imgKostenplaats;




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
       
            this.DoubleBuffered = true;
        }


        private void DisableMdiScrollBars()
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient client)
                {
                    client.Dock = DockStyle.Fill;

                    // Schakel scrollbars uit via de Windows stijl
                    const int WS_HSCROLL = 0x00100000;
                    const int WS_VSCROLL = 0x00200000;

                    int style = (int)NativeMethods.GetWindowLong(client.Handle, NativeMethods.GWL_STYLE);
                    style &= ~WS_HSCROLL;
                    style &= ~WS_VSCROLL;
                    NativeMethods.SetWindowLong(client.Handle, NativeMethods.GWL_STYLE, (IntPtr)style);
                }
            }
        }
        internal static class NativeMethods
        {
            public const int GWL_STYLE = -16;

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        }

        private static void ErrorHandler(string customMessage, Exception ex, string location)
        {
            MessageBox.Show($"Error: {customMessage} - {ex.Message} in {location}", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
 
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
           
            mdiClient?.Invalidate();
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

        public static void laadGrafischeParameters()
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

        private void MdiClient_Paint(object sender, PaintEventArgs e)
        {
            if (StyleParameters.LogoG == null)
                return;

            Image logo = StyleParameters.LogoG;
            MdiClient client = (MdiClient)sender;

            int x = (client.ClientSize.Width - logo.Width) / 2;
            int y = (client.ClientSize.Height - logo.Height) / 2;

            e.Graphics.DrawImage(logo, x, y);
        }
        public void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;
            toolStrip.BackColor = StyleParameters.AccentKleur;
            menuStrip.BackColor = StyleParameters.AccentKleur;
            menuStrip.ForeColor = StyleParameters.Buttontext;
            beheerToolStripMenuItem.BackColor = StyleParameters.AccentKleur;

            beheerToolStripMenuItem.DropDown.BackColor = StyleParameters.AccentKleur;
            beheerToolStripMenuItem.DropDown.ForeColor = StyleParameters.Buttontext;

         

            foreach (Control c in this.Controls)
            {
                if (c is MdiClient client)
                {
                    mdiClient = client;
                    mdiClient.BackColor = StyleParameters.Achtergrondkleur;
                    mdiClient.Paint += MdiClient_Paint;
                    mdiClient.Resize += (s, e) => mdiClient.Invalidate();
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
                imgAankopers = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-businessman-50-alt.png"));
                imgAfdelingen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-department-50-alt.png"));
                imgDiensten = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-dienst-50-alt.png"));
                imgKostenplaats = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-cost-euro-50-alt.png"));
            }
            else
            {
                imgGebruikersbeheer = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-users-48.png"));
                imgGoedkeuringen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-approval-50.png"));
                imgParameters = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-parameters-66.png"));
                imgGebruikslog = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-log-80.png"));
                imgAanvragen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-form-80.png"));
                imgBudgetspreiding = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-euro-50.png"));
                imgAankopers = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-businessman-50.png"));
                imgAfdelingen = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-department-50.png"));
                imgDiensten = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-dienst-50.png"));
                imgKostenplaats = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-cost-euro-50.png"));
            }

            gebruikersToolStripButton.Image = imgGebruikersbeheer;
            goedkeuringenToolStripButton.Image = imgGoedkeuringen;
            aanvragenToolStripButton.Image = imgAanvragen;
            gebruiksLogToolStripButton.Image = imgGebruikslog;
            parameterToolStripButton.Image = imgParameters;
            budgetSpreidingtoolStripButton.Image = imgBudgetspreiding;
            aankopersToolStripButton.Image = imgAankopers;
            afdelingToolStripButton.Image = imgAfdelingen;
            dienstToolStripButton.Image = imgDiensten;
            kostenplaatsToolStripButton.Image = imgKostenplaats;
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
                aankopersToolStripButton.Visible = false;
                afdelingToolStripButton.Visible = false;
                dienstToolStripButton.Visible = false;
                kostenplaatsToolStripButton.Visible = false;
                helpMenu.Visible = true;
                goedkeuringenToolStripMenuItem.Visible = false;
                overzichtenToolStripMenuItem.Visible = false;
                budgetoverzichtToolStripMenuItem.Visible = false;
                budgetSpreidingtoolStripButton.Visible = false;
                aankopenToolStripMenuItem.Visible = false;
            }

            //Aankoper - items voor aankoper worden extra bij aangezett
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
                aankopenToolStripMenuItem.Visible = true;

                beheerToolStripMenuItem.Visible = false;
                gebruiksLogToolStripButton.Visible = false;
                parameterToolStripButton.Visible = false;
                gebruikersToolStripButton.Visible = false;
                aankopersToolStripButton.Visible = false;
                afdelingToolStripButton.Visible = false;
                dienstToolStripButton.Visible = false;
                kostenplaatsToolStripButton.Visible = false;
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
                aankopersToolStripButton.Visible = false;
                afdelingToolStripButton.Visible = false;
                dienstToolStripButton.Visible = false;
                kostenplaatsToolStripButton.Visible = false;

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
                aankopersToolStripButton.Visible = true;
                //TODO: Afdelingen en diensten tijdelijk uitgezet tot items klaar zijn.
                afdelingToolStripButton.Visible = true;
                afdelingenToolStripMenuItem.Visible = true;
                dienstToolStripButton.Visible = true;
                dienstenToolStripMenuItem.Visible = true;
                financieringsTypesToolStripMenuItem.Visible = true;
                investeringsTypesToolStripMenuItem.Visible = true;

                kostenplaatsToolStripButton.Visible = true;

                tss3.Visible = true;
                overzichtenToolStripMenuItem.Visible = true;
                budgetoverzichtToolStripMenuItem.Visible = true;
                budgetSpreidingtoolStripButton.Visible = true;

                //TO DO: Dit is onvoldoende uitgewerkt om al gebruikt te worden.
                aankopenToolStripMenuItem.Visible = true;
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
            if (AppForms.frmAbout == null)
            {
                AppForms.frmAbout = new frmAbout();
                AppForms.frmAbout.MdiParent = this;
            }
            AppForms.frmAbout.Show();
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

            DisableMdiScrollBars();

            string rollen = GetRollen();
            toolStripStatusLabel.Text = $"Gebruiker: {Program.Gebruiker} Rollen: {rollen}";

          

            MenubalkSamenstellen();
            CreateUI();
        }

        private void aanvragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppForms.frmAanvragen == null)
            {
                AppForms.frmAanvragen = new FrmAanvragen();
                AppForms.frmAanvragen.MdiParent = this;
            }
            AppForms.frmAanvragen.Show();
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
            if (AppForms.frmAanvragen == null)
            {
                AppForms.frmAanvragen = new FrmAanvragen();
                AppForms.frmAanvragen.MdiParent = this;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Dock = DockStyle.Fill;
                this.StartPosition = FormStartPosition.Manual;
                this.AutoScroll = false;
            }
            AppForms.frmAanvragen.Show();

        }

        private void goedkeuringenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppForms.frmGoedkeuring == null)
            {
                AppForms.frmGoedkeuring = new frmGoedkeuring();
                AppForms.frmGoedkeuring.MdiParent = this;
            }
            AppForms.frmGoedkeuring.Show();
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
            if (AppForms.frmGoedkeuring == null)
            {
                AppForms.frmGoedkeuring = new frmGoedkeuring();
                AppForms.frmGoedkeuring.MdiParent = this;
            }
            AppForms.frmGoedkeuring.Show();
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

        private void kostenplaatsenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBeheerKostenplaatsen == null)
            {
                frmBeheerKostenplaatsen = new frmBeheerKostenplaatsen();
                frmBeheerKostenplaatsen.MdiParent = this;
            }
            frmBeheerKostenplaatsen.Show();
        }

        private void aankopersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AppForms.frmBeheerAankopers == null)
            {
                AppForms.frmBeheerAankopers = new frmBeheerAankopers();
                AppForms.frmBeheerAankopers.MdiParent = this;
            }
            AppForms.frmBeheerAankopers.Show();
        }

        private void afdelingenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBeheerAfdelingen == null)
            {
                frmBeheerAfdelingen = new frmBeheerAfdelingen();
                frmBeheerAfdelingen.MdiParent = this;
            }
            frmBeheerAfdelingen.Show();
        }

        private void dienstenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBeheerDiensten == null)
            {
                frmBeheerDiensten = new frmBeheerDiensten();
                frmBeheerDiensten.MdiParent = this;
            }
            frmBeheerDiensten.Show();
        }

        private void aankopersToolStripButton_Click(object sender, EventArgs e)
        {
            if (AppForms.frmBeheerAankopers == null)
            {
                AppForms.frmBeheerAankopers = new frmBeheerAankopers();
                AppForms.frmBeheerAankopers.MdiParent = this;
            }
            AppForms.frmBeheerAankopers.Show();
        }

        private void afdelingenToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmBeheerAfdelingen == null)
            {
                frmBeheerAfdelingen = new frmBeheerAfdelingen();
                frmBeheerAfdelingen.MdiParent = this;
            }
            frmBeheerAfdelingen.Show();
        }

        private void dienstToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmBeheerDiensten == null)
            {
                frmBeheerDiensten = new frmBeheerDiensten();
                frmBeheerDiensten.MdiParent = this;
            }
            frmBeheerDiensten.Show();
        }

        private void kostenplaatsToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmBeheerKostenplaatsen == null)
            {
                frmBeheerKostenplaatsen = new frmBeheerKostenplaatsen();
                frmBeheerKostenplaatsen.MdiParent = this;
            }
            frmBeheerKostenplaatsen.Show();
        }

        private void investeringsTypesToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmBeheerInvesteringsType == null)
            {
                frmBeheerInvesteringsType = new frmBeheerInvesteringsType();
                frmBeheerInvesteringsType.MdiParent = this;
            }
            frmBeheerInvesteringsType.Show();
        }

        private void financieringsTypesToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmBeheerFinancieringsType == null)
            {
                frmBeheerFinancieringsType = new frmBeheerFinancieringsType(); /// wees eerst naar investering waardoor het niet werkte
                frmBeheerFinancieringsType.MdiParent = this;
            }
            frmBeheerFinancieringsType.Show();
        }

        private void prioriteitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPrioriteit == null)
            {
                frmPrioriteit = new frmPrioriteit();
                frmPrioriteit.MdiParent = this;
            }
            frmPrioriteit.Show();
        }

        private void landenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBeheerLanden == null)
            {
                frmBeheerLanden = new frmBeheerLanden();
                frmBeheerLanden.MdiParent = this;
            }
            frmBeheerLanden.Show();
        }

        private void leverancierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBeheerLeverancier == null)
            {
                frmBeheerLeverancier = new frmBeheerLeverancier();
                frmBeheerLeverancier.MdiParent = this;
            }
            frmBeheerLeverancier.Show();
        }
    }
}

