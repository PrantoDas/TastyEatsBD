using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TastyEatsBD.Core.Enums;

namespace TastyEatsBD.Core.Entities;

public class Account : EntityBase
{
    [Required(ErrorMessage = "Account type is required")]
    [Display(Name = "Account Type")]
    public AccountType AccountType { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, ErrorMessage = "Name must be less than {1} characters")]
    [Display(Name = "Name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [StringLength(50, ErrorMessage = "Email must be less than {1} characters")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Range(0, 5, ErrorMessage = "Rating must be between {1} and {2}")]
    [Column(TypeName = "decimal(1, 1)")]
    [Display(Name = "Rating")]
    public decimal? Rating { get; set; }

    [StringLength(300, ErrorMessage = "Profile image URL must be less than {1} characters")]
    [Display(Name = "Profile Image URL")]
    [DataType(DataType.ImageUrl, ErrorMessage = "Invalid URL format")]
    public string? ProfileImageURL { get; set; }
}