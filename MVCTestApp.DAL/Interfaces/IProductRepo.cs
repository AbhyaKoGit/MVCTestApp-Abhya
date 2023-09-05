using MVCTestApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.DAL.Interfaces
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProductList();
        Product GetProductById(int id); 
        bool AddProduct (Product product);
        bool UpdateProduct (Product product);
        bool DeleteProduct (int id);
        
    }
}
