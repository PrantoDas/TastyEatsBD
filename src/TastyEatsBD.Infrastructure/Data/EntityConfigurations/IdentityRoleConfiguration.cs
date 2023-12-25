using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Enums;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        var defaultRoles = GetDefaultRoles();
        builder.HasData(defaultRoles);
    }

    /// <summary>
    /// Generates a collection of IdentityRole based on the <see cref="AccountType"/> enum.
    /// </summary>
    /// <returns>A collection of IdentityRole.</returns>
    private IEnumerable<IdentityRole> GetDefaultRoles()
    {
        return Enum.GetValues(typeof(AccountType))
                   .Cast<AccountType>()
                   .Select(type => new IdentityRole
                   {
                       Id = Guid.NewGuid().ToString(),
                       Name = type.ToString(),
                       NormalizedName = type.ToString().ToUpper(),
                       ConcurrencyStamp = Guid.NewGuid().ToString()
                   });
    }
}
