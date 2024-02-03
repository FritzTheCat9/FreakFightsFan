import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule, PageEvent } from '@angular/material/paginator';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatSortModule, Sort } from '@angular/material/sort';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatProgressBarModule } from '@angular/material/progress-bar';
import { MatInputModule } from '@angular/material/input';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { MyDictionaryService } from '../../../services/my-dictionary.service';
import { GetAllMyDictionaries } from '../../../shared/features/dictionaries/queries/GetAllMyDictionaries';
import { SortOrder, ToSortOrder } from '../../../shared/abstractions/SortOrder';
import { DictionariesDataSource } from './DictionariesDataSource';
import { MyDictionaryDto } from '../../../shared/features/dictionaries/responses/MyDictionaryDto';
import { CreateDictionaryDialogComponent } from './create-dictionary-dialog/create-dictionary-dialog.component';
import { UpdateDictionaryDialogComponent } from './update-dictionary-dialog/update-dictionary-dialog.component';

@Component({
  selector: 'app-dictionaries',
  standalone: true,
  imports: [CommonModule, MatTableModule, MatPaginatorModule, MatIconModule, MatButtonModule, MatSortModule, MatFormFieldModule, MatProgressBarModule, MatInputModule, FormsModule, MatDialogModule],
  templateUrl: './dictionaries.component.html',
  styleUrl: './dictionaries.component.css'
})
export class DictionariesComponent implements OnInit {
  displayedColumns: string[] = ['name', 'code', 'dictionaryItems', 'actions'];

  searchString = "";
  query: GetAllMyDictionaries.Query =
    {
      page: 1,
      pageSize: 10,
      sortColumn: "",
      sortOrder: SortOrder.None,
      searchTerm: ""
    }

  dataSource: DictionariesDataSource;
  totalCount = 0;
  loading = false;

  constructor(
    private dictionariesDataSource: DictionariesDataSource,
    private myDictionaryService: MyDictionaryService,
    private dialog: MatDialog
  ) {
    this.dataSource = dictionariesDataSource;
  }

  ngOnInit(): void {
    this.dataSource.loadData(this.query);

    this.dataSource.totalCount$.subscribe(totalCount => {
      this.totalCount = totalCount;
    });

    this.dataSource.loading$.subscribe(loading => {
      this.loading = loading;
    });
  }

  onPageChange(event: PageEvent): void {
    this.query.page = event.pageIndex + 1;
    this.query.pageSize = event.pageSize;
    this.dataSource.loadData(this.query);
  }

  onSortChange(event: Sort): void {
    this.query.sortColumn = event.active;
    this.query.sortOrder = ToSortOrder(event.direction);
    this.dataSource.loadData(this.query);
  }

  onSearch(event: Event): void {
    this.query.searchTerm = this.searchString;
    this.dataSource.loadData(this.query);
  }

  createDictionary() {
    const dialogRef = this.dialog.open(CreateDictionaryDialogComponent, {
      autoFocus: false
    });

    dialogRef.afterClosed().subscribe(() => {
      this.dataSource.loadData(this.query);
    });
  }

  updateDictionary(myDictionaryDto: MyDictionaryDto) {
    const dialogRef = this.dialog.open(UpdateDictionaryDialogComponent, {
      autoFocus: false,
      data: { myDictionaryDto: myDictionaryDto }
    });

    dialogRef.afterClosed().subscribe(() => {
      this.dataSource.loadData(this.query);
    });
  }

  deleteDictionary(id: number) {
    // TODO: add dialog

    this.myDictionaryService.deleteMyDictionary(id).subscribe({
      next: () => {
        this.dataSource.loadData(this.query);
      },
      error: (e) => {
        console.error(e);
      }
    });
  }
}
