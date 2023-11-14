using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Commands
{
    public static class UpdateFederation
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IFederationRepository _federationRepository;
            private readonly IClock _clock;

            public Handler(IFederationRepository federationRepository, IClock clock)
            {
                _federationRepository = federationRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(command.Id) ?? throw new MyNotFoundException();
                federation.Modified = _clock.Current();
                federation.Name = command.Name;

                await _federationRepository.Update(federation);
                return Unit.Value;
            }
        }
    }

    public class UpdateFederationEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/api/federations/{id}", async (
                int id,
                UpdateFederationRequest updateFederationRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new UpdateFederation.Command()
                    {
                        Id = id,
                        Name = updateFederationRequest.Name,
                    };

                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Federations");
        }
    }
}
