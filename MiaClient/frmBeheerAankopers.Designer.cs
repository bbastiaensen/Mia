namespace MiaClient
{
    partial class frmBeheerAankopers
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
            this.LstAankopers = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblActief = new System.Windows.Forms.Label();
            this.checkActief = new System.Windows.Forms.CheckBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnBewaren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstAankopers
            // 
            this.LstAankopers.FormattingEnabled = true;
            this.LstAankopers.ItemHeight = 25;
            this.LstAankopers.Location = new System.Drawing.Point(56, 28);
            this.LstAankopers.Name = "LstAankopers";
            this.LstAankopers.Size = new System.Drawing.Size(289, 129);
            this.LstAankopers.TabIndex = 0;
            this.LstAankopers.SelectedIndexChanged += new System.EventHandler(this.LstAankopers_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(51, 207);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 25);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id: ";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(51, 242);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(103, 25);
            this.lblVoornaam.TabIndex = 2;
            this.lblVoornaam.Text = "Voornaam:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(51, 285);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(118, 25);
            this.lblAchternaam.TabIndex = 3;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // lblActief
            // 
            this.lblActief.AutoSize = true;
            this.lblActief.Location = new System.Drawing.Point(51, 328);
            this.lblActief.Name = "lblActief";
            this.lblActief.Size = new System.Drawing.Size(64, 25);
            this.lblActief.TabIndex = 4;
            this.lblActief.Text = "Actief:";
            // 
            // checkActief
            // 
            this.checkActief.AutoSize = true;
            this.checkActief.Location = new System.Drawing.Point(175, 328);
            this.checkActief.Name = "checkActief";
            this.checkActief.Size = new System.Drawing.Size(39, 29);
            this.checkActief.TabIndex = 5;
            this.checkActief.Text = " ";
            this.checkActief.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(175, 200);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(119, 32);
            this.txtId.TabIndex = 6;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(175, 285);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(100, 32);
            this.txtAchternaam.TabIndex = 7;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(175, 242);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(100, 32);
            this.txtVoornaam.TabIndex = 8;
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(394, 208);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(169, 47);
            this.btnNieuw.TabIndex = 9;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(394, 314);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(169, 43);
            this.btnVerwijderen.TabIndex = 10;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnBewaren
            // 
            this.btnBewaren.Location = new System.Drawing.Point(394, 261);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(169, 49);
            this.btnBewaren.TabIndex = 11;
            this.btnBewaren.Text = "Bewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // frmBeheerAankopers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 692);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.checkActief);
            this.Controls.Add(this.lblActief);
            this.Controls.Add(this.lblAchternaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.LstAankopers);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBeheerAankopers";
            this.Text = "Beheer Aankopers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeheerAankopers_FormClosing);
            this.Load += new System.EventHandler(this.frmBeheerAankopers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstAankopers;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblActief;
        private System.Windows.Forms.CheckBox checkActief;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnBewaren;
    }
}