using Numr.Data.DbHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Numr.Data
{
   public  class RepositoryBase
    {
       protected IDbHelper DB = new PgsqlHelper();

    }
}
