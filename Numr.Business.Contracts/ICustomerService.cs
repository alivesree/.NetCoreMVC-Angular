using Numr.Business.Entities;
using System;

namespace Numr.Business.Contracts
{
    public interface ICustomerService
    {
       Customer GetCustomer(string id);
       Customer AddCustomer(Customer cust);
    }
}
