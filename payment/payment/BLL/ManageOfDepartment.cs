using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.DAL;
using System.Data;
using payment.BLL.model;


namespace payment.BLL
{
    class ManageOfDepartment
    {
        public DataTable ShowDName(Department department)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = new DataTable();
            datatable = sqlhelper.Exesql("SELECT DName from Department ");
            return datatable;
        }
    }
}
