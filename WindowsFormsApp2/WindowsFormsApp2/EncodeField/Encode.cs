using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.VREntry;
/// <summary>
///
/// </summary>
namespace WindowsFormsApp2.EncodeField
{
   
    abstract class Encode
    {

        public Encode(Rule rule)

        {

        }
        /// <summary>
        /// 接口,解码
        /// </summary>
        /// <returns></returns>
        public  abstract Item encode();
        /// <summary>
        /// 传入tag解得VR
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string encodeVR(string s)
        {
            DicomDictonaryEntry dd = new DicomDictonaryEntry();
            DicomDictionary dde = new DicomDictionary();
            dd = dde.FindByTag(s);
            string vr = dd.VR;
            return vr;
        }
    }
}
