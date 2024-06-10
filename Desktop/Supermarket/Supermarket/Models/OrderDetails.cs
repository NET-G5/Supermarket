namespace Supermarket.Models;

public class OrderDetails
{
    public int Id { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    public decimal Total { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set;}
}
