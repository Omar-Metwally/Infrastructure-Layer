using System;
using System.Collections.Generic;

namespace Infrastructure_Layer.Models;

public partial class CartViewModel
{

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public int? Qty { get; set; }

    public string ProductName { get; set; }

    public string MeasureOfScaleName { get; set; }

    public string CategoryName { get; set; } = null!;

    public double Price { get; set; }

    public bool NewOrUsed { get; set; }

    public string? Image1 { get; set; }

}
