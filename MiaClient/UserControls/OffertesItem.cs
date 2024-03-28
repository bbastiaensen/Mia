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
    public partial class OffertesItem : UserControl
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string URL { get; set; }
        public int AanvraagId { get; set; }
        public Boolean Even { get; set;}

        public event EventHandler OfferteDeleted;
        public event EventHandler OfferteItemSelected;
        public event EventHandler OfferteItemChanged;
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
            if(Even)
            {
                this.BackColor = Color.White;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
