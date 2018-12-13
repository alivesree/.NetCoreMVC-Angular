using System;
using System.Collections.Generic;
using System.Text;
using Numr.Business.Entities;

namespace Numr.Data.DbHelper
{
   public interface IDbHelper
    {
        DBResult ExecuteNonQuery(string query);
        DBResult ExecuteSelectQuery(string query);
        DBResult ExecuteScalar(string query);
        bool OpenDataBaseConnection();
        DBResult BulkInsert(List<object> list);
        DBResult BulkInsert(object obj);

    }
}
