using System;
using MVCTestApp.Entities;

namespace MVCTestApp.DAL.Interfaces
{
	public interface ISupplierRepo
	{
        IEnumerable<Supplier> GetSupplierList();

        Supplier GetSupplierById(int id);

        bool AddSupplier(Supplier supplier);

        bool UpdateSupplier(Supplier ssupplier);

        bool DeleteSupplier(int id);



    }
}

