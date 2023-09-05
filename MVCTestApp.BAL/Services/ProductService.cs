using MVCTestApp.BAL.Inferaces;
using MVCTestApp.DAL.Interfaces;
using MVCTestApp.DAL.Services;
using MVCTestApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.BAL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
           

        public ProductService(IProductRepo productRepo) 
        {
            _productRepo = productRepo;
        }

        public bool AddProduct(Product product)
        {
            return _productRepo.AddProduct(product);
        }

        public bool DeleteProduct(int id)
        {
            return _productRepo.DeleteProduct(id);
        }

        public Product GetProductById(int id)
        {
            return _productRepo.GetProductById(id);
        }

        public IEnumerable<Product> GetProductlist()
        {
            return _productRepo.GetProductList();
        }

        public bool UpdateProduct(Product product)
        {
            return _productRepo.UpdateProduct(product);
        }
    }
}
