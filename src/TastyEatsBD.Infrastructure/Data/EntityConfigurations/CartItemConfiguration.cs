using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        // CartId - Foreign Key to Cart
        builder.HasIndex(i => i.CartId).HasDatabaseName("IDX_CartItem_CartId");

        // ItemID - Foreign Key to Item
        builder.HasIndex(i => i.ItemId).HasDatabaseName("IDX_CartItem_ItemId");
    }
}