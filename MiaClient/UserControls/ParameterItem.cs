using ProofOfConceptDesign;
using System;
using System.Diagnostics.Eventing.Reader;
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
        public string Verklaring { get; set; }


        public Boolean Even { get; set; }

        public event EventHandler ParameterSelected;

        public event EventHandler ParameterDeleted;



        public ParameterItem()
        {
            InitializeComponent();
        }

        public ParameterItem(int id, string code, string waarde, string eenheid, string verklaring, Boolean even)
        {
            InitializeComponent();
            Id = id;
            Code = code;
            Waarde = waarde;
            Eenheid = eenheid;
            Verklaring = verklaring; /// kijk dit nog na(van thomas)

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

        public void EnableCodeHover(ToolTip tip)
        {
            if (lblCode == null) throw new ArgumentNullException(nameof(lblCode));
            if (tip == null) throw new ArgumentNullException(nameof(tip));

            // Tooltip instellen
            string text = string.IsNullOrEmpty(Verklaring) ? "Null" : Verklaring;
            if (text != "Null")
            {
                tip.SetToolTip(lblCode, $"Verklaring: {text}");
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
