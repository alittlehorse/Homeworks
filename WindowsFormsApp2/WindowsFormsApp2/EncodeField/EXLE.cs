using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.VREntry;

namespace WindowsFormsApp2.EncodeField
{/// <summary>
/// 显式VR
/// LittleEndian
/// </summary>
    class EXLE:Encode
    {
        Rule rule;
        public EXLE(Rule rule) : base(rule)
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
            //为显式VR是解得VR的类型
            String vrstring = Encoding.Default.GetString(buff, i, 2);
            i += 2;
            int len;
            //为如下值时,len为2+4,先跳过前两的00 00 在按照LE取出剩下的四个值,解码的len
            if (vrstring == "OB" || vrstring == "OW" || vrstring == "UT" || vrstring == "OW" || vrstring == "UN" || vrstring == "SQ")
            {
                i += 2;
                len = (int)(buff[i + 0] + (buff[i + 1] << 8) + (buff[i + 2] << 16) + (buff[i + 3] << 24));
                i += 4;
            }
            //不是上边的类型是,len为两个字节,按照LE接触len
            else
            {
                len = (int)(buff[i + 0] + buff[i + 1] << 8);
                i += 2;
            }

            rule.i = i;

            VRFactory vrf;
            if (vrstring != "SQ")
            {
                vrf = new no_sqVRFactory();
            }
            else
            {
                vrf = new sqVRFactory();
            }
            VR vr = vrf.CreateVR(vrstring, rule, len);
            //调用ValueEncoding方法解得Value;
            string value = vr.ValueEncoding();
            item.Tag = tag;
            item.len = len;
            item.Value = value;
            return item;
        }
    }
}
