import { FightResult } from "../helpers/fightResult";
import { FightDto } from "./FightDto";

export interface FighterProfileDto {
    profileFights: Array<ProfileFightDto>;
    stats: FighterFightsStats;
}

export interface ProfileFightDto {
    fight: FightDto;
    fightResult: FightResult;
}

export interface FighterFightsStats {
    upcoming: number;
    win: number;
    loss: number;
    draw: number;
    noContest: number;
}