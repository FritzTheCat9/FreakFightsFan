export namespace UpdateFighter {
    export interface Command {
        id: number;
        firstName: string;
        lastName: string;
        nickname: string;
        instagramUrl: string;
        imageBase64: string;
    }
}
