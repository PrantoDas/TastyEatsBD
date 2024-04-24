using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using TastyEatsBD.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;

namespace TastyEatsBD.WebApp.Services.Identity
{
    internal sealed class IdentityUserAccessor
    {
        private readonly UserManager<AppIdentityUser> userManager;
        private readonly IdentityRedirectManager redirectManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IMemoryCache memoryCache;

        public IdentityUserAccessor(
            UserManager<AppIdentityUser> userManager,
            IdentityRedirectManager redirectManager,
            IHttpContextAccessor httpContextAccessor,
            IMemoryCache memoryCache)
        {
            this.userManager = userManager;
            this.redirectManager = redirectManager;
            this.httpContextAccessor = httpContextAccessor;
            this.memoryCache = memoryCache;
        }

        public async Task<AppIdentityUser> GetRequiredUserAsync(HttpContext context)
        {
            string userId = userManager.GetUserId(context.User);
            if (string.IsNullOrEmpty(userId))
            {
                redirectManager.RedirectToWithStatus("Account/Login", "Error: Unable to load user ID.", context);
                return null;
            }

            AppIdentityUser user = await memoryCache.GetOrCreateAsync($"AppIdentityUser_{userId}", async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromMinutes(5); // Cache duration
                return await userManager.GetUserAsync(context.User).ConfigureAwait(false);
            }).ConfigureAwait(false);

            if (user == null)
            {
                redirectManager.RedirectToWithStatus("Account/Login", $"Error: Unable to load user with ID '{userId}'.", context);
            }

            return user;
        }

        public Task<AppIdentityUser> GetCurrentUserAsync()
        {
            return GetRequiredUserAsync(httpContextAccessor.HttpContext);
        }
    }
}
