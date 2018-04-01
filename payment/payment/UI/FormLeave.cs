using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using NPOI.HSSF.UserModel;
//using NPOI.XSSF.UserModel;
using System.Drawing.Printing;
using System.Data.SqlClient;
using payment.BLL;

namespace payment.UI
{
	public partial class FormLeave : Form
	{
		public FormLeave()
		{
			InitializeComponent();
		}

        private void btnLeave_Click(object sender, EventArgs e)
        {
            LeaveInfo leaveInfo = new LeaveInfo();
            leaveInfo.PatientID = int.Parse(txPatientID.Text);
            leaveInfo.Date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            leaveInfo.BedNumber = int.Parse(txBedID.Text);
            AddLeavePatient addLeavePatient = new AddLeavePatient();
            if (addLeavePatient.AddInfo(leaveInfo))
                MessageBox.Show("插入成功");
            else
                MessageBox.Show("插入失败");
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            AddLeavePatient addLeavePatient = new AddLeavePatient();
            if (addLeavePatient.FindLeaveInfo())
            {
                dataGridView1.DataSource = LeaveInfo.LeaveTable;
            }
            else
            {
                MessageBox.Show("此用户没有费用记录");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font tabelTextFont = new System.Drawing.Font("宋体", 10);
            if (dataGridView1.DataBindings != null)
            {

                int[] columnsWidth = new int[dataGridView1.Columns.Count];
                //得到所有列的个数
                int[] columnsLeft = new int[dataGridView1.Columns.Count];
                for (int c = 0; c < columnsWidth.Length; c++)
                //得到列标题的宽度
                {
                    columnsWidth[c] = (int)(e.Graphics.MeasureString(dataGridView1.Columns[c].HeaderText, tabelTextFont).Width)+100;
                }


                for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)
                //C#打印控件的使用之rowindex当前行
                {
                    for (int columnIndex = 0; columnIndex < dataGridView1.Columns.Count; columnIndex++)
                    //C#打印控件的使用之当前列
                    {
                        int w = (int)e.Graphics.MeasureString(
                        dataGridView1.Columns[columnIndex].Name,
                        tabelTextFont).Width;
                        columnsWidth[columnIndex] = w > columnsWidth[columnIndex] ? w : columnsWidth[columnIndex];
                    }
                }//C#打印控件的使用
                int rowHidth = 20;
                int tableLeft = 60;
                int tableTop = 70;
                columnsLeft[0] = tableLeft;
                for (int i = 1; i <= columnsWidth.Length - 1; i++)
                {
                    columnsLeft[i] = columnsLeft[i - 1] + columnsWidth[i - 1] + 30;
                }
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;//居中打印
                                                      // e.Graphics.DrawString("欢迎医学信息工程专业同学!",
                                                      // new Font("宋体", 15), Brushes.Black, new Point(
                                                      // e.PageBounds.Width / 2, 20), sf);//打印标题
                for (int c = 0; c < columnsWidth.Length; c++)
                //打印表中的列名
                {
                    e.Graphics.DrawString(dataGridView1.Columns[c].HeaderText,
                    new System.Drawing.Font("宋体", 10, FontStyle.Bold),
                    Brushes.Black, new System.Drawing.Point(columnsLeft[c], tableTop));
                    e.Graphics.DrawLine(Pens.Black,
                    new System.Drawing.Point(columnsLeft[c] - 5, tableTop - 5),
                    new System.Drawing.Point(columnsLeft[c] - 5, tableTop +
                    (dataGridView1.Rows.Count + 1) * rowHidth));
                }//C#打印控件的使用
                e.Graphics.DrawLine(Pens.Black,
                new System.Drawing.Point(columnsLeft[dataGridView1.Columns.Count - 1] +
                columnsWidth[dataGridView1.Columns.Count - 1],
                tableTop - 5), new System.Drawing.Point(columnsLeft[dataGridView1.Columns.Count - 1] +
                columnsWidth[dataGridView1.Columns.Count - 1],
                tableTop + (dataGridView1.Rows.Count + 1) * rowHidth));
                //画最后面的线
                e.Graphics.DrawLine(Pens.Black, new System.Drawing.Point(columnsLeft[0] - 5,
                tableTop - 5), new System.Drawing.Point(columnsLeft[dataGridView1.Columns.Count - 1] +
                columnsWidth[dataGridView1.Columns.Count - 1], tableTop - 5));
           
                for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)//打印表中的内容
                {
                    for (int columnIndex = 0; columnIndex < dataGridView1.Columns.Count; columnIndex++)
                    {
                        e.Graphics.DrawString(
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString(),
                        tabelTextFont, Brushes.Black, new System.Drawing.Point(columnsLeft[columnIndex],
                        tableTop + rowHidth * (rowIndex + 1)));
                    }

                    e.Graphics.DrawLine(Pens.Black,
                    new System.Drawing.Point(columnsLeft[0] - 5,
                    tableTop + (rowIndex + 1) * rowHidth - 5),
                    new System.Drawing.Point(columnsLeft[dataGridView1.Columns.Count - 1] +
                    columnsWidth[dataGridView1.Columns.Count - 1], tableTop +
                    (rowIndex + 1) * rowHidth - 5));//循环画行
                }

                //C#打印控件的使用之
            }
        
        }
        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            printDocument1.Print();
        }
    }
}
