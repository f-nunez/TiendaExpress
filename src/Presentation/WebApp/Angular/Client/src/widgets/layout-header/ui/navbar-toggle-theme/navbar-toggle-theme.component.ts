import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { themeModel } from '~entities/theme';
import { ThemeColor } from '~entities/theme/model/types';

@Component({
  selector: 'navbar-toggle-theme',
  templateUrl: './navbar-toggle-theme.component.html',
  styleUrl: './navbar-toggle-theme.component.scss'
})
export class NavbarToggleThemeComponent {
  currentThemeColor$: Observable<ThemeColor>;
  currentThemeColor: ThemeColor = ThemeColor.Auto;

  items: ThemeColorDropdownItem[];

  currentItem: ThemeColorDropdownItem;

  constructor(private readonly store: Store) {
    this.currentThemeColor$ = this.store.select(themeModel.selectors.selectCurrentThemeColor);

    this.currentThemeColor$.subscribe(themeColor => this.currentThemeColor = themeColor);

    this.items = [
      { iconClass: 'bi-sun-fill', isSelected: this.currentThemeColor == ThemeColor.Light, text: 'Light', themeColor: ThemeColor.Light },
      { iconClass: 'bi-moon-stars-fill', isSelected: this.currentThemeColor == ThemeColor.Dark, text: 'Dark', themeColor: ThemeColor.Dark },
      { iconClass: 'bi-circle-half', isSelected: this.currentThemeColor == ThemeColor.Auto, text: 'Auto', themeColor: ThemeColor.Auto }
    ]

    this.currentItem = {
      iconClass: 'bi-circle-half',
      isSelected: this.currentThemeColor == ThemeColor.Auto,
      text: 'Auto',
      themeColor: ThemeColor.Auto
    }

    this.items.map((item) => {
      if (item.isSelected)
        this.currentItem = item;
    })

    this.setSelectedItem(this.currentThemeColor);
  }

  clearSelectedItems() {
    this.items.map((item) => item.isSelected = false)
  }

  setSelectedItem(themeColor: ThemeColor) {
    this.items.map((item) => {
      if (item.themeColor == themeColor) {
        item.isSelected = true;
        this.currentItem = item;
      }
    })
  }

  onClickDropdownItem(_event: Event, item: ThemeColorDropdownItem) {
    this.store.dispatch(themeModel.actions.changeThemeColor({ themeColor: item.themeColor }));
    this.clearSelectedItems();
    this.setSelectedItem(item.themeColor);
  }
}

export interface ThemeColorDropdownItem {
  iconClass: string
  isSelected: boolean
  text: string
  themeColor: ThemeColor
}