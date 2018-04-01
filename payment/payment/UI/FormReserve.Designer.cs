namespace payment.UI
{
	partial class FormReserve
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
            this.txIDNum = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txAge = new System.Windows.Forms.TextBox();
            this.txTell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.rdBtnM = new System.Windows.Forms.RadioButton();
            this.rdBtnF = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txIDNum
            // 
            this.txIDNum.Location = new System.Drawing.Point(231, 64);
            this.txIDNum.Margin = new System.Windows.Forms.Padding(4);
            this.txIDNum.Name = "txIDNum";
            this.txIDNum.Size = new System.Drawing.Size(204, 25);
            this.txIDNum.TabIndex = 0;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(231, 122);
            this.txName.Margin = new System.Windows.Forms.Padding(4);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(204, 25);
            this.txName.TabIndex = 1;
            // 
            // txAge
            // 
            this.txAge.Location = new System.Drawing.Point(231, 238);
            this.txAge.Margin = new System.Windows.Forms.Padding(4);
            this.txAge.Name = "txAge";
            this.txAge.Size = new System.Drawing.Size(204, 25);
            this.txAge.TabIndex = 2;
            // 
            // txTell
            // 
            this.txTell.Location = new System.Drawing.Point(231, 294);
            this.txTell.Margin = new System.Windows.Forms.Padding(4);
            this.txTell.Name = "txTell";
            this.txTell.Size = new System.Drawing.Size(204, 25);
            this.txTell.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "身份证号码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "年龄：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "电话号码：";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(258, 390);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(123, 41);
            this.BtnRegister.TabIndex = 10;
            this.BtnRegister.Text = "预约登记";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // rdBtnM
            // 
            this.rdBtnM.AutoSize = true;
            this.rdBtnM.Location = new System.Drawing.Point(231, 180);
            this.rdBtnM.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnM.Name = "rdBtnM";
            this.rdBtnM.Size = new System.Drawing.Size(43, 19);
            this.rdBtnM.TabIndex = 11;
            this.rdBtnM.TabStop = true;
            this.rdBtnM.Text = "男";
            this.rdBtnM.UseVisualStyleBackColor = true;
            // 
            // rdBtnF
            // 
            this.rdBtnF.AutoSize = true;
            this.rdBtnF.Location = new System.Drawing.Point(311, 180);
            this.rdBtnF.Margin = new System.Windows.Forms.Padding(4);
            this.rdBtnF.Name = "rdBtnF";
            this.rdBtnF.Size = new System.Drawing.Size(43, 19);
            this.rdBtnF.TabIndex = 12;
            this.rdBtnF.TabStop = true;
            this.rdBtnF.Text = "女";
            this.rdBtnF.UseVisualStyleBackColor = true;
            // 
            // FormReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 488);
            this.Controls.Add(this.rdBtnF);
            this.Controls.Add(this.rdBtnM);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txTell);
            this.Controls.Add(this.txAge);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txIDNum);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReserve";
            this.Text = "FormReserve";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txIDNum;
		private System.Windows.Forms.TextBox txName;
		private System.Windows.Forms.TextBox txAge;
		private System.Windows.Forms.TextBox txTell;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button BtnRegister;
		private System.Windows.Forms.RadioButton rdBtnM;
		private System.Windows.Forms.RadioButton rdBtnF;
    }
}