import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs/internal/Observable';
import { PagedList } from '../shared/abstractions/PagedList';
import { ConfirmEmail } from '../shared/features/users/commands/ConfirmEmail';
import { Login } from '../shared/features/users/commands/Login';
import { JwtDto } from '../shared/features/users/responses/JwtDto';
import { Register } from '../shared/features/users/commands/Register';
import { UpdateUser } from '../shared/features/users/commands/UpdateUser';
import { GetAllUsers } from '../shared/features/users/queries/GetAllUsers';
import { UserDto } from '../shared/features/users/responses/UserDto';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  url = "api/users";

  constructor(private apiService: ApiService) { }

  confirmEmail(command: ConfirmEmail.Command): Observable<void> {
    return this.apiService.post(`${this.url}/confirmEmail`, command);
  }

  degradeUser(id: number): Observable<void> {
    return this.apiService.putWithoutBody(`${this.url}/degrade/${id}`);
  }

  login(command: Login.Command): Observable<JwtDto> {
    return this.apiService.postWithResponse<Login.Command, JwtDto>(`${this.url}/login`, command);
  }

  promoteUser(id: number): Observable<void> {
    return this.apiService.putWithoutBody(`${this.url}/promote/${id}`);
  }

  register(command: Register.Command): Observable<void> {
    return this.apiService.post(`${this.url}/register`, command);
  }

  updateUser(command: UpdateUser.Command): Observable<void> {
    return this.apiService.put(`${this.url}/${command.id}`, command);
  }

  getAllUsers(query: GetAllUsers.Query): Observable<PagedList<UserDto>> {
    return this.apiService.postWithResponse<GetAllUsers.Query, PagedList<UserDto>>(`${this.url}/all`, query);
  }

  getUser(id: number): Observable<UserDto> {
    return this.apiService.get<UserDto>(`${this.url}/${id}`);
  }
}
