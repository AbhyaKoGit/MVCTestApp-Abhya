using MVCTestApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.BAL.Inferaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetProductlist();
        Product GetProductById(int id);
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
   }
}
