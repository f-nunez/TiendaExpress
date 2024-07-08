import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Store } from '@ngrx/store';
import { sessionModel } from '~entities/session';
import { routePath } from '~shared/router';

@Component({
  selector: 'navbar-login-menu',
  templateUrl: './navbar-login-menu.component.html',
  styleUrl: './navbar-login-menu.component.scss'
})
export class NavbarLoginMenuComponent {
  constructor(private readonly store: Store, private router: Router) { }

  onClickLogin() {
    let path = location.pathname;
    const currentPath = path.startsWith('/') ? path.substring(1, path.length) : path;
    this.store.dispatch(sessionModel.actions.setRedirectionPath({ redirectPath: currentPath }));
    this.router.navigate([routePath.signIn()]);
  }
}
