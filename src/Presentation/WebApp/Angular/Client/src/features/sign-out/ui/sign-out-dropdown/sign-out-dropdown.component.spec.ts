import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SignOutDropdownComponent } from './sign-out-dropdown.component';

describe('SignOutDropdownComponent', () => {
  let component: SignOutDropdownComponent;
  let fixture: ComponentFixture<SignOutDropdownComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SignOutDropdownComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SignOutDropdownComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
