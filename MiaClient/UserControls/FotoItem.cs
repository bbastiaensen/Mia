using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public event EventHandler OfferteDeleted;
        public event EventHandler OfferteItemSelected;
        public event EventHandler OfferteItemChanged;
        public FotoItem()
        {
            InitializeComponent();
        }
        public FotoItem(int id, string titel, string url, int aanvraagId)
        {
            Id = id;
            Titel = titel;
            URL = url;
            AanvraagId = aanvraagId;
            SetFotoItemWaarde();
        }
        private void SetFotoItemWaarde()
        {
            
            lblId.Text = Id.ToString();
            lblTitel.Text = Titel.ToString();
            //pcbFoto.Image = URL.;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
