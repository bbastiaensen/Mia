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
        //// Tooltip forwarding
        //public void EnableTooltip(ToolTip tip)
        //{
        //    // Tooltip op root control
        //    this.MouseMove += (s, e) => tip.Show(
        //        $"Code: {Code}\nWaarde: {Waarde}\nEenheid: {Eenheid}\nVerklaring: {Verklaring}",
        //        this
        //    );
        //     this.MouseLeave += (s, e) => tip.Hide(this);

        //    // Forward naar subcontrols
        //    ForwardTooltipToChildren(this, tip);
        //}

        //private void ForwardTooltipToChildren(Control parent, ToolTip tip)
        //{
        //    foreach (Control c in parent.Controls)
        //    {
        //        // Gebruik MouseEnter in plaats van MouseMove
        //        c.MouseMove += (s, e) =>
        //        {
        //            // Alleen tonen als tooltip nog niet zichtbaar
        //            tip.Show(
        //                $"Code: {Code}\nWaarde: {Waarde}\nEenheid: {Eenheid}\nVerklaring: {Verklaring}",
        //                this
        //            );
        //        };

        //        // Niet automatisch verbergen bij MouseLeave van subcontrol
        //        // De root MouseLeave regelt dit al

        //        if (c.HasChildren)
        //            ForwardTooltipToChildren(c, tip);
        //    }
        //}

        public void EnableTooltip(ToolTip tip)
        {
            this.MouseEnter += (s, e) =>
            {
                // Tooltip tonen, 3 seconden
                tip.Show(
                    $"Code: {Code}\nWaarde: {Waarde}\nEenheid: {Eenheid}\nVerklaring: {Verklaring}",
                    this,
                    0, 0, 3000
                );
            };

            this.MouseLeave += (s, e) =>
            {
                // Kijk waar de muis nu is
                Point p = this.PointToClient(Cursor.Position);
                if (!this.ClientRectangle.Contains(p))
                {
                    tip.Hide(this);
                }
                // anders muis zit nog binnen de control of child, tooltip blijft
            };

            // Optioneel: subcontrols doorgeven, zodat hover over knop/label tooltip niet verdwijnt
            foreach (Control c in this.Controls)
            {
                c.MouseMove += (s, e) =>
                {
                    tip.Show(
                        $"Code: {Code}\nWaarde: {Waarde}\nEenheid: {Eenheid}\nVerklaring: {Verklaring}",
                        this,
                        0, 0, 3000
                    );
                };
            }
        }



        private void ForwardTooltipToChildren(Control parent, ToolTip tip)
        {
            foreach (Control c in parent.Controls)
            {
                c.MouseEnter += (s, e) => ShowTooltip(tip);
                // Geen MouseLeave hier; root regelt het verbergen
                if (c.HasChildren)
                    ForwardTooltipToChildren(c, tip);
            }
        }

        private void ShowTooltip(ToolTip tip)
        {
            tip.Show(
                $"Code: {Code}\nWaarde: {Waarde}\nEenheid: {Eenheid}\nVerklaring: {Verklaring}",
                this
            );
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
