import { NgModule, Type } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ManagerRolePageComponent } from './ui';
import { SharedModule } from '~shared/shared.module';
import { ManagerRolePageRoutingModule } from './manager-role-page-routing.module';

const components: Array<Type<any>> = [ManagerRolePageComponent];

@NgModule({
  declarations: [
    ...components
  ],
  imports: [
    SharedModule,
    ManagerRolePageRoutingModule
  ],
  exports: [
    ...components
  ]
})
export class ManagerRolePageModule { }
