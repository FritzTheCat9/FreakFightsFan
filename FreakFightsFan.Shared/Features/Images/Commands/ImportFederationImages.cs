using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Images.Commands;

public static class ImportFederationImages
{
    public class Command : IRequest<Unit>
    {

    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator()
        {

        }
    }
}