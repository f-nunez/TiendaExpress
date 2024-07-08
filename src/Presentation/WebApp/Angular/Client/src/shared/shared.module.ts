import { CommonModule } from '@angular/common';
import { NgModule, Type } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PageTitleComponent } from './ui/page-title/page-title.component';

const components: Array<Type<any>> = [PageTitleComponent];

@NgModule({
  declarations: [
    ...components
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [
    ...components,
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: []
})
export class SharedModule { }
