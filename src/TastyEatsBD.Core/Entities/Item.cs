using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TastyEatsBD.Core.Entities;

public class Item : EntityBase
{
    [Required(ErrorMessage = "Restaurant ID is required")]
    [Display(Name = "Restaurant ID")]
    public int RestaurantID { get; set; }

    [Required(ErrorMessage = "Item name is required")]
    [StringLength(50, ErrorMessage = "Item name must be less than {1} characters")]
    [Display(Name = "Item Name")]
    public string ItemName { get; set; }

    [Required(ErrorMessage = "Price is required")]
    [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value")]
    [Column(TypeName = "decimal(10, 2)")]
    [DataType(DataType.Currency)]
    [Display(Name = "Price")]
    public decimal Price { get; set; }

    [StringLength(300, ErrorMessage = "Description must be less than {1} characters")]
    [Display(Name = "Description")]
    public string Description { get; set; }

    [Range(0, 100, ErrorMessage = "Discount must be between {1}% and {2}%")]
    [Display(Name = "Discount")]
    public int? Discount { get; set; }

    [Display(Name = "Is Available")]
    public bool IsAvailable { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Preparation time must be a positive number of minutes")]
    [Display(Name = "Preparation Time (minutes)")]
    public int? PreparationTime { get; set; }

    [StringLength(300, ErrorMessage = "Photo URL must be less than {1} characters")]
    [DataType(DataType.ImageUrl, ErrorMessage = "Invalid URL format")]
    [Display(Name = "Photo URL")]
    public string? PhotoURL { get; set; }
}
