import { Component, ViewChild } from '@angular/core';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatPaginator, MatPaginatorModule, PageEvent } from '@angular/material/paginator';
import { MyDictionaryService } from '../../../services/my-dictionary.service';
import { GetAllMyDictionaries } from '../../../shared/features/dictionaries/queries/GetAllMyDictionaries';
import { ToSortOrder } from '../../../shared/abstractions/SortOrder';
import { PagedList } from '../../../shared/abstractions/PagedList';
import { MyDictionaryDto } from '../../../shared/features/dictionaries/responses/MyDictionaryDto';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatSort, MatSortModule, Sort } from '@angular/material/sort';
import { MatFormFieldModule } from '@angular/material/form-field';
import { PaginationData } from '../../../shared/abstractions/PaginationData';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { SortingData } from '../../../shared/abstractions/SortingData';
import { MatInputModule } from '@angular/material/input';
import { FormsModule } from '@angular/forms';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { CreateDictionaryDialogComponent } from './create-dictionary-dialog/create-dictionary-dialog.component';

@Component({
  selector: 'app-dictionaries',
  standalone: true,
  imports: [MatTableModule, MatPaginatorModule, MatIconModule, MatButtonModule, MatSortModule, MatFormFieldModule, MatProgressBarModule, MatInputModule, FormsModule, MatDialogModule],
  templateUrl: './dictionaries.component.html',
  styleUrl: './dictionaries.component.css'
})
export class DictionariesComponent {
  displayedColumns: string[] = ['name', 'code', 'dictionaryItems', 'actions'];

  myDictionaries!: PagedList<MyDictionaryDto>;
  dataSource!: MatTableDataSource<MyDictionaryDto>;

  @ViewChild(MatSort) sort!: MatSort;
  sortingData: SortingData = new SortingData();

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  paginationData: PaginationData = new PaginationData();

  searchString: string = "";

  isLoading = false;

  constructor(
    private myDictionaryService: MyDictionaryService,
    private dialog: MatDialog
  ) {
    this.serverReload();
  }

  serverReload(): void {
    let query = <GetAllMyDictionaries.Query>{};
    query.page = this.paginationData.pageIndex + 1;
    query.pageSize = this.paginationData.pageSize;
    query.sortColumn = this.sortingData.active;
    query.sortOrder = ToSortOrder(this.sortingData.direction);
    query.searchTerm = this.searchString;

    this.isLoading = true;
    this.myDictionaryService.getAllMyDictionaries(query).subscribe({
      next: (v) => {
        console.log(v);
        this.myDictionaries = v;
        this.dataSource = new MatTableDataSource<MyDictionaryDto>(this.myDictionaries.items);
        this.paginationData.totalCount = this.myDictionaries.totalCount;
        this.isLoading = false;
      },
      error: (e) => {
        console.error(e);
        this.dataSource = new MatTableDataSource<MyDictionaryDto>([]);
        this.paginationData.totalCount = 0;
        this.isLoading = false;
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

  onSortChange(event: Sort) {
    this.sortingData.active = event.active;
    this.sortingData.direction = event.direction;

    this.serverReload();
  }

  onSearch(event: Event) {
    this.serverReload();
  }

  openDialog() {
    const dialogRef = this.dialog.open(CreateDictionaryDialogComponent, {
      autoFocus: false
    });

    dialogRef.afterClosed().subscribe(() => {
      this.serverReload();
    });
  }
}
