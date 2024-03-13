using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components.DesignTokens;
using TastyEatsBD.Infrastructure.Data;
using TastyEatsBD.WebApp.Services.Identity;

namespace TastyEatsBD.WebApp.Components.Theme;

internal class ThemeService
{
    private readonly BaseLayerLuminance _baseLayerLuminance;
    private readonly AccentBaseColor _accentBaseColor;
    private readonly IDbContextFactory<TastyEatsDbContext> _dbContextFactory;
    private readonly IdentityUserAccessor _identityUserAccessor;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ThemeService(
        BaseLayerLuminance baseLayerLuminance,
        AccentBaseColor AccentBaseColor,
        IDbContextFactory<TastyEatsDbContext> dbContextFactory,
        IdentityUserAccessor identityUserAccessor,
        IHttpContextAccessor httpContextAccessor)
    {
        _baseLayerLuminance = baseLayerLuminance;
        _accentBaseColor = AccentBaseColor;
        _dbContextFactory = dbContextFactory;
        _identityUserAccessor = identityUserAccessor;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task SetUserThemeAsync()
    {
        if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated == false)
        {
            return;
        }

        var user = await _identityUserAccessor.GetRequiredUserAsync(_httpContextAccessor.HttpContext);

        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var userSettings = await dbContext.AccountSettings.Where(a => a.AccountId == user.AccountId).FirstOrDefaultAsync();

        if (userSettings == null)
            return;

        SetLuminance(userSettings.IsDarkMode ? StandardLuminance.DarkMode : StandardLuminance.LightMode);
        SetThemeColor(userSettings.ThemeColor);
    }
    public async Task<(StandardLuminance Luminance, string Color)> GetUserThemeAsync()
    {
        var user = await _identityUserAccessor.GetRequiredUserAsync(_httpContextAccessor.HttpContext);

        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var userSettings = await dbContext.AccountSettings.Where(a => a.AccountId == user.AccountId).FirstOrDefaultAsync();

        if (userSettings == null)
            return (StandardLuminance.LightMode, "default");

        return (userSettings.IsDarkMode ? StandardLuminance.DarkMode : StandardLuminance.LightMode, userSettings.ThemeColor);
    }

    public async Task ChangeLuminanceAsync(StandardLuminance luminance)
    {
        SetLuminance(luminance);
        await UpdateLuminanceAsync(luminance);
    }

    public async Task ChangeThemeColor(string color)
    {
        SetThemeColor(color);
        await UpdateThemeColorAsync(color);
    }

    private async Task UpdateLuminanceAsync(StandardLuminance luminance)
    {
        var user = await _identityUserAccessor.GetRequiredUserAsync(_httpContextAccessor.HttpContext);

        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var userSettings = await dbContext.AccountSettings.Where(a => a.AccountId == user.AccountId).FirstOrDefaultAsync();

        if (userSettings == null)
        {
            userSettings = new()
            {
                AccountId = user.AccountId,
                IsDarkMode = luminance == StandardLuminance.DarkMode
            };
            await dbContext.AddAsync(userSettings);
        }
        else
        {
            userSettings.ModifiedOn = DateTime.UtcNow;
            userSettings.IsDarkMode = luminance == StandardLuminance.DarkMode;
            dbContext.Update(userSettings);
        }
        await dbContext.SaveChangesAsync();
    }


    private async Task UpdateThemeColorAsync(string color)
    {
        var user = await _identityUserAccessor.GetRequiredUserAsync(_httpContextAccessor.HttpContext);

        using var dbContext = await _dbContextFactory.CreateDbContextAsync();
        var userSettings = await dbContext.AccountSettings.Where(a => a.AccountId == user.AccountId).FirstOrDefaultAsync();

        if (userSettings == null)
        {
            userSettings = new()
            {
                AccountId = user.AccountId,
                ThemeColor = color
            };
            await dbContext.AddAsync(userSettings);
        }
        else
        {
            userSettings.ModifiedOn = DateTime.UtcNow;
            userSettings.ThemeColor = color;
            dbContext.Update(userSettings);
        }
        await dbContext.SaveChangesAsync();
    }

    private void SetLuminance(StandardLuminance luminance) => _baseLayerLuminance.WithDefault(luminance.GetLuminanceValue());

    private void SetThemeColor(string color) => _accentBaseColor.WithDefault(color.ToSwatch());
}
