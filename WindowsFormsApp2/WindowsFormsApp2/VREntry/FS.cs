
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApp2.VREntry
{
    class FS:VR
    {
        Rule rule;
        public FS(Rule rule, int length):base(rule,length)
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
                string str = BitConverter.ToSingle(buff, i).ToString();
                i += length;
                rule.i = i;
                return str;
            }
            else
            {
                byte[] tempbuff = ArrayHelper.SplitArray(buff, i, buff.Length);
                Array.Reverse(tempbuff);
                string str = BitConverter.ToSingle(buff, 0).ToString();
                i += length;
                rule.i = i;
                return str;
            }
        }
    }
}