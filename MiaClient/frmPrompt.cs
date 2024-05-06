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

namespace MiaClient
{
    public partial class frmPrompt : Form
    {
        frmGebruikerBeheer frmGebruikerBeheer;

        public frmPrompt()
        {
            InitializeComponent();
        }

        private void btnControleren_Click(object sender, EventArgs e)
        {
            string bckdrcd = ParameterManager.GetParameterByCode("Backdoor").Waarde;

            if (bckdrcd == txtCode.Text)
            {
                if (frmGebruikerBeheer == null)
                {
                    frmGebruikerBeheer = new frmGebruikerBeheer();
                    frmGebruikerBeheer.MdiParent = this.MdiParent;
                }
                frmGebruikerBeheer.Show();
            }
            else
            {
                GebruiksLogManager.SaveGebruiksLog(new GebruiksLog
                {
                    Gebruiker = Program.Gebruiker,
                    Id = -1,
                    TijdstipActie = DateTime.Now,
                    OmschrijvingActie = $"Gebruiker {Program.Gebruiker} probeerde niet succesvol de backdoor te gebruiken."
                }, true);
            }
        }

        private void frmPrompt_Load(object sender, EventArgs e)
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            btnControleren.FlatStyle = FlatStyle.Flat;
            btnControleren.FlatAppearance.BorderSize = 0;
            btnControleren.BackColor = StyleParameters.ButtonBack;
            btnControleren.ForeColor = StyleParameters.Buttontext;
        }
    }
}
