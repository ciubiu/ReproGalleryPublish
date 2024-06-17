using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ReproGallery.Models;

public class Order
{
    [BindNever]
    public int OrderId { get; set; }

    [Required(ErrorMessage = "Please enter your first name")]
    [Display(Name = "First Name")]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your last name")]
    [Display(Name = "Last Name")]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your address")]
    [StringLength(100)]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your zip code")]
    [Display(Name = "Zip Code")]
    [StringLength(10, MinimumLength = 5)]
    public string ZipCode { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your city")]
    [StringLength(50)]
    public string City { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your phone number")]
    [Display(Name = "Phone Number")]
    [StringLength(25)]
    public string Phone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your email address")]
    [StringLength(50)]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = string.Empty;

    public DateTime OrderDate { get; set; }
    public decimal OrderTotal { get; set; }

    public List<OrderDetail>? OrderDetails { get; set; }
}
