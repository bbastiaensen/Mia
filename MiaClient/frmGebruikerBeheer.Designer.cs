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
            this.RadActief = new System.Windows.Forms.RadioButton();
            this.RadAlle = new System.Windows.Forms.RadioButton();
            this.RadNonActief = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.BtnOpslaan = new System.Windows.Forms.Button();
            this.checkActief = new System.Windows.Forms.CheckBox();
            this.lblActief = new System.Windows.Forms.Label();
            this.grpRollen = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstGebruikers
            // 
            this.LstGebruikers.FormattingEnabled = true;
            this.LstGebruikers.ItemHeight = 21;
            this.LstGebruikers.Location = new System.Drawing.Point(16, 21);
            this.LstGebruikers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LstGebruikers.Name = "LstGebruikers";
            this.LstGebruikers.Size = new System.Drawing.Size(325, 130);
            this.LstGebruikers.TabIndex = 0;
            this.LstGebruikers.SelectedIndexChanged += new System.EventHandler(this.LstGebruikers_SelectedIndexChanged);
            // 
            // RadActief
            // 
            this.RadActief.AutoSize = true;
            this.RadActief.Location = new System.Drawing.Point(16, 17);
            this.RadActief.Margin = new System.Windows.Forms.Padding(2);
            this.RadActief.Name = "RadActief";
            this.RadActief.Size = new System.Drawing.Size(67, 25);
            this.RadActief.TabIndex = 3;
            this.RadActief.Text = "Actief";
            this.RadActief.UseVisualStyleBackColor = true;
            this.RadActief.CheckedChanged += new System.EventHandler(this.RadActief_CheckedChanged);
            // 
            // RadAlle
            // 
            this.RadAlle.AutoSize = true;
            this.RadAlle.Checked = true;
            this.RadAlle.Location = new System.Drawing.Point(16, 84);
            this.RadAlle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadAlle.Name = "RadAlle";
            this.RadAlle.Size = new System.Drawing.Size(54, 25);
            this.RadAlle.TabIndex = 4;
            this.RadAlle.TabStop = true;
            this.RadAlle.Text = "Alle";
            this.RadAlle.UseVisualStyleBackColor = true;
            this.RadAlle.CheckedChanged += new System.EventHandler(this.RadAlle_CheckedChanged);
            // 
            // RadNonActief
            // 
            this.RadNonActief.AutoSize = true;
            this.RadNonActief.Location = new System.Drawing.Point(16, 49);
            this.RadNonActief.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RadNonActief.Name = "RadNonActief";
            this.RadNonActief.Size = new System.Drawing.Size(100, 25);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(349, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(195, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gebruikersnaam: ";
            // 
            // TxtGebruikersnaam
            // 
            this.TxtGebruikersnaam.Location = new System.Drawing.Point(150, 174);
            this.TxtGebruikersnaam.Name = "TxtGebruikersnaam";
            this.TxtGebruikersnaam.ReadOnly = true;
            this.TxtGebruikersnaam.Size = new System.Drawing.Size(394, 29);
            this.TxtGebruikersnaam.TabIndex = 12;
            this.TxtGebruikersnaam.TabStop = false;
            // 
            // BtnOpslaan
            // 
            this.BtnOpslaan.Location = new System.Drawing.Point(177, 461);
            this.BtnOpslaan.Name = "BtnOpslaan";
            this.BtnOpslaan.Size = new System.Drawing.Size(204, 57);
            this.BtnOpslaan.TabIndex = 14;
            this.BtnOpslaan.Text = "Bewaren";
            this.BtnOpslaan.UseVisualStyleBackColor = true;
            this.BtnOpslaan.Click += new System.EventHandler(this.BtnOpslaan_Click);
            // 
            // checkActief
            // 
            this.checkActief.AutoSize = true;
            this.checkActief.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkActief.Location = new System.Drawing.Point(150, 209);
            this.checkActief.Name = "checkActief";
            this.checkActief.Size = new System.Drawing.Size(15, 14);
            this.checkActief.TabIndex = 1;
            this.checkActief.UseVisualStyleBackColor = true;
            // 
            // lblActief
            // 
            this.lblActief.AutoSize = true;
            this.lblActief.Location = new System.Drawing.Point(12, 205);
            this.lblActief.Name = "lblActief";
            this.lblActief.Size = new System.Drawing.Size(52, 21);
            this.lblActief.TabIndex = 16;
            this.lblActief.Text = "Actief:";
            // 
            // grpRollen
            // 
            this.grpRollen.Location = new System.Drawing.Point(16, 230);
            this.grpRollen.Name = "grpRollen";
            this.grpRollen.Size = new System.Drawing.Size(528, 26);
            this.grpRollen.TabIndex = 17;
            this.grpRollen.TabStop = false;
            this.grpRollen.Text = "Rollen";
            // 
            // frmGebruikerBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 530);
            this.Controls.Add(this.grpRollen);
            this.Controls.Add(this.lblActief);
            this.Controls.Add(this.checkActief);
            this.Controls.Add(this.BtnOpslaan);
            this.Controls.Add(this.TxtGebruikersnaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LstGebruikers);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmGebruikerBeheer";
            this.Text = "Beheer gebruikers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGebruikerBeheer_FormClosing);
            this.Load += new System.EventHandler(this.frmGebruikerBeheer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstGebruikers;
        private System.Windows.Forms.RadioButton RadActief;
        private System.Windows.Forms.RadioButton RadAlle;
        private System.Windows.Forms.RadioButton RadNonActief;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGebruikersnaam;
        private System.Windows.Forms.Button BtnOpslaan;
        private System.Windows.Forms.CheckBox checkActief;
        private System.Windows.Forms.Label lblActief;
        private System.Windows.Forms.GroupBox grpRollen;
    }
}