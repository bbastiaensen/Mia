namespace MiaClient
{
    partial class frmBeheerAankopers
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
            this.SuspendLayout();
            // 
            // frmBeheerAankopers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 692);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBeheerAankopers";
            this.Text = "Beheer Aankopers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeheerAankopers_FormClosing);
            this.Load += new System.EventHandler(this.frmBeheerAankopers_Load);
            this.ResumeLayout(false);

        }

        #endregion
=======
        private System.Windows.Forms.ListBox LstAankopers;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblActief;
        private System.Windows.Forms.CheckBox checkActief;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnBewaren;
>>>>>>> a6c3b7d4610a61a3a4ac0a29bd65f05af70416d5
    }
}