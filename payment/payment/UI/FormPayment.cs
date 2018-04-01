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

namespace payment.UI
{
	public partial class FormPayment : Form
	{
		public FormPayment()
		{
			InitializeComponent();
		}

        private void btnPrepay_Click(object sender, EventArgs e)
        {
            PrepaidPayment prepaidpayment = new PrepaidPayment();
            prepaidpayment.PatientID = int.Parse(txPatientID1.Text);
            prepaidpayment.Prepay = int.Parse(txPrepay.Text);
            prepaidpayment.Time = dateTimePicker1.Value.ToString("yyyy-MM-dd"); 
            Prepaid prepaid = new Prepaid();
            if (prepaid.Pay(prepaidpayment))
            {
                MessageBox.Show("缴费'" + prepaidpayment.Prepay + "'元成功");
            }
            else
            {
                MessageBox.Show("缴费失败");
            }
        }

        private void btnSelectFee_Click(object sender, EventArgs e)
        {
            Fee fee = new Fee();
            Balance balance = new Balance();
            //显示余额
            balance.PatientID =int.Parse( txPatientID2.Text);
            Prepaid prepaid = new Prepaid();
            if (prepaid.FindBalance(balance))
            {
                txBalance1.Text = balance.BalanceMoney.ToString();
            }
            else
            {
                 MessageBox.Show("查无此病例");
            }
            //PrintFeeByDate
            fee.PatientID = int.Parse(txPatientID2.Text);
            fee.Time = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            if (prepaid.ShowFeeByDate(fee))
            {
                dataGridView1.DataSource = fee.FeeTable;
            }
            else
            {
                MessageBox.Show("本日没有交费项目");
            }
        }
        /// <summary>
        /// 查询一个人的余额和预交金记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectOne1_Click(object sender, EventArgs e)
        { 
            Balance balance = new Balance();
            PrepaidPayment prepaidpayment = new PrepaidPayment();
            //显示余额
            balance.PatientID = int.Parse(txPatientID3.Text);
            Prepaid prepaid = new Prepaid();
            if (prepaid.FindBalance(balance))
            {
                txBalance2.Text = balance.BalanceMoney.ToString();
            }
            else
            {
                MessageBox.Show("查无此病例");
            }
            //find PrepaidPayment by PatinetID
            prepaidpayment.PatientID = int.Parse(txPatientID3.Text);
            dataGridView2.DataSource=prepaid.FindPrepaidPaymentByPID(prepaidpayment);
            
        }

        private void btnSelectAll1_Click(object sender, EventArgs e)
        {
            Prepaid prepaid = new Prepaid();
            dataGridView2.DataSource= prepaid.FindALlPrepaidPayment();
        }

        private void btnSelectOne2_Click(object sender, EventArgs e)
        {
            PrepaidPayment prepaidpayment = new PrepaidPayment();
            Prepaid prepaid = new Prepaid();
            prepaidpayment.PatientID = int.Parse(txPatientID4.Text);
            dataGridView3.DataSource = prepaid.FindPrepaidPaymentByPID(prepaidpayment);
        }

        private void btnSelectAll2_Click(object sender, EventArgs e)
        {
            Prepaid prepaid = new Prepaid();
            dataGridView2.DataSource = prepaid.FindALlPrepaidPayment();
        }
    }
}
