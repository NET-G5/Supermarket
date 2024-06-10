using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Models
{
    public class ProductInventory
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
