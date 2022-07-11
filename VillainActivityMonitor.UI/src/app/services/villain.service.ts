import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { Villain } from '../models/villain';

@Injectable({
  providedIn: 'root'
})
export class VillainService {
  private url: string = "Villain";

  constructor(private http: HttpClient) { }

  public getVillains(): Observable<Villain[]> {
    return this.http.get<Villain[]>(`${environment.apiUrl}/${this.url}`);
  }
}
