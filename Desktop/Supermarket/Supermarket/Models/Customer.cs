using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone {  get; set; }
        public string Password {  get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public ICollection<CustomerAddres> CustomerAddresses { get; set; }
    }
}
