using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fights.Commands;

public static class DeleteFight
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Command> { }
}