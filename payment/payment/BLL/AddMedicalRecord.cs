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
    
    class AddMedicalRecord
    { 
        Content Content = new Content();
        public Boolean AddContentInfo(Content Content)
        {
            this.Content = Content;
            Sqlhelper sqlhelper = new Sqlhelper();
            int resualt = sqlhelper.ExecuteNonQuery("insert into Content(PatientID,Time,Treatment,Doctor) values('" + Content.PatientID + "', '" + Content.Time + "',  '" + Content.Treatment+ "','" + Content.Doctor + "')");
            if (resualt != 0) { return true; }
            else { return false; }
        }

        Patients Patients = new Patients();
        public Boolean SelectContentInfo(Patients Patients)
        {
            this.Patients = Patients;
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * FROM MedicalRecord WHERE  PatientID='" + Patients.PatientID + "'");
            if (datatable.Rows.Count > 0)
            {
                Patients.PatientID = int.Parse(datatable.Rows[0]["PatientID"].ToString());
                Patients.PatienName = datatable.Rows[0]["Name"].ToString();
                Patients.Sex = datatable.Rows[0]["Sex"].ToString();
                Patients.Age = int.Parse(datatable.Rows[0]["Age"].ToString());
                Patients.Phone = datatable.Rows[0]["Phone"].ToString();
                Patients.IDNumber = datatable.Rows[0]["IDNumber"].ToString();
                return true;
            }
            else { return false; }
        }
    }
}
