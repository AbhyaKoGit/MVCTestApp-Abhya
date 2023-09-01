using System;
using MVCTestApp.DAL.DataContext;
using MVCTestApp.DAL.Interfaces;
using MVCTestApp.Entities;

namespace MVCTestApp.DAL.Services
{
    public class CustomerRepo : ICustomerRepo
    {
        private DbDataContext _dbContext;
        public CustomerRepo(DbDataContext dbDataContext)
        {
            _dbContext = dbDataContext;
        }

        public bool AddCustomer(Customer customer)
        {
            try
            {
                _dbContext.Customer.Add(customer);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                var _customer = _dbContext.Customer.FirstOrDefault(x => x.Id == id);
                if (_customer != null)
                {
                    _dbContext.Customer.Remove(_customer);
                    _dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Customer GetCustomerById(int id)
        {
            return _dbContext.Customer.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            return _dbContext.Customer.ToList();
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                var _customer = _dbContext.Customer.FirstOrDefault(x => x.Id == customer.Id);
                if (_customer != null)
                {
                    _dbContext.Customer.Update(customer);
                    _dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}

