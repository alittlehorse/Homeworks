using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace payment.BLL
{
    class LeaveInfo
    {
        public int PatientID { get; set; }
        public string Date { get; set; }
        public int BedNumber { get; set; }
        public static DataTable LeaveTable { set; get; }
    }
}
