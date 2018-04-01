namespace payment.UI
{
	partial class FormPayment
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnPrepay = new System.Windows.Forms.Button();
            this.txPrepay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txPatientID1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrintToday = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txBalance1 = new System.Windows.Forms.TextBox();
            this.txPatientID2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnSelectFee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrintAll1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSelectAll1 = new System.Windows.Forms.Button();
            this.btnSelectOne1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txBalance2 = new System.Windows.Forms.TextBox();
            this.txPatientID3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnPrintAll2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelectAll2 = new System.Windows.Forms.Button();
            this.btnSelectOne2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txPatientID4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPrintBill);
            this.tabPage1.Controls.Add(this.btnPrepay);
            this.tabPage1.Controls.Add(this.txPrepay);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txPatientID1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(721, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "预交金交纳";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Location = new System.Drawing.Point(288, 302);
            this.btnPrintBill.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(131, 35);
            this.btnPrintBill.TabIndex = 7;
            this.btnPrintBill.Text = "打印凭证";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            // 
            // btnPrepay
            // 
            this.btnPrepay.Location = new System.Drawing.Point(288, 230);
            this.btnPrepay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrepay.Name = "btnPrepay";
            this.btnPrepay.Size = new System.Drawing.Size(131, 35);
            this.btnPrepay.TabIndex = 6;
            this.btnPrepay.Text = "确定缴纳";
            this.btnPrepay.UseVisualStyleBackColor = true;
            this.btnPrepay.Click += new System.EventHandler(this.btnPrepay_Click);
            // 
            // txPrepay
            // 
            this.txPrepay.Location = new System.Drawing.Point(288, 168);
            this.txPrepay.Margin = new System.Windows.Forms.Padding(4);
            this.txPrepay.Name = "txPrepay";
            this.txPrepay.Size = new System.Drawing.Size(189, 25);
            this.txPrepay.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "交纳费用：";
            // 
            // txPatientID1
            // 
            this.txPatientID1.Location = new System.Drawing.Point(288, 64);
            this.txPatientID1.Margin = new System.Windows.Forms.Padding(4);
            this.txPatientID1.Name = "txPatientID1";
            this.txPatientID1.Size = new System.Drawing.Size(189, 25);
            this.txPatientID1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 114);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "缴费时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "病历号：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnPrintToday);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txBalance1);
            this.tabPage2.Controls.Add(this.txPatientID2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.btnSelectFee);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(721, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "预交金日结";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "该日费用明细：";
            // 
            // btnPrintToday
            // 
            this.btnPrintToday.Location = new System.Drawing.Point(383, 395);
            this.btnPrintToday.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintToday.Name = "btnPrintToday";
            this.btnPrintToday.Size = new System.Drawing.Size(91, 30);
            this.btnPrintToday.TabIndex = 9;
            this.btnPrintToday.Text = "打印清单";
            this.btnPrintToday.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(619, 186);
            this.dataGridView1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "余额：";
            // 
            // txBalance1
            // 
            this.txBalance1.Location = new System.Drawing.Point(160, 102);
            this.txBalance1.Margin = new System.Windows.Forms.Padding(4);
            this.txBalance1.Name = "txBalance1";
            this.txBalance1.Size = new System.Drawing.Size(251, 25);
            this.txBalance1.TabIndex = 6;
            // 
            // txPatientID2
            // 
            this.txPatientID2.Location = new System.Drawing.Point(160, 30);
            this.txPatientID2.Margin = new System.Windows.Forms.Padding(4);
            this.txPatientID2.Name = "txPatientID2";
            this.txPatientID2.Size = new System.Drawing.Size(251, 25);
            this.txPatientID2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "病历号：";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(160, 65);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(251, 25);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // btnSelectFee
            // 
            this.btnSelectFee.Location = new System.Drawing.Point(207, 395);
            this.btnSelectFee.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFee.Name = "btnSelectFee";
            this.btnSelectFee.Size = new System.Drawing.Size(91, 30);
            this.btnSelectFee.TabIndex = 2;
            this.btnSelectFee.Text = "查询";
            this.btnSelectFee.UseVisualStyleBackColor = true;
            this.btnSelectFee.Click += new System.EventHandler(this.btnSelectFee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择日期：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPrintAll1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnSelectAll1);
            this.tabPage3.Controls.Add(this.btnSelectOne1);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txBalance2);
            this.tabPage3.Controls.Add(this.txPatientID3);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(721, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "统计预交金";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPrintAll1
            // 
            this.btnPrintAll1.Location = new System.Drawing.Point(296, 394);
            this.btnPrintAll1.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintAll1.Name = "btnPrintAll1";
            this.btnPrintAll1.Size = new System.Drawing.Size(117, 39);
            this.btnPrintAll1.TabIndex = 10;
            this.btnPrintAll1.Text = "打印清单";
            this.btnPrintAll1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 201);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(679, 186);
            this.dataGridView2.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 168);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "查询结果：";
            // 
            // btnSelectAll1
            // 
            this.btnSelectAll1.Location = new System.Drawing.Point(425, 124);
            this.btnSelectAll1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectAll1.Name = "btnSelectAll1";
            this.btnSelectAll1.Size = new System.Drawing.Size(117, 39);
            this.btnSelectAll1.TabIndex = 7;
            this.btnSelectAll1.Text = "查询";
            this.btnSelectAll1.UseVisualStyleBackColor = true;
            this.btnSelectAll1.Click += new System.EventHandler(this.btnSelectAll1_Click);
            // 
            // btnSelectOne1
            // 
            this.btnSelectOne1.Location = new System.Drawing.Point(137, 124);
            this.btnSelectOne1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOne1.Name = "btnSelectOne1";
            this.btnSelectOne1.Size = new System.Drawing.Size(117, 39);
            this.btnSelectOne1.TabIndex = 6;
            this.btnSelectOne1.Text = "查询";
            this.btnSelectOne1.UseVisualStyleBackColor = true;
            this.btnSelectOne1.Click += new System.EventHandler(this.btnSelectOne1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "全部查询：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "余额：";
            // 
            // txBalance2
            // 
            this.txBalance2.Location = new System.Drawing.Point(107, 90);
            this.txBalance2.Margin = new System.Windows.Forms.Padding(4);
            this.txBalance2.Name = "txBalance2";
            this.txBalance2.Size = new System.Drawing.Size(195, 25);
            this.txBalance2.TabIndex = 3;
            // 
            // txPatientID3
            // 
            this.txPatientID3.Location = new System.Drawing.Point(107, 50);
            this.txPatientID3.Margin = new System.Windows.Forms.Padding(4);
            this.txPatientID3.Name = "txPatientID3";
            this.txPatientID3.Size = new System.Drawing.Size(195, 25);
            this.txPatientID3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "病历号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "单个查询：";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnPrintAll2);
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.btnSelectAll2);
            this.tabPage4.Controls.Add(this.btnSelectOne2);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.txPatientID4);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(721, 440);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "查询须交金";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnPrintAll2
            // 
            this.btnPrintAll2.Location = new System.Drawing.Point(296, 386);
            this.btnPrintAll2.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintAll2.Name = "btnPrintAll2";
            this.btnPrintAll2.Size = new System.Drawing.Size(117, 39);
            this.btnPrintAll2.TabIndex = 21;
            this.btnPrintAll2.Text = "打印清单";
            this.btnPrintAll2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(11, 175);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(700, 204);
            this.dataGridView3.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 142);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "查询结果：";
            // 
            // btnSelectAll2
            // 
            this.btnSelectAll2.Location = new System.Drawing.Point(421, 99);
            this.btnSelectAll2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectAll2.Name = "btnSelectAll2";
            this.btnSelectAll2.Size = new System.Drawing.Size(117, 39);
            this.btnSelectAll2.TabIndex = 18;
            this.btnSelectAll2.Text = "查询";
            this.btnSelectAll2.UseVisualStyleBackColor = true;
            this.btnSelectAll2.Click += new System.EventHandler(this.btnSelectAll2_Click);
            // 
            // btnSelectOne2
            // 
            this.btnSelectOne2.Location = new System.Drawing.Point(133, 99);
            this.btnSelectOne2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectOne2.Name = "btnSelectOne2";
            this.btnSelectOne2.Size = new System.Drawing.Size(117, 39);
            this.btnSelectOne2.TabIndex = 17;
            this.btnSelectOne2.Text = "查询";
            this.btnSelectOne2.UseVisualStyleBackColor = true;
            this.btnSelectOne2.Click += new System.EventHandler(this.btnSelectOne2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(383, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "全部查询：";
            // 
            // txPatientID4
            // 
            this.txPatientID4.Location = new System.Drawing.Point(103, 50);
            this.txPatientID4.Margin = new System.Windows.Forms.Padding(4);
            this.txPatientID4.Name = "txPatientID4";
            this.txPatientID4.Size = new System.Drawing.Size(195, 25);
            this.txPatientID4.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 54);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "病历号：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 12);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "单个查询：";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 469);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox txPatientID1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txPrepay;
		private System.Windows.Forms.Button btnPrepay;
		private System.Windows.Forms.Button btnPrintBill;
		private System.Windows.Forms.Button btnSelectFee;
		private System.Windows.Forms.TextBox txPatientID2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txBalance1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnPrintToday;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnSelectAll1;
		private System.Windows.Forms.Button btnSelectOne1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txBalance2;
		private System.Windows.Forms.TextBox txPatientID3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnPrintAll1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button btnPrintAll2;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnSelectAll2;
		private System.Windows.Forms.Button btnSelectOne2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txPatientID4;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
	}
}