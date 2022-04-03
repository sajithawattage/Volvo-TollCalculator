using FluentValidation;
using Volvo.TollCalculator.API.Models;

namespace Volvo.TollCalculator.API.Validators
{
    public class TollCalculateRequestModelValidator : AbstractValidator<TollCalculateRequestModel>
    {
        public TollCalculateRequestModelValidator()
        {
            RuleFor(x => x.Vehicle)
                .NotNull()
                .NotEmpty()
                .WithMessage("The vehicle must not be empty.");
            RuleForEach(x => x.TollDates)
                .NotNull()
                .NotEmpty()
                .WithMessage("Toll dates must not be empty.");
        }
    }
}
