import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { sessionModel } from '~entities/session';

@Component({
  selector: 'navbar-profile-menu',
  templateUrl: './navbar-profile-menu.component.html',
  styleUrl: './navbar-profile-menu.component.scss'
})
export class NavbarProfileMenuComponent {
  username$: Observable<string | undefined>;

  constructor(private readonly store: Store) {
    this.username$ = this.store.select(sessionModel.selectors.selectUsername);
  }
}
