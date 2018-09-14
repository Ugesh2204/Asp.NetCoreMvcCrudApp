using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomersAppMvcAspCore.Data;
using Microsoft.AspNetCore.Mvc;

namespace CustomersAppMvcAspCore.Controllers
{
    public class CustomerController : Controller
    {
        //Dependency inject
        CustomerDbContext customerDbContext;

        //Create a construct

        public CustomerController(CustomerDbContext _customerDbContext)
        {
            customerDbContext = _customerDbContext;

        }




        public IActionResult Index()
        {
            //CustomerDbContext customerDbContext = new CustomerDbContext();
            var customers = customerDbContext.Customers.ToList();
            return View(customers);
        }
    }
}