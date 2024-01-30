import { ImageDto } from "../../images/responses/ImageDto";

export interface FighterDto {
    id: number;
    created: Date;
    modified: Date;

    instagramUrl: string;
    firstName: string;
    lastName: string;
    nickname: string;
    image: ImageDto | undefined;
}