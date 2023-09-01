using System;
using MVCTestApp.BAL.Inferaces;
using MVCTestApp.DAL.Interfaces;
using MVCTestApp.Entities;

namespace MVCTestApp.BAL.Services
{
    public class CustomerServices : ICustomerServices

    {
        private readonly ICustomerRepo _customerRepo;
        public CustomerServices(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public bool AddCustomer(Customer customer)
        {
            return _customerRepo.AddCustomer(customer);
        }

        public bool DeleteCustomer(int id)
        {
            return _customerRepo.DeleteCustomer(id);
        }

        public Customer GetCustomerById(int id)
        {
            return _customerRepo.GetCustomerById(id);
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            return _customerRepo.GetCustomerList();
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _customerRepo.UpdateCustomer(customer);
        }

    }
}

