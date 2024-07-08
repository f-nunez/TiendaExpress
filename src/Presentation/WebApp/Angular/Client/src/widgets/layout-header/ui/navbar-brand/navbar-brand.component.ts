import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'navbar-brand',
  templateUrl: './navbar-brand.component.html',
  styleUrl: './navbar-brand.component.scss'
})
export class NavbarBrandComponent {

  constructor(private router: Router,) {
  }

  onClickBrandLogo() {
    this.router.navigate(['/']);
  }
}
