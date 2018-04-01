using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;
using System.Data;
using System.Data.SqlClient;

namespace payment.BLL
{
    class AddLeavePatient
    {
        LeaveInfo LeaveInfo = new LeaveInfo();

        public Boolean AddInfo(LeaveInfo LeaveInfo)
        {
            this.LeaveInfo = LeaveInfo;
            Sqlhelper sqlhelper = new Sqlhelper();
            int resualt = sqlhelper.ExecuteNonQuery("insert into Leave(PatientID,Date,BedNumber) values('" + LeaveInfo.PatientID + "', '" + LeaveInfo.Date + "', '" + LeaveInfo.BedNumber + "')");
            if (resualt != 0) { return true; }
            else { return false; }
        }

        public Boolean FindLeaveInfo()
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * FROM Leave");
            if (datatable.Rows.Count > 0)
            {
                LeaveInfo.LeaveTable = datatable;
                return true;
            }
            else
                return false;
        }
    }
}

