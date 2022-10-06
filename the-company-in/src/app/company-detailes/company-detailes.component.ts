import { Component, OnInit } from '@angular/core';
import { CompaniesService, Company } from '../companies.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-company-detailes',
  templateUrl: './company-detailes.component.html',
  styleUrls: ['./company-detailes.component.scss'],
})
export class CompanyDetailesComponent implements OnInit {
  company: Company | undefined;
  constructor(
    private ac: ActivatedRoute,
    private companiesService: CompaniesService
  ) {}
  id!: string;

  ngOnInit(): void {
    this.id = this.ac.snapshot.params['id'];
    this.companiesService
      .getCompany(this.id)
      .subscribe((i) => (this.company = i));
  }

  likeCompany() {
    this.companiesService
      .likeCompany(this.id)
      .subscribe(() => alert('favorite!'));
  }
}
