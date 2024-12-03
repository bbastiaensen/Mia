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
        public int AanvraagStatusId { get; set; }
        public string Titel { get; set; }
        public string Financieringsjaar { get; set; }
        public decimal PrijsIndicatieStuk { get; set; }
        public int AantalStuk { get; set; }
        public decimal Bedrag { get; set; }
        public Boolean Even { get; set; }

        public event EventHandler GoedkeurDeleted;
        public event EventHandler GoedkeurItemSelected;
        public event EventHandler GoedkeurItemChanged;
        frmGoedkeuring frmGoedkeuring;

        public string projectDirectory = Directory.GetCurrentDirectory();

        public GoedkeurItem()
        {
            InitializeComponent();
        }

        public GoedkeurItem(int id, string aanvrager, DateTime aanvraagmoment, int aanvraagStatusId, string titel, string financieringsjaar, Decimal bedrag, Boolean even)
        {
            InitializeComponent();
            Id = id;
            Aanvrager = aanvrager;
            AanvraagStatusId = aanvraagStatusId;
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
            lblBedrag.Text = Bedrag.ToString("c", CultureInfo.CurrentCulture);
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
            string imageaf = Path.Combine(projectDirectory, "icons", "Goedgekeurd_aan.png");
            string imageBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
            string imagenietaan = Path.Combine(projectDirectory, "icons", "Aanvraag_uit.png");



            btnNietBekrachtigd.Image = Image.FromFile(imageNietBekracht);
            btnAfgekeurd.Image = Image.FromFile(imageaf);
            btnNietBekrachtigd.Image = Image.FromFile(imageBekracht);
            btnInaanvraag.Image = Image.FromFile(imagenietaan);
            btnInaanvraag.Enabled = false;


        }

        private void btnAfgekeurd_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
            btnAfgekeurd.Image = Image.FromFile(imagePath);
            Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
            aanvraag.StatusAanvraagId = 3;
            AanvraagManager.SaveAanvraag(aanvraag, false);
          
            string imageNietBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
            string imagegoed = Path.Combine(projectDirectory, "icons", "goedgekeurd_uit.png");
            string imageBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
            string imagenietaan = Path.Combine(projectDirectory, "icons", "Aanvraag_uit.png");


            btnNietBekrachtigd.Image = Image.FromFile(imageNietBekracht);
            BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
            btnNietBekrachtigd.Image = Image.FromFile(imageBekracht);
            btnInaanvraag.Image = Image.FromFile(imagenietaan);
            btnInaanvraag.Enabled = true;


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
            string imagenietaan = Path.Combine(projectDirectory, "icons", "Aanvraag_uit.png");


            btnAfgekeurd.Image = Image.FromFile(imageaf);
            BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
            btnNietBekrachtigd.Image = Image.FromFile(imageBekracht);
            btnInaanvraag.Image = Image.FromFile(imagenietaan);

            btnAfgekeurd.Enabled = false;
            BtnGoedgekeurd.Enabled = false;
            btnNietBekrachtigd.Enabled = false;
            btnInaanvraag.Enabled = false;

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
            string imagenietaan = Path.Combine(projectDirectory, "icons", "Aanvraag_uit.png");


            btnAfgekeurd.Image = Image.FromFile(imageaf);
            BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
            btnBekrachtigd.Image = Image.FromFile(imageBekracht);
            btnInaanvraag.Image = Image.FromFile(imagenietaan);
            btnInaanvraag.Enabled = false;


        }

        private void GoedkeurItem_Load(object sender, EventArgs e)
        {
            //Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);

            switch (AanvraagStatusId)
            {
                case 1:
                    string imagePath5 = Path.Combine(projectDirectory, "icons", "aanvraag.png");
                    btnInaanvraag.Image = Image.FromFile(imagePath5);

                    break;
                case 2:
                    string imagePath = Path.Combine(projectDirectory, "icons", "Goedgekeurd_aan.png");
                    BtnGoedgekeurd.Image = Image.FromFile(imagePath);
                    btnInaanvraag.Enabled = false;

                    break;
                case 3:
                    string imagePath2 = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
                    btnAfgekeurd.Image = Image.FromFile(imagePath2);
                    
                    break;
                case 4:
                    string imagePath3 = Path.Combine(projectDirectory, "icons", "bekrachtigd_aan.png");
                    btnBekrachtigd.Image = Image.FromFile(imagePath3);
                    btnInaanvraag.Enabled = false;
                    btnAfgekeurd.Enabled = false;
                    BtnGoedgekeurd.Enabled = false;
                    btnNietBekrachtigd.Enabled = false;
                    break;
                case 5:
                    string imagePath4= Path.Combine(projectDirectory, "icons", "NietBekrachtigd_aan.png");
                    btnNietBekrachtigd.Image = Image.FromFile(imagePath4);
                    btnInaanvraag.Enabled = false;


                    break;
                
            }
        }

        private void btnInaanvraag_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(projectDirectory, "icons", "aanvraag.png");
            btnInaanvraag.Image = Image.FromFile(imagePath);
            Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
            aanvraag.StatusAanvraagId = 1;
            AanvraagManager.SaveAanvraag(aanvraag, false);
            string imageaf = Path.Combine(projectDirectory, "icons", "Afgekeurd_uit.png");
            string imagegoed = Path.Combine(projectDirectory, "icons", "goedgekeurd_uit.png");
            string imageBekracht = Path.Combine(projectDirectory, "icons", "bekrachtigd_uit.png");
            string imagenietbe = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");


            btnAfgekeurd.Image = Image.FromFile(imageaf);
            BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
            btnBekrachtigd.Image = Image.FromFile(imageBekracht);
            btnNietBekrachtigd.Image = Image.FromFile(imagenietbe);
            
        }
    }
}
