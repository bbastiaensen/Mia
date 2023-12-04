namespace MiaClient
{
    partial class frmGebruikerBeheer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstGebruikers = new System.Windows.Forms.ListBox();
            this.BtnPasaan = new System.Windows.Forms.Button();
            this.BtnVerwijder = new System.Windows.Forms.Button();
            this.RadActief = new System.Windows.Forms.RadioButton();
            this.RadAlle = new System.Windows.Forms.RadioButton();
            this.RadNonActief = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.DdlActief = new System.Windows.Forms.ComboBox();
            this.BtnOpslaan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstGebruikers
            // 
            this.LstGebruikers.FormattingEnabled = true;
            this.LstGebruikers.ItemHeight = 28;
            this.LstGebruikers.Location = new System.Drawing.Point(16, 21);
            this.LstGebruikers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LstGebruikers.Name = "LstGebruikers";
            this.LstGebruikers.Size = new System.Drawing.Size(424, 172);
            this.LstGebruikers.TabIndex = 0;
            this.LstGebruikers.SelectedIndexChanged += new System.EventHandler(this.LstGebruikers_SelectedIndexChanged);
            // 
            // BtnPasaan
            // 
            this.BtnPasaan.Location = new System.Drawing.Point(232, 455);
            this.BtnPasaan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPasaan.Name = "BtnPasaan";
            this.BtnPasaan.Size = new System.Drawing.Size(208, 57);
            this.BtnPasaan.TabIndex = 1;
            this.BtnPasaan.Text = "Aanpassen";
            this.BtnPasaan.UseVisualStyleBackColor = true;
            this.BtnPasaan.Click += new System.EventHandler(this.BtnPasaan_Click);
            // 
            // BtnVerwijder
            // 
            this.BtnVerwijder.Location = new System.Drawing.Point(16, 455);
            this.BtnVerwijder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVerwijder.Name = "BtnVerwijder";
            this.BtnVerwijder.Size = new System.Drawing.Size(208, 57);
            this.BtnVerwijder.TabIndex = 2;
            this.BtnVerwijder.Text = "Verwijderen";
            this.BtnVerwijder.UseVisualStyleBackColor = true;
            // 
            // RadActief
            // 
            this.RadActief.AutoSize = true;
            this.RadActief.Location = new System.Drawing.Point(29, 37);
            this.RadActief.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadActief.Name = "RadActief";
            this.RadActief.Size = new System.Drawing.Size(61, 20);
            this.RadActief.TabIndex = 3;
            this.RadActief.Text = "Actief";
            this.RadActief.UseVisualStyleBackColor = true;
            this.RadActief.CheckedChanged += new System.EventHandler(this.RadActief_CheckedChanged);
            // 
            // RadAlle
            // 
            this.RadAlle.AutoSize = true;
            this.RadAlle.Checked = true;
            this.RadAlle.Location = new System.Drawing.Point(29, 128);
            this.RadAlle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadAlle.Name = "RadAlle";
            this.RadAlle.Size = new System.Drawing.Size(51, 20);
            this.RadAlle.TabIndex = 4;
            this.RadAlle.TabStop = true;
            this.RadAlle.Text = "Alle";
            this.RadAlle.UseVisualStyleBackColor = true;
            this.RadAlle.CheckedChanged += new System.EventHandler(this.RadAlle_CheckedChanged);
            // 
            // RadNonActief
            // 
            this.RadNonActief.AutoSize = true;
            this.RadNonActief.Location = new System.Drawing.Point(29, 82);
            this.RadNonActief.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadNonActief.Name = "RadNonActief";
            this.RadNonActief.Size = new System.Drawing.Size(88, 20);
            this.RadNonActief.TabIndex = 5;
            this.RadNonActief.Text = "Niet Actief";
            this.RadNonActief.UseVisualStyleBackColor = true;
            this.RadNonActief.CheckedChanged += new System.EventHandler(this.RadNonActief_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadActief);
            this.groupBox1.Controls.Add(this.RadAlle);
            this.groupBox1.Controls.Add(this.RadNonActief);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.groupBox1.Location = new System.Drawing.Point(448, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(195, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gebruikersnaam: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Actief: ";
            // 
            // TxtGebruikersnaam
            // 
            this.TxtGebruikersnaam.Location = new System.Drawing.Point(17, 276);
            this.TxtGebruikersnaam.Name = "TxtGebruikersnaam";
            this.TxtGebruikersnaam.Size = new System.Drawing.Size(423, 34);
            this.TxtGebruikersnaam.TabIndex = 12;
            // 
            // DdlActief
            // 
            this.DdlActief.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdlActief.FormattingEnabled = true;
            this.DdlActief.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.DdlActief.Location = new System.Drawing.Point(17, 345);
            this.DdlActief.Name = "DdlActief";
            this.DdlActief.Size = new System.Drawing.Size(121, 36);
            this.DdlActief.TabIndex = 13;
            // 
            // BtnOpslaan
            // 
            this.BtnOpslaan.Location = new System.Drawing.Point(447, 455);
            this.BtnOpslaan.Name = "BtnOpslaan";
            this.BtnOpslaan.Size = new System.Drawing.Size(208, 57);
            this.BtnOpslaan.TabIndex = 14;
            this.BtnOpslaan.Text = "Opslaan";
            this.BtnOpslaan.UseVisualStyleBackColor = true;
            this.BtnOpslaan.Visible = false;
            // 
            // frmGebruikerBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 530);
            this.Controls.Add(this.BtnOpslaan);
            this.Controls.Add(this.DdlActief);
            this.Controls.Add(this.TxtGebruikersnaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnVerwijder);
            this.Controls.Add(this.BtnPasaan);
            this.Controls.Add(this.LstGebruikers);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGebruikerBeheer";
            this.Text = "frmGebruikerBeheer";
            this.Load += new System.EventHandler(this.frmGebruikerBeheer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstGebruikers;
        private System.Windows.Forms.Button BtnPasaan;
        private System.Windows.Forms.Button BtnVerwijder;
        private System.Windows.Forms.RadioButton RadActief;
        private System.Windows.Forms.RadioButton RadAlle;
        private System.Windows.Forms.RadioButton RadNonActief;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGebruikersnaam;
        private System.Windows.Forms.ComboBox DdlActief;
        private System.Windows.Forms.Button BtnOpslaan;
    }
}