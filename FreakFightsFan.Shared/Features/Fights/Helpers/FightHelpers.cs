using static FreakFightsFan.Shared.Features.Fights.Commands.CreateFight;

namespace FreakFightsFan.Shared.Features.Fights.Helpers;

public static class FightHelpers
{
    public static bool HaveUniqueFighters(List<CreateTeamModel> teams)
    {
        var allFightersIds = new List<int>();

        foreach (var fighter in teams.SelectMany(createTeamModel => createTeamModel.Fighters))
        {
            if (allFightersIds.Contains(fighter.FighterId))
            {
                return false;
            }

            allFightersIds.Add(fighter.FighterId);
        }

        return true;
    }
}