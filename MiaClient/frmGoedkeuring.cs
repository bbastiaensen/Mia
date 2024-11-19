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
    public partial class frmGoedkeuring : Form
    {
        public frmGoedkeuring()
        {
            InitializeComponent();
        }

        public void BindAanvraag(List<Goedkeuring> items)
        {
            this.pnlGoedkeuringen.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            if (items != null)
            {
                foreach (var av in items)
                {
                    GoedkeurItem item = new GoedkeurItem(av.Id, av.Gebruiker, av.Aanvraagmoment, av.StatusAanvraagId,av.Titel, av.Financieringsjaar, av.Bedrag, t % 2 == 0);
                    item.Location = new System.Drawing.Point(xPos, yPos);
                    item.Name = "GoedkeurSelection" + t;
                    item.Size = new System.Drawing.Size(1034, 33);
                    item.TabIndex = t + 8;
                
                    this.pnlGoedkeuringen.Controls.Add(item);

                    t++;
                    yPos += 30;
                }
            }
        }

        private void frmGoedkeuring_Load(object sender, EventArgs e)
        {
            
        }

        private void frmGoedkeuring_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void frmGoedkeuring_Activated(object sender, EventArgs e)
        {
            var lijst = GoedkeuringManager.GetGoedkeuringen();
            BindAanvraag(lijst);
        }
    }
}
