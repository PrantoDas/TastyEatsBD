using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TastyEatsBD.Core.Entities;

public class CartItem : EntityBase
{
    [Required]
    [Display(Name = "Quantity")]
    public int Quantity { get; set; }

    [Required]
    [Display(Name = "Cart ID")]
    public int CartId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Cart? Cart { get; set;  }

    [Required]
    [Display(Name = "Item ID")]
    public int ItemId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Item? Item { get; set; }
}


