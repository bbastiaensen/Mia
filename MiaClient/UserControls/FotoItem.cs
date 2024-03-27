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

            //pcbFoto.Image = URL.;
            if (Even)
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
