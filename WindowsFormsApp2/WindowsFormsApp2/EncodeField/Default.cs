using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.VREntry;

namespace WindowsFormsApp2.EncodeField
{
    class Default:Encode
    {
        Rule rule;
        public Default(Rule rule) : base(rule)
        {
           this. rule = rule;
        }

        public override Item encode()
        {
            int i = rule.i;

            Item item = new Item();

            ushort gtag = (ushort)(rule.buff[i] + rule.buff[i + 1] * 256);
            ushort etag = (ushort)(rule.buff[rule.i + 2] + rule.buff[i + 3] * 256);
            string tag = "(" + gtag.ToString("X4") + "," + etag.ToString("X4") + ")";

            i += 4;

            int len = (int)(rule.buff[i + 0] + (rule.buff[i + 1] << 8) + (rule.buff[i + 2] << 16) + (rule.buff[i + 3] << 24));

            i += 4;

            string vrstring = encodeVR(tag);//找出对应的VR
            VRFactory vrf;
            if (vrstring != "SQ")
            {
                vrf = new no_sqVRFactory();
            }
            else
            { 
                vrf = new sqVRFactory();
            }
            rule.i = i;
            VR vr = vrf.CreateVR(vrstring, rule, len);
            string value = vr.ValueEncoding();
            item.Tag = tag;
            item.len = len;
            item.Value = value;
            return item;
        }
    }
}
