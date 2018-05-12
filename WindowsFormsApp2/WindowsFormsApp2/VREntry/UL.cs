using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.VREntry

{
    class UL:VR
    {
        Rule rule;
        public UL(Rule rule, int length):base(rule,length)
        {
            this.rule = rule;
        }
        public override string ValueEncoding()
        {
            byte[] buff = rule.buff;
            int i = rule.i;
            int flag = rule.flag;
            if (flag == 0)
            {
                string str = BitConverter.ToUInt32(buff, i).ToString();
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
                    string str = BitConverter.ToInt32(buff, 0).ToString();
                    return str;
                }
                else {
                    return " ";
                }
            }
        }

    }
}
