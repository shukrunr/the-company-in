import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  constructor(private _http: HttpClient) {}

  get<T>(endpoint: string): Observable<T> {
    return this._http.get<T>(endpoint);
  }

  put<T>(endpoint: string, id: string): Observable<T> {
    return this._http.put<T>(endpoint, { id });
  }
}
