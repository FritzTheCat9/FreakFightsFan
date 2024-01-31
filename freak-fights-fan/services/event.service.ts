import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { GetAllEvents } from '../shared/features/events/queries/GetAllEvents';
import { PagedList } from '../shared/abstractions/PagedList';
import { EventDto } from '../shared/features/events/responses/EventDto';
import { Observable } from 'rxjs/internal/Observable';
import { CreateEvent } from '../shared/features/events/commands/CreateEvent';
import { UpdateEvent } from '../shared/features/events/commands/UpdateEvent';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  url = "api/events";

  constructor(private apiService: ApiService) { }

  getAllEvents(query: GetAllEvents.Query): Observable<PagedList<EventDto>> {
    return this.apiService.postWithResponse<GetAllEvents.Query, PagedList<EventDto>>(`${this.url}/all`, query);
  }

  getEvent(id: number): Observable<EventDto> {
    return this.apiService.get<EventDto>(`${this.url}/${id}`);
  }

  createEvent(command: CreateEvent.Command) {
    return this.apiService.post(this.url, command);
  }

  updateEvent(command: UpdateEvent.Command) {
    return this.apiService.put(`${this.url}/${command.id}`, command);
  }

  deleteEvent(id: number) {
    return this.apiService.delete(`${this.url}/${id}`);
  }
}
