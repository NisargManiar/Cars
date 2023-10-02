import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {

  readonly apiUrl = 'http://localhost:50306/api/';
  constructor(private http: HttpClient) { }
  getCarsList(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl + 'Cars/GetCarList');
  }

  addCars(Car: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.apiUrl + 'Cars/CreateCar', Car, httpOptions);
  }

  updateCars(Car: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put<any>(this.apiUrl + 'Cars/UpdateCar/', Car, httpOptions);
  }

  deleteCars(CarId: number): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete<number>(this.apiUrl + 'Cars/DeleteCar/' + CarId, httpOptions);
  }
}
