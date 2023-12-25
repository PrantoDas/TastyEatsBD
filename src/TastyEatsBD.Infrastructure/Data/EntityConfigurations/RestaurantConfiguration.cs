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
    }
}
