using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payment.BLL
{/// <summary>
///注意，这个模型对应的是MedicalRecord
/// </summary>
    class Patients
    {
        public int PatientID { set; get; }
        public string PatienName { set; get; }
        public string Sex { set; get; }
        public int Age { set; get; }
        public string  Phone{ set; get; }
        public String  DName { set; get; }
        public string BID { set; get; }
        public String IDNumber { set; get; }
    }
}
