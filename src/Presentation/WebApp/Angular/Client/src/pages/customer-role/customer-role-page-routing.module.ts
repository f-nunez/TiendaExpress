import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerRolePageComponent } from './ui';

const routes: Routes = [{ path: '', component: CustomerRolePageComponent }];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CustomerRolePageRoutingModule { }
