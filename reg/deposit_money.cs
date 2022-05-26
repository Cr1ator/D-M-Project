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
        public deposit_money()
        {
            InitializeComponent();

            //guna2TextBox4.UseSystemPasswordChar = true;
            //guna2TextBox4.MaxLength = 4;
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
            if (System.Text.RegularExpressions.Regex.IsMatch(guna2TextBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                guna2TextBox1.Text = guna2TextBox1.Text.Remove(guna2TextBox1.Text.Length - 1);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(guna2TextBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                guna2TextBox5.Text = guna2TextBox5.Text.Remove(guna2TextBox5.Text.Length - 1);
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
            if (System.Text.RegularExpressions.Regex.IsMatch(guna2TextBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                guna2TextBox3.Text = guna2TextBox3.Text.Remove(guna2TextBox3.Text.Length - 1);
            }
        }

        private void EntryRegButton_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(guna2TextBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводите толька числа");
                guna2TextBox4.Text = guna2TextBox4.Text.Remove(guna2TextBox4.Text.Length - 1);
            }
        }

        private void EntryRegButton_Click(object sender, EventArgs e)
        {

        }
    }
}
