import { Component, ViewChild } from '@angular/core';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatPaginator, MatPaginatorModule, PageEvent } from '@angular/material/paginator';
import { MyDictionaryService } from '../../../services/my-dictionary.service';
import { GetAllMyDictionaries } from '../../../shared/features/dictionaries/queries/GetAllMyDictionaries';
import { SortOrder } from '../../../shared/abstractions/SortOrder';
import { PagedList } from '../../../shared/abstractions/PagedList';
import { MyDictionaryDto } from '../../../shared/features/dictionaries/responses/MyDictionaryDto';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatSort, MatSortModule } from '@angular/material/sort';
import { MatFormFieldModule } from '@angular/material/form-field';
import { PaginationData } from '../../../shared/abstractions/PaginationData';

@Component({
  selector: 'app-dictionaries',
  standalone: true,
  imports: [MatTableModule, MatPaginatorModule, MatIconModule, MatButtonModule, MatSortModule, MatFormFieldModule],
  templateUrl: './dictionaries.component.html',
  styleUrl: './dictionaries.component.css'
})
export class DictionariesComponent {
  displayedColumns: string[] = ['name', 'code', 'dictionaryItems', 'actions'];

  myDictionaries!: PagedList<MyDictionaryDto>;
  dataSource!: MatTableDataSource<MyDictionaryDto>;

  @ViewChild(MatSort) sort!: MatSort;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  paginationData: PaginationData = new PaginationData();

  constructor(private myDictionaryApiService: MyDictionaryService) {
    this.serverReload();
  }

  serverReload(): void {
    let query = <GetAllMyDictionaries.Query>{};
    query.page = this.paginationData.pageIndex + 1;
    query.pageSize = this.paginationData.pageSize;
    query.sortColumn = "";              //SortLabel - add sort field
    query.sortOrder = SortOrder.None;   //SortDirection - add sort field
    query.searchTerm = "";

    this.myDictionaryApiService.getAllMyDictionaries(query).subscribe({
      next: (v) => {
        console.log(v);
        this.myDictionaries = v;
        this.dataSource = new MatTableDataSource<MyDictionaryDto>(this.myDictionaries.items);
        this.paginationData.totalCount = this.myDictionaries.totalCount;
      },
      error: (e) => {
        console.error(e);
        this.dataSource = new MatTableDataSource<MyDictionaryDto>([]);
        this.paginationData.totalCount = 0;
      },
      complete: () => {
        console.info('complete');
      }
    });
  }

  onPageChange(event: PageEvent): void {
    this.paginationData.pageSize = event.pageSize;
    this.paginationData.pageIndex = event.pageIndex;

    this.serverReload();
  }
}
