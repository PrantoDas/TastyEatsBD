using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TastyEatsBD.Core.Entities;

public class Customer : EntityBase
{
    [Required(ErrorMessage = "Account Id is required")]
    [Display(Name = "Account Id")]
    public int AccountId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Account? Account { get; set; }

    public virtual ICollection<Order>? Orders { get; }
}
