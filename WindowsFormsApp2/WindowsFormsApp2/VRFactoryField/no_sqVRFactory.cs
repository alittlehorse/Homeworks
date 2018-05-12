using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.VREntry;

namespace WindowsFormsApp2
{
    class no_sqVRFactory:VRFactory
    {
        public override VR CreateVR(string str, Rule rule, int length)
        {
            {
                VR vr = null;
                if (str == "SS")
                {
                    vr = new SS(rule,length);
                }
                else if (str == "US")
                {
                    vr = new US(rule,length);
                }
                else if (str == "UL")
                {
                    vr = new UL(rule,length);
                }
                else if (str == "SL")
                {
                    vr = new SL(rule,length);
                }
                else if (str == "IS")
                {
                    vr = new IS(rule,length);
                }
                else if (str == "FS")
                {
                    vr = new FS(rule,length);
                }
                else if (str == "AS")
                {
                    vr = new AS(rule,length);
                }
                else if (str == "DA")
                {
                    vr = new DA(rule,length);
                }
                else if (str == "UI")
                {
                    vr = new TX(rule, length);
                }
                return vr;

            }
        }

    }
}
