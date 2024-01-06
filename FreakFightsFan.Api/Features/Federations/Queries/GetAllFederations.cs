using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Federations.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Requests;
using FreakFightsFan.Shared.Features.Federations.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Queries
{
    public static class GetAllFederations
    {
        public class Query : IRequest<PagedList<FederationDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
            public string SearchTerm { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, PagedList<FederationDto>>
        {
            private readonly IFederationRepository _federationRepository;

            public Handler(IFederationRepository federationRepository)
            {
                _federationRepository = federationRepository;
            }

            public async Task<PagedList<FederationDto>> Handle(Query query, CancellationToken cancellationToken)
            {
                var federationsQuery = _federationRepository.AsQueryable();

                federationsQuery = federationsQuery.FilterFederations(query);
                federationsQuery = federationsQuery.SortFederations(query);

                var federationsPagedList = PageListExtensions<FederationDto>.Create(
                    federationsQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

                return await Task.FromResult(federationsPagedList);
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/federations/all", async (
                 GetAllFederationsRequest request,
                 IMediator mediator,
                 CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToGetAllFederationsQuery(), cancellationToken));
            })
                 .WithTags("Federations")
                 .AllowAnonymous();

            return app;
        }
    }
}
