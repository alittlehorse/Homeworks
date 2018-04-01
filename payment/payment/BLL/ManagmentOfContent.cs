using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using payment.BLL.model;
using System.Data;
using payment.DAL;

namespace payment.BLL
{
    class ManagmentOfContent
    {
        public DataTable ShowContent(Content content)
        {
            Sqlhelper sqlhelper = new Sqlhelper();
            DataTable datatable = new DataTable();
            datatable = sqlhelper.Exesql("SELECT * from Content WHERE PatientID='"+content.PatientID+"' ");
            return datatable;
        }
    }
}
