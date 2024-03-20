namespace MiaClient
{
    partial class FrmBestanden
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Links = new System.Windows.Forms.TabPage();
            this.btn_bewaarLink = new System.Windows.Forms.Button();
            this.btn_verwijderLink = new System.Windows.Forms.Button();
            this.btn_nieuweLink = new System.Windows.Forms.Button();
            this.txt_hyperlinkInput = new System.Windows.Forms.TextBox();
            this.lbl_hyperlinkDetail = new System.Windows.Forms.Label();
            this.lbl_linksTitel = new System.Windows.Forms.Label();
            this.pnl_Links = new System.Windows.Forms.Panel();
            this.tabPage_Fotos = new System.Windows.Forms.TabPage();
            this.btn_bewaarFoto = new System.Windows.Forms.Button();
            this.btn_verwijderFoto = new System.Windows.Forms.Button();
            this.btn_nieuweFoto = new System.Windows.Forms.Button();
            this.btn_kiesFoto = new System.Windows.Forms.Button();
            this.txt_FotoId = new System.Windows.Forms.TextBox();
            this.lbl_fotoIdDetail = new System.Windows.Forms.Label();
            this.txt_fotoURLInput = new System.Windows.Forms.TextBox();
            this.lbl_fotoUrlDetail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Fotos = new System.Windows.Forms.Panel();
            this.lbl_fotosTitel = new System.Windows.Forms.Label();
            this.tabPage_Offertes = new System.Windows.Forms.TabPage();
            this.btn_bewaarOfferte = new System.Windows.Forms.Button();
            this.btn_verwijderOfferte = new System.Windows.Forms.Button();
            this.btn_nieuweOfferte = new System.Windows.Forms.Button();
            this.btn_kiesOfferte = new System.Windows.Forms.Button();
            this.txt_offerteId = new System.Windows.Forms.TextBox();
            this.lbl_offerteIdDetail = new System.Windows.Forms.Label();
            this.txt_offerteURLInput = new System.Windows.Forms.TextBox();
            this.lbl_offerteURLDetail = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_offertesTitel = new System.Windows.Forms.Label();
            this.pnl_Offertes = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabPage_Links.SuspendLayout();
            this.tabPage_Fotos.SuspendLayout();
            this.tabPage_Offertes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(9, -34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 610);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voorstellen";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Links);
            this.tabControl.Controls.Add(this.tabPage_Fotos);
            this.tabControl.Controls.Add(this.tabPage_Offertes);
            this.tabControl.Location = new System.Drawing.Point(9, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(851, 572);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_Links
            // 
            this.tabPage_Links.Controls.Add(this.btn_bewaarLink);
            this.tabPage_Links.Controls.Add(this.btn_verwijderLink);
            this.tabPage_Links.Controls.Add(this.btn_nieuweLink);
            this.tabPage_Links.Controls.Add(this.txt_hyperlinkInput);
            this.tabPage_Links.Controls.Add(this.lbl_hyperlinkDetail);
            this.tabPage_Links.Controls.Add(this.lbl_linksTitel);
            this.tabPage_Links.Controls.Add(this.pnl_Links);
            this.tabPage_Links.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Links.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Links.Name = "tabPage_Links";
            this.tabPage_Links.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Links.Size = new System.Drawing.Size(843, 543);
            this.tabPage_Links.TabIndex = 0;
            this.tabPage_Links.Text = "Links";
            this.tabPage_Links.UseVisualStyleBackColor = true;
            // 
            // btn_bewaarLink
            // 
            this.btn_bewaarLink.Location = new System.Drawing.Point(281, 343);
            this.btn_bewaarLink.Name = "btn_bewaarLink";
            this.btn_bewaarLink.Size = new System.Drawing.Size(267, 75);
            this.btn_bewaarLink.TabIndex = 10;
            this.btn_bewaarLink.Text = "Bewaren";
            this.btn_bewaarLink.UseVisualStyleBackColor = true;
            this.btn_bewaarLink.Click += new System.EventHandler(this.btn_bewaarLink_Click);
            // 
            // btn_verwijderLink
            // 
            this.btn_verwijderLink.Location = new System.Drawing.Point(572, 343);
            this.btn_verwijderLink.Name = "btn_verwijderLink";
            this.btn_verwijderLink.Size = new System.Drawing.Size(243, 75);
            this.btn_verwijderLink.TabIndex = 9;
            this.btn_verwijderLink.Text = "Verwijder";
            this.btn_verwijderLink.UseVisualStyleBackColor = true;
            this.btn_verwijderLink.Click += new System.EventHandler(this.btn_verwijderLink_Click);
            // 
            // btn_nieuweLink
            // 
            this.btn_nieuweLink.Location = new System.Drawing.Point(17, 343);
            this.btn_nieuweLink.Name = "btn_nieuweLink";
            this.btn_nieuweLink.Size = new System.Drawing.Size(240, 75);
            this.btn_nieuweLink.TabIndex = 8;
            this.btn_nieuweLink.Text = "Nieuw";
            this.btn_nieuweLink.UseVisualStyleBackColor = true;
            this.btn_nieuweLink.Click += new System.EventHandler(this.btn_nieuweLink_Click);
            // 
            // txt_hyperlinkInput
            // 
            this.txt_hyperlinkInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hyperlinkInput.Location = new System.Drawing.Point(119, 298);
            this.txt_hyperlinkInput.Name = "txt_hyperlinkInput";
            this.txt_hyperlinkInput.Size = new System.Drawing.Size(696, 22);
            this.txt_hyperlinkInput.TabIndex = 7;
            // 
            // lbl_hyperlinkDetail
            // 
            this.lbl_hyperlinkDetail.AutoSize = true;
            this.lbl_hyperlinkDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hyperlinkDetail.Location = new System.Drawing.Point(12, 295);
            this.lbl_hyperlinkDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hyperlinkDetail.Name = "lbl_hyperlinkDetail";
            this.lbl_hyperlinkDetail.Size = new System.Drawing.Size(100, 28);
            this.lbl_hyperlinkDetail.TabIndex = 6;
            this.lbl_hyperlinkDetail.Text = "Hyperlink:";
            this.lbl_hyperlinkDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_linksTitel
            // 
            this.lbl_linksTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_linksTitel.Location = new System.Drawing.Point(11, 7);
            this.lbl_linksTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_linksTitel.Name = "lbl_linksTitel";
            this.lbl_linksTitel.Size = new System.Drawing.Size(811, 84);
            this.lbl_linksTitel.TabIndex = 1;
            this.lbl_linksTitel.Text = "Links";
            this.lbl_linksTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Links
            // 
            this.pnl_Links.AutoScroll = true;
            this.pnl_Links.Location = new System.Drawing.Point(17, 113);
            this.pnl_Links.Name = "pnl_Links";
            this.pnl_Links.Size = new System.Drawing.Size(805, 176);
            this.pnl_Links.TabIndex = 0;
            // 
            // tabPage_Fotos
            // 
            this.tabPage_Fotos.Controls.Add(this.btn_bewaarFoto);
            this.tabPage_Fotos.Controls.Add(this.btn_verwijderFoto);
            this.tabPage_Fotos.Controls.Add(this.btn_nieuweFoto);
            this.tabPage_Fotos.Controls.Add(this.btn_kiesFoto);
            this.tabPage_Fotos.Controls.Add(this.txt_FotoId);
            this.tabPage_Fotos.Controls.Add(this.lbl_fotoIdDetail);
            this.tabPage_Fotos.Controls.Add(this.txt_fotoURLInput);
            this.tabPage_Fotos.Controls.Add(this.lbl_fotoUrlDetail);
            this.tabPage_Fotos.Controls.Add(this.label5);
            this.tabPage_Fotos.Controls.Add(this.pnl_Fotos);
            this.tabPage_Fotos.Controls.Add(this.lbl_fotosTitel);
            this.tabPage_Fotos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Fotos.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Fotos.Name = "tabPage_Fotos";
            this.tabPage_Fotos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Fotos.Size = new System.Drawing.Size(843, 543);
            this.tabPage_Fotos.TabIndex = 1;
            this.tabPage_Fotos.Text = "Foto\'s";
            this.tabPage_Fotos.UseVisualStyleBackColor = true;
            // 
            // btn_bewaarFoto
            // 
            this.btn_bewaarFoto.Location = new System.Drawing.Point(268, 376);
            this.btn_bewaarFoto.Name = "btn_bewaarFoto";
            this.btn_bewaarFoto.Size = new System.Drawing.Size(206, 40);
            this.btn_bewaarFoto.TabIndex = 21;
            this.btn_bewaarFoto.Text = "Bewaren";
            this.btn_bewaarFoto.UseVisualStyleBackColor = true;
            this.btn_bewaarFoto.Click += new System.EventHandler(this.btn_bewaarFoto_Click);
            // 
            // btn_verwijderFoto
            // 
            this.btn_verwijderFoto.Location = new System.Drawing.Point(519, 376);
            this.btn_verwijderFoto.Name = "btn_verwijderFoto";
            this.btn_verwijderFoto.Size = new System.Drawing.Size(206, 40);
            this.btn_verwijderFoto.TabIndex = 20;
            this.btn_verwijderFoto.Text = "Verwijder";
            this.btn_verwijderFoto.UseVisualStyleBackColor = true;
            this.btn_verwijderFoto.Click += new System.EventHandler(this.btn_verwijderFoto_Click);
            // 
            // btn_nieuweFoto
            // 
            this.btn_nieuweFoto.Location = new System.Drawing.Point(17, 376);
            this.btn_nieuweFoto.Name = "btn_nieuweFoto";
            this.btn_nieuweFoto.Size = new System.Drawing.Size(206, 40);
            this.btn_nieuweFoto.TabIndex = 19;
            this.btn_nieuweFoto.Text = "Nieuw";
            this.btn_nieuweFoto.UseVisualStyleBackColor = true;
            this.btn_nieuweFoto.Click += new System.EventHandler(this.btn_nieuweFoto_Click);
            // 
            // btn_kiesFoto
            // 
            this.btn_kiesFoto.Location = new System.Drawing.Point(652, 331);
            this.btn_kiesFoto.Name = "btn_kiesFoto";
            this.btn_kiesFoto.Size = new System.Drawing.Size(75, 38);
            this.btn_kiesFoto.TabIndex = 18;
            this.btn_kiesFoto.Text = "...";
            this.btn_kiesFoto.UseVisualStyleBackColor = true;
            this.btn_kiesFoto.Click += new System.EventHandler(this.btn_kiesFoto_Click);
            // 
            // txt_FotoId
            // 
            this.txt_FotoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FotoId.Location = new System.Drawing.Point(74, 290);
            this.txt_FotoId.Name = "txt_FotoId";
            this.txt_FotoId.ReadOnly = true;
            this.txt_FotoId.Size = new System.Drawing.Size(93, 22);
            this.txt_FotoId.TabIndex = 17;
            // 
            // lbl_fotoIdDetail
            // 
            this.lbl_fotoIdDetail.AutoSize = true;
            this.lbl_fotoIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fotoIdDetail.Location = new System.Drawing.Point(12, 294);
            this.lbl_fotoIdDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fotoIdDetail.Name = "lbl_fotoIdDetail";
            this.lbl_fotoIdDetail.Size = new System.Drawing.Size(33, 28);
            this.lbl_fotoIdDetail.TabIndex = 16;
            this.lbl_fotoIdDetail.Text = "Id:";
            this.lbl_fotoIdDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_fotoURLInput
            // 
            this.txt_fotoURLInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fotoURLInput.Location = new System.Drawing.Point(74, 333);
            this.txt_fotoURLInput.Name = "txt_fotoURLInput";
            this.txt_fotoURLInput.ReadOnly = true;
            this.txt_fotoURLInput.Size = new System.Drawing.Size(572, 22);
            this.txt_fotoURLInput.TabIndex = 12;
            // 
            // lbl_fotoUrlDetail
            // 
            this.lbl_fotoUrlDetail.AutoSize = true;
            this.lbl_fotoUrlDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fotoUrlDetail.Location = new System.Drawing.Point(12, 335);
            this.lbl_fotoUrlDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fotoUrlDetail.Name = "lbl_fotoUrlDetail";
            this.lbl_fotoUrlDetail.Size = new System.Drawing.Size(51, 28);
            this.lbl_fotoUrlDetail.TabIndex = 11;
            this.lbl_fotoUrlDetail.Text = "URL:";
            this.lbl_fotoUrlDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 28);
            this.label5.TabIndex = 8;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_Fotos
            // 
            this.pnl_Fotos.AutoScroll = true;
            this.pnl_Fotos.Location = new System.Drawing.Point(17, 100);
            this.pnl_Fotos.Name = "pnl_Fotos";
            this.pnl_Fotos.Size = new System.Drawing.Size(715, 181);
            this.pnl_Fotos.TabIndex = 3;
            // 
            // lbl_fotosTitel
            // 
            this.lbl_fotosTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fotosTitel.Location = new System.Drawing.Point(11, 7);
            this.lbl_fotosTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fotosTitel.Name = "lbl_fotosTitel";
            this.lbl_fotosTitel.Size = new System.Drawing.Size(721, 30);
            this.lbl_fotosTitel.TabIndex = 2;
            this.lbl_fotosTitel.Text = "Foto\'s";
            this.lbl_fotosTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_Offertes
            // 
            this.tabPage_Offertes.Controls.Add(this.btn_bewaarOfferte);
            this.tabPage_Offertes.Controls.Add(this.btn_verwijderOfferte);
            this.tabPage_Offertes.Controls.Add(this.btn_nieuweOfferte);
            this.tabPage_Offertes.Controls.Add(this.btn_kiesOfferte);
            this.tabPage_Offertes.Controls.Add(this.txt_offerteId);
            this.tabPage_Offertes.Controls.Add(this.lbl_offerteIdDetail);
            this.tabPage_Offertes.Controls.Add(this.txt_offerteURLInput);
            this.tabPage_Offertes.Controls.Add(this.lbl_offerteURLDetail);
            this.tabPage_Offertes.Controls.Add(this.label9);
            this.tabPage_Offertes.Controls.Add(this.lbl_offertesTitel);
            this.tabPage_Offertes.Controls.Add(this.pnl_Offertes);
            this.tabPage_Offertes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Offertes.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Offertes.Name = "tabPage_Offertes";
            this.tabPage_Offertes.Size = new System.Drawing.Size(843, 543);
            this.tabPage_Offertes.TabIndex = 2;
            this.tabPage_Offertes.Text = "Offertes";
            this.tabPage_Offertes.UseVisualStyleBackColor = true;
            // 
            // btn_bewaarOfferte
            // 
            this.btn_bewaarOfferte.Location = new System.Drawing.Point(268, 376);
            this.btn_bewaarOfferte.Name = "btn_bewaarOfferte";
            this.btn_bewaarOfferte.Size = new System.Drawing.Size(206, 40);
            this.btn_bewaarOfferte.TabIndex = 30;
            this.btn_bewaarOfferte.Text = "Bewaren";
            this.btn_bewaarOfferte.UseVisualStyleBackColor = true;
            this.btn_bewaarOfferte.Click += new System.EventHandler(this.btn_bewaarOfferte_Click);
            // 
            // btn_verwijderOfferte
            // 
            this.btn_verwijderOfferte.Location = new System.Drawing.Point(519, 376);
            this.btn_verwijderOfferte.Name = "btn_verwijderOfferte";
            this.btn_verwijderOfferte.Size = new System.Drawing.Size(206, 40);
            this.btn_verwijderOfferte.TabIndex = 29;
            this.btn_verwijderOfferte.Text = "Verwijder";
            this.btn_verwijderOfferte.UseVisualStyleBackColor = true;
            this.btn_verwijderOfferte.Click += new System.EventHandler(this.btn_verwijderOfferte_Click);
            // 
            // btn_nieuweOfferte
            // 
            this.btn_nieuweOfferte.Location = new System.Drawing.Point(17, 376);
            this.btn_nieuweOfferte.Name = "btn_nieuweOfferte";
            this.btn_nieuweOfferte.Size = new System.Drawing.Size(206, 40);
            this.btn_nieuweOfferte.TabIndex = 28;
            this.btn_nieuweOfferte.Text = "Nieuw";
            this.btn_nieuweOfferte.UseVisualStyleBackColor = true;
            this.btn_nieuweOfferte.Click += new System.EventHandler(this.btn_nieuweOfferte_Click);
            // 
            // btn_kiesOfferte
            // 
            this.btn_kiesOfferte.Location = new System.Drawing.Point(652, 331);
            this.btn_kiesOfferte.Name = "btn_kiesOfferte";
            this.btn_kiesOfferte.Size = new System.Drawing.Size(75, 38);
            this.btn_kiesOfferte.TabIndex = 27;
            this.btn_kiesOfferte.Text = "...";
            this.btn_kiesOfferte.UseVisualStyleBackColor = true;
            this.btn_kiesOfferte.Click += new System.EventHandler(this.btn_kiesOfferte_Click);
            // 
            // txt_offerteId
            // 
            this.txt_offerteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_offerteId.Location = new System.Drawing.Point(74, 290);
            this.txt_offerteId.Name = "txt_offerteId";
            this.txt_offerteId.ReadOnly = true;
            this.txt_offerteId.Size = new System.Drawing.Size(93, 22);
            this.txt_offerteId.TabIndex = 26;
            // 
            // lbl_offerteIdDetail
            // 
            this.lbl_offerteIdDetail.AutoSize = true;
            this.lbl_offerteIdDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offerteIdDetail.Location = new System.Drawing.Point(12, 294);
            this.lbl_offerteIdDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_offerteIdDetail.Name = "lbl_offerteIdDetail";
            this.lbl_offerteIdDetail.Size = new System.Drawing.Size(33, 28);
            this.lbl_offerteIdDetail.TabIndex = 25;
            this.lbl_offerteIdDetail.Text = "Id:";
            this.lbl_offerteIdDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_offerteURLInput
            // 
            this.txt_offerteURLInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_offerteURLInput.Location = new System.Drawing.Point(74, 333);
            this.txt_offerteURLInput.Name = "txt_offerteURLInput";
            this.txt_offerteURLInput.ReadOnly = true;
            this.txt_offerteURLInput.Size = new System.Drawing.Size(572, 22);
            this.txt_offerteURLInput.TabIndex = 24;
            // 
            // lbl_offerteURLDetail
            // 
            this.lbl_offerteURLDetail.AutoSize = true;
            this.lbl_offerteURLDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offerteURLDetail.Location = new System.Drawing.Point(12, 335);
            this.lbl_offerteURLDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_offerteURLDetail.Name = "lbl_offerteURLDetail";
            this.lbl_offerteURLDetail.Size = new System.Drawing.Size(51, 28);
            this.lbl_offerteURLDetail.TabIndex = 23;
            this.lbl_offerteURLDetail.Text = "URL:";
            this.lbl_offerteURLDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 284);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 28);
            this.label9.TabIndex = 22;
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_offertesTitel
            // 
            this.lbl_offertesTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offertesTitel.Location = new System.Drawing.Point(11, 7);
            this.lbl_offertesTitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_offertesTitel.Name = "lbl_offertesTitel";
            this.lbl_offertesTitel.Size = new System.Drawing.Size(721, 30);
            this.lbl_offertesTitel.TabIndex = 12;
            this.lbl_offertesTitel.Text = "Offertes";
            this.lbl_offertesTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Offertes
            // 
            this.pnl_Offertes.Location = new System.Drawing.Point(17, 51);
            this.pnl_Offertes.Name = "pnl_Offertes";
            this.pnl_Offertes.Size = new System.Drawing.Size(715, 230);
            this.pnl_Offertes.TabIndex = 11;
            // 
            // FrmBestanden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 464);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBestanden";
            this.Text = "FrmBestanden";
            this.tabControl.ResumeLayout(false);
            this.tabPage_Links.ResumeLayout(false);
            this.tabPage_Links.PerformLayout();
            this.tabPage_Fotos.ResumeLayout(false);
            this.tabPage_Fotos.PerformLayout();
            this.tabPage_Offertes.ResumeLayout(false);
            this.tabPage_Offertes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Links;
        private System.Windows.Forms.Button btn_bewaarLink;
        private System.Windows.Forms.Button btn_verwijderLink;
        private System.Windows.Forms.Button btn_nieuweLink;
        private System.Windows.Forms.TextBox txt_hyperlinkInput;
        private System.Windows.Forms.Label lbl_hyperlinkDetail;
        private System.Windows.Forms.Label lbl_linksTitel;
        private System.Windows.Forms.Panel pnl_Links;
        private System.Windows.Forms.TabPage tabPage_Fotos;
        private System.Windows.Forms.Button btn_bewaarFoto;
        private System.Windows.Forms.Button btn_verwijderFoto;
        private System.Windows.Forms.Button btn_nieuweFoto;
        private System.Windows.Forms.Button btn_kiesFoto;
        private System.Windows.Forms.TextBox txt_FotoId;
        private System.Windows.Forms.Label lbl_fotoIdDetail;
        private System.Windows.Forms.TextBox txt_fotoURLInput;
        private System.Windows.Forms.Label lbl_fotoUrlDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_Fotos;
        private System.Windows.Forms.Label lbl_fotosTitel;
        private System.Windows.Forms.TabPage tabPage_Offertes;
        private System.Windows.Forms.Button btn_bewaarOfferte;
        private System.Windows.Forms.Button btn_verwijderOfferte;
        private System.Windows.Forms.Button btn_nieuweOfferte;
        private System.Windows.Forms.Button btn_kiesOfferte;
        private System.Windows.Forms.TextBox txt_offerteId;
        private System.Windows.Forms.Label lbl_offerteIdDetail;
        private System.Windows.Forms.TextBox txt_offerteURLInput;
        private System.Windows.Forms.Label lbl_offerteURLDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_offertesTitel;
        private System.Windows.Forms.Panel pnl_Offertes;
    }
}