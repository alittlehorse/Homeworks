using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMLIB
{
    public partial class DecodeForm : Form
    {
        public DecodeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem==null)
            {
                MessageBox.Show("请选择传输语法");
            }
            else {
                TransferSyntax syntax = (TransferSyntax)comboBox1.SelectedItem;
                byte[] data = HexStringToByteArray(richTextBox1.Text);
                DCMDataSet dCM = new DCMDataSet(syntax);
                uint idx = 0;
                //调用Decode方法进行解码
                try
                {
                    dCM.Decode(data, ref idx);
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

                string str = dCM.ToString("").Replace("\0","");
                string[] lines = str.Split('\n');
                lvOutput.Items.Clear();
                for (int i = 0; i < lines.Length; i++)
                {
                    ListViewItem item = new ListViewItem(lines[i].Split('\t'));
                    lvOutput.Items.Add(item);
                }
            }


        }

        /// <summary>
        /// 将传进来的一串字符串转化为byte数组
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] HexStringToByteArray(string s)
        {
            try
            {
                s = s.Replace(" ", "");
                byte[] buffer = new byte[s.Length / 2];
                for (int i = 0; i < s.Length; i += 2)
                {
                    buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);

                }
                return buffer;
            }
            catch 
            {
                throw;
            }
           
        }

        private void DecodeForm_Load(object sender, EventArgs e)
        {
            //传递进来各个的实例
            TransferSyntaxes tsfactory = new TransferSyntaxes();
            comboBox1.Items.Clear();
            foreach (TransferSyntax syntax in tsfactory.TSs)
            {
                comboBox1.Items.Add(syntax);
            }

        }

        private void lvOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DCMFile dcm = new DCMFile(".//gsps.txt");
            uint idx = 0;
            dcm.Decode(null,ref idx);
            string str = dcm.ToString("").Replace('\0', ' ');
            string[] lines = str.Split('\n');
            lvOutput.Items.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                ListViewItem item = new ListViewItem(lines[i].Split('\t'));
                lvOutput.Items.Add(item);
            }


        }
    }
}
