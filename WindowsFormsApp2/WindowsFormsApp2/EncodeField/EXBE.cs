using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.VREntry;

/// <summary>
/// 显式VR
///BigEndian
/// </summary>
namespace WindowsFormsApp2.EncodeField
{
    class EXBE:Encode
    {
        Rule rule;
        public EXBE(Rule rule) : base(rule)
        {
            this.rule = rule;
        }
        public override Item encode()
        {
            byte[] buff = rule.buff;
            int i = rule.i;
            int flag = rule.flag;

            Item item = new Item();           
            ushort gtag = (ushort)(buff[i] * 256 + buff[i + 1]);
            ushort etag = (ushort)(buff[i + 2] * 256 + buff[i + 3]);
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
                len = (int)(buff[i + 0]<<24 + (buff[i + 1] << 16) + (buff[i + 2] << 8) + (buff[i + 3] << 0));
                i += 4;
            }
            //不是上边的类型是,len为两个字节,按照LE接触len
            else
            {
                len = (int)((buff[i + 0] <<8)+ buff[i + 1]);
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
            try
            {
                VR vr = vrf.CreateVR(vrstring, rule, len);
                string value = vr.ValueEncoding();
                item.Tag = tag;
                item.len = len;
                item.Value = value;
                return item;
            }
            catch 
            {
                throw new Exception();
            }
            
            
        }
    }
}
