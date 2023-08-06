namespace Infrastructure_Layer.Models;

public partial class District
{
    public int DistrictId { get; set; }

    public string DistrictName { get; set; } = null!;

    public int GovernorateId { get; set; }

    public virtual Governorate Governorate { get; set; } = null!;

    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();
}
