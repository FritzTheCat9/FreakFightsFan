using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Helpers;

namespace FreakFightsFan.Api.Services
{
    public interface IFightService
    {
        Task<FightResult> GetFightResultForFighter(int fightId, int fighterId);
    }

    public class FightService : IFightService
    {
        private readonly IFightRepository _fightRepository;

        public FightService(IFightRepository fightRepository)
        {
            _fightRepository = fightRepository;
        }

        public async Task<FightResult> GetFightResultForFighter(int fightId, int fighterId)
        {
            var fight = await _fightRepository.Get(fightId) ?? throw new MyNotFoundException();
            var team = fight.Teams.FirstOrDefault(x => x.Fighters.Any(x => x.Id == fighterId)) ?? throw new MyNotFoundException();
            var teamFighter = team.TeamFighters.FirstOrDefault(x => x.FighterId == fighterId) ?? throw new MyNotFoundException();

            return teamFighter.FightResult;
        }
    }
}
