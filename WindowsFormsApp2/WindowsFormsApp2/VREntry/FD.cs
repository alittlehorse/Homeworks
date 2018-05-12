using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.VREntry
{
    class FD:VR
    {
        Rule rule;
        public FD(Rule rule, int length) : base(rule, length)
        {
            this.rule = rule;
        }
        public override string ValueEncoding()
        {
            int flag = rule.flag;
            byte[] buff = rule.buff;
            int i = rule.i;
            if (flag == 0)

            {
                string str = BitConverter.ToDouble(buff, i).ToString();
                i += length;
                rule.i = i;
                return str;
            }
            else
            {
                if (length != 0)
                {
                    byte[] tempbuff = ArrayHelper.SplitArray(buff, i, length);
                    Array.Reverse(tempbuff);
                    i += length;
                    rule.i = i;
                    string str = BitConverter.ToDouble(buff, 0).ToString();
                    return str;
                }
                else
                {
                    return " ";
                }
            }
         
        }

    }
}
