﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reg
{
    public partial class RegMenu : Form
    {
        String query;
        funkreg func = new funkreg();
        public RegMenu()
        {
            InitializeComponent();
            PasswordInput.UseSystemPasswordChar = true;
            repeatPasswordInput.UseSystemPasswordChar = true;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                base.WndProc(ref m);
                if ((int)m.Result == 0x1)
                    m.Result = (IntPtr)0x2;
                return;
            }

            base.WndProc(ref m);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Создание объекта для генерации чисел
                Random rnd = new Random();
                String query2 = "select * from Users1";
                if (NameInput.Text != "" && LastNameInput.Text != "" && LoginImput.Text != "" && EmailInput.Text != "" && PasswordInput.Text != "" && repeatPasswordInput.Text != "")
                {
                    var email_check = new EmailAddressAttribute();
                    String name = NameInput.Text;
                    String lastname = LastNameInput.Text;
                    String login = LoginImput.Text.ToLower();
                    String email = EmailInput.Text;
                    String password = PasswordInput.Text;
                    int userid = rnd.Next(10000, 99999);
                    String message = "Вы успешно зарегистрировались!";
                    if (PasswordInput.Text == repeatPasswordInput.Text)
                    {
                        if (func.getUserInfo(query2).Item1 == login)
                        {
                            MessageBox.Show("Пользователь с данным логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (email_check.IsValid(email))
                            {
                                AuthMenu.txt1 = userid.ToString();
                                query = "insert into Users1(userID, username, usersurname, userlogin, useremail, userpassword) values ('" + userid + "', '" + name + "', '" + lastname + "', '" + login + "', '" + email + "', '" + password + "')";
                                func.setData(query, message);
                                ProfileMenu f3 = new ProfileMenu();
                                this.Hide();
                                f3.Show();
                            }
                            else
                            {
                                MessageBox.Show("Неверный email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                    MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Проверьте заполненные поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswodSwitch.Checked)
            {
                PasswordInput.UseSystemPasswordChar = false;
                repeatPasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = true;
                repeatPasswordInput.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RegMenu form2 = new RegMenu();
            this.Hide();
            form2.Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            AuthMenu form1 = new AuthMenu();
            this.Hide();
            form1.Show();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowPasswodSwitch.Checked)
            {
                PasswordInput.UseSystemPasswordChar = false;
                repeatPasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = true;
                repeatPasswordInput.UseSystemPasswordChar = true;
            }
        }

        private void guna2ControlBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegMenu_Load(object sender, EventArgs e)
        {

        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Запускаем нужный файл
                System.Diagnostics.Process.Start("ПОЛЬЗОВАТЕЛЬСКОЕ СОГЛАШЕНИЕ.docx");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
