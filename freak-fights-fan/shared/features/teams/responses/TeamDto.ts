import { FighterInTeamDto } from "../../fighters/responses/FighterInTeamDto";

export interface TeamDto {
    id: number;
    created: Date;
    modified: Date;

    Number: number;
    FightId: number;
    FighterInTeams: Array<FighterInTeamDto>;
}