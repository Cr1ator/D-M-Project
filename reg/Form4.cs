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

        double MonthlyPayment, InterestRate, monthlyInterestRate, Termofyears, loanAmount, TotalPayment, principalDebt;
        public void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
               
                InterestRate = 12.0;
                monthlyInterestRate = InterestRate / 1200;
                Termofyears = Convert.ToDouble(txtTerm.Text);
                loanAmount = Convert.ToDouble(txtLoanAmount.Text);
                double month = (Termofyears * 12) - 1;
                principalDebt = loanAmount / month;

                MonthlyPayment = (loanAmount * monthlyInterestRate / 1 - 1 / Math.Pow(1 + monthlyInterestRate, Termofyears * 12))+principalDebt;
                TotalPayment = MonthlyPayment * Termofyears * 12;


                string iMonthlyPayment = Convert.ToString(MonthlyPayment);
                iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
                ibiMonthlyPayment.Text = iMonthlyPayment;

                
                //string iTotalPayment = Convert.ToString(TotalPayment);
                string iTotalPayment = String.Format("{0:C}", TotalPayment);
                IbiTotalPayment.Text = iTotalPayment;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Поля не заполнены!");
            }


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EntryRegButton_Click(object sender, EventArgs e)
        {
            OdobrCredit odobrCredit = new OdobrCredit();
            this.Hide();
            odobrCredit.Show();
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


            }
        }
    }
}
