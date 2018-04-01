namespace payment.UI
{
	partial class FormPermission
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAgree = new System.Windows.Forms.Button();
			this.btnReject = new System.Windows.Forms.Button();
			this.rdBtnF = new System.Windows.Forms.RadioButton();
			this.rdBtnM = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txTell = new System.Windows.Forms.TextBox();
			this.txAge = new System.Windows.Forms.TextBox();
			this.txName = new System.Windows.Forms.TextBox();
			this.txIDNum = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(152, 57);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(154, 20);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "请选择：";
			// 
			// btnAgree
			// 
			this.btnAgree.Location = new System.Drawing.Point(93, 356);
			this.btnAgree.Name = "btnAgree";
			this.btnAgree.Size = new System.Drawing.Size(75, 23);
			this.btnAgree.TabIndex = 2;
			this.btnAgree.Text = "允许入院";
			this.btnAgree.UseVisualStyleBackColor = true;
			this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
			// 
			// btnReject
			// 
			this.btnReject.Location = new System.Drawing.Point(231, 356);
			this.btnReject.Name = "btnReject";
			this.btnReject.Size = new System.Drawing.Size(75, 23);
			this.btnReject.TabIndex = 3;
			this.btnReject.Text = "不予入院";
			this.btnReject.UseVisualStyleBackColor = true;
			this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
			// 
			// rdBtnF
			// 
			this.rdBtnF.AutoSize = true;
			this.rdBtnF.Location = new System.Drawing.Point(212, 191);
			this.rdBtnF.Name = "rdBtnF";
			this.rdBtnF.Size = new System.Drawing.Size(35, 16);
			this.rdBtnF.TabIndex = 23;
			this.rdBtnF.TabStop = true;
			this.rdBtnF.Text = "女";
			this.rdBtnF.UseVisualStyleBackColor = true;
			// 
			// rdBtnM
			// 
			this.rdBtnM.AutoSize = true;
			this.rdBtnM.Location = new System.Drawing.Point(152, 191);
			this.rdBtnM.Name = "rdBtnM";
			this.rdBtnM.Size = new System.Drawing.Size(35, 16);
			this.rdBtnM.TabIndex = 22;
			this.rdBtnM.TabStop = true;
			this.rdBtnM.Text = "男";
			this.rdBtnM.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(71, 285);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 12);
			this.label5.TabIndex = 21;
			this.label5.Text = "电话号码：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(95, 240);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 20;
			this.label4.Text = "年龄：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(95, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 19;
			this.label3.Text = "性别：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 18;
			this.label2.Text = "姓名：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(59, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 12);
			this.label6.TabIndex = 17;
			this.label6.Text = "身份证号码：";
			// 
			// txTell
			// 
			this.txTell.Location = new System.Drawing.Point(152, 282);
			this.txTell.Name = "txTell";
			this.txTell.Size = new System.Drawing.Size(154, 21);
			this.txTell.TabIndex = 16;
			// 
			// txAge
			// 
			this.txAge.Location = new System.Drawing.Point(152, 237);
			this.txAge.Name = "txAge";
			this.txAge.Size = new System.Drawing.Size(154, 21);
			this.txAge.TabIndex = 15;
			// 
			// txName
			// 
			this.txName.Location = new System.Drawing.Point(152, 145);
			this.txName.Name = "txName";
			this.txName.Size = new System.Drawing.Size(154, 21);
			this.txName.TabIndex = 14;
			// 
			// txIDNum
			// 
			this.txIDNum.Location = new System.Drawing.Point(152, 98);
			this.txIDNum.Name = "txIDNum";
			this.txIDNum.Size = new System.Drawing.Size(154, 21);
			this.txIDNum.TabIndex = 13;
			// 
			// FormPermission
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 445);
			this.Controls.Add(this.rdBtnF);
			this.Controls.Add(this.rdBtnM);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txTell);
			this.Controls.Add(this.txAge);
			this.Controls.Add(this.txName);
			this.Controls.Add(this.txIDNum);
			this.Controls.Add(this.btnReject);
			this.Controls.Add(this.btnAgree);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Name = "FormPermission";
			this.Text = "FormPermission";
			this.Load += new System.EventHandler(this.FormRegister_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAgree;
		private System.Windows.Forms.Button btnReject;
		private System.Windows.Forms.RadioButton rdBtnF;
		private System.Windows.Forms.RadioButton rdBtnM;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txTell;
		private System.Windows.Forms.TextBox txAge;
		private System.Windows.Forms.TextBox txName;
		private System.Windows.Forms.TextBox txIDNum;
	}
}