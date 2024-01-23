using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        // CustomerID - Foreign Key to Customer
        builder.HasIndex(o => o.CustomerId).HasDatabaseName("IDX_Order_CustomerID");

        // DeliveryLocationID - Foreign Key to Location
        builder.HasIndex(o => o.LocationId).HasDatabaseName("IDX_Order_DeliveryLocation");
    }
}
