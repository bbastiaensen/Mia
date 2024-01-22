using MiaLogic.Object;
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
            InitializeComponent();
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

        private void mdiMia_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = $"Gebruiker: {Program.Gebruiker} Rol: {Program.Rol}";
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
            if (frmGebruikerBeheer ==  null)
            {
                frmGebruikerBeheer = new frmGebruikerBeheer();
                frmGebruikerBeheer.MdiParent = this;    
            }
            frmGebruikerBeheer.Show();
        }
    }
}
