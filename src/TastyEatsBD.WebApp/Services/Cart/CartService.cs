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

    public async Task<Cart> GetCartInfoAsync(int restaurantId = 0)
    {
        using var db = await _dbContextFactory.CreateDbContextAsync().ConfigureAwait(false);

        var user = await _identityUserAccessor.GetCurrentUserAsync();

        var cart = await db.Carts
                .Include(c => c.CartItems)
                //.ThenInclude(ci => ci.Item)
                .FirstOrDefaultAsync(c => c.AccountId == user.AccountId)
                .ConfigureAwait(true);

        if(cart == null)
        {
            cart = new() { AccountId = user.AccountId };
            if(restaurantId > 0)
            {
                cart.RestaurantId = restaurantId;
                db.Add(cart);
                await db.SaveChangesAsync().ConfigureAwait(false);
            }
        }
        return cart;
    }

    public async Task AddToCartAsync(int itemId)
    {
        using var db = await _dbContextFactory.CreateDbContextAsync().ConfigureAwait(false);

        var item = await db.Items.FirstOrDefaultAsync(i => i.Id == itemId).ConfigureAwait(false);

        var cart = await GetCartInfoAsync(item.RestaurantId).ConfigureAwait(false);

        var cartItem = await db.CartItems
            .FirstOrDefaultAsync(i => i.CartId == cart.Id && i.ItemId == itemId)
            .ConfigureAwait(false);

        if (cartItem == null)
        {
            cartItem = new CartItem
            {
                CartId = cart.Id,
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

        if (cart.RestaurantId != item.RestaurantId)
        {
            cart.RestaurantId = item.RestaurantId;
            db.Carts.Update(cart);
        }

        await db.SaveChangesAsync().ConfigureAwait(false);
    }

    public async Task<CartItem> GetItemInfoAsync(int itemId)
    {
        var cart = await GetCartInfoAsync().ConfigureAwait(false);

        if (cart.RestaurantId == 0)
            return new();

        using var db = await _dbContextFactory.CreateDbContextAsync().ConfigureAwait(false);

        var cartItem = await db.CartItems
            .AsNoTracking()
            .FirstOrDefaultAsync(i => i.CartId == cart.Id && i.ItemId == itemId)
            .ConfigureAwait(false);

        return cartItem ?? new();
    }

    public async Task ClearCartAsync()
    {
        var cart = await GetCartInfoAsync().ConfigureAwait(false);
        if(cart == null) return;

        using var db = await _dbContextFactory.CreateDbContextAsync().ConfigureAwait(false);

        var cartItem = await db.CartItems
            .Where(i => i.CartId == cart.Id)
            .ExecuteDeleteAsync()
            .ConfigureAwait(false);
    }
}

public class CartState
{
    public event Func<Task> OnChangeAsync;

    public Cart Cart { get; set; }

    public async Task NotifyChangesAsync()
    {
        // Notify subscribers that the cart has changed
        if (OnChangeAsync != null)
        {
            await OnChangeAsync.Invoke();
        }
    }
}
