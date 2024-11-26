using MiaClient.UserControls;
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
                    GoedkeurItem agi = new GoedkeurItem(av.Id, av.Gebruiker, av.Aanvraagmoment, av.Titel, av.Financieringsjaar, av.PrijsIndicatieStuk, av.AantalStuk, t % 2 == 0);
                    agi.Location = new System.Drawing.Point(xPos, yPos);
                    agi.Name = "aanvraagSelection" + t;
                    agi.Size = new System.Drawing.Size(1210, 33);
                    agi.TabIndex = t + 8;
                    agi.GoedkeurItemSelected += Gli_GoedkeurItemSelected;
                    agi.GoedkeurDeleted += Agi_GoedkeurItemChanged;
                    agi.GoedkeurItemChanged += Ai_GoedkeurItemChanged;
                    this.pnlGoedkeuringen.Controls.Add(agi);

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
