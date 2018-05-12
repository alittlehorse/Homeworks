using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class DicomDictonaryEntry
    {
        public string tag { set; get; }
        public string Name { set; get; }
        public string Keyword{ set; get; }
        public string VR { set; get; }
        public string VM { set; get; }
    }
}
