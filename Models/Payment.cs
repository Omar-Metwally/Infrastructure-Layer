namespace Infrastructure_Layer.Models;

public partial class Payment
{
    public int OrderId { get; set; }

    public string CardName { get; set; } = null!;

    public string CardNumber { get; set; } = null!;

    public string Cvc { get; set; } = null!;

    public string ExpireDate { get; set; } = null!;

    public double PaymentAmount { get; set; }

    public virtual Order Order { get; set; } = null!;
}
