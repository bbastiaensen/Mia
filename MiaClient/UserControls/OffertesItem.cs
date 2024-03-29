using MiaLogic.Manager;
using MiaLogic.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class OffertesItem : UserControl
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string URL { get; set; }
        public int AanvraagId { get; set; }
        public Boolean Even { get; set; }

        public event EventHandler OfferteDeleted;
        public event EventHandler OfferteItemSelected;
        public event EventHandler OfferteItemChanged;
        frmAanvraagFormulier frmAanvraagFormulier;

        public OffertesItem()
        {
            InitializeComponent();
        }
        public OffertesItem(int id, string titel, string url, int aanvraagId, Boolean even)
        {
            InitializeComponent();
            Id = id;
            Titel = titel;
            URL = url;
            AanvraagId = aanvraagId;
            Even = even;
            SetOfferteItemWaarde();
        }
        private void SetOfferteItemWaarde()
        {
            lblId.Text = Id.ToString();
            lblTitel.Text = Titel.ToString();
            if (Even)
            {
                this.BackColor = Color.White;
            }
        }
        public void DeleteOfferte()
        {
            try
            {
                Offerte offerte = new Offerte();
                offerte.Id = Id;
                OfferteManager.DeleteOfferte(offerte);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ben je zeker dat je deze offerte wilt verwijderen?", "success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DeleteOfferte();
                MessageBox.Show("Success");
                //Hier moeten de aanvragen terug gerefreshed worden
            }
            else
            {
                return;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (frmAanvraagFormulier == null)
            {
                if (OfferteItemSelected != null)
                {
                    if (AanvraagItem.edit == true)
                    {
                        OfferteItemSelected(this, null);
                        frmAanvraagFormulier = new frmAanvraagFormulier(Id, "editOfferte");
                    }
                    else
                    {
                        frmAanvraagFormulier = new frmAanvraagFormulier(Id, "editOfferte");
                        frmAanvraagFormulier.Show();
                        frmAanvraagFormulier.DisableBewaarButon();
                        frmAanvraagFormulier.DisableForm();
                        MessageBox.Show("Je kunt deze offerte niet aanpassen.", "Geen Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Offerte offerte = new Offerte();
                    offerte.Id = Convert.ToInt32(lblId.Text);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog //er wordt een log aangemaakt wanneer de gebruiker probeert in te loggen
                    {
                        Gebruiker = Program.Gebruiker,
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Offerte {offerte.Id} werd aangepast door Gebruiker {Program.Gebruiker.ToString()}"

                    }, true);
                }
            }
        }


        private void lblTitel_Click(object sender, EventArgs e)
        {
            try
            {
                String extension = Path.GetExtension(URL).ToLower();
                if (extension != null)
                {
                    if (extension == ".doc" || extension == ".docx" || extension == ".xls" || extension == ".xlsx" || extension == ".pdf" || extension == ".txt")
                    {
                        Process.Start(URL);
                    }
                    else
                    {
                        MessageBox.Show("Dit bestandstype is niet ondersteund");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
