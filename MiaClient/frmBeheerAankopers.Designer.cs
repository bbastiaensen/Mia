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
            this.cmbFinancieringsjaar = new System.Windows.Forms.ComboBox();
            this.btnGenereer = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFinancieringsjaar
            // 
            this.cmbFinancieringsjaar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbFinancieringsjaar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFinancieringsjaar.FormattingEnabled = true;
            this.cmbFinancieringsjaar.Location = new System.Drawing.Point(12, 12);
            this.cmbFinancieringsjaar.Name = "cmbFinancieringsjaar";
            this.cmbFinancieringsjaar.Size = new System.Drawing.Size(64, 33);
            this.cmbFinancieringsjaar.TabIndex = 0;
            this.cmbFinancieringsjaar.SelectedIndexChanged += new System.EventHandler(this.cmbFinancieringsjaar_SelectedIndexChanged);
            // 
            // btnGenereer
            // 
            this.btnGenereer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenereer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenereer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenereer.Location = new System.Drawing.Point(93, 12);
            this.btnGenereer.Name = "btnGenereer";
            this.btnGenereer.Size = new System.Drawing.Size(119, 33);
            this.btnGenereer.TabIndex = 1;
            this.btnGenereer.Text = "Genereren";
            this.btnGenereer.UseVisualStyleBackColor = false;
            this.btnGenereer.Click += new System.EventHandler(this.btnGenereer_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ColumnHeadersVisible = false;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView.Location = new System.Drawing.Point(2, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(900, 502);
            this.dataGridView.TabIndex = 2;
            // 
            // frmBeheerAankopers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 692);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnGenereer);
            this.Controls.Add(this.cmbFinancieringsjaar);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBeheerAankopers";
            this.Text = "Beheer Aankopers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBeheerAankopers_FormClosing);
            this.Load += new System.EventHandler(this.frmBeheerAankopers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFinancieringsjaar;
        private System.Windows.Forms.Button btnGenereer;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}