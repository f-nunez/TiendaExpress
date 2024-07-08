import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CatalogPageComponent } from './ui';

const routes: Routes = [{ path: '', component: CatalogPageComponent }];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CatalogPageRoutingModule { }
