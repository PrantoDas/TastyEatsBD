using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class RiderConfiguration : IEntityTypeConfiguration<Rider>
{
    public void Configure(EntityTypeBuilder<Rider> builder)
    {
        // AccountID - Foreign Key to Account
        builder.HasIndex(r => r.AccountID).HasDatabaseName("IDX_Rider_AccountID");

        builder.HasData(GetRiderSeedData());
    }

    private IEnumerable<Rider> GetRiderSeedData()
    {
        var riders = new List<Rider>
        {
            new Rider { ID = 1, AccountID = 12, IsAvailable = true },
            new Rider { ID = 2, AccountID = 13, IsAvailable = false },
            new Rider { ID = 3, AccountID = 14, IsAvailable = true },
            new Rider { ID = 4, AccountID = 15, IsAvailable = true },
            new Rider { ID = 5, AccountID = 16, IsAvailable = false },
            new Rider { ID = 6, AccountID = 17, IsAvailable = true },
            new Rider { ID = 7, AccountID = 18, IsAvailable = false },
            new Rider { ID = 8, AccountID = 19, IsAvailable = true },
            new Rider { ID = 9, AccountID = 20, IsAvailable = true },
            new Rider { ID = 10, AccountID = 21, IsAvailable = false }
        };
        return riders;
    }
}
