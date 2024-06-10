using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Models
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int OrderId {  get; set; }
        public int ProductId {  get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set;}
        public OrderDetails OrderDetails { get; set; }
        public Product Product { get; set; }

    }
}
