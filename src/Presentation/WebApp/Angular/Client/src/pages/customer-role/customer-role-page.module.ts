import { NgModule, Type } from '@angular/core';
import { SharedModule } from '~shared/shared.module';
import { CustomerRolePageRoutingModule } from './customer-role-page-routing.module';
import { CustomerRolePageComponent } from './ui';

const components: Array<Type<any>> = [CustomerRolePageComponent];

@NgModule({
  declarations: [
    ...components
  ],
  imports: [
    SharedModule,
    CustomerRolePageRoutingModule
  ],
  exports: [
    ...components
  ]
})
export class CustomerRolePageModule { }
