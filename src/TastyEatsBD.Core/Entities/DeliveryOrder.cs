using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TastyEatsBD.Core.Entities;

public class DeliveryOrder : EntityBase
{
    [Required(ErrorMessage = "Order Id is required")]
    [Display(Name = "Order Id")]
    public int OrderId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Order? Order { get; set; }

    [Required(ErrorMessage = "Restaurant Id is required")]
    [Display(Name = "Restaurant Id")]
    public int RestaurantId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Restaurant? Restaurant { get; set; }

    [Required(ErrorMessage = "Rider Id is required")]
    [Display(Name = "Rider Id")]
    public int RiderId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Rider? Rider { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
    [Display(Name = "Pickup Time")]
    public DateTime? PickupTime { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
    [Display(Name = "Delivery Time")]
    public DateTime? DeliveryTime { get; set; }

    [Range(0, 5, ErrorMessage = "Rating must be between {1} and {2}")]
    [Column(TypeName = "decimal(2, 1)")]
    [Display(Name = "Rating")]
    public float? Rating { get; set; }
}