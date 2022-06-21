import { Injectable } from '@angular/core';
import {
  HttpClientModule,
  HttpHeaders,
  HttpClient,
} from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class LeadService {
  readonly url = 'https://localhost:7156/';

  constructor(private http: HttpClient) {}

  getLeads(dados: any) {
    return this.http.get<any>(this.url + 'Lead', {
      params: dados,
    });
  }

  updateLead(dados: any) {
    return this.http.put<any>(this.url + 'Lead',
    dados,
    );
  }
}
