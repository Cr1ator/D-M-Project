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
        public ProfileMenu()
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
            timer1_Tick( sender, e);
            ToolTip t = new ToolTip();
            t.SetToolTip(guna2Button3, "Инвестиции");
            t.SetToolTip(guna2Button2, "Пополнить счёт");
            t.SetToolTip(guna2Button1, "Вклады");
            t.SetToolTip(Menu3, "Подтверждение");
            t.SetToolTip(noComfirmAccount, "Подтвердите аккаунт");

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
    }
}
