using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;

public class OrderValidator : AbstractValidator<Order>
{
    public OrderValidator()
    {
        RuleFor(o => o.ID).GreaterThanOrEqualTo(0);
        RuleFor(o => o.CustomerID).GreaterThanOrEqualTo(0);
        RuleFor(o => o.DeliveryLocationID).GreaterThanOrEqualTo(0);
        RuleFor(o => o.TotalPrice).GreaterThanOrEqualTo(0);
        RuleFor(o => o.Discount).InclusiveBetween(0, 100).When(o => o.Discount.HasValue);
        RuleFor(o => o.Status).NotEmpty();
        RuleFor(o => o.PaymentMethod).NotEmpty();
        RuleFor(o => o.PaymentStatus).NotEmpty();
        RuleFor(o => o.CreatedBy).NotEmpty();
        RuleFor(o => o.ModifiedBy).NotEmpty().When(o => o.ModifiedOn.HasValue);
    }
}
