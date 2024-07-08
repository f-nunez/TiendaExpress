import { NgModule, Type } from '@angular/core';
import { SharedModule } from '~shared/shared.module';
import { NotFoundPageRoutingModule } from './not-found-page-routing.module';
import { NotFoundPageComponent } from './ui';

const components: Array<Type<any>> = [NotFoundPageComponent];

@NgModule({
  declarations: [
    ...components
  ],
  imports: [
    SharedModule,
    NotFoundPageRoutingModule
  ],
  exports: [
    ...components
  ]
})
export class NotFoundPageModule { }
