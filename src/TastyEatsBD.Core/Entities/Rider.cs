using System.ComponentModel.DataAnnotations;

namespace TastyEatsBD.Core.Entities;

public class Rider : EntityBase
{
    [Required(ErrorMessage = "Account ID is required")]
    [Display(Name = "Account ID")]
    public int AccountID { get; set; }

    [Display(Name = "Is Available")]
    public bool IsAvailable { get; set; }
}
