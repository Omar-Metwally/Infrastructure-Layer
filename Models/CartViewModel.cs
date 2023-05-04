namespace Infrastructure_Layer.Models;

public partial class CartViewModel : Cart
{

    public string ProductName { get; set; }

    public string MeasureOfScaleName { get; set; }

    public string CategoryName { get; set; } = null!;

    public double Price { get; set; }

    public bool NewOrUsed { get; set; }

    public string? Image1 { get; set; }

    public double Total { get; set; }

    public string? Area { get; set; }

    public string? Streat { get; set; }

    public string? House { get; set; }

}
