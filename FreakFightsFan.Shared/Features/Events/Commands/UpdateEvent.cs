using FluentValidation;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Events.Commands
{
    public class UpdateEvent
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime? Date { get; set; }
            public int? CityId { get; set; }
            public int? HallId { get; set; }
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

                RuleFor(x => x.Date)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.DateNotEmpty)]);

                RuleFor(x => x.CityId)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.CityNotEmpty)]);

                RuleFor(x => x.HallId)
                    .NotEmpty()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.HallNotEmpty)]);
            }
        }
    }
}
