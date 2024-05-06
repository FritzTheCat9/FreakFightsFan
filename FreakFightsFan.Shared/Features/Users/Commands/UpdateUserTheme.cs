using FluentValidation;
using FreakFightsFan.Shared.Features.Users.Helpers;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Users.Commands
{
    public class UpdateUserTheme
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public ThemeColor ThemeColor { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator(IStringLocalizer<ValidationMessage> localizer)
            {
                RuleFor(x => x.ThemeColor)
                    .IsInEnum()
                    .WithMessage(x => localizer[nameof(ValidationMessageString.ThemeColorIsInEnum)]);
            }
        }
    }
}
