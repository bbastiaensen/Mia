namespace MiaClient.UserControls
{
    partial class AankopenItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AankopenItem));
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblTotaalBedrag = new System.Windows.Forms.Label();
            this.lblRichtperiode = new System.Windows.Forms.Label();
            this.lblAanvrager = new System.Windows.Forms.Label();
            this.lblAanvraagStatus = new System.Windows.Forms.Label();
            this.lblBudgetToegekend = new System.Windows.Forms.Label();

            //extra tekst bij aankopers(thomas)
            this.lblFinancieringsjaar = new System.Windows.Forms.Label();
            
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(27, 27);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // lblTitel
            // 
            this.lblTitel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTitel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitel.Location = new System.Drawing.Point(36, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(232, 33);
            this.lblTitel.TabIndex = 11;
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotaalBedrag
            // 
            this.lblTotaalBedrag.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotaalBedrag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotaalBedrag.Location = new System.Drawing.Point(321, 0);
            this.lblTotaalBedrag.Name = "lblTotaalBedrag";
            this.lblTotaalBedrag.Size = new System.Drawing.Size(147, 33);
            this.lblTotaalBedrag.TabIndex = 12;
            this.lblTotaalBedrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRichtperiode
            // 
            this.lblRichtperiode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRichtperiode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRichtperiode.Location = new System.Drawing.Point(863, 0);
            this.lblRichtperiode.Name = "lblRichtperiode";
            this.lblRichtperiode.Size = new System.Drawing.Size(147, 33);
            this.lblRichtperiode.TabIndex = 14;
            this.lblRichtperiode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAanvrager
            // 
            this.lblAanvrager.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAanvrager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAanvrager.Location = new System.Drawing.Point(541, 0);
            this.lblAanvrager.Name = "lblAanvrager";
            this.lblAanvrager.Size = new System.Drawing.Size(147, 33);
            this.lblAanvrager.TabIndex = 13;
            this.lblAanvrager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AankopenItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRichtperiode);
            this.Controls.Add(this.lblAanvrager);
            this.Controls.Add(this.lblTotaalBedrag);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnEdit);
            this.Name = "AankopenItem";
            this.Size = new System.Drawing.Size(1231, 33);
            this.ResumeLayout(false);




            // 
            // lblFinancieringsjaar
            // 
            this.lblFinancieringsjaar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFinancieringsjaar.Location = new System.Drawing.Point(270, 0); // direct na titel
            this.lblFinancieringsjaar.Name = " lblFinancieringsjaar";
            this.lblFinancieringsjaar.Size = new System.Drawing.Size(120, 33);
            this.lblFinancieringsjaar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.Controls.Add(this.lblFinancieringsjaar);


      

            // 
            //    lblAanvraagStatus
            // 
            this.lblAanvraagStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAanvraagStatus.Location = new System.Drawing.Point(270, 0); // direct na titel
            this.lblAanvraagStatus.Name = "lblAanvraagStatus";
            this.lblAanvraagStatus.Size = new System.Drawing.Size(120, 33);
            this.lblAanvraagStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.Controls.Add(this.lblAanvraagStatus);


            // 
            ////     lblBudgetToegekend
            //// 
            this.lblBudgetToegekend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBudgetToegekend.Location = new System.Drawing.Point(270, 0); // direct na titel
            this.lblBudgetToegekend.Name = "lblAanvraagStatus";
            this.lblBudgetToegekend.Size = new System.Drawing.Size(120, 33);
            this.lblBudgetToegekend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.Controls.Add(this.lblBudgetToegekend);


        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblTotaalBedrag;
        private System.Windows.Forms.Label lblRichtperiode;
        private System.Windows.Forms.Label lblAanvrager;

        //plus thomas
        private System.Windows.Forms.Label lblFinancieringsjaar;
      
        private System.Windows.Forms.Label lblAanvraagStatus;
       



    }
}
