using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;

public class DeliveryOrderValidator : AbstractValidator<DeliveryOrder>
{
    public DeliveryOrderValidator()
    {
        RuleFor(deliveryOrder => deliveryOrder.ID)
            .GreaterThanOrEqualTo(0);

        RuleFor(deliveryOrder => deliveryOrder.OrderID)
            .GreaterThanOrEqualTo(0);

        RuleFor(deliveryOrder => deliveryOrder.RestaurantID)
            .GreaterThanOrEqualTo(0);

        RuleFor(deliveryOrder => deliveryOrder.RiderID)
            .GreaterThanOrEqualTo(0);

        RuleFor(deliveryOrder => deliveryOrder.PickupTime)
            .LessThanOrEqualTo(deliveryOrder => deliveryOrder.DeliveryTime)
            .WithMessage("Pickup time must be before or equal to delivery time.");

        RuleFor(deliveryOrder => deliveryOrder.DeliveryTime)
            .GreaterThanOrEqualTo(deliveryOrder => deliveryOrder.PickupTime)
            .WithMessage("Delivery time must be after or equal to pickup time.");

        RuleFor(deliveryOrder => deliveryOrder.CreatedBy)
            .NotEmpty();

        RuleFor(deliveryOrder => deliveryOrder.ModifiedBy)
            .NotEmpty()
            .When(deliveryOrder => deliveryOrder.ModifiedOn.HasValue);
    }
}
