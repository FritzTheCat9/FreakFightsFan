using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Requests;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Queries
{
    public static class GetAllFighters
    {
        public class Query : IRequest<PagedList<FighterDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
            public string SearchTerm { get; set; }

            public List<int> HiddenFightersIds { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, PagedList<FighterDto>>
        {
            private readonly IFighterRepository _fighterRepository;

            public Handler(IFighterRepository fighterRepository)
            {
                _fighterRepository = fighterRepository;
            }

            public async Task<PagedList<FighterDto>> Handle(Query query, CancellationToken cancellationToken)
            {
                var fightersQuery = _fighterRepository.AsQueryable();

                if (query.HiddenFightersIds is not null)
                {
                    fightersQuery = fightersQuery.Where(x => !query.HiddenFightersIds.Contains(x.Id));
                }

                fightersQuery = fightersQuery.FilterFighters(query);
                fightersQuery = fightersQuery.SortFighters(query);

                var fightersPagedList = PageListExtensions<FighterDto>.Create(
                    fightersQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

                return await Task.FromResult(fightersPagedList);
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fighters/all", async (
                GetAllFightersRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToGetAllFightersQuery(), cancellationToken));
            })
                .WithTags("Fighters")
                .AllowAnonymous();

            return app;
        }
    }
}
