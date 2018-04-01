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
using payment.BLL.model;
using payment.BLL.Reserve;

namespace payment.UI
{
	public partial class FormReserve : Form
	{
		public FormReserve()
		{
			InitializeComponent();
		}

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txIDNum.Text == "" || txAge.Text == "" || txName.Text == "" || txTell.Text == "")
            {
                MessageBox.Show("请输入完整信息", "信息提示", MessageBoxButtons.OKCancel);
            }
            else
            {
                PatientReserve pr = new PatientReserve();
                BeingHospitalized newpatient = new BeingHospitalized();
                newpatient.IDNumber = txIDNum.Text;
                newpatient.Name = txName.Text;
                if (rdBtnF.Checked == true)
                {
                    newpatient.Sex = "女";
                }
                else if (rdBtnM.Checked == true)
                {
                    newpatient.Sex = "男";
                }
                else
                {
                    MessageBox.Show("请选择性别！", "信息提示", MessageBoxButtons.OKCancel);
                }

                //AGE
                string str = txAge.Text;
                bool flag = true;
                char[] ch = new char[str.Length];
                ch = str.ToCharArray();
                for (int i = 0; i < str.Length; i++)
                {
                    if (ch[i] < '0' || ch[i] > '9')
                    {
                        MessageBox.Show("年龄格式不正确，请重新输入！", "信息提示", MessageBoxButtons.OKCancel);
                        flag = false;
                        break;
                    }
                }
                if (flag && (int.Parse(txAge.Text) > 0 && int.Parse(txAge.Text) < 200))
                {
                    newpatient.Age = int.Parse(txAge.Text);
                    newpatient.Phone = txTell.Text;
                    newpatient.Situation = 0;

                    MessageBox.Show(pr.ReserveSubmit(newpatient), "信息提示", MessageBoxButtons.OKCancel);
                    txIDNum.Text = null;
                    txName.Text = null;
                    rdBtnF.Checked = false;
                    rdBtnM.Checked = false;
                    txAge.Text = null;
                    txTell.Text = null;
                }
                else
                {
                    MessageBox.Show("年龄大小不正确，请重新输入！", "信息提示", MessageBoxButtons.OKCancel);
                }

               
            }
        }

    }

 }
