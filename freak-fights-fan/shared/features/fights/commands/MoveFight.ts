import { MoveDirection } from "../../../abstractions/MoveDirection";

export namespace MoveFight {
    export interface Command {
        id: number;
        direction: MoveDirection;
    }
}
