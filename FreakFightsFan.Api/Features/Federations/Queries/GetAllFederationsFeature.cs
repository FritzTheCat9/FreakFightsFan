using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Federations.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Queries;
using FreakFightsFan.Shared.Features.Federations.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Queries;

public static class GetAllFederationsFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/federations/all", async (
                GetAllFederations.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithTags(Tags.Federations)
            .AllowAnonymous();
    }

    public class Handler(IFederationRepository federationRepository)
        : IRequestHandler<GetAllFederations.Query, PagedList<FederationDto>>
    {
        public async Task<PagedList<FederationDto>> Handle(
            GetAllFederations.Query query,
            CancellationToken cancellationToken)
        {
            var federationsQuery = federationRepository.AsQueryable();

            federationsQuery = federationsQuery.FilterFederations(query);
            federationsQuery = federationsQuery.SortFederations(query);

            var federationsPagedList = PageListExtensions<FederationDto>.Create(
                federationsQuery.Select(x => x.ToDto()),
                query.Page,
                query.PageSize);

            return await Task.FromResult(federationsPagedList);
        }
    }
}