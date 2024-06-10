namespace Supermarket.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string SKU { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public DateTime DeletedAt { get; set; }

    public int CategoryId { get; set; }
    public virtual ProductCategory ProductCategory { get; set; }

    public int InventoryId { get; set; }
    public virtual ProductInventory ProductInventory { get; set; }
}
