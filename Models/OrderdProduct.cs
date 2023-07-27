namespace Infrastructure_Layer.Models;

public partial class OrderdProduct
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Qty { get; set; }

    public double Total { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
