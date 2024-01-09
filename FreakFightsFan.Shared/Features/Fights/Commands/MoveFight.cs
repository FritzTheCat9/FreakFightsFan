using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fights.Commands
{
    public class MoveFight
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public MoveDirection Direction { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Direction)
                    .IsInEnum();
            }
        }
    }
}
