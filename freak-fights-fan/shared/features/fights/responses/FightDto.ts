import { MyDictionaryItemDto } from "../../dictionaryItems/responses/MyDictionaryItemDto";
import { EventDto } from "../../events/responses/EventDto";
import { TeamDto } from "../../teams/responses/TeamDto";

export interface FightDto {
    id: number;
    created: Date;
    modified: Date;
    orderNumber: number;
    videoUrl: string;

    eventId: number;
    event: EventDto;
    teams: Array<TeamDto>;
    type: MyDictionaryItemDto | undefined;
}