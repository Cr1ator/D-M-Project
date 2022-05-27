namespace reg
{
    partial class MenuVklad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVklad));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.moneyTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.DateTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.EntryRegButton = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LineMenu = new System.Windows.Forms.Label();
            this.HideMenu = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ExitMenu = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.DMText = new System.Windows.Forms.Label();
            this.AccountText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ProcentTextBox = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // moneyTrackBar
            // 
            this.moneyTrackBar.FillColor = System.Drawing.Color.White;
            this.moneyTrackBar.HoverState.Parent = this.moneyTrackBar;
            this.moneyTrackBar.IndicateFocus = false;
            this.moneyTrackBar.LargeChange = 5000;
            this.moneyTrackBar.Location = new System.Drawing.Point(23, 134);
            this.moneyTrackBar.Maximum = 500000;
            this.moneyTrackBar.Minimum = 50000;
            this.moneyTrackBar.MouseWheelBarPartitions = 1;
            this.moneyTrackBar.Name = "moneyTrackBar";
            this.moneyTrackBar.Size = new System.Drawing.Size(311, 23);
            this.moneyTrackBar.SmallChange = 5000;
            this.moneyTrackBar.TabIndex = 0;
            this.moneyTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.moneyTrackBar.UseWaitCursor = true;
            this.moneyTrackBar.Value = 50000;
            this.moneyTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // DateTrackBar
            // 
            this.DateTrackBar.FillColor = System.Drawing.Color.White;
            this.DateTrackBar.HoverState.Parent = this.DateTrackBar;
            this.DateTrackBar.IndicateFocus = false;
            this.DateTrackBar.Location = new System.Drawing.Point(23, 221);
            this.DateTrackBar.Maximum = 24;
            this.DateTrackBar.Minimum = 1;
            this.DateTrackBar.Name = "DateTrackBar";
            this.DateTrackBar.Size = new System.Drawing.Size(311, 23);
            this.DateTrackBar.TabIndex = 1;
            this.DateTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.DateTrackBar.UseWaitCursor = true;
            this.DateTrackBar.Value = 1;
            this.DateTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar2_Scroll);
            // 
            // EntryRegButton
            // 
            this.EntryRegButton.BorderRadius = 15;
            this.EntryRegButton.CheckedState.Parent = this.EntryRegButton;
            this.EntryRegButton.CustomImages.Parent = this.EntryRegButton;
            this.EntryRegButton.FillColor = System.Drawing.Color.White;
            this.EntryRegButton.Font = new System.Drawing.Font("Co Headline Corp", 26.25F);
            this.EntryRegButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.EntryRegButton.HoverState.Parent = this.EntryRegButton;
            this.EntryRegButton.Location = new System.Drawing.Point(23, 542);
            this.EntryRegButton.Name = "EntryRegButton";
            this.EntryRegButton.ShadowDecoration.Parent = this.EntryRegButton;
            this.EntryRegButton.Size = new System.Drawing.Size(311, 54);
            this.EntryRegButton.TabIndex = 74;
            this.EntryRegButton.Text = "Подтвердить";
            this.EntryRegButton.UseWaitCursor = true;
            this.EntryRegButton.Click += new System.EventHandler(this.EntryRegButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Co Headline Corp", 8F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(305, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Мес";
            this.label10.UseMnemonic = false;
            this.label10.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Co Headline Corp", 6F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(148, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 9);
            this.label2.TabIndex = 72;
            this.label2.Text = "BYN";
            this.label2.UseMnemonic = false;
            this.label2.UseWaitCursor = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.White;
            this.DateLabel.Font = new System.Drawing.Font("Co Headline Corp", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.Black;
            this.DateLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DateLabel.Location = new System.Drawing.Point(189, 464);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(29, 36);
            this.DateLabel.TabIndex = 71;
            this.DateLabel.Text = "1";
            this.DateLabel.UseMnemonic = false;
            this.DateLabel.UseWaitCursor = true;
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox5.BorderRadius = 15;
            this.guna2PictureBox5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2PictureBox5.ErrorImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.ErrorImage")));
            this.guna2PictureBox5.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.InitialImage")));
            this.guna2PictureBox5.Location = new System.Drawing.Point(173, 440);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.ShadowDecoration.Parent = this.guna2PictureBox5;
            this.guna2PictureBox5.Size = new System.Drawing.Size(172, 86);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox5.TabIndex = 70;
            this.guna2PictureBox5.TabStop = false;
            this.guna2PictureBox5.UseTransparentBackground = true;
            this.guna2PictureBox5.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Co Headline Corp", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Location = new System.Drawing.Point(181, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 18);
            this.label14.TabIndex = 69;
            this.label14.Text = "Срок";
            this.label14.UseMnemonic = false;
            this.label14.UseWaitCursor = true;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.BackColor = System.Drawing.Color.White;
            this.SumLabel.Font = new System.Drawing.Font("Co Headline Corp", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumLabel.ForeColor = System.Drawing.Color.Black;
            this.SumLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SumLabel.Location = new System.Drawing.Point(23, 464);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(65, 36);
            this.SumLabel.TabIndex = 68;
            this.SumLabel.Text = "0,0";
            this.SumLabel.UseMnemonic = false;
            this.SumLabel.UseWaitCursor = true;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox4.BorderRadius = 15;
            this.guna2PictureBox4.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2PictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.ErrorImage")));
            this.guna2PictureBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.InitialImage")));
            this.guna2PictureBox4.Location = new System.Drawing.Point(9, 440);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.ShadowDecoration.Parent = this.guna2PictureBox4;
            this.guna2PictureBox4.Size = new System.Drawing.Size(172, 86);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 67;
            this.guna2PictureBox4.TabStop = false;
            this.guna2PictureBox4.UseTransparentBackground = true;
            this.guna2PictureBox4.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Co Headline Corp", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(17, 423);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 18);
            this.label11.TabIndex = 66;
            this.label11.Text = "Сумма вклада:";
            this.label11.UseMnemonic = false;
            this.label11.UseWaitCursor = true;
            // 
            // LineMenu
            // 
            this.LineMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LineMenu.Location = new System.Drawing.Point(-16, 411);
            this.LineMenu.Name = "LineMenu";
            this.LineMenu.Size = new System.Drawing.Size(395, 2);
            this.LineMenu.TabIndex = 75;
            this.LineMenu.UseWaitCursor = true;
            // 
            // HideMenu
            // 
            this.HideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideMenu.BackColor = System.Drawing.Color.Transparent;
            this.HideMenu.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.HideMenu.FillColor = System.Drawing.Color.Transparent;
            this.HideMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(155)))), ((int)(((byte)(15)))));
            this.HideMenu.HoverState.Parent = this.HideMenu;
            this.HideMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.HideMenu.Location = new System.Drawing.Point(295, 12);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.ShadowDecoration.Parent = this.HideMenu;
            this.HideMenu.Size = new System.Drawing.Size(21, 19);
            this.HideMenu.TabIndex = 79;
            this.HideMenu.UseWaitCursor = true;
            // 
            // ExitMenu
            // 
            this.ExitMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitMenu.BackColor = System.Drawing.Color.Transparent;
            this.ExitMenu.FillColor = System.Drawing.Color.Transparent;
            this.ExitMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(63)))), ((int)(((byte)(53)))));
            this.ExitMenu.HoverState.Parent = this.ExitMenu;
            this.ExitMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.ExitMenu.Location = new System.Drawing.Point(322, 12);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.ShadowDecoration.Parent = this.ExitMenu;
            this.ExitMenu.Size = new System.Drawing.Size(21, 19);
            this.ExitMenu.TabIndex = 78;
            this.ExitMenu.UseWaitCursor = true;
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.White;
            this.BackButton.BorderRadius = 15;
            this.BackButton.CheckedState.Parent = this.BackButton;
            this.BackButton.CustomImages.Parent = this.BackButton;
            this.BackButton.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.Font = new System.Drawing.Font("Co Headline Corp", 28.25F);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.BackButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.HoverState.Parent = this.BackButton;
            this.BackButton.Location = new System.Drawing.Point(-11, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.ShadowDecoration.Parent = this.BackButton;
            this.BackButton.Size = new System.Drawing.Size(75, 41);
            this.BackButton.TabIndex = 77;
            this.BackButton.Text = "<";
            this.BackButton.UseWaitCursor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DMText
            // 
            this.DMText.AutoSize = true;
            this.DMText.Font = new System.Drawing.Font("Co Headline Corp", 22.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DMText.ForeColor = System.Drawing.Color.White;
            this.DMText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DMText.Location = new System.Drawing.Point(126, 9);
            this.DMText.Name = "DMText";
            this.DMText.Size = new System.Drawing.Size(90, 37);
            this.DMText.TabIndex = 76;
            this.DMText.Text = "D&M";
            this.DMText.UseMnemonic = false;
            this.DMText.UseWaitCursor = true;
            // 
            // AccountText
            // 
            this.AccountText.AutoSize = true;
            this.AccountText.Font = new System.Drawing.Font("Co Headline Corp", 16.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountText.ForeColor = System.Drawing.Color.White;
            this.AccountText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AccountText.Location = new System.Drawing.Point(15, 65);
            this.AccountText.Name = "AccountText";
            this.AccountText.Size = new System.Drawing.Size(199, 28);
            this.AccountText.TabIndex = 80;
            this.AccountText.Text = "Онлайн вклады";
            this.AccountText.UseMnemonic = false;
            this.AccountText.UseWaitCursor = true;
            this.AccountText.Click += new System.EventHandler(this.AccountText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "СУММА ВКЛАДА";
            this.label3.UseMnemonic = false;
            this.label3.UseWaitCursor = true;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(20, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "СРОК ВКЛАДА";
            this.label1.UseMnemonic = false;
            this.label1.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "50000";
            this.label4.UseMnemonic = false;
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(273, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "500000";
            this.label5.UseMnemonic = false;
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(20, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 85;
            this.label6.Text = "1 МЕС";
            this.label6.UseMnemonic = false;
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(274, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 86;
            this.label7.Text = "24 МЕС";
            this.label7.UseMnemonic = false;
            this.label7.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(17, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "ЭФФЕКТИВНАЯ СТАВКА";
            this.label8.UseMnemonic = false;
            this.label8.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Co Headline Corp", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Location = new System.Drawing.Point(28, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 92;
            this.label13.Text = "Ставка:";
            this.label13.UseMnemonic = false;
            this.label13.UseWaitCursor = true;
            // 
            // ProcentTextBox
            // 
            this.ProcentTextBox.AutoSize = true;
            this.ProcentTextBox.BackColor = System.Drawing.Color.White;
            this.ProcentTextBox.Font = new System.Drawing.Font("Co Headline Corp", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcentTextBox.ForeColor = System.Drawing.Color.Black;
            this.ProcentTextBox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ProcentTextBox.Location = new System.Drawing.Point(24, 335);
            this.ProcentTextBox.Name = "ProcentTextBox";
            this.ProcentTextBox.Size = new System.Drawing.Size(96, 36);
            this.ProcentTextBox.TabIndex = 91;
            this.ProcentTextBox.Text = "0,0%";
            this.ProcentTextBox.UseMnemonic = false;
            this.ProcentTextBox.UseWaitCursor = true;
            this.ProcentTextBox.Click += new System.EventHandler(this.ProcentTextBox_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label16.Location = new System.Drawing.Point(294, 358);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 17);
            this.label16.TabIndex = 90;
            this.label16.Text = "BYN";
            this.label16.UseMnemonic = false;
            this.label16.UseWaitCursor = true;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox3.BorderRadius = 15;
            this.guna2PictureBox3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2PictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.ErrorImage")));
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.InitialImage")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(9, 306);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(336, 98);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 89;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            this.guna2PictureBox3.UseWaitCursor = true;
            this.guna2PictureBox3.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // MenuVklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(354, 639);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ProcentTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AccountText);
            this.Controls.Add(this.HideMenu);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.DMText);
            this.Controls.Add(this.LineMenu);
            this.Controls.Add(this.EntryRegButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.guna2PictureBox5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SumLabel);
            this.Controls.Add(this.guna2PictureBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DateTrackBar);
            this.Controls.Add(this.moneyTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuVklad";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TrackBar DateTrackBar;
        private Guna.UI2.WinForms.Guna2TrackBar moneyTrackBar;
        private Guna.UI2.WinForms.Guna2Button EntryRegButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateLabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label SumLabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LineMenu;
        private Guna.UI2.WinForms.Guna2ControlBox HideMenu;
        private Guna.UI2.WinForms.Guna2ControlBox ExitMenu;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private System.Windows.Forms.Label DMText;
        private System.Windows.Forms.Label AccountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ProcentTextBox;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
    }
}