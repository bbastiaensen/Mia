using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
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
    public partial class FotoItem : UserControl
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string URL { get; set; }
        public int AanvraagId { get; set; }
        public Boolean Even { get; set; }

        public event EventHandler FotoDeleted;
        public event EventHandler FotoItemSelected;
        public event EventHandler FotoItemChanged;

        frmAanvraagFormulier frmAanvraagFormulier;

        public FotoItem()
        {
            InitializeComponent();
        }
        public FotoItem(int id, string titel, string url, int aanvraagId, Boolean even)
        {
            InitializeComponent();
            Id = id;
            Titel = titel;
            URL = url;
            AanvraagId = aanvraagId;
            Even = even;
            SetFotoItemWaarde();

        }
        private void SetFotoItemWaarde()
        {

            lblId.Text = Id.ToString();
            if (Titel != null)
            {
                lblTitel.Text = Titel.ToString();
            }

            pcbFoto.ImageLocation = URL.ToString();

            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Even)
            {
                this.BackColor = StyleParameters.ListItemColor;
            }
            else
            {
                this.BackColor = StyleParameters.AltListItemColor;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (frmAanvraagFormulier == null)
            {
                if (FotoDeleted != null)
                {
                    if (AanvraagItem.delete == true)
                    {
                        Foto fotos = new Foto();
                        fotos.Id = Convert.ToInt32(lblId.Text);
                        FotoManager.DeleteFoto(fotos);
                        FotoDeleted(this, null);
                        MessageBox.Show("De Foto is succesvol verwijderd.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Je kunt deze Foto niet verwijderen.", "Geen Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Foto foto = new Foto();
                    foto.Id = Convert.ToInt32(lblId.Text);
                    GebruiksLog gebruiksLog1 = new GebruiksLog();
                    gebruiksLog1.Gebruiker = Program.Gebruiker;
                    gebruiksLog1.TijdstipActie = DateTime.Now;
                    gebruiksLog1.OmschrijvingActie = "Foto " + foto.Id + " werd aangepast door Gebruiker " + Program.Gebruiker.ToString();

                    GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (frmAanvraagFormulier == null)
            {
                if (FotoItemSelected != null)
                {
                    if (AanvraagItem.edit == true)
                    {
                        FotoItemSelected(this, null);
                        frmAanvraagFormulier = new frmAanvraagFormulier(Id, "editFoto");
                    }
                    else
                    {
                        frmAanvraagFormulier = new frmAanvraagFormulier(Id, "editFoto");
                        frmAanvraagFormulier.Show();
                        frmAanvraagFormulier.DisableBewaarButon();
                        frmAanvraagFormulier.SetFormStatus(false);
                        MessageBox.Show("Je kunt deze Foto niet aanpassen.", "Geen Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Foto foto = new Foto();
                    foto.Id = Convert.ToInt32(lblId.Text);
                    GebruiksLogManager.SaveGebruiksLog(new GebruiksLog //er wordt een log aangemaakt wanneer de gebruiker probeert in te loggen
                    {
                        Gebruiker = Program.Gebruiker,
                        TijdstipActie = DateTime.Now,
                        OmschrijvingActie = $"Foto {foto.Id} werd aangepast door Gebruiker {Program.Gebruiker.ToString()}"

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
                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif")
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

        private void lblTitel_MouseHover(object sender, EventArgs e)
        {


        }
    }
}
