import { SortDirection } from "@angular/material/sort";

export enum SortOrder {
    None = 0,
    Ascending = 1,
    Descending = 2,
}

export function ToSortOrder(direction: SortDirection) {
    switch (direction) {
        case 'asc':
            return SortOrder.Ascending;
        case 'desc':
            return SortOrder.Descending;
        default:
            return SortOrder.None;
    }
}

export function ToSortDirection(sortOrder: SortOrder) {
    switch (sortOrder) {
        case SortOrder.Ascending:
            return 'asc';
        case SortOrder.Descending:
            return 'desc';
        default:
            return '';
    }
}
