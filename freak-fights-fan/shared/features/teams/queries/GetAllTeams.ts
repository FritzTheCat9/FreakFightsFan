import { IPagedQuery } from "../../../abstractions/IPagedQuery";

export namespace GetAllTeams {
    export interface Query extends IPagedQuery {
        page: number;
        pageSize: number;
    }
}
