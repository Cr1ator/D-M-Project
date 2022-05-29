using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace reg
{


    public partial class InvestMenu : Form
    {
        String query1;
        funkreg func = new funkreg();

        public InvestMenu()
        {
            InitializeComponent();

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

        private void DMText_Click(object sender, EventArgs e)
        {

        }

        double MonthlyPayment, InterestRate, monthlyInterestRate, loanAmount, TotalPayment, principalDebt;
        int Termofyears;
        DateTime  DN, LD, PD;
        string dn, ld;

        private void txtLoanAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLoanAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                txtLoanAmount.Text = txtLoanAmount.Text.Remove(txtLoanAmount.Text.Length - 1);
            }
        }

        private void txtTerm_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTerm.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                txtTerm.Text = txtTerm.Text.Remove(txtTerm.Text.Length - 1);
            }
        }

        private void txtZP_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtZP.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                txtZP.Text = txtZP.Text.Remove(txtZP.Text.Length - 1);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rtfReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        public void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = $"select Users1.Confirmed from Users1 where UserID='{AuthMenu.txt1}'";
            DataSet ds = func.getData(query);
            if ((bool)ds.Tables[0].Rows[0][0] == true)
            {
                try
                {

                    InterestRate = 12.0;
                    monthlyInterestRate = InterestRate / 1200;
                    Termofyears = Convert.ToInt32(txtTerm.Text);
                    loanAmount = Convert.ToDouble(txtLoanAmount.Text);
                    if (loanAmount >= 1000)
                    {
                        double month = (Termofyears * 12) - 1;
                        principalDebt = loanAmount / month;
                        DN = DateTime.Now;
                        LD = DateTime.Now.AddYears(Termofyears);
                        PD = DateTime.Now.AddMonths(1);

                        dn = Convert.ToString(DN);
                        ld = Convert.ToString(LD);

                        MonthlyPayment = (loanAmount * monthlyInterestRate / 1 - 1 / Math.Pow(1 + monthlyInterestRate, Termofyears * 12)) + principalDebt;
                        TotalPayment = MonthlyPayment * Termofyears * 12;


                        string iMonthlyPayment = Convert.ToString(MonthlyPayment);
                        iMonthlyPayment = String.Format("{0:0.00}", MonthlyPayment);
                        ibiMonthlyPayment.Text = iMonthlyPayment;


                        //string iTotalPayment = Convert.ToString(TotalPayment);
                        string iTotalPayment = String.Format("{0:0.00}", TotalPayment);
                        IbiTotalPayment.Text = iTotalPayment;

                                            
                    }
                    else
                    {
                        MessageBox.Show("Банк выдает кредит от 1000 BYN", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Поля не заполнены!");
                }
            }
            else
            {
                MessageBox.Show("Ваш аккаунт не подтверждён! Подтвердите аккаунт чтобы взять кредит", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void InvestMenu_Load(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EntryRegButton_Click_1(object sender, EventArgs e)
        {
            string query = $"select Users1.Confirmed from Users1 where UserID='{AuthMenu.txt1}'";

            

            DataSet ds = func.getData(query);

            

            if ((bool)ds.Tables[0].Rows[0][0] == true)
            {
                string activ = $"select Credits.Activity from Credits where UserID='{AuthMenu.txt1}'";

                DataSet ac = func.getData(activ);
                if ((bool)ac.Tables[0].Rows[0][0] == false)
                {
                    try
                    {

                        InterestRate = 12.0;
                        monthlyInterestRate = InterestRate / 1200;
                        Termofyears = Convert.ToInt32(txtTerm.Text);
                        loanAmount = Convert.ToDouble(txtLoanAmount.Text);
                        if (loanAmount >= 1000)
                        {
                            double month = (Termofyears * 12) - 1;
                            principalDebt = loanAmount / month;
                            DN = DateTime.Now;
                            LD = DateTime.Now.AddYears(Termofyears);
                            PD = DateTime.Now.AddMonths(1);

                            dn = Convert.ToString(DN);
                            ld = Convert.ToString(LD);

                            MonthlyPayment = (loanAmount * monthlyInterestRate / 1 - 1 / Math.Pow(1 + monthlyInterestRate, Termofyears * 12)) + principalDebt;
                            TotalPayment = MonthlyPayment * Termofyears * 12;


                            string iMonthlyPayment = Convert.ToString(MonthlyPayment);
                            iMonthlyPayment = String.Format("{0:0.00}", MonthlyPayment);
                            ibiMonthlyPayment.Text = iMonthlyPayment;


                            //string iTotalPayment = Convert.ToString(TotalPayment);
                            string iTotalPayment = String.Format("{0:0.00}", TotalPayment);
                            IbiTotalPayment.Text = iTotalPayment;

                            guna2Panel1.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Банк выдает кредит от 1000 BYN", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Поля не заполнены!");
                    }
                }
                else
                {
                    MessageBox.Show("У вас уже есть активный кредит, погасите предыдущий чтобы взять новый ", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                   
            }
            else
            {
                MessageBox.Show("Ваш аккаунт не подтверждён! Подтвердите аккаунт чтобы взять кредит", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            double ZP = Convert.ToDouble(txtZP.Text);
            double forty = (ZP * 40) / 100;
            if (MonthlyPayment > forty)
            {
                MessageBox.Show("Банк вам отказал в выдаче кридита!"); 
            }
            else
            {
                MessageBox.Show("Банк вам выдает кредит, проверьте средства на балансе!");
                rtfReceipt.AppendText("                            D&M Bank                                " + "\n");
                rtfReceipt.AppendText("--------------------------------------------------------------" + "\n");
                rtfReceipt.AppendText("Сумма кредита:      " + txtLoanAmount.Text + "  BYN" + "\n");
                rtfReceipt.AppendText("Срок кредита:       " + txtTerm.Text + "\n");
                rtfReceipt.AppendText("Процентная ставка:  " +  "12%" + "\n");
                rtfReceipt.AppendText("Ежемесячный платеж: " + ibiMonthlyPayment.Text + "  BYN"+ "\n");
                rtfReceipt.AppendText("Итоговая сумма:     " + IbiTotalPayment.Text + "  BYN"+ "\n");
                rtfReceipt.AppendText("--------------------------------------------------------------" + "\n");
                rtfReceipt.AppendText("                            D&M Bank                                " + "\n");

                guna2Button4.Visible = true;

                query = $"select Users1.Amount from Users1 where UserID='{AuthMenu.txt1}'";
                DataSet sum_amount = func.getData(query);
                double Sum_amount = Convert.ToDouble(sum_amount.Tables[0].Rows[0][0].ToString());
                double Sum_Credit = Sum_amount + loanAmount;

                string query_sumupdate = $"UPDATE Users1 SET Amount={Sum_Credit} WHERE UserID={AuthMenu.txt1}";
                func.setDataUpd(query_sumupdate);
              
              //string query_savecredit = "insert into Credits(userID, Amount, interestRate, paymentDate, EndDate, monthlyPaymentAmount, Activity, DateCredits, salary, CreditsTotalPayment) values ('" + AuthMenu.txt1 + "', '" + Convert.ToDouble(txtLoanAmount.Text) + "', '" + 12.0 + "', '" + PD + "', '" + LD + "' , '" + Convert.ToDouble(ibiMonthlyPayment.Text) + "', '" + 1 + "', '" + DN + "', '" + Convert.ToDouble(ZP) + "', '" + BTP + "')";
                string query_savecredit = "insert into Credits(userID, Amount, interestRate, paymentDate, EndDate, monthlyPaymentAmount, Activity, DateCredits, salary, CreditsTotalPayment) values ('" + AuthMenu.txt1 + "', '" + Convert.ToDouble(txtLoanAmount.Text) + "', '" + 12.0 + "', '" + PD + "', '" + LD + "' , '" +  ibiMonthlyPayment.Text.Replace(',', '.') + "', '" + 1 + "', '" + DN + "', '" + txtZP.Text.Replace(',', '.') + "', '" + IbiTotalPayment.Text.Replace(',', '.') + "')";
                //string query_savecredit = "insert into Credits(userID, Amount) values ('" + AuthMenu.txt1 + "', '" + Convert.ToDouble(txtLoanAmount.Text) + "')";
                func.setDataUpd(query_savecredit);

                //суммы которая сейчас на балансе кредитов
                string queryCreditBalanceAll = $"select Users1.CreditBalanceAll from Users1 where UserID='{AuthMenu.txt1}'";
                DataSet queryCBAll = func.getData(queryCreditBalanceAll);
                //Сложение суммы взятого кредита с остальными
                int CreditBalanceAll = Convert.ToInt32(queryCBAll.Tables[0].Rows[0][0]) + Convert.ToInt32(TotalPayment);
                string query_InvestedBalanceAll = $"UPDATE Users1 SET CreditBalanceAll={CreditBalanceAll} WHERE UserID={AuthMenu.txt1}";
                func.setDataUpd(query_InvestedBalanceAll);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            var word = new Wordhelp("КредитныйДоговорDM.docx");
            var items = new Dictionary<string, string>
            {
                {"<LA>", txtLoanAmount.Text},
                {"<TOY>", txtTerm.Text },
                {"<MP>", ibiMonthlyPayment.Text },
                {"<TP>", ibiMonthlyPayment.Text},
                {"<SN>", AuthMenu.txtSN},
                {"<DN>", dn},
                {"<LD>", ld },
            };

            word.Process(items);
            MessageBox.Show("Word file created");


        }

        string query = $"select Users1.Confirmed from Users1 where UserID='{AuthMenu.txt1}'";
    }
}
