namespace Infrastructure_Layer.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public int MeasureOfScaleId { get; set; }

    public string ProductName { get; set; } = null!;

    public bool Instock { get; set; }

    public int InstockQty { get; set; }

    public double Price { get; set; }

    public bool NewOrUsed { get; set; }

    public DateTime SignupDate { get; set; } = DateTime.Now;

    public string? Image1 { get; set; }

    public string? Image2 { get; set; }

    public string? Image3 { get; set; }

    public string? Image4 { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category Category { get; set; } = null!;

    public virtual MeasuresOfScale MeasureOfScale { get; set; } = null!;

    public virtual ICollection<OrderdProduct> OrderdProducts { get; set; } = new List<OrderdProduct>();
}
