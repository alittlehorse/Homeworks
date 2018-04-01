using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;
using System.Data;
using payment.BLL.model;

namespace payment.BLL.PatientInfo
{
    class Patientinfo
    {
        Patients patient = new Patients();
        public Boolean FindPatient(Patients patient)
        {
            this.patient = patient;
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * FROM MedicalRecord WHERE PatientID = '" + patient.PatientID + "'");
            if (datatable.Rows.Count > 0)
            {
                patient.PatienName = datatable.Rows[0]["Name"].ToString();
                patient.PatientID = int.Parse(datatable.Rows[0]["PatientID"].ToString());
                patient.Sex = datatable.Rows[0]["Sex"].ToString();
                patient.Phone = datatable.Rows[0]["Phone"].ToString();
                patient.Age = int.Parse(datatable.Rows[0]["Age"].ToString());
                patient.DName= datatable.Rows[0]["DName"].ToString();
                patient.BID = datatable.Rows[0]["BID"].ToString();
                patient.IDNumber= datatable.Rows[0]["IDNumber"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean UpdatePatient(Patients patient)
        {
            this.patient = patient;
            Sqlhelper sqlhelper = new Sqlhelper();
            int state = sqlhelper.ExecuteNonQuery("update MedicalRecord set DName='" + patient.DName + "',BID='" + patient.BID + "' where PatientID = '" + patient.PatientID+ "'");
            if (state > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean InertPatient(Patients patient)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            int resualt = sqlhelper.ExecuteNonQuery("INSERT INTO MedicalRecord(Name,Sex,Age,Phone,IDNumber) VAlUES( '" + patient.PatienName + "','" + patient.Sex + "','" + patient.Age + "','" + patient.Phone + "','" + patient.IDNumber + "') ");
            if (resualt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean FindPatientByIDNumber(Patients patient)
        {
            this.patient = patient;
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * FROM MedicalRecord WHERE IDNumber= '" + patient.IDNumber + "'");
            if (datatable.Rows.Count > 0)
            {
                patient.PatienName = datatable.Rows[0]["Name"].ToString();
                patient.PatientID = int.Parse(datatable.Rows[0]["PatientID"].ToString());
                patient.Sex = datatable.Rows[0]["Sex"].ToString();
                patient.Phone = datatable.Rows[0]["Phone"].ToString();
                patient.Age = int.Parse(datatable.Rows[0]["Age"].ToString());
                patient.DName = datatable.Rows[0]["DName"].ToString();
                patient.BID = datatable.Rows[0]["BID"].ToString();
                patient.IDNumber = datatable.Rows[0]["IDNumber"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
