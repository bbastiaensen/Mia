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
            this.pnlGoedkeuringen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGoedkeuringen.Location = new System.Drawing.Point(0, 0);
            this.pnlGoedkeuringen.Name = "pnlGoedkeuringen";
            this.pnlGoedkeuringen.Size = new System.Drawing.Size(1169, 549);
            this.pnlGoedkeuringen.TabIndex = 0;
            // 
            // frmGoedkeuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 549);
            this.Controls.Add(this.pnlGoedkeuringen);
            this.Name = "frmGoedkeuring";
            this.Text = "GoedKeuringsform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoedkeuring_FormClosing);
            this.Load += new System.EventHandler(this.frmGoedkeuring_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGoedkeuringen;
    }
}