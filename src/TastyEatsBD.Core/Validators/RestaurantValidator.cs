﻿using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;

public class RestaurantValidator : AbstractValidator<Restaurant>
{
    public RestaurantValidator()
    {
        RuleFor(r => r.ID).GreaterThanOrEqualTo(0);
        RuleFor(r => r.AccountID).GreaterThanOrEqualTo(0);
        RuleFor(r => r.LocationID).GreaterThanOrEqualTo(0);
        // IsAvailable doesn't need validation as it's a boolean
        RuleFor(r => r.CreatedBy).NotEmpty();
        RuleFor(r => r.ModifiedBy).NotEmpty().When(r => r.ModifiedOn.HasValue);
    }
}
