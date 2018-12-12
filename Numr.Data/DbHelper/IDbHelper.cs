using System;
using System.Collections.Generic;
using System.Text;

namespace Numr.Data.DbHelper
{
   public interface IDbHelper
    {
        DBResult ExecuteNonQuery(string query);
        DBResult ExecuteSelectQuery(string query);
        DBResult ExecuteScalar(string query);
        bool OpenDataBaseConnection();
    }
}
