import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ManagerRolePageComponent } from './ui';

const routes: Routes = [{ path: '', component: ManagerRolePageComponent }];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ManagerRolePageRoutingModule { }
