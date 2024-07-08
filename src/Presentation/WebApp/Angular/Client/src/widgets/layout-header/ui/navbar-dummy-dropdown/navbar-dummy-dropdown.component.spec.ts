import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavbarDummyDropdownComponent } from './navbar-dummy-dropdown.component';

describe('NavbarDummyDropdownComponent', () => {
  let component: NavbarDummyDropdownComponent;
  let fixture: ComponentFixture<NavbarDummyDropdownComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NavbarDummyDropdownComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NavbarDummyDropdownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
