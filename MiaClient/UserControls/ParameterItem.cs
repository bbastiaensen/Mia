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
                this.BackColor = Color.White;
            }
        }

        private void llblDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ParameterSelected != null)
            {
                ParameterSelected(this, null);
            }
        }
    }
}
