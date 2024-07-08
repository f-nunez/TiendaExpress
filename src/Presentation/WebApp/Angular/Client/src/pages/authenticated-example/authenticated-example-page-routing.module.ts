import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthenticatedExamplePageComponent } from './ui';

const routes: Routes = [{ path: '', component: AuthenticatedExamplePageComponent }];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthenticatedExamplePageRoutingModule { }
