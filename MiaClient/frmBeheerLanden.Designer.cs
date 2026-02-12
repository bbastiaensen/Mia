namespace MiaClient
{
    partial class frmBeheerLanden
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
            this.LstLanden = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBewaren
            // 
            this.btnBewaren.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBewaren.Location = new System.Drawing.Point(425, 103);
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
            this.btnVerwijderen.Location = new System.Drawing.Point(536, 103);
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
            this.btnNieuw.Location = new System.Drawing.Point(307, 103);
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
            this.txtNaam.Location = new System.Drawing.Point(428, 65);
            this.txtNaam.MaxLength = 30;
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(213, 27);
            this.txtNaam.TabIndex = 19;
            this.txtNaam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNaam_KeyPress);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(428, 26);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(213, 27);
            this.txtId.TabIndex = 18;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(326, 65);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(56, 20);
            this.lblNaam.TabIndex = 15;
            this.lblNaam.Text = "Naam: ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(326, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 20);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id: ";
            // 
            // LstLanden
            // 
            this.LstLanden.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstLanden.FormattingEnabled = true;
            this.LstLanden.ItemHeight = 20;
            this.LstLanden.Location = new System.Drawing.Point(12, 12);
            this.LstLanden.Name = "LstLanden";
            this.LstLanden.Size = new System.Drawing.Size(289, 124);
            this.LstLanden.TabIndex = 12;
            this.LstLanden.SelectedIndexChanged += new System.EventHandler(this.LstLanden_SelectedIndexChanged);
            // 
            // frmBeheerLanden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 154);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.LstLanden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBeheerLanden";
            this.Text = "Beheer Landen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeheerLanden_FormClosing);
            this.Load += new System.EventHandler(this.frmBeheerLanden_Load);
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
        private System.Windows.Forms.ListBox LstLanden;
    }
}