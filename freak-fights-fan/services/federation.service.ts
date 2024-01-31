import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs/internal/Observable';
import { GetAllFederations } from '../shared/features/federations/queries/GetAllFederations';
import { PagedList } from '../shared/abstractions/PagedList';
import { FederationDto } from '../shared/features/federations/responses/FederationDto';
import { CreateFederation } from '../shared/features/federations/commands/CreateFederation';
import { UpdateFederation } from '../shared/features/federations/commands/UpdateFederation';

@Injectable({
  providedIn: 'root'
})
export class FederationService {
  url = "api/federations";

  constructor(private apiService: ApiService) { }

  getAllFederations(query: GetAllFederations.Query): Observable<PagedList<FederationDto>> {
    return this.apiService.postWithResponse<GetAllFederations.Query, PagedList<FederationDto>>(`${this.url}/all`, query);
  }

  getFederation(id: number): Observable<FederationDto> {
    return this.apiService.get<FederationDto>(`${this.url}/${id}`);
  }

  createFederation(command: CreateFederation.Command) {
    return this.apiService.post(this.url, command);
  }

  updateFederation(command: UpdateFederation.Command) {
    return this.apiService.put(`${this.url}/${command.id}`, command);
  }

  deleteFederation(id: number) {
    return this.apiService.delete(`${this.url}/${id}`);
  }
}
