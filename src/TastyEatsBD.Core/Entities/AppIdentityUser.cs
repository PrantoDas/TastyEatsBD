using Microsoft.AspNetCore.Identity;

namespace TastyEatsBD.Core.Entities;
public class AppIdentityUser : IdentityUser
{
    public int AccountId { get; set; }
}
