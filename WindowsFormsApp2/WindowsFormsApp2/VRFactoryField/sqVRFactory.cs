using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.VREntry;

namespace WindowsFormsApp2
{
    class sqVRFactory:VRFactory
    {
        public override VR CreateVR(string str, Rule rule,int length)
        {
            VR vr;
            vr = new SQ(rule, length);
            return vr;
        }
    }
}
