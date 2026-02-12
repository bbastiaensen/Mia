using MiaLogic.Object;
using ProofOfConceptDesign;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MiaClient.UserControls
{
    public partial class NieuweAankoopItem : UserControl
    {
        // Volledige Aanvraag bewaren
        public Aanvraag Aanvraag { get; set; }

        public static string ConnectionString { get; set; }

        public bool Even { get; set; }

        public event EventHandler EuroClicked;

        public NieuweAankoopItem()
        {
            InitializeComponent();
            SetupLabels();
        }

        public NieuweAankoopItem(Aanvraag aanvraag, bool even)
        {
            InitializeComponent();

            Aanvraag = aanvraag;
            Even = even;

            SetupLabels();
            SetItemValue();
            LoadEuroIcon();
        }

        private void SetupLabels()
        {
            lblTitel.AutoSize = false;
            lblTitel.AutoEllipsis = true;

            lblAanvrager.AutoSize = false;
            lblAanvrager.AutoEllipsis = true;

            lblStatusAanvraag.AutoSize = false;
            lblStatusAanvraag.AutoEllipsis = true;

            lblFinancieringsjaar.AutoSize = false;
            lblFinancieringsjaar.AutoEllipsis = true;

            lblRichtperiode.AutoSize = false;
            lblRichtperiode.AutoEllipsis = true;
        }

        private void SetItemValue()
        {
            if (Aanvraag == null) return;

            // Omschrijving vervangen door Titel
            lblTitel.Text = Aanvraag.Titel ?? "";
            lblAanvrager.Text = Aanvraag.Gebruiker ?? "";
            lblStatusAanvraag.Text = Aanvraag.StatusAanvraag ?? "";
            lblFinancieringsjaar.Text = Aanvraag.Financieringsjaar ?? "";
            lblRichtperiode.Text = Aanvraag.RichtperiodeNaam ?? "";

            BackColor = Even
                ? StyleParameters.ListItemColor
                : StyleParameters.AltListItemColor;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int padding = 10;
            int height = Height;

            lblTitel.SetBounds(49, 0, 150, height);
            lblAanvrager.SetBounds(250, 0, 140, height);
            lblStatusAanvraag.SetBounds(415, 0, 120, height);
            lblFinancieringsjaar.SetBounds(615, 0, 120, height);
            lblRichtperiode.SetBounds(800, 0, Math.Max(0, Width - 845 - padding), height);
        }

        private void LoadEuroIcon()
        {
            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "icons",
                "icons8-euro-50.png"
            );

            if (File.Exists(path))
            {
                using (var img = Image.FromFile(path))
                    btnEuro.Image = new Bitmap(img, new Size(20, 20));
            }
            else
            {
                btnEuro.Text = "€";
                btnEuro.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            }
        }

        // Aankoop aanmaken met Titel
        public static void CreateAankoop(Aankoop aankoop)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Aankoop 
                        (Titel, BTWPercentage, BedragExBTW, StatusAankoopId, LeverancierId, AanvraagId) 
                        VALUES 
                        (@Titel, @BTWPercentage, @BedragExBTW, @StatusAankoopId, @LeverancierId, @AanvraagId);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Titel", aankoop.Titel ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@BTWPercentage", aankoop.BTWPercentage);
                        command.Parameters.AddWithValue("@BedragExBTW", aankoop.BedragExBtw);
                        command.Parameters.AddWithValue("@StatusAankoopId", aankoop.StatusAankoopId);
                        command.Parameters.AddWithValue("@LeverancierId", aankoop.LeverancierId);
                        command.Parameters.AddWithValue("@AanvraagId", aankoop.AanvraagId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Er is een fout opgetreden bij het aanmaken van de Aankoop.");
                throw;
            }
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            EuroClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}