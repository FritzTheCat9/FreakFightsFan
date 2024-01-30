import { SortOrder } from "../../../abstractions/SortOrder";
import { IPagedQuery } from "../../../abstractions/IPagedQuery";
import { ISortedQuery } from "../../../abstractions/ISortedQuery";

export namespace GetAllMyDictionaryItemsByCode {
    export interface Query extends IPagedQuery, ISortedQuery {
        page: number;
        pageSize: number;
        sortColumn: string;
        sortOrder: SortOrder;
        searchTerm: string;

        dictionaryCode: string;
    }
}
