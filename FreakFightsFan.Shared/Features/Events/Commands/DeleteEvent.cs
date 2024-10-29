using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Events.Commands;

public static class DeleteEvent
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Command> { }
}