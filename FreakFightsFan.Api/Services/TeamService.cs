using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Commands;

namespace FreakFightsFan.Api.Services
{
    public interface ITeamService
    {
        Task<List<Team>> CreateFightTeams(List<CreateFight.CreateTeamModel> teams);
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

        public async Task<List<Team>> CreateFightTeams(List<CreateFight.CreateTeamModel> teams)
        {
            var teamsInFight = new List<Team>();
            var teamNumber = 0;
            foreach (var createTeamModel in teams)
            {
                var team = new Team
                {
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Number = teamNumber,
                };

                var teamFighters = new List<TeamFighter>();
                foreach (var teamFighterModel in createTeamModel.Fighters)
                {
                    var fighter = await _fighterRepository.Get(teamFighterModel.FighterId) ?? throw new MyNotFoundException();
                    var teamFighter = new TeamFighter()
                    {
                        Fighter = fighter,
                        Team = team,
                        FightResult = teamFighterModel.FightResult
                    };
                    teamFighters.Add(teamFighter);
                };

                team.TeamFighters.AddRange(teamFighters);

                teamsInFight.Add(team);
                teamNumber++;
            }

            return teamsInFight;
        }
    }
}
