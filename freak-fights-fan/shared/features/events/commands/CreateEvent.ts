export namespace CreateEvent {
    export interface Command {
        name: string;
        date: Date | undefined;
        federationId: number;
        cityId: number | undefined;
        hallId: number | undefined;
    }
}
