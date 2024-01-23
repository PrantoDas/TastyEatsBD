using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;
public class AccountValidator : AbstractValidator<Account>
{
    public AccountValidator()
    {
        RuleFor(account => account.Id)
            .GreaterThanOrEqualTo(0);

        RuleFor(account => account.AccountType)
            .NotEmpty();

        RuleFor(account => account.Name)
            .NotEmpty()
            .MaximumLength(100); // Assuming 100 is the max length

        RuleFor(account => account.Email)
            .NotEmpty()
            .EmailAddress();

        // Password validation is complex with SecureString and might need a custom approach

        RuleFor(account => account.Rating)
            .InclusiveBetween(0, 5)
            .When(account => account.Rating.HasValue);

        RuleFor(account => account.ProfileImageURL)
            .Must(BeAValidUrl)
            .When(account => !string.IsNullOrEmpty(account.ProfileImageURL))
            .WithMessage("'{PropertyValue}' is not a valid URL");

        // CreatedOn usually doesn't need validation

        RuleFor(account => account.CreatedBy)
            .NotEmpty();

        RuleFor(account => account.ModifiedBy)
            .NotEmpty()
            .When(account => account.ModifiedOn.HasValue);
    }

    private bool BeAValidUrl(string url)
    {
        return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
               && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }
}
