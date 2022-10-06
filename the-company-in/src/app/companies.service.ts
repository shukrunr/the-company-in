import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DataService } from './data-service.service';

export class Company {
  id: string = '';
  logo: string = '';
  name: string = '';
  domain: string = '';
  description: string = '';
  category: Category = new Category();
  metrics: Metrics = new Metrics();
  location: string = '';
  type: boolean = false;
}
class Category {
  industry: string = '';
}
class Metrics {
  marketCap: number = 0;
  annualRevenue: number | null = 0;
  employees: number = 0;
  raised: number | null = 0;
}

@Injectable({
  providedIn: 'root',
})
export class CompaniesService {
  constructor(private data: DataService) {}

  getList(): Observable<Company[]> {
    return this.data.get('http://localhost:5064/companies/list/');
  }
  
  search<T>(value: string): Observable<Company> {
    return this.data.get<Company>(
      'http://localhost:5064/companies/search/' + value
    );
  }
  getCompany<T>(id: string): Observable<Company> {
    return this.data.get<Company>(
      'http://localhost:5064/companies/company/' + id
    );
  }
  likeCompany(id: string) {
    return this.data.put('http://localhost:5064/companies/like', id);
  }
}
