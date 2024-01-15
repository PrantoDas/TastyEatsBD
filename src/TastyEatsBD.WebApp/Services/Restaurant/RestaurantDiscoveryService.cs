using Microsoft.EntityFrameworkCore;
using TastyEatsBD.Core.DTOs;
using TastyEatsBD.Core.Entities;
using TastyEatsBD.Core.Interfaces;
using TastyEatsBD.Infrastructure.Data;

namespace TastyEatsBD.WebApp.Services.Restaurant;

public partial class RestaurantDiscoveryService : IRestaurantDiscoveryService
{
    private readonly IDbContextFactory<TastyEatsDbContext> _dbContextFactory;

    public RestaurantDiscoveryService(IDbContextFactory<TastyEatsDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<List<RestaurantInfo>> GetTopRatedRestaurantsAsync(int count)
    {
        await Task.Delay(1000);
        using var db = await CreateDbContext();

        // Query to get available restaurants
        var availableRestaurants = db.Restaurants
            .Where(restaurant => restaurant.IsAvailable);

        // Query to get available items
        var availableItems = db.Items
            .Where(item => item.IsAvailable);

        // Combine the queries, include accounts, and order by account rating
        var result = await availableRestaurants
            .Join(db.Accounts,
                  restaurant => restaurant.AccountID,
                  account => account.ID,
                  (restaurant, account) => new { Restaurant = restaurant, Account = account })
            .Join(availableItems,
                  restaurantAccount => restaurantAccount.Restaurant.ID,
                  item => item.RestaurantID,
                  (restaurantAccount, item) => new { restaurantAccount.Restaurant, restaurantAccount.Account, Item = item })
            .GroupBy(x => x.Restaurant.ID)
            .OrderByDescending(info => info.First().Account.Rating)
            .Take(count)
            .Select(group => new RestaurantInfo
            {
                Restaurant = group.First().Restaurant,
                Account = group.First().Account,
                Items = group.Select(x => x.Item).ToList()
            })
            .AsNoTracking()
            .ToListAsync();

        return result;
    }

    public async Task<List<RestaurantInfo>> SearchItemsAndResturantsAsync(string searchKey, int count)
    {
        await Task.Delay(1000);
        using var db = await CreateDbContext();


        // Query to get available restaurants
        var availableRestaurants = db.Restaurants
            .Where(restaurant => restaurant.IsAvailable);

        // Query to get available items
        var availableItems = db.Items
            .Where(item => item.IsAvailable);

        // Combine the queries, include accounts, and order by account rating
        var result = await availableRestaurants
            .Join(db.Accounts,
                  restaurant => restaurant.AccountID,
                  account => account.ID,
                  (restaurant, account) => new { Restaurant = restaurant, Account = account })
            .Join(availableItems,
                  restaurantAccount => restaurantAccount.Restaurant.ID,
                  item => item.RestaurantID,
                  (restaurantAccount, item) => new { restaurantAccount.Restaurant, restaurantAccount.Account, Item = item })
            .Where(x => x.Item.Name.Contains(searchKey) || x.Restaurant.RestaurantName.Contains(searchKey))
            .GroupBy(x => x.Restaurant.ID)
            .OrderByDescending(info => info.First().Account.Rating)
            .Take(count)
            .Select(group => new RestaurantInfo
            {
                Restaurant = group.First().Restaurant,
                Account = group.First().Account,
                Items = group.Select(x => x.Item).ToList()
            })
            .AsNoTracking()
            .ToListAsync();

        return result;
    }

    private Task<TastyEatsDbContext> CreateDbContext() => _dbContextFactory.CreateDbContextAsync();
}
