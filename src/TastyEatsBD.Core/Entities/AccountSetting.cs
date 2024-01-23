using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TastyEatsBD.Core.Entities;

public class AccountSetting : EntityBase
{
    [Required(ErrorMessage = "Account ID is required")]
    [Display(Name = "Account ID")]
    public int AccountId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Account? Account { get; set; }

    [Display(Name = "Dark Mode Enabled")]
    public bool IsDarkMode { get; set; }

    [StringLength(10, ErrorMessage = "Theme color must be less than {1} characters")]
    [Display(Name = "Theme Color")]
    public string? ThemeColor { get; set; }

}

