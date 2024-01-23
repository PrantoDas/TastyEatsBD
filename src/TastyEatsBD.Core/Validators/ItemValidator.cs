using FluentValidation;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.Validators;

public class ItemValidator : AbstractValidator<Item>
{
    public ItemValidator()
    {
        RuleFor(item => item.Id)
            .GreaterThanOrEqualTo(0);

        RuleFor(item => item.RestaurantId)
            .GreaterThanOrEqualTo(0);

        RuleFor(item => item.Name)
            .NotEmpty()
            .MaximumLength(200); // Assuming 200 is the max length

        RuleFor(item => item.Price)
            .GreaterThanOrEqualTo(0);

        RuleFor(item => item.Description)
            .NotEmpty()
            .MaximumLength(1000); // Assuming 1000 is the max length

        RuleFor(item => item.Discount)
            .InclusiveBetween(0, 100) // Assuming discount is a percentage
            .When(item => item.Discount.HasValue);

        RuleFor(item => item.IsAvailable)
            .NotNull();

        RuleFor(item => item.PreparationTime)
            .GreaterThanOrEqualTo(0)
            .When(item => item.PreparationTime.HasValue);

        RuleFor(item => item.PhotoURL)
            .Must(BeAValidUrl)
            .When(item => !string.IsNullOrEmpty(item.PhotoURL))
            .WithMessage("'{PropertyValue}' is not a valid URL");

        RuleFor(item => item.CreatedBy)
            .NotEmpty();

        RuleFor(item => item.ModifiedBy)
            .NotEmpty()
            .When(item => item.ModifiedOn.HasValue);
    }

    private bool BeAValidUrl(string url)
    {
        return Uri.TryCreate(url, UriKind.Absolute, out var uriResult)
               && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
    }
}
