using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TastyEatsBD.Core.Entities;

[Index(nameof(IsAvailable))]
public class Rider : EntityBase
{
    [Required(ErrorMessage = "Account Id is required")]
    [Display(Name = "Account Id")]
    public int AccountId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Account? Account { get; set; }

    [Display(Name = "Is Available")]
    public bool IsAvailable { get; set; }

    public virtual ICollection<DeliveryOrder>? DeliveryOrders { get; }
}

