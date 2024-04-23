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
    public partial class frmAbout : Form
    {
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
    }
}
