using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Queries;

public static class GetAllFightersFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/fighters/all", async (
                GetAllFighters.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithTags(Tags.Fighters)
            .AllowAnonymous();
    }

    public class Handler(IFighterRepository fighterRepository)
        : IRequestHandler<GetAllFighters.Query, PagedList<FighterDto>>
    {
        public async Task<PagedList<FighterDto>> Handle(
            GetAllFighters.Query query,
            CancellationToken cancellationToken)
        {
            var fightersQuery = fighterRepository.AsQueryable();

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
}