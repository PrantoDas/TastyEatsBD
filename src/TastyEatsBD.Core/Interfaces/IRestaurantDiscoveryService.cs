using TastyEatsBD.Core.DTOs;

namespace TastyEatsBD.Core.Interfaces;
public interface IRestaurantDiscoveryService
{
    Task<List<RestaurantInfo>> GetTopRatedRestaurantsAsync(int count);
    Task<List<RestaurantInfo>> SearchItemsAndResturantsAsync(string searchKey, int count);
}