using Numr.Business.Entities;


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
    }
   
}
