import { NgModule, Type } from '@angular/core';
import { SharedModule } from '~shared/shared.module';
import { SignOutDropdownComponent } from './ui';

const components: Array<Type<any>> = [SignOutDropdownComponent];

@NgModule({
    declarations: [
        ...components
    ],
    imports: [
        SharedModule
    ],
    exports: [
        ...components
    ],
})
export class SignOutModule { }
