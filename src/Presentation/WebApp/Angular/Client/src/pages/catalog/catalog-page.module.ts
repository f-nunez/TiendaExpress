import { NgModule, Type } from '@angular/core';
import { SharedModule } from '~shared/shared.module';
import { CatalogPageRoutingModule } from './catalog-page-routing.module';
import { CatalogPageComponent } from './ui';

const components: Array<Type<any>> = [CatalogPageComponent];

@NgModule({
  declarations: [
    ...components
  ],
  imports: [
    SharedModule,
    CatalogPageRoutingModule
  ],
  exports: [
    ...components
  ]
})
export class CatalogPageModule { }
