using FluentValidation;
using FreakFightsFan.Shared.Features.Users.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Users.Commands;

public static class RefreshToken
{
    public class Command : IRequest<JwtDto>
    {
        public string RefreshToken { get; set; }
    }

    public class Validator : AbstractValidator<Command> { }
}