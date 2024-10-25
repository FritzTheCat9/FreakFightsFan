using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Queries;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Queries
{
    public static class GetAllFightsFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fights/all", async (
                        GetAllFights.Query query,
                        IMediator mediator,
                        CancellationToken cancellationToken)
                    => Results.Ok(await mediator.Send(query, cancellationToken)))
                .WithTags(Tags.Fights)
                .AllowAnonymous();
        }

        public class Handler : IRequestHandler<GetAllFights.Query, PagedList<FightDto>>
        {
            private readonly IFightRepository _fightRepository;

            public Handler(IFightRepository fightRepository)
            {
                _fightRepository = fightRepository;
            }

            public async Task<PagedList<FightDto>> Handle(
                GetAllFights.Query query,
                CancellationToken cancellationToken)
            {
                var fightsQuery = _fightRepository.AsQueryable(query.EventId);

                var fightsPagedList = PageListExtensions<FightDto>.Create(fightsQuery.Select(x => x.ToDto()),
                    query.Page,
                    query.PageSize);

                return await Task.FromResult(fightsPagedList);
            }
        }
    }
}