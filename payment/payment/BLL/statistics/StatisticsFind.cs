using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;
using System.Data;

namespace payment.BLL.statistics
{
    class StatisticsFind
    {
        Bed bed = new Bed();

        public Boolean FindBedByPatientID( Bed bed)
        {
            this.bed = bed;
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable= sqlhelper.Exesql("SELECT * FROM dbo.Bed WHERE  PatientID='" + bed.PatientID + "'");
            if (datatable.Rows.Count > 0) {
                bed.BID = datatable.Rows[0]["BID"].ToString();
                bed.DName = datatable.Rows[0]["DName"].ToString();
                bed.State = datatable.Rows[0]["State"].ToString();
                return true; }
            else { return false; }           
        }
        public Boolean FindBedByDName(Bed bed)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT COUNT(BID) FROM dbo.Bed  WHERE  DName='" + bed.DName + "' GROUP BY DName");
            if (datatable.Rows.Count > 0)
            {
                bed.DName =datatable.Rows[0][0].ToString();
                return true;
            }
            else { return false; }
        }
    }
}
