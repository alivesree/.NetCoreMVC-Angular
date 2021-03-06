using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Numr.Business.Contracts;
using Numr.Business.Service;
using Numr.Business.Entities;

namespace NumrWeb.Controllers
{
    [Route("Api/Customer")]
    public class SampleDataController : Controller
    {
       private readonly ICustomerService _customerService;

        public SampleDataController(ICustomerService customerService)
        {

            _customerService = customerService;
        }
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }

        [HttpPost("get")]
        public void getTestData()
        {
           _customerService.GetCustomer("1");
        }

        // POST: Customer/Create
        [HttpGet]
        [Route("Add")]
        public void Create([FromBody] Customer cust)
        {
                _customerService.AddCustomer(cust);
                
            
        }


    }
}
