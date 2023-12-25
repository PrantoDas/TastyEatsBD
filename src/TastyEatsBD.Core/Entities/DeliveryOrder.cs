using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TastyEatsBD.Core.Entities;

public class DeliveryOrder : EntityBase
{
    [Required(ErrorMessage = "Order ID is required")]
    [Display(Name = "Order ID")]
    public int OrderID { get; set; }

    [Required(ErrorMessage = "Restaurant ID is required")]
    [Display(Name = "Restaurant ID")]
    public int RestaurantID { get; set; }

    [Required(ErrorMessage = "Rider ID is required")]
    [Display(Name = "Rider ID")]
    public int RiderID { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
    [Display(Name = "Pickup Time")]
    public DateTime? PickupTime { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
    [Display(Name = "Delivery Time")]
    public DateTime? DeliveryTime { get; set; }

    [Range(0, 5, ErrorMessage = "Rating must be between {1} and {2}")]
    [Column(TypeName = "decimal(1, 1)")]
    [Display(Name = "Rating")]
    public decimal? Rating { get; set; }
}