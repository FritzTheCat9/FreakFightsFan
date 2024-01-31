import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { GetAllTeams } from '../shared/features/teams/queries/GetAllTeams';
import { Observable } from 'rxjs/internal/Observable';
import { PagedList } from '../shared/abstractions/PagedList';
import { TeamDto } from '../shared/features/teams/responses/TeamDto';

@Injectable({
  providedIn: 'root'
})
export class TeamService {
  url = "api/teams";

  constructor(private apiService: ApiService) { }

  getAllTeams(query: GetAllTeams.Query): Observable<PagedList<TeamDto>> {
    return this.apiService.postWithResponse<GetAllTeams.Query, PagedList<TeamDto>>(`${this.url}/all`, query);
  }

  getTeam(id: number): Observable<TeamDto> {
    return this.apiService.get<TeamDto>(`${this.url}/${id}`);
  }
}
