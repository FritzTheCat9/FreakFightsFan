import { CreateFight } from "./CreateFight";


export namespace UpdateFight {
    export interface Command {
        id: number;
        teams: Array<CreateFight.CreateTeamModel>;
        videoUrl: string;
        typeId: number | undefined;
    }
}
