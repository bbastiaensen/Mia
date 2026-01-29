namespace MiaClient
{
    partial class FrmBeheerPrioriteit
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
            this.checkActief = new System.Windows.Forms.CheckBox();
            this.lblActief = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.LstPrioriteiten = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBewaren
            // 
            this.btnBewaren.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewaren.Location = new System.Drawing.Point(431, 139);
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
            this.btnVerwijderen.Location = new System.Drawing.Point(545, 139);
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
            this.btnNieuw.Location = new System.Drawing.Point(320, 139);
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
            this.txtNaam.Location = new System.Drawing.Point(428, 61);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(213, 27);
            this.txtNaam.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(428, 23);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(213, 27);
            this.txtId.TabIndex = 18;
            // 
            // checkActief
            // 
            this.checkActief.AutoSize = true;
            this.checkActief.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkActief.Location = new System.Drawing.Point(428, 94);
            this.checkActief.Name = "checkActief";
            this.checkActief.Size = new System.Drawing.Size(32, 24);
            this.checkActief.TabIndex = 17;
            this.checkActief.Text = " ";
            this.checkActief.UseVisualStyleBackColor = true;
            // 
            // lblActief
            // 
            this.lblActief.AutoSize = true;
            this.lblActief.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActief.Location = new System.Drawing.Point(325, 94);
            this.lblActief.Name = "lblActief";
            this.lblActief.Size = new System.Drawing.Size(51, 20);
            this.lblActief.TabIndex = 16;
            this.lblActief.Text = "Actief:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(325, 64);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(56, 20);
            this.lblNaam.TabIndex = 14;
            this.lblNaam.Text = "Naam: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(325, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 20);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id: ";
            // 
            // LstPrioriteiten
            // 
            this.LstPrioriteiten.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstPrioriteiten.FormattingEnabled = true;
            this.LstPrioriteiten.ItemHeight = 20;
            this.LstPrioriteiten.Location = new System.Drawing.Point(12, 12);
            this.LstPrioriteiten.Name = "LstPrioriteiten";
            this.LstPrioriteiten.Size = new System.Drawing.Size(289, 144);
            this.LstPrioriteiten.TabIndex = 12;
            this.LstPrioriteiten.SelectedIndexChanged += new System.EventHandler(this.LstPrioriteiten_SelectedIndexChanged);
            // 
            // FrmBeheerPrioriteit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 196);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.checkActief);
            this.Controls.Add(this.lblActief);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.LstPrioriteiten);
            this.Name = "FrmBeheerPrioriteit";
            this.Text = "Beheer prioriteiten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBeheerPrioriteit_FormClosing);
            this.Load += new System.EventHandler(this.FrmBeheerPrioriteit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBewaren;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.CheckBox checkActief;
        private System.Windows.Forms.Label lblActief;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListBox LstPrioriteiten;
    }
}