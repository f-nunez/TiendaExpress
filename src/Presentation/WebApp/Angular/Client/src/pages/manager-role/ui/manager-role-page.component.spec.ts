import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagerRolePageComponent } from './manager-role-page.component';

describe('ManagerRolePageComponent', () => {
  let component: ManagerRolePageComponent;
  let fixture: ComponentFixture<ManagerRolePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManagerRolePageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ManagerRolePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
