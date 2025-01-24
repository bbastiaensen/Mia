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
            this.goedkeuringenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetoverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geweigerdeAanvragenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aankopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beheerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gebruikersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.aanvragenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.goedkeuringenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.budgetSpreidingtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.gebruiksLogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.parameterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gebruikersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.geplandeAanvragenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aanvragenToolStripMenuItem,
            this.goedkeuringenToolStripMenuItem,
            this.overzichtenToolStripMenuItem,
            this.aankopenToolStripMenuItem,
            this.beheerToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1564, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // aanvragenToolStripMenuItem
            // 
            this.aanvragenToolStripMenuItem.Name = "aanvragenToolStripMenuItem";
            this.aanvragenToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.aanvragenToolStripMenuItem.Text = "&Aanvragen";
            this.aanvragenToolStripMenuItem.Click += new System.EventHandler(this.aanvragenToolStripMenuItem_Click);
            this.aanvragenToolStripMenuItem.MouseEnter += new System.EventHandler(this.kleuronhover);
            this.aanvragenToolStripMenuItem.MouseLeave += new System.EventHandler(this.kleuronleave);
            // 
            // goedkeuringenToolStripMenuItem
            // 
            this.goedkeuringenToolStripMenuItem.Name = "goedkeuringenToolStripMenuItem";
            this.goedkeuringenToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.goedkeuringenToolStripMenuItem.Text = "Goedkeuringen";
            this.goedkeuringenToolStripMenuItem.Click += new System.EventHandler(this.goedkeuringenToolStripMenuItem_Click);
            // 
            // overzichtenToolStripMenuItem
            // 
            this.overzichtenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.budgetoverzichtToolStripMenuItem,
            this.geweigerdeAanvragenToolStripMenuItem,
            this.geplandeAanvragenToolStripMenuItem});
            this.overzichtenToolStripMenuItem.Name = "overzichtenToolStripMenuItem";
            this.overzichtenToolStripMenuItem.Size = new System.Drawing.Size(130, 32);
            this.overzichtenToolStripMenuItem.Text = "Overzichten";
            // 
            // budgetoverzichtToolStripMenuItem
            // 
            this.budgetoverzichtToolStripMenuItem.Name = "budgetoverzichtToolStripMenuItem";
            this.budgetoverzichtToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.budgetoverzichtToolStripMenuItem.Text = "Budgetspreiding";
            this.budgetoverzichtToolStripMenuItem.Click += new System.EventHandler(this.budgetoverzichtToolStripMenuItem_Click);
            // 
            // geweigerdeAanvragenToolStripMenuItem
            // 
            this.geweigerdeAanvragenToolStripMenuItem.Name = "geweigerdeAanvragenToolStripMenuItem";
            this.geweigerdeAanvragenToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.geweigerdeAanvragenToolStripMenuItem.Text = "Geweigerde Aanvragen";
            this.geweigerdeAanvragenToolStripMenuItem.Click += new System.EventHandler(this.geweigerdeAanvragenToolStripMenuItem_Click);
            // 
            // aankopenToolStripMenuItem
            // 
            this.aankopenToolStripMenuItem.Name = "aankopenToolStripMenuItem";
            this.aankopenToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.aankopenToolStripMenuItem.Text = "Aankopen";
            this.aankopenToolStripMenuItem.Click += new System.EventHandler(this.aankopenToolStripMenuItem_Click);
            // 
            // beheerToolStripMenuItem
            // 
            this.beheerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gebruikersToolStripMenuItem,
            this.gebruikslogToolStripMenuItem,
            this.parametersToolStripMenuItem});
            this.beheerToolStripMenuItem.Name = "beheerToolStripMenuItem";
            this.beheerToolStripMenuItem.Size = new System.Drawing.Size(85, 32);
            this.beheerToolStripMenuItem.Text = "&Beheer";
            this.beheerToolStripMenuItem.Click += new System.EventHandler(this.beheerToolStripMenuItem_Click);
            this.beheerToolStripMenuItem.MouseEnter += new System.EventHandler(this.kleuronhover);
            this.beheerToolStripMenuItem.MouseLeave += new System.EventHandler(this.kleuronleave);
            // 
            // gebruikersToolStripMenuItem
            // 
            this.gebruikersToolStripMenuItem.Name = "gebruikersToolStripMenuItem";
            this.gebruikersToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.gebruikersToolStripMenuItem.Text = "Gebruikers";
            this.gebruikersToolStripMenuItem.Click += new System.EventHandler(this.gebruikersToolStripMenuItem_Click);
            this.gebruikersToolStripMenuItem.MouseEnter += new System.EventHandler(this.kleuronhover);
            this.gebruikersToolStripMenuItem.MouseLeave += new System.EventHandler(this.kleuronleave);
            // 
            // gebruikslogToolStripMenuItem
            // 
            this.gebruikslogToolStripMenuItem.Name = "gebruikslogToolStripMenuItem";
            this.gebruikslogToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.gebruikslogToolStripMenuItem.Text = "Gebruikslog";
            this.gebruikslogToolStripMenuItem.Click += new System.EventHandler(this.gebruikslogToolStripMenuItem_Click);
            this.gebruikslogToolStripMenuItem.MouseEnter += new System.EventHandler(this.kleuronhover);
            this.gebruikslogToolStripMenuItem.MouseLeave += new System.EventHandler(this.kleuronleave);
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.parametersToolStripMenuItem.Text = "Parameters";
            this.parametersToolStripMenuItem.Click += new System.EventHandler(this.parametersToolStripMenuItem_Click);
            this.parametersToolStripMenuItem.MouseEnter += new System.EventHandler(this.kleuronhover);
            this.parametersToolStripMenuItem.MouseLeave += new System.EventHandler(this.kleuronleave);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(67, 32);
            this.helpMenu.Text = "&Help";
            this.helpMenu.MouseEnter += new System.EventHandler(this.kleuronhover);
            this.helpMenu.MouseLeave += new System.EventHandler(this.kleuronleave);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.indexToolStripMenuItem.Text = "&Index";
            this.indexToolStripMenuItem.MouseEnter += new System.EventHandler(this.kleuronhover);
            this.indexToolStripMenuItem.MouseLeave += new System.EventHandler(this.kleuronleave);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(178, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.aboutToolStripMenuItem.Text = "&Over MIA";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 780);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1564, 29);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(56, 23);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aanvragenToolStripButton,
            this.tss1,
            this.goedkeuringenToolStripButton,
            this.tss2,
            this.budgetSpreidingtoolStripButton,
            this.tss3,
            this.gebruiksLogToolStripButton,
            this.parameterToolStripButton,
            this.gebruikersToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 36);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1564, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "Knoppenbalk";
            // 
            // aanvragenToolStripButton
            // 
            this.aanvragenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aanvragenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aanvragenToolStripButton.Name = "aanvragenToolStripButton";
            this.aanvragenToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.aanvragenToolStripButton.Text = "Aanvragen";
            this.aanvragenToolStripButton.Click += new System.EventHandler(this.aanvragenToolStripButton_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(6, 25);
            this.tss1.Visible = false;
            // 
            // goedkeuringenToolStripButton
            // 
            this.goedkeuringenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goedkeuringenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goedkeuringenToolStripButton.Name = "goedkeuringenToolStripButton";
            this.goedkeuringenToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.goedkeuringenToolStripButton.Text = "Goedkeuringen";
            this.goedkeuringenToolStripButton.Click += new System.EventHandler(this.goedkeuringenToolStripButton_Click);
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(6, 25);
            this.tss2.Visible = false;
            // 
            // budgetSpreidingtoolStripButton
            // 
            this.budgetSpreidingtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.budgetSpreidingtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.budgetSpreidingtoolStripButton.Name = "budgetSpreidingtoolStripButton";
            this.budgetSpreidingtoolStripButton.Size = new System.Drawing.Size(29, 22);
            this.budgetSpreidingtoolStripButton.Click += new System.EventHandler(this.budgetSpreidingtoolStripButton_Click);
            // 
            // tss3
            // 
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(6, 25);
            this.tss3.Visible = false;
            // 
            // gebruiksLogToolStripButton
            // 
            this.gebruiksLogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gebruiksLogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gebruiksLogToolStripButton.Name = "gebruiksLogToolStripButton";
            this.gebruiksLogToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.gebruiksLogToolStripButton.Text = "GebruiksLog";
            this.gebruiksLogToolStripButton.Click += new System.EventHandler(this.gebruiksLogToolStripButton_Click);
            // 
            // parameterToolStripButton
            // 
            this.parameterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.parameterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.parameterToolStripButton.Name = "parameterToolStripButton";
            this.parameterToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.parameterToolStripButton.Text = "Parameters";
            this.parameterToolStripButton.Click += new System.EventHandler(this.parameterToolStripButton_Click);
            // 
            // gebruikersToolStripButton
            // 
            this.gebruikersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gebruikersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gebruikersToolStripButton.Name = "gebruikersToolStripButton";
            this.gebruikersToolStripButton.Size = new System.Drawing.Size(29, 22);
            this.gebruikersToolStripButton.Text = "Gebruikersbeheer";
            this.gebruikersToolStripButton.Click += new System.EventHandler(this.gebruikersToolStripButton_Click);
            // 
            // geplandeAanvragenToolStripMenuItem
            // 
            this.geplandeAanvragenToolStripMenuItem.Name = "geplandeAanvragenToolStripMenuItem";
            this.geplandeAanvragenToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.geplandeAanvragenToolStripMenuItem.Text = "Geplande Aanvragen";
            this.geplandeAanvragenToolStripMenuItem.Click += new System.EventHandler(this.geplandeAanvragenToolStripMenuItem_Click);
            // 
            // mdiMia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 809);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mdiMia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MIA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiMia_Load);
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
        private System.Windows.Forms.ToolStripMenuItem aanvragenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gebruikersToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton aanvragenToolStripButton;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripMenuItem goedkeuringenToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton gebruikersToolStripButton;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripButton goedkeuringenToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem overzichtenToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton budgetSpreidingtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator tss3;
        private System.Windows.Forms.ToolStripMenuItem budgetoverzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aankopenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geweigerdeAanvragenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geplandeAanvragenToolStripMenuItem;
    }
}


