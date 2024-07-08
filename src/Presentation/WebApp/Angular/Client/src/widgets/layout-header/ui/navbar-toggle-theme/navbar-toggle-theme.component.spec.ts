import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavbarToggleThemeComponent } from './navbar-toggle-theme.component';

describe('NavbarToggleThemeComponent', () => {
  let component: NavbarToggleThemeComponent;
  let fixture: ComponentFixture<NavbarToggleThemeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NavbarToggleThemeComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NavbarToggleThemeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
