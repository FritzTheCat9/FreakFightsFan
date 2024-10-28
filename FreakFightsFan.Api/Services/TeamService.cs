using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Commands;

namespace FreakFightsFan.Api.Services;

public interface ITeamService
{
    Task<List<Team>> CreateFightTeams(List<CreateFight.CreateTeamModel> teams);
}

public class TeamService(
    IFighterRepository fighterRepository,
    IClock clock) : ITeamService
{
    public async Task<List<Team>> CreateFightTeams(List<CreateFight.CreateTeamModel> teams)
    {
        var teamsInFight = new List<Team>();
        var teamNumber = 0;
        foreach (var createTeamModel in teams)
        {
            var team = new Team { Created = clock.Current(), Modified = clock.Current(), Number = teamNumber };

            var teamFighters = new List<TeamFighter>();
            foreach (var teamFighterModel in createTeamModel.Fighters)
            {
                var fighter = await fighterRepository.Get(teamFighterModel.FighterId) ??
                              throw new MyNotFoundException();
                var teamFighter = new TeamFighter
                {
                    Fighter = fighter, Team = team, FightResult = teamFighterModel.FightResult
                };
                teamFighters.Add(teamFighter);
            }

            ;

            team.TeamFighters.AddRange(teamFighters);

            teamsInFight.Add(team);
            teamNumber++;
        }

        return teamsInFight;
    }
}