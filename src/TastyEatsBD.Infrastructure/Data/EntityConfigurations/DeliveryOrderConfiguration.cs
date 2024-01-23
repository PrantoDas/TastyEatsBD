using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class DeliveryOrderConfiguration : IEntityTypeConfiguration<DeliveryOrder>
{
    public void Configure(EntityTypeBuilder<DeliveryOrder> builder)
    {
        // OrderID - Foreign Key to Order
        builder.HasIndex(order => order.OrderId).HasDatabaseName("IDX_DeliveryOrder_OrderID");

        // RestaurantID - Foreign Key to Restaurant
        builder.HasIndex(order => order.RestaurantId).HasDatabaseName("IDX_DeliveryOrder_RestaurantID");

        // RiderID - Foreign Key to Rider
        builder.HasIndex(order => order.RiderId).HasDatabaseName("IDX_DeliveryOrder_RiderID");
    }
}
