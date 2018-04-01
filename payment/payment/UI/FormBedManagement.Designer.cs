namespace payment.UI
{
	partial class FormBedManagement
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
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.InsertBedPage = new System.Windows.Forms.TabPage();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnAddBed = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txBedID1 = new System.Windows.Forms.TextBox();
			this.DeleteBedPage = new System.Windows.Forms.TabPage();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSelectBedID1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txBedID2 = new System.Windows.Forms.TextBox();
			this.IndentifyingBedPage = new System.Windows.Forms.TabPage();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.btnUpdateBed = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnSelectBedID3 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.txBedID3 = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txOffice = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txBedID = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.btnSelectP = new System.Windows.Forms.Button();
			this.txPatientID = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnPrintDay = new System.Windows.Forms.Button();
			this.btnSelectAll = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label19 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label18 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.InsertBedPage.SuspendLayout();
			this.DeleteBedPage.SuspendLayout();
			this.IndentifyingBedPage.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(681, 388);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tabControl2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage1.Size = new System.Drawing.Size(673, 362);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "床位管理";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.InsertBedPage);
			this.tabControl2.Controls.Add(this.DeleteBedPage);
			this.tabControl2.Controls.Add(this.IndentifyingBedPage);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl2.Location = new System.Drawing.Point(3, 3);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(667, 361);
			this.tabControl2.TabIndex = 8;
			this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
			// 
			// InsertBedPage
			// 
			this.InsertBedPage.Controls.Add(this.comboBox2);
			this.InsertBedPage.Controls.Add(this.comboBox1);
			this.InsertBedPage.Controls.Add(this.btnAddBed);
			this.InsertBedPage.Controls.Add(this.label3);
			this.InsertBedPage.Controls.Add(this.label2);
			this.InsertBedPage.Controls.Add(this.label1);
			this.InsertBedPage.Controls.Add(this.txBedID1);
			this.InsertBedPage.Location = new System.Drawing.Point(4, 22);
			this.InsertBedPage.Name = "InsertBedPage";
			this.InsertBedPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.InsertBedPage.Size = new System.Drawing.Size(659, 335);
			this.InsertBedPage.TabIndex = 0;
			this.InsertBedPage.Text = "增加";
			this.InsertBedPage.UseVisualStyleBackColor = true;
			this.InsertBedPage.Click += new System.EventHandler(this.tabPage4_Click);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "普通床位",
            "重症床位"});
			this.comboBox2.Location = new System.Drawing.Point(283, 173);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(128, 20);
			this.comboBox2.TabIndex = 17;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(283, 120);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(128, 20);
			this.comboBox1.TabIndex = 16;
			// 
			// btnAddBed
			// 
			this.btnAddBed.Location = new System.Drawing.Point(301, 232);
			this.btnAddBed.Name = "btnAddBed";
			this.btnAddBed.Size = new System.Drawing.Size(88, 30);
			this.btnAddBed.TabIndex = 15;
			this.btnAddBed.Text = "增加床位";
			this.btnAddBed.UseVisualStyleBackColor = true;
			this.btnAddBed.Click += new System.EventHandler(this.btnAddBed_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(207, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 12;
			this.label3.Text = "所属部门：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(207, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 11;
			this.label2.Text = "床位属性：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(219, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "床位号：";
			// 
			// txBedID1
			// 
			this.txBedID1.Location = new System.Drawing.Point(283, 66);
			this.txBedID1.Name = "txBedID1";
			this.txBedID1.Size = new System.Drawing.Size(128, 21);
			this.txBedID1.TabIndex = 8;
			// 
			// DeleteBedPage
			// 
			this.DeleteBedPage.Controls.Add(this.textBox8);
			this.DeleteBedPage.Controls.Add(this.label11);
			this.DeleteBedPage.Controls.Add(this.btnDelete);
			this.DeleteBedPage.Controls.Add(this.textBox6);
			this.DeleteBedPage.Controls.Add(this.textBox7);
			this.DeleteBedPage.Controls.Add(this.label7);
			this.DeleteBedPage.Controls.Add(this.label8);
			this.DeleteBedPage.Controls.Add(this.label6);
			this.DeleteBedPage.Controls.Add(this.textBox5);
			this.DeleteBedPage.Controls.Add(this.label5);
			this.DeleteBedPage.Controls.Add(this.btnSelectBedID1);
			this.DeleteBedPage.Controls.Add(this.label4);
			this.DeleteBedPage.Controls.Add(this.txBedID2);
			this.DeleteBedPage.Location = new System.Drawing.Point(4, 22);
			this.DeleteBedPage.Name = "DeleteBedPage";
			this.DeleteBedPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.DeleteBedPage.Size = new System.Drawing.Size(659, 335);
			this.DeleteBedPage.TabIndex = 1;
			this.DeleteBedPage.Text = "删除";
			this.DeleteBedPage.UseVisualStyleBackColor = true;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(270, 248);
			this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(128, 21);
			this.textBox8.TabIndex = 22;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(194, 250);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 12);
			this.label11.TabIndex = 21;
			this.label11.Text = "所住病人：";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(296, 297);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 20;
			this.btnDelete.Text = "确认删除";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(270, 169);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(128, 21);
			this.textBox6.TabIndex = 19;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(270, 206);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(128, 21);
			this.textBox7.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(195, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 12);
			this.label7.TabIndex = 17;
			this.label7.Text = "所属部门：";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(194, 209);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 12);
			this.label8.TabIndex = 16;
			this.label8.Text = "床位属性：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(206, 131);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 15;
			this.label6.Text = "床位号：";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(270, 129);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(128, 21);
			this.textBox5.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(194, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 12);
			this.label5.TabIndex = 13;
			this.label5.Text = "信息如下：";
			// 
			// btnSelectBedID1
			// 
			this.btnSelectBedID1.Location = new System.Drawing.Point(429, 46);
			this.btnSelectBedID1.Name = "btnSelectBedID1";
			this.btnSelectBedID1.Size = new System.Drawing.Size(75, 23);
			this.btnSelectBedID1.TabIndex = 12;
			this.btnSelectBedID1.Text = "查询";
			this.btnSelectBedID1.UseVisualStyleBackColor = true;
			this.btnSelectBedID1.Click += new System.EventHandler(this.btnSelectBedID1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(206, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 11;
			this.label4.Text = "床位号：";
			// 
			// txBedID2
			// 
			this.txBedID2.Location = new System.Drawing.Point(270, 46);
			this.txBedID2.Name = "txBedID2";
			this.txBedID2.Size = new System.Drawing.Size(128, 21);
			this.txBedID2.TabIndex = 10;
			// 
			// IndentifyingBedPage
			// 
			this.IndentifyingBedPage.Controls.Add(this.comboBox3);
			this.IndentifyingBedPage.Controls.Add(this.comboBox4);
			this.IndentifyingBedPage.Controls.Add(this.btnUpdateBed);
			this.IndentifyingBedPage.Controls.Add(this.label9);
			this.IndentifyingBedPage.Controls.Add(this.label10);
			this.IndentifyingBedPage.Controls.Add(this.label12);
			this.IndentifyingBedPage.Controls.Add(this.btnSelectBedID3);
			this.IndentifyingBedPage.Controls.Add(this.label13);
			this.IndentifyingBedPage.Controls.Add(this.txBedID3);
			this.IndentifyingBedPage.Location = new System.Drawing.Point(4, 22);
			this.IndentifyingBedPage.Name = "IndentifyingBedPage";
			this.IndentifyingBedPage.Size = new System.Drawing.Size(659, 335);
			this.IndentifyingBedPage.TabIndex = 2;
			this.IndentifyingBedPage.Text = "定义";
			this.IndentifyingBedPage.UseVisualStyleBackColor = true;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "普通床位",
            "重症床位"});
			this.comboBox3.Location = new System.Drawing.Point(264, 177);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(128, 20);
			this.comboBox3.TabIndex = 33;
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(264, 135);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(128, 20);
			this.comboBox4.TabIndex = 32;
			// 
			// btnUpdateBed
			// 
			this.btnUpdateBed.Location = new System.Drawing.Point(283, 246);
			this.btnUpdateBed.Name = "btnUpdateBed";
			this.btnUpdateBed.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateBed.TabIndex = 31;
			this.btnUpdateBed.Text = "确认修改";
			this.btnUpdateBed.UseVisualStyleBackColor = true;
			this.btnUpdateBed.Click += new System.EventHandler(this.button4_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(193, 138);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 12);
			this.label9.TabIndex = 28;
			this.label9.Text = "所属部门：";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(188, 180);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 12);
			this.label10.TabIndex = 27;
			this.label10.Text = "床位属性：";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(188, 92);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 12);
			this.label12.TabIndex = 24;
			this.label12.Text = "信息如下：";
			// 
			// btnSelectBedID3
			// 
			this.btnSelectBedID3.Location = new System.Drawing.Point(423, 39);
			this.btnSelectBedID3.Name = "btnSelectBedID3";
			this.btnSelectBedID3.Size = new System.Drawing.Size(75, 23);
			this.btnSelectBedID3.TabIndex = 23;
			this.btnSelectBedID3.Text = "查询";
			this.btnSelectBedID3.UseVisualStyleBackColor = true;
			this.btnSelectBedID3.Click += new System.EventHandler(this.btnSelectBedID3_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(200, 42);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 12);
			this.label13.TabIndex = 22;
			this.label13.Text = "床位号：";
			// 
			// txBedID3
			// 
			this.txBedID3.Location = new System.Drawing.Point(264, 39);
			this.txBedID3.Name = "txBedID3";
			this.txBedID3.Size = new System.Drawing.Size(128, 21);
			this.txBedID3.TabIndex = 21;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnUpdate);
			this.tabPage2.Controls.Add(this.txOffice);
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.txBedID);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.btnSelectP);
			this.tabPage2.Controls.Add(this.txPatientID);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage2.Size = new System.Drawing.Size(673, 362);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "转床管理";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(269, 261);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(81, 29);
			this.btnUpdate.TabIndex = 8;
			this.btnUpdate.Text = "确认修改";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txOffice
			// 
			this.txOffice.Location = new System.Drawing.Point(256, 192);
			this.txOffice.Name = "txOffice";
			this.txOffice.Size = new System.Drawing.Size(111, 21);
			this.txOffice.TabIndex = 7;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(185, 195);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(65, 12);
			this.label17.TabIndex = 6;
			this.label17.Text = "所属科室：";
			// 
			// txBedID
			// 
			this.txBedID.Location = new System.Drawing.Point(256, 150);
			this.txBedID.Name = "txBedID";
			this.txBedID.Size = new System.Drawing.Size(111, 21);
			this.txBedID.TabIndex = 5;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(197, 153);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(53, 12);
			this.label16.TabIndex = 4;
			this.label16.Text = "床位号：";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(197, 117);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(113, 12);
			this.label15.TabIndex = 3;
			this.label15.Text = "病人详细信息如下：";
			// 
			// btnSelectP
			// 
			this.btnSelectP.Location = new System.Drawing.Point(399, 70);
			this.btnSelectP.Name = "btnSelectP";
			this.btnSelectP.Size = new System.Drawing.Size(75, 28);
			this.btnSelectP.TabIndex = 2;
			this.btnSelectP.Text = "查询";
			this.btnSelectP.UseVisualStyleBackColor = true;
			this.btnSelectP.Click += new System.EventHandler(this.btnSelectP_Click);
			// 
			// txPatientID
			// 
			this.txPatientID.Location = new System.Drawing.Point(255, 75);
			this.txPatientID.Name = "txPatientID";
			this.txPatientID.Size = new System.Drawing.Size(111, 21);
			this.txPatientID.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(196, 78);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(53, 12);
			this.label14.TabIndex = 0;
			this.label14.Text = "病历号：";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnPrintDay);
			this.tabPage3.Controls.Add(this.btnSelectAll);
			this.tabPage3.Controls.Add(this.dataGridView1);
			this.tabPage3.Controls.Add(this.label19);
			this.tabPage3.Controls.Add(this.dateTimePicker1);
			this.tabPage3.Controls.Add(this.label18);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage3.Size = new System.Drawing.Size(673, 362);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "床位日报表";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// btnPrintDay
			// 
			this.btnPrintDay.Location = new System.Drawing.Point(297, 328);
			this.btnPrintDay.Name = "btnPrintDay";
			this.btnPrintDay.Size = new System.Drawing.Size(75, 23);
			this.btnPrintDay.TabIndex = 5;
			this.btnPrintDay.Text = "打印报表";
			this.btnPrintDay.UseVisualStyleBackColor = true;
			// 
			// btnSelectAll
			// 
			this.btnSelectAll.Location = new System.Drawing.Point(269, 27);
			this.btnSelectAll.Name = "btnSelectAll";
			this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
			this.btnSelectAll.TabIndex = 4;
			this.btnSelectAll.Text = "查询";
			this.btnSelectAll.UseVisualStyleBackColor = true;
			this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(64, 88);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(550, 212);
			this.dataGridView1.TabIndex = 3;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(8, 73);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(65, 12);
			this.label19.TabIndex = 2;
			this.label19.Text = "查询结果：";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(79, 27);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(152, 21);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(8, 33);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(65, 12);
			this.label18.TabIndex = 0;
			this.label18.Text = "查询日期：";
			// 
			// FormBedManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 385);
			this.Controls.Add(this.tabControl1);
			this.Name = "FormBedManagement";
			this.Text = "FormBedManagement";
			this.Load += new System.EventHandler(this.FormBedManagement_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.InsertBedPage.ResumeLayout(false);
			this.InsertBedPage.PerformLayout();
			this.DeleteBedPage.ResumeLayout(false);
			this.DeleteBedPage.PerformLayout();
			this.IndentifyingBedPage.ResumeLayout(false);
			this.IndentifyingBedPage.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage InsertBedPage;
		private System.Windows.Forms.Button btnAddBed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txBedID1;
		private System.Windows.Forms.TabPage DeleteBedPage;
		private System.Windows.Forms.TabPage IndentifyingBedPage;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button btnSelectBedID1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txBedID2;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnUpdateBed;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnSelectBedID3;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txBedID3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txOffice;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txBedID;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnSelectP;
		private System.Windows.Forms.TextBox txPatientID;
		private System.Windows.Forms.Button btnPrintDay;
		private System.Windows.Forms.Button btnSelectAll;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
    }
}