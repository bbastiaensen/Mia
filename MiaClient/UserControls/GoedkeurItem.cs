using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
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
        public Boolean Even { get; set; }

       public string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        public GoedkeurItem()
        {
            InitializeComponent();
        }
        public GoedkeurItem(int id, string aanvrager, DateTime aanvraagmoment, string titel, string financieringsjaar,Decimal bedrag,Boolean even )
        {
         InitializeComponent();
         Id = id;
         Aanvrager = aanvrager;
         Titel = titel;
         Aanvraagmoment = aanvraagmoment;
         Financieringsjaar = financieringsjaar;
         Bedrag = bedrag;
         Even = even;
            SetGoedkeurItemWaarden();
        }
        private void SetGoedkeurItemWaarden()
        {
            lblTitel.Text = Titel;
            lblBedrag.Text = Bedrag.ToString();
            lblFinancieringsjaar.Text = Financieringsjaar.ToString();
            LblAanvrager.Text = Aanvrager;
            lblAanvraagmoment.Text = Aanvraagmoment.ToString();
            if (Even)
            {
                this.BackColor = Color.White;
            }

            else
            {

                this.BackColor = StyleParameters.AccentKleur;
                this.ForeColor = StyleParameters.Buttontext;
                
            }
        }

        private void BtnGoedgekeurd_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(projectDirectory, "icons", "Goedgekeurd_aan.png");
            BtnGoedgekeurd.Image = Image.FromFile(imagePath);
            Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
            aanvraag.StatusAanvraagId = 2;
            AanvraagManager.SaveAanvraag(aanvraag, false);
            string imageNietBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
            string imageaf = Path.Combine(projectDirectory, "icons", "goedgekeurd_uit.png");
            string imageBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");

            btnNietBekrachtigd.Image = Image.FromFile(imageNietBekracht);
            btnAfgekeurd.Image = Image.FromFile(imageaf);
            btnNietBekrachtigd.Image = Image.FromFile(imageBekracht);
        }

        private void btnAfgekeurd_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
            btnAfgekeurd.Image = Image.FromFile(imagePath);
            Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
            aanvraag.StatusAanvraagId = 3;
            AanvraagManager.SaveAanvraag(aanvraag, false);
            btnBekrachtigd.Enabled = false;
            btnNietBekrachtigd.Enabled = false;
            string imageNietBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
            string imagegoed = Path.Combine(projectDirectory, "icons", "goedgekeurd_uit.png");
            string imageBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");

            btnNietBekrachtigd.Image = Image.FromFile(imageNietBekracht);
            BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
            btnNietBekrachtigd.Image = Image.FromFile(imageBekracht);
        }

        private void btnBekrachtigd_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(projectDirectory, "icons", "bekrachtigd_aan.png");
            btnBekrachtigd.Image = Image.FromFile(imagePath);
            Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
            aanvraag.StatusAanvraagId = 4;
            AanvraagManager.SaveAanvraag(aanvraag, false);
            string imageaf = Path.Combine(projectDirectory, "icons", "Afgekeurd_uit.png");
            string imagegoed = Path.Combine(projectDirectory, "icons", "goedgekeurd_uit.png");
            string imageBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");

            btnAfgekeurd.Image = Image.FromFile(imageaf);
            BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
            btnNietBekrachtigd.Image = Image.FromFile(imageBekracht);
            btnAfgekeurd.Enabled = false;
            BtnGoedgekeurd.Enabled = false;

        }

        private void btnNietBekrachtigd_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_aan.png");
            btnNietBekrachtigd.Image = Image.FromFile(imagePath);
            Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
            aanvraag.StatusAanvraagId = 5;
            AanvraagManager.SaveAanvraag(aanvraag, false);
            string imageaf = Path.Combine(projectDirectory, "icons", "Afgekeurd_uit.png");
            string imagegoed = Path.Combine(projectDirectory, "icons", "goedgekeurd_uit.png");
            string imageBekracht = Path.Combine(projectDirectory, "icons", "bekrachtigd_uit.png");

            btnAfgekeurd.Image = Image.FromFile(imageaf);
            BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
            btnBekrachtigd.Image = Image.FromFile(imageBekracht);
            btnAfgekeurd.Enabled = false;
            BtnGoedgekeurd.Enabled = false;
        }

        private void GoedkeurItem_Load(object sender, EventArgs e)
        {
            Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);

            switch (aanvraag.StatusAanvraagId)
            {
                case 2:
                    string imagePath = Path.Combine(projectDirectory, "icons", "Goedgekeurd_aan.png");
                    BtnGoedgekeurd.Image = Image.FromFile(imagePath); 
                    break;
                case 3:
                    string imagePath2 = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
                    btnAfgekeurd.Image = Image.FromFile(imagePath2);
                    btnBekrachtigd.Enabled = false;
                    btnNietBekrachtigd.Enabled = false;
                    break;
                case 4:
                    string imagePath3 = Path.Combine(projectDirectory, "icons", "bekrachtigd_aan.png");
                    btnBekrachtigd.Image = Image.FromFile(imagePath3);
                    btnAfgekeurd.Enabled = false;
                    BtnGoedgekeurd.Enabled = false;
                    break;
                case 5:
                    string imagePath4= Path.Combine(projectDirectory, "icons", "NietBekrachtigd_aan.png");
                    btnNietBekrachtigd.Image = Image.FromFile(imagePath4);
                    btnAfgekeurd.Enabled = false;
                    BtnGoedgekeurd.Enabled = false;
                    break;
            }
        }
    }
}
