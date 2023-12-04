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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstGebruikers
            // 
            this.LstGebruikers.FormattingEnabled = true;
            this.LstGebruikers.ItemHeight = 16;
            this.LstGebruikers.Location = new System.Drawing.Point(12, 12);
            this.LstGebruikers.Name = "LstGebruikers";
            this.LstGebruikers.Size = new System.Drawing.Size(507, 356);
            this.LstGebruikers.TabIndex = 0;
            // 
            // BtnPasaan
            // 
            this.BtnPasaan.Location = new System.Drawing.Point(198, 374);
            this.BtnPasaan.Name = "BtnPasaan";
            this.BtnPasaan.Size = new System.Drawing.Size(180, 43);
            this.BtnPasaan.TabIndex = 1;
            this.BtnPasaan.Text = "Aanpassen";
            this.BtnPasaan.UseVisualStyleBackColor = true;
            // 
            // BtnVerwijder
            // 
            this.BtnVerwijder.Location = new System.Drawing.Point(12, 374);
            this.BtnVerwijder.Name = "BtnVerwijder";
            this.BtnVerwijder.Size = new System.Drawing.Size(180, 43);
            this.BtnVerwijder.TabIndex = 2;
            this.BtnVerwijder.Text = "Verwijderen";
            this.BtnVerwijder.UseVisualStyleBackColor = true;
            // 
            // RadActief
            // 
            this.RadActief.AutoSize = true;
            this.RadActief.Location = new System.Drawing.Point(21, 21);
            this.RadActief.Name = "RadActief";
            this.RadActief.Size = new System.Drawing.Size(61, 20);
            this.RadActief.TabIndex = 3;
            this.RadActief.Text = "Actief";
            this.RadActief.UseVisualStyleBackColor = true;
            // 
            // RadAlle
            // 
            this.RadAlle.AutoSize = true;
            this.RadAlle.Checked = true;
            this.RadAlle.Location = new System.Drawing.Point(21, 73);
            this.RadAlle.Name = "RadAlle";
            this.RadAlle.Size = new System.Drawing.Size(51, 20);
            this.RadAlle.TabIndex = 4;
            this.RadAlle.TabStop = true;
            this.RadAlle.Text = "Alle";
            this.RadAlle.UseVisualStyleBackColor = true;
            // 
            // RadNonActief
            // 
            this.RadNonActief.AutoSize = true;
            this.RadNonActief.Location = new System.Drawing.Point(21, 47);
            this.RadNonActief.Name = "RadNonActief";
            this.RadNonActief.Size = new System.Drawing.Size(88, 20);
            this.RadNonActief.TabIndex = 5;
            this.RadNonActief.Text = "Niet Actief";
            this.RadNonActief.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadActief);
            this.groupBox1.Controls.Add(this.RadAlle);
            this.groupBox1.Controls.Add(this.RadNonActief);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.groupBox1.Location = new System.Drawing.Point(525, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // frmGebruikerBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnVerwijder);
            this.Controls.Add(this.BtnPasaan);
            this.Controls.Add(this.LstGebruikers);
            this.Name = "frmGebruikerBeheer";
            this.Text = "frmGebruikerBeheer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstGebruikers;
        private System.Windows.Forms.Button BtnPasaan;
        private System.Windows.Forms.Button BtnVerwijder;
        private System.Windows.Forms.RadioButton RadActief;
        private System.Windows.Forms.RadioButton RadAlle;
        private System.Windows.Forms.RadioButton RadNonActief;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}