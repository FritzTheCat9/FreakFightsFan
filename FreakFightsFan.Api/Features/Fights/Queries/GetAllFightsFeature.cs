using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Queries;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Queries;

public static class GetAllFightsFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/fights/all", async (
                GetAllFights.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithTags(Tags.Fights)
            .AllowAnonymous();
    }

    public class Handler(IFightRepository fightRepository)
        : IRequestHandler<GetAllFights.Query, PagedList<FightDto>>
    {
        public async Task<PagedList<FightDto>> Handle(
            GetAllFights.Query query,
            CancellationToken cancellationToken)
        {
            var fightsQuery = fightRepository.AsQueryable(query.EventId);

            var fightsPagedList = PageListExtensions<FightDto>.Create(fightsQuery.Select(x => x.ToDto()),
                query.Page,
                query.PageSize);

            return await Task.FromResult(fightsPagedList);
        }
    }
}