﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.VREntry
{
    class DS : VR
    {
        Rule rule;
        public DS(Rule rule, int length) : base(rule, length)
        {
            this.rule = rule;
        }
        public override string ValueEncoding()
        {
            int flag = rule.flag;
            byte[] buff = rule.buff;
            int i = rule.i;
            String s = Encoding.Default.GetString(buff, i, length);
            i += length;
            rule.i = i;
            return s;
        }

    }
}
