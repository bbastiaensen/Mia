namespace MiaClient
{
    partial class mdiMia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiMia));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aanvragenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beheerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gebruikslogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.gebruiksLogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.parameterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gebruikersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aanvragenToolStripMenuItem,
            this.beheerToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1173, 29);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // aanvragenToolStripMenuItem
            // 
            this.aanvragenToolStripMenuItem.Name = "aanvragenToolStripMenuItem";
            this.aanvragenToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.aanvragenToolStripMenuItem.Text = "&Aanvragen";
            this.aanvragenToolStripMenuItem.Click += new System.EventHandler(this.aanvragenToolStripMenuItem_Click);
            // 
            // beheerToolStripMenuItem
            // 
            this.beheerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gebruikersToolStripMenuItem,
            this.gebruikslogToolStripMenuItem,
            this.parametersToolStripMenuItem});
            this.beheerToolStripMenuItem.Name = "beheerToolStripMenuItem";
            this.beheerToolStripMenuItem.Size = new System.Drawing.Size(70, 25);
            this.beheerToolStripMenuItem.Text = "&Beheer";
            // 
            // gebruikslogToolStripMenuItem
            // 
            this.gebruikslogToolStripMenuItem.Name = "gebruikslogToolStripMenuItem";
            this.gebruikslogToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.gebruikslogToolStripMenuItem.Text = "Gebruikslog";
            this.gebruikslogToolStripMenuItem.Click += new System.EventHandler(this.gebruikslogToolStripMenuItem_Click);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(54, 25);
            this.helpMenu.Text = "&Help";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(143, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.aboutToolStripMenuItem.Text = "&Over MIA";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 635);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1173, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gebruiksLogToolStripButton,
            this.parameterToolStripButton,
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 29);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1173, 37);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "Knoppenbalk";
            // 
            // gebruiksLogToolStripButton
            // 
            this.gebruiksLogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gebruiksLogToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("gebruiksLogToolStripButton.Image")));
            this.gebruiksLogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gebruiksLogToolStripButton.Name = "gebruiksLogToolStripButton";
            this.gebruiksLogToolStripButton.Size = new System.Drawing.Size(34, 34);
            this.gebruiksLogToolStripButton.Text = "GebruiksLog";
            this.gebruiksLogToolStripButton.Click += new System.EventHandler(this.gebruiksLogToolStripButton_Click);
            // 
            // parameterToolStripButton
            // 
            this.parameterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.parameterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("parameterToolStripButton.Image")));
            this.parameterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.parameterToolStripButton.Name = "parameterToolStripButton";
            this.parameterToolStripButton.Size = new System.Drawing.Size(34, 34);
            this.parameterToolStripButton.Text = "Parameters";
            this.parameterToolStripButton.Click += new System.EventHandler(this.parameterToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // gebruikersToolStripMenuItem
            // 
            this.gebruikersToolStripMenuItem.Name = "gebruikersToolStripMenuItem";
            this.gebruikersToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.gebruikersToolStripMenuItem.Text = "Gebruikers";
            this.gebruikersToolStripMenuItem.Click += new System.EventHandler(this.gebruikersToolStripMenuItem_Click);
            // 
            // mdiMia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 657);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mdiMia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem beheerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gebruikslogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametersToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton gebruiksLogToolStripButton;
        private System.Windows.Forms.ToolStripButton parameterToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aanvragenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gebruikersToolStripMenuItem;
    }
}



