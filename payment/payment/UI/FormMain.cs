using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payment.UI
{
    public partial class FormMain : Form
    {
        private int childFormNumber = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void 申请入院ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReserve form = new FormReserve();
            form.MdiParent = this;
            form.Show();
        }

        private void 审批ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPermission form = new FormPermission();
            form.MdiParent = this;
            form.Show();
        }

        private void 床位管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBedManagement form = new FormBedManagement();
            form.MdiParent = this;
            form.Show();
        }

        private void 费用管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPayment form = new FormPayment();
            form.MdiParent = this;
            form.Show();
        }

        private void 病历管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicalRecord form = new FormMedicalRecord();
            form.MdiParent = this;
            form.Show();
        }

        private void 查询管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelect form = new FormSelect();
            form.MdiParent = this;
            form.Show();
        }

        private void 出院ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeave form = new FormLeave();
            form.MdiParent = this;
            form.Show();
        }
    }
}
