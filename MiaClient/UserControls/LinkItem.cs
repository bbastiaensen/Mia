using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class LinkItem : UserControl
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string URL { get; set; }
        public int AanvraagId { get; set; }
        public Boolean Even { get; set; }

        public event EventHandler LinkDeleted;
        public event EventHandler LinkItemSelected;
        public event EventHandler LinkItemChanged;
        frmAanvraagFormulier frmAanvraagFormulier;
        public LinkItem()
        {
            InitializeComponent();
        }
        public LinkItem(int id, string titel, string url, int aanvraagId, Boolean even)
        {
            InitializeComponent();
            Id = id;
            Titel = titel;
            URL = url;
            AanvraagId = aanvraagId;
            Even = even;
            SetLinkItemWaarde();
        }
        private void SetLinkItemWaarde()
        {
            lblId.Text = Id.ToString();
            lblTitel.Text = Titel.ToString();
            if (Even)
            {
                this.BackColor = Color.White;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ben je zeker dat je deze Aanvraag wilt verwijderen?", "Aanvragen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (LinkDeleted != null)
                {
                    
                    
                    //Aanvraag aanvraag1 = new Aanvraag();
                    //aanvraag1.Id = Convert.ToInt32(lblId.Text);
                    //GebruiksLog gebruiksLog1 = new GebruiksLog();
                    //gebruiksLog1.Gebruiker = Program.Gebruiker;
                    //gebruiksLog1.TijdstipActie = DateTime.Now;
                    //gebruiksLog1.OmschrijvingActie = "Aanvraag " + aanvraag1.Id + " werd verwijderd door Gebruiker " + Program.Gebruiker.ToString();

                    //GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

                if (LinkItemSelected != null)
                {
                        
                    
                    

                    //Aanvraag aanvraag1 = new Aanvraag();
                    //aanvraag1.Id = Convert.ToInt32(lblId.Text);
                    //GebruiksLog gebruiksLog1 = new GebruiksLog();
                    //gebruiksLog1.Gebruiker = Program.Gebruiker;
                    //gebruiksLog1.TijdstipActie = DateTime.Now;
                    //gebruiksLog1.OmschrijvingActie = "Aanvraag " + aanvraag1.Id + " werd aangepast door Gebruiker " + Program.Gebruiker.ToString();

                    //GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);
                }
            
        }
    }
}
