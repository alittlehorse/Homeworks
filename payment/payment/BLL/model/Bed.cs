using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;

namespace payment.BLL
{
    class Bed
    {
        public string BID { set; get; }
        public string TurningOut { set; get; } 
        public string State { set; get; }
        public int PatientID { set; get; }
        public string DName { set; get; }
    }
}
