using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using payment.BLL;

namespace payment.UI
{
	public partial class FormRegister : Form
	{
		public FormRegister()
		{
			InitializeComponent();
		}

        private void btnRegister_Click(object sender, EventArgs e)
        {
			if(txRegName.Text == "")
			{
				MessageBox.Show("用户名不能为空！", "信息提示", MessageBoxButtons.OKCancel);
			}
			else if(txRegPwd1.Text == "" || txRegPwd2.Text == "")
			{
				MessageBox.Show("密码或确认密码不能为空！","信息提示",MessageBoxButtons.OKCancel);
			}
			else if(txRegPwd1.Text != txRegPwd2.Text)
			{
				MessageBox.Show("两次输入密码不一致！", "信息提示", MessageBoxButtons.OKCancel);
			}
			else if(comboBox1.Text=="")
			{
				MessageBox.Show("请选择注册类型！", "信息提示", MessageBoxButtons.OKCancel);
			}
			else
			{
				int result;
				BLL.model.User newUser = new BLL.model.User();
				newUser.Username = txRegName.Text;
				newUser.Password = txRegPwd1.Text;
				newUser.Type = comboBox1.Text;
				BLL.Login.LoginOrRegister newLorR = new BLL.Login.LoginOrRegister();
				result = newLorR.Register(newUser);
				if(result==1)
				{
					MessageBox.Show("注册成功，点击确定返回登录界面！", "信息提示", MessageBoxButtons.OKCancel);
					this.Close();
				}
				else
				{
					MessageBox.Show("注册失败，请联系系统管理员！", "信息提示", MessageBoxButtons.OKCancel);
				}
			}
        }

		private void FormRegister_Load(object sender, EventArgs e)
		{
			comboBox1.Items.Add("P1");
			comboBox1.Items.Add("P2");
			comboBox1.Items.Add("P3");
			comboBox1.Items.Add("P4");
			comboBox1.Items.Add("P5");
			comboBox1.Items.Add("P6");
		}
	}
}
