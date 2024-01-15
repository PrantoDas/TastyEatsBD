using Microsoft.EntityFrameworkCore;
using TastyEatsBD.Core.Entities;
using TastyEatsBD.Core.Interfaces;
using TastyEatsBD.Infrastructure.Data;

namespace TastyEatsBD.WebApp.Services.Restaurant;

public class RestaurantDiscoveryService : IRestaurantDiscoveryService
{
    private readonly IDbContextFactory<TastyEatsDbContext> _dbContextFactory;

    public RestaurantDiscoveryService(IDbContextFactory<TastyEatsDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<List<Item>> GetTopRatedItemsAsync(int count)
    {
        await Task.Delay(1000);
        using var db = await CreateDbContext();

        var result = await db.Items
            .Join(db.Restaurants,
                item => item.RestaurantID,
                restaurant => restaurant.ID,
                (item, restaurant) => new ItemWithRestaurantInfo { Item = item, Restaurant = restaurant })
            .Join(db.Accounts,
                  result => result.Restaurant.AccountID,
                  account => account.ID,
                  (result, account) => new { Item = result.Item, Restaurant = result.Restaurant, Account = account })
            .OrderByDescending(r => r.Account.Rating)
            .Take(count)
            .Select(r => r.Item)
            .ToListAsync();

        return result;
    }

    public async Task<List<Item>> SearchItemsAndResturantsAsync(string searchKey, int count)
    {
        await Task.Delay(1000);
        using var db = await CreateDbContext();

        var result = await db.Items
            .Join(db.Restaurants,
                item => item.RestaurantID,
                restaurant => restaurant.ID,
                (item, restaurant) => new ItemWithRestaurantInfo { Item = item, Restaurant = restaurant })
            .Join(db.Accounts,
                  result => result.Restaurant.AccountID,
                  account => account.ID,
                  (result, account) => new { Item = result.Item, Restaurant = result.Restaurant, Account = account })
            .Where(result => result.Restaurant.RestaurantName.Contains(searchKey) || result.Item.Name.Contains(searchKey))
            .OrderByDescending(r => r.Account.Rating)
            .Take(count)
            .Select(r => r.Item)
            .ToListAsync();

        return result;
    }

    private Task<TastyEatsDbContext> CreateDbContext() => _dbContextFactory.CreateDbContextAsync();

    private class ItemWithRestaurantInfo
    {
        public Item Item { get; set; }
        public TastyEatsBD.Core.Entities.Restaurant Restaurant { get; set; }
        public TastyEatsBD.Core.Entities.Account Account { get; set; }
    }

}
