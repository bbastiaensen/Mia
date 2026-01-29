namespace MiaClient
{
    partial class frmNieuweAankoop
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
            this.dgvAanvragen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAanvragen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAanvragen
            // 
            this.dgvAanvragen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAanvragen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAanvragen.Location = new System.Drawing.Point(12, 12);
            this.dgvAanvragen.Name = "dgvAanvragen";
            this.dgvAanvragen.RowHeadersWidth = 51;
            this.dgvAanvragen.RowTemplate.Height = 24;
            this.dgvAanvragen.Size = new System.Drawing.Size(865, 523);
            this.dgvAanvragen.TabIndex = 0;
            this.dgvAanvragen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAanvragen_CellClick);
            // 
            // frmNieuweAankoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 547);
            this.Controls.Add(this.dgvAanvragen);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNieuweAankoop";
            this.Text = "Nieuwe aankoop toevoegen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNieuweAankoop_FormClosing);
            this.Load += new System.EventHandler(this.frmNieuweAankoop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAanvragen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAanvragen;
    }
}