import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavbarDividerComponent } from './navbar-divider.component';

describe('NavbarDividerComponent', () => {
  let component: NavbarDividerComponent;
  let fixture: ComponentFixture<NavbarDividerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NavbarDividerComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NavbarDividerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
