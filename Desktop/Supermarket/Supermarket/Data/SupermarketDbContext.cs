using Microsoft.EntityFrameworkCore;
using Supermarket.Models;
namespace Supermarket.Data
{
    internal class SupermarketDbContext : DbContext
    {
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductInventory> ProductInventory { get; set; }
        public virtual DbSet<Product>Products { get; set; }
        public virtual DbSet<Customer>  Customers { get; set; }
        public virtual DbSet<CustomerAddres> CustomerAddres { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }

        public SupermarketDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HP-PC\SQLEXPRESS;Initial Catalog=SupermarketManagementOtabek;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
