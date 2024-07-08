import { NgModule, Type } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutFooterComponent } from './ui';

const components: Array<Type<any>> = [LayoutFooterComponent];

@NgModule({
  declarations: [
    ...components
  ],
  imports: [
    CommonModule
  ],
  exports: [
    ...components
  ]
})
export class LayoutFooterModule { }
