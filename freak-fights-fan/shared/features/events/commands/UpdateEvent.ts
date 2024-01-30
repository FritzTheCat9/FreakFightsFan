export namespace UpdateEvent {
    export interface Command {
        id: number;
        name: string;
        date: Date | undefined;
        cityId: number | undefined;
        hallId: number | undefined;
    }
}
