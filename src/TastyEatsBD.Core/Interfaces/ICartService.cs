using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Interfaces;

public interface ICartService
{
    Task<int> AddToCartAsync(int itemId, int cartId);
    Task<Cart> GetCartInfoAsync();
}
