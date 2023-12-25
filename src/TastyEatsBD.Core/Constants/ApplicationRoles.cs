using TastyEatsBD.Core.Enums;

namespace TastyEatsBD.Core.Constants;

public static class ApplicationRoles
{
    public const string Customer = nameof(AccountType.Customer);
    public const string Restaurant = nameof(AccountType.Restaurant);
    public const string Rider = nameof(AccountType.Rider);
    public const string Administrator = nameof(AccountType.Administrator);
    public const string CustomerCare = nameof(AccountType.CustomerCare);
}
