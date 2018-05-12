using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.EncodeField;

namespace WindowsFormsApp2
{
    /// <summary>
    /// 解码规则的简单工厂,根据传入的rule.ie----显式隐式,falg --- LE或者BE来确定实际的解码规则是什么
    /// </summary>
    class EncodeFactory
    {
        public static Encode CreateEnode(Rule rule
            )
        {
            Encode encode;
            if (rule.ie == 0 && rule.flag == 0)
            {
                encode = new Default(rule);
                return encode;
            }
            //显式VR,LittleEndian
            else if (rule.ie == 1 && rule.flag == 0)
            {
                encode = new EXLE(rule);
                return encode;
            }
            //隐式VR,LittleBndian
            else if (rule.ie == 0 && rule.flag == 1)
            {
                encode = new IMBE(rule);
                return encode;
            }
            else if (rule.ie == 1 && rule.flag == 1)
            {
                encode = new EXBE(rule);
                return encode;
            }
            else {
                    throw new Exception();
            }
        }
    }
}
