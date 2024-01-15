using Microsoft.AspNetCore.Identity;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.WebApp.Services.Identity
{
    internal sealed class IdentityUserAccessor(UserManager<AppIdentityUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<AppIdentityUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);
            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/Login", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }
            return user;
        }
    }
}
