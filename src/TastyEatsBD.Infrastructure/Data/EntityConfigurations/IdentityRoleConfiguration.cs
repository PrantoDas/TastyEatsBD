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
                       Id = GetDeterministicGuid(type.ToString()).ToString(),
                       Name = type.ToString(),
                       NormalizedName = type.ToString().ToUpper(),
                       ConcurrencyStamp = GetDeterministicGuid($"ConcurrencyStamp_{type}").ToString()
                   });
    }

    /// <summary>
    /// Generates a deterministic GUID based on the input string.
    /// </summary>
    /// <param name="input">The input string to generate a GUID for.</param>
    /// <returns>A GUID.</returns>
    private Guid GetDeterministicGuid(string input)
    {
        // Using an MD5 hash to generate a GUID from the role name
        using (var provider = System.Security.Cryptography.MD5.Create())
        {
            byte[] inputBytes = System.Text.Encoding.Default.GetBytes(input);
            byte[] hashBytes = provider.ComputeHash(inputBytes);
            return new Guid(hashBytes);
        }
    }
}
