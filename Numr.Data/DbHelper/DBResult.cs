using System;
using System.Collections.Generic;
using System.Text;

namespace Numr.Data.DbHelper
{
    public class DBResult
    {
        public bool IsSucceess { get; set; }
        public string ErrorMessage { get; set; }
        public string Description { get; set; }
        public string ErrorCommandQuery { get; set; }
        public object Result { get; set; }

        public DBResult()
        {
            IsSucceess = false;
            ErrorMessage = "";
            Description = "";
            ErrorCommandQuery = "";
            Result = null;
        }
    }
}
