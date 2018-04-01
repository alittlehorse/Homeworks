namespace payment.UI
{
	partial class FormLogin
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.txName = new System.Windows.Forms.TextBox();
			this.txPwd = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(132, 183);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(82, 32);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "登录";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(92, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "用户名：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(104, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "密码：";
			// 
			// btnRegister
			// 
			this.btnRegister.Location = new System.Drawing.Point(243, 183);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(82, 32);
			this.btnRegister.TabIndex = 3;
			this.btnRegister.Text = "注册";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// txName
			// 
			this.txName.Location = new System.Drawing.Point(160, 77);
			this.txName.Name = "txName";
			this.txName.Size = new System.Drawing.Size(189, 21);
			this.txName.TabIndex = 4;
			// 
			// txPwd
			// 
			this.txPwd.Location = new System.Drawing.Point(160, 121);
			this.txPwd.Name = "txPwd";
			this.txPwd.PasswordChar = '*';
			this.txPwd.Size = new System.Drawing.Size(188, 21);
			this.txPwd.TabIndex = 5;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 294);
			this.Controls.Add(this.txPwd);
			this.Controls.Add(this.txName);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLogin);
			this.Name = "FormLogin";
			this.Text = "FormLogin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox txName;
		private System.Windows.Forms.TextBox txPwd;
	}
}