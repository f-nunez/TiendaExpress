import { NgModule, Type } from '@angular/core';
import { SharedModule } from '~shared/shared.module';
import { SignInFormComponent } from './ui';

const components: Array<Type<any>> = [SignInFormComponent];

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
export class SignInModule { }
