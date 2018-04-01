using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using payment.UI;

namespace payment.UI
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			FormRegister myRegister = new FormRegister();
			myRegister.ShowDialog();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if(txName.Text == "")  //判断用户名是否为空
			{
				MessageBox.Show("用户名不能为空！", "信息提示", MessageBoxButtons.OKCancel);
			}
			else if(txPwd.Text == "") //判断密码是否为空
			{
				MessageBox.Show("密码不能为空！", "信息提示", MessageBoxButtons.OKCancel);
			}
			else
			{
				BLL.model.User newUser = new BLL.model.User();
				BLL.Login.LoginOrRegister newLorR = new BLL.Login.LoginOrRegister();
				DataTable mytable = new DataTable();
				newUser.Username = txName.Text;
				mytable = newLorR.Login(newUser);
				if(mytable.Rows[0][0].ToString() == txName.Text && mytable.Rows[0][1].ToString() == txPwd.Text)
				{
					MessageBox.Show("登录成功！", "信息提示", MessageBoxButtons.OKCancel);
					if(mytable.Rows[0][2].ToString() == "P1")
					{
						UI.FormPermission myform = new FormPermission();
						this.Hide();
						myform.ShowDialog();
						this.Close();
					}
					else if(mytable.Rows[0][2].ToString() == "P2")
					{
						UI.FormPayment myform = new FormPayment();
						this.Hide();
						myform.ShowDialog();
						this.Close();
					}
					else if (mytable.Rows[0][2].ToString() == "P3")
					{
						UI.FormLeave myform = new FormLeave();
						this.Hide();
						myform.ShowDialog();
						this.Close();
					}
					else if (mytable.Rows[0][2].ToString() == "P4")
					{
						UI.FormMedicalRecord myform = new FormMedicalRecord();
						this.Hide();
						myform.ShowDialog();
						this.Close();
					}
					else if (mytable.Rows[0][2].ToString() == "P5")
					{
						UI.FormSelect myform = new FormSelect();
						this.Hide();
						myform.ShowDialog();
						this.Close();
					}
					else if (mytable.Rows[0][2].ToString() == "P6")
					{
						UI.FormBedManagement myform = new FormBedManagement();
						this.Hide();
						myform.ShowDialog();
						this.Close();
					}
				}
				else
				{
					MessageBox.Show("用户名或密码错误！", "信息提示", MessageBoxButtons.OKCancel);
				}
			}
		}
	}
}
