import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CompanyDetailesComponent } from './company-detailes.component';

describe('CompanyDetailesComponent', () => {
  let component: CompanyDetailesComponent;
  let fixture: ComponentFixture<CompanyDetailesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CompanyDetailesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CompanyDetailesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
