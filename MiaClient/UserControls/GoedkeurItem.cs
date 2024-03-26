using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class GoedkeurItem : UserControl
    {
        public int Id { get; set; }
        public string Aanvrager { get; set; }
        public DateTime Aanvraagmoment { get; set; }
        public string Titel { get; set; }
        public string Financieringsjaar { get; set; }
        public Decimal Bedrag { get; set; }

        public GoedkeurItem()
        {
            InitializeComponent();
        }
        public GoedkeurItem(int id, string aanvrager, DateTime aanvraagmoment, string titel, string financieringsjaar,Decimal bedrag )
        {
         InitializeComponent();
         Id = id;
         Aanvrager = aanvrager;
         Titel = titel;
         Aanvraagmoment = aanvraagmoment;
         Financieringsjaar = financieringsjaar;
         Bedrag = bedrag;
            SetGoedkeurItemWaarden();
        }
        private void SetGoedkeurItemWaarden()
        {
            lblTitel.Text = Titel;
            lblBedrag.Text = Bedrag.ToString();
            lblFinancieringsjaar.Text = Financieringsjaar.ToString();
            LblAanvrager.Text = Aanvrager;
            lblAanvraagmoment.Text = Aanvraagmoment.ToString();
        }
      

       
       

        

    }
}
