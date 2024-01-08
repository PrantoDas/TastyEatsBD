using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Interfaces;

public interface IAccountService
{
    Task<Account> GetByIdAsync(int id);
    ValueTask<int> CreateAccountAsync(Account account);
    Task UpdateAccountAsync(Account account);
    Task<IEnumerable<Account>> GetAsync();
}
