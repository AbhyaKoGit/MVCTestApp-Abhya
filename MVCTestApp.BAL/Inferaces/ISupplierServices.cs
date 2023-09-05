using System;
using MVCTestApp.Entities;

namespace MVCTestApp.BAL.Inferaces
{
	public interface ISupplierServices
	{
        IEnumerable<Supplier> GetSupplierList();

        Supplier GetSupplierById(int id);

        bool AddSupplier(Supplier customer);

        bool UpdateSupplier(Supplier supplier);

        bool DeleteSupplier(int id);










    }
}

