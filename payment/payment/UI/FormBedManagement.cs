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
using payment.UI;
using payment.BLL.model;
using payment.BLL.BedManagement;
using payment.BLL.PatientInfo;

namespace payment.UI
{
	public partial class FormBedManagement : Form
	{
		public FormBedManagement()
		{
			InitializeComponent();
		}
        Bed bed = new Bed();
        MBed mbed = new MBed();
        /// <summary>
        /// 增加床位是的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBed_Click(object sender, EventArgs e)
        {
            
            if (txBedID1.Text == "")
            {
                MessageBox.Show("请输入床位号");
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择床位类型");
            }
            bed.BID = txBedID1.Text;
            bed.State = comboBox2.SelectedItem.ToString();
            bed.DName=comboBox1.SelectedItem.ToString();
            
            MessageBox.Show(mbed.InsertBed(bed));
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 第二层tabpage切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab.Name == "InsertBedPage")
            {
                if (comboBox1.Items.Count == 0)
                {
                    Department department = new Department();
                    ManageOfDepartment md = new ManageOfDepartment();
                    DataTable datatable = md.ShowDName(department);
                    if (datatable.Rows.Count > 0)
                    {
                        for (int i = 0; i < datatable.Rows.Count; i++)
                        {
                            comboBox1.Items.Add(datatable.Rows[i][0]);
                        }
                        comboBox1.SelectedIndex = 0;
                    }
                    else
                    {

                    }
                }
            }
            if (tabControl2.SelectedTab.Name == "DeleteBedPage")
            {

            }
            if (tabControl2.SelectedTab.Name == "IndentifyingBedPage")
            {
                if (comboBox4.Items.Count ==0)
                {
                    Department department = new Department();
                    ManageOfDepartment md = new ManageOfDepartment();
                    DataTable datatable = md.ShowDName(department);
                    if (datatable.Rows.Count > 0)
                    {
                        for (int i = 0; i < datatable.Rows.Count; i++)
                        {
                            comboBox4.Items.Add(datatable.Rows[i][0]);
                        }
                        comboBox4.SelectedIndex = 0;
                    }
                    else
                    {

                    }
                }
            }
        }
        /// <summary>
        /// 第一层tabpage切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 页面加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBedManagement_Load(object sender, EventArgs e)
        {
            Department department = new Department();
            ManageOfDepartment md = new ManageOfDepartment();
            DataTable datatable = md.ShowDName(department);
            if (datatable.Rows.Count > 0)
            {
                for (int i = 0; i < datatable.Rows.Count; i++)
                {
                    comboBox1.Items.Add(datatable.Rows[i][0]);
                }
                comboBox1.SelectedIndex = 0;
            }
            else
            {

            }
        }

        private void btnSelectBedID1_Click(object sender, EventArgs e)
        {

            bed .BID=txBedID2.Text;
            if (mbed.ShowBedInfo(bed))
            {
                textBox5.Text = bed.BID;
                textBox6.Text = bed.DName;
                textBox7.Text = bed.State;
                //textBox8.Text = bed.PatientID.ToString();
            }
            else
            {
                MessageBox.Show("查无此床位");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bed.BID = textBox5.Text;
            MessageBox.Show(mbed.DeleteBed(bed));
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void btnSelectBedID3_Click(object sender, EventArgs e)
        {
            bed.BID = txBedID3.Text;
            if (mbed.ShowBedInfo(bed))
            {
                comboBox4.SelectedItem = bed.DName;
                comboBox3.SelectedItem = bed.State;
            }
            else {
                MessageBox.Show("没有此床位");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bed.BID = txBedID3.Text;
            bed.DName = comboBox4.SelectedItem.ToString();
            bed.State = comboBox3.SelectedItem.ToString();
            MessageBox.Show(mbed.UpdateBed(bed));
        }

        private void btnSelectP_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            patient.PatientID = int.Parse(txPatientID.Text);
            Patientinfo patientinfo = new Patientinfo();
            if (patientinfo.FindPatient(patient))
            {
                txBedID.Text = patient.BID;
                txOffice.Text = patient.DName;
            }
            else
            {
                MessageBox.Show("此病例不存在");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            patient.PatientID = int.Parse(txPatientID.Text);
            patient.BID = txBedID.Text ;
            patient.DName=txOffice.Text ;
            Patientinfo patientinfo = new Patientinfo();
            if (patientinfo.UpdatePatient(patient))
            {
                MessageBox.Show("修改成功");
            }
            else {
                MessageBox.Show("修改失败");
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = mbed.Showall();
        }
    }
}
