using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TastyEatsBD.Core.Entities;
using TastyEatsBD.Infrastructure.Data.EntityConfigurations;

namespace TastyEatsBD.Infrastructure.Data;

public class AppIdentityDbContext : IdentityDbContext<AppIdentityUser>
{
    public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new IdentityRoleConfiguration());
    }
}
