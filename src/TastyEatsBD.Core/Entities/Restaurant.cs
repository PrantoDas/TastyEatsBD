using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace TastyEatsBD.Core.Entities;

[Index(nameof(IsAvailable))]
public class Restaurant : EntityBase
{
    [Required(ErrorMessage = "Account Id is required")]
    [Display(Name = "Account Id")]
    public int AccountId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Account? Account { get; set; }

    [Required(ErrorMessage = "Restaurant name is required")]
    [StringLength(100, ErrorMessage = "Restaurant name must be under {1} characters")]
    [Display(Name = "Restaurant Name")]
    public string RestaurantName { get; set; }

    [Required(ErrorMessage = "Location Id is required")]
    [Display(Name = "Location Id")]
    public int LocationId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Location? Location { get; set;}

    [Display(Name = "Is Available")]
    public bool IsAvailable { get; set; }

    public virtual ICollection<Item>? Items { get; }

    public virtual ICollection<DeliveryOrder>? DeliveryOrders { get; }
}

