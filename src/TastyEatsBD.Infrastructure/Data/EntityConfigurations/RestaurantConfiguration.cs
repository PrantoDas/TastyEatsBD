using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        // AccountID - Foreign Key to Account
        builder.HasIndex(r => r.AccountID).HasDatabaseName("IDX_Restaurant_AccountID");

        // LocationID - Foreign Key to Location
        builder.HasIndex(r => r.LocationID).HasDatabaseName("IDX_Restaurant_LocationID");

        // RestaurantName - Need to make it full text searchable later on using a migration script
        // builder.HasIndex(r => r.RestaurantName).HasDatabaseName("IDX_Restaurant_RestaurantName");

        builder.HasData(GetResturantSeedData());
    }

    private IEnumerable<Restaurant> GetResturantSeedData()
    {
        var restaurants = new List<Restaurant>
        {
            new Restaurant { ID = 1, AccountID = 2, RestaurantName = "Dhaka Delights", LocationID = 1 },
            new Restaurant { ID = 2, AccountID = 3, RestaurantName = "Chittagong Eats", LocationID = 2 },
            new Restaurant { ID = 3, AccountID = 4, RestaurantName = "Sylhet Spices", LocationID = 3 },
            new Restaurant { ID = 4, AccountID = 5, RestaurantName = "Rajshahi Recipes", LocationID = 4 },
            new Restaurant { ID = 5, AccountID = 6, RestaurantName = "Khulna Kitchen", LocationID = 5 },
            new Restaurant { ID = 6, AccountID = 7, RestaurantName = "Barisal Bites", LocationID = 6 },
            new Restaurant { ID = 7, AccountID = 8, RestaurantName = "Rangpur Relish", LocationID = 7 },
            new Restaurant { ID = 8, AccountID = 9, RestaurantName = "Mymensingh Munch", LocationID = 8 },
            new Restaurant { ID = 9, AccountID = 10, RestaurantName = "Comilla Cuisine", LocationID = 9 },
            new Restaurant { ID = 10, AccountID = 11, RestaurantName = "Gazipur Gourmet", LocationID = 10 }
        };
        return restaurants;
    }
}
