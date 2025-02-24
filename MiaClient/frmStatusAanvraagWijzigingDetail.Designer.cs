namespace MiaClient
{
    partial class frmStatusAanvraagWijzigingDetail
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
            this.lblOpmerking = new System.Windows.Forms.Label();
            this.txtOpmerking = new System.Windows.Forms.TextBox();
            this.lblToegekendBedrag = new System.Windows.Forms.Label();
            this.txtToegekendBedrag = new System.Windows.Forms.TextBox();
            this.btnBewaren = new System.Windows.Forms.Button();
            this.lblStatusAanvraag = new System.Windows.Forms.Label();
            this.txtStatusAanvraag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOpmerking
            // 
            this.lblOpmerking.AutoSize = true;
            this.lblOpmerking.Location = new System.Drawing.Point(12, 68);
            this.lblOpmerking.Name = "lblOpmerking";
            this.lblOpmerking.Size = new System.Drawing.Size(83, 20);
            this.lblOpmerking.TabIndex = 0;
            this.lblOpmerking.Text = "Opmerking";
            // 
            // txtOpmerking
            // 
            this.txtOpmerking.Location = new System.Drawing.Point(16, 91);
            this.txtOpmerking.Multiline = true;
            this.txtOpmerking.Name = "txtOpmerking";
            this.txtOpmerking.Size = new System.Drawing.Size(498, 145);
            this.txtOpmerking.TabIndex = 1;
            // 
            // lblToegekendBedrag
            // 
            this.lblToegekendBedrag.AutoSize = true;
            this.lblToegekendBedrag.Location = new System.Drawing.Point(12, 246);
            this.lblToegekendBedrag.Name = "lblToegekendBedrag";
            this.lblToegekendBedrag.Size = new System.Drawing.Size(134, 20);
            this.lblToegekendBedrag.TabIndex = 2;
            this.lblToegekendBedrag.Text = "Toegekend bedrag";
            // 
            // txtToegekendBedrag
            // 
            this.txtToegekendBedrag.Location = new System.Drawing.Point(16, 269);
            this.txtToegekendBedrag.Name = "txtToegekendBedrag";
            this.txtToegekendBedrag.Size = new System.Drawing.Size(498, 27);
            this.txtToegekendBedrag.TabIndex = 3;
            // 
            // btnBewaren
            // 
            this.btnBewaren.Location = new System.Drawing.Point(16, 302);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(498, 58);
            this.btnBewaren.TabIndex = 4;
            this.btnBewaren.Text = "Bewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // lblStatusAanvraag
            // 
            this.lblStatusAanvraag.AutoSize = true;
            this.lblStatusAanvraag.Location = new System.Drawing.Point(12, 9);
            this.lblStatusAanvraag.Name = "lblStatusAanvraag";
            this.lblStatusAanvraag.Size = new System.Drawing.Size(114, 20);
            this.lblStatusAanvraag.TabIndex = 5;
            this.lblStatusAanvraag.Text = "Status aanvraag";
            // 
            // txtStatusAanvraag
            // 
            this.txtStatusAanvraag.Location = new System.Drawing.Point(16, 32);
            this.txtStatusAanvraag.Name = "txtStatusAanvraag";
            this.txtStatusAanvraag.ReadOnly = true;
            this.txtStatusAanvraag.Size = new System.Drawing.Size(498, 27);
            this.txtStatusAanvraag.TabIndex = 6;
            // 
            // frmStatusAanvraagWijzigingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 369);
            this.Controls.Add(this.txtStatusAanvraag);
            this.Controls.Add(this.lblStatusAanvraag);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.txtToegekendBedrag);
            this.Controls.Add(this.lblToegekendBedrag);
            this.Controls.Add(this.txtOpmerking);
            this.Controls.Add(this.lblOpmerking);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStatusAanvraagWijzigingDetail";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "StatusAanvraag wijziging";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStatusAanvraagWijzigingDetail_FormClosing);
            this.Load += new System.EventHandler(this.frmStatusAanvraagWijzigingDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpmerking;
        private System.Windows.Forms.TextBox txtOpmerking;
        private System.Windows.Forms.Label lblToegekendBedrag;
        private System.Windows.Forms.TextBox txtToegekendBedrag;
        private System.Windows.Forms.Button btnBewaren;
        private System.Windows.Forms.Label lblStatusAanvraag;
        private System.Windows.Forms.TextBox txtStatusAanvraag;
    }
}