using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;

public class LedgerValidator : AbstractValidator<Ledger>
{
    public LedgerValidator()
    {
        RuleFor(l => l.ID).GreaterThanOrEqualTo(0);
        RuleFor(l => l.AccountID).GreaterThanOrEqualTo(0);
        RuleFor(l => l.Amount).GreaterThanOrEqualTo(0);
        RuleFor(l => l.TransactionType).NotEmpty();
        RuleFor(l => l.Description).NotEmpty();
    }
}
