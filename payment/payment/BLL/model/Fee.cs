using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace payment.BLL
{
    class Fee
    {
        public int PatientID { set; get; }
        public string Time { set; get; }
        public string FeeName { set; get; }
        public int Price { set; get; }
        public DataTable FeeTable { set; get; }
        
    }
}
