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

        public void guna2Button1_Click(object sender, EventArgs e)
        {

            if (t)
                double InterestRate = 12.0;
            double mothlyInterestRate = InterestRate / 1200;
            double Termofyears = Convert.ToDouble(txtTerm.Text);
            double loanAmount = Convert.ToDouble(txtLoanAmount.Text);

            double MonthlyPayment = loanAmount * mothlyInterestRate / 1 - 1 / Math.Pow(1 + mothlyInterestRate, Termofyears * 12);



            string iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            ibiMonthlyPayment.Text = iMonthlyPayment;

            double TotalPayment = MonthlyPayment * Termofyears * 12;
            //string iTotalPayment = Convert.ToString(TotalPayment);
            string iTotalPayment = String.Format("{0:C}", TotalPayment);
            IbiTotalPayment.Text = iTotalPayment;


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
    }
}
