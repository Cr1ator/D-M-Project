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
    public partial class deposit_money : Form
    {
        String query;
        funkreg func = new funkreg();
        public deposit_money()
        {
            InitializeComponent();
            query = $"select Users1.Amount from Users1 where UserID='{AuthMenu.txt1}'";
            DataSet ds = func.getData(query);

            Sumlabel.Text = ds.Tables[0].Rows[0][0].ToString();

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

        private void deposit_money_Load(object sender, EventArgs e)
        {

        }

        private void HideMenu_Click(object sender, EventArgs e)
        {

        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxSlider_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProfileMenu form3 = new ProfileMenu();
            this.Hide();
            form3.Show();
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(CardTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                CardTextBox.Text = CardTextBox.Text.Remove(CardTextBox.Text.Length - 1);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SumTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                SumTextBox.Text = SumTextBox.Text.Remove(SumTextBox.Text.Length - 1);
            }
        }

        private void BynText_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(DateTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                DateTextBox.Text = DateTextBox.Text.Remove(DateTextBox.Text.Length - 1);
            }
        }

        private void guna2TextBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(CVVTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                CVVTextBox.Text = CVVTextBox.Text.Remove(CVVTextBox.Text.Length - 1);
            }
        }

        private void EntryRegButton_Click(object sender, EventArgs e)
        {
            String card = CardTextBox.Text;
            String Date = DatesTextBox.Text;
            String cvv = CVVTextBox.Text;
            String name = NameTextBox.Text;
            int sum = Convert.ToInt32(SumTextBox.Text);
            String message = $"На ваш баланс была зачислина Сумма {sum}";

            //суммы которая сейчас на аккаунте
            query = $"select Users1.Amount from Users1 where UserID='{AuthMenu.txt1}'";
            DataSet sum_amount = func.getData(query);
            int sums = Convert.ToInt32(sum_amount.Tables[0].Rows[0][0].ToString());

            sum = sum + sums;

            string query_sumupdate = $"UPDATE Users1 SET Amount={sum} WHERE UserID={AuthMenu.txt1}";
            string query_savecatd = "insert into DepositCard(userID, number, DateCard, anchorDate, cvv) values ('" + AuthMenu.txt1 + "', '" + card + "', '" + Date + "', '" + DateTime.Now + "', '" + cvv + "')";
            string query_operations = "insert into Operation(userID, Amount, TypeOperation, DateOperation) values ('" + AuthMenu.txt1 + "', '" + sum + "', '" + 1 + "', '" + DateTime.Now + "')";

            if (card != "" && Date != "" && cvv != "" && name != "" && SumTextBox.Text != "")
            {

                func.setDataUpd(query_sumupdate);

                func.setDataUpd(query_savecatd);

                func.setData(query_operations, message);

                ProfileMenu f3 = new ProfileMenu();
                this.Hide();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void deposit_money_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            query = $"select Users1.Confirmed from Users1 where UserID='{AuthMenu.txt1}'";
            DataSet ds = func.getData(query);
            if ((bool)ds.Tables[0].Rows[0][0] == true)
            {
                String card = CardTextBox.Text;
                String Date = DatesTextBox.Text;
                String cvv = CVVTextBox.Text;
                String name = NameTextBox.Text;
                int sum = Convert.ToInt32(SumTextBox.Text);
                String message = $"Средства успешно выведины {sum}";

                //суммы которая сейчас на аккаунте
                query = $"select Users1.Amount from Users1 where UserID='{AuthMenu.txt1}'";
                DataSet sum_amount = func.getData(query);
                int sums = Convert.ToInt32(sum_amount.Tables[0].Rows[0][0].ToString());

                if (sum <= sums)
                {
                    sum = sums - sum;

                    string query_sumupdate = $"UPDATE Users1 SET Amount={sum} WHERE UserID={AuthMenu.txt1}";
                    string query_savecatd = "insert into DepositCard(userID, number, DateCard, anchorDate, cvv) values ('" + AuthMenu.txt1 + "', '" + card + "', '" + Date + "', '" + DateTime.Now + "', '" + cvv + "')";
                    string query_operations = "insert into Operation(userID, Amount, TypeOperation, DateOperation) values ('" + AuthMenu.txt1 + "', '" + sum + "', '" + 2 + "', '" + DateTime.Now + "')";

                    if (card != "" && Date != "" && cvv != "" && name != "" && SumTextBox.Text != "")
                    {

                        func.setDataUpd(query_sumupdate);

                        func.setDataUpd(query_savecatd);

                        func.setData(query_operations, message);

                        ProfileMenu f3 = new ProfileMenu();
                        this.Hide();
                        f3.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Недостаточно средств для вывода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ваш аккаунт не подтверждён! Подтвердите аккаунт чтобы вывести средства", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
