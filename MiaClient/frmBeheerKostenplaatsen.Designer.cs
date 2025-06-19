namespace MiaClient
{
    partial class frmBeheerKostenplaatsen
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.chkActief = new System.Windows.Forms.CheckBox();
            this.lblActief = new System.Windows.Forms.Label();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnBewaren = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lsbKostenplaatsen = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(314, 18);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(248, 27);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(314, 84);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(248, 27);
            this.txtNaam.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(314, 51);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(248, 27);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(232, 54);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(47, 20);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Code:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(232, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(232, 87);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(52, 20);
            this.lblNaam.TabIndex = 5;
            this.lblNaam.Text = "Naam:";
            // 
            // chkActief
            // 
            this.chkActief.AutoSize = true;
            this.chkActief.Location = new System.Drawing.Point(314, 125);
            this.chkActief.Name = "chkActief";
            this.chkActief.Size = new System.Drawing.Size(15, 14);
            this.chkActief.TabIndex = 3;
            this.chkActief.UseVisualStyleBackColor = true;
            // 
            // lblActief
            // 
            this.lblActief.AutoSize = true;
            this.lblActief.Location = new System.Drawing.Point(232, 121);
            this.lblActief.Name = "lblActief";
            this.lblActief.Size = new System.Drawing.Size(51, 20);
            this.lblActief.TabIndex = 7;
            this.lblActief.Text = "Actief:";
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(236, 154);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(105, 33);
            this.btnNieuw.TabIndex = 4;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnBewaren
            // 
            this.btnBewaren.Location = new System.Drawing.Point(347, 154);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(105, 33);
            this.btnBewaren.TabIndex = 5;
            this.btnBewaren.Text = "Bewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(457, 154);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(105, 33);
            this.btnVerwijderen.TabIndex = 6;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // lsbKostenplaatsen
            // 
            this.lsbKostenplaatsen.FormattingEnabled = true;
            this.lsbKostenplaatsen.ItemHeight = 20;
            this.lsbKostenplaatsen.Location = new System.Drawing.Point(12, 12);
            this.lsbKostenplaatsen.Name = "lsbKostenplaatsen";
            this.lsbKostenplaatsen.Size = new System.Drawing.Size(203, 184);
            this.lsbKostenplaatsen.TabIndex = 0;
            this.lsbKostenplaatsen.SelectedIndexChanged += new System.EventHandler(this.lsbKostenplaatsen_SelectedIndexChanged);
            // 
            // frmBeheerKostenplaatsen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 212);
            this.Controls.Add(this.lsbKostenplaatsen);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.lblActief);
            this.Controls.Add(this.chkActief);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBeheerKostenplaatsen";
            this.Text = "Beheer Kostenplaatsen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeheerKostenplaatsen_FormClosing);
            this.Load += new System.EventHandler(this.frmBeheerKostenplaatsen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.CheckBox chkActief;
        private System.Windows.Forms.Label lblActief;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnBewaren;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.ListBox lsbKostenplaatsen;
    }
}