using Microsoft.Extensions.DependencyInjection;
using Numr.Business.Contracts;
using Numr.Business.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Numr.Web.API.DependencyInjection
{
    public class DependecyRegistery
    {
        public DependecyRegistery(IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();


        }
    }
}
