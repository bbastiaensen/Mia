namespace MiaClient
{
    partial class frmBeheerGemeente
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
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblLanden = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.LstGemeente = new System.Windows.Forms.ListBox();
            this.ddlLand = new System.Windows.Forms.ComboBox();
            this.txtLandId = new System.Windows.Forms.TextBox();
            this.lblLandId = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBewaren
            // 
            this.btnBewaren.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewaren.Location = new System.Drawing.Point(428, 203);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(105, 33);
            this.btnBewaren.TabIndex = 23;
            this.btnBewaren.Text = "Bewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderen.Location = new System.Drawing.Point(547, 203);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(105, 33);
            this.btnVerwijderen.TabIndex = 22;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnNieuw
            // 
            this.btnNieuw.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuw.Location = new System.Drawing.Point(317, 203);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(105, 33);
            this.btnNieuw.TabIndex = 21;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.Location = new System.Drawing.Point(428, 42);
            this.txtNaam.MaxLength = 50;
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(213, 27);
            this.txtNaam.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(428, 9);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(213, 27);
            this.txtId.TabIndex = 18;
            // 
            // lblLanden
            // 
            this.lblLanden.AutoSize = true;
            this.lblLanden.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanden.Location = new System.Drawing.Point(325, 117);
            this.lblLanden.Name = "lblLanden";
            this.lblLanden.Size = new System.Drawing.Size(60, 20);
            this.lblLanden.TabIndex = 15;
            this.lblLanden.Text = "Landen:";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoornaam.Location = new System.Drawing.Point(325, 45);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(52, 20);
            this.lblVoornaam.TabIndex = 14;
            this.lblVoornaam.Text = "Naam:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(325, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 20);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id: ";
            // 
            // LstGemeente
            // 
            this.LstGemeente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstGemeente.FormattingEnabled = true;
            this.LstGemeente.ItemHeight = 20;
            this.LstGemeente.Location = new System.Drawing.Point(12, 12);
            this.LstGemeente.Name = "LstGemeente";
            this.LstGemeente.Size = new System.Drawing.Size(289, 204);
            this.LstGemeente.TabIndex = 12;
            this.LstGemeente.SelectedIndexChanged += new System.EventHandler(this.LstGemeente_SelectedIndexChanged);
            // 
            // ddlLand
            // 
            this.ddlLand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlLand.FormattingEnabled = true;
            this.ddlLand.Location = new System.Drawing.Point(428, 116);
            this.ddlLand.Name = "ddlLand";
            this.ddlLand.Size = new System.Drawing.Size(213, 28);
            this.ddlLand.TabIndex = 24;
            // 
            // txtLandId
            // 
            this.txtLandId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandId.Location = new System.Drawing.Point(428, 156);
            this.txtLandId.Name = "txtLandId";
            this.txtLandId.ReadOnly = true;
            this.txtLandId.Size = new System.Drawing.Size(213, 27);
            this.txtLandId.TabIndex = 26;
            // 
            // lblLandId
            // 
            this.lblLandId.AutoSize = true;
            this.lblLandId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandId.Location = new System.Drawing.Point(325, 156);
            this.lblLandId.Name = "lblLandId";
            this.lblLandId.Size = new System.Drawing.Size(61, 20);
            this.lblLandId.TabIndex = 25;
            this.lblLandId.Text = "LandId: ";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(428, 82);
            this.txtPostcode.MaxLength = 9;
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(213, 27);
            this.txtPostcode.TabIndex = 28;
            this.txtPostcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostcode_KeyPress);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(325, 82);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(72, 20);
            this.lblPostcode.TabIndex = 27;
            this.lblPostcode.Text = "Postcode:";
            // 
            // frmBeheerGemeente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 259);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtLandId);
            this.Controls.Add(this.lblLandId);
            this.Controls.Add(this.ddlLand);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblLanden);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.LstGemeente);
            this.Name = "frmBeheerGemeente";
            this.Text = "Beheer Gemeente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeheerGemeente_FormClosing);
            this.Load += new System.EventHandler(this.frmBeheerGemeente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBewaren;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblLanden;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListBox LstGemeente;
        private System.Windows.Forms.ComboBox ddlLand;
        private System.Windows.Forms.TextBox txtLandId;
        private System.Windows.Forms.Label lblLandId;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
    }
}