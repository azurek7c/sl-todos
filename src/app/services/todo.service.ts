import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class TodoService {
  private baseUrl = 'http://localhost:7071/api/gettodos';

  constructor(private http: HttpClient) {}
  getToDos(): Observable<any> {
    return this.http.get(this.baseUrl);
  }
}
