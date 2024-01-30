import { IPagedQuery } from "../../../abstractions/IPagedQuery";
import { ISortedQuery } from "../../../abstractions/ISortedQuery";

export namespace GetAllFights {
    export interface Query extends IPagedQuery, ISortedQuery {
        page: number;
        pageSize: number;
        eventId: number;
    }
}
