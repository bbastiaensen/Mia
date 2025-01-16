using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        //private void BtnGoedgekeurd_Click(object sender, EventArgs e)
        //{
        //    string imagePath = Path.Combine(projectDirectory, "icons", "Goedgekeurd_aan.png");
        //    BtnGoedgekeurd.Image = Image.FromFile(imagePath);
        //    Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
        //    aanvraag.StatusAanvraagId = 2;
        //    AanvraagManager.SaveAanvraag(aanvraag, false);
        //    string imageNietBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
        //    string imageaf = Path.Combine(projectDirectory, "icons", "Goedgekeurd_aan.png");
        //    string imageBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
        //    string imagenietaan = Path.Combine(projectDirectory, "icons", "Aanvraag_uit.png");



        //    btnNietBekrachtigd.Image = Image.FromFile(imageNietBekracht);
        //    btnAfgekeurd.Image = Image.FromFile(imageaf);
        //    btnNietBekrachtigd.Image = Image.FromFile(imageBekracht);
        //    btnInaanvraag.Image = Image.FromFile(imagenietaan);
        //    btnInaanvraag.Enabled = false;


        //}

        //private void btnAfgekeurd_Click(object sender, EventArgs e)
        //{
        //    string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
        //    btnAfgekeurd.Image = Image.FromFile(imagePath);
        //    Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
        //    aanvraag.StatusAanvraagId = 3;
        //    AanvraagManager.SaveAanvraag(aanvraag, false);

        //    string imageNietBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
        //    string imagegoed = Path.Combine(projectDirectory, "icons", "goedgekeurd_uit.png");
        //    string imageBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
        //    string imagenietaan = Path.Combine(projectDirectory, "icons", "Aanvraag_uit.png");


        //    btnNietBekrachtigd.Image = Image.FromFile(imageNietBekracht);
        //    BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
        //    btnNietBekrachtigd.Image = Image.FromFile(imageBekracht);
        //    btnInaanvraag.Image = Image.FromFile(imagenietaan);
        //    btnInaanvraag.Enabled = true;


        //}

        //private void btnBekrachtigd_Click(object sender, EventArgs e)
        //{
        //    string imagePath = Path.Combine(projectDirectory, "icons", "bekrachtigd_aan.png");
        //    btnBekrachtigd.Image = Image.FromFile(imagePath);
        //    Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
        //    aanvraag.StatusAanvraagId = 4;
        //    AanvraagManager.SaveAanvraag(aanvraag, false);
        //    string imageaf = Path.Combine(projectDirectory, "icons", "Afgekeurd_uit.png");
        //    string imagegoed = Path.Combine(projectDirectory, "icons", "goedgekeurd_uit.png");
        //    string imageBekracht = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_uit.png");
        //    string imagenietaan = Path.Combine(projectDirectory, "icons", "Aanvraag_uit.png");


        //    btnAfgekeurd.Image = Image.FromFile(imageaf);
        //    BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
        //    btnNietBekrachtigd.Image = Image.FromFile(imageBekracht);
        //    btnInaanvraag.Image = Image.FromFile(imagenietaan);

        //    btnAfgekeurd.Enabled = false;
        //    BtnGoedgekeurd.Enabled = false;
        //    btnNietBekrachtigd.Enabled = false;
        //    btnInaanvraag.Enabled = false;

        //}

        //private void btnNietBekrachtigd_Click(object sender, EventArgs e)
        //{
        //    string imagePath = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_aan.png");
        //    btnNietBekrachtigd.Image = Image.FromFile(imagePath);
        //    Aanvraag aanvraag = AanvraagManager.GetAanvraagById(Id);
        //    aanvraag.StatusAanvraagId = 5;
        //    AanvraagManager.SaveAanvraag(aanvraag, false);
        //    string imageaf = Path.Combine(projectDirectory, "icons", "Afgekeurd_uit.png");
        //    string imagegoed = Path.Combine(projectDirectory, "icons", "goedgekeurd_uit.png");
        //    string imageBekracht = Path.Combine(projectDirectory, "icons", "bekrachtigd_uit.png");
        //    string imagenietaan = Path.Combine(projectDirectory, "icons", "Aanvraag_uit.png");


        //    btnAfgekeurd.Image = Image.FromFile(imageaf);
        //    BtnGoedgekeurd.Image = Image.FromFile(imagegoed);
        //    btnBekrachtigd.Image = Image.FromFile(imageBekracht);
        //    btnInaanvraag.Image = Image.FromFile(imagenietaan);
        //    btnInaanvraag.Enabled = false;


        //}

        //private void GoedkeurItem_Load(object sender, EventArgs e)
        //{
        //    Aanvraag goedkeuring = AanvraagManager.GetAanvraagById(Id);

        //    switch (Id)
        //    {
        //        case 2:
        //            string imagePath = Path.Combine(projectDirectory, "icons", "Goedgekeurd_aan.png");
        //            BtnGoedgekeurd.Image = Image.FromFile(imagePath);

        //            break;
        //        case 3:
        //            string imagePath2 = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
        //            btnAfgekeurd.Image = Image.FromFile(imagePath2);

        //            break;
        //        case 4:
        //            string imagePath3 = Path.Combine(projectDirectory, "icons", "bekrachtigd_aan.png");
        //            btnBekrachtigd.Image = Image.FromFile(imagePath3);

        //            break;
        //        case 5:
        //            string imagePath4 = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_aan.png");
        //            btnNietBekrachtigd.Image = Image.FromFile(imagePath4);
        //            break;
        //    }
        //    return;
        //}

        public frmGoedkeuringFormulier(int id, string action)
        {
            aanvraagId = id;
            Aanvraag aanvraag = new Aanvraag();
        }
    }
}
