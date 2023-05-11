namespace Infrastructure_Layer.Models;

public partial class Cart
{
    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public int? Qty { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
