using System;
using MVCTestApp.BAL.Inferaces;
using MVCTestApp.DAL.Interfaces;
using MVCTestApp.DAL.Services;
using MVCTestApp.Entities;

namespace MVCTestApp.BAL.Services
{
    public class SupplierServices : ISupplierServices
    {
        private readonly ISupplierRepo _supplierRepo;
        public SupplierServices(ISupplierRepo supplierRepo)
        {
            _supplierRepo = supplierRepo;
        }

        public bool AddSupplier(Supplier supplier)
        {
            return _supplierRepo.AddSupplier(supplier);
        }

        public bool DeleteSupplier(int id)
        {
            return _supplierRepo.DeleteSupplier(id);
        }

        public Supplier GetSupplierById(int id)
        {
            return _supplierRepo.GetSupplierById(id);
        }

        public IEnumerable<Supplier> GetSupplierList()
        {
            return _supplierRepo.GetSupplierList();

        }

        public bool UpdateSupplier(Supplier supplier)
        {
            return _supplierRepo.UpdateSupplier(supplier);
        }

        
    }
}

