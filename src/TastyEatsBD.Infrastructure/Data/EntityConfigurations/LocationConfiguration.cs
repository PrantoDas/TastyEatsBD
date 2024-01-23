using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.HasData(GetLocationSeedData());
    }

    private IEnumerable<Location> GetLocationSeedData()
    {
        var locations = new List<Location>
        {
            new Location { Id = 1, Latitude = 23.8103M, Longitude = 90.4125M },
            new Location { Id = 2, Latitude = 22.3569M, Longitude = 91.7832M },
            new Location { Id = 3, Latitude = 24.8949M, Longitude = 91.8687M },
            new Location { Id = 4, Latitude = 24.3636M, Longitude = 88.6241M },
            new Location { Id = 5, Latitude = 22.8456M, Longitude = 89.5403M },
            new Location { Id = 6, Latitude = 22.7010M, Longitude = 90.3535M },
            new Location { Id = 7, Latitude = 25.7439M, Longitude = 89.2752M },
            new Location { Id = 8, Latitude = 24.7471M, Longitude = 90.4203M },
            new Location { Id = 9, Latitude = 23.4609M, Longitude = 91.1809M },
            new Location { Id = 10, Latitude = 24.0023M, Longitude = 90.4264M }
        };
        return locations;
    }
}
