namespace Infrastructure_Layer.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public int MeasureOfScaleId { get; set; }

    public int BrandId { get; set; }

    public string ProductName { get; set; } = "No name";

    public bool Instock { get; set; } = false;

    public int InstockQty { get; set; } = 0;

    public double Price { get; set; } = 0.0;

    public bool NewOrUsed { get; set; } = true;

    public DateTime SignupDate { get; set; } = DateTime.Now;

    public string Size { get; set; } = null!;

    public string? Image1 { get; set; } = "No Image";

    public string? Image2 { get; set; } = "No Image";

    public string? Image3 { get; set; } = "No Image";

    public string? Image4 { get; set; } = "No Image";

    public string? Description { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category Category { get; set; } = null!;

    public virtual MeasuresOfScale MeasureOfScale { get; set; } = null!;

    public virtual ICollection<OrderdProduct> OrderdProducts { get; set; } = new List<OrderdProduct>();
}
