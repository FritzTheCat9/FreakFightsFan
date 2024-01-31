import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { GetAllMyDictionaryItems } from '../shared/features/dictionaryItems/queries/GetAllMyDictionaryItems';
import { GetAllMyDictionaryItemsByCode } from '../shared/features/dictionaryItems/queries/GetAllMyDictionaryItemsByCode';
import { Observable } from 'rxjs/internal/Observable';
import { PagedList } from '../shared/abstractions/PagedList';
import { MyDictionaryItemDto } from '../shared/features/dictionaryItems/responses/MyDictionaryItemDto';
import { CreateMyDictionaryItem } from '../shared/features/dictionaryItems/commands/CreateMyDictionaryItem';
import { UpdateMyDictionaryItem } from '../shared/features/dictionaryItems/commands/UpdateMyDictionaryItem';

@Injectable({
  providedIn: 'root'
})
export class MyDictionaryItemService {
  url = "api/myDictionaryItems";

  constructor(private apiService: ApiService) { }

  getAllMyDictionaryItems(query: GetAllMyDictionaryItems.Query): Observable<PagedList<MyDictionaryItemDto>> {
    return this.apiService.postWithResponse<GetAllMyDictionaryItems.Query, PagedList<MyDictionaryItemDto>>(`${this.url}/all`, query);
  }

  getAllMyDictionaryItemsByCode(query: GetAllMyDictionaryItemsByCode.Query): Observable<PagedList<MyDictionaryItemDto>> {
    return this.apiService.postWithResponse<GetAllMyDictionaryItemsByCode.Query, PagedList<MyDictionaryItemDto>>(`${this.url}/allByCode`, query);
  }

  getMyDictionaryItem(id: number): Observable<MyDictionaryItemDto> {
    return this.apiService.get<MyDictionaryItemDto>(`${this.url}/${id}`);
  }

  createMyDictionaryItem(command: CreateMyDictionaryItem.Command) {
    return this.apiService.post(this.url, command);
  }

  updateMyDictionaryItem(command: UpdateMyDictionaryItem.Command) {
    return this.apiService.put(`${this.url}/${command.id}`, command);
  }

  deleteMyDictionaryItem(id: number) {
    return this.apiService.delete(`${this.url}/${id}`);
  }
}
