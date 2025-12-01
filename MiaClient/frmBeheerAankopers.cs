<<<<<<< HEAD
﻿    using MiaLogic.Manager;
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
=======
﻿using MiaLogic.Manager;
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
>>>>>>> a6c3b7d4610a61a3a4ac0a29bd65f05af70416d5

    namespace MiaClient
    {
<<<<<<< HEAD
        public partial class frmBeheerAankopers : Form
=======
        List<Aankoper> aankopers;

        int xPos = 10;
        int yPos = 20;
        int grpHeight = 26;
        bool IsNew = false;
        
        public frmBeheerAankopers()
>>>>>>> a6c3b7d4610a61a3a4ac0a29bd65f05af70416d5
        {
            public frmBeheerAankopers()
            {
                InitializeComponent();
            }

            private void frmBeheerAankopers_FormClosing(object sender, FormClosingEventArgs e)
            {
                //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
                //keren naast elkaar kan geopend worden.
                e.Cancel = true;
                ((Form)sender).Hide();
            }

        private void frmBeheerAankopers_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            btnGenereer.Enabled = false;
            cmbFinancieringsjaar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFinancieringsjaar.Items.Clear();
=======
            CreateUI();
            BindLstAankopers();
        }
>>>>>>> a6c3b7d4610a61a3a4ac0a29bd65f05af70416d5

            // Haal de aanvragen op
            var aanvragen = AanvraagManager.GetAanvragenByRichtPeriodeAsc();

            if (aanvragen != null && aanvragen.Any())
            {
                var jaren = aanvragen
                    .Select(a => Convert.ToInt32(a.Financieringsjaar))
                    .Distinct()
                    .OrderBy(j => j)
                    .ToList();

                cmbFinancieringsjaar.Items.AddRange(jaren.Select(j => j.ToString()).ToArray());

                // Selecteer automatisch het laatste (recentste) jaar
                if (cmbFinancieringsjaar.Items.Count > 0)
                    cmbFinancieringsjaar.SelectedIndex = cmbFinancieringsjaar.Items.Count - 1;
            }
            else
            {
                MessageBox.Show(
                      "Er werden geen financieringsjaren gevonden in de databank.\n" +
                      "Controleer of er aanvragen geregistreerd zijn.",
                      "MIA – Geen financieringsjaren",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                  );
            }
        }
<<<<<<< HEAD



        private void CreateUI()
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

            private void cmbFinancieringsjaar_SelectedIndexChanged(object sender, EventArgs e)
            {
                btnGenereer.Enabled = cmbFinancieringsjaar.SelectedIndex >= 0;
            }

        private void btnGenereer_Click(object sender, EventArgs e)
        {
            if (cmbFinancieringsjaar.SelectedItem == null) return;

            // Gekozen jaar ophalen
            int gekozenJaar = int.Parse(cmbFinancieringsjaar.SelectedItem.ToString());

            // Alle aanvragen ophalen
            List<Aanvraag> alleAanvragen = AanvraagManager.GetAanvragenByRichtPeriodeAsc();

            // Alleen geweigerde aanvragen filteren
            var geweigerdeAanvragen = alleAanvragen
                .Where(a =>
                {
                    var statusNaam = StatusAanvraagManager.GetStatusAanvraagById(a.StatusAanvraagId).Naam?.ToLower().Trim();
                    return (statusNaam == "niet bekrachtigd" || statusNaam == "niet goedgekeurd")
                           && !string.IsNullOrEmpty(a.Financieringsjaar)
                           && Convert.ToInt32(a.Financieringsjaar) == gekozenJaar;
                })
                .ToList();

            // Tonen in datagridview
            dataGridView.DataSource = geweigerdeAanvragen;

            if (geweigerdeAanvragen.Count == 0)
            {
                MessageBox.Show(
                    $"Er werden geen geweigerde aanvragen gevonden voor financieringsjaar {gekozenJaar}.",
                    "MIA – Geen resultaten",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }

=======
        public void BindLstAankopers()
        {

            aankopers = AankoperManager.GetAankoper();
            LstAankopers.DisplayMember = "FullName";
            
            LstAankopers.ValueMember = "Id";
            LstAankopers.DataSource= aankopers;
            
        }

        private void LstAankopers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aankoper aankoper  = (Aankoper)LstAankopers.SelectedItem;

           
            if (aankoper != null) 
            {
                txtId.Text = Convert.ToString(aankoper.Id);
                txtVoornaam.Text = aankoper.Voornaam;
                txtAchternaam.Text = aankoper.Achternaam;
                if (aankoper.actief)
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
            txtAchternaam.Text = string.Empty;
            txtId.Text = string.Empty;
            txtVoornaam.Text = string.Empty;
            checkActief.Checked = false;
            IsNew = true;
        }
        private void btnNieuw_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            Aankoper a = new Aankoper();
            a.Id = Convert.ToInt32(LstAankopers.SelectedValue);
            a.Voornaam = txtVoornaam.Text;
            a.Achternaam = txtAchternaam.Text;
            if (checkActief.Checked)
            {
                a.actief = true;
            }
            else
            {
                a.actief= false;
            }
          

            a.Id = AankoperManager.SaveAankoper(a, IsNew);

            BindLstAankopers();
            ClearFields();
            LstAankopers.SelectedValue = a.Id.ToString();
            IsNew = false;
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {

            
            Aankoper a = new Aankoper();
            a.Id = Convert.ToInt32(LstAankopers.SelectedValue);
            a.Voornaam= txtVoornaam.Text;
            a.Achternaam= txtAchternaam.Text;
            if (checkActief.Checked) 
            {
                a.actief = true;
            }
            else
            {
                a.actief= false;
            }
            
           
            
            if (MessageBox.Show($"Bent u dat u {LstAankopers.Text} wilt verwijderen?", "Aankoper verwijderen", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                MessageBox.Show("De Aankoper is succesvol verwijderd", "succes", MessageBoxButtons.OK);
                AankoperManager.DeleteAankoper(a);
            }
          
            

            BindLstAankopers();
            ClearFields();



        }
>>>>>>> a6c3b7d4610a61a3a4ac0a29bd65f05af70416d5
    }


}
    
