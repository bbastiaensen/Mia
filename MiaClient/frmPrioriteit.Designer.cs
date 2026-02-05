namespace MiaClient
{
    partial class frmPrioriteit
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
            this.lstPrioriteiten = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblActief = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.chkActief = new System.Windows.Forms.CheckBox();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnBewaren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPrioriteiten
            // 
            this.lstPrioriteiten.FormattingEnabled = true;
            this.lstPrioriteiten.ItemHeight = 20;
            this.lstPrioriteiten.Location = new System.Drawing.Point(16, 18);
            this.lstPrioriteiten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPrioriteiten.Name = "lstPrioriteiten";
            this.lstPrioriteiten.Size = new System.Drawing.Size(305, 184);
            this.lstPrioriteiten.TabIndex = 0;
            this.lstPrioriteiten.SelectedIndexChanged += new System.EventHandler(this.lstPrioriteiten_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(349, 18);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(329, 79);
            this.lblNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(49, 20);
            this.lblNaam.TabIndex = 2;
            this.lblNaam.Text = "Naam";
            // 
            // lblActief
            // 
            this.lblActief.AutoSize = true;
            this.lblActief.Location = new System.Drawing.Point(330, 141);
            this.lblActief.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActief.Name = "lblActief";
            this.lblActief.Size = new System.Drawing.Size(48, 20);
            this.lblActief.TabIndex = 3;
            this.lblActief.Text = "Actief";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(388, 18);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 27);
            this.txtId.TabIndex = 4;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(386, 76);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(132, 27);
            this.txtNaam.TabIndex = 5;
            // 
            // chkActief
            // 
            this.chkActief.AutoSize = true;
            this.chkActief.Location = new System.Drawing.Point(388, 148);
            this.chkActief.Name = "chkActief";
            this.chkActief.Size = new System.Drawing.Size(15, 14);
            this.chkActief.TabIndex = 6;
            this.chkActief.UseVisualStyleBackColor = true;
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(333, 174);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(116, 33);
            this.btnNieuw.TabIndex = 7;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(561, 174);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(100, 33);
            this.btnVerwijderen.TabIndex = 8;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnBewaren
            // 
            this.btnBewaren.Location = new System.Drawing.Point(455, 174);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(100, 33);
            this.btnBewaren.TabIndex = 9;
            this.btnBewaren.Text = "Bewaar";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // frmPrioriteit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 215);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.chkActief);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblActief);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lstPrioriteiten);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrioriteit";
            this.Text = "Beheer Prioriteit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrioriteit_FormClosing);
            this.Load += new System.EventHandler(this.frmPrioriteit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPrioriteiten;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblActief;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.CheckBox chkActief;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnBewaren;
    }
}