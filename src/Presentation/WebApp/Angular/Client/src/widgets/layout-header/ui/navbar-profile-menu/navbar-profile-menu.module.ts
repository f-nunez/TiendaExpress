import { NgModule, Type } from '@angular/core';
import { SignOutModule } from '~features/sign-out';
import { SharedModule } from '~shared/shared.module';
import { NavbarProfileMenuComponent } from './navbar-profile-menu.component';

const components: Array<Type<any>> = [
    NavbarProfileMenuComponent
];

@NgModule({
    declarations: [
        ...components
    ],
    imports: [
        SharedModule,
        SignOutModule
    ],
    exports: [
        ...components
    ]
})
export class NavbarProfileMenuModule { }