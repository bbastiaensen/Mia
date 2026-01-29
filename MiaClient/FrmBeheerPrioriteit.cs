using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiaClient
{
    public partial class FrmBeheerPrioriteit : Form
    {

        List<Prioriteit> Prioriteiten;
        public event EventHandler PrioriteitenChanged;

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;
        public FrmBeheerPrioriteit()
        {
            InitializeComponent();
        }

        private void FrmBeheerPrioriteit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();

            if (AppForms.FrmBeheerPrioriteit == this)
            {
                AppForms.FrmBeheerPrioriteit = null;
            }
        }
        public void CreateUI()
        {
            this.BackColor = StyleParameters.Achtergrondkleur;

            //this.Icon = imgFormIcon;

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = StyleParameters.ButtonBack;
                btn.ForeColor = StyleParameters.Buttontext;
            }
        }

        private void FrmBeheerPrioriteit_Load(object sender, EventArgs e)
        {
            CreateUI();
            BindLstPrioriteiten();


            AppForms.FrmBeheerPrioriteit = this;

            if (AppForms.frmAanvraagFormulier != null)
            {
                this.PrioriteitenChanged -= AppForms.frmAanvraagFormulier.FrmBeheerPrioriteiten_PrioriteitenChanged;
                this.PrioriteitenChanged += AppForms.frmAanvraagFormulier.FrmBeheerPrioriteiten_PrioriteitenChanged;
            }
        }
        public void BindLstPrioriteiten()
        {

            Prioriteiten = PrioriteitManager.GetPrioriteiten();
            LstPrioriteiten.DisplayMember = "Naam"; 

            LstPrioriteiten.ValueMember = "Id";
            LstPrioriteiten.DataSource = Prioriteiten;

        }

        private void LstPrioriteiten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prioriteit prioriteit = (Prioriteit)LstPrioriteiten.SelectedItem;
            if (prioriteit != null)
            {
                txtId.Text = Convert.ToString(prioriteit.Id);
                
                txtNaam.Text = prioriteit.Naam;
                if (prioriteit.actief)
                {
                    checkActief.Checked = true;
                }
                else
                {
                    checkActief.Checked = false;
                }

                IsNew = false;
            }
        }
        private void ClearFields()
        {
           txtNaam.Text = string.Empty;
            txtId.Text = string.Empty;
            checkActief.Checked = false;
            IsNew = true;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNaam.Text))
                {
                    throw new Exception("Gelieve een geldige naam in te vullen.");
                }
                txtNaam.Text = txtNaam.Text.Trim();

                Prioriteit p = new Prioriteit();
                p.Id = Convert.ToInt32(LstPrioriteiten.SelectedValue);
               
                if (checkActief.Checked)
                {
                    p.actief = true;
                }
                else
                {
                    p.actief = false;
                }
                p.Naam = txtNaam.Text;



                p.Id = PrioriteitManager.SavePrioriteit(p, IsNew);
                PrioriteitenChanged?.Invoke(this, EventArgs.Empty);

                BindLstPrioriteiten();

                LstPrioriteiten.SelectedValue = p.Id;
                IsNew = false;

                MessageBox.Show("De gegevens werden succesvol bewaard.", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            
            if (LstPrioriteiten.SelectedItem== null)
            {
                MessageBox.Show("Er is geen financieringstype geselecteerd om te verwijderen.","MIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            Prioriteit p = new Prioriteit();
            p.Id = Convert.ToInt32(LstPrioriteiten.SelectedValue);
          
            p.Naam = txtNaam.Text;
            if (checkActief.Checked)
            {
                p.actief = true;
            }
            else
            {
                p.actief = false;
            }
           
            if (MessageBox.Show($"Bent u zeker dat u {LstPrioriteiten.Text} wilt verwijderen?", "Prioriteit verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (PrioriteitManager.CheckPrioriteitInUse(p.Id))
                {
                    PrioriteitManager.DeactivatePrioriteit(p);
                    PrioriteitenChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    PrioriteitManager.DeletePrioriteit(p);
                    MessageBox.Show("De Prioriteit is succesvol verwijderd", "MIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrioriteitenChanged?.Invoke(this, EventArgs.Empty);

                }
            }
                   

            BindLstPrioriteiten();
            ClearFields();
        }


    }
    
}
