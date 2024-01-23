using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;

public class LocationValidator : AbstractValidator<Location>
{
    public LocationValidator()
    {
        RuleFor(loc => loc.Id).GreaterThanOrEqualTo(0);
        // Latitude and Longitude validation can be more specific based on valid ranges
        RuleFor(loc => loc.StreetAddress).NotEmpty();
        RuleFor(loc => loc.City).NotEmpty();
        RuleFor(loc => loc.ZipCode).NotEmpty();
        RuleFor(loc => loc.CreatedBy).NotEmpty();
        RuleFor(loc => loc.ModifiedBy).NotEmpty().When(loc => loc.ModifiedOn.HasValue);
    }
}
