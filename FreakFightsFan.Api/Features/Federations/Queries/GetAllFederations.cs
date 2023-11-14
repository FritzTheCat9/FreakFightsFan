using Carter;
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
    }

    public class GetAllFederationsEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/federations/all", async (
                GetAllFederationsRequest getAllFederationsRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var query = new GetAllFederations.Query()
                    {
                        Page = getAllFederationsRequest.Page,
                        PageSize = getAllFederationsRequest.PageSize,
                        SortOrder = getAllFederationsRequest.SortOrder,
                        SortColumn = getAllFederationsRequest.SortColumn,
                        SearchTerm = getAllFederationsRequest.SearchTerm,
                    };

                    return Results.Ok(await mediator.Send(query, cancellationToken));
                })
                .WithTags("Federations");
        }
    }
}
