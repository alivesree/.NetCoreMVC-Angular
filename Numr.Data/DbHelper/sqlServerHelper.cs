using System;
using System.Collections.Generic;
using Numr.Business.Entities;

namespace Numr.Data.DbHelper
{
    class SqlServerHelper : IDbHelper
    {
       

        public DBResult BulkInsert(List<DBResult> list)
        {
            throw new NotImplementedException();
        }

        public DBResult BulkInsert(List<object> list)
        {
            throw new NotImplementedException();
        }

        public DBResult BulkInsert(object obj)
        {
            throw new NotImplementedException();
        }

        public DBResult ExecuteNonQuery(string query)
        {
            throw new NotImplementedException();
        }

        public DBResult ExecuteScalar(string query)
        {
            throw new NotImplementedException();
        }

        public DBResult ExecuteSelectQuery(string query)
        {
            throw new NotImplementedException();
        }

        public bool OpenDataBaseConnection()
        {
            throw new NotImplementedException();
        }
    }
}
