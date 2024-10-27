using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Fights.Queries;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Queries;

public static class GetFighterProfileFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/fights/fighter/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetFighterProfile.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithTags(Tags.Fights)
            .AllowAnonymous();
    }

    public class Handler(
        IFightRepository fightRepository,
        IFightService fightService)
        : IRequestHandler<GetFighterProfile.Query, FighterProfileDto>
    {
        public async Task<FighterProfileDto> Handle(
            GetFighterProfile.Query query,
            CancellationToken cancellationToken)
        {
            var fights = await fightRepository.GetFighterFights(query.Id) ?? throw new MyNotFoundException();

            var profileFights = new List<ProfileFightDto>();
            foreach (var fight in fights)
            {
                var fightResult = await fightService.GetFightResultForFighter(fight.Id, query.Id);
                profileFights.Add(new ProfileFightDto { Fight = fight.ToDto(), FightResult = fightResult });
            }

            var fighterProfileDto = new FighterProfileDto()
            {
                ProfileFights = profileFights, Stats = GetFighterStats(profileFights)
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
                    case FightResult.Upcoming:
                        upcoming++;
                        break;
                    case FightResult.Win:
                        win++;
                        break;
                    case FightResult.Loss:
                        loss++;
                        break;
                    case FightResult.Draw:
                        draw++;
                        break;
                    case FightResult.NoContest:
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