using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        // AccountId - Foreign Key to Account
        builder.HasIndex(i => i.AccountId).HasDatabaseName("IDX_Cart_AccountId");

        // RestaurantId - Foreign Key to Resturant
        builder.HasIndex(i => i.RestaurantId).HasDatabaseName("IDX_Cart_RestaurantId");

        builder.Property(i => i.RestaurantId)
               .IsRequired()
               .HasDefaultValue(0);
    }
}
