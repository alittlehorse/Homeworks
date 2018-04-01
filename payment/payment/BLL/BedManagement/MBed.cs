using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;
using System.Data;
using payment.BLL.model;
using payment.BLL.PatientInfo;

namespace payment.BLL.BedManagement
{
    class MBed
    {
        public String InsertBed(Bed bed)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            string resualt;            
            if (ShowBedInfo(bed))
            {
                resualt = "此床位已存在，请重新插入";
                return resualt;
            }
            else
            {
                int state = sqlhelper.ExecuteNonQuery("INSERT INTO Bed( BID,State,DName) VAlUES('" + bed.BID + "', '" + bed.State + "','" + bed.DName + "') ");
                if (state > 0)
                {
                    resualt = "插入成功";
                }
                else
                {
                    resualt = "插入失败";

                }
                return resualt;
            }
        }
        public Boolean ShowBedInfo(Bed bed)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = new DataTable();
            datatable = sqlhelper.Exesql("SELECT * from BEd WHERE  BID = '" + bed.BID + "' ");
            if (datatable.Rows.Count > 0)
            {
                bed.BID = datatable.Rows[0]["BID"].ToString();
                bed.State = datatable.Rows[0]["State"].ToString();
                bed.DName = datatable.Rows[0]["DName"].ToString();
                /*if (datatable.Rows[0]["PatientID"] == null)
                {
                    bed.PatientID = 0;
                }
                else {
                    bed.PatientID = int.Parse(datatable.Rows[0]["PatientID"].ToString());
                }
                bed.TurningOut = datatable.Rows[0]["TurningOut"].ToString();
                */
                return true;
            }
            else
            {
                return false;
            }
        }
        public String DeleteBed(Bed bed)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            string resualt;
            int state = sqlhelper.ExecuteNonQuery("Delete from Bed WHERE  BID = '" + bed.BID + "' ");
            if (state> 0)//检查是否有同一日期同一用户的数据，有则更新
            {
                resualt = "删除成功";
                return resualt;
            }
            else
            {
                resualt = "没有此床位";
                return resualt;
            }
        }
        public String UpdateBed(Bed bed)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            string resualt;
            int state = sqlhelper.ExecuteNonQuery("update Bed set DName='" + bed.DName + "',State='" + bed.State + "' where BID = '" + bed.BID + "'");
            if(state>0)
            {
                resualt = "修改成功";
                return resualt;
            }
            else
            {
                resualt = "修改失败";
                return resualt;
            }
        }
        public DataTable Showall()
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * from Bed ");
            return datatable;
        }
        public DataTable ShowBedInfoByDName(Bed bed)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * from Bed Where DName ='" + bed.DName + "'");
            return datatable;
        }

        public DataTable ShowBedInfoByPID(Bed bed)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * from Bed Where PatientID ='" + bed.PatientID + "'");
            bed.BID = datatable.Rows[0]["BID"].ToString();
            bed.DName = datatable.Rows[0]["DName"].ToString();
            bed.State = datatable.Rows[0]["State"].ToString();
            return datatable;

        }
    }
}
