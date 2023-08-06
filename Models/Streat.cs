namespace Infrastructure_Layer.Models;

public partial class Street
{
    public int StreetId { get; set; }

    public string StreetName { get; set; } = null!;

    public int DistrictId { get; set; }

    public virtual District District { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
