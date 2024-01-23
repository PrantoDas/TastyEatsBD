using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;

public class ItemOrderValidator : AbstractValidator<ItemOrder>
{
    public ItemOrderValidator()
    {
        RuleFor(io => io.Id).GreaterThanOrEqualTo(0);
        RuleFor(io => io.OrderId).GreaterThanOrEqualTo(0);
        RuleFor(io => io.ItemId).GreaterThanOrEqualTo(0);
        RuleFor(io => io.Quantity).GreaterThan(0);
        RuleFor(io => io.TotalPrice).GreaterThanOrEqualTo(0);
        RuleFor(io => io.CreatedBy).NotEmpty();
        RuleFor(io => io.ModifiedBy).NotEmpty().When(io => io.ModifiedOn.HasValue);
    }
}
