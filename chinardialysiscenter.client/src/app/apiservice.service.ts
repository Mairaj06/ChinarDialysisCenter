import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {
  readonly apiUrl = 'https://localhost:7122/api/';
  constructor(private http: HttpClient) { }

  // Department
  getMembersList(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl + 'GetMembers');
  }
  addMembership(member: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.apiUrl + 'AddMember', member, httpOptions);
  }

  updateMembership(member: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put<any>(this.apiUrl + 'UpdateMember/', member, httpOptions);
  }

  deleteMembership(memberId: number): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete<number>(this.apiUrl + 'DeleteMember/' + memberId, httpOptions);
  }
}
