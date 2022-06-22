namespace reg
{
    partial class RegMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegMenu));
            this.DMText = new System.Windows.Forms.Label();
            this.NameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.repeatPasswordInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.EntryRegButton = new Guna.UI2.WinForms.Guna2Button();
            this.ShowPasswodSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ShowPasswodText = new System.Windows.Forms.Label();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.HideMenu = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ExitMenu = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LastNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginImput = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // DMText
            // 
            this.DMText.AutoSize = true;
            this.DMText.Font = new System.Drawing.Font("Co Headline Corp", 69F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DMText.ForeColor = System.Drawing.Color.White;
            this.DMText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DMText.Location = new System.Drawing.Point(50, 34);
            this.DMText.Name = "DMText";
            this.DMText.Size = new System.Drawing.Size(265, 110);
            this.DMText.TabIndex = 0;
            this.DMText.Text = "D&M";
            this.DMText.UseMnemonic = false;
            this.DMText.UseWaitCursor = true;
            this.DMText.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameInput
            // 
            this.NameInput.BorderColor = System.Drawing.Color.White;
            this.NameInput.BorderRadius = 15;
            this.NameInput.BorderThickness = 3;
            this.NameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameInput.DefaultText = "";
            this.NameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameInput.DisabledState.Parent = this.NameInput;
            this.NameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.NameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.NameInput.FocusedState.Parent = this.NameInput;
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.NameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.NameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.NameInput.HoverState.Parent = this.NameInput;
            this.NameInput.IconLeft = ((System.Drawing.Image)(resources.GetObject("NameInput.IconLeft")));
            this.NameInput.IconLeftSize = new System.Drawing.Size(25, 25);
            this.NameInput.Location = new System.Drawing.Point(27, 151);
            this.NameInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.NameInput.Name = "NameInput";
            this.NameInput.PasswordChar = '\0';
            this.NameInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.NameInput.PlaceholderText = "Имя";
            this.NameInput.SelectedText = "";
            this.NameInput.ShadowDecoration.Parent = this.NameInput;
            this.NameInput.Size = new System.Drawing.Size(139, 52);
            this.NameInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.NameInput.TabIndex = 1;
            this.NameInput.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.BorderColor = System.Drawing.Color.White;
            this.PasswordInput.BorderRadius = 15;
            this.PasswordInput.BorderThickness = 3;
            this.PasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordInput.DefaultText = "";
            this.PasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordInput.DisabledState.Parent = this.PasswordInput;
            this.PasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.PasswordInput.FocusedState.Parent = this.PasswordInput;
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.PasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.PasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.PasswordInput.HoverState.Parent = this.PasswordInput;
            this.PasswordInput.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasswordInput.IconLeft")));
            this.PasswordInput.IconLeftSize = new System.Drawing.Size(25, 25);
            this.PasswordInput.Location = new System.Drawing.Point(26, 374);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '\0';
            this.PasswordInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PasswordInput.PlaceholderText = "Пароль";
            this.PasswordInput.SelectedText = "";
            this.PasswordInput.ShadowDecoration.Parent = this.PasswordInput;
            this.PasswordInput.Size = new System.Drawing.Size(308, 52);
            this.PasswordInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // repeatPasswordInput
            // 
            this.repeatPasswordInput.BorderColor = System.Drawing.Color.White;
            this.repeatPasswordInput.BorderRadius = 15;
            this.repeatPasswordInput.BorderThickness = 3;
            this.repeatPasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repeatPasswordInput.DefaultText = "";
            this.repeatPasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.repeatPasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.repeatPasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repeatPasswordInput.DisabledState.Parent = this.repeatPasswordInput;
            this.repeatPasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repeatPasswordInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.repeatPasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.repeatPasswordInput.FocusedState.Parent = this.repeatPasswordInput;
            this.repeatPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.repeatPasswordInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.repeatPasswordInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.repeatPasswordInput.HoverState.Parent = this.repeatPasswordInput;
            this.repeatPasswordInput.IconLeft = ((System.Drawing.Image)(resources.GetObject("repeatPasswordInput.IconLeft")));
            this.repeatPasswordInput.IconLeftSize = new System.Drawing.Size(25, 25);
            this.repeatPasswordInput.IconRightSize = new System.Drawing.Size(25, 25);
            this.repeatPasswordInput.Location = new System.Drawing.Point(26, 453);
            this.repeatPasswordInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.repeatPasswordInput.Name = "repeatPasswordInput";
            this.repeatPasswordInput.PasswordChar = '\0';
            this.repeatPasswordInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.repeatPasswordInput.PlaceholderText = "Повторите пароль";
            this.repeatPasswordInput.SelectedText = "";
            this.repeatPasswordInput.ShadowDecoration.Parent = this.repeatPasswordInput;
            this.repeatPasswordInput.Size = new System.Drawing.Size(308, 52);
            this.repeatPasswordInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.repeatPasswordInput.TabIndex = 3;
            this.repeatPasswordInput.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // EntryRegButton
            // 
            this.EntryRegButton.Animated = true;
            this.EntryRegButton.BorderRadius = 15;
            this.EntryRegButton.CheckedState.Parent = this.EntryRegButton;
            this.EntryRegButton.CustomImages.Parent = this.EntryRegButton;
            this.EntryRegButton.FillColor = System.Drawing.Color.White;
            this.EntryRegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.EntryRegButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.EntryRegButton.HoverState.Parent = this.EntryRegButton;
            this.EntryRegButton.Location = new System.Drawing.Point(22, 547);
            this.EntryRegButton.Name = "EntryRegButton";
            this.EntryRegButton.ShadowDecoration.Parent = this.EntryRegButton;
            this.EntryRegButton.Size = new System.Drawing.Size(312, 48);
            this.EntryRegButton.TabIndex = 4;
            this.EntryRegButton.Text = "Вход";
            this.EntryRegButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ShowPasswodSwitch
            // 
            this.ShowPasswodSwitch.Animated = true;
            this.ShowPasswodSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.ShowPasswodSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.ShowPasswodSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ShowPasswodSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ShowPasswodSwitch.CheckedState.Parent = this.ShowPasswodSwitch;
            this.ShowPasswodSwitch.Location = new System.Drawing.Point(24, 521);
            this.ShowPasswodSwitch.Name = "ShowPasswodSwitch";
            this.ShowPasswodSwitch.ShadowDecoration.Parent = this.ShowPasswodSwitch;
            this.ShowPasswodSwitch.Size = new System.Drawing.Size(35, 20);
            this.ShowPasswodSwitch.TabIndex = 5;
            this.ShowPasswodSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.ShowPasswodSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.ShowPasswodSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(247)))), ((int)(((byte)(135)))));
            this.ShowPasswodSwitch.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(247)))), ((int)(((byte)(135)))));
            this.ShowPasswodSwitch.UncheckedState.Parent = this.ShowPasswodSwitch;
            this.ShowPasswodSwitch.UseWaitCursor = true;
            this.ShowPasswodSwitch.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged_1);
            // 
            // ShowPasswodText
            // 
            this.ShowPasswodText.AutoSize = true;
            this.ShowPasswodText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPasswodText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.ShowPasswodText.Location = new System.Drawing.Point(64, 521);
            this.ShowPasswodText.Name = "ShowPasswodText";
            this.ShowPasswodText.Size = new System.Drawing.Size(141, 20);
            this.ShowPasswodText.TabIndex = 6;
            this.ShowPasswodText.Text = "Показать пароль";
            this.ShowPasswodText.Click += new System.EventHandler(this.label2_Click);
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.White;
            this.BackButton.BorderRadius = 15;
            this.BackButton.CheckedState.Parent = this.BackButton;
            this.BackButton.CustomImages.Parent = this.BackButton;
            this.BackButton.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.BackButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BackButton.HoverState.Parent = this.BackButton;
            this.BackButton.Location = new System.Drawing.Point(-13, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.ShadowDecoration.Parent = this.BackButton;
            this.BackButton.Size = new System.Drawing.Size(75, 41);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "<";
            this.BackButton.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // HideMenu
            // 
            this.HideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideMenu.Animated = true;
            this.HideMenu.BackColor = System.Drawing.Color.Transparent;
            this.HideMenu.BorderRadius = 3;
            this.HideMenu.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.HideMenu.FillColor = System.Drawing.Color.Transparent;
            this.HideMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.HideMenu.HoverState.Parent = this.HideMenu;
            this.HideMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.HideMenu.Location = new System.Drawing.Point(294, 12);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.ShadowDecoration.Parent = this.HideMenu;
            this.HideMenu.Size = new System.Drawing.Size(21, 19);
            this.HideMenu.TabIndex = 41;
            this.HideMenu.UseWaitCursor = true;
            this.HideMenu.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitMenu.Animated = true;
            this.ExitMenu.BackColor = System.Drawing.Color.Transparent;
            this.ExitMenu.BorderRadius = 3;
            this.ExitMenu.FillColor = System.Drawing.Color.Transparent;
            this.ExitMenu.HoverState.FillColor = System.Drawing.Color.Red;
            this.ExitMenu.HoverState.Parent = this.ExitMenu;
            this.ExitMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.ExitMenu.Location = new System.Drawing.Point(321, 12);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.ShadowDecoration.Parent = this.ExitMenu;
            this.ExitMenu.Size = new System.Drawing.Size(21, 19);
            this.ExitMenu.TabIndex = 26;
            this.ExitMenu.UseWaitCursor = true;
            this.ExitMenu.Click += new System.EventHandler(this.guna2ControlBox2_Click_1);
            // 
            // LastNameInput
            // 
            this.LastNameInput.BorderColor = System.Drawing.Color.White;
            this.LastNameInput.BorderRadius = 15;
            this.LastNameInput.BorderThickness = 3;
            this.LastNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNameInput.DefaultText = "";
            this.LastNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNameInput.DisabledState.Parent = this.LastNameInput;
            this.LastNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNameInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LastNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.LastNameInput.FocusedState.Parent = this.LastNameInput;
            this.LastNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LastNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.LastNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.LastNameInput.HoverState.Parent = this.LastNameInput;
            this.LastNameInput.IconLeft = ((System.Drawing.Image)(resources.GetObject("LastNameInput.IconLeft")));
            this.LastNameInput.IconLeftSize = new System.Drawing.Size(25, 25);
            this.LastNameInput.Location = new System.Drawing.Point(195, 151);
            this.LastNameInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.PasswordChar = '\0';
            this.LastNameInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LastNameInput.PlaceholderText = "Фамилия";
            this.LastNameInput.SelectedText = "";
            this.LastNameInput.ShadowDecoration.Parent = this.LastNameInput;
            this.LastNameInput.Size = new System.Drawing.Size(139, 52);
            this.LastNameInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.LastNameInput.TabIndex = 33;
            this.LastNameInput.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // LoginImput
            // 
            this.LoginImput.BorderColor = System.Drawing.Color.White;
            this.LoginImput.BorderRadius = 15;
            this.LoginImput.BorderThickness = 3;
            this.LoginImput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginImput.DefaultText = "";
            this.LoginImput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginImput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginImput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginImput.DisabledState.Parent = this.LoginImput;
            this.LoginImput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginImput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LoginImput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.LoginImput.FocusedState.Parent = this.LoginImput;
            this.LoginImput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.LoginImput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.LoginImput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.LoginImput.HoverState.Parent = this.LoginImput;
            this.LoginImput.IconLeft = ((System.Drawing.Image)(resources.GetObject("LoginImput.IconLeft")));
            this.LoginImput.IconLeftSize = new System.Drawing.Size(25, 25);
            this.LoginImput.Location = new System.Drawing.Point(26, 227);
            this.LoginImput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LoginImput.Name = "LoginImput";
            this.LoginImput.PasswordChar = '\0';
            this.LoginImput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LoginImput.PlaceholderText = "Логин";
            this.LoginImput.SelectedText = "";
            this.LoginImput.ShadowDecoration.Parent = this.LoginImput;
            this.LoginImput.Size = new System.Drawing.Size(308, 52);
            this.LoginImput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.LoginImput.TabIndex = 35;
            // 
            // EmailInput
            // 
            this.EmailInput.BorderColor = System.Drawing.Color.White;
            this.EmailInput.BorderRadius = 15;
            this.EmailInput.BorderThickness = 3;
            this.EmailInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailInput.DefaultText = "";
            this.EmailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailInput.DisabledState.Parent = this.EmailInput;
            this.EmailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.EmailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.EmailInput.FocusedState.Parent = this.EmailInput;
            this.EmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.EmailInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(136)))));
            this.EmailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.EmailInput.HoverState.Parent = this.EmailInput;
            this.EmailInput.IconLeft = ((System.Drawing.Image)(resources.GetObject("EmailInput.IconLeft")));
            this.EmailInput.IconLeftSize = new System.Drawing.Size(25, 25);
            this.EmailInput.Location = new System.Drawing.Point(27, 308);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.PasswordChar = '\0';
            this.EmailInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.EmailInput.PlaceholderText = "Почта";
            this.EmailInput.SelectedText = "";
            this.EmailInput.ShadowDecoration.Parent = this.EmailInput;
            this.EmailInput.Size = new System.Drawing.Size(307, 52);
            this.EmailInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.EmailInput.TabIndex = 37;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(83, 602);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 25);
            this.guna2Button1.TabIndex = 38;
            this.guna2Button1.Text = "Пользовательское соглашение";
            this.guna2Button1.UseWaitCursor = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // RegMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(354, 639);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.LoginImput);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.HideMenu);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ShowPasswodText);
            this.Controls.Add(this.ShowPasswodSwitch);
            this.Controls.Add(this.EntryRegButton);
            this.Controls.Add(this.repeatPasswordInput);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.DMText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegMenu";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DMText;
        private Guna.UI2.WinForms.Guna2TextBox NameInput;
        private Guna.UI2.WinForms.Guna2TextBox PasswordInput;
        private Guna.UI2.WinForms.Guna2TextBox repeatPasswordInput;
        private Guna.UI2.WinForms.Guna2Button EntryRegButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ShowPasswodSwitch;
        private System.Windows.Forms.Label ShowPasswodText;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Guna.UI2.WinForms.Guna2ControlBox HideMenu;
        private Guna.UI2.WinForms.Guna2ControlBox ExitMenu;
        private Guna.UI2.WinForms.Guna2TextBox LastNameInput;
        private Guna.UI2.WinForms.Guna2TextBox EmailInput;
        private Guna.UI2.WinForms.Guna2TextBox LoginImput;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}