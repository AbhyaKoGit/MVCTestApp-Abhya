using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCTestApp.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public Decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public string CompanyName { get; set; }


    }
}
