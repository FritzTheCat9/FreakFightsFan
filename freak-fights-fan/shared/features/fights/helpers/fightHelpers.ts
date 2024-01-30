import { CreateFight } from "../commands/CreateFight";

class FightHelpers {
    static haveUniqueFighters(teams: CreateFight.CreateTeamModel[]): boolean {
        const allFightersIds: number[] = [];

        for (const createTeamModel of teams) {
            for (const fighter of createTeamModel.fighters) {
                if (allFightersIds.includes(fighter.fighterId)) {
                    return false;
                }

                allFightersIds.push(fighter.fighterId);
            }
        }

        return true;
    }
}