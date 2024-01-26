using FluentValidation;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.DictionaryItems.Commands
{
    public class UpdateMyDictionaryItem
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator(IStringLocalizer<ValidationMessage> localizer)
            {
                RuleFor(x => x.Name)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.NameNotEmpty)])
                    .MaximumLength(ValidationConsts.MaximumStringLength)
                    .WithMessage(x => localizer[nameof(ValidationMessageString.NameMaximumLength)]);

                RuleFor(x => x.Code)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.CodeNotEmpty)])
                    .MaximumLength(ValidationConsts.MaximumStringLength)
                    .WithMessage(x => localizer[nameof(ValidationMessageString.CodeMaximumLength)])
                    .Matches(ValidationConsts.CodeRegex)
                    .WithMessage(x => localizer[nameof(ValidationMessageString.CodeMatchesRegex)]);
            }
        }
    }
}
