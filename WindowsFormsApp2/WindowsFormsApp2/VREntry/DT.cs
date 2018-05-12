using System;
using System.Text;

namespace WindowsFormsApp2.VREntry


{
    class DT:VR
    {
        Rule rule;
        public DT(Rule rule, int length) : base(rule, length)
        {
            this.rule = rule;
        }
        public override string ValueEncoding()
        {
            byte[] buff = rule.buff;
            int i = rule.i;
            String s = Encoding.Default.GetString(buff, i, length);
            int year = int.Parse(s.Substring(0, 4));
            int month = int.Parse(s.Substring(4, 2));
            int day = int.Parse(s.Substring(6, 2));
            int hour = int.Parse(s.Substring(8, 2));
            int minute = int.Parse(s.Substring(10, 2));
            int second = int.Parse(s.Substring(12, 2));
            string resualt = year + "-" + month + "-" + day + ":"+hour + ":" + minute + ":" + second;
            i += length;
            rule.i = i;
            return resualt;
        }
    }
}
