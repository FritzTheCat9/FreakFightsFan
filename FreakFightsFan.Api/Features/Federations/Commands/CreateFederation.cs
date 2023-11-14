using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Features.Federations.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Commands
{
    public static class CreateFederation
    {
        public class Command : IRequest<int>
        {
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

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IFederationRepository _federationRepository;
            private readonly IClock _clock;

            public Handler(IFederationRepository federationRepository, IClock clock)
            {
                _federationRepository = federationRepository;
                _clock = clock;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var federation = new Federation
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                };

                return await _federationRepository.Create(federation);
            }
        }
    }

    public class CreateFederationEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/federations", async (
                CreateFederationRequest createFederationRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new CreateFederation.Command()
                    {
                        Name = createFederationRequest.Name,
                    };

                    int federationId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetFederation", new { id = federationId });
                })
                .WithTags("Federations");
        }
    }
}
