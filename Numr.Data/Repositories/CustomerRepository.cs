using Numr.Business.Entities;
using System.Collections.Generic;

namespace Numr.Data.Repositories
{
    public class CustomerRepository : RepositoryBase
    {
        public Customer GetCustomer(string id)
        {
            string query = "select * from Customer where id='"+id+"'";
            var data=  DB.ExecuteSelectQuery(query);

            return new Customer();
        }

        public Customer AddCustomer(Customer item)
        {
            Customer data = new Customer
            {

                Name = "Nina",
                Phone = "9847234567",
                Address_Details = "hghdshd",
                Email = "GH@GMAIL.com"

            };
            DB.BulkInsert(data);

            return data;
        }
    }

    

}
