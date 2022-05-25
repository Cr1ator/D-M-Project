using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reg
{
    public partial class AuthMenu : Form
    {
        public static string txt1 = "";
        String query;
        funkreg func = new funkreg();
        public AuthMenu()
        {
            InitializeComponent();

            PasswordImput.UseSystemPasswordChar = true;

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

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswodSwitch.Checked)
            {
                PasswordImput.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordImput.UseSystemPasswordChar = true;
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = $"select Users1.userID, Users1.userlogin, Users1.userpassword from Users1 where userlogin='{LoginImput.Text}'";
            DataSet ds = func.getData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (PasswordImput.Text != "" || LoginImput.Text != "")
                {
                    string log = ds.Tables[0].Rows[0][1].ToString();
                    string pass = ds.Tables[0].Rows[0][2].ToString();
                    if (log == LoginImput.Text && pass == PasswordImput.Text)
                    {
                        txt1 = ds.Tables[0].Rows[0][0].ToString();
                        ProfileMenu f3 = new ProfileMenu();
                        this.Hide(); 
                        f3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Пользователя не существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthMenu f1 = new AuthMenu();
            f1.ShowDialog();
        }

        private void guna2ToggleSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowPasswodSwitch.Checked)
            {
                PasswordImput.UseSystemPasswordChar = false;

            }
            else
            {
                PasswordImput.UseSystemPasswordChar = true;

            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            RegMenu form2 = new RegMenu();
            this.Hide();
            form2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (ShowPasswodSwitch.Checked)
            {
                PasswordImput.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordImput.UseSystemPasswordChar = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu3_Click(object sender, EventArgs e)
        {
            ProfileMenu form3 = new ProfileMenu();
            this.Hide();
            form3.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            InvestMenu form4 = new InvestMenu();
            this.Hide();
            form4.Show();
        }

        private void DMPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
