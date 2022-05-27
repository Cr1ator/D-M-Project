﻿using System;
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
            ProcentTextBox.Text = "14%";
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
                ProcentTextBox.Text = "14%";
                DateLabel.Text = "8";
            }
            else
            {
                if (Convert.ToInt32(moneyTrackBar.Value.ToString()) > 100000 && Convert.ToInt32(moneyTrackBar.Value.ToString()) <= 300000)
                {
                    DateTrackBar.Value = 16;
                    ProcentTextBox.Text = "20%";
                    DateLabel.Text = "16";
                }
                else
                {
                    DateTrackBar.Value = 24;
                    ProcentTextBox.Text = "24%";
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
                ProcentTextBox.Text = "14%";
            }
            else
            {
                if (DateTrackBar.Value >= 9 && DateTrackBar.Value <= 19)
                {
                    moneyTrackBar.Value = 300000;
                    SumLabel.Text = "300000";
                    ProcentTextBox.Text = "20%";
                }
                else
                {
                    if (DateTrackBar.Value >= 20)
                    {
                        moneyTrackBar.Value = 500000;
                        SumLabel.Text = "500000";
                        ProcentTextBox.Text = "24%";
                    }
                }
            }
        }

        private void EntryRegButton_Click(object sender, EventArgs e)
        {
            string Sum = SumLabel.Text;
            string Date = DateLabel.Text;
            //MessageBox.Show(DateTime.Now.ToString());
            var dat = DateTime.Now;
            MessageBox.Show(dat.AddMonths(Convert.ToInt32(Date)).ToString("d"));

            //суммы которая сейчас на аккаунте
            string query = $"select Users1.Amount from Users1 where UserID='{AuthMenu.txt1}'";
            DataSet sum_amount = func.getData(query);
            int sums = Convert.ToInt32(sum_amount.Tables[0].Rows[0][0].ToString());

            sum = sum + sums;
        }

        private void ProcentTextBox_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
