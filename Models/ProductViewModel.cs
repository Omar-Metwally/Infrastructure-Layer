namespace Infrastructure_Layer.Models;

public partial class ProductViewModel
{
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public string MeasureOfScaleName { get; set; }

    public string CategoryName { get; set; } = null!;

    public int InstockQty { get; set; } = 0;

    public double Price { get; set; } = 0.0;

    public bool NewOrUsed { get; set; } = true;

    public DateTime SignupDate { get; set; } = DateTime.Now;

    public string? Image1 { get; set; } = "No Image";

    public string? Image2 { get; set; } = "No Image";

    public string? Image3 { get; set; } = "No Image";

    public string? Image4 { get; set; } = "No Image";

    public string? Description { get; set; } = "No Description";

}