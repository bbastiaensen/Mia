namespace MiaClient
{
    partial class frmBeheerFinancieringsType
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
            this.lsbKostenplaatsen = new System.Windows.Forms.ListBox();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnBewaren = new System.Windows.Forms.Button();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.lblActief = new System.Windows.Forms.Label();
            this.chkActief = new System.Windows.Forms.CheckBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsbKostenplaatsen
            // 
            this.lsbKostenplaatsen.FormattingEnabled = true;
            this.lsbKostenplaatsen.ItemHeight = 20;
            this.lsbKostenplaatsen.Location = new System.Drawing.Point(12, 23);
            this.lsbKostenplaatsen.Name = "lsbKostenplaatsen";
            this.lsbKostenplaatsen.Size = new System.Drawing.Size(203, 184);
            this.lsbKostenplaatsen.TabIndex = 8;
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(457, 146);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(105, 33);
            this.btnVerwijderen.TabIndex = 18;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btnBewaren
            // 
            this.btnBewaren.Location = new System.Drawing.Point(347, 146);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(105, 33);
            this.btnBewaren.TabIndex = 16;
            this.btnBewaren.Text = "Bewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(236, 146);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(105, 33);
            this.btnNieuw.TabIndex = 14;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            // 
            // lblActief
            // 
            this.lblActief.AutoSize = true;
            this.lblActief.Location = new System.Drawing.Point(232, 113);
            this.lblActief.Name = "lblActief";
            this.lblActief.Size = new System.Drawing.Size(51, 20);
            this.lblActief.TabIndex = 19;
            this.lblActief.Text = "Actief:";
            // 
            // chkActief
            // 
            this.chkActief.AutoSize = true;
            this.chkActief.Location = new System.Drawing.Point(314, 117);
            this.chkActief.Name = "chkActief";
            this.chkActief.Size = new System.Drawing.Size(15, 14);
            this.chkActief.TabIndex = 12;
            this.chkActief.UseVisualStyleBackColor = true;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(232, 79);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(52, 20);
            this.lblNaam.TabIndex = 17;
            this.lblNaam.Text = "Naam:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(232, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "Id:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(314, 76);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(248, 27);
            this.txtNaam.TabIndex = 11;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(314, 29);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(248, 27);
            this.txtId.TabIndex = 9;
            this.txtId.TabStop = false;
            // 
            // frmBeheerFinancieringsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 236);
            this.Controls.Add(this.lsbKostenplaatsen);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.lblActief);
            this.Controls.Add(this.chkActief);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBeheerFinancieringsType";
            this.Text = "Beheer FinancieringsType";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeheerFinancieringsType_FormClosing);
            this.Load += new System.EventHandler(this.frmBeheerFinancieringsType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbKostenplaatsen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnBewaren;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Label lblActief;
        private System.Windows.Forms.CheckBox chkActief;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtId;
    }
}