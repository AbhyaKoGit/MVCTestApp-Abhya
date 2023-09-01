using System;
using MVCTestApp.Entities;
namespace MVCTestApp.DAL.Interfaces
{
	public interface ICustomerRepo
	{
		IEnumerable<Customer> GetCustomerList();

		Customer GetCustomerById(int id);

		bool AddCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

		bool DeleteCustomer(int id);


    }
}

