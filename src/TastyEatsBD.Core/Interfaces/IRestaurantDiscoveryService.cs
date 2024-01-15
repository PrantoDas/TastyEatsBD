using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Interfaces;
public interface IRestaurantDiscoveryService
{
    Task<List<Item>> GetTopRatedItemsAsync(int count);
    Task<List<Item>> SearchItemsAndResturantsAsync(string searchKey, int count);
}