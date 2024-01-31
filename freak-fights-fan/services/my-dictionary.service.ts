import { Injectable } from '@angular/core';
import { ApiService } from '../services/api.service';
import { Observable } from 'rxjs';
import { MyDictionaryDto } from '../shared/features/dictionaries/responses/MyDictionaryDto';
import { GetAllMyDictionaries } from '../shared/features/dictionaries/queries/GetAllMyDictionaries';
import { CreateMyDictionary } from '../shared/features/dictionaries/commands/CreateMyDictionary';
import { UpdateMyDictionary } from '../shared/features/dictionaries/commands/UpdateMyDictionary';
import { PagedList } from '../shared/abstractions/PagedList';

@Injectable({
  providedIn: 'root'
})
export class MyDictionaryService {
  url = "api/myDictionaries";

  constructor(private apiService: ApiService) { }

  getAllMyDictionaries(query: GetAllMyDictionaries.Query): Observable<PagedList<MyDictionaryDto>> {
    return this.apiService.postWithResponse<GetAllMyDictionaries.Query, PagedList<MyDictionaryDto>>(`${this.url}/all`, query);
  }

  getMyDictionary(id: number): Observable<MyDictionaryDto> {
    return this.apiService.get<MyDictionaryDto>(`${this.url}/${id}`);
  }

  createMyDictionary(command: CreateMyDictionary.Command) {
    return this.apiService.post(this.url, command);
  }

  updateMyDictionary(command: UpdateMyDictionary.Command) {
    return this.apiService.put(`${this.url}/${command.id}`, command);
  }

  deleteMyDictionary(id: number) {
    return this.apiService.delete(`${this.url}/${id}`);
  }
}
