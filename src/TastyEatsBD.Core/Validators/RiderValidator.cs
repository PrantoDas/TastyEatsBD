using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;

public class RiderValidator : AbstractValidator<Rider>
{
    public RiderValidator()
    {
        RuleFor(r => r.ID).GreaterThanOrEqualTo(0);
        RuleFor(r => r.AccountID).GreaterThanOrEqualTo(0);
        // IsAvailable doesn't need validation as it's a boolean
        RuleFor(r => r.CreatedBy).NotEmpty();
        RuleFor(r => r.ModifiedBy).NotEmpty().When(r => r.ModifiedOn.HasValue);
    }
}
