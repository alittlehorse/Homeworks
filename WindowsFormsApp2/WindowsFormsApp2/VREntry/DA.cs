using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp2.VREntry
{
    class DA:VR
    {
        Rule rule;
        public DA(Rule rule, int length) : base(rule, length)
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
            string resualt = year + "-" + month + "-" + day;
            i += length;
            return resualt;
        }
    }
}
