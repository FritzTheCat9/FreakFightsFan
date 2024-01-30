import { FightResult } from "../../fights/helpers/fightResult";
import { FighterDto } from "./FighterDto";

export interface FighterInTeamDto {
    fighter: FighterDto;
    fightResult: FightResult;
}