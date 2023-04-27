namespace Infrastructure_Layer.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public int Qty { get; set; }

    public int Total { get; set; }

    public string OrderDate { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
