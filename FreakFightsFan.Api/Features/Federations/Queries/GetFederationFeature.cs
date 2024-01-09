using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Federations.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Queries;
using FreakFightsFan.Shared.Features.Federations.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Queries
{
    public static class GetFederationFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/federations/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetFederation.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetFederation")
                .WithTags("Federations")
                .AllowAnonymous();

            return app;
        }

        public class Handler : IRequestHandler<GetFederation.Query, FederationDto>
        {
            private readonly IFederationRepository _federationRepository;

            public Handler(IFederationRepository federationRepository)
            {
                _federationRepository = federationRepository;
            }

            public async Task<FederationDto> Handle(GetFederation.Query query, CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return federation.ToDto();
            }
        }
    }
}
