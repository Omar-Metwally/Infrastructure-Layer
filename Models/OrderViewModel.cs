namespace Infrastructure_Layer.Models;

public partial class OrderViewModel : Order
{

    public int ProductId { get; set; }

    public string ProductName { get; set; } = "No Product Name";

    public string MeasureOfScaleName { get; set; } = "No Scale";

    public string CategoryName { get; set; } = null!;

    public int Qty { get; set; }

    public double Total { get; set; }

    public string? Image1 { get; set; }

    public bool NewOrUsed { get; set; }

    public string? Description { get; set; }

    public string CustomerName { get; set; } = "Error No customer name";

    public string Brand { get; set; }

    public string Size { get; set; }

    public DateTime OrderDate { get; set; }
	public string Phone { get; set; }
	public string Location { get; set; }
}