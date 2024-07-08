import { Component } from '@angular/core';
import { ERole } from '~entities/session/model/types';

@Component({
  selector: 'navbar-navigation',
  templateUrl: './navbar-navigation.component.html',
  styleUrl: './navbar-navigation.component.scss'
})
export class NavbarNavigationComponent {
  role: typeof ERole = ERole;
}
