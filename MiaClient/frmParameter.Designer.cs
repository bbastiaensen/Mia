namespace MiaClient
{
    partial class frmParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParameter));
            this.grpbxFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblEenheid = new System.Windows.Forms.Label();
            this.lblWaarde = new System.Windows.Forms.Label();
            this.txtEenheid = new System.Windows.Forms.TextBox();
            this.txtWaarde = new System.Windows.Forms.TextBox();
            this.lblParameterTitel = new System.Windows.Forms.Label();
            this.pnlParameters = new System.Windows.Forms.Panel();
            this.txtCodeDetail = new System.Windows.Forms.TextBox();
            this.txtWaardeDetail = new System.Windows.Forms.TextBox();
            this.txtEenheidDetail = new System.Windows.Forms.TextBox();
            this.txtIdDetail = new System.Windows.Forms.TextBox();
            this.lblEenheidDetail = new System.Windows.Forms.Label();
            this.lblCodeDetail = new System.Windows.Forms.Label();
            this.lblWaardeDetail = new System.Windows.Forms.Label();
            this.lblIdDetail = new System.Windows.Forms.Label();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnBewaren = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.grpbxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxFilter
            // 
            this.grpbxFilter.Controls.Add(this.btnFilter);
            this.grpbxFilter.Controls.Add(this.lblCode);
            this.grpbxFilter.Controls.Add(this.txtCode);
            this.grpbxFilter.Controls.Add(this.lblEenheid);
            this.grpbxFilter.Controls.Add(this.lblWaarde);
            this.grpbxFilter.Controls.Add(this.txtEenheid);
            this.grpbxFilter.Controls.Add(this.txtWaarde);
            this.grpbxFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxFilter.Location = new System.Drawing.Point(13, 36);
            this.grpbxFilter.Name = "grpbxFilter";
            this.grpbxFilter.Size = new System.Drawing.Size(885, 101);
            this.grpbxFilter.TabIndex = 0;
            this.grpbxFilter.TabStop = false;
            this.grpbxFilter.Text = "Filteren";
            // 
            // btnFilter
            // 
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(10, 52);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(30, 30);
            this.btnFilter.TabIndex = 28;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(74, 25);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 21);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(78, 54);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(198, 29);
            this.txtCode.TabIndex = 0;
            // 
            // lblEenheid
            // 
            this.lblEenheid.AutoSize = true;
            this.lblEenheid.Location = new System.Drawing.Point(526, 25);
            this.lblEenheid.Name = "lblEenheid";
            this.lblEenheid.Size = new System.Drawing.Size(65, 21);
            this.lblEenheid.TabIndex = 6;
            this.lblEenheid.Text = "Eenheid";
            // 
            // lblWaarde
            // 
            this.lblWaarde.AutoSize = true;
            this.lblWaarde.Location = new System.Drawing.Point(278, 25);
            this.lblWaarde.Name = "lblWaarde";
            this.lblWaarde.Size = new System.Drawing.Size(63, 21);
            this.lblWaarde.TabIndex = 5;
            this.lblWaarde.Text = "Waarde";
            // 
            // txtEenheid
            // 
            this.txtEenheid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEenheid.Location = new System.Drawing.Point(530, 54);
            this.txtEenheid.Name = "txtEenheid";
            this.txtEenheid.Size = new System.Drawing.Size(349, 29);
            this.txtEenheid.TabIndex = 2;
            // 
            // txtWaarde
            // 
            this.txtWaarde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaarde.Location = new System.Drawing.Point(282, 54);
            this.txtWaarde.Name = "txtWaarde";
            this.txtWaarde.Size = new System.Drawing.Size(242, 29);
            this.txtWaarde.TabIndex = 1;
            // 
            // lblParameterTitel
            // 
            this.lblParameterTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameterTitel.Location = new System.Drawing.Point(12, 9);
            this.lblParameterTitel.Name = "lblParameterTitel";
            this.lblParameterTitel.Size = new System.Drawing.Size(865, 24);
            this.lblParameterTitel.TabIndex = 4;
            this.lblParameterTitel.Text = "MIA - Parameters";
            this.lblParameterTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlParameters
            // 
            this.pnlParameters.AutoScroll = true;
            this.pnlParameters.Location = new System.Drawing.Point(12, 143);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.Size = new System.Drawing.Size(886, 311);
            this.pnlParameters.TabIndex = 1;
            // 
            // txtCodeDetail
            // 
            this.txtCodeDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeDetail.Location = new System.Drawing.Point(149, 527);
            this.txtCodeDetail.Name = "txtCodeDetail";
            this.txtCodeDetail.Size = new System.Drawing.Size(743, 29);
            this.txtCodeDetail.TabIndex = 2;
            this.txtCodeDetail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeDetail_KeyPress);
            // 
            // txtWaardeDetail
            // 
            this.txtWaardeDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaardeDetail.Location = new System.Drawing.Point(148, 562);
            this.txtWaardeDetail.Name = "txtWaardeDetail";
            this.txtWaardeDetail.Size = new System.Drawing.Size(744, 29);
            this.txtWaardeDetail.TabIndex = 3;
            // 
            // txtEenheidDetail
            // 
            this.txtEenheidDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEenheidDetail.Location = new System.Drawing.Point(148, 597);
            this.txtEenheidDetail.Name = "txtEenheidDetail";
            this.txtEenheidDetail.Size = new System.Drawing.Size(744, 29);
            this.txtEenheidDetail.TabIndex = 4;
            // 
            // txtIdDetail
            // 
            this.txtIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetail.Location = new System.Drawing.Point(148, 492);
            this.txtIdDetail.Name = "txtIdDetail";
            this.txtIdDetail.ReadOnly = true;
            this.txtIdDetail.Size = new System.Drawing.Size(744, 29);
            this.txtIdDetail.TabIndex = 16;
            this.txtIdDetail.TabStop = false;
            // 
            // lblEenheidDetail
            // 
            this.lblEenheidDetail.AutoSize = true;
            this.lblEenheidDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEenheidDetail.Location = new System.Drawing.Point(17, 600);
            this.lblEenheidDetail.Name = "lblEenheidDetail";
            this.lblEenheidDetail.Size = new System.Drawing.Size(68, 21);
            this.lblEenheidDetail.TabIndex = 15;
            this.lblEenheidDetail.Text = "Eenheid:";
            // 
            // lblCodeDetail
            // 
            this.lblCodeDetail.AutoSize = true;
            this.lblCodeDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeDetail.Location = new System.Drawing.Point(17, 530);
            this.lblCodeDetail.Name = "lblCodeDetail";
            this.lblCodeDetail.Size = new System.Drawing.Size(49, 21);
            this.lblCodeDetail.TabIndex = 14;
            this.lblCodeDetail.Text = "Code:";
            // 
            // lblWaardeDetail
            // 
            this.lblWaardeDetail.AutoSize = true;
            this.lblWaardeDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaardeDetail.Location = new System.Drawing.Point(17, 565);
            this.lblWaardeDetail.Name = "lblWaardeDetail";
            this.lblWaardeDetail.Size = new System.Drawing.Size(66, 21);
            this.lblWaardeDetail.TabIndex = 13;
            this.lblWaardeDetail.Text = "Waarde:";
            // 
            // lblIdDetail
            // 
            this.lblIdDetail.AutoSize = true;
            this.lblIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDetail.Location = new System.Drawing.Point(17, 495);
            this.lblIdDetail.Name = "lblIdDetail";
            this.lblIdDetail.Size = new System.Drawing.Size(26, 21);
            this.lblIdDetail.TabIndex = 12;
            this.lblIdDetail.Text = "Id:";
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(216, 643);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(251, 41);
            this.btnNieuw.TabIndex = 5;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnBewaren
            // 
            this.btnBewaren.Location = new System.Drawing.Point(473, 643);
            this.btnBewaren.Name = "btnBewaren";
            this.btnBewaren.Size = new System.Drawing.Size(251, 41);
            this.btnBewaren.TabIndex = 6;
            this.btnBewaren.Text = "Bewaren";
            this.btnBewaren.UseVisualStyleBackColor = true;
            this.btnBewaren.Click += new System.EventHandler(this.btnBewaren_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(49, 460);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 36;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnPrevious_MouseLeave);
            this.btnPrevious.MouseHover += new System.EventHandler(this.btnPrevious_MouseHover);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(13, 460);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 30);
            this.btnFirst.TabIndex = 35;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            this.btnFirst.MouseLeave += new System.EventHandler(this.btnFirst_MouseLeave);
            this.btnFirst.MouseHover += new System.EventHandler(this.btnFirst_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(832, 460);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 37;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(868, 460);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 30);
            this.btnLast.TabIndex = 38;
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            this.btnLast.MouseLeave += new System.EventHandler(this.btnLast_MouseLeave);
            this.btnLast.MouseHover += new System.EventHandler(this.btnLast_MouseHover);
            // 
            // frmParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 692);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnBewaren);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.txtCodeDetail);
            this.Controls.Add(this.txtWaardeDetail);
            this.Controls.Add(this.txtEenheidDetail);
            this.Controls.Add(this.txtIdDetail);
            this.Controls.Add(this.lblEenheidDetail);
            this.Controls.Add(this.lblCodeDetail);
            this.Controls.Add(this.lblWaardeDetail);
            this.Controls.Add(this.lblIdDetail);
            this.Controls.Add(this.grpbxFilter);
            this.Controls.Add(this.lblParameterTitel);
            this.Controls.Add(this.pnlParameters);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmParameter";
            this.Text = "Parameter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParameter_FormClosing);
            this.Load += new System.EventHandler(this.frmParameter_Load);
            this.Shown += new System.EventHandler(this.frmParameter_Shown);
            this.grpbxFilter.ResumeLayout(false);
            this.grpbxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxFilter;
        private System.Windows.Forms.Label lblEenheid;
        private System.Windows.Forms.Label lblWaarde;
        private System.Windows.Forms.TextBox txtEenheid;
        private System.Windows.Forms.TextBox txtWaarde;
        private System.Windows.Forms.Label lblParameterTitel;
        private System.Windows.Forms.Panel pnlParameters;
        private System.Windows.Forms.TextBox txtCodeDetail;
        private System.Windows.Forms.TextBox txtWaardeDetail;
        private System.Windows.Forms.TextBox txtEenheidDetail;
        private System.Windows.Forms.TextBox txtIdDetail;
        private System.Windows.Forms.Label lblEenheidDetail;
        private System.Windows.Forms.Label lblCodeDetail;
        private System.Windows.Forms.Label lblWaardeDetail;
        private System.Windows.Forms.Label lblIdDetail;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnBewaren;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}