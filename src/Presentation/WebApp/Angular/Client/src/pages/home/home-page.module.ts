import { NgModule, Type } from '@angular/core';
import { SharedModule } from '~shared/shared.module';
import { HomePageRoutingModule } from './home-page-routing.module';
import { HomePageComponent } from './ui';

const components: Array<Type<any>> = [HomePageComponent];

@NgModule({
  declarations: [
    ...components
  ],
  imports: [
    SharedModule,
    HomePageRoutingModule
  ],
  exports: [
    ...components
  ]
})
export class HomePageModule { }
