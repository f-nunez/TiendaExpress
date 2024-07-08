import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Store } from '@ngrx/store';
import { sessionModel } from '~entities/session';
import { routePath } from '~shared/router';

@Component({
  selector: 'sign-out-dropdown',
  templateUrl: './sign-out-dropdown.component.html',
  styleUrl: './sign-out-dropdown.component.scss'
})
export class SignOutDropdownComponent {

  constructor(private readonly store: Store, private router: Router) { }

  onClickLogout() {
    this.store.dispatch(sessionModel.actions.logout());
    this.router.navigate([routePath.home()]);
  }
}
