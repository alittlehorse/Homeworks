using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.VREntry

{
    class TM : VR
    {
        Rule rule;
        public TM(Rule rule, int length):base(rule,length)
        {
            this.rule = rule;
        }
        public override string ValueEncoding()
        {
            String s = Encoding.Default.GetString(rule.buff, rule.i, length);
            int hour = int.Parse(s.Substring(0, 2));
            int minute = int.Parse(s.Substring(2, 2));
            int second = int.Parse(s.Substring(4, 2));
            string resualt = hour + "-" + minute + "-" + second;
            rule.i += length;
            return resualt;
        }

    }
}
