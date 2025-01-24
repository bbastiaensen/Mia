namespace MiaClient.UserControls
{
    partial class Budget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLine = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lblLineThe2nd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(276, 9);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(6, 300);
            this.lblLine.TabIndex = 12;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotaal.Location = new System.Drawing.Point(39, 324);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(64, 28);
            this.lblTotaal.TabIndex = 13;
            this.lblTotaal.Text = "Totaal";
            // 
            // lblLineThe2nd
            // 
            this.lblLineThe2nd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLineThe2nd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLineThe2nd.Location = new System.Drawing.Point(159, 298);
            this.lblLineThe2nd.Name = "lblLineThe2nd";
            this.lblLineThe2nd.Size = new System.Drawing.Size(111, 5);
            this.lblLineThe2nd.TabIndex = 14;
            // 
            // Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLineThe2nd);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.lblLine);
            this.Name = "Budget";
            this.Size = new System.Drawing.Size(610, 372);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Label lblLineThe2nd;
    }
}
