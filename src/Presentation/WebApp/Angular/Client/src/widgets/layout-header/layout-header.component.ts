import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { sessionModel } from '~entities/session';

@Component({
  selector: 'layout-header',
  templateUrl: './layout-header.component.html',
  styleUrl: './layout-header.component.scss'
})
export class LayoutHeaderComponent {
  isAuthorized$: Observable<boolean>;

  constructor(private readonly store: Store) {
    this.isAuthorized$ = this.store.select(sessionModel.selectors.selectIsAuthorized);
  }
}
