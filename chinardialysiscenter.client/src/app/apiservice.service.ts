import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiserviceService {
  readonly apiUrl = 'http://localhost:50306/api/';
  constructor(private http: HttpClient) { }

  // Department
  getMembersList(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl + 'membership/GetMembers');
  }
  addMembership(member: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.apiUrl + 'membership/AddMember', member, httpOptions);
  }

  updateMembership(member: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.put<any>(this.apiUrl + 'membership/UpdateMember/', member, httpOptions);
  }

  deleteMembership(memberId: number): Observable<number> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.delete<number>(this.apiUrl + 'membership/DeleteMember/' + memberId, httpOptions);
  }
}
