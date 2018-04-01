using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;
using System.Data;
using payment.BLL.model;
using payment.BLL.PatientInfo;


namespace payment.BLL.Reserve
{
    class PatientReserve
    {
        /// <summary>
        /// 查询入院表里是否有此人几录，若有，返回state状态，若为0，为已提交申请但还未通过，1，已通过，2未通过
        /// </summary>
        /// <param name="bh"></param>
        /// <returns></returns>
        public string ReserveSubmit(BeingHospitalized bh)
        {

            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = new DataTable();
            datatable = sqlhelper.Exesql("SELECT * from BeingHospitalized WHERE  IDNumber = '" + bh.IDNumber + "' ");
            if (datatable.Rows.Count > 0)
            {
                int state = int.Parse(datatable.Rows[0]["State"].ToString());
                string resualt = "";
                switch (state)
                {
                    case 0:
                        resualt = "申请已提交，请等待审查;";
                        break;
                    case 1:
                        resualt = "申请已通过，请去住院部领取办理相应手续";
                        break;
                    case 2:
                        resualt = "申请未通过，请去住院部查问";
                        break;
                }
                return resualt;
            }
            else
            {
                string resualt;
                int state = sqlhelper.ExecuteNonQuery("INSERT INTO BeingHospitalized( IDNumber,Name,Sex,Age,Phone) VAlUES('" + bh.IDNumber + "', '" + bh.Name + "','" + bh.Sex + "','" + bh.Age + "','" + bh.Phone + "') ");
                if (state > 0)
                {
                    resualt = "申请已提交";
                    return resualt;
                }
                else
                {
                    resualt = "提交失败，请重新提交";
                    return resualt;
                }
            }
        }
        public string ReserveStateShow(BeingHospitalized bh)
        {

            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = new DataTable();
            datatable = sqlhelper.Exesql("SELECT * from BeingHospitalized WHERE  IDNumber = '" + bh.IDNumber + "' ");
            if (datatable.Rows.Count > 0)
            {
                int state = int.Parse(datatable.Rows[0]["State"].ToString());
                string resualt = "";
                switch (state)
                {
                    case 0:
                        resualt = "申请已提交，请等待审查;";
                        break;
                    case 1:
                        resualt = "申请已通过，请去住院部领取办理相应手续";
                        break;
                    case 2:
                        resualt = "申请未通过，请去住院部查问";
                        break;
                }
                return resualt;
            }
            else
            {
                return "请先提交预约";
            }
        }
    }
}
