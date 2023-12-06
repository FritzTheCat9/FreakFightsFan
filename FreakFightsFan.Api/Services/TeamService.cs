using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Requests;

namespace FreakFightsFan.Api.Services
{
    public interface ITeamService
    {
        Task<List<Team>> CreateFightTeams(List<CreateTeamModel> teams);
    }

    public class TeamService : ITeamService
    {
        private readonly IFighterRepository _fighterRepository;
        private readonly IClock _clock;

        public TeamService(IFighterRepository fighterRepository, IClock clock)
        {
            _fighterRepository = fighterRepository;
            _clock = clock;
        }

        public async Task<List<Team>> CreateFightTeams(List<CreateTeamModel> teams)
        {
            var teamsInFight = new List<Team>();
            var teamNumber = 0;
            foreach (var createTeamModel in teams)
            {
                var fightersInTeam = new List<Fighter>();
                foreach (var fighterId in createTeamModel.FightersIds)
                {
                    var fighter = await _fighterRepository.Get(fighterId) ?? throw new MyNotFoundException();
                    fightersInTeam.Add(fighter);
                }

                var team = new Team
                {
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Number = teamNumber,
                };
                team.Fighters.AddRange(fightersInTeam);

                teamsInFight.Add(team);
                teamNumber++;
            }

            return teamsInFight;
        }
    }
}
