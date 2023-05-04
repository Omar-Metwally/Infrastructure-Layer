namespace Infrastructure_Layer.Models;

public partial class ProductViewModel : Product
{
    public string CategoryName { get; set; } = null!;

    public string? BrandName { get; set; }

    public string MeasureOfScaleName { get; set; }
}