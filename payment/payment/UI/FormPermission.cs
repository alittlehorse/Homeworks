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
using payment.BLL.PatientInfo;

namespace payment.UI
{
	public partial class FormPermission : Form
	{
		public FormPermission()
		{
			InitializeComponent();
		}

		private void FormRegister_Load(object sender, EventArgs e)
		{
			PermissionCheck newCheck = new PermissionCheck();
			DataTable newtable = new DataTable();
			newtable = newCheck.selectReservePatients();
			int sum = newtable.Rows.Count;
			for(int i=0;i<sum;i++)
			{
				comboBox1.Items.Add(newtable.Rows[i][0]);
			}

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			PermissionCheck newCheck = new PermissionCheck();
			DataTable newtable = new DataTable();
			newtable = newCheck.selectInfo(comboBox1.Text);
			txIDNum.Text = newtable.Rows[0][0].ToString();
			txName.Text = newtable.Rows[0][1].ToString();
			if(newtable.Rows[0][2].ToString()=="男")
			{
				rdBtnM.Checked = true;
			}
			else
			{
				rdBtnF.Checked = true;
			}
			txAge.Text = newtable.Rows[0][3].ToString();
			txTell.Text = newtable.Rows[0][4].ToString();
		}

		private void btnAgree_Click(object sender, EventArgs e)
		{
			PermissionCheck newCheck = new PermissionCheck();
            Patients patient = new Patients();
            patient.IDNumber = comboBox1.Text;
            Patientinfo patientinfo = new Patientinfo();
            ///如果不是第一次入院，不新建病例
            if (patientinfo.FindPatientByIDNumber(patient))
            {

            }
            else///如果是第一次入院，则新建病例
            {
                patient.Age = int.Parse(txAge.Text);
                patient.PatienName = txName.Text;
                if (rdBtnF.Checked == true)
                {
                    patient.Sex = "女";
                }
                else {
                    patient.Sex = "男";
                }
                patient.IDNumber=txIDNum.Text;
                patient.Phone = txTell.Text;
                patientinfo.InertPatient(patient);
            }
			int result;
			result = newCheck.Agree(comboBox1.Text);

			if (result > 0)
			{
				MessageBox.Show("操作成功！", "信息提示", MessageBoxButtons.OKCancel);
			}
            comboBox1.Items.Remove(this.comboBox1.SelectedItem);
            txAge.Text = "";
            txIDNum.Text = "";
            txName.Text = "";
            txTell.Text = "";
            rdBtnF.Checked = false;
            rdBtnM.Checked = false;
		}

		private void btnReject_Click(object sender, EventArgs e)
		{
			PermissionCheck newCheck = new PermissionCheck();
			int result;
			result = newCheck.Reject(comboBox1.Text);
			if (result > 0)
			{
				MessageBox.Show("操作成功！", "信息提示", MessageBoxButtons.OKCancel);
			}
		}
	}
}
