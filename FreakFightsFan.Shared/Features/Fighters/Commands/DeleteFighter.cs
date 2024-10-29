using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fighters.Commands;

public static class DeleteFighter
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Command> { }
}