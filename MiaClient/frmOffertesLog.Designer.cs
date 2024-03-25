namespace MiaClient
{
    partial class frmOffertesLog
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
            this.pnlOfferte = new System.Windows.Forms.Panel();
            this.grpbxFilter = new System.Windows.Forms.GroupBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.grpbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOfferte
            // 
            this.pnlOfferte.AutoScroll = true;
            this.pnlOfferte.Location = new System.Drawing.Point(16, 186);
            this.pnlOfferte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOfferte.Name = "pnlOfferte";
            this.pnlOfferte.Size = new System.Drawing.Size(1057, 396);
            this.pnlOfferte.TabIndex = 2;
            // 
            // grpbxFilter
            // 
            this.grpbxFilter.Controls.Add(this.lblTitel);
            this.grpbxFilter.Controls.Add(this.txtTitel);
            this.grpbxFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxFilter.Location = new System.Drawing.Point(12, 44);
            this.grpbxFilter.Name = "grpbxFilter";
            this.grpbxFilter.Size = new System.Drawing.Size(1061, 101);
            this.grpbxFilter.TabIndex = 3;
            this.grpbxFilter.TabStop = false;
            this.grpbxFilter.Text = "Filteren";
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Location = new System.Drawing.Point(94, 39);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(49, 28);
            this.lblTitel.TabIndex = 8;
            this.lblTitel.Text = "Titel";
            // 
            // txtTitel
            // 
            this.txtTitel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitel.Location = new System.Drawing.Point(203, 33);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(540, 34);
            this.txtTitel.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(12, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(172, 37);
            this.btnFilter.TabIndex = 29;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // frmOffertesLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 1008);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.grpbxFilter);
            this.Controls.Add(this.pnlOfferte);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOffertesLog";
            this.Text = "frmOffertesLog";
            this.grpbxFilter.ResumeLayout(false);
            this.grpbxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOfferte;
        private System.Windows.Forms.GroupBox grpbxFilter;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Button btnFilter;
    }
}