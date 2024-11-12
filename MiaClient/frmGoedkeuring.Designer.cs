namespace MiaClient
{
    partial class frmGoedkeuring
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
            this.pnlGoedkeuringen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGoedkeuringen
            // 
            this.pnlGoedkeuringen.AutoScroll = true;
            this.pnlGoedkeuringen.Location = new System.Drawing.Point(12, 238);
            this.pnlGoedkeuringen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGoedkeuringen.Name = "pnlGoedkeuringen";
            this.pnlGoedkeuringen.Size = new System.Drawing.Size(1381, 300);
            this.pnlGoedkeuringen.TabIndex = 0;
            // 
            // frmGoedkeuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 549);
            this.Controls.Add(this.pnlGoedkeuringen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmGoedkeuring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Goedkeuringen";
            this.Activated += new System.EventHandler(this.frmGoedkeuring_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoedkeuring_FormClosing);
            this.Load += new System.EventHandler(this.frmGoedkeuring_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGoedkeuringen;
    }
}