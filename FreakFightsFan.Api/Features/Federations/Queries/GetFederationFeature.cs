using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Federations.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Queries;
using FreakFightsFan.Shared.Features.Federations.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Queries;

public static class GetFederationFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/federations/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetFederation.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithName("GetFederation")
            .WithTags(Tags.Federations)
            .AllowAnonymous();
    }

    public class Handler(IFederationRepository federationRepository)
        : IRequestHandler<GetFederation.Query, FederationDto>
    {
        public async Task<FederationDto> Handle(
            GetFederation.Query query,
            CancellationToken cancellationToken)
        {
            var federation = await federationRepository.Get(query.Id) ?? throw new MyNotFoundException();
            return federation.ToDto();
        }
    }
}