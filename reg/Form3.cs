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
    public partial class ProfileMenu : Form
    {
        String query, queryCreditBalanceAll;
        funkreg func = new funkreg();
        public ProfileMenu()
        {
            InitializeComponent();
            query = $"select Users1.Confirmed from Users1 where UserID='{AuthMenu.txt1}'";
            DataSet ds = func.getData(query);
            if ((bool)ds.Tables[0].Rows[0][0] == true)
            {
                noComfirmAccount.Hide();
                TrueComfirmAccount.Show();
            }
            else
            {
                TrueComfirmAccount.Hide();
            }

            query = $"select Users1.Amount, Users1.CreditBalanceAll from Users1 where UserID='{AuthMenu.txt1}'";
            DataSet sum = func.getData(query);
            int Amount = Convert.ToInt32(sum.Tables[0].Rows[0][0]);
            //MyAccountLabel.Text = Amount.ToString();
            
            CreditSumLabel.Text = sum.Tables[0].Rows[0][1].ToString();

            //Выплата вклада
            string query_vklad = $"select Deposits.DateDeposit, Deposits.Amount from Deposits where UserID='{AuthMenu.txt1}' and Activity=1 ";
            DataSet vklad= func.getData(query_vklad);
            //MessageBox.Show(DateTime.Parse(vklad.Tables[0].Rows[0][0].ToString()).ToString());
            DateTime Now_time = DateTime.Now;


            for (int i = 0; i < vklad.Tables[0].Rows.Count; i++)
            {
                DateTime end_vklad_time = DateTime.Parse(vklad.Tables[0].Rows[i][0].ToString());
                if (Now_time >= end_vklad_time)
                {
                    string queryInvestedBalanceAll = $"select Users1.InvestedBalanceAll from Users1 where UserID='{AuthMenu.txt1}'";
                    DataSet queryIBAll = func.getData(queryInvestedBalanceAll);

                    int Sum_ostatok = Amount + Convert.ToInt32(vklad.Tables[0].Rows[i][1]);
                    int InvestedBalanceAll = Convert.ToInt32(queryIBAll.Tables[0].Rows[0][0]) - Convert.ToInt32(vklad.Tables[0].Rows[i][1]);
                    string query_sumupdate = $"UPDATE Users1 SET Amount={Sum_ostatok} WHERE UserID={AuthMenu.txt1}";
                    string query_close_deposit = $"UPDATE Deposits SET Activity=0 WHERE UserID={AuthMenu.txt1} and DateDeposit='{end_vklad_time.ToShortDateString()}'";
                    string query_InvestedBalanceAll = $"UPDATE Users1 SET InvestedBalanceAll={InvestedBalanceAll} WHERE UserID={AuthMenu.txt1}";

                    func.setDataUpd(query_sumupdate);
                    func.setDataUpd(query_close_deposit);
                    func.setDataUpd(query_InvestedBalanceAll);

                    MessageBox.Show($"Вклад на сумму {vklad.Tables[0].Rows[i][1]} BYN выплачен ");
                }
            }

            query = $"select Users1.Amount, Users1.InvestedBalanceAll from Users1 where UserID='{AuthMenu.txt1}'";
            DataSet amount = func.getData(query);
            MyAccountLabel.Text = amount.Tables[0].Rows[0][0].ToString();
            VkladSumLabel.Text = amount.Tables[0].Rows[0][1].ToString();
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

        private int imageno = 1;

        private void loadimage()
        {
            if (imageno == 4)
            {
                imageno = 1;
            }
            pictureBoxSlider.ImageLocation = String.Format(@"slider\imageSlide{0}.png", imageno);
            imageno++;
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MenuText_Click(object sender, EventArgs e)
        {

        }

        private void StockText_Click(object sender, EventArgs e)
        {

        }

        private void ProfileMenu_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
            ToolTip t = new ToolTip();
            t.SetToolTip(guna2Button3, "Кредиты");
            t.SetToolTip(guna2Button2, "Пополнить счёт");
            t.SetToolTip(guna2Button1, "Вклады");
            t.SetToolTip(Menu3, "Подтверждение");
            t.SetToolTip(noComfirmAccount, "Подтвердите аккаунт");
            t.SetToolTip(TrueComfirmAccount, "Аккакут подтверждён");
            t.SetToolTip(repayment, "Погашение кредита");

            guna2Panel1.Visible = false;

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HideMenu_Click(object sender, EventArgs e)
        {

        }

        private void Menu3_Click(object sender, EventArgs e)
        {
            ConfirmMenu confirmMenu = new ConfirmMenu();
            this.Hide();
            confirmMenu.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadimage();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            InvestMenu form4 = new InvestMenu();
            this.Hide();
            form4.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AuthMenu form1 = new AuthMenu();
            this.Hide();
            form1.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            deposit_money deposit_money = new deposit_money();
            this.Hide();
            deposit_money.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MenuVklad MenuVklad = new MenuVklad();
            this.Hide();
            MenuVklad.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void noComfirmAccount_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void VkladSumLabel_Click(object sender, EventArgs e)
        {

        }


        private void repayment_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = true;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
        }



        private void ALLP_Click(object sender, EventArgs e)
        {
            query = $"select Users1.Amount, Users1.CreditBalanceAll from Users1 where UserID='{AuthMenu.txt1}'";
            
            
            DataSet sum_amount = func.getData(query);
            DataSet sum_credits = func.getData(query);
            
            double Sum_amount = Convert.ToDouble(sum_amount.Tables[0].Rows[0][0].ToString());
            double Sum_credits = Convert.ToDouble(sum_credits.Tables[0].Rows[0][1].ToString());

            if (Sum_credits > 0)
            {
                if (Sum_amount >= Sum_credits)
                {
                    double repayment = Sum_amount - Sum_credits;

                    string query_sumupdate = $"UPDATE Users1 SET Amount={repayment}, CreditBalanceAll= {0} WHERE UserID={AuthMenu.txt1}";
                    func.setDataUpd(query_sumupdate);

                    string activity = $"UPDATE Credits SET Activity={0} WHERE UserID={AuthMenu.txt1} and Activity='1'";
                    func.setDataUpd(activity);

                    MessageBox.Show("Кредит погашен ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    guna2Panel1.Visible = false;

                    string newQ = $"select Users1.CreditBalanceAll,  Users1.Amount from Users1 where UserID='{AuthMenu.txt1}'";
                    DataSet new_credit_balance = func.getData(newQ);
                    CreditSumLabel.Text = new_credit_balance.Tables[0].Rows[0][0].ToString();
                    MyAccountLabel.Text = new_credit_balance.Tables[0].Rows[0][1].ToString();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств для погашения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("У вас нет кредита", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                guna2Panel1.Visible = false;
            }

        }
        private void MP_Click(object sender, EventArgs e)
        {
            query = $"select Users1.Amount, Users1.CreditBalanceAll from Users1 where UserID='{AuthMenu.txt1}'";
            string queryMP = $"select Credits.monthlyPaymentAmount from Credits where UserID='{AuthMenu.txt1}' and Activity=1";

            DataSet sum_amount = func.getData(query);
            DataSet sum_credits = func.getData(query);
            DataSet sum_MP = func.getData(queryMP);

            double Sum_amount = Convert.ToDouble(sum_amount.Tables[0].Rows[0][0].ToString());
            double Sum_credits = Convert.ToDouble(sum_credits.Tables[0].Rows[0][1].ToString());

            double Sum_MP = Convert.ToDouble(sum_MP.Tables[0].Rows[0][0].ToString());

            
            if (Sum_credits > 0)
            {
                
                 if (Sum_amount >= Sum_MP)
                 {
                     double repayment = Sum_amount - Sum_MP;
                     double LoanBalance = Sum_credits - Sum_MP;

                    //MessageBox.Show(repayment.ToString());
                    //MessageBox.Show(Convert.ToInt32(repayment).ToString());
                    string query_sumupdate = $"UPDATE Users1 SET Amount={Convert.ToInt32(repayment)}, CreditBalanceAll= {Convert.ToInt32(LoanBalance)}  WHERE UserID={AuthMenu.txt1}";
                    func.setDataUpd(query_sumupdate);
                    //MessageBox.Show("3 fsdf");

                    MessageBox.Show("Кредит погашен ", "D&M Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query_sumostatok = $"select Users1.CreditBalanceAll, Users1.Amount  from Users1 where UserID='{AuthMenu.txt1}'";
                    DataSet dt_sum_ostatok = func.getData(query_sumostatok);

                    CreditSumLabel.Text = dt_sum_ostatok.Tables[0].Rows[0][0].ToString();
                    MyAccountLabel.Text = dt_sum_ostatok.Tables[0].Rows[0][1].ToString();

                    guna2Panel1.Visible = false;

                 }
                 else
                 {
                     MessageBox.Show("Недостаточно средств для погашения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
            }
            else
            {
                MessageBox.Show("У вас нет кредита", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                guna2Panel1.Visible = false;
            }
        }
    }
}
