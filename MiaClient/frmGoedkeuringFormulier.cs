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

        public frmGoedkeuring frmGoedkeuring;
        private int aanvraagId = 0;

        bool inaanvraag = false;
        bool goedkeur = false;
        bool afkeur = false;
        bool bekrachtig = false;
        bool nietbekrachtig = false;

        public string projectDirectory = Directory.GetCurrentDirectory();


        public frmGoedkeuringFormulier()
        {
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
        }

        public frmGoedkeuringFormulier(int id, string action)
        {
            aanvraagId = id;

            var aanvraag = AanvraagManager.GetAanvraagById(aanvraagId);

            txtGebruiker.Text = aanvraag.Gebruiker.ToString();
            txtTitel.Text = aanvraag.Titel.ToString();
            txtAanvraagMoment.Text = aanvraag.Aanvraagmoment.ToString();
            txtFinancieringsJaar.Text = aanvraag.Financieringsjaar.ToString();
            txtBedrag.Text = (aanvraag.PrijsIndicatieStuk * aanvraag.AantalStuk).ToString();
        }

        private void pcbInAanvraag_Click(object sender, EventArgs e)
        {
            if (inaanvraag == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "aanvraag.png");
                pcbInAanvraag.Image = Image.FromFile(imagePath);

                inaanvraag = true;


            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "AanvraagUit.png");
                pcbInAanvraag.Image = Image.FromFile(imagePath);

                inaanvraag = false;
            }

            pcbGoedgekeurd.Enabled = true;
            pcbNietBekrachtigd.Enabled = true;
            pcbAfgekeurd.Enabled = true;
            pcbBekrachtigd.Enabled = true;

        }

        private void pcbGoedgekeurd_Click(object sender, EventArgs e)
        {
            if (goedkeur == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
                pcbGoedgekeurd.Image = Image.FromFile(imagePath);

                goedkeur = true;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = false;
                pcbBekrachtigd.Enabled = true;
            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_uit.png");
                pcbGoedgekeurd.Image = Image.FromFile(imagePath);

                goedkeur = false;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = true;
                pcbBekrachtigd.Enabled = true;
            }
        }

        private void pcbAfgekeurd_Click(object sender, EventArgs e)
        {
            if (afkeur == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
                pcbGoedgekeurd.Image = Image.FromFile(imagePath);

                afkeur = true;

                pcbGoedgekeurd.Enabled = false;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = true;
                pcbBekrachtigd.Enabled = true;
            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_uit.png");
                pcbGoedgekeurd.Image = Image.FromFile(imagePath);

                afkeur = false;
            }
        }

        private void pcbBekrachtigd_Click(object sender, EventArgs e)
        {
            if (bekrachtig == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
                pcbBekrachtigd.Image = Image.FromFile(imagePath);

                bekrachtig = true;

                pcbGoedgekeurd.Enabled = false;
                pcbNietBekrachtigd.Enabled = false;
                pcbAfgekeurd.Enabled = false;
                pcbBekrachtigd.Enabled = true;
            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_uit.png");
                pcbBekrachtigd.Image = Image.FromFile(imagePath);

                bekrachtig = false;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = true;
                pcbBekrachtigd.Enabled = true;
            }
        }

        private void pcbNietBekrachtigd_Click(object sender, EventArgs e)
        {
            if (nietbekrachtig == false)
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
                pcbNietBekrachtigd.Image = Image.FromFile(imagePath);

                nietbekrachtig = true;

                pcbGoedgekeurd.Enabled = false;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = false;
                pcbBekrachtigd.Enabled = false;
            }
            else
            {
                string imagePath = Path.Combine(projectDirectory, "icons", "Afgekeurd_uit.png");
                pcbNietBekrachtigd.Image = Image.FromFile(imagePath);

                nietbekrachtig = false;

                pcbGoedgekeurd.Enabled = true;
                pcbNietBekrachtigd.Enabled = true;
                pcbAfgekeurd.Enabled = true;
                pcbBekrachtigd.Enabled = true;
            }
        }

        private void frmGoedkeuringFormulier_Load(object sender, EventArgs e)
        {

        }
    }
}
