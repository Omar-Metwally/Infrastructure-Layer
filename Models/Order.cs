﻿namespace Infrastructure_Layer.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public int Qty { get; set; }

    public double Total { get; set; }

    public DateTime OrderDate { get; set; } = DateTime.Now!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
