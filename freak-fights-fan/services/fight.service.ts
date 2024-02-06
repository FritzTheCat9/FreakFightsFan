import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { GetAllFights } from '../shared/features/fights/queries/GetAllFights';
import { Observable } from 'rxjs/internal/Observable';
import { PagedList } from '../shared/abstractions/PagedList';
import { FightDto } from '../shared/features/fights/responses/FightDto';
import { FighterProfileDto } from '../shared/features/fights/responses/FighterProfileDto';
import { CreateFight } from '../shared/features/fights/commands/CreateFight';
import { UpdateFight } from '../shared/features/fights/commands/UpdateFight';
import { MoveFight } from '../shared/features/fights/commands/MoveFight';

@Injectable({
  providedIn: 'root'
})
export class FightService {
  url = "api/fights";

  constructor(private apiService: ApiService) { }

  getAllFights(query: GetAllFights.Query): Observable<PagedList<FightDto>> {
    return this.apiService.postWithResponse<GetAllFights.Query, PagedList<FightDto>>(`${this.url}/all`, query);
  }

  getFighterProfile(id: number): Observable<FighterProfileDto> {
    return this.apiService.get<FighterProfileDto>(`${this.url}/fighter/${id}`);
  }

  getFight(id: number): Observable<FightDto> {
    return this.apiService.get<FightDto>(`${this.url}/${id}`);
  }

  createFight(command: CreateFight.Command): Observable<void> {
    return this.apiService.post(this.url, command);
  }

  updateFight(command: UpdateFight.Command): Observable<void> {
    return this.apiService.put(`${this.url}/${command.id}`, command);
  }

  deleteFight(id: number): Observable<void> {
    return this.apiService.delete(`${this.url}/${id}`);
  }

  moveFight(command: MoveFight.Command): Observable<void> {
    return this.apiService.put(`${this.url}/move/${command.id}`, command);
  }
}