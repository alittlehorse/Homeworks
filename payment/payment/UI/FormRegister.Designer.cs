namespace payment.UI
{
	partial class FormRegister
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
			this.txRegPwd1 = new System.Windows.Forms.TextBox();
			this.txRegName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txRegPwd2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txRegPwd1
			// 
			this.txRegPwd1.Location = new System.Drawing.Point(178, 86);
			this.txRegPwd1.Name = "txRegPwd1";
			this.txRegPwd1.PasswordChar = '*';
			this.txRegPwd1.Size = new System.Drawing.Size(188, 21);
			this.txRegPwd1.TabIndex = 9;
			// 
			// txRegName
			// 
			this.txRegName.Location = new System.Drawing.Point(178, 42);
			this.txRegName.Name = "txRegName";
			this.txRegName.Size = new System.Drawing.Size(188, 21);
			this.txRegName.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(98, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "输入密码：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(110, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "用户名：";
			// 
			// txRegPwd2
			// 
			this.txRegPwd2.Location = new System.Drawing.Point(178, 132);
			this.txRegPwd2.Name = "txRegPwd2";
			this.txRegPwd2.PasswordChar = '*';
			this.txRegPwd2.Size = new System.Drawing.Size(188, 21);
			this.txRegPwd2.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "再次输入密码：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(98, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 12;
			this.label4.Text = "注册类型：";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(178, 178);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(188, 20);
			this.comboBox1.TabIndex = 13;
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(189, 237);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(105, 31);
			this.btnRegister.TabIndex = 14;
			this.btnRegister.Text = "确定";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// FormRegister
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 306);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txRegPwd2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txRegPwd1);
			this.Controls.Add(this.txRegName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormRegister";
			this.Text = "FormRegister";
			this.Load += new System.EventHandler(this.FormRegister_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txRegPwd1;
		private System.Windows.Forms.TextBox txRegName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txRegPwd2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button btnRegister;
	}
}