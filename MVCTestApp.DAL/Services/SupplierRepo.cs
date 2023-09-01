using System;
using MVCTestApp.DAL.DataContext;
using MVCTestApp.DAL.Interfaces;
using MVCTestApp.Entities;

namespace MVCTestApp.DAL.Services
{
    public class SupplierRepo : ISupplierRepo

    {
        private DbDataContext _dbContext;
        public SupplierRepo(DbDataContext dbDataContext)
        {
            _dbContext = dbDataContext;
        }

        public bool AddSupplier(Supplier supplier)
        {
            try
            {
                _dbContext.Supplier.Add(supplier);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteSupplier(int id)
        {
            try
            {
                var _supplier = _dbContext.Supplier.FirstOrDefault(x => x.Id == id);
                if (_supplier != null)
                {
                    _dbContext.Supplier.Remove(_supplier);
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

        public Supplier GetSupplierById(int id)
        {
            return _dbContext.Supplier.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Supplier> GetSupplierList()
        {
            return _dbContext.Supplier.ToList();
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            try
            {
                var _supplier = _dbContext.Supplier.FirstOrDefault(x => x.Id == supplier.Id);
                if (_supplier != null)
                {
                    _dbContext.Supplier.Update(supplier);
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

