using System.ComponentModel.DataAnnotations;

namespace Infrastructure_Layer.Models;

public partial class Customer
{
    
    public int? CustomerId { get; set; }
    [Required(ErrorMessage = "Please enter your first name")]
    [MinLength(3, ErrorMessage = "A name must be at least 3 letters")]
    [MaxLength(15, ErrorMessage = "A name cannot be more than 15 letters")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter your first name in English letters")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your middle name")]
    [MinLength(3, ErrorMessage = "A name must be at least 3 letters")]
    [MaxLength(15, ErrorMessage = "A name cannot be more than 15 letters")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter your middle name in English letters")]
    public string MiddleName { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your last name")]
    [MinLength(3, ErrorMessage = "A name must be at least 3 letters")]
    [MaxLength(15, ErrorMessage = "A name cannot be more than 15 letters")]
    [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter your last name in English letters")]
    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your phone number")]
    [MinLength(11, ErrorMessage = "A phone number should contain 11 digits")]
    [MaxLength(11, ErrorMessage = "A phone number should contain 11 digits")]
    [RegularExpression(@"^(010|012|011|015)\d{8}$", ErrorMessage = "A phone number must start with 010, 011, 012 ,015")]
    public string Phone { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your email address")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    [RegularExpression(@"\b\S+@(gmail|hotmail|yahoo)\.com\b", ErrorMessage = "At the moment we only accept Gmail, Yahoo, Hotmail")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Please enter a password")]
    [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$",
    ErrorMessage = "Password must be at least 8 characters long and contain at least 1 letter, 1 number")]
    public string Password { get; set; } = null!;

    public DateTime CreateDate { get; set; } = DateTime.Now!;

    public bool? Admin { get; set; }

    public string? Cookie { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
