using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;
using System.Data;
using payment.BLL.model;
using payment.BLL.PatientInfo;
/// <summary>
/// 预交金管理
/// </summary>
namespace payment.BLL
{
    class Prepaid
    {
        PrepaidPayment prepaidpayment = new PrepaidPayment();

        /// <summary>
        /// 缴费操作
        /// <input>
        /// PrepaidPayment
        /// </input>
        /// </summary>
        /// <param name="prepaidpayment"></param>
        /// <returns></returns>
        public Boolean Pay(PrepaidPayment prepaidpayment)
        {
            this.prepaidpayment = prepaidpayment;
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = new DataTable();
            datatable = sqlhelper.Exesql("SELECT * from PrepaidPayment WHERE  PatientID = '" + prepaidpayment.PatientID + "' AND Time='"+prepaidpayment.Time+"'");
            if (datatable.Rows.Count > 0)//检查是否有同一日期同一用户的数据，有则更新
            {
                int resualt = sqlhelper.ExecuteNonQuery("update PrepaidPayment set Prepay=Prepay+'"+prepaidpayment.Prepay+"' where PatientID = '" + prepaidpayment.PatientID + "'");
                if (resualt > 0) {
                    Balance balance = new Balance();
                    balance.PatientID = prepaidpayment.PatientID;
                    balance.BalanceMoney = prepaidpayment.Prepay;
                    updateBalance(balance);
                    return true; }
                else { return false; }
            }
            else
            {
                //先检查是否有此用户
                Patientinfo patientinfo = new Patientinfo();
                Patients patient = new Patients();
                patient.PatientID = prepaidpayment.PatientID;
                if (patientinfo.FindPatient(patient))//若存在此用户，则插入新的数据
                {
                    int resualt = sqlhelper.ExecuteNonQuery("INSERT INTO PrepaidPayment( PatientID,Time,Prepay) VAlUES('" + prepaidpayment.PatientID + "', '" + prepaidpayment.Time + "','" + prepaidpayment.Prepay + "') ");
                    if (resualt > 0)//插入成功,则修改Balance中的值
                    {
                        Balance balance = new Balance();
                        balance.PatientID = prepaidpayment.PatientID;
                        balance.BalanceMoney = prepaidpayment.Prepay;
                        if (FindBalance(balance))//Balance中有此数据，则更新数据
                        {
                            updateBalance(balance);
                        }
                        else//Balance 中无此数据，则插入；
                        {
                            insertBalance(balance);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else {
                    return false;
                }

              
            }
            
            
        }
        /// <summary>
        /// 更新余额表
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public Boolean updateBalance(Balance balance)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            int resualt= sqlhelper.ExecuteNonQuery("UPDATE Balance set BalanceMoney = BalanceMoney + '" + balance.BalanceMoney+"' WHERE PatientID='"+balance.PatientID+"'");
            if (resualt> 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 查询余额
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public Boolean FindBalance(Balance balance)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT BalanceMoney FROM Balance WHERE PatientID = '" + balance.PatientID+ "'");
            if (datatable.Rows.Count > 0)
            {
                balance.BalanceMoney = int.Parse(datatable.Rows[0][0].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 当新建一个余额行，并插入数据
        /// 并不是主只要有病例就有余额表‘
        /// 而是有病例才有余额表
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public Boolean insertBalance(Balance balance)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            int resualt = sqlhelper.ExecuteNonQuery("INSERT INTO Balance(PatientID,BalanceMoney) VALUES('"+balance.PatientID+"',BalanceMoney+'" + balance.BalanceMoney + "')");
            if (resualt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// PrintFeeByDate
        /// </summary>
        /// <input>
        /// Fee
        /// </input>
        /// <param name="fee"></param>
        /// <returns></returns>
        public Boolean ShowFeeByDate(Fee fee)
        {
            
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * FROM dbo.Fee WHERE  PatientID='" + fee.PatientID + "' AND Time = '" + fee.Time + "'");
            if (datatable.Rows.Count > 0)
            {
                fee.FeeTable = datatable;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 从预交金表中查询一个数据
        /// </summary>
        /// <param name="prepaidpayment"></param>
        /// <returns></returns>
        public DataTable FindPrepaidPaymentByPID(PrepaidPayment prepaidpayment)
        {
            this.prepaidpayment = prepaidpayment;
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * FROM dbo.PrepaidPayment WHERE  PatientID='" + prepaidpayment.PatientID + "' ");
            return datatable;
        }
        /// <summary>
        /// 从预交金表中全部查询
        /// </summary>
        /// <returns></returns>
        public DataTable FindALlPrepaidPayment()
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * FROM dbo.PrepaidPayment ");
            return datatable;
        }

        public Boolean ShowFee(Fee fee)
        {

            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = sqlhelper.Exesql("SELECT * FROM dbo.Fee WHERE  PatientID='" + fee.PatientID + "'");
            if (datatable.Rows.Count > 0)
            {
                fee.FeeTable = datatable;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
