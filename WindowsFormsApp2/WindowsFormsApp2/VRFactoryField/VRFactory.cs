using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.VREntry;


namespace WindowsFormsApp2

{
    abstract class VRFactory
    {
        public abstract VR CreateVR(string str, Rule rule, int length);
    }
}
