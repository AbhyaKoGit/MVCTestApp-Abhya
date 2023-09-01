using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTestApp.BAL.Inferaces;
using MVCTestApp.BAL.Services;
using MVCTestApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTestApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices)

        {

            _customerServices = customerServices;
        }


        public IActionResult Index()
        {
            var customerlist = _customerServices.GetCustomerList();
            List<CustomerModel> list = new List<CustomerModel>();
            foreach (var customer in customerlist)
            {
                list.Add(new CustomerModel()
                {
                    Id = customer.Id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Country = customer.Country,
                    Phone = customer.Phone,
                    City = customer.City
                });
            }
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {

            var customerlist = _customerServices.GetCustomerById(id);
            return View(customerlist);
        }




    }
}

