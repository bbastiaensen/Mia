using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
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

namespace MiaClient
{
    public partial class FrmGebruiksLog : Form
    {
        public FrmGebruiksLog()
        {
            InitializeComponent();

            GebruiksLogManager.ConnectionString = ConfigurationManager.ConnectionStrings["MiaCn"].ConnectionString;
        }

        private void frmGebruiksLogDemo_Load(object sender, EventArgs e)
        {
            try
            {
                List<GebruiksLog> gebruiksLogs = GebruiksLogManager.GetGebruiksLogs();

                int xPos = 12;
                int yPos = 155;
                int t = 0;

                foreach (var gl in gebruiksLogs)
                {
                    GebruikslogItem gli = new GebruikslogItem(gl.Id, gl.TijdstipActie, gl.Gebruiker, gl.OmschrijvingActie, t % 2 == 0);
                    gli.Location = new System.Drawing.Point(xPos, yPos);
                    gli.Name = "gebruiksLogSelection" + t;
                    gli.Size = new System.Drawing.Size(881, 33);
                    gli.TabIndex = t + 8;
                    this.Controls.Add(gli);

                    //Voorbereiden voor de volgende control
                    t++;
                    if (t < 10)
                    {
                        yPos += 30;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
