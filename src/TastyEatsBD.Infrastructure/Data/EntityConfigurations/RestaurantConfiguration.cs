using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        // AccountID - Foreign Key to Account
        builder.HasIndex(r => r.AccountId).HasDatabaseName("IDX_Restaurant_AccountID");

        // LocationID - Foreign Key to Location
        builder.HasIndex(r => r.LocationId).HasDatabaseName("IDX_Restaurant_LocationID");

        // RestaurantName - Need to make it full text searchable later on using a migration script
        // builder.HasIndex(r => r.RestaurantName).HasDatabaseName("IDX_Restaurant_RestaurantName");

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

        builder.HasData(GetResturantSeedData());
    }

    private IEnumerable<Restaurant> GetResturantSeedData()
    {
        var restaurants = new List<Restaurant>
        {
            new Restaurant { Id = 1, AccountId = 2, RestaurantName = "Dhaka Delights", LocationId = 1 },
            new Restaurant { Id = 2, AccountId = 3, RestaurantName = "Chittagong Eats", LocationId = 2 },
            new Restaurant { Id = 3, AccountId = 4, RestaurantName = "Sylhet Spices", LocationId = 3 },
            new Restaurant { Id = 4, AccountId = 5, RestaurantName = "Rajshahi Recipes", LocationId = 4 },
            new Restaurant { Id = 5, AccountId = 6, RestaurantName = "Khulna Kitchen", LocationId = 5 },
            new Restaurant { Id = 6, AccountId = 7, RestaurantName = "Barisal Bites", LocationId = 6 },
            new Restaurant { Id = 7, AccountId = 8, RestaurantName = "Rangpur Relish", LocationId = 7 },
            new Restaurant { Id = 8, AccountId = 9, RestaurantName = "Mymensingh Munch", LocationId = 8 },
            new Restaurant { Id = 9, AccountId = 10, RestaurantName = "Comilla Cuisine", LocationId = 9 },
            new Restaurant { Id = 10, AccountId = 11, RestaurantName = "Gazipur Gourmet", LocationId = 10 }
        };
        return restaurants;
    }
}
