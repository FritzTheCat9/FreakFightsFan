using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Requests;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Queries
{
    public static class GetAllFights
    {
        public class Query : IRequest<PagedList<FightDto>>, IPagedQuery, ISortedQuery
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

        public class Handler : IRequestHandler<Query, PagedList<FightDto>>
        {
            private readonly IFightRepository _fightRepository;

            public Handler(IFightRepository fightRepository)
            {
                _fightRepository = fightRepository;
            }

            public async Task<PagedList<FightDto>> Handle(Query query, CancellationToken cancellationToken)
            {
                var fightsQuery = _fightRepository.AsQueryable();

                fightsQuery = fightsQuery.FilterFights(query);
                fightsQuery = fightsQuery.SortFights(query);

                var fightsPagedList = PageListExtensions<FightDto>.Create(
                    fightsQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

                return await Task.FromResult(fightsPagedList);
            }
        }
    }

    public class GetAllFightsEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fights/all", async (
                GetAllFightsRequest getAllFightsRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var query = new GetAllFights.Query()
                    {
                        Page = getAllFightsRequest.Page,
                        PageSize = getAllFightsRequest.PageSize,
                        SortOrder = getAllFightsRequest.SortOrder,
                        SortColumn = getAllFightsRequest.SortColumn,
                        SearchTerm = getAllFightsRequest.SearchTerm,
                    };

                    return Results.Ok(await mediator.Send(query, cancellationToken));
                })
                .WithTags("Fights");
        }
    }
}
