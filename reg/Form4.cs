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
        DateTime  DN, LD;
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

        public void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
               
                InterestRate = 12.0;
                monthlyInterestRate = InterestRate / 1200;
                Termofyears = Convert.ToInt32(txtTerm.Text);
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);
                double month = (Termofyears * 12) - 1;
                principalDebt = loanAmount / month;
                DN = DateTime.Now;
                LD = DateTime.Now.AddYears(Termofyears);
                
                dn = Convert.ToString(DN);
                ld = Convert.ToString(LD);

                MonthlyPayment = (loanAmount * monthlyInterestRate / 1 - 1 / Math.Pow(1 + monthlyInterestRate, Termofyears * 12))+principalDebt;
                TotalPayment = MonthlyPayment * Termofyears * 12;


                string iMonthlyPayment = Convert.ToString(MonthlyPayment);
                iMonthlyPayment = String.Format("{0:0.00}", MonthlyPayment);
                ibiMonthlyPayment.Text = iMonthlyPayment;

                
                //string iTotalPayment = Convert.ToString(TotalPayment);
                string iTotalPayment = String.Format("{0:0.00}", TotalPayment);
                IbiTotalPayment.Text = iTotalPayment;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Поля не заполнены!");
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
            try
            {

                InterestRate = 12.0;
                monthlyInterestRate = InterestRate / 1200;
                Termofyears = Convert.ToInt32(txtTerm.Text);
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);
                double month = (Termofyears * 12) - 1;
                principalDebt = loanAmount / month;
                DN = DateTime.Now;
                LD = DateTime.Now.AddYears(Termofyears);

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
            catch (Exception ex)
            {
                MessageBox.Show("Поля не заполнены!");
            }

            guna2Panel1.Visible = true;
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
                rtfReceipt.AppendText("Итоговая сумма:     " + ibiMonthlyPayment.Text + "  BYN"+ "\n");
                rtfReceipt.AppendText("--------------------------------------------------------------" + "\n");
                rtfReceipt.AppendText("                            D&M Bank                                " + "\n");

                guna2Button4.Visible = true;
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
    }
}
