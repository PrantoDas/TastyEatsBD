using Microsoft.EntityFrameworkCore;
using TastyEatsBD.Core.Entities;
using TastyEatsBD.Infrastructure.Data.EntityConfigurations;

namespace TastyEatsBD.Infrastructure.Data;

public class TastyEatsDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Rider> Riders { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<DeliveryOrder> DeliveryOrders { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<ItemOrder> ItemOrders { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Ledger> Ledgers { get; set; }
    public DbSet<AccountSetting> AccountSettings { get; set; }

    public TastyEatsDbContext(DbContextOptions<TastyEatsDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        modelBuilder.ApplyConfiguration(new RestaurantConfiguration());
        modelBuilder.ApplyConfiguration(new RiderConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new DeliveryOrderConfiguration());
        modelBuilder.ApplyConfiguration(new ItemOrderConfiguration());
        modelBuilder.ApplyConfiguration(new ItemConfiguration());
        modelBuilder.ApplyConfiguration(new LedgerConfiguration());
        modelBuilder.ApplyConfiguration(new LocationConfiguration());
        modelBuilder.ApplyConfiguration(new AccountSettingConfiguration());
        modelBuilder.ApplyConfiguration(new CartConfiguration());
        modelBuilder.ApplyConfiguration(new CartItemConfiguration());
    }
}
