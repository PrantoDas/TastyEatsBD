namespace TastyEatsBD.WebApp.Services.Account;

using Microsoft.EntityFrameworkCore;
using TastyEatsBD.Core.Entities;
using TastyEatsBD.Core.Interfaces;
using TastyEatsBD.Infrastructure.Data;

public class AccountService : IAccountService
{
    private readonly IDbContextFactory<TastyEatsDbContext> _dbContextFactory;

    public AccountService(IDbContextFactory<TastyEatsDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<Account> GetByIdAsync(int id)
    {
        using var db = await CreateDbContext();
        return await db.Accounts.FindAsync(id);
    }

    public async ValueTask<int> CreateAccountAsync(Account account)
    {
        using var db = await CreateDbContext();

        account.CreatedOn = DateTime.UtcNow;

        db.Accounts.Add(account);
        await db.SaveChangesAsync();

        return account.ID;
    }

    public async Task UpdateAccountAsync(Account account)
    {
        using var db = await CreateDbContext();
        db.Accounts.Update(account);
        await db.SaveChangesAsync();
    }

    private Task<TastyEatsDbContext> CreateDbContext() => _dbContextFactory.CreateDbContextAsync();
}
