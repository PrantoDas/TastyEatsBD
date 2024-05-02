using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Interfaces;

public interface ICartService
{
    Task AddToCartAsync(int itemId);
    Task ClearCartAsync();
    Task<Cart> GetCartInfoAsync(int restaurantId = 0);
    Task<CartItem> GetItemInfoAsync(int itemId);
}
