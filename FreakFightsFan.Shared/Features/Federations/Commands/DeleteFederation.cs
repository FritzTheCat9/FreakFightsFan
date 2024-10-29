using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Federations.Commands;

public static class DeleteFederation
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Command> { }
}