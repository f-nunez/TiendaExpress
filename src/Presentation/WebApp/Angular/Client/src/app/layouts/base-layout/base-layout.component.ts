import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { sessionModel } from '~entities/session';
import { themeModel } from '~entities/theme';

@Component({
  selector: 'base-layout',
  templateUrl: './base-layout.component.html',
  styleUrl: './base-layout.component.scss'
})
export class BaseLayoutComponent {

  constructor(private readonly store: Store) {
    this.store.dispatch(themeModel.actions.getCurrentThemeColor());
    this.store.dispatch(sessionModel.actions.getCurrentUser());
  }
}
