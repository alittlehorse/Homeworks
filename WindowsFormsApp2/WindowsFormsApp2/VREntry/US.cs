using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.VREntry

{
    class US:VR
    {
        Rule rule;
        public  US(Rule rule, int length):base(rule,length)
        {
            this.rule = rule;
        }
        public override string ValueEncoding()
        {
            byte[] buff = rule.buff;
            int i = rule.i;
            if (rule.flag == 0)
            {
                string str = BitConverter.ToUInt16(buff, i).ToString();
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
                    string str = BitConverter.ToInt16(buff, 0).ToString();
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
