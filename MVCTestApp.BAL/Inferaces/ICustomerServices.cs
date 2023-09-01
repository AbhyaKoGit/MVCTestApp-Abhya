using System;
using MVCTestApp.Entities;

namespace MVCTestApp.BAL.Inferaces
{
	public interface ICustomerServices
	{



        IEnumerable<Customer> GetCustomerList();

        Customer GetCustomerById(int id);

        bool AddCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        bool DeleteCustomer(int id);
        
    }


}

