using Carter;
using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Commands
{
    public static class DeleteFederation
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {

        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IFederationRepository _federationRepository;

            public Handler(IFederationRepository federationRepository)
            {
                _federationRepository = federationRepository;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(command.Id) ?? throw new MyNotFoundException();
                await _federationRepository.Delete(federation);
                return Unit.Value;
            }
        }
    }

    public class DeleteFederationEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/federations/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new DeleteFederation.Command() { Id = id };
                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Federations");
        }
    }
}
