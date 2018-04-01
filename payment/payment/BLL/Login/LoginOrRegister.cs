using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;
using System.Data;

namespace payment.BLL.Login
{
	public class LoginOrRegister
	{
		Sqlhelper mysqlhelper = new Sqlhelper();
		public int Register(BLL.model.User newUser)
		{
			int result;
			string mysql;
			mysql = "INSERT INTO Users(Username,Password,Type) VALUES('"+newUser.Username+"','"+newUser.Password+"','"+newUser.Type+"')";
			result = mysqlhelper.ExecuteNonQuery(mysql);
			return result;
		}

		public DataTable Login(BLL.model.User newUser)
		{
			DataTable mytable = new DataTable();
			string mysql;
			mysql = "SELECT * FROM Users WHERE Username='"+newUser.Username+"'";
			mytable = mysqlhelper.Exesql(mysql);
			return mytable;
		}
	}
}
