using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TastyEatsBD.Core.Entities;

public class Cart : EntityBase
{
    [Display(Name = "Total Price")]
    [Column(TypeName = "decimal(10, 2)")]
    public decimal TotalPrice { get; set; }

    [Required(ErrorMessage = "Account Id is required")]
    [Display(Name = "Account Id")]
    public int AccountId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Account? Account { get; set; }

    public virtual ICollection<CartItem>? CartItems { get; }
}