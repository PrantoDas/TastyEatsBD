namespace TastyEatsBD.WebApp.Services.Cart;

using Microsoft.EntityFrameworkCore;
using TastyEatsBD.Core.Entities;
using TastyEatsBD.Core.Interfaces;
using TastyEatsBD.Infrastructure.Data;
using TastyEatsBD.WebApp.Services.Identity;

internal class CartService : ICartService
{
    private readonly IDbContextFactory<TastyEatsDbContext> _dbContextFactory;
    private readonly IdentityUserAccessor _identityUserAccessor;

    public CartService(
        IDbContextFactory<TastyEatsDbContext> dbContextFactory,
        IdentityUserAccessor identityUserAccessor)
    {
        _dbContextFactory = dbContextFactory;
        _identityUserAccessor = identityUserAccessor;
    }

    public async Task<Cart> GetCartInfoAsync()
    {
        using var db = await _dbContextFactory.CreateDbContextAsync().ConfigureAwait(false);

        var user = await _identityUserAccessor.GetCurrentUserAsync().ConfigureAwait(false);

        try
        {
            var cart = await db.Carts
                .Include(c => c.CartItems)
                //.ThenInclude(ci => ci.Item)
                .FirstOrDefaultAsync(c => c.AccountId == user.AccountId)
                .ConfigureAwait(true);

            return cart ?? await CreateCartAsync(db, user.AccountId).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task<int> AddToCartAsync(int itemId, int cartId)
    {
        try
        {
            if (cartId == 0)
            {
                var cart = await GetCartInfoAsync().ConfigureAwait(false);
                cartId = cart.Id;
            }

            using var db = await _dbContextFactory.CreateDbContextAsync().ConfigureAwait(false);

            var cartItem = await db.CartItems
                .FirstOrDefaultAsync(i => i.CartId == cartId && i.ItemId == itemId)
                .ConfigureAwait(false);

            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    CartId = cartId,
                    ItemId = itemId,
                    Quantity = 1
                };
                db.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
                db.CartItems.Update(cartItem);
            }
            
            await db.SaveChangesAsync().ConfigureAwait(false);
        }
        catch (Exception ex)
        {

            throw;
        }

        return cartId;
    }

    private async Task<Cart> CreateCartAsync(TastyEatsDbContext db, int accountId)
    {
        var newCart = new Cart { AccountId = accountId };
        db.Carts.Add(newCart);
        await db.SaveChangesAsync();
        return newCart;
    }
}

public class CartState
{
    public event Func<Task> OnChangeAsync;

    private List<CartItem> _items = new List<CartItem>();

    public IReadOnlyList<CartItem> Items => _items.AsReadOnly();

    public async Task NotifyChangesAsync()
    {
        // Notify subscribers that the cart has changed
        if (OnChangeAsync != null)
        {
            await OnChangeAsync.Invoke().ConfigureAwait(false);
        }
    }
}
