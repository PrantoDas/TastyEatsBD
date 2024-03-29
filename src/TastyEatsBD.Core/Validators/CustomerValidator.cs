﻿using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;

public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        RuleFor(customer => customer.Id)
            .GreaterThanOrEqualTo(0);

        RuleFor(customer => customer.AccountId)
            .GreaterThanOrEqualTo(0);

        // CreatedOn usually doesn't need validation

        RuleFor(customer => customer.CreatedBy)
            .NotEmpty();

        RuleFor(customer => customer.ModifiedBy)
            .NotEmpty()
            .When(customer => customer.ModifiedOn.HasValue);
    }
}
