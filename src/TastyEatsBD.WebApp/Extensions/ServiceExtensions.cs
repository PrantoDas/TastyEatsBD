
// Service Extensions
using Microsoft.Extensions.DependencyInjection;
using TastyEatsBD.Core.Interfaces;
using TastyEatsBD.WebApp.Services.Account;
using TastyEatsBD.WebApp.Services.Cart;
using TastyEatsBD.WebApp.Services.Identity;
using TastyEatsBD.WebApp.Services.Restaurant;
using TastyEatsBD.WebApp.Services.Storage;
using TastyEatsBD.WebApp.Services.Theme;

public static class ServiceExtensions
{
    /// <summary>
    /// Add application specific custom services
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ThemeService>();
        services.AddScoped<IdentityManagementService>();
        services.AddScoped<IAccountService, AccountService>();
        services.AddScoped<IFileService, LocalDriveStorageService>();
        services.AddScoped<IRestaurantDiscoveryService, RestaurantDiscoveryService>();
        services.AddScoped<ICartService, CartService>();

        services.AddCascadingValue<CartState>(sp => new CartState());

        return services;
    }
}
