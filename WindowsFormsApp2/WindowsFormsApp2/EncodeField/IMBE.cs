using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.VREntry;

namespace WindowsFormsApp2.EncodeField
{
    /// <summary>
    /// 隐式VR
    /// BigEndian
    /// </summary>
    class IMBE:Encode
    {
        Rule rule;
        public IMBE(Rule rule) : base(rule)
        {
            this.rule = rule;
        }
        public override Item encode()
        {
            byte[] buff = rule.buff;
            int i = rule.i;
            int flag = rule.flag;

            Item item = new Item();
            ushort gtag = (ushort)(buff[i] * 256 + buff[i + 1] );
            ushort etag = (ushort)(buff[i + 2] * 256 + buff[i + 3] );
            string tag = "(" + gtag.ToString("X4") + "," + etag.ToString("X4") + ")";
            i += 4;
            int len = (int)(buff[i + 0] <<24+ buff[i + 1] << 16 + buff[i + 1] << 8 + buff[i + 1]);
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
