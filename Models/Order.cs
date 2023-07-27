namespace Infrastructure_Layer.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime OrderDate { get; set; }

    public string OrderStatus { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Streat { get; set; } = null!;

    public string House { get; set; } = null!;

    public bool Delivered { get; set; }

    public bool PayedByVisa { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderdProduct> OrderdProducts { get; set; } = new List<OrderdProduct>();

    public virtual Payment? Payment { get; set; }
}