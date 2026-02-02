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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lstGemeente = new System.Windows.Forms.ListBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtLandId = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblLandId = new System.Windows.Forms.Label();
            this.ddlLand = new System.Windows.Forms.ComboBox();
            this.lblLand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBewaren
            // 
            this.btnBewaren.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewaren.Location = new System.Drawing.Point(418, 252);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(105, 33);
            this.btnBewaren.TabIndex = 33;
            this.btnBewaren.Text = "Bewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderen.Location = new System.Drawing.Point(529, 252);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(105, 33);
            this.btnVerwijderen.TabIndex = 32;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnNieuw
            // 
            this.btnNieuw.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuw.Location = new System.Drawing.Point(307, 252);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(105, 33);
            this.btnNieuw.TabIndex = 31;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.Location = new System.Drawing.Point(412, 67);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(213, 27);
            this.txtNaam.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(412, 22);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(213, 27);
            this.txtId.TabIndex = 29;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(325, 74);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(56, 20);
            this.lblNaam.TabIndex = 26;
            this.lblNaam.Text = "Naam: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(325, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 20);
            this.lblId.TabIndex = 25;
            this.lblId.Text = "Id: ";
            // 
            // lstGemeente
            // 
            this.lstGemeente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGemeente.FormattingEnabled = true;
            this.lstGemeente.ItemHeight = 20;
            this.lstGemeente.Location = new System.Drawing.Point(12, 12);
            this.lstGemeente.Name = "lstGemeente";
            this.lstGemeente.Size = new System.Drawing.Size(289, 224);
            this.lstGemeente.TabIndex = 24;
            this.lstGemeente.SelectedIndexChanged += new System.EventHandler(this.lstGemeente_SelectedIndexChanged);
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(412, 116);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(213, 27);
            this.txtPostcode.TabIndex = 37;
            // 
            // txtLandId
            // 
            this.txtLandId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandId.Location = new System.Drawing.Point(412, 209);
            this.txtLandId.Name = "txtLandId";
            this.txtLandId.ReadOnly = true;
            this.txtLandId.Size = new System.Drawing.Size(213, 27);
            this.txtLandId.TabIndex = 36;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(325, 123);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(76, 20);
            this.lblPostcode.TabIndex = 35;
            this.lblPostcode.Text = "Postcode: ";
            // 
            // lblLandId
            // 
            this.lblLandId.AutoSize = true;
            this.lblLandId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandId.Location = new System.Drawing.Point(325, 209);
            this.lblLandId.Name = "lblLandId";
            this.lblLandId.Size = new System.Drawing.Size(61, 20);
            this.lblLandId.TabIndex = 34;
            this.lblLandId.Text = "LandId: ";
            // 
            // ddlLand
            // 
            this.ddlLand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlLand.FormattingEnabled = true;
            this.ddlLand.Location = new System.Drawing.Point(412, 161);
            this.ddlLand.Name = "ddlLand";
            this.ddlLand.Size = new System.Drawing.Size(213, 28);
            this.ddlLand.TabIndex = 38;
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLand.Location = new System.Drawing.Point(329, 164);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(48, 20);
            this.lblLand.TabIndex = 39;
            this.lblLand.Text = "Land: ";
            // 
            // frmBeheerGemeente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 310);
            this.Controls.Add(this.lblLand);
            this.Controls.Add(this.ddlLand);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtLandId);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblLandId);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lstGemeente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListBox lstGemeente;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtLandId;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblLandId;
        private System.Windows.Forms.ComboBox ddlLand;
        private System.Windows.Forms.Label lblLand;
    }
}