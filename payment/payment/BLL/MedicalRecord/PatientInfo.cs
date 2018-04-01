using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;
using System.Data;

namespace payment.BLL.MedicalRecord
{
    class PatientInfo
    {
        Patients patient = new Patients();
        public Boolean ShowPatientInfo(Patients patient)
        {
            this.patient = patient;
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * FROM dbo.MedicalRecord WHERE  PatientID='" + patient.PatientID + "'");
            if (datatable.Rows.Count > 0)
            {
                patient.PatientID = int.Parse(datatable.Rows[0]["PatientID"].ToString());
                patient.DName = datatable.Rows[0]["DName"].ToString();
                patient.Sex = datatable.Rows[0]["Sex"].ToString();
                patient.Age = int.Parse(datatable.Rows[0]["Age"].ToString());
                patient.Phone = int.Parse(datatable.Rows[0]["Phone"].ToString());
                patient.BID = datatable.Rows[0]["BID"].ToString();
                return true;
            }
            else { return false; }
        }
    }
}
