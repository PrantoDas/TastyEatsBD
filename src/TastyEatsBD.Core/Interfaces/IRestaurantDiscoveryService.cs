using TastyEatsBD.Core.DTOs;

namespace TastyEatsBD.Core.Interfaces;
public interface IRestaurantDiscoveryService
{
    Task<RestaurantInfo> GetResturantAsync(int restaurantID);
    Task<List<RestaurantInfo>> SearchItemsAndResturantsAsync(string searchKey, int count);
}