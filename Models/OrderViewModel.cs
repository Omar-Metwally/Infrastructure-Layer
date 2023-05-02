namespace Infrastructure_Layer.Models;

public partial class OrderViewModel
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public string MeasureOfScaleName { get; set; }

    public string CategoryName { get; set; } = null!;

    public int Qty { get; set; }

    public double Total { get; set; }

    public DateTime OrderDate { get; set; } = DateTime.Now!;

    public string? Image1 { get; set; }

    public bool NewOrUsed { get; set; }

    public string? Description { get; set; }

    public string CustomerName { get; set; }
}