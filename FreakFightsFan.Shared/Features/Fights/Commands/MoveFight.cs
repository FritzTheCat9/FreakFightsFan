using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Localization;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Shared.Features.Fights.Commands;

public static class MoveFight
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; set; }
        public MoveDirection Direction { get; set; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator(IStringLocalizer<ValidationMessage> localizer)
        {
            RuleFor(x => x.Direction)
                .IsInEnum()
                .WithMessage(x => localizer[nameof(ValidationMessageString.DirectionIsInEnum)]);
        }
    }
}