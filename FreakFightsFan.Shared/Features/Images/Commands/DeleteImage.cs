using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Images.Commands;

public static class DeleteImage
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Command> { }
}