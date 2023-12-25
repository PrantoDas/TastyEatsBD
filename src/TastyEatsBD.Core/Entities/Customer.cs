using System.ComponentModel.DataAnnotations;

namespace TastyEatsBD.Core.Entities;

public class Customer : EntityBase
{
    [Required(ErrorMessage = "Account ID is required")]
    [Display(Name = "Account ID")]
    public int AccountID { get; set; }
}
