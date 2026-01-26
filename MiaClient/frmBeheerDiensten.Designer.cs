namespace MiaClient
{
    partial class frmBeheerDiensten
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
            this.btnBewaren = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.checkActief = new System.Windows.Forms.CheckBox();
            this.lblActief = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.LstDiensten = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBewaren
            // 
            this.btnBewaren.Location = new System.Drawing.Point(425, 136);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(105, 33);
            this.btnBewaren.TabIndex = 23;
            this.btnBewaren.Text = "Bewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(536, 136);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(105, 33);
            this.btnVerwijderen.TabIndex = 22;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(314, 136);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(105, 33);
            this.btnNieuw.TabIndex = 21;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(428, 42);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(213, 32);
            this.txtVoornaam.TabIndex = 20;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(428, 75);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(213, 32);
            this.txtAchternaam.TabIndex = 19;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(428, 9);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(213, 32);
            this.txtId.TabIndex = 18;
            // 
            // checkActief
            // 
            this.checkActief.AutoSize = true;
            this.checkActief.Location = new System.Drawing.Point(428, 108);
            this.checkActief.Name = "checkActief";
            this.checkActief.Size = new System.Drawing.Size(39, 29);
            this.checkActief.TabIndex = 17;
            this.checkActief.Text = " ";
            this.checkActief.UseVisualStyleBackColor = true;
            // 
            // lblActief
            // 
            this.lblActief.AutoSize = true;
            this.lblActief.Location = new System.Drawing.Point(325, 108);
            this.lblActief.Name = "lblActief";
            this.lblActief.Size = new System.Drawing.Size(64, 25);
            this.lblActief.TabIndex = 16;
            this.lblActief.Text = "Actief:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(325, 78);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(118, 25);
            this.lblAchternaam.TabIndex = 15;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(325, 45);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(103, 25);
            this.lblVoornaam.TabIndex = 14;
            this.lblVoornaam.Text = "Voornaam:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(325, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 25);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id: ";
            // 
            // LstDiensten
            // 
            this.LstDiensten.FormattingEnabled = true;
            this.LstDiensten.ItemHeight = 25;
            this.LstDiensten.Location = new System.Drawing.Point(12, 12);
            this.LstDiensten.Name = "LstDiensten";
            this.LstDiensten.Size = new System.Drawing.Size(289, 154);
            this.LstDiensten.TabIndex = 12;
            // 
            // frmBeheerDiensten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 186);
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
            this.Controls.Add(this.LstDiensten);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmBeheerDiensten";
            this.Text = "Beheer Diensten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeheerDiensten_FormClosing);
            this.Load += new System.EventHandler(this.frmBeheerDiensten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBewaren;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox checkActief;
        private System.Windows.Forms.Label lblActief;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListBox LstDiensten;
    }
}