namespace MiaClient.UserControls
{
    partial class ParameterItem
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
            this.llblDetails = new System.Windows.Forms.LinkLabel();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblWaarde = new System.Windows.Forms.Label();
            this.lblEenheid = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llblDetails
            // 
            this.llblDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblDetails.Location = new System.Drawing.Point(3, 2);
            this.llblDetails.Name = "llblDetails";
            this.llblDetails.Size = new System.Drawing.Size(71, 23);
            this.llblDetails.TabIndex = 3;
            this.llblDetails.TabStop = true;
            this.llblDetails.Text = "Details";
            this.llblDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDetails_LinkClicked);
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(80, 2);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(198, 23);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "01234567890123456789";
            // 
            // lblWaarde
            // 
            this.lblWaarde.Location = new System.Drawing.Point(284, 2);
            this.lblWaarde.Name = "lblWaarde";
            this.lblWaarde.Size = new System.Drawing.Size(243, 23);
            this.lblWaarde.TabIndex = 5;
            this.lblWaarde.Text = "0123456789012345678901234";
            // 
            // lblEenheid
            // 
            this.lblEenheid.Location = new System.Drawing.Point(533, 2);
            this.lblEenheid.Name = "lblEenheid";
            this.lblEenheid.Size = new System.Drawing.Size(243, 23);
            this.lblEenheid.TabIndex = 6;
            this.lblEenheid.Text = "0123456789012345678901234";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 2);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 21);
            this.lblId.TabIndex = 7;
            this.lblId.Visible = false;
            // 
            // ParameterItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblEenheid);
            this.Controls.Add(this.lblWaarde);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.llblDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ParameterItem";
            this.Size = new System.Drawing.Size(778, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblDetails;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblWaarde;
        private System.Windows.Forms.Label lblEenheid;
        private System.Windows.Forms.Label lblId;
    }
}
