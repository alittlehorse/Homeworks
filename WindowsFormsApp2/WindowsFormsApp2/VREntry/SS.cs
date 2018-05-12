using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.VREntry
{
    class SS:VR
    {
        Rule rule;
        public SS(Rule rule, int length):base(rule,length)
        {
            this.rule = rule;
        }
        public override string ValueEncoding()
        {
            if (rule.flag == 0)
            {
                string s = (rule.buff[rule.i] + (rule.buff[rule.i + 1] << 8)).ToString();
                rule.i += length;
                return s;
            }
            else
            {
                string str = ((rule.buff[rule.i] << 8) + rule.buff[rule.i + 1]).ToString();
                rule.i += length;
                return str;
            }
        }

    }
}
