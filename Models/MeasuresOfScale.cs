namespace Infrastructure_Layer.Models;

public partial class MeasuresOfScale
{
    public int MeasureOfScaleId { get; set; }

    public string MeasureOfScale { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
