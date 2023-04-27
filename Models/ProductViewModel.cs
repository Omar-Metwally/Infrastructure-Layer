namespace Infrastructure_Layer.Models;

public partial class ProductViewModel
{
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public string MeasureOfScaleName { get; set; }

    public string CategoryName { get; set; } = null!;

    public int InstockQty { get; set; }

    public double Price { get; set; }

    public bool NewOrUsed { get; set; }

    public DateTime SignupDate { get; set; }

    public string? Image1 { get; set; }

    public string? Image2 { get; set; }

    public string? Image3 { get; set; }

    public string? Image4 { get; set; }

    public string? Description { get; set; }

    public string? Phone { get; set; }
}