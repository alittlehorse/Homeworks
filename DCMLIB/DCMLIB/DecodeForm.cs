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
            TransferSyntax syntax = (TransferSyntax)comboBox1.SelectedItem;
            byte[] data = HexStringToByteArray(richTextBox1.Text);
            DCMDataSet dCM = new DCMDataSet(syntax);
            uint idx = 0;           
            //调用Decode方法进行解码
            dCM.Decode(data, ref idx);
            
            richTextBox2.Text= dCM.ToString(" ").Replace('\0',' ');

        }

        /// <summary>
        /// 将传进来的一串字符串转化为byte数组
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
            {
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);

            }
            return buffer;
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
    }
}
