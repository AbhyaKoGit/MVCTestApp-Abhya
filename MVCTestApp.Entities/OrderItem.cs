using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestApp.Entities
{
    internal class OrderItem
    {
        public int Id { get; set; }

        public string OrderName { get; set; }

        public int OrderId { get; set; }
        [ForeignKey(OrderName)]

    }
}
