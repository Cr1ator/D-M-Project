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
    public partial class MenuVklad : Form
    {
        funkreg func = new funkreg();
        public MenuVklad()
        {
            InitializeComponent();
            ProcentTextBox.Text = "14";
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

        private void MenuVklad_Load(object sender, EventArgs e)
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

        private void AccountText_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //MessageBox.Show(moneyTrackBar.Value.ToString());
            SumLabel.Text = moneyTrackBar.Value.ToString();
            if (Convert.ToInt32(moneyTrackBar.Value.ToString()) <= 100000)
            {
                DateTrackBar.Value = 8;
                ProcentTextBox.Text = "14";
                DateLabel.Text = "8";
            }
            else
            {
                if (Convert.ToInt32(moneyTrackBar.Value.ToString()) > 100000 && Convert.ToInt32(moneyTrackBar.Value.ToString()) <= 300000)
                {
                    DateTrackBar.Value = 16;
                    ProcentTextBox.Text = "20";
                    DateLabel.Text = "16";
                }
                else
                {
                    DateTrackBar.Value = 24;
                    ProcentTextBox.Text = "24";
                    DateLabel.Text = "24";
                }
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            DateLabel.Text = DateTrackBar.Value.ToString();
            if (DateTrackBar.Value <= 8)
            {
                moneyTrackBar.Value = 100000;
                SumLabel.Text = "100000";
                ProcentTextBox.Text = "14";
            }
            else
            {
                if (DateTrackBar.Value >= 9 && DateTrackBar.Value <= 19)
                {
                    moneyTrackBar.Value = 300000;
                    SumLabel.Text = "300000";
                    ProcentTextBox.Text = "20";
                }
                else
                {
                    if (DateTrackBar.Value >= 20)
                    {
                        moneyTrackBar.Value = 500000;
                        SumLabel.Text = "500000";
                        ProcentTextBox.Text = "24";
                    }
                }
            }
        }

        private void EntryRegButton_Click(object sender, EventArgs e)
        {
            string query = $"select Users1.Confirmed from Users1 where UserID='{AuthMenu.txt1}'";
            DataSet ds = func.getData(query);
            if ((bool)ds.Tables[0].Rows[0][0] == true)
            {
                int Sum = Convert.ToInt32(SumLabel.Text);
                string Date = DateLabel.Text;
                var dat = DateTime.Now;
                DateTime DateDeposit = dat.AddMonths(Convert.ToInt32(Date));

                int days = (DateDeposit - dat).Days;

                //суммы которая сейчас на аккаунте
                query = $"select Users1.Amount from Users1 where UserID='{AuthMenu.txt1}'";

                //суммы которая сейчас на балансе вкладов
                string queryInvestedBalanceAll = $"select Users1.InvestedBalanceAll from Users1 where UserID='{AuthMenu.txt1}'";
                DataSet queryIBAll = func.getData(queryInvestedBalanceAll);

                DataSet sum_amount = func.getData(query);
                int sums = Convert.ToInt32(sum_amount.Tables[0].Rows[0][0].ToString());

                int Sum_ostatok = sums - Sum;

                double Sum_viplat = Sum * Math.Pow((1 + ((Convert.ToInt32(ProcentTextBox.Text) * 0.01) / 365.0)), days);

                int InvestedBalanceAll = Convert.ToInt32(queryIBAll.Tables[0].Rows[0][0]) + Convert.ToInt32(Sum_viplat);
                if (Sum <= sums)
                {
                    string query_deposit = "insert into Deposits(userID, Amount, Activity, DateDeposit) values ('" + AuthMenu.txt1 + "', '" + Convert.ToInt32(Sum_viplat) + "', '" + 1 + "', '" + DateDeposit.ToShortDateString() + "')";
                    string query_operations = "insert into Operation(userID, Amount, TypeOperation, DateOperation) values ('" + AuthMenu.txt1 + "', '" + Sum + "', '" + 4 + "', '" + DateTime.Now + "')"; 
                    string query_sumupdate = $"UPDATE Users1 SET Amount={Sum_ostatok} WHERE UserID={AuthMenu.txt1}";
                    string query_InvestedBalanceAll = $"UPDATE Users1 SET InvestedBalanceAll={InvestedBalanceAll} WHERE UserID={AuthMenu.txt1}";

                    func.setDataUpd(query_deposit);
                    func.setDataUpd(query_operations);
                    func.setDataUpd(query_sumupdate);
                    func.setDataUpd(query_InvestedBalanceAll);

                    MessageBox.Show($"Вклад успешно внесён\nДата выплаты вклада: {DateDeposit.ToShortDateString()}");

                    ProfileMenu form3 = new ProfileMenu();
                    this.Hide();
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ваш аккаунт не подтверждён! Подтвердите аккаунт чтобы совершить вклад", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProcentTextBox_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
