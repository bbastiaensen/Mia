using MiaClient.UserControls;
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
    public partial class frmOffertesLog : Form
    {
        public frmOffertesLog()
        {
            InitializeComponent();
        }
        public void BindOfferte(List<Offerte> items)
        {
            this.pnlOfferte.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var av in items)
            {
                OffertesItem avi = new OffertesItem(av.Id, av.Titel, av.Url, av.AanvraagId);
                avi.Location = new System.Drawing.Point(xPos, yPos);
                avi.Name = "OfferteSelection" + t;
                avi.Size = new System.Drawing.Size(1210, 33);
                avi.TabIndex = t + 8;
                avi.OfferteItemSelected += Gli_OfferteItemSelected;
                //avi.AanvraagDeleted += Avi_AanvraagItemChanged;
                //avi.AanvraagItemChanged += Avi_AanvraagItemChanged;
                this.pnlOfferte.Controls.Add(avi);

                t++;
                yPos += 30;
            } 
        }
        private void Gli_OfferteItemSelected(object sender, EventArgs e)
        {
            OffertesItem geselecteerd = (OffertesItem)sender;
        }
    }
}
