using System.ComponentModel.DataAnnotations;

namespace TastyEatsBD.Core.Entities;

public class Restaurant : EntityBase
{
    [Required(ErrorMessage = "Account ID is required")]
    [Display(Name = "Account ID")]
    public int AccountID { get; set; }

    [Required(ErrorMessage = "Restaurant name is required")]
    [StringLength(100, ErrorMessage = "Restaurant name must be under {1} characters")]
    [Display(Name = "Restaurant Name")]
    public string RestaurantName { get; set; }

    [Required(ErrorMessage = "Location ID is required")]
    [Display(Name = "Location ID")]
    public int LocationID { get; set; }

    [Display(Name = "Is Available")]
    public bool IsAvailable { get; set; }
}

