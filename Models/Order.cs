using System.ComponentModel.DataAnnotations;

namespace Infrastructure_Layer.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime OrderDate { get; set; } = DateTime.Now;

    public string? OrderStatus { get; set; }

    public string? Area { get; set; }

    public string? Streat { get; set; }

    public string? House { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderdProduct> OrderdProducts { get; set; } = new List<OrderdProduct>();
}
