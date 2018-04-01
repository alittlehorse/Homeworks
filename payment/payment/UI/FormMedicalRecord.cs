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
	public partial class FormMedicalRecord : Form
	{
		public FormMedicalRecord()
		{
			InitializeComponent();
		}

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            
            Content content = new Content();
            

            content.Time = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            // medicalRecordInfo.Date = dateTimePicker1.Text.ToString();
            if (richTextBox1.Text == "")
                MessageBox.Show("治疗内容为空");
            else
            content.Treatment = richTextBox1.Text;
            if (txDoctor.Text == "")
                MessageBox.Show("医生名为空");
            else
            content.Doctor = txDoctor.Text;

            
            if ( content.Treatment == "" && content.Doctor == "")
                MessageBox.Show("某值为空，不能插入");
         
            else
            {
                AddMedicalRecord addMedicalRecord = new AddMedicalRecord();
                if (addMedicalRecord.AddContentInfo(content))
                    MessageBox.Show("插入成功");
                else
                    MessageBox.Show("插入失败");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            Content content = new Content();
            content.PatientID = int.Parse(txPatientID.Text);
            patients.PatientID = int.Parse(txPatientID.Text);
            AddMedicalRecord addMedicalRecord = new AddMedicalRecord();
            addMedicalRecord.SelectContentInfo(patients);
            txPatientID.Text = patients.PatientID.ToString();
            txName.Text = patients.PatienName;
            if (patients.Sex == "男")
                rdbtnM.Checked = true;
            else if (patients.Sex == "女")
                rdbtnF.Checked = true;
            txTell.Text = patients.Phone;
            txAge.Text = patients.Age.ToString() ;
            txIDNum.Text = patients.IDNumber;

                


        }
    }
}