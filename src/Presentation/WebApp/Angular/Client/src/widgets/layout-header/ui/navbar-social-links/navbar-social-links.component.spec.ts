import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavbarSocialLinksComponent } from './navbar-social-links.component';

describe('NavbarSocialLinksComponent', () => {
  let component: NavbarSocialLinksComponent;
  let fixture: ComponentFixture<NavbarSocialLinksComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NavbarSocialLinksComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NavbarSocialLinksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
