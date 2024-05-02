using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class RiderConfiguration : IEntityTypeConfiguration<Rider>
{
    public void Configure(EntityTypeBuilder<Rider> builder)
    {
        // AccountID - Foreign Key to Account
        builder.HasIndex(r => r.AccountId).HasDatabaseName("IDX_Rider_AccountID");

        builder.Property(r => r.CreatedOn)
               .HasDefaultValueSql("GETDATE()")
               .ValueGeneratedOnAdd();

        builder.Property(r => r.ModifiedOn)
               .HasDefaultValueSql("GETDATE()")
               .ValueGeneratedOnAddOrUpdate();

        builder.Property(r => r.IsAvailable)
               .HasDefaultValue(true)
               .ValueGeneratedOnAddOrUpdate();

        // Ensuring these are not included as literals in migrations
        builder.Property(r => r.CreatedOn).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        builder.Property(r => r.ModifiedOn).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
        builder.Property(r => r.IsAvailable).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

        builder.HasData(GetRiderSeedData());
    }

    private IEnumerable<Rider> GetRiderSeedData()
    {
        var riders = new List<Rider>
        {
            new Rider { Id = 1, AccountId = 12, IsAvailable = true },
            new Rider { Id = 2, AccountId = 13, IsAvailable = false },
            new Rider { Id = 3, AccountId = 14, IsAvailable = true },
            new Rider { Id = 4, AccountId = 15, IsAvailable = true },
            new Rider { Id = 5, AccountId = 16, IsAvailable = false },
            new Rider { Id = 6, AccountId = 17, IsAvailable = true },
            new Rider { Id = 7, AccountId = 18, IsAvailable = false },
            new Rider { Id = 8, AccountId = 19, IsAvailable = true },
            new Rider { Id = 9, AccountId = 20, IsAvailable = true },
            new Rider { Id = 10, AccountId = 21, IsAvailable = false }
        };
        return riders;
    }
}
