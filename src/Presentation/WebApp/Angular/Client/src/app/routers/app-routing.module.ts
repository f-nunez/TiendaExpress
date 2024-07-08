import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BaseLayoutComponent } from '~app/layouts';

const routes: Routes = [
  {
    path: '',
    component: BaseLayoutComponent,
    loadChildren: () => import('~app/layouts/base-layout/base-layout.module').then(module => module.BaseLayoutModule)
  }
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }