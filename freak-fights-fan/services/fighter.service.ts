import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { GetAllFighters } from '../shared/features/fighters/queries/GetAllFighters';
import { Observable } from 'rxjs/internal/Observable';
import { PagedList } from '../shared/abstractions/PagedList';
import { FighterDto } from '../shared/features/fighters/responses/FighterDto';
import { CreateFighter } from '../shared/features/fighters/commands/CreateFighter';
import { UpdateFighter } from '../shared/features/fighters/commands/UpdateFighter';

@Injectable({
  providedIn: 'root'
})
export class FighterService {
  url = "api/fighters";

  constructor(private apiService: ApiService) { }

  getAllFighters(query: GetAllFighters.Query): Observable<PagedList<FighterDto>> {
    return this.apiService.postWithResponse<GetAllFighters.Query, PagedList<FighterDto>>(`${this.url}/all`, query);
  }

  getFighter(id: number): Observable<FighterDto> {
    return this.apiService.get<FighterDto>(`${this.url}/${id}`);
  }

  createFighter(command: CreateFighter.Command): Observable<void> {
    return this.apiService.post(this.url, command);
  }

  updateFighter(command: UpdateFighter.Command): Observable<void> {
    return this.apiService.put(`${this.url}/${command.id}`, command);
  }

  deleteFighter(id: number): Observable<void> {
    return this.apiService.delete(`${this.url}/${id}`);
  }
}
