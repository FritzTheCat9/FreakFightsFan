import { CollectionViewer, DataSource } from '@angular/cdk/collections';
import { BehaviorSubject, Observable } from 'rxjs';
import { GetAllMyDictionaries } from '../../../shared/features/dictionaries/queries/GetAllMyDictionaries';
import { MyDictionaryService } from '../../../services/my-dictionary.service';
import { MyDictionaryDto } from '../../../shared/features/dictionaries/responses/MyDictionaryDto';
import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root'
})
export class DictionariesDataSource implements DataSource<MyDictionaryDto> {
    private dataSubject = new BehaviorSubject<MyDictionaryDto[]>([]);
    private loadingSubject = new BehaviorSubject<boolean>(false);
    private totalCountSubject = new BehaviorSubject<number>(0);

    public loading$ = this.loadingSubject.asObservable();
    public totalCount$ = this.totalCountSubject.asObservable();

    constructor(private myDictionaryService: MyDictionaryService) { }

    connect(collectionViewer: CollectionViewer): Observable<MyDictionaryDto[]> {
        return this.dataSubject.asObservable();
    }

    disconnect(collectionViewer: CollectionViewer): void {
        this.dataSubject.complete();
        this.loadingSubject.complete();
        this.totalCountSubject.complete();
    }

    // testDelay = (ms: number) => new Promise(res => setTimeout(res, ms));

    async loadData(query: GetAllMyDictionaries.Query) {
        this.loadingSubject.next(true);

        // await this.testDelay(1000);
        this.myDictionaryService.getAllMyDictionaries(query).subscribe({
            next: (v) => {
                console.log(v);
                this.dataSubject.next(v.items);
                this.loadingSubject.next(false);
                this.totalCountSubject.next(v.totalCount);
            },
            error: (e) => {
                console.error(e);
                this.dataSubject.next([]);
                this.loadingSubject.next(false);
                this.totalCountSubject.next(0);
            },
        });
    }
}