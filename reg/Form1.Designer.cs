using System.Drawing;

namespace reg
{
    partial class AuthMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthMenu));
            this.PasswordImput = new Guna.UI2.WinForms.Guna2TextBox();
            this.EntryButton = new Guna.UI2.WinForms.Guna2Button();
            this.ShowPasswodSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.StrelkiPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShowPasswodText = new System.Windows.Forms.Label();
            this.RegButton = new Guna.UI2.WinForms.Guna2Button();
            this.HideMenu = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ExitMenu = new Guna.UI2.WinForms.Guna2ControlBox();
            this.LoginImput = new Guna.UI2.WinForms.Guna2TextBox();
            this.DontAccount = new System.Windows.Forms.Label();
            this.RegLine = new System.Windows.Forms.Label();
            this.DMPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Menu3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.StrelkiPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordImput
            // 
            this.PasswordImput.BorderColor = System.Drawing.Color.White;
            this.PasswordImput.BorderRadius = 15;
            this.PasswordImput.BorderThickness = 3;
            this.PasswordImput.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PasswordImput.DefaultText = "";
            this.PasswordImput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordImput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordImput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordImput.DisabledState.Parent = this.PasswordImput;
            this.PasswordImput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.PasswordImput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PasswordImput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.PasswordImput.FocusedState.Parent = this.PasswordImput;
            this.PasswordImput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PasswordImput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.PasswordImput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.PasswordImput.HoverState.Parent = this.PasswordImput;
            this.PasswordImput.Location = new System.Drawing.Point(19, 357);
            this.PasswordImput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PasswordImput.Name = "PasswordImput";
            this.PasswordImput.PasswordChar = '\0';
            this.PasswordImput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.PasswordImput.PlaceholderText = "ПАРОЛЬ";
            this.PasswordImput.SelectedText = "";
            this.PasswordImput.ShadowDecoration.Parent = this.PasswordImput;
            this.PasswordImput.Size = new System.Drawing.Size(312, 43);
            this.PasswordImput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PasswordImput.TabIndex = 2;
            this.PasswordImput.UseWaitCursor = true;
            this.PasswordImput.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // EntryButton
            // 
            this.EntryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EntryButton.BackgroundImage")));
            this.EntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EntryButton.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EntryButton.BorderRadius = 15;
            this.EntryButton.CheckedState.Parent = this.EntryButton;
            this.EntryButton.CustomImages.Parent = this.EntryButton;
            this.EntryButton.FillColor = System.Drawing.Color.White;
            this.EntryButton.Font = new System.Drawing.Font("Co Headline Corp", 20F, System.Drawing.FontStyle.Bold);
            this.EntryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.EntryButton.HoverState.Parent = this.EntryButton;
            this.EntryButton.Image = ((System.Drawing.Image)(resources.GetObject("EntryButton.Image")));
            this.EntryButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EntryButton.ImageOffset = new System.Drawing.Point(35, -2);
            this.EntryButton.ImageSize = new System.Drawing.Size(50, 50);
            this.EntryButton.Location = new System.Drawing.Point(19, 473);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.ShadowDecoration.Parent = this.EntryButton;
            this.EntryButton.Size = new System.Drawing.Size(312, 49);
            this.EntryButton.TabIndex = 4;
            this.EntryButton.Text = "ВОЙТИ";
            this.EntryButton.UseWaitCursor = true;
            this.EntryButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ShowPasswodSwitch
            // 
            this.ShowPasswodSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPasswodSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPasswodSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ShowPasswodSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ShowPasswodSwitch.CheckedState.Parent = this.ShowPasswodSwitch;
            this.ShowPasswodSwitch.Location = new System.Drawing.Point(30, 428);
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
            this.ShowPasswodSwitch.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged_2);
            // 
            // StrelkiPicture
            // 
            this.StrelkiPicture.BackColor = System.Drawing.Color.Transparent;
            this.StrelkiPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StrelkiPicture.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.StrelkiPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("StrelkiPicture.ErrorImage")));
            this.StrelkiPicture.FillColor = System.Drawing.Color.Transparent;
            this.StrelkiPicture.Image = ((System.Drawing.Image)(resources.GetObject("StrelkiPicture.Image")));
            this.StrelkiPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("StrelkiPicture.InitialImage")));
            this.StrelkiPicture.Location = new System.Drawing.Point(-66, -71);
            this.StrelkiPicture.Name = "StrelkiPicture";
            this.StrelkiPicture.ShadowDecoration.Parent = this.StrelkiPicture;
            this.StrelkiPicture.Size = new System.Drawing.Size(419, 254);
            this.StrelkiPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StrelkiPicture.TabIndex = 8;
            this.StrelkiPicture.TabStop = false;
            this.StrelkiPicture.UseWaitCursor = true;
            this.StrelkiPicture.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // ShowPasswodText
            // 
            this.ShowPasswodText.AutoSize = true;
            this.ShowPasswodText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPasswodText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.ShowPasswodText.Location = new System.Drawing.Point(71, 428);
            this.ShowPasswodText.Name = "ShowPasswodText";
            this.ShowPasswodText.Size = new System.Drawing.Size(141, 20);
            this.ShowPasswodText.TabIndex = 10;
            this.ShowPasswodText.Text = "Показать пароль";
            this.ShowPasswodText.UseWaitCursor = true;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Transparent;
            this.RegButton.BorderColor = System.Drawing.Color.Transparent;
            this.RegButton.BorderRadius = 19;
            this.RegButton.BorderThickness = 1;
            this.RegButton.CheckedState.Parent = this.RegButton;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.RegButton.CustomImages.Parent = this.RegButton;
            this.RegButton.FillColor = System.Drawing.Color.Transparent;
            this.RegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.RegButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.RegButton.HoverState.Parent = this.RegButton;
            this.RegButton.Location = new System.Drawing.Point(45, 561);
            this.RegButton.Name = "RegButton";
            this.RegButton.ShadowDecoration.Parent = this.RegButton;
            this.RegButton.Size = new System.Drawing.Size(260, 41);
            this.RegButton.TabIndex = 11;
            this.RegButton.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.RegButton.UseWaitCursor = true;
            this.RegButton.Click += new System.EventHandler(this.guna2Button2_Click_1);
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
            this.HideMenu.Location = new System.Drawing.Point(294, 12);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.ShadowDecoration.Parent = this.HideMenu;
            this.HideMenu.Size = new System.Drawing.Size(21, 19);
            this.HideMenu.TabIndex = 27;
            this.HideMenu.UseWaitCursor = true;
            this.HideMenu.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitMenu.BackColor = System.Drawing.Color.Transparent;
            this.ExitMenu.FillColor = System.Drawing.Color.Transparent;
            this.ExitMenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(63)))), ((int)(((byte)(53)))));
            this.ExitMenu.HoverState.Parent = this.ExitMenu;
            this.ExitMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.ExitMenu.Location = new System.Drawing.Point(321, 12);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.ShadowDecoration.Parent = this.ExitMenu;
            this.ExitMenu.Size = new System.Drawing.Size(21, 19);
            this.ExitMenu.TabIndex = 26;
            this.ExitMenu.UseWaitCursor = true;
            this.ExitMenu.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // LoginImput
            // 
            this.LoginImput.BackColor = System.Drawing.Color.Transparent;
            this.LoginImput.BorderColor = System.Drawing.Color.White;
            this.LoginImput.BorderRadius = 15;
            this.LoginImput.BorderThickness = 3;
            this.LoginImput.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LoginImput.DefaultText = "";
            this.LoginImput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginImput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginImput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.LoginImput.DisabledState.Parent = this.LoginImput;
            this.LoginImput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.LoginImput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.LoginImput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.LoginImput.FocusedState.Parent = this.LoginImput;
            this.LoginImput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoginImput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.LoginImput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.LoginImput.HoverState.Parent = this.LoginImput;
            this.LoginImput.Location = new System.Drawing.Point(19, 295);
            this.LoginImput.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.LoginImput.Name = "LoginImput";
            this.LoginImput.PasswordChar = '\0';
            this.LoginImput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.LoginImput.PlaceholderText = "ЛОГИН";
            this.LoginImput.SelectedText = "";
            this.LoginImput.ShadowDecoration.Parent = this.LoginImput;
            this.LoginImput.Size = new System.Drawing.Size(312, 44);
            this.LoginImput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.LoginImput.TabIndex = 1;
            this.LoginImput.UseWaitCursor = true;
            this.LoginImput.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // DontAccount
            // 
            this.DontAccount.AutoSize = true;
            this.DontAccount.Font = new System.Drawing.Font("Co Headline Corp", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DontAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.DontAccount.Location = new System.Drawing.Point(100, 538);
            this.DontAccount.Name = "DontAccount";
            this.DontAccount.Size = new System.Drawing.Size(147, 19);
            this.DontAccount.TabIndex = 30;
            this.DontAccount.Text = "НЕТ АККАУНТА?";
            this.DontAccount.UseWaitCursor = true;
            this.DontAccount.Click += new System.EventHandler(this.label5_Click);
            // 
            // RegLine
            // 
            this.RegLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegLine.Location = new System.Drawing.Point(58, 597);
            this.RegLine.Name = "RegLine";
            this.RegLine.Size = new System.Drawing.Size(236, 2);
            this.RegLine.TabIndex = 31;
            this.RegLine.UseWaitCursor = true;
            this.RegLine.Click += new System.EventHandler(this.label6_Click);
            // 
            // DMPicture
            // 
            this.DMPicture.BackColor = System.Drawing.Color.Transparent;
            this.DMPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DMPicture.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DMPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("DMPicture.ErrorImage")));
            this.DMPicture.FillColor = System.Drawing.Color.Transparent;
            this.DMPicture.Image = ((System.Drawing.Image)(resources.GetObject("DMPicture.Image")));
            this.DMPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("DMPicture.InitialImage")));
            this.DMPicture.Location = new System.Drawing.Point(37, 128);
            this.DMPicture.Name = "DMPicture";
            this.DMPicture.ShadowDecoration.Parent = this.DMPicture;
            this.DMPicture.Size = new System.Drawing.Size(268, 161);
            this.DMPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DMPicture.TabIndex = 33;
            this.DMPicture.TabStop = false;
            this.DMPicture.UseTransparentBackground = true;
            this.DMPicture.UseWaitCursor = true;
            this.DMPicture.Click += new System.EventHandler(this.DMPicture_Click);
            // 
            // Menu3
            // 
            this.Menu3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu3.BackgroundImage")));
            this.Menu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Menu3.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Menu3.BorderRadius = 15;
            this.Menu3.CheckedState.Parent = this.Menu3;
            this.Menu3.CustomImages.Parent = this.Menu3;
            this.Menu3.FillColor = System.Drawing.Color.White;
            this.Menu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.Menu3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.Menu3.HoverState.Parent = this.Menu3;
            this.Menu3.Image = ((System.Drawing.Image)(resources.GetObject("Menu3.Image")));
            this.Menu3.ImageSize = new System.Drawing.Size(50, 50);
            this.Menu3.Location = new System.Drawing.Point(191, 281);
            this.Menu3.Name = "Menu3";
            this.Menu3.ShadowDecoration.Parent = this.Menu3;
            this.Menu3.Size = new System.Drawing.Size(140, 49);
            this.Menu3.TabIndex = 34;
            this.Menu3.UseWaitCursor = true;
            this.Menu3.Click += new System.EventHandler(this.Menu3_Click);
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
            this.guna2Button1.Font = new System.Drawing.Font("Co Headline Corp", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(76)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(87, 602);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 25);
            this.guna2Button1.TabIndex = 36;
            this.guna2Button1.Text = "Пользовательское соглашение";
            this.guna2Button1.UseWaitCursor = true;
            // 
            // AuthMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(354, 639);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Menu3);
            this.Controls.Add(this.DMPicture);
            this.Controls.Add(this.RegLine);
            this.Controls.Add(this.DontAccount);
            this.Controls.Add(this.LoginImput);
            this.Controls.Add(this.HideMenu);
            this.Controls.Add(this.ExitMenu);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.ShowPasswodText);
            this.Controls.Add(this.StrelkiPicture);
            this.Controls.Add(this.ShowPasswodSwitch);
            this.Controls.Add(this.EntryButton);
            this.Controls.Add(this.PasswordImput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthMenu";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StrelkiPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox PasswordImput;
        private Guna.UI2.WinForms.Guna2Button EntryButton;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ShowPasswodSwitch;
        private Guna.UI2.WinForms.Guna2PictureBox StrelkiPicture;
        private System.Windows.Forms.Label ShowPasswodText;
        private Guna.UI2.WinForms.Guna2Button RegButton;
        private Guna.UI2.WinForms.Guna2ControlBox HideMenu;
        private Guna.UI2.WinForms.Guna2ControlBox ExitMenu;
        private Guna.UI2.WinForms.Guna2TextBox LoginImput;
        private System.Windows.Forms.Label DontAccount;
        private System.Windows.Forms.Label RegLine;
        private Guna.UI2.WinForms.Guna2PictureBox DMPicture;
        private Guna.UI2.WinForms.Guna2Button Menu3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}