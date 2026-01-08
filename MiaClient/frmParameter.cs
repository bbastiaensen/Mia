using MiaClient.UserControls;
using MiaLogic.Manager;
using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace MiaClient
{
    public partial class frmParameter : Form
    {
        List<Parameter> parameters;
        

        private ToolTip tip = new ToolTip(); // tooltip gebruikt bij hover

        bool filterCode = false;
        bool filterWaarde = false;
        bool filterEenheid = false;
        bool filterVerklaring = true;
        bool isNieuw = true;

        int aantalListItems = 10;
        int huidigePage = 1;
        int aantalPages = 0;

        Image imgLast = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-last-50.png"));
        Image imgLastDisable = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-last-50-grey.png"));
        Image imgLastHover = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-last-50-hover.png"));
        Image imgNext = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-next-50.png"));
        Image imgNextDisable = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-next-50-grey.png"));
        Image imgNextHover = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-next-50-hover.png"));
        Image imgPrevious = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-previous-50.png"));
        Image imgPreviousDisable = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-previous-50-grey.png"));
        Image imgPreviousHover = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-previous-50-hover.png"));
        Image imgFirst = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-first-50.png"));
        Image imgFirstDisable = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-first-50-grey.png"));
        Image imgFirstHover = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "icons8-first-50-hover.png"));
        Image imgFilter = (Image)new Bitmap(Path.Combine(Directory.GetCurrentDirectory(), "icons", "Filter.png"));

        public frmParameter()
        {
            InitializeComponent();
        }

        private void frmParameter_FormClosing(object sender, FormClosingEventArgs e)
        {
            //We sluiten het formulier niet, maar verbergen het. Zo voorkomen we dat het formulier meerdere
            //keren naast elkaar kan geopend worden.
            e.Cancel = true;
            ((Form)sender).Hide();
        }

        private void frmParameter_Load(object sender, EventArgs e)
        {

            try
            {

                this.BackColor = StyleParameters.Achtergrondkleur;


                btnBewaren.FlatStyle = FlatStyle.Flat;
                btnBewaren.FlatAppearance.BorderSize = 0;
                btnBewaren.BackColor = StyleParameters.ButtonBack;
                btnBewaren.ForeColor = StyleParameters.Buttontext;
                
                btnNieuw.BackColor = StyleParameters.ButtonBack;

                btnNieuw.ForeColor = StyleParameters.Buttontext;

                btnNieuw.FlatStyle = FlatStyle.Flat;
                btnNieuw.FlatAppearance.BorderSize = 0;

                btnFirst.BackgroundImage = imgFirst;
                btnFirst.BackgroundImageLayout = ImageLayout.Stretch;
                btnFirst.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

                btnPrevious.BackgroundImage = imgPrevious;
                btnPrevious.BackgroundImageLayout = ImageLayout.Stretch;
                btnPrevious.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

                btnNext.BackgroundImage = imgNext;
                btnNext.BackgroundImageLayout = ImageLayout.Stretch;
                btnNext.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

                btnLast.BackgroundImage = imgLast;
                btnLast.BackgroundImageLayout = ImageLayout.Stretch;
                btnLast.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

                btnFilter.BackgroundImage = imgFilter;
                btnFilter.BackgroundImageLayout = ImageLayout.Stretch;
                btnFilter.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindParameters(List<Parameter> items)
        {
            //Eventueel bestaande lijst verwijderen
            this.pnlParameters.Controls.Clear();

            int xPos = 0;
            int yPos = 0;
            int t = 0;

            foreach (var p in items)
            {
                ParameterItem pi = new ParameterItem(p.Id, p.Code, p.Waarde, p.Eenheid, p.Verklaring ,   t % 2 == 0);
                pi.Location = new System.Drawing.Point(xPos, yPos);
                pi.Name = "parameterSelection" + t;
                pi.Size = new System.Drawing.Size(868, 33);
                pi.TabIndex = t + 8;
             
                // Events koppelen
                pi.ParameterSelected += Pi_ParameterSelected;
                pi.ParameterDeleted += Pi_ParameterDeleted;

                // Tooltip via MouseHover instellen
                //// Alleen hover op Waarde
                pi.EnableCodeHover(tip);

                this.pnlParameters.Controls.Add(pi);


               
                //Voorbereiden voor de volgende control
                t++;
                yPos += 30;
            }
        }

        private void Pi_ParameterDeleted(object sender, EventArgs e)
        {
            try
            {
                ParameterItem geselecteerd = (ParameterItem)sender;

                //Nieuw parameter object aanmaken en vullen met de waarden uit het formulier
                Parameter p = new Parameter();
                p.Id = geselecteerd.Id;
 
                ParameterManager.DeleteParameter(p);

                parameters = ParameterManager.GetParameters();
                //aanpassing thomas 
                BindParameters(FilteredParameters(parameters, filterCode, filterWaarde, filterEenheid));
                StartPaging();

                detailsWissen();

                MessageBox.Show("De parameter is verwijderd.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pi_ParameterSelected(object sender, EventArgs e)
        {
            ParameterItem geselecteerd = (ParameterItem)sender;

            txtIdDetail.Text = geselecteerd.Id.ToString();
            txtCodeDetail.Text = geselecteerd.Code;
        
      
            txtWaardeDetail.Text = geselecteerd.Waarde;
            txtEenheidDetail.Text = geselecteerd.Eenheid;

            txtVerklaringDetail.Text = geselecteerd.Verklaring;
            

            //hier zet ik Code parameter naar readonly omdat die van een bestaande veld niet veranderd mag worden.( Readonly = false is bij methode btnNieuw_Click(object sender, EventArgs e))
            txtCodeDetail.ReadOnly = true;

            isNieuw = false;
     
        }

        private void detailsWissen()
        {
            txtIdDetail.Text = string.Empty;
            txtCodeDetail.Text = string.Empty;
            txtWaardeDetail.Text = string.Empty;
            txtEenheidDetail.Text = string.Empty;
            
            txtVerklaringDetail.Text = string.Empty;

            isNieuw = true;
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {


            //Detailformulier leegmaken voor nieuwe invoer.
            detailsWissen();
            txtCodeDetail.Focus();
            // parameter Code kan nu bewerkt worden:
            txtCodeDetail.ReadOnly = false;
       
        }

        private void btnBewaren_Click(object sender, EventArgs e)
        {
            ParameterBewaar();
        
        }

        private void txtCodeDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Voorkomt dat er spaties in code worden gebruikt.
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
        private List<Parameter> FilteredParameters(List<Parameter> items, bool code, bool waarde, bool eenheid)
        {
            if (items != null)
            {
                if (code)
                {
                    items = items.Where(p => p.Code.ToLower().Contains(txtCode.Text.ToLower())).ToList();
                }

                if (waarde)
                {
                    items = items.Where(p => p.Waarde.ToLower().Contains(txtWaarde.Text.ToLower())).ToList();
                }

                if (eenheid)
                {
                    items = items.Where(p => p.Eenheid.ToLower().Contains(txtEenheid.Text.ToLower())).ToList();
                }
           
            }

            //Leegmaken detailvelden
            if (txtEenheidDetail.Text == string.Empty && txtCodeDetail.Text == string.Empty && txtWaardeDetail.Text == string.Empty || txtIdDetail.Text != string.Empty)
            {
                txtIdDetail.Text = string.Empty;
                txtCodeDetail.Text = string.Empty;
                txtWaardeDetail.Text = string.Empty;
                txtEenheidDetail.Text = string.Empty;
            }
            else
            {
                if (MessageBox.Show("Wil je deze parameter opslaan?", "parameter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ParameterBewaar();
                    txtIdDetail.Text = string.Empty;
                    txtCodeDetail.Text = string.Empty;
                    txtWaardeDetail.Text = string.Empty;
                    txtEenheidDetail.Text = string.Empty;
                }
            }

            return items;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Text != string.Empty)
                {
                    filterCode = true;
                }
                if (txtEenheid.Text != string.Empty)
                {
                    filterEenheid = true;
                }
                if (txtWaarde.Text != string.Empty)
                {
                    filterWaarde = true;
                }
                parameters = (FilteredParameters(ParameterManager.GetParameters(), filterCode, filterWaarde, filterEenheid));

                huidigePage = 1;
                StartPaging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ParameterBewaar()
        {
            try
            {
                //Controle op verplichte velden
                if (string.IsNullOrWhiteSpace(txtCodeDetail.Text))
                {
                    MessageBox.Show("Het veld 'Code' moet ingevuld zijn.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtWaardeDetail.Text))
                {
                    MessageBox.Show("Het veld 'Waarde' moet ingevuld zijn.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEenheidDetail.Text))
                {
                    MessageBox.Show("Het veld 'Eenheid' moet ingevuld zijn.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
       
        
                if (isNieuw && !ParameterManager.ParameterExists(txtCodeDetail.Text))
                {
                    MessageBox.Show("De code '" + txtCodeDetail.Text + "' bestaat al.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCodeDetail.Text = string.Empty;
                    return;
                }
          

                //Nieuw parameter object aanmaken en vullen met de waarden uit het formulier
                Parameter p = new Parameter();
                p.Code = txtCodeDetail.Text;
                p.Waarde = txtWaardeDetail.Text;
                p.Eenheid = txtEenheidDetail.Text;
                p.Verklaring = txtVerklaringDetail.Text;
                
                if (!isNieuw)
                {
                    p.Id = Convert.ToInt32(txtIdDetail.Text);
                }
                p.Id = ParameterManager.SaveParameter(p, isNieuw);
                txtIdDetail.Text = p.Id.ToString();

                isNieuw = false;

                parameters = FilteredParameters(ParameterManager.GetParameters(), filterCode, filterWaarde, filterEenheid);
                StartPaging();
                detailsWissen();
                MessageBox.Show("De gegevens zijn bewaard.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmParameter_Shown(object sender, EventArgs e)
        {
            try
            {
                parameters = ParameterManager.GetParameters();

                if (parameters != null)
                {
                    StartPaging();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartPaging()
        {
            if (parameters.Count > aantalListItems)
            {
                //Paging is nodig
                aantalPages = (parameters.Count / aantalListItems);
                if ((parameters.Count % aantalListItems) != 0)
                {
                    aantalPages++;
                }

                ShowPages();

                if (huidigePage <= aantalPages)
                {
                    BindParameters(parameters.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
                    EnableLastNext(true);
                }
                if (huidigePage == 1)
                {
                    EnableFirstPrevious(false);
                }
            }
            else
            {
                aantalPages = 1;
                ShowPages();
                BindParameters(parameters);
                EnableFirstPrevious(false);
                EnableLastNext(false);
            }
        }

        private void EnableFirstPrevious(bool enable)
        {
            if (enable)
            {
                btnFirst.BackgroundImage = imgFirst;
                btnPrevious.BackgroundImage = imgPrevious;
            }
            else
            {
                btnFirst.BackgroundImage = imgFirstDisable;
                btnPrevious.BackgroundImage = imgPreviousDisable;
            }
            btnFirst.Enabled = enable;
            btnPrevious.Enabled = enable;
        }

        private void EnableLastNext(bool enable)
        {
            if (enable)
            {
                btnLast.BackgroundImage = imgLast;
                btnNext.BackgroundImage = imgNext;
            }
            else
            {
                btnLast.BackgroundImage = imgLastDisable;
                btnNext.BackgroundImage = imgNextDisable;
            }
            btnLast.Enabled = enable;
            btnNext.Enabled = enable;
        }

        private void btnLast_MouseHover(object sender, EventArgs e)
        {
            btnLast.FlatAppearance.MouseOverBackColor = StyleParameters.Achtergrondkleur;
            btnLast.BackgroundImage = imgLastHover;
        }

        private void btnLast_MouseLeave(object sender, EventArgs e)
        {
            if (huidigePage == aantalPages)
            {
                btnLast.BackgroundImage = imgLastDisable;
            }
            else
            {
                btnLast.BackgroundImage = imgLast;
            }
        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = imgNextHover;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            if (huidigePage == aantalPages)
            {
                btnNext.BackgroundImage = imgNextDisable;
            }
            else
            {
                btnNext.BackgroundImage = imgNext;
            }
        }

        private void btnPrevious_MouseHover(object sender, EventArgs e)
        {
            btnPrevious.BackgroundImage = imgPreviousHover;
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            if (huidigePage == 1)
            {
                btnPrevious.BackgroundImage = imgPreviousDisable;
            }
            else
            {
                btnPrevious.BackgroundImage = imgPrevious;
            }
        }

        private void btnFirst_MouseHover(object sender, EventArgs e)
        {
            btnFirst.BackgroundImage = imgFirstHover;
        }

        private void btnFirst_MouseLeave(object sender, EventArgs e)
        {
            if (huidigePage == 1)
            {
                btnFirst.BackgroundImage = imgFirstDisable;
            }
            else
            {
                btnFirst.BackgroundImage = imgFirst;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            huidigePage++;
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindParameters(parameters.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
            }
            else if (huidigePage == aantalPages)
            {
                BindParameters(parameters.Skip((huidigePage - 1) * aantalListItems).ToList());
                EnableLastNext(false);
            }
            EnableFirstPrevious(true);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            huidigePage--;
            ShowPages();
            if (huidigePage < aantalPages)
            {
                BindParameters(parameters.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
            }
            if (huidigePage == 1)
            {
                EnableFirstPrevious(false);
            }
            EnableLastNext(true);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            huidigePage = 1;
            ShowPages();
            BindParameters(parameters.Skip((huidigePage - 1) * aantalListItems).Take(aantalListItems).ToList());
            EnableFirstPrevious(false);
            if (huidigePage < aantalPages)
            {
                EnableLastNext(true);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            huidigePage = aantalPages;
            ShowPages();
            BindParameters(parameters.Skip((huidigePage - 1) * aantalListItems).ToList());
            EnableLastNext(false);
            if (huidigePage > 1)
            {
                EnableFirstPrevious(true);
            }
        }

        private void ShowPages()
        {
            lblPages.Text = huidigePage.ToString() + " van " + aantalPages.ToString();
        }

        private void pnlParameters_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
