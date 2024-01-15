using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiaLogic.Manager;

namespace MiaClient
{
    public partial class frmGebruikerBeheer : Form
    {
        public frmGebruikerBeheer()
        {
            InitializeComponent();
        }

        private void LstGebruikers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmGebruikerBeheer_Load(object sender, EventArgs e)
        {
            if (RadAlle.Checked == true)
            {
                
                LstGebruikers.Items.Add(GebruikerManager.GetGebruikers());
            }
            
        }

        private void frmGebruikerBeheer_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
