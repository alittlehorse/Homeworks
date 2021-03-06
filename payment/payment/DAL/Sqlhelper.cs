﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace payment.DAL
{
    public class Sqlhelper
    {
        public DataTable Exesql(string mysql)
        {
            string mystr, sqlcomm;
            SqlConnection conn = new SqlConnection();
            mystr = @"Data Source=.;Initial Catalog=ManagementOfBingHospitalized;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn.ConnectionString = mystr;
            conn.Open();

            SqlCommand cmd = new SqlCommand(mysql, conn);
            //cmd.CommandText = mysql;

            sqlcomm = firststr(mysql);

            if (sqlcomm == "INSERT" || sqlcomm == "DELETE" || sqlcomm == "UPDATE")
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return null;
            }
            else
            {
                DataSet myds = new DataSet();
                SqlDataAdapter myadp = new SqlDataAdapter();
                myadp.SelectCommand = cmd;
                cmd.ExecuteNonQuery();         //执行查询
                conn.Close();                  //关闭连接
                myadp.Fill(myds);                //填充数据
                return myds.Tables[0];           //返回表对象
            }
        }

        public string firststr(string mystr)      //提取字符串中的第一个字符串
        {
            string[] strarr;
            strarr = mystr.Split(' ');
            return strarr[0].ToUpper().Trim();
        }
        public int ExecuteNonQuery(string mysql)
        {
            int result = 0;
            string mystr;
            SqlConnection conn = new SqlConnection();
            mystr = @"Data Source=.;Initial Catalog=ManagementOfBingHospitalized;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn.ConnectionString = mystr;
            conn.Open();
            SqlCommand cmd = new SqlCommand(mysql, conn);
            result = cmd.ExecuteNonQuery();            
            conn.Close();
            return result;
        }
    }
    
}
