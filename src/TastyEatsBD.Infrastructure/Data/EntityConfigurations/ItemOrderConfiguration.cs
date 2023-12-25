using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class ItemOrderConfiguration : IEntityTypeConfiguration<ItemOrder>
{
    public void Configure(EntityTypeBuilder<ItemOrder> builder)
    {
        // OrderID - Foreign Key to Order
        builder.HasIndex(order => order.OrderID).HasDatabaseName("IDX_ItemOrder_OrderID");

        // ItemID - Foreign Key to Item
        builder.HasIndex(order => order.ItemID).HasDatabaseName("IDX_ItemOrder_ItemID");
    }
}
