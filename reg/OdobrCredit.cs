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
    public partial class OdobrCredit : Form
    {
        public OdobrCredit()
        {
            InitializeComponent();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InvestMenu form4 = new InvestMenu();
            this.Hide();
            form4.Show();
        }

        private void EntryRegButton_Click(object sender, EventArgs e)
        {
/*            InvestMenu f4 = new InvestMenu(ibiMonthlyPayment.Text);

           double iMonthlyPayment = ibiMonthlyPayment.Text;
            if (iMonthlyPayment)*/
        }
    }
}
