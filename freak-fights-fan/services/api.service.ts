import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  baseUrl = "https://localhost:7277";

  constructor(private http: HttpClient) { }

  get<TResponse>(url: string): Observable<TResponse> {
    return this.http.get<TResponse>(`${this.baseUrl}/${url}`);
  }

  post<TRequest>(url: string, tRequest: TRequest): Observable<void> {
    return this.http.post<void>(`${this.baseUrl}/${url}`, tRequest);
  }

  postWithResponse<TRequest, TResponse>(url: string, tRequest: TRequest): Observable<TResponse> {
    return this.http.post<TResponse>(`${this.baseUrl}/${url}`, tRequest);
  }

  put<TRequest>(url: string, tRequest: TRequest): Observable<void> {
    return this.http.put<void>(`${this.baseUrl}/${url}`, tRequest);
  }

  putWithoutBody(url: string): Observable<void> {
    return this.http.put<void>(`${this.baseUrl}/${url}`, null);
  }

  delete(url: string): Observable<void> {
    return this.http.delete<void>(`${this.baseUrl}/${url}`);
  }
}
