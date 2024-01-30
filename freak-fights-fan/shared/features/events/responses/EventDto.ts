import { MyDictionaryItemDto } from "../../dictionaryItems/responses/MyDictionaryItemDto";

export interface EventDto {
    id: number;
    created: Date;
    modified: Date;

    name: string;
    date: Date;
    federationId: number;
    city: MyDictionaryItemDto | undefined;
    hall: MyDictionaryItemDto | undefined;
}