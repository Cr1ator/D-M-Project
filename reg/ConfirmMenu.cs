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
    public partial class ConfirmMenu : Form
    {
        String query;
        funkreg func = new funkreg();
        public ConfirmMenu()
        {
            InitializeComponent();
            try
            {
                query = $"select Users1.Confirmed from Users1 where UserID='{AuthMenu.txt1}'";
                DataSet ds = func.getData(query);
                //bool Confirm = (bool)ds.Tables[0].Rows[0][0];
                if ((bool)ds.Tables[0].Rows[0][0] == true)
                {
                    DangerTextBox.Hide();
                    TrueTextBox.Show();
                }
                else
                {
                    TrueTextBox.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Проверьте заполненные поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void ConfirmMenu_Load(object sender, EventArgs e)
        {

        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProfileMenu form3 = new ProfileMenu();
            this.Hide();
            form3.Show();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(guna2TextBox1.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Вводите толька числа");
            //    guna2TextBox1.Text = guna2TextBox1.Text.Remove(guna2TextBox1.Text.Length - 1);
            //}
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(INFCTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                INFCTextBox.Text = INFCTextBox.Text.Remove(INFCTextBox.Text.Length - 1);
            }
        }

        private void EntryRegButton_Click(object sender, EventArgs e)
        {
            try
            {
                //query = $"select Users1.numberPassport, Users1.INFC from Users1 where userID='{AuthMenu.txt1}'";
                //DataSet ds = func.getData(query);
                //if (ds.Tables[0].Rows.Count != 0)
                //{
                if (NumberPassportTextBox.Text != "" || INFCTextBox.Text != "")
                {
                    string message = "Вы подтвердили свой аккаунт";
                    string NumbPass = NumberPassportTextBox.Text;
                    string INFC = INFCTextBox.Text;
                    string DataBirth = DateBithdayTimePicker.Text;

                    //query = "insert into Users1(numberPassport, INFC, DataOfBirthday) values ('" + NumbPass + "', '" + INFC + "', '" + DataBirth + "')";
                    //query = "UPDATE Users1(numberPassport, INFC, DataOfBirthday) VALUES (@NumbPass, @INFC, @DataBirth) WHERE UserID='" + AuthMenu.txt1 + "'";
                    DangerTextBox.Hide();
                    TrueTextBox.Show();
                    query = $"UPDATE Users1 SET numberPassport={NumbPass}, INFC={INFC} , DataOfBirthday='{DataBirth}', Confirmed=1 WHERE UserID={AuthMenu.txt1}";
                    func.setData(query, message);
                    //MessageBox.Show("Ваш аккаунт подтверждён", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //ProfileMenu f3 = new ProfileMenu();
                    //this.Hide();
                    //f3.Show();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //}
                //else
                //{
                //    MessageBox.Show("Не придвиденная ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch
            {
                MessageBox.Show("Проверьте заполненные поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfirmMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void TrueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
