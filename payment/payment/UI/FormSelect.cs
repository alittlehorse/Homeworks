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
using payment.BLL.statistics;
using payment.BLL.BedManagement;
using payment.BLL.PatientInfo;


namespace payment.UI
{
	public partial class FormSelect : Form
	{
		public FormSelect()
		{
			InitializeComponent();
		}

        private void btnSelectState_Click(object sender, EventArgs e)
        {
            Bed bed = new Bed();
            bed.DName = comboBox1.SelectedItem.ToString();
            MBed mbed = new MBed();
            dataGridView1.DataSource = mbed.ShowBedInfoByDName(bed);
    }

		private void btnPrintRecord_Click(object sender, EventArgs e)
		{

		}

        private void FormSelect_Load(object sender, EventArgs e)
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

        private void btnSelectP1_Click(object sender, EventArgs e)
        {
            Patients patient = new Patients();
            patient.PatientID = int.Parse(txPatientID1.Text);

            Patientinfo pi = new Patientinfo();
            if (pi.FindPatient(patient))
            {
                txName.Text = patient.PatienName;
                txIDNum.Text = patient.IDNumber;
                txAge.Text = patient.Age.ToString();
                txTell.Text = patient.Phone;
                if (patient.Sex == "男")
                {
                    rdbtnM.Checked = true;
                }
                else
                {
                    rdbtnF.Checked = true;
                }
                Content con = new Content();
                con.PatientID = patient.PatientID;
                ManagmentOfContent mcon = new ManagmentOfContent();
                
                dataGridView2.DataSource= mcon.ShowContent(con);
            }
            else
            {
                MessageBox.Show("查无此病例");
            }
            
        }

        private void btnSelectP2_Click(object sender, EventArgs e)
        {
            Prepaid prepaid = new Prepaid();
            Fee fee = new Fee();
            fee.PatientID = int.Parse(txPatientID2.Text);
            if (prepaid.ShowFee(fee))
            {
                dataGridView3.DataSource = fee.FeeTable;
            }
            else
            {
                MessageBox.Show("本日没有交费项目");
            }
        }

        private void btnSelectP3_Click(object sender, EventArgs e)
        {
            Bed bed = new Bed();
            bed.PatientID = int.Parse(txPatientID3.Text);
            MBed mbed = new MBed();
            if (mbed.ShowBedInfoByPID(bed).Rows.Count > 0)
            {
                textBox1.Text = bed.BID;
                textBox2.Text = bed.DName;
                textBox3.Text = bed.State;
            }
            else
            {
                MessageBox.Show("此病例无床位或没有此病例");
            }
        }
    }
    
}
