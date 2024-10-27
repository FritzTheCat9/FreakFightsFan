using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Users.Commands;

public static class PromoteUser
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; set; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator()
        {

        }
    }
}