using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiaClient.UserControls;

namespace MiaClient
{
    public partial class frmAbout : MdiChildBoundedForm
    {
        frmPrompt frmPrompt;

        public frmAbout()
        {
            InitializeComponent();
        }

        private void llblProjectLogoAttribution_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                llblProjectLogoAttribution.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.flaticon.com/free-icons/hair");
            }
            catch (Exception)
            {
                MessageBox.Show("De link kon niet worden geopend.");
            }
        }

        private void llblTaTu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                llblTaTu.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.talentenschoolturnhout.be/");
            }
            catch (Exception)
            {
                MessageBox.Show("De link kon niet worden geopend.");
            }
        }

        private void llblMuylenberg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                llblMuylenberg.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.muylenberg.be/");
            }
            catch (Exception)
            {
                MessageBox.Show("De link kon niet worden geopend.");
            }
        }

        private void llblIconsByIcon8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                llblIconsByIcon8.LinkVisited = true;
                System.Diagnostics.Process.Start("https://icons8.com");
            }
            catch (Exception)
            {
                MessageBox.Show("De link kon niet worden geopend.");
            }
        }

        private void pbxProjectLogo_DoubleClick(object sender, EventArgs e)
        {
            if (frmPrompt == null)
            {
                frmPrompt = new frmPrompt();
                frmPrompt.MdiParent = this.MdiParent;
            }
            frmPrompt.Show();

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (AppForms.frmSaldoOverzetten == null)
            {
                AppForms.frmSaldoOverzetten = new frmSaldoOverzetten(0);
                AppForms.frmSaldoOverzetten.MdiParent = this.MdiParent;
            }
            AppForms.frmSaldoOverzetten.Show();
        }
    }
}
