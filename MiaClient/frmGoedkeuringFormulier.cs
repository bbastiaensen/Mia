using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class frmGoedkeuringFormulier : Form
    {
        public event EventHandler AanvraagBewaard;

        private int aanvraagId = 0;

        public frmGoedkeuringFormulier()
        {

            Initialize();

        }

        private void Initialize()
        {
            InitializeComponent();
            //vulFormulier();
            //SetFormStatus(false);
            //GetParam();
        }

        public frmGoedkeuringFormulier(int id, string action)
        {
            aanvraagId = id;
            Aanvraag aanvraag = new Aanvraag();
        }


    }
}
