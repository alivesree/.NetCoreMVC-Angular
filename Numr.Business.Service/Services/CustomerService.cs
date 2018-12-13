using Numr.Business.Contracts;
using Numr.Business.Entities;
using Numr.Data.Repositories;

namespace Numr.Business.Service
{
    public class CustomerService : ICustomerService
    {
        CustomerRepository _customerRepository = new CustomerRepository();


        public Customer GetCustomer(string id)
        {
            Customer customer = _customerRepository.GetCustomer(id);
            return customer;
        }

        public Customer AddCustomer(Customer cust)
        {
            Customer customer = _customerRepository.AddCustomer(cust);
            return customer;

        }
       
    }
}
    
