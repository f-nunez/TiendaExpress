import { NgModule, Type } from '@angular/core';
import { LayoutHeaderComponent } from './layout-header.component';
import { NavbarBrandComponent } from './ui/navbar-brand/navbar-brand.component';
import { NavbarDividerComponent } from './ui/navbar-divider/navbar-divider.component';
import { NavbarDummyDropdownComponent } from './ui/navbar-dummy-dropdown/navbar-dummy-dropdown.component';
import { NavbarLoginMenuComponent } from './ui/navbar-login-menu/navbar-login-menu.component';
import { NavbarNavigationComponent } from './ui/navbar-navigation/navbar-navigation.component';
import { NavbarSocialLinksComponent } from './ui/navbar-social-links/navbar-social-links.component';
import { NavbarToggleThemeComponent } from './ui/navbar-toggle-theme/navbar-toggle-theme.component';
import { NavbarProfileMenuModule } from './ui/navbar-profile-menu/navbar-profile-menu.module';
import { SharedModule } from '~shared/shared.module';
import { RouterModule } from '@angular/router';
import { RoleBasedAccessControlDirective } from '~entities/session/model/directives';

const components: Array<Type<any>> = [
  LayoutHeaderComponent,
  NavbarBrandComponent,
  NavbarDividerComponent,
  NavbarDummyDropdownComponent,
  NavbarLoginMenuComponent,
  NavbarNavigationComponent,
  NavbarSocialLinksComponent,
  NavbarToggleThemeComponent
];

export const directives: Array<Type<any>> = [
  RoleBasedAccessControlDirective
];

@NgModule({
  declarations: [
    ...components,
    ...directives
  ],
  imports: [
    SharedModule,
    NavbarProfileMenuModule,
    RouterModule
  ],
  exports: [
    ...components
  ]
})
export class LayoutHeaderModule { }
