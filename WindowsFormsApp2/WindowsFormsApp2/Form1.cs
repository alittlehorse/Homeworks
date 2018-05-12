using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.VREntry;
using WindowsFormsApp2.EncodeField;
/// <summary>
/// 最好使用工厂类而不不是简单工厂类,这样可以把sq与其他类型分隔开
/// 已经有工厂方法VR封装,所以不能再在客户端选择是文本型还是数值型,只能留有一个接口,使其不管什么类型
/// 都调用同一个方法
/// </summary>
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ie = int.Parse(comboBox1.SelectedIndex.ToString());
            int flag = int.Parse(comboBox2.SelectedIndex.ToString());
            byte[] buff=HexStringToByteArray(textBox1.Text);
            try
            {
                Rule rule = new Rule();
                rule.buff = buff;
                rule.flag = flag;
                rule.i = 0;
                rule.ie = ie;

                Encode encode = EncodeFactory.CreateEnode(rule);
                Item item = encode.encode();
                textBox2.Text = item.Tag;
                if (item.len != 2139095040)
                {
                    textBox3.Text = item.len.ToString();
                }
                else
                {
                    textBox3.Text = "未定";
                }
                richTextBox1.Text = item.Value;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }


        }
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
       

    }
}
