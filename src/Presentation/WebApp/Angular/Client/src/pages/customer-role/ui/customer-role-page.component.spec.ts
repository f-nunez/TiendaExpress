import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerRolePageComponent } from './customer-role-page.component';

describe('CustomerRolePageComponent', () => {
  let component: CustomerRolePageComponent;
  let fixture: ComponentFixture<CustomerRolePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CustomerRolePageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CustomerRolePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
