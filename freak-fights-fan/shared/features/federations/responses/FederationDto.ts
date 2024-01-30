import { ImageDto } from "../../images/responses/ImageDto";

export interface FederationDto {
    id: number;
    created: Date;
    modified: Date;

    name: string;
    image: ImageDto | undefined;
}