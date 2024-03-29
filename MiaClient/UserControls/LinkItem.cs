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
                    if (AanvraagItem.delete == true)
                    {
                        Link link = new Link();
                        link.Id = Convert.ToInt32(lblId.Text);
                        LinkManager.DeleteLink(link);
                        LinkDeleted(this, null);
                        MessageBox.Show("De link is succesvol verwijderd.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Je kunt deze link niet verwijderen.", "Geen Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Link link1 = new Link();
                    link1.Id = Convert.ToInt32(lblId.Text);
                    GebruiksLog gebruiksLog1 = new GebruiksLog();
                    gebruiksLog1.Gebruiker = Program.Gebruiker;
                    gebruiksLog1.TijdstipActie = DateTime.Now;
                    gebruiksLog1.OmschrijvingActie = "Link " + link1.Id + " werd verwijderd door Gebruiker " + Program.Gebruiker.ToString();

                    GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);
                }
                else
                {
                    MessageBox.Show("Je kunt deze aanvraag niet verwijderen.", "Geen Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (frmAanvraagFormulier == null)
            {
                if (LinkItemSelected != null)
                {
                    if (AanvraagItem.edit == true)
                    {
                        LinkItemSelected(this, null);
                        frmAanvraagFormulier = new frmAanvraagFormulier(Id, "editLink");
                    }
                    else
                    {
                        frmAanvraagFormulier = new frmAanvraagFormulier(Id, "editLink");
                        frmAanvraagFormulier.Show();
                        frmAanvraagFormulier.DisableBewaarButon();
                        frmAanvraagFormulier.DisableForm();
                        MessageBox.Show("Je kunt deze aanvraag niet aanpassen.", "Geen Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Link link = new Link();
                    link.Id = Convert.ToInt32(lblId.Text);
                    GebruiksLog gebruiksLog1 = new GebruiksLog();
                    gebruiksLog1.Gebruiker = Program.Gebruiker;
                    gebruiksLog1.TijdstipActie = DateTime.Now;
                    gebruiksLog1.OmschrijvingActie = "Link " + link.Id + " werd aangepast door Gebruiker " + Program.Gebruiker.ToString();

                    GebruiksLogManager.SaveGebruiksLog(gebruiksLog1, true);
                }
            }
        }

        private void lblTitel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(URL))
                {
                    Process.Start(URL);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
