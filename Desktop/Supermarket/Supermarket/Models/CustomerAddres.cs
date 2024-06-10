using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Models
{
    public class CustomerAddres
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AddresLine1 { get; set; }
        public string AddresLine2 { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public Customer Customer { get; set; }

    }
}
