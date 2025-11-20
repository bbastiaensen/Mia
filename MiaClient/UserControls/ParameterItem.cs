using ProofOfConceptDesign;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class ParameterItem : UserControl
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Waarde { get; set; }
        public string Eenheid { get; set; }

        
        public Boolean Even { get; set; }

        public event EventHandler ParameterSelected;

        public event EventHandler ParameterDeleted;

        public ParameterItem()
        {
            InitializeComponent();
        }

        public ParameterItem(int id, string code, string waarde, string eenheid, Boolean even)
        {
            InitializeComponent();
            Id = id;
            Code = code;
            Waarde = waarde;
            Eenheid = eenheid;
       
            Even = even;
            SetParameterWaarden();
        }

        private void SetParameterWaarden()
        {
            lblId.Text = Id.ToString();
            lblCode.Text = Code;
            lblWaarde.Text = Waarde;
            lblEenheid.Text = Eenheid;
            
            if (Even)
            {
                this.BackColor = StyleParameters.ListItemColor;
            }
            else
            {
                this.BackColor = StyleParameters.AltListItemColor;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ParameterSelected != null)
            {
                ParameterSelected(this, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ben je zeker dat je deze parameter wilt verwijderen?", "Aanvragen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ParameterDeleted != null)
                {
                    ParameterDeleted(this, null);
                }
            }
        }
    }
}
