using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Fights.Queries;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Queries
{
    public static class GetFighterProfileFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/fights/fighter/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetFighterProfile.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithTags("Fights")
                .AllowAnonymous();

            return app;
        }

        public class Handler : IRequestHandler<GetFighterProfile.Query, FighterProfileDto>
        {
            private readonly IFightRepository _fightRepository;
            private readonly IFightService _fightService;

            public Handler(IFightRepository fightRepository, IFightService fightService)
            {
                _fightRepository = fightRepository;
                _fightService = fightService;
            }

            public async Task<FighterProfileDto> Handle(GetFighterProfile.Query query, CancellationToken cancellationToken)
            {
                var fights = await _fightRepository.GetFighterFights(query.Id) ?? throw new MyNotFoundException();

                var profileFights = new List<ProfileFightDto>();
                foreach (var fight in fights)
                {
                    var fightResult = await _fightService.GetFightResultForFighter(fight.Id, query.Id);
                    profileFights.Add(new()
                    {
                        Fight = fight.ToDto(),
                        FightResult = fightResult
                    });
                }

                var fighterProfileDto = new FighterProfileDto()
                {
                    ProfileFights = profileFights,
                    Stats = GetFighterStats(profileFights)
                };

                return fighterProfileDto;
            }

            private static FighterFightsStats GetFighterStats(List<ProfileFightDto> profileFights)
            {
                var upcoming = 0;
                var win = 0;
                var loss = 0;
                var draw = 0;
                var noContest = 0;

                foreach (var fight in profileFights)
                {
                    switch (fight.FightResult)
                    {
                        case FightResult.UPCOMING:
                            upcoming++;
                            break;
                        case FightResult.WIN:
                            win++;
                            break;
                        case FightResult.LOSS:
                            loss++;
                            break;
                        case FightResult.DRAW:
                            draw++;
                            break;
                        case FightResult.NO_CONTEST:
                            noContest++;
                            break;
                        default:
                            break;
                    }
                }

                var stats = new FighterFightsStats()
                {
                    Upcoming = upcoming,
                    Win = win,
                    Loss = loss,
                    Draw = draw,
                    NoContest = noContest,
                };

                return stats;
            }
        }
    }
}
