using Microsoft.EntityFrameworkCore;
using MVCTestApp.DAL.DataContext;
using MVCTestApp.DAL.Interfaces;
using MVCTestApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.DAL.Services
{
    public class ProductRepo : IProductRepo
    {
        private DbDataContext _dbcontext;
        public ProductRepo(DbDataContext dbDataContext) 
        {
            _dbcontext = dbDataContext;
        }
        public bool AddProduct(Product product)
        {
            try
            {
                _dbcontext.Product.Add(product);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool DeleteProduct(int id)
        {
            try
            {
                var _product = _dbcontext.Product.FirstOrDefault(x => x.Id == id);
                if (_product != null)
                {
                    _dbcontext.Product.Remove(_product);
                    _dbcontext.SaveChanges();
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

        public Product GetProductById(int id)
        {
            return _dbcontext.Product.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProductList()
        {
            return _dbcontext.Product.Include(x => x.Supplier).AsNoTracking().ToList();
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                    _dbcontext.Product.Update(product);
                    _dbcontext.SaveChanges();
                    return true;
            }              
            
            catch (Exception ex)
            {
                return false;
            }
        }
       
    }
}
