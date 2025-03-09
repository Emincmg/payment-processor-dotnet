using FluentValidation;
using PaymentProcessorApi.Models.Strategy;

namespace PaymentProcessorApi.FluentValidations;

public class StripePaymentValidator : AbstractValidator<StripePayment>
{
    public StripePaymentValidator()
    {
        RuleFor(x => x.Amount).GreaterThan(0).WithMessage("Amount must be greater than zero.");
        RuleFor(x => x.Currency).NotEmpty().WithMessage("Currency is required.");
        RuleFor(x => x.Status).NotEmpty().WithMessage("Status is required.");
    }
}
