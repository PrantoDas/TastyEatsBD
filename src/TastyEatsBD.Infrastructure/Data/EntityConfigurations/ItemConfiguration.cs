using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        // RestaurantID - Foreign Key to Restaurant
        builder.HasIndex(i => i.RestaurantID).HasDatabaseName("IDX_Item_RestaurantID");

        // ItemName - Need to make it full text searchable later on using a migration script
        //builder.HasIndex(i => i.ItemName).HasDatabaseName("IDX_Item_ItemName");
    }
}
