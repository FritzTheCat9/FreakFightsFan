using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Federations.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Queries;
using FreakFightsFan.Shared.Features.Federations.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Queries
{
    public static class GetAllFederationsFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/federations/all", async (
                 GetAllFederations.Query query,
                 IMediator mediator,
                 CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                 .WithTags("Federations")
                 .AllowAnonymous();

            return app;
        }

        public class Handler : IRequestHandler<GetAllFederations.Query, PagedList<FederationDto>>
        {
            private readonly IFederationRepository _federationRepository;

            public Handler(IFederationRepository federationRepository)
            {
                _federationRepository = federationRepository;
            }

            public async Task<PagedList<FederationDto>> Handle(
                GetAllFederations.Query query,
                CancellationToken cancellationToken)
            {
                var federationsQuery = _federationRepository.AsQueryable();

                federationsQuery = federationsQuery.FilterFederations(query);
                federationsQuery = federationsQuery.SortFederations(query);

                var federationsPagedList = PageListExtensions<FederationDto>.Create(federationsQuery.Select(x => x.ToDto()),
                                                                                    query.Page,
                                                                                    query.PageSize);

                return await Task.FromResult(federationsPagedList);
            }
        }
    }
}
