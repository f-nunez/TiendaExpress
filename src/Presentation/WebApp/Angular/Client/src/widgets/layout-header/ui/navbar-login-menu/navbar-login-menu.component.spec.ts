import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavbarLoginMenuComponent } from './navbar-login-menu.component';

describe('NavbarLoginMenuComponent', () => {
  let component: NavbarLoginMenuComponent;
  let fixture: ComponentFixture<NavbarLoginMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NavbarLoginMenuComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NavbarLoginMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
