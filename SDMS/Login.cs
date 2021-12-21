using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button_login_Click(object sender, EventArgs e)
        {
            BLL.LoginBLL loginBLL = new BLL.LoginBLL();
            if (this.guna2CustomRadioButton_stu.Checked)
            {
                if (loginBLL.isStudentLogined(this.guna2TextBox_username.Text, this.guna2TextBox_passworld.Text))
                {
                    MessageBox.Show("身份验证成功");
                    Thread thread = new Thread(() =>
                    {
                        Application.Run(new Main());
                    });
                    thread.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("身份验证失败");
                }
            }

            if (this.guna2CustomRadioButton_admin.Checked)
            {
                if (loginBLL.isAdminLogined(this.guna2TextBox_username.Text, this.guna2TextBox_passworld.Text))
                {
                    MessageBox.Show("身份验证成功");
                    Thread thread = new Thread(() =>
                    {
                        Application.Run(new Main());
                    });
                    thread.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("身份验证失败");
                }
            }
            
        }
    }
}
