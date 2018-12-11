using Numr.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Numr.Business.Service
{
    class ServiceBase
    {
        public void ExecuteOperation<T>(Func<T> codetoExecute)
        {
            NumrDBContext dBContext = new NumrDBContext();
            try
            {
                dBContext.Open();
               // return codetoExecute.Invoke();
                // return data; 
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dBContext.Close();
            }
        }
    }
}
