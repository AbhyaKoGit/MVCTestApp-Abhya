using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.Entities
{
    public class Product
    {
        [Key] 
        public int Id { get; set; }
        public string ProductName { get; set; }
       
        [ForeignKey("SupplierId")]

        public int SupplierId { get; set; }
        public Decimal UnitPrice { get; set;}
        public string Package { get; set; }

        public Supplier Supplier { get; set; }

    }
}
