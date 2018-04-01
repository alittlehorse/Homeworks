using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using payment.DAL;

namespace payment.BLL
{
	public class PermissionCheck
	{
		public DataTable selectReservePatients()
		{
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable mytable = new DataTable();
			string mysql;
			mysql = "SELECT IDNumber FROM BeingHospitalized WHERE SITUATION=0";
			mytable = sqlhelper.Exesql(mysql);
			return mytable;
		}

		public DataTable selectInfo(string IDNumber)
		{
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable mytable = new DataTable();
			string mysql;
			mysql = "SELECT * FROM BeingHospitalized WHERE IDNumber='"+IDNumber+"'";
			mytable = sqlhelper.Exesql(mysql);
			return mytable;
		}

		public int Agree(string IDNumber)
		{
            Sqlhelper sqlhelper = new Sqlhelper();
            string mysql;
			mysql = "UPDATE BeingHospitalized SET Situation=1 WHERE IDNumber='" + IDNumber+"'";
			int result = sqlhelper.ExecuteNonQuery(mysql);
			return result;
		}

		public int Reject(string IDNumber)
		{
            Sqlhelper sqlhelper = new Sqlhelper();
            string mysql;
			mysql = "UPDATE BeingHospitalized SET Situation=-1 WHERE IDNumber='" + IDNumber + "'";
			int result = sqlhelper.ExecuteNonQuery(mysql);
			return result;
		}
	}
}
