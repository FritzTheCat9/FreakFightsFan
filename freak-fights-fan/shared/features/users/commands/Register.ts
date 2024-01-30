export namespace Register {
    export interface Command {
        email: string;
        userName: string;
        password: string;
        repeatPassword: string;
    }
}
