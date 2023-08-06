namespace Infrastructure_Layer.Models;

public partial class Governorate
{
    public int GovernorateId { get; set; }

    public string GovernorateName { get; set; } = null!;

    public virtual ICollection<District> Districts { get; set; } = new List<District>();
}
