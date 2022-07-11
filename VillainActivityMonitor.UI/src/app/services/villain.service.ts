import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment';
import { Villain } from '../models/villain';

@Injectable({
  providedIn: 'root'
})
export class VillainService {
  constructor(private http: HttpClient) { }

  public getVillains(): Observable<Villain[]> {
    return this.http.get<Villain[]>(`${environment.apiUrl}/Villain/GetVillains`);
  }

  public addVillain(villain: Villain): void {
    this.http.post(`${environment.apiUrl}/Villain/AddVillain`, villain);
  }
}
