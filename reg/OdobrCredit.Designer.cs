namespace reg
{
    partial class OdobrCredit
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
            this.HideMenu = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ExitMenu = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BackButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SumText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.EntryRegButton = new Guna.UI2.WinForms.Guna2Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
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
            this.HideMenu.Location = new System.Drawing.Point(278, 12);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.ShadowDecoration.Parent = this.HideMenu;
            this.HideMenu.Size = new System.Drawing.Size(21, 19);
            this.HideMenu.TabIndex = 69;
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
            this.ExitMenu.Location = new System.Drawing.Point(305, 12);
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.ShadowDecoration.Parent = this.ExitMenu;
            this.ExitMenu.Size = new System.Drawing.Size(21, 19);
            this.ExitMenu.TabIndex = 68;
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
            this.BackButton.Location = new System.Drawing.Point(-12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.ShadowDecoration.Parent = this.BackButton;
            this.BackButton.Size = new System.Drawing.Size(75, 41);
            this.BackButton.TabIndex = 70;
            this.BackButton.Text = "<";
            this.BackButton.UseWaitCursor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Co Headline Corp", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 28);
            this.label1.TabIndex = 71;
            this.label1.Text = "Одобрение кредита";
            // 
            // SumText
            // 
            this.SumText.AutoSize = true;
            this.SumText.Font = new System.Drawing.Font("Co Headline Corp", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumText.ForeColor = System.Drawing.Color.Gray;
            this.SumText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SumText.Location = new System.Drawing.Point(14, 103);
            this.SumText.Name = "SumText";
            this.SumText.Size = new System.Drawing.Size(286, 30);
            this.SumText.TabIndex = 72;
            this.SumText.Text = "Для одобрения кредита необходимо ввести \r\nзаработную плату ";
            this.SumText.UseMnemonic = false;
            this.SumText.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(285, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "BYN";
            this.label5.UseMnemonic = false;
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Co Headline Corp", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(8, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Введите сумму:";
            this.label4.UseMnemonic = false;
            this.label4.UseWaitCursor = true;
            // 
            // EmailInput
            // 
            this.EmailInput.BorderColor = System.Drawing.Color.White;
            this.EmailInput.BorderRadius = 10;
            this.EmailInput.BorderThickness = 3;
            this.EmailInput.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.EmailInput.DefaultText = "";
            this.EmailInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailInput.DisabledState.Parent = this.EmailInput;
            this.EmailInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.EmailInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.EmailInput.FocusedState.Parent = this.EmailInput;
            this.EmailInput.Font = new System.Drawing.Font("Co Headline Corp", 15.75F);
            this.EmailInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.EmailInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(237)))), ((int)(((byte)(135)))));
            this.EmailInput.HoverState.Parent = this.EmailInput;
            this.EmailInput.Location = new System.Drawing.Point(14, 193);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.PasswordChar = '\0';
            this.EmailInput.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.EmailInput.PlaceholderText = "0,0";
            this.EmailInput.SelectedText = "";
            this.EmailInput.ShadowDecoration.Parent = this.EmailInput;
            this.EmailInput.Size = new System.Drawing.Size(314, 52);
            this.EmailInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.EmailInput.TabIndex = 74;
            this.EmailInput.UseWaitCursor = true;
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
            this.EntryRegButton.Location = new System.Drawing.Point(8, 518);
            this.EntryRegButton.Name = "EntryRegButton";
            this.EntryRegButton.ShadowDecoration.Parent = this.EntryRegButton;
            this.EntryRegButton.Size = new System.Drawing.Size(314, 54);
            this.EntryRegButton.TabIndex = 76;
            this.EntryRegButton.Text = "Подтвердить";
            this.EntryRegButton.UseWaitCursor = true;
            this.EntryRegButton.Click += new System.EventHandler(this.EntryRegButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Co Headline Corp", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(17, 278);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 200);
            this.richTextBox1.TabIndex = 77;
            this.richTextBox1.Text = "";
            // 
            // OdobrCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(338, 600);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.EntryRegButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.SumText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.HideMenu);
            this.Controls.Add(this.ExitMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OdobrCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OdobrCredit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox HideMenu;
        private Guna.UI2.WinForms.Guna2ControlBox ExitMenu;
        private Guna.UI2.WinForms.Guna2Button BackButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SumText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox EmailInput;
        private Guna.UI2.WinForms.Guna2Button EntryRegButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}