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

    public async Task<List<RestaurantInfo>> SearchItemsAndResturantsAsync(string searchKey, int count)
    {
        using var db = await CreateDbContext();

        // Query to get available restaurants
        var availableRestaurants = db.Restaurants
            .Join(db.Accounts,
                  restaurant => restaurant.AccountId,
                  account => account.Id,
                  (restaurant, account) => new { Restaurant = restaurant, Account = account })
            .Where(x => x.Restaurant.IsAvailable);

        // Query to get available items
        var availableItems = db.Items
            .Where(item => item.IsAvailable);

        var result = await availableItems
            .Join(availableRestaurants,
                  item => item.RestaurantId,
                  info => info.Restaurant.Id,
                  (item, info) => new { Item = item, Restaurant = info.Restaurant, Account = info.Account })
            .Where(x => 
                x.Item.Name.Contains(searchKey) 
                || x.Restaurant.RestaurantName.Contains(searchKey))
            .GroupBy(x => x.Restaurant.Id)
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


    public async Task<RestaurantInfo> GetResturantAsync(int restaurantID)
    {
        await Task.Delay(1000);
        using var db = await CreateDbContext();

        // Query to get available restaurants
        var restaurantInfo = await db.Restaurants
            .Join(db.Accounts,
                  restaurant => restaurant.AccountId,
                  account => account.Id,
                  (restaurant, account) => new RestaurantInfo { Restaurant = restaurant, Account = account })
            .Where(x => x.Restaurant.IsAvailable && x.Restaurant.Id == restaurantID)
            .FirstOrDefaultAsync();

        // Combine the queries, include accounts, and order by account rating
        restaurantInfo.Items = await db.Items
            .Where(item => item.IsAvailable && item.RestaurantId == restaurantID)
            .ToListAsync();

        return restaurantInfo;
    }

    private Task<TastyEatsDbContext> CreateDbContext() => _dbContextFactory.CreateDbContextAsync();
}
