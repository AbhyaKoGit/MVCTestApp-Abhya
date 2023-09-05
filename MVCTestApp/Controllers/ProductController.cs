using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCTestApp.BAL.Inferaces;
using MVCTestApp.BAL.Services;
using MVCTestApp.Entities;
using MVCTestApp.Models;

namespace MVCTestApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ISupplierServices _supplierService;

        public ProductController(IProductService productService, ISupplierServices supplierService)
        {
            _productService = productService;
            _supplierService = supplierService;
        }
       
        public IActionResult Index()
        {
            var Supplierlist = new SelectList(_supplierService.GetSupplierList().OrderBy(s => s.Id), "Id", "CompanyName");

            var productlist = _productService.GetProductlist();
            List<ProductModel> list = new List<ProductModel>();
            foreach (var x in productlist)
            {
                list.Add(new ProductModel()
                {
                    Id = x.Id,
                    Package = x.Package,
                    ProductName = x.ProductName,
                    SupplierId = x.SupplierId,
                    CompanyName = x.Supplier.ContactName,
                    UnitPrice = x.UnitPrice,
                });
            }
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["SupplierData"] = new SelectList(_supplierService.GetSupplierList().OrderBy(s => s.Id), "Id", "CompanyName");

            return View();
        }


        [HttpPost]
        public IActionResult Create(ProductModel productModel)
        {
            var newProduct = new Product
            {
                Id = productModel.Id,
                Package = productModel.Package,
                ProductName = productModel.ProductName,
                SupplierId = productModel.SupplierId,
                UnitPrice = productModel.UnitPrice
            };

            _productService.AddProduct(newProduct);

            return RedirectToAction("Index");
        }
        [HttpGet]
        
        public IActionResult Update(int id)
        {
            var product = _productService.GetProductById(id);

            var model = new ProductModel
            {
                Id = product.Id,
                Package = product.Package,
                ProductName = product.ProductName,
                SupplierId = product.SupplierId,
                UnitPrice = product.UnitPrice
            };

            //var supplierList = _supplierService.GetSupplierlist().OrderByDescending(s => s.Id);

            //var selectList = new SelectList(supplierList);
            //model.Supplier  = selectList;

            ViewData["SupplierData"] = new SelectList(_supplierService.GetSupplierList().OrderBy(s => s.Id), "Id", "CompanyName");
            return View(model);
        }

        [HttpPost]
        
        public IActionResult Update(ProductModel productModel)
        {
            var updatedProduct = new Product
            {
                Id = productModel.Id,
                Package = productModel.Package,
                ProductName = productModel.ProductName,
                SupplierId = productModel.SupplierId,
                UnitPrice = productModel.UnitPrice
            };

            _productService.UpdateProduct(updatedProduct);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _productService.GetProductById(id);

            var model = new ProductModel
            {
                Id = product.Id,
                Package = product.Package,
                ProductName = product.ProductName,
                SupplierId = product.SupplierId,
                UnitPrice = product.UnitPrice

            };

            return View(model);

        }

        [HttpPost]
        public IActionResult DeleteProduct(int Id)
        {
            _productService.DeleteProduct(Id);

            return RedirectToAction("Index");
        }

    }
}
