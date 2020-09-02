using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Festo_Rubik_s_Cube_Explorer
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            if (UserLogin.IsLoggedIn)
            {
                this.Text = "登入登出（已登入）";
                this.button_change_password.Visible = true;
                this.button_login.Text = "登出";
            }

            if (string.IsNullOrEmpty(UserLogin.Password)) // there is no password in config file
            {
                UserLogin.Password = "1"; // set a default one
                return;
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string userPwd = UserLogin.Hash(this.textBox_password.Text.Trim());
            this.textBox_password.Text = string.Empty;
            if (this.button_login.Text == "登出" && UserLogin.IsLoggedIn) // logout
            {
                UserLogin.IsLoggedIn = false;
                this.Text = "登入登出";
                this.button_login.Text = "登入";
                return;
            }
            if (userPwd == UserLogin.Password) // login
            {
                UserLogin.IsLoggedIn = true;
                this.button_change_password.Visible = true;
                this.Text = "登入登出（已登入）";
                this.button_login.Text = "登出";
            }
            else
            {
                MessageBox.Show("口令错误！");
            }
        }

        private void button_change_password_Click(object sender, EventArgs e)
        {
            if (UserLogin.IsLoggedIn == false)
            {
                MessageBox.Show("请先登入");
                return;
            }
            if (string.IsNullOrEmpty(textBox_password.Text))
            {
                MessageBox.Show("口令不能为空……");
                return;
            }

            UserLogin.Password = textBox_password.Text;
            MessageBox.Show("成功更改口令");
            this.textBox_password.Text = string.Empty;
        }

        private void button_change_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.button_login_Click(null, null);
            }
        }

        private void button_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
