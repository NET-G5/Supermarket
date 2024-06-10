using Microsoft.EntityFrameworkCore;
using Supermarket.Models;
using System.Configuration;

namespace Supermarket.Data;

internal class SupermarketDbContext : DbContext
{
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<CustomerAddress> CustomersAddress { get; set; }
    public virtual DbSet<OrderDetails> OrderDetails { get; set; }
    public virtual DbSet<OrderItems> OrderItems { get; set; }
    public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    public virtual DbSet<ProductInventory> ProductInventory { get; set; }

    public SupermarketDbContext()
    {
        Database.SetCommandTimeout(TimeSpan.FromMinutes(10));
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=desktop-qrmohru;Initial Catalog=Supermarket_System;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .ToTable(nameof(Product));
        modelBuilder.Entity<Product>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<Customer>()
            .ToTable(nameof(Customer));
        modelBuilder.Entity<Customer>()
            .HasKey(c  => c.Id);

        modelBuilder.Entity<CustomerAddress>()
            .ToTable(nameof(CustomerAddress));
        modelBuilder.Entity<CustomerAddress>()
            .HasKey(c => c.Id);

        modelBuilder.Entity<OrderDetails>()
            .ToTable(nameof(OrderDetails));
        modelBuilder.Entity<OrderDetails>()
            .HasKey(o => o.Id);

        modelBuilder.Entity<OrderItems>()
            .ToTable(nameof(OrderItems));
        modelBuilder.Entity<OrderItems>()
            .HasKey(o => o.Id);

        modelBuilder.Entity<ProductCategory>()
            .ToTable(nameof(ProductCategory));
        modelBuilder.Entity<ProductCategory>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<ProductInventory>()
            .ToTable(nameof(ProductInventory));
        modelBuilder.Entity<ProductInventory>()
            .HasKey(p => p.Id);

        base.OnModelCreating(modelBuilder);
    }
}
