using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.VREntry
{
    class SL:VR
    {
        Rule rule;
        public SL( Rule rule, int length) : base(rule, length)
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
                string str = BitConverter.ToUInt32(buff, i).ToString();
                i += length;
                rule.i = i;
                return str;
            }
            else
            {
                byte[] tempbuff = ArrayHelper.SplitArray(buff, i, buff.Length);
                Array.Reverse(tempbuff);
                i += length;
                rule.i = i;
                string str = BitConverter.ToInt32(buff, 0).ToString();
                return str;
            }
        }

    }
}
