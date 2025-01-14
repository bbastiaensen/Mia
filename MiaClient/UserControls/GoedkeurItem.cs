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
        public string StatusAanvraag { get; set; }
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

        public GoedkeurItem(int id, string aanvrager, DateTime aanvraagmoment, string titel, string financieringsjaar, decimal PrijsIndicatiePerStuk, int AantalStuk, string Statusaanvraag, Boolean even)
        {
            InitializeComponent();
            Id = id;
            StatusAanvraag = Statusaanvraag;
            Aanvrager = aanvrager;
            Titel = titel;
            Aanvraagmoment = aanvraagmoment;
            Financieringsjaar = financieringsjaar;

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

        private void GoedkeurItem_Load(object sender, EventArgs e)
        {
            Goedkeuring goedkeuring = GoedkeuringManager.GetGoedkeuringById(Id);

            switch (Id)
                {
                    case 2:
                        string imagePath = Path.Combine(projectDirectory, "icons", "Goedgekeurd_aan.png");
                        BtnGoedgekeurd.Image = Image.FromFile(imagePath);

                        break;
                    case 3:
                        string imagePath2 = Path.Combine(projectDirectory, "icons", "Afgekeurd_aan.png");
                        btnAfgekeurd.Image = Image.FromFile(imagePath2);

                        break;
                    case 4:
                        string imagePath3 = Path.Combine(projectDirectory, "icons", "bekrachtigd_aan.png");
                        btnBekrachtigd.Image = Image.FromFile(imagePath3);

                        break;
                    case 5:
                        string imagePath4 = Path.Combine(projectDirectory, "icons", "NietBekrachtigd_aan.png");
                        btnNietBekrachtigd.Image = Image.FromFile(imagePath4);
                        break;
                }
                return;
        }
    }
}
