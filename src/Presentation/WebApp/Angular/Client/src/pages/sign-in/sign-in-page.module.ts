import { Type, NgModule } from '@angular/core';
import { SignInModule } from '~features/sign-in';
import { SharedModule } from '~shared/shared.module';
import { SignInPageRoutingModule } from './sign-in-page-routing.module';
import { SignInPageComponent } from './ui/sign-in-page.component';

const components: Array<Type<any>> = [SignInPageComponent];

@NgModule({
  declarations: [
    ...components
  ],
  imports: [
    SharedModule,
    SignInModule,
    SignInPageRoutingModule
  ],
  exports: [
    ...components
  ]
})
export class SignInPageModule { }
