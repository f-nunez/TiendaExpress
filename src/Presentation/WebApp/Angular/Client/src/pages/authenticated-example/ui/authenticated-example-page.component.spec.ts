import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AuthenticatedExamplePageComponent } from './authenticated-example-page.component';

describe('AuthenticatedExamplePageComponent', () => {
  let component: AuthenticatedExamplePageComponent;
  let fixture: ComponentFixture<AuthenticatedExamplePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AuthenticatedExamplePageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AuthenticatedExamplePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
