import { Component, OnInit } from '@angular/core';
import { CompaniesService, Company } from '../companies.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss'],
})
export class HomePageComponent implements OnInit {
  searchValue: string = '';
  companies: Company[] = [];

  constructor(public companiesService: CompaniesService) {}

  ngOnInit(): void {
    this.companiesService.getList().subscribe((res) => (this.companies = res));
  }

  search() {
    this.companiesService.search(this.searchValue).subscribe({
      next: (company) => {
        this.companies.push(company);
      },
      error: (err) => {
        alert('not found');
      },
    });
  }
}
