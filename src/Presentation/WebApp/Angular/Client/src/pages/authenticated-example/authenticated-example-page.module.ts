import { NgModule, Type } from '@angular/core';
import { SharedModule } from '~shared/shared.module';
import { AuthenticatedExamplePageRoutingModule } from './authenticated-example-page-routing.module';
import { AuthenticatedExamplePageComponent } from './ui';

const components: Array<Type<any>> = [AuthenticatedExamplePageComponent];

@NgModule({
  declarations: [
    ...components
  ],
  imports: [
    SharedModule,
    AuthenticatedExamplePageRoutingModule
  ],
  exports: [
    ...components
  ]
})
export class AuthenticatedExamplePageModule { }
