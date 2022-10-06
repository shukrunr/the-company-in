import { Component, Input, OnInit } from '@angular/core';
import { Company } from '../companies.service';

@Component({
  selector: 'app-company-card',
  templateUrl: './company-card.component.html',
  styleUrls: ['./company-card.component.scss'],
})
export class CompanyCardComponent implements OnInit {
  @Input() company: Company = new Company();
  constructor() {}

  ngOnInit(): void {}
}
