import { FightResult } from "../helpers/fightResult";

export namespace CreateFight {
    export interface Command {
        eventId: number;
        teams: Array<CreateTeamModel>;
        videoUrl: string;
        typeId: number | undefined;
    }

    export interface CreateTeamModel {
        fighters: Array<TeamFighterModel>;
    }

    export interface TeamFighterModel {
        fighterId: number;
        fightResult: FightResult;
    }
}