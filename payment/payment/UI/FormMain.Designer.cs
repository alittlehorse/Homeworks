namespace payment.UI
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.审批ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.床位管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.费用管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.申请入院ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病历管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出院ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.申请入院ToolStripMenuItem,
            this.审批ToolStripMenuItem,
            this.床位管理ToolStripMenuItem,
            this.费用管理ToolStripMenuItem,
            this.病历管理ToolStripMenuItem,
            this.查询管理ToolStripMenuItem,
            this.出院ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // 审批ToolStripMenuItem
            // 
            this.审批ToolStripMenuItem.Name = "审批ToolStripMenuItem";
            this.审批ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.审批ToolStripMenuItem.Text = "审批入院";
            this.审批ToolStripMenuItem.Click += new System.EventHandler(this.审批ToolStripMenuItem_Click);
            // 
            // 床位管理ToolStripMenuItem
            // 
            this.床位管理ToolStripMenuItem.Name = "床位管理ToolStripMenuItem";
            this.床位管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.床位管理ToolStripMenuItem.Text = "床位管理";
            this.床位管理ToolStripMenuItem.Click += new System.EventHandler(this.床位管理ToolStripMenuItem_Click);
            // 
            // 费用管理ToolStripMenuItem
            // 
            this.费用管理ToolStripMenuItem.Name = "费用管理ToolStripMenuItem";
            this.费用管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.费用管理ToolStripMenuItem.Text = "费用管理";
            this.费用管理ToolStripMenuItem.Click += new System.EventHandler(this.费用管理ToolStripMenuItem_Click);
            // 
            // 申请入院ToolStripMenuItem
            // 
            this.申请入院ToolStripMenuItem.Name = "申请入院ToolStripMenuItem";
            this.申请入院ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.申请入院ToolStripMenuItem.Text = "申请入院";
            this.申请入院ToolStripMenuItem.Click += new System.EventHandler(this.申请入院ToolStripMenuItem_Click);
            // 
            // 病历管理ToolStripMenuItem
            // 
            this.病历管理ToolStripMenuItem.Name = "病历管理ToolStripMenuItem";
            this.病历管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.病历管理ToolStripMenuItem.Text = "病历管理";
            this.病历管理ToolStripMenuItem.Click += new System.EventHandler(this.病历管理ToolStripMenuItem_Click);
            // 
            // 出院ToolStripMenuItem
            // 
            this.出院ToolStripMenuItem.Name = "出院ToolStripMenuItem";
            this.出院ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.出院ToolStripMenuItem.Text = "出院";
            this.出院ToolStripMenuItem.Click += new System.EventHandler(this.出院ToolStripMenuItem_Click);
            // 
            // 查询管理ToolStripMenuItem
            // 
            this.查询管理ToolStripMenuItem.Name = "查询管理ToolStripMenuItem";
            this.查询管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.查询管理ToolStripMenuItem.Text = "查询管理";
            this.查询管理ToolStripMenuItem.Click += new System.EventHandler(this.查询管理ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 523);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 审批ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 床位管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 费用管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 申请入院ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病历管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出院ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询管理ToolStripMenuItem;
    }
}



