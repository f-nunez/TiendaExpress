import { NgModule } from '@angular/core';
import { BaseLayoutComponent } from './base-layout.component';
import { BaseLayoutRoutingModule } from './base-layout-routing.module';
import { LayoutFooterModule } from '~widgets/layout-footer/layout-footer.module';
import { LayoutHeaderModule } from '~widgets/layout-header';

@NgModule({
  declarations: [
    BaseLayoutComponent
  ],
  imports: [
    BaseLayoutRoutingModule,
    LayoutFooterModule,
    LayoutHeaderModule
  ],
  exports: [
    BaseLayoutComponent
  ]
})
export class BaseLayoutModule { }
