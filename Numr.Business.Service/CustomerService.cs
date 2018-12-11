using Numr.Business.Contracts;
using Numr.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Numr.Business.Service
{
    public class CustomerService : ICustomerService
    {
        public Customer GetCustomer(string id)
        {
            string query = "select now()";
         var curtime=   new ServiceBase().ExecuteScalar(query);
            return new Customer();
        }
    }
}
