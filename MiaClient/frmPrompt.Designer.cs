namespace MiaClient
{
    partial class frmPrompt
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnControleren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(13, 13);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(194, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Geef de backdoor code op:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(17, 38);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(228, 29);
            this.txtCode.TabIndex = 1;
            // 
            // btnControleren
            // 
            this.btnControleren.Location = new System.Drawing.Point(17, 73);
            this.btnControleren.Name = "btnControleren";
            this.btnControleren.Size = new System.Drawing.Size(228, 35);
            this.btnControleren.TabIndex = 2;
            this.btnControleren.Text = "Code controleren";
            this.btnControleren.UseVisualStyleBackColor = true;
            this.btnControleren.Click += new System.EventHandler(this.btnControleren_Click);
            // 
            // frmPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 120);
            this.Controls.Add(this.btnControleren);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backdoor";
            this.Load += new System.EventHandler(this.frmPrompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnControleren;
    }
}